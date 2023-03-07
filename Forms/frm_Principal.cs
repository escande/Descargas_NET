using Descargas_NET.Helpers;
using Descargas_NET.Models;
using Descargas_NET.Properties;
using Descargas_NET.Services;
using Descargas_NET.Services.Hub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargas_NET.Forms
{
    public partial class Frm_Principal : Form
    {
        private readonly IRepositorio _repositorio;
        private readonly IWaitFunction _wait;
        private readonly IHubClient _hub;
        private frm_EligeConf formEligeConf;
        //private readonly bool _enCarga = false;
        private readonly Log _log;
        private Mutex mutex;
        private bool created;
        private bool _enConfig = false;
        private bool _enArranque = true;
        readonly string _endPoint = string.Empty;

        public Frm_Principal(IRepositorio repositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
            _wait = Injector.GetService<IWaitFunction>();
            _hub = Injector.GetService<IHubClient>();

            _hub.Hub_ConexionChange += Socket_ConexionChange;
            _hub.Hub_DataReceive += Connection_DataReceive;

            _log = new Log("Form_Principal");

            _endPoint = "api/versiones/Descargas";

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
                await ComprobarVersionSoftware();

                tsHub.BackColor = Color.Red;

                timer1.Enabled = true;

                await Task.Delay(1000);
                _wait.Close();
                this.Focus();
            }
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalSettings.MSCommNet.StatusCom == StatusCom.Conected)
            {
                GlobalSettings.MSCommNet.CerrarPuerto();
            }

            GlobalSettings.MSCommNet.Dispose();
        }

        private void AbrirPuertoCom()
        {
            try
            {
                if (GlobalSettings.MSCommNet.StatusCom == StatusCom.Conected)
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

        private async Task ComprobarVersionSoftware()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}{_endPoint}"
                };

                var resp = await _repositorio.Get<VersionesActuales>(url.ToString());

                if (!resp.Error)
                {
                    tsCloud.BackColor = Color.GreenYellow;
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

                            if (respAnota.Error)
                            {
                                _log.EscribirEnFichero($"No se pudo actualizar a la versión {GlobalSettings.VersionSoftware}");
                            }
                        }
                        //#endif
                    }
                }
                else
                {
                    tsCloud.BackColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ComprobarVersionSoftware : {ex.Message}");
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

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                tsHora.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
                tsUser.Text = GlobalSettings.UsuarioApp;

                await ComprobarVersionSoftware();

            }
            catch (Exception ex) { _log.EscribirEnFichero($"ERROR en Timer1 : {ex.Message}"); }
            finally { timer1.Enabled = true; }
        }

        private void Socket_ConexionChange(object sender, bool e)
        {
            this.BeginInvoke(new Action(() =>
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

        private void ConectionComChange(bool e)
        {
            this.BeginInvoke((new Action(() =>
            {
                tsSerialPort.BackColor = e ? Color.GreenYellow : Color.Red;
                tsSerialPort.Text = $"MSCOMM {GlobalSettings.PuertoCom}";

                if (!e)
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

        private void BtReposiciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(GlobalSettings.UsuarioApp))
                {

                    _hub.Hub_DataReceive -= Connection_DataReceive;

                    GlobalSettings.formPrincReposiciones = new frm_PrincReposiciones(this);
                    GlobalSettings.formPrincReposiciones.Show();

                    this.Hide();
                }
                else
                {
                    Aviso.Msg("Debes de valida el usuario primero", false);
                }
            }
            catch { }//Me la 
        }

        private void BtDescargas_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(GlobalSettings.UsuarioApp))
                {

                    _hub.Hub_DataReceive -= Connection_DataReceive;

                    GlobalSettings.formPrincDescargas = new FrmPrincDescargas(this);
                    GlobalSettings.formPrincDescargas.Show();

                    this.Hide();
                }
                else
                {
                    Aviso.Msg("Debes de valida el usuario primero", false);
                }
            }
            catch { }//Me la 
        }

        private async void BtLogin_Click(object sender, EventArgs e)
        {
            if (_hub.Conexion == EstadoConexion.conectado)
            {
                await _hub.Desconectar();
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
                    await _hub.Conectar(GlobalSettings.UsuarioApp, token, puesto);
                }
            }
        }

        private void BtSettings_Click(object sender, EventArgs e)
        {
            formEligeConf = new frm_EligeConf();
            formEligeConf.ShowDialog();
            formEligeConf.Dispose();
            formEligeConf = null;

            var dialogResult = Aviso.Msg("¿DESEAS CARGAR LA CONFIGURACIÓN DE NUEVO?", true);

            if (dialogResult == DialogResult.OK)
            {
                _enConfig = true;
                CargarParametros();
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Principal_VisibleChanged(object sender, EventArgs e)
        {
            if (!_enArranque && this.Visible)
            {
                _hub.Hub_DataReceive += Connection_DataReceive;
            }

            if (_enArranque) _enArranque = false;
        }
    }
}
