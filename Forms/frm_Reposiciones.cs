using Descargas_NET.Helpers;
using Descargas_NET.Models;
using Descargas_NET.Services;
using Descargas_NET.Services.Hub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargas_NET.Forms
{
    public partial class FrmReposiciones : Form
    {
        private readonly int _nave;
        private readonly string _sector;
        private readonly frm_PrincReposiciones _parent;
        private readonly IRepositorio _repositorio;
        private readonly IHubClient hub;
        private List<Reposicioneslineas> _reposicioneslineas;
        private const string _endPoint = "api/reposicioneslineas";
        private bool _enCarga = false;
        private bool _enObtener = false;
        private readonly Log _log;
        Frm_Incidencias _formIncidencias;
        frm_Embalajes _formEmbalajes;
        //private ContextMenuStrip _menu;
        //private ToolStripMenuItem _itemAlerta0;
        //private ToolStripMenuItem _itemMinimo;
        //private ToolStripMenuItem _incidencia;

        public FrmReposiciones(int nave, string sector, frm_PrincReposiciones parent)
        {
            InitializeComponent();

            _nave = nave;
            _sector = sector;
            _parent = parent;
            _repositorio = Injector.GetService<IRepositorio>();
            hub = Injector.GetService<IHubClient>();
            hub.Hub_DataReceive += Connection_DataReceive;
            _log = new Log("Form_Reposiciones");
            //GlobalSettings.MSCommNet._comm_DataReceive += DatosRecibidosEscaner;
            AsignarEventComm();
        }

        private async void Frm_Reposiciones_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = -5;
            //this.WindowState = FormWindowState.Maximized;

            if (_nave == 2)
            {
                btEmbalajes.Visible = true;
                lbCabecera.Width = 640;
            }
            BorrarDatos();
            await ObtenerReposicionesLinea();
            timer1.Interval = 30000;
            timer1.Enabled = true;
        }

        private void Frm_Reposiciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalSettings.MSCommNet._comm_DataReceive -= DatosRecibidosEscaner;
        }

        private async Task ObtenerReposicionesLinea()
        {
            try
            {
                if (!_enObtener)
                {
                    _enObtener = true;

                    dgv.Rows.Clear();

                    var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                    {
                        Path = $"{GlobalSettings.VirtualHost}{_endPoint}/listadonaves/{_nave}",
                        Query = $"Sector={_sector}"
                    };

                    var resp = await _repositorio.Get<List<Reposicioneslineas>>(url.ToString());

                    if (!resp.Error)
                    {
                        _reposicioneslineas = resp.Response;


                        if (_reposicioneslineas.Count > 0)
                        {
                            int i = 0;
                            _enCarga = true;
                            foreach (var item in _reposicioneslineas)
                            {
                                var material = await ObtenerMaterial(item.ReposicionesLineasReferenciaSap);
                                dgv.Rows.Add();
                                dgv.Rows[i].Cells["Reposicion"].Value = item.ReposicionesLineasId;
                                dgv.Rows[i].Cells["Sap"].Value = item.ReposicionesLineasReferenciaSap;
                                dgv.Rows[i].Cells["Ubicacion"].Value = item.ReposicionesLineasUbicacionAlmpId;
                                dgv.Rows[i].Cells["IDK"].Value = material.MaterialesPartNumber;//item.ReposicionesLineasIdKanban;
                                dgv.Rows[i].Cells["TContenedor"].Value = item.ReposicionesLineasUbicacionAlmpTipo;
                                dgv.Rows[i].Cells["Sector"].Value = item.ReposicionesLineasSector;
                                i++;
                            }

                            dgv.Rows[0].Selected = true;
                            _enCarga = false;

                            await RellenarDatos(0);

                        }
                    }
                    else
                    {
                        _log.EscribirEnFichero($"ERROR en ObtenerReposicionesLinea : {resp.HttpResponseMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerReposicionesLinea : {ex.Message}");
            }
            finally { _enObtener = false; }
        }

        private async Task<Materiales> ObtenerMaterial(int sap)
        {
            Materiales material = new();
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/materiales/P{sap}"
                };

                var resp = await _repositorio.Get<Materiales>(url.ToString());

                if (!resp.Error)
                {
                    material = resp.Response;
                }

                return material;
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerMaterial : {ex.Message}");
                return null;
            }
        }

        private async Task RellenarDatos(int index)
        {
            var reposicion = _reposicioneslineas.Where(x => x.ReposicionesLineasId.ToString() == dgv.Rows[index].Cells["Reposicion"].Value.ToString()).FirstOrDefault();
            var material = await ObtenerMaterial(reposicion.ReposicionesLineasReferenciaSap);
            lbPN.Text = material.MaterialesPartNumber.Replace("-", "").Replace(" ","");
            lbSap.Text = reposicion.ReposicionesLineasReferenciaSap.ToString();
            lbDescripcion.Text = material.MaterialesDescripcion;
            lbUbicacion.Text = reposicion.ReposicionesLineasUbicacionAlmpId;
        }

        private void BorrarDatos()
        {
            lbPN.Text = "";
            lbSap.Text = "";
            lbDescripcion.Text = "";
            lbUbicacion.Text = "";
        }

        private async void DatosRecibidosEscaner(LecturaOdette odette)
        {
            try
            {
                
                this.BeginInvoke(new Action(()=> 
                {
                    lbEscaner.Text = odette.Lectura;
                }));

                if (odette.CodeType == CodeType.PDF417 || odette.CodeType == CodeType.Code_QR)
                {
                    var pnLimpio = "P" + odette.Campo_P.Replace("-", "").Replace(" ", "");
                    var sap = await ObtenerSap(pnLimpio);

                    var reposicion = _reposicioneslineas.Where(x => x.ReposicionesLineasReferenciaSap == sap)
                                                        .FirstOrDefault();

                    if(reposicion != null)
                    {
                        var dialog = Aviso.Msg($"¿Deseas reponer el material? \nSAP: {sap} \n"
                                                                        + $"PN: {odette.Campo_P}\n"
                                                                        + $"Serie: {odette.Campo_S}"
                                                                        , true);

                        if (dialog == DialogResult.OK)
                        {
                           await ReponerMaterial(reposicion, sap, false, odette);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en DatosRecibidosEscaner: {ex.Message}");
            }
        }

        private async Task<int> ObtenerSap(string pn)
        {
            int mResponse = -1;
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/materiales/{pn}"
                };

                var resp = await _repositorio.Get<Materiales>(url.ToString());

                if (!resp.Error)
                {
                    var sap = resp.Response;

                    mResponse = sap.MaterialesReferenciaSap;
                }

                return mResponse;
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerSap: {ex.Message}");
                return -1;
            }
        }

        private async Task ReponerMaterial(Reposicioneslineas reposicion, int sap, bool anular, LecturaOdette odette = null)
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}{_endPoint}"
                };

                //Cierro la reposición
                reposicion.ReposicionesLineasFechaInicio = DateTime.Now;
                reposicion.ReposicionesLineasFechaFin = DateTime.Now;
                reposicion.ReposicionesLineasCliente = GlobalSettings.UsuarioApp;

                if(odette != null && !anular)
                {
                    var detalles = new ReposicionesMaterial
                    {
                        ReposicionId = reposicion.ReposicionesLineasId,
                        CampoP = odette.Campo_P,
                        CampoQ = odette.Campo_Q,
                        CampoV = odette.Campo_V,
                        CampoS = odette.Campo_S,
                        CampoU = odette.Campo_U,
                        CampoH = odette.Campo_H,
                        CampoD = odette.Campo_D,
                        CampoN = odette.Campo_N,
                        CampoB = odette.Campo_B
                    };

                    if(!string.IsNullOrEmpty(odette.Campo_A))
                    {
                        detalles.CampoS = odette.Campo_A;
                    }

                    reposicion.ReposicionMaterial = detalles;
                }

                var respPost = await _repositorio.Put(url.ToString(), reposicion);

                //Si la perra caza a crear la petición
                if (!respPost.Error)
                {
                    //Elimino la reposición del grid y de la lista
                    _reposicioneslineas.Remove(reposicion);    
                    

                    dgv.BeginInvoke(new Action(async () =>
                    {
                        try
                        {
                            //int indexRow = -1;
                            //foreach (DataGridViewRow row in dgv.Rows)
                            //{
                            //    if (row.Cells["Sap"].Value.ToString() == reposicion.ReposicionesLineasReferenciaSap.ToString())
                            //    {
                            //        indexRow = row.Index;

                            //    }
                            //}
                            //var laRow = dgv.Rows[indexRow];
                            //dgv.Rows.Remove(laRow);
                            BorrarDatos();
                            await ObtenerReposicionesLinea();
                        }
                        catch 
                        { 
                            _log.EscribirEnFichero("Plim algo paso actualizando el griden ReponerMaterial"); 
                        }

                        //if(dgv.Rows.Count == 0)
                        //{
                        //    BorrarDatos();
                        //}
                    }));

                    //Solo si estoy en Nave 1
                    if (_nave == 1 && !anular)
                    {
                        url.Path = $"{GlobalSettings.VirtualHost}api/peticiones/{sap}";

                        //Compruebo peticiones pendientes
                        var respPendiente = await _repositorio.Get<Peticionesalmp>(url.ToString());

                        if (!respPendiente.Error)
                        {

                            var peticionPendiente = respPendiente.Response;
                            //Doy la opción de crear la petición si ya existe alguna, plim... ,-)
                            if (peticionPendiente != null)
                            {
                                var dialog = Aviso.Msg($"Ya existe una Petición Pendiente del SAP: {sap} \n"
                                                        + "¿Desea continuar Generando la Petición?", true);

                                if(dialog == DialogResult.OK)
                                {
                                    await CrearPeticion(sap, reposicion.ReposicionesLineasId);
                                }
                            }
                            else
                            {
                                await CrearPeticion(sap, reposicion.ReposicionesLineasId);
                            }
                        }
                        else
                        {
                            _log.EscribirEnFichero("Error reposiciones, no se han obtenido datos de las reposiciones pendientes");
                            Aviso.Msg("No se han podido obtener las reposiciones pendientes, avise a IT para revisar", false);
                        }
                    }
                    else
                    {
                        //Si es anulado anotamos en LogReposiciones anuladas
                        if(anular)
                        {
                            await AnotarLogReposicionesAnuladas(reposicion.ReposicionesLineasId, sap);
                        }
                    }
                }
                else
                {
                    _log.EscribirEnFichero($"Se ha producido un error cerrando la Reposición con ID: {reposicion.ReposicionesLineasId} \n"
                                            + "Pruebe más tarde o notifique el error");
                    Aviso.Msg($"Se ha producido un error cerrando la Reposición con ID: {reposicion.ReposicionesLineasId} \n"
                                            + "Pruebe más tarde o notifique el error", false); ;
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ReponerMaterial: {ex.Message}");
            }
        }

        private async Task AnotarLogReposicionesAnuladas(int idReposicion, int sap)
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/logReposicionesAnuladas"
                };

                var log = new Logreposicionesanuladas
                {
                    LogReposicionesAnuladasIdReposicion = idReposicion,
                    LogReposicionesAnuladasSap = sap,
                    LogReposicionesAnuladasMotivo = "Anulada",
                    LogReposicionesAnuladasCliente = GlobalSettings.UsuarioApp,
                    LogReposicionesAnuladasFecha = DateTime.Now
                };

                var resp = await _repositorio.Post(url.ToString(), log);

                if(resp.Error)
                {
                    _log.EscribirEnFichero("Se produjo un error anotando en LogReposicionesAnuladas");
                    Aviso.Msg("Se produjo un error anotando en LogReposicionesAnuladas", false);
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en AnotarLogReposicionesAnuladas: {ex.Message}");
            }
        }

        public async Task CrearPeticion(int sap, int reposicionId)
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/ejes/{sap}"
                };

                var respEjes = await _repositorio.Get<TblEjes>(url.ToString());

                if (!respEjes.Error)
                {
                    var eje = respEjes.Response;

                    //Compruebo que en la tabla Ejes exista el SAP antes de crear la Petición
                    if(eje == null)
                    {

                        var peticion = new Peticionesalmp
                        {
                            PeticionesAlmpIdReposicion = reposicionId,
                            PeticionesAlmpReferenciaSap = sap,
                            PeticionesAlmpManual = true,
                            PeticionesAlmpCliente = GlobalSettings.UsuarioApp,
                            PeticionesAlmpFechaPeticion = DateTime.Now
                        };

                        url.Path = $"{GlobalSettings.VirtualHost}api/peticiones/";

                        var respPost = await _repositorio.Post(url.ToString(), peticion);

                        if(respPost.Error)
                        {
                            _log.EscribirEnFichero($"Se ha producido un error generando la Petición para la reposición ID: {reposicionId}");
                            Aviso.Msg($"Se ha producido un error generando la Petición para la reposición ID: {reposicionId} \n"
                                            + "Trate de generarla manualmente o notifique el error", false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en CrearPeticion: {ex.Message}");
            }
        }

        private async Task CrearAlerta(int sap, bool esCero)
        {
            try
            {
                var dialog = Aviso.Msg($"¿Deseas crear la alerta {(!esCero ? "CERO" : "MINIMO")}?", true);

                if (dialog == DialogResult.OK)
                {
                    var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                    {
                        Path = $"{GlobalSettings.VirtualHost}api/panelalertas"
                    };

                    var alertaCero = new PanelAlertas
                    {
                        PanelAlertasSap = sap,
                        PanelAlertasReferencia = lbPN.Text,
                        PanelAlertasFechaEntrada = DateTime.Now,
                        PanelAlertasTipo = esCero,
                        PanelAlertasCliente = GlobalSettings.UsuarioApp
                    };

                    var respCero = await _repositorio.Post(url.ToString(), alertaCero);

                    if (respCero.Error)
                    {
                        _log.EscribirEnFichero($"Se ha producido un error creando la Alerta Cero para el SAP: {sap}");
                        Aviso.Msg($"Se ha producido un error creando la Alerta Cero para el SAP: {sap}", false);
                    }
                    else
                    {
                        Aviso.Msg($"Alerta Cero creada correctamente para el SAP: {sap}", false);
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en CrearAlerta: {ex.Message}");
            }
        }

        private async Task<bool> ComprobarAlertaAbierta(int sap)
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/panelalertas/alertaporsap/{sap}"
                };

                var respAlerta = await _repositorio.Get<PanelAlertas>(url.ToString());

                //Si hay alerta entro a evaluar, si es minimo la cierro y abro una cero
                if (respAlerta.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var alerta = respAlerta.Response;

                    if(alerta.PanelAlertasTipo.Value)
                    {
                        //Si existe alerta minimo la cierro
                        alerta.PanelAlertasFechaFin = DateTime.Now;
                        alerta.PanelAlertasObservaciones = "AUTOMATICO RINHO";

                        url.Path  = $"{GlobalSettings.VirtualHost}api/panelalertas/";

                        var respupdate = await _repositorio.Put(url.ToString(), alerta);
                    }
                    else
                    {
                        //Si es 0 pues respondo que ya existe una Alerta 0
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ComprobarAlertaAbierta: {ex.Message}");
                return false;
            }
        }

        private async void BtAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    
                    var currentIndex = dgv.SelectedRows[0].Index;

                    var sap = dgv.Rows[currentIndex].Cells["Sap"].Value.ToString();

                    var dialo = Aviso.Msg($"¿Desea anular la reposición con SAP: {sap}? ", true);

                    if (dialo == DialogResult.OK)
                    {
                        var reposicion = _reposicioneslineas.Where(x => x.ReposicionesLineasReferenciaSap.ToString() == sap).FirstOrDefault();

                        await ReponerMaterial(reposicion, int.Parse(sap), true);
                    }
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private async void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.BorrarDatos();
            await _parent.ObtenerReposicionesAgrupadas();
            _parent.Show();
        }

        private void Connection_DataReceive(object sender, string e)
        {
            this.BeginInvoke(new Action(() =>
            {

                Aviso.Msg(e, false);

            }));
        }

        #region eventos_botones_navegacion
        private async void BtBackAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    dgv.Rows[0].Selected = true;
                    await RellenarDatos(0);
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private async void BtBack_Click(object sender, EventArgs e)
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
                        await RellenarDatos(index);

                    }
                    else
                    {
                        BtFowardAll_Click(sender, e);
                    }
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private async void BtFoward_Click(object sender, EventArgs e)
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
                        await RellenarDatos(index);
                    }
                    else
                    {
                        BtBackAll_Click(sender, e);
                    }
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private async void BtFowardAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    var ultima = dgv.Rows.Count - 1;
                    dgv.Rows[ultima].Selected = true;
                    await RellenarDatos (ultima);
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private async void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0 && !_enCarga)
                {
                    var index = e.RowIndex;
                    dgv.Rows[index].Selected = true;
                    await RellenarDatos(index);
                }
            }
            catch { }//ignoro los errores
        }
        #endregion

        public void AsignarEventComm()
        {
            GlobalSettings.MSCommNet._comm_DataReceive += DatosRecibidosEscaner;
        }

        private void BtEmbalajes_Click(object sender, EventArgs e)
        {
            _formEmbalajes = new frm_Embalajes(this);
            _formEmbalajes.Show();

            this.Hide();
            GlobalSettings.MSCommNet._comm_DataReceive -= DatosRecibidosEscaner;
        }

        private async void BtAlerta0_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {

                    var currentIndex = dgv.SelectedRows[0].Index;

                    var sap = dgv.Rows[currentIndex].Cells["Sap"].Value.ToString();

                    if (await ComprobarAlertaAbierta(int.Parse(sap)) == false)
                    {
                        await CrearAlerta(int.Parse(sap), false);
                    }
                    else
                    {
                        Aviso.Msg($"Ya existe una Alerta 0 para el SAP: {sap}", false);
                    }
                }
            }
            catch { }
        }

        private async void BtAlertaMinimo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {

                    var currentIndex = dgv.SelectedRows[0].Index;

                    var row = dgv.Rows[currentIndex];

                    var sap = row.Cells["SAP"].Value.ToString();
                    dgv.Rows.Remove(row);

                    //Alerta minimo true
                    await CrearAlerta(int.Parse(sap), true);
                }
            }
            catch { }
        }

        private void BtIncidencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    var currentIndex = dgv.SelectedRows[0].Index;
                    var sap = dgv.Rows[currentIndex].Cells["Sap"].Value.ToString();

                    _formIncidencias = new Frm_Incidencias(this, int.Parse(sap));
                    _formIncidencias.Show();
                }
            }
            catch { }
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;

                BorrarDatos();
                await ObtenerReposicionesLinea();
            }
            catch { }
            finally
            {
                timer1.Enabled = true;
            }
        }
    }
}
