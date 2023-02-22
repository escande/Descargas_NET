using Descargas_NET.Models;
using Descargas_NET.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Descargas_NET.Helpers;
using Descargas_NET.Properties;
using System.Threading;
using Descargas_NET.Services.Hub;

namespace Descargas_NET.Forms
{
    public partial class frm_Principal : Form
    {
        private readonly IRepositorio _repositorio;
        private readonly IWaitFunction _wait;
        private readonly IHubClient hub;
        private List<DescargaMuelles> _muelles;
        private frm_EligeConf formEligeConf;
        private const string _endPoint = "api/descargamuelles";
        private bool _enCarga = false;
        private Log _log;
        private Mutex mutex;
        private bool created;
        private int _cuentaTicks;
        private bool _enConfig = false;
        private bool _enArranque = true;

        public frm_Principal(IRepositorio repositorio)
        {
            InitializeComponent();

            this._repositorio = repositorio;
            this._wait = Injector.GetService<IWaitFunction>();
            this.hub = Injector.GetService<IHubClient>();

            this.hub.Hub_ConexionChange += Socket_ConexionChange;
            hub.Hub_DataReceive += Connection_DataReceive;

            _log = new Log("Form_Principal");

            GlobalSettings.UsuarioApp = "";
            GlobalSettings.MSCommNet = new MSCommNet(GlobalSettings.PuertoCom, GlobalSettings.PuertoCom);
            GlobalSettings.MSCommNet._comm_ConexionChange += ConectionComChange;
        }

        private async void Frm_Principal_Load(object sender, EventArgs e)
        {
            mutex = new Mutex(false, "DescargasApp", out created);
            if (!created)
            {
                _log.EscribirEnFichero("Another instance of this application is already running");
                Aviso.Msg("Hay otra instancia de la APP en en funcionamiento", false);
                this.Close();
            }
            else
            {
                _wait.Show(this, "CARGANDO...");
                this.Top = 0;
                this.Left = -5;
                tsVersion.Text = "Version: " + GlobalSettings.VersionSoftware;
                CargarParametros();
                await ObtenerDescargas();
                timer1.Enabled = true;
                //CargarRegistrosMock();

                await Task.Delay(1000);
                _wait.Close();
                this.Focus();
            }
        }

        private void CargarParametros()
        {
            GlobalSettings.BASE_SERVER_URL = Settings.Default.Api_WEBAPI_URL;
            GlobalSettings.VirtualHost = Settings.Default.Api_WEBAPI_VirtualHost;

            GlobalSettings.PuertoCom = Settings.Default.COM_MSCOMM_Puerto;
            GlobalSettings.Baudrate = Settings.Default.COM_MSCOMM_BaudRate;

            AbrirPuertoCom();
        }

        private void AbrirPuertoCom()
        {
            try
            {
                if(GlobalSettings.MSCommNet.StatusCom == StatusCom.Conected)
                {
                    GlobalSettings.MSCommNet.CerrarPuerto();
                }

                GlobalSettings.MSCommNet.Puerto = GlobalSettings.PuertoCom;
                GlobalSettings.MSCommNet.BaudRate = GlobalSettings.Baudrate;
                GlobalSettings.MSCommNet.AbrirPuerto();
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR Abriendo el Puerto COM: {GlobalSettings.PuertoCom} \n {ex.Message}");
                Aviso.Msg($"ERROR Abriendo el Puerto COM: {GlobalSettings.PuertoCom} \n {ex.Message}", false);
            }
        }

        private async Task ObtenerDescargas()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}{_endPoint}"
                };

                var resp = await _repositorio.Get<List<DescargaMuelles>>(url.ToString());

                if (!resp.Error)
                {
                    tsCloud.BackColor = Color.GreenYellow;
                    _muelles = resp.Response;

                    var naves = _muelles.GroupBy(x => x.Nave).OrderBy(x => x.Key).ToList();
                    dgv.Rows.Clear();

                    if (naves.Count > 0)
                    {
                        int i = 0;
                        _enCarga = true;
                        foreach (var item in naves)
                        {
                            dgv.Rows.Add();
                            dgv.Rows[i].Cells["Id"].Value = item.Key;
                            dgv.Rows[i].Cells["Nave"].Value = $"NAVE {item.Key}";
                            i++;
                        }

                        dgv.Rows[0].Selected = true;
                        _enCarga = false;
                    }
                }
                else
                {
                    tsCloud.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerDescargas : {ex.Message}");
            }
        }

        private async Task ComprobarVersionSoftware()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/versiones/Descargas"
                };

                var resp = await _repositorio.Get<VersionesActuales>(url.ToString());

                if (!resp.Error)
                {
                    var version = resp.Response;

                    if (version.Version > GlobalSettings.VersionSoftware)
                    {
                        Aviso.Msg("La versión de software instalada en este equipo es inferior a la versión del servidor. \n"
                                    + "Contacte con su responsable para obtener la versión más reciente.\n"
                                    + $"APP: {GlobalSettings.VersionSoftware}, Servidor: {version.Version}", false);
                    }
                    else
                    {
//#if DEBUG
                        if (GlobalSettings.VersionSoftware > version.Version)
                        {
                            url.Path = $"{GlobalSettings.VirtualHost}api/versiones";

                            version.Version = GlobalSettings.VersionSoftware;

                            var respAnota = await _repositorio.Put(url.ToString(), version);

                            if(respAnota.Error)
                            {
                                _log.EscribirEnFichero($"No se pudo actualizar a la versión {GlobalSettings.VersionSoftware}");
                            }
                        }    
//#endif
                    }
                }

            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ComprobarVersionSoftware : {ex.Message}");
            }
        }

        private void BorrarDatos()
        {
            dgv.Rows.Clear();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtSettings_Click(object sender, EventArgs e)
        {
            formEligeConf = new frm_EligeConf();
            formEligeConf.ShowDialog();
            formEligeConf.Dispose();
            formEligeConf = null;

            var dialogResult = Aviso.Msg("¿DESEAS CARGAR LA CONFIGURACIÓN DE NUEVO?", true);

            if(dialogResult == DialogResult.OK)
            {
                _enConfig = true;
                CargarParametros();
                await ObtenerDescargas();
            }
        }

        private void BtDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(GlobalSettings.UsuarioApp))
                {
                    var currentIndex = dgv.SelectedRows[0].Index;
                    var nave = int.Parse(dgv.Rows[currentIndex].Cells["Id"].Value.ToString());

                    hub.Hub_DataReceive -= Connection_DataReceive;

                    GlobalSettings.formListDescargas = new frm_ListDescargas(nave, this);
                    GlobalSettings.formListDescargas.Show();

                    this.Hide();
                }
                else
                {
                    Aviso.Msg("Debes de valida el usuario primero", false);
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void ConectionComChange(bool e)
        {
            this.BeginInvoke((new Action(() =>
            {
                tsSerialPort.BackColor = e ? Color.GreenYellow : Color.Red;
                tsSerialPort.Text = $"MSCOMM {GlobalSettings.PuertoCom}";

                if(!e)
                {
                    if (!_enConfig)
                    {
                        _log.EscribirEnFichero($"ERROR Abriendo el Puerto COM: {GlobalSettings.PuertoCom}");
                        Aviso.Msg($"ERROR Abriendo el Puerto COM: {GlobalSettings.PuertoCom} ", false);
                    }
                    else
                        _enConfig = false;
                }
            })));
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                tsHora.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
                tsUser.Text = GlobalSettings.UsuarioApp;

                _cuentaTicks++;
                if (_cuentaTicks >= 4)
                {
                    _cuentaTicks = 0;
                    BorrarDatos();
                    await ObtenerDescargas();
                    await ComprobarVersionSoftware();
                }

                if(_cuentaTicks >= 1 && _enConfig)
                {
                    _enConfig = false;
                }

            }
            catch (Exception ex) { _log.EscribirEnFichero($"ERROR en Timer1 : {ex.Message}"); }
            finally { timer1.Enabled = true; }
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalSettings.MSCommNet.StatusCom == StatusCom.Conected)
            {
                GlobalSettings.MSCommNet.CerrarPuerto();
            }

            GlobalSettings.MSCommNet.Dispose();
        }

        private async void BtLogin_Click(object sender, EventArgs e)
        {
            if(hub.Conexion == EstadoConexion.conectado)
            {
                await hub.Desconectar();
            }

            GlobalSettings.formLogin = new frm_Login();
            var dialog = GlobalSettings.formLogin.ShowDialog();

            var token = GlobalSettings.formLogin.Token;
            var puesto = GlobalSettings.formLogin.Puesto;

            GlobalSettings.formLogin.Dispose();
            GlobalSettings.formLogin = null;

            if (dialog == DialogResult.OK)
            {
                tsUser.Text = GlobalSettings.UsuarioApp;

                if (Settings.Default.Api_WEBAPI_AvisosActivos)
                {
                    await hub.Conectar(GlobalSettings.UsuarioApp, token, puesto);
                }
            }
        }

        //Para pruebas sin datos o datos ficticios
        //private void CargarRegistrosMock()
        //{
        //    _enCarga = true;

        //    _muelles = new List<DescargaMuelles>
        //    {
        //        new DescargaMuelles{Nave = "1",Muelle = "1"},
        //        new DescargaMuelles{Nave = "2",Muelle = "2"},
        //        new DescargaMuelles{Nave = "3",Muelle = "3"},
        //        new DescargaMuelles{Nave = "4",Muelle = "4"},
        //    };

        //    int i = 0;
        //    foreach (var item in _muelles)
        //    {
        //        dgv.Rows.Add();
        //        dgv.Rows[i].Cells["Id"].Value = item.Nave;
        //        dgv.Rows[i].Cells["Nave"].Value = item.Muelle;
        //        i++;
        //    }

        //    dgv.Rows[0].Selected = true;
        //    _enCarga = false;
        //}

        #region eventos_botones
        private void BtBackAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    dgv.Rows[0].Selected = true;
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    var currentIndex = dgv.SelectedRows[0].Index;//dgv.SelectedRows.Se(r => r.Index);//dgv.CurrentCell.RowIndex;

                    if (currentIndex > 0)
                    {
                        var index = dgv.Rows.GetPreviousRow(currentIndex, new DataGridViewElementStates());
                        dgv.Rows[index].Selected = true;

                    }
                    else
                    {
                        BtFowardAll_Click(sender, e);
                    }
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void BtFoward_Click(object sender, EventArgs e)
        {
            try
            { 
                if (dgv.Rows.Count > 0)
                {
                    var currentIndex = dgv.SelectedRows[0].Index;
                    var ultima = dgv.Rows.Count - 1;
                
                    if (currentIndex < ultima)
                    {
                        var index = dgv.Rows.GetNextRow(currentIndex, new DataGridViewElementStates());
                        dgv.Rows[index].Selected = true;
                    }
                    else
                    {
                        BtBackAll_Click(sender, e);
                    }
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void BtFowardAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    var ultima = dgv.Rows.Count - 1;
                    dgv.Rows[ultima].Selected = true;
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0 && !_enCarga)
                {
                    var index = e.RowIndex;
                    dgv.Rows[index].Selected = true;
                }
            }
            catch { }//ignoro los errores
        }

        private void Socket_ConexionChange(object sender, bool e)
        {
            this.BeginInvoke(new Action (() =>
            {

                tsHub.BackColor = e ? Color.GreenYellow : Color.Red;

            }));
        }

        private void Connection_DataReceive(object sender, string e)
        {
            this.BeginInvoke(new Action(() =>
            {

                Aviso.Msg(e, false);

            }));
        }
        #endregion

        private void frm_Principal_VisibleChanged(object sender, EventArgs e)
        {
            if (!_enArranque && this.Visible)
            {
                hub.Hub_DataReceive += Connection_DataReceive;
            }

            if (_enArranque) _enArranque = false;
        }
    }
}
