using Descargas_NET.Helpers;
using Descargas_NET.Helpers;
using Descargas_NET.Models;
using Descargas_NET.Services;
using Descargas_NET.Services.Hub;
using Newtonsoft.Json;
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
    public partial class frm_Descarga : Form
    {
        private readonly frm_ListDescargas _parent;
        private readonly Descarga _descarga;
        private readonly IRepositorio _repositorio;
        private readonly IWaitFunction _wait;
        private readonly IHubClient hub;
        //private readonly IMemoData _salvarLecturasEnFichero;
        private List<TrazabilidadMaterial> _materiales;
        private frm_DescargaResumen formDescargaResumen;
        private frm_Incidencias _formIncidencias;
        private ContextMenuStrip _menu;
        private ToolStripMenuItem _itemBorrar;
        //private ToolStripMenuItem _incidencia;
        private Log _log;
        int _repetidos = 0;
        int _counter = 0;
        private bool _anotando = false;
        private bool _enArranque = true;
        List<string> _avisosSap;

        //BUILDER -----------------------------------------------
        public frm_Descarga(frm_ListDescargas parent, Descarga descarga)
        {
            InitializeComponent();

            this._parent = parent;
            this._descarga = descarga;
            this._repositorio = Injector.GetService<IRepositorio>();
            this.hub = Injector.GetService<IHubClient>();
            hub.Hub_DataReceive += Connection_DataReceive;
            //this._salvarLecturasEnFichero = Injector.GetService<IMemoData>();
            //_salvarLecturasEnFichero.NombreFichero = $"Descarga_{_descarga.DescargaId}";
            _wait =  Injector.GetService<IWaitFunction>();
            _materiales = new List<TrazabilidadMaterial>();
            _avisosSap = new();
            _log = new Log("Form_Descargas");
            GlobalSettings.MSCommNet._comm_DataReceive += DatosRecibidosEscaner;

            _itemBorrar = new ToolStripMenuItem
            {
                Name = "_iBorrar",
                Text = "BORRAR ITEM"
            };
            _itemBorrar.Click += MuestraBorrarItem_Click;

            //_incidencia = new ToolStripMenuItem();
            //_incidencia.Name = "_incidencia";
            //_incidencia.Text = "INCIDENCIA";
            //_incidencia.Click += Muestraincidencia_Click;

            _menu = new ContextMenuStrip();
            _menu.Items.Add(_itemBorrar);
            //_menu.Items.Add(_incidencia);
        }

        //LOAD ---------------------------------------------------
        private async void Frm_Descarga_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = -5;
            RellenarLabels();
            await ComprobarLecturasGuardadas();
            //RenellarDatosMock();
        }

        private async Task ComprobarLecturasGuardadas()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/trazabilidadmateriales/listado/{_descarga.DescargaId}"
                };

                _wait.Show(this,"Cargando");

                var resp = await _repositorio.Get<List<TrazabilidadMaterial>>(url.ToString());

                if (!resp.Error)
                {
                    var materialesBis = resp.Response;

                    //Cargamos los materiales
                    foreach (var item in materialesBis)
                    {
                        var repetido = _materiales.Where(x => x.TrazabilidadMaterialesPPartNumber == item.TrazabilidadMaterialesPPartNumber
                                                                        && x.TrazabilidadMaterialesNAlbaran == item.TrazabilidadMaterialesNAlbaran
                                                                        && x.TrazabilidadMaterialesSSerial == item.TrazabilidadMaterialesSSerial).Count();

                        _materiales.Add(item);

                        dgv.BeginInvoke(new Action(() =>
                        {
                            dgv.Rows.Add();
                            dgv.Rows[_counter].Cells["ID"].Value = item.TrazabilidadMaterialesId;
                            dgv.Rows[_counter].Cells["Campo_P"].Value = item.TrazabilidadMaterialesPPartNumber;
                            dgv.Rows[_counter].Cells["SAP"].Value = item.TrazabilidadMaterialesReferenciaSap;
                            dgv.Rows[_counter].Cells["Campo_Q"].Value = item.TrazabilidadMaterialesQCantidad;
                            dgv.Rows[_counter].Cells["Alerta0"].Value = item.AvisoCDMId;
                            dgv.Rows[_counter].Cells["Mensaje"].Value = item.AvisoCarretilleroCDMId;
                            dgv.Rows[_counter].Cells["Campo_V"].Value = item.TrazabilidadMaterialesVProveedor;
                            dgv.Rows[_counter].Cells["Campo_N"].Value = item.TrazabilidadMaterialesNAlbaran;
                            dgv.Rows[_counter].Cells["Campo_D"].Value = item.TrazabilidadMaterialesDFecha;
                            dgv.Rows[_counter].Cells["Campo_S"].Value = item.TrazabilidadMaterialesSSerial;

                            if (repetido > 0)
                            {
                                _repetidos++;

                                for (int i = 0; i < dgv.Rows[_counter].Cells.Count; i++)
                                {

                                    dgv.Rows[_counter].Cells[i].Style.BackColor = Color.Red;
                                }
                            }

                            if (item.AvisoCDMId > 0)
                            {
                                //for (int i = 0; i < dgv.Rows[_counter].Cells.Count; i++)
                                //{
                                //    dgv.Rows[_counter].Cells[i].Style.BackColor = Color.Orange;
                                //}
                                dgv.Rows[_counter].Cells["Alerta0"].Style.BackColor = Color.Yellow;
                            }

                            if (item.AvisoCarretilleroCDMId > 0)
                            {
                                //for (int i = 0; i < dgv.Rows[_counter].Cells.Count; i++)
                                //{
                                //    dgv.Rows[_counter].Cells[i].Style.BackColor = Color.Orange;
                                //}
                                dgv.Rows[_counter].Cells["Mensaje"].Style.BackColor = Color.Orange;
                            }


                            dgv.Rows[0].Selected = true;
                            dgv.FirstDisplayedScrollingRowIndex = dgv.RowCount - 1;

                            _counter++;
                            lbCantidad.Text = _counter.ToString();
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ComprobarLecturasGuardadas - {ex.Message}");
            }
            finally
            {
                _wait.Close();
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            //if(_materiales.Count > 0)
            //{
            //    var dialog = Aviso.Msg("¿Deseas guardar las lecturas de los materiales para usarlos Posteriormente?", true);

            //    if(dialog == DialogResult.OK)
            //    {
            //        var cadena = JsonConvert.SerializeObject(_materiales);
            //        _salvarLecturasEnFichero.EscribirEnFichero(cadena);
            //    }
            //    else
            //    {
            //        _salvarLecturasEnFichero.EliminarFichero();
            //    }
            //}

            this.Close();
            _parent.Show();
        }

        private void RellenarLabels()
        {
            lbDescarga.Text = _descarga.DescargaId.ToString();
            lbRuta.Text = _descarga.DescargaRuta;
            lbMuelle.Text = _descarga.DescargaMuelle;
            lbFecha.Text = _descarga.DescargaFecha.Value.ToString("dd/MM/yyyy HH:mm:ss");
            lbAgencia.Text = _descarga.DescargaAgencia;
            lbMatricula.Text = _descarga.DescargaMatricula;
        }

        private void BorrarDatos()
        {
            lbDescarga.Text = "";
            lbRuta.Text = "";
            lbMuelle.Text = "";
            lbFecha.Text = "";
            lbAgencia.Text = "";
            lbMatricula.Text = "";
            lbCantidad.Text = "";
        }

        private async void DatosRecibidosEscaner(LecturaOdette odette)
        {
            try
            {
                if (!_anotando)
                {
                    _anotando = true;

                    if (odette.CodeType == CodeType.PDF417 || odette.CodeType == CodeType.Code_QR)
                    {
                        var partNumber = odette.Campo_P.Replace("-", "").Replace(" ", "");
                        int sap = -1;

                        if (IsNumeric(partNumber))
                        {
                            sap = int.Parse(partNumber);

                            var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                            {
                                Path = $"{GlobalSettings.VirtualHost}api/materiales/P{sap}"
                            };

                            var respMat = await _repositorio.Get<Materiales>(url.ToString());

                            var material = respMat.Response;

                            partNumber = material.MaterialesPartNumber;
                        }
                        else
                            sap = await ObtenerSap($"P{partNumber}");

                        if (sap != -1)
                        {

                            var alerta = await GestionarAlerta0(sap);

                            var avisoConductor = await GestionarAvisosCarretillero(sap);

                            var material = new TrazabilidadMaterial
                            {
                                TrazabilidadMaterialesPPartNumber = partNumber,
                                TrazabilidadMaterialesNAlbaran = !string.IsNullOrEmpty(odette.Campo_N) ? odette.Campo_N : !string.IsNullOrEmpty(odette.Campo_A) ? odette.Campo_A : _descarga.DescargaId.ToString(),//odette.CodeType == CodeType.PDF417 ? odette.Campo_N : !string.IsNullOrEmpty(odette.Campo_A) ? odette.Campo_A : _descarga.DescargaId.ToString(),
                                TrazabilidadMaterialesDFecha = odette.Campo_D,
                                TrazabilidadMaterialesQCantidad = odette.Campo_Q,
                                TrazabilidadMaterialesVProveedor = odette.Campo_V,
                                TrazabilidadMaterialesSSerial = odette.Campo_S,
                                TrazabilidadMaterialesHLote = odette.Campo_H,
                                TrazabilidadMaterialesBEmbalaje = odette.Campo_B,
                                TrazabilidadMaterialesDescargaId = _descarga.DescargaId,
                                TrazabilidadMaterialesCliente = GlobalSettings.UsuarioApp,
                                TrazabilidadMaterialesReferenciaSap = sap,
                                AvisoCDMId = alerta.Item1,
                                AvisoCDMTexto = alerta.Item2,
                                AvisoCarretilleroCDMId = avisoConductor.Item1,
                                Detalles = new List<TrazabilidadMaterialDetalle>
                            {
                                new TrazabilidadMaterialDetalle
                                {
                                    TrazabilidadMaterialesDetallesQCantidad = odette.Campo_Q,
                                    TrazabilidadMaterialesDetallesCantidadCalculada = 0,
                                    TrazabilidadMaterialesDetallesCliente = GlobalSettings.UsuarioApp,
                                    TrazabilidadMaterialesDetallesFinalizado = false,
                                    TrazabilidadMaterialesDetallesFechaEntrada = DateTime.Now,
                                    TrazabilidadMaterialesDetallesDestino = "P",
                                    TrazabilidadMaterialesDetallesOrigen = "R"
                                }
                            }
                            };

                            int idMaterial = await AnotaTrazabilidadMaterial(material);
                            if (idMaterial > 0)
                            {
                                material.TrazabilidadMaterialesId = idMaterial;
                                var repetido = _materiales.Where(x => x.TrazabilidadMaterialesPPartNumber == material.TrazabilidadMaterialesPPartNumber
                                                                                && x.TrazabilidadMaterialesNAlbaran == material.TrazabilidadMaterialesNAlbaran
                                                                                && x.TrazabilidadMaterialesSSerial == material.TrazabilidadMaterialesSSerial).Count();

                                _materiales.Add(material);

                                dgv.BeginInvoke(new Action(() =>
                                 {
                                     dgv.Rows.Add();
                                     dgv.Rows[_counter].Cells["ID"].Value = material.TrazabilidadMaterialesId;
                                     dgv.Rows[_counter].Cells["Campo_P"].Value = partNumber;
                                     dgv.Rows[_counter].Cells["SAP"].Value = sap;
                                     dgv.Rows[_counter].Cells["Campo_Q"].Value = odette.Campo_Q;
                                     dgv.Rows[_counter].Cells["Alerta0"].Value = material.AvisoCDMId;
                                     dgv.Rows[_counter].Cells["Mensaje"].Value = material.AvisoCarretilleroCDMId;
                                     dgv.Rows[_counter].Cells["Campo_V"].Value = odette.Campo_V;
                                     dgv.Rows[_counter].Cells["Campo_N"].Value = material.TrazabilidadMaterialesNAlbaran;
                                     dgv.Rows[_counter].Cells["Campo_D"].Value = odette.Campo_D;
                                     dgv.Rows[_counter].Cells["Campo_S"].Value = material.TrazabilidadMaterialesSSerial;

                                     if (repetido > 0)
                                     {
                                         _repetidos++;

                                         for (int i = 0; i < dgv.Rows[_counter].Cells.Count; i++)
                                         {

                                             dgv.Rows[_counter].Cells[i].Style.BackColor = Color.Red;
                                         }
                                     }

                                     if (material.AvisoCDMId > 0)
                                     {
                                         //for (int i = 0; i < dgv.Rows[_counter].Cells.Count; i++)
                                         //{
                                         //    dgv.Rows[_counter].Cells[i].Style.BackColor = Color.Orange;
                                         //}
                                         dgv.Rows[_counter].Cells["Alerta0"].Style.BackColor = Color.Yellow;
                                         Aviso.Msg($"SAP:{material.TrazabilidadMaterialesReferenciaSap}\nPN: {material.TrazabilidadMaterialesPPartNumber}\n\n"
                                                                        + "Alerta0 cerrada: Colocar identificación y enviar a ubicación final", false);
                                     }

                                     if (material.AvisoCarretilleroCDMId > 0)
                                     {
                                         var existeAviso = _avisosSap.Any(x => x == sap.ToString());

                                         if (!existeAviso)
                                         {
                                             dgv.Rows[_counter].Cells["Mensaje"].Style.BackColor = Color.Orange;
                                             Aviso.Msg($"SAP:{material.TrazabilidadMaterialesReferenciaSap}\nPN: {material.TrazabilidadMaterialesPPartNumber}\n\n"
                                                                                                               + $"{ avisoConductor.Item2}", false);
                                             _avisosSap.Add(sap.ToString());
                                         }
                                     }

                                     try
                                     {
                                         dgv.Rows[0].Selected = true;
                                         dgv.FirstDisplayedScrollingRowIndex = dgv.RowCount - 1;
                                     }
                                     catch { }

                                     _counter++;
                                     lbCantidad.Text = _counter.ToString();
                                 }));
                            }
                        }
                        else
                        {
                            Aviso.Msg($"Se produjo un error obteniendo el SAP para el PN: {partNumber}", false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en DatosRecibidosEscaner: {ex.Message}");
            }
            finally
            {
                _anotando = false;
            }
        }

        private async Task<(int, string)> GestionarAlerta0(int sap)
        {
            try
            { 

                (int, string) alertaMaterial = (-1, ""); 

                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/panelalertas/alertaporsap/listado/{sap}"
                };

                //Comprobamos si existen Alertas 0 para ese material
                var respAlerta = await _repositorio.Get<List<PanelAlertas>>(url.ToString());

                if (!respAlerta.Error)
                {
                    var listadoAlertas = respAlerta.Response;

                    if (listadoAlertas.Count > 0)
                    {
                        var primera = listadoAlertas.FirstOrDefault(x => x.PanelAlertasTipo == false);

                        if (primera != null)
                        {
                            alertaMaterial.Item1 = primera.PanelAlertasId;
                            alertaMaterial.Item2 = "ALERTA0 CERRADA";
                        }

                        //La cerramos todas las de ese material
                        listadoAlertas.ForEach((Alerta) =>
                        {
                            Alerta.PanelAlertasFechaFin = DateTime.Now;
                            Alerta.PanelAlertasObservaciones = "CERRADO EN DESCARGA";
                        });

                        url.Path = $"{GlobalSettings.VirtualHost}api/panelalertas/alertaporsap/listado";


                        var respPost = await _repositorio.Post(url.ToString(), listadoAlertas);
                    }
                    
                }

                return alertaMaterial;
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"Se ha producido un error en GestionarAlerta0 para el SAP: {sap}");
                Aviso.Msg($"Se ha producido un error en GestionarAlerta0 para el SAP: {sap}", false);

                return (-1, "");
            }
        }

        private async Task<(int, string)> GestionarAvisosCarretillero(int sap)
        {
            try
            {

                (int, string) avisoMaterial = (-1, "");

                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/avisoscarretillero/{sap}"
                };

                //Comprobamos si existen Alertas 0 para ese material
                var respAvisos = await _repositorio.Get<AvisosCarretillero>(url.ToString());

                if (!respAvisos.Error)
                {
                    var avisoCarretillero = respAvisos.Response;

                    if (avisoCarretillero != null)
                    {
                        
                        if (int.Parse(avisoCarretillero.Albaran) > 0)
                        {
                            avisoMaterial.Item1 = avisoCarretillero.Id;
                            avisoMaterial.Item2 = $"{avisoCarretillero.Comentario}\n\n Revisar albaran Campo N\n\nALBARAN: {avisoCarretillero.Albaran}";
                        }
                        else
                        {
                            avisoMaterial.Item1 = avisoCarretillero.Id;
                            avisoMaterial.Item2 = avisoCarretillero.Comentario;
                        }

                    }
                }

                return avisoMaterial;
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"Se ha producido un error en GestionarAvisosCarretillero para el SAP: {sap}");
                Aviso.Msg($"Se ha producido un error en GestionarAvisosCarretillero para el SAP: {sap}", false);

                return (-1, "");
            }
        }

        private bool IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any,
                                        System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }//end

        private async Task<int> AnotaTrazabilidadMaterial(TrazabilidadMaterial trazabilidad)
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/trazabilidadmateriales/anotasimple"
                };

                _wait.Show(this, "ESPERE...");


                var resp = await _repositorio.Post<TrazabilidadMaterial, int >(url.ToString(), trazabilidad);

                Task.Delay(200).Wait();

                if (!resp.Error)
                {
                    var id = resp.Response;

                    return id;
                }
                else
                {
                    _log.EscribirEnFichero($"Se ha producido un error anotando el Material {trazabilidad.TrazabilidadMaterialesPPartNumber}");
                    Aviso.Msg($"Se ha producido un error anotando el Material {trazabilidad.TrazabilidadMaterialesPPartNumber}", false);
                }

                return -1;
            }
            catch(Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en AnotaTrazabilidadMaterial: {ex.Message}");
                return -1;
            }
            finally
            {
                _wait.Close();
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


                    mResponse = sap != null ? sap.MaterialesReferenciaSap : -1;
                }

                return mResponse;
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerSap: {ex.Message}");
                return -1;
            }
        }

        private async void BtGuardar_Click(object sender, EventArgs e)
        {
            if (_materiales.Count > 0)
            {
                if (_repetidos == 0)
                {
                    formDescargaResumen = new frm_DescargaResumen(_materiales);
                    var dialogResult = formDescargaResumen.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        var resp = await AnotaMaterial();

                        if (resp)
                        {
                            BorrarDatos();
                            dgv.Rows.Clear();
                            _parent.BorrarDescargaFinalizada(_descarga);

                            Aviso.Msg($"La descarga: {_descarga.DescargaId} ha sido guardada correctamente", false);
                            this.Close();
                            _parent.Show();
                        }
                    }
                }
                else
                {
                    Aviso.Msg("Debes de eliminar antes los materiales duplicados", false);
                }
            }
        }

        private async Task<bool> AnotaMaterial()
        {
            bool mResp = false;
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/descargas"
                };

                _wait.Show(this, "PROCESANDO...");

                _descarga.DescargaFechaInicio = DateTime.Now;
                _descarga.DescargaFechaFin = DateTime.Now;

                var resp = await _repositorio.Put(url.ToString(), _descarga);
                _wait.Close();
                if (!resp.Error)
                {
                    //Aviso.Msg("Datos Anotados correctamente", false);
                    mResp = true;
                }
                else
                {
                    Aviso.Msg($"Error anotando los datos: {resp.Response}", false);
                    mResp = false;
                }

                return mResp;
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en AnotaMaterial: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> BorrarTrazabilidadMaterial(int materialId)
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/trazabilidadmateriales/{materialId}"
                };

                var resp = await _repositorio.Delete(url.ToString());

                if (!resp.Error)
                {
                    return true;
                }
                else
                {
                    _log.EscribirEnFichero($"Se ha producido un error eliminando el Material Id: {materialId}");
                    Aviso.Msg($"Se ha producido un error eliminando el Material Id: {materialId}", false);
                }

                return false;
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en BorrarTrazabilidadMaterial: {ex.Message}");
                return false;
            }
        }

        private void Frm_Descarga_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalSettings.MSCommNet._comm_DataReceive -= DatosRecibidosEscaner;
            hub.Hub_DataReceive -= Connection_DataReceive;
        }

        private void BtIncidencias_Click(object sender, EventArgs e)
        {
            try
            {
                _formIncidencias = new frm_Incidencias(this, _descarga.DescargaId);
                _formIncidencias.Show();

                this.Hide();
            }
            catch { }
        }

        #region eventos_botones

        private async void MuestraBorrarItem_Click(object sender, EventArgs e)
        {
            try
            {
                var index = int.Parse(_itemBorrar.Name);
                var row = dgv.Rows[index];

                var id = row.Cells["ID"].Value.ToString();

                var item = _materiales.FirstOrDefault(x => x.TrazabilidadMaterialesId == int.Parse(id));

                if (await BorrarTrazabilidadMaterial(item.TrazabilidadMaterialesId))
                {
                    dgv.Rows.Remove(row);
                    _materiales.Remove(item);
                    _counter = _materiales.Count();
                    lbCantidad.Text = _counter.ToString();
                    if (_repetidos > 0)
                    {
                        _repetidos--;
                    }

                    if (dgv.Rows.Count > 0)
                    {
                        dgv.Rows[index - 1].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en MuestraBorrarItem_Click : {ex.Message}");
            }
        }

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

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int currentMouseOverRow = dgv.HitTest(e.X, e.Y).RowIndex;

                    if (currentMouseOverRow >= 0)
                    {
                        //_itemBorrar.Name = currentMouseOverRow.ToString();
                        if (dgv.Rows[currentMouseOverRow].Cells[0].Style.BackColor == Color.Red)
                        {

                            _menu.Show();
                        }
                    }
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void Dgv_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int currentMouseOverRow = dgv.HitTest(e.X, e.Y).RowIndex;

                    if (currentMouseOverRow >= 0)
                    {
                        var currenRow = dgv.SelectedRows[0].Index;
                        if (currenRow == currentMouseOverRow)
                        {
                            //if (dgv.Rows[currentMouseOverRow].Cells[0].Style.BackColor == Color.Red)
                            //{
                                _itemBorrar.Name = currentMouseOverRow.ToString();
                                //_incidencia.Name = currentMouseOverRow.ToString();
                                _menu.Show(dgv, new Point(e.X, e.Y));
                            //}
                        }
                    }
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0 )
                {
                    var index = e.RowIndex;
                    dgv.Rows[index].Selected = true;
                }
            }
            catch { }//ignoro los errores
        }

        private async void BtLecturaSimple_ClickAsync(object sender, EventArgs e)
        {
            GlobalSettings.MSCommNet._comm_DataReceive -= DatosRecibidosEscaner;

            var frmSimple = new frm_LecturaSimple();

            var dialog = frmSimple.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                var material = frmSimple.material;

                if (!string.IsNullOrEmpty(material.TrazabilidadMaterialesPPartNumber) && !string.IsNullOrEmpty(material.TrazabilidadMaterialesNAlbaran)
                                                                                    && !string.IsNullOrEmpty(material.TrazabilidadMaterialesSSerial)
                                                                                    && material.TrazabilidadMaterialesQCantidad.Value > 0)
                {
                    var sap = await ObtenerSap($"P{material.TrazabilidadMaterialesPPartNumber}");

                    var alerta = await GestionarAlerta0(sap);

                    var avisoConductor = await GestionarAvisosCarretillero(sap);


                    material.TrazabilidadMaterialesReferenciaSap = sap;
                    material.TrazabilidadMaterialesCliente = GlobalSettings.UsuarioApp;
                    material.TrazabilidadMaterialesDescargaId = _descarga.DescargaId;
                    material.AvisoCDMId = alerta.Item1;
                    material.AvisoCDMTexto = alerta.Item2;
                    material.AvisoCarretilleroCDMId = avisoConductor.Item1;

                    material.Detalles = new List<TrazabilidadMaterialDetalle>
                            {
                                new TrazabilidadMaterialDetalle
                                {
                                    TrazabilidadMaterialesDetallesQCantidad = material.TrazabilidadMaterialesQCantidad.Value,
                                    TrazabilidadMaterialesDetallesCantidadCalculada = 0,
                                    TrazabilidadMaterialesDetallesCliente = GlobalSettings.UsuarioApp,
                                    TrazabilidadMaterialesDetallesFinalizado = false,
                                    TrazabilidadMaterialesDetallesFechaEntrada = DateTime.Now,
                                    TrazabilidadMaterialesDetallesDestino = "P",
                                    TrazabilidadMaterialesDetallesOrigen = "R"
                                }
                            };

                    int idMaterial = await AnotaTrazabilidadMaterial(material);
                    if (idMaterial > 0)
                    {
                        material.TrazabilidadMaterialesId = idMaterial;
                        var repetido = _materiales.Where(x => x.TrazabilidadMaterialesPPartNumber == material.TrazabilidadMaterialesPPartNumber
                                                                        && x.TrazabilidadMaterialesNAlbaran == material.TrazabilidadMaterialesNAlbaran
                                                                        && x.TrazabilidadMaterialesSSerial == material.TrazabilidadMaterialesSSerial).Count();

                        _materiales.Add(material);

                        dgv.BeginInvoke(new Action(() =>
                        {
                            dgv.Rows.Add();
                            dgv.Rows[_counter].Cells["ID"].Value = material.TrazabilidadMaterialesId;
                            dgv.Rows[_counter].Cells["Campo_P"].Value = material.TrazabilidadMaterialesPPartNumber;
                            dgv.Rows[_counter].Cells["SAP"].Value = sap;
                            dgv.Rows[_counter].Cells["Campo_Q"].Value = material.TrazabilidadMaterialesQCantidad;
                            dgv.Rows[_counter].Cells["Alerta0"].Value = material.AvisoCDMId;
                            dgv.Rows[_counter].Cells["Mensaje"].Value = material.AvisoCarretilleroCDMId;
                            dgv.Rows[_counter].Cells["Campo_V"].Value = material.TrazabilidadMaterialesVProveedor;
                            dgv.Rows[_counter].Cells["Campo_N"].Value = material.TrazabilidadMaterialesNAlbaran;
                            dgv.Rows[_counter].Cells["Campo_D"].Value = material.TrazabilidadMaterialesDFecha;
                            dgv.Rows[_counter].Cells["Campo_S"].Value = material.TrazabilidadMaterialesSSerial;

                            if (repetido > 0)
                            {
                                _repetidos++;

                                for (int i = 0; i < dgv.Rows[_counter].Cells.Count; i++)
                                {

                                    dgv.Rows[_counter].Cells[i].Style.BackColor = Color.Red;
                                }
                            }

                            if (material.AvisoCDMId > 0)
                            {
                                //for (int i = 0; i < dgv.Rows[_counter].Cells.Count; i++)
                                //{
                                //    dgv.Rows[_counter].Cells[i].Style.BackColor = Color.Orange;
                                //}
                                dgv.Rows[_counter].Cells["Alerta0"].Style.BackColor = Color.Yellow;
                                Aviso.Msg($"SAP:{material.TrazabilidadMaterialesReferenciaSap}\nPN: {material.TrazabilidadMaterialesPPartNumber}\n\n" 
                                                                        + "Alerta0 cerrada: Colocar identificación y enviar a ubicación final",false);
                            }

                            if(material.AvisoCarretilleroCDMId > 0)
                            {
                                var existeAviso = _avisosSap.Any(x => x == sap.ToString());

                                if (!existeAviso)
                                {
                                    dgv.Rows[_counter].Cells["Mensaje"].Style.BackColor = Color.Orange;
                                    Aviso.Msg($"SAP:{material.TrazabilidadMaterialesReferenciaSap}\nPN: {material.TrazabilidadMaterialesPPartNumber}\n\n"
                                                                                                                + $"{ avisoConductor.Item2}", false);
                                    _avisosSap.Add(sap.ToString());
                                }
                            }

                            dgv.Rows[0].Selected = true;
                            dgv.FirstDisplayedScrollingRowIndex = dgv.RowCount - 1;

                            _counter++;
                            lbCantidad.Text = _counter.ToString();
                        }));

                    }
                }
            }

            frmSimple.Dispose();
            GlobalSettings.MSCommNet._comm_DataReceive += DatosRecibidosEscaner;
        }

        private void Connection_DataReceive(object sender, string e)
        {
            this.BeginInvoke(new Action(() =>
            {

                Aviso.Msg(e, false);

            }));
        }

        private void frm_Descarga_VisibleChanged(object sender, EventArgs e)
        {
            if (!_enArranque && this.Visible)
            {
                //De momento no se usa....
                //hub.Hub_DataReceive += Connection_DataReceive;
            }

            if (_enArranque) _enArranque = false;
        }
        #endregion

        //private void RenellarDatosMock()
        //{
        //    var lista = new List<TrazabilidadMaterial>
        //    {
        //        new TrazabilidadMaterial{
        //            TrazabilidadMaterialesPPartNumber = "AB123345TR",
        //            TrazabilidadMaterialesNAlbaran = "ABCDE",
        //            TrazabilidadMaterialesDFecha = "150821",
        //            TrazabilidadMaterialesQCantidad = 45,
        //            TrazabilidadMaterialesVProveedor = "FORD",
        //            TrazabilidadMaterialesSSerial = "S12345689",
        //            TrazabilidadMaterialesHLote = "12356464",
        //            TrazabilidadMaterialesDescargaId = _descarga.DescargaId,
        //            TrazabilidadMaterialesCliente = GlobalSettings.UsuarioApp,
        //            TrazabilidadMaterialesReferenciaSap = 160002365 },
        //        new TrazabilidadMaterial{
        //            TrazabilidadMaterialesPPartNumber = "BChuhu23444",
        //            TrazabilidadMaterialesNAlbaran = "WSEDD",
        //            TrazabilidadMaterialesDFecha = "180821",
        //            TrazabilidadMaterialesQCantidad = 100,
        //            TrazabilidadMaterialesVProveedor = "FORD",
        //            TrazabilidadMaterialesSSerial = "S6548494",
        //            TrazabilidadMaterialesHLote = "15566514564",
        //            TrazabilidadMaterialesDescargaId = _descarga.DescargaId,
        //            TrazabilidadMaterialesCliente = GlobalSettings.UsuarioApp,
        //            TrazabilidadMaterialesReferenciaSap = 160002369 },
        //        new TrazabilidadMaterial{
        //            TrazabilidadMaterialesPPartNumber = "AHG45646ESD",
        //            TrazabilidadMaterialesNAlbaran = "DETCSS",
        //            TrazabilidadMaterialesDFecha = "160821",
        //            TrazabilidadMaterialesQCantidad = 69,
        //            TrazabilidadMaterialesVProveedor = "CURRU",
        //            TrazabilidadMaterialesSSerial = "S69631",
        //            TrazabilidadMaterialesHLote = "234444444",
        //            TrazabilidadMaterialesDescargaId = _descarga.DescargaId,
        //            TrazabilidadMaterialesCliente = GlobalSettings.UsuarioApp,
        //            TrazabilidadMaterialesReferenciaSap = 160002305 },
        //        new TrazabilidadMaterial{
        //            TrazabilidadMaterialesPPartNumber = "BChuhu23444",
        //            TrazabilidadMaterialesNAlbaran = "WSEDD",
        //            TrazabilidadMaterialesDFecha = "180821",
        //            TrazabilidadMaterialesQCantidad = 100,
        //            TrazabilidadMaterialesVProveedor = "FORD",
        //            TrazabilidadMaterialesSSerial = "S6548494",
        //            TrazabilidadMaterialesHLote = "15566514564",
        //            TrazabilidadMaterialesDescargaId = _descarga.DescargaId,
        //            TrazabilidadMaterialesCliente = GlobalSettings.UsuarioApp,
        //            TrazabilidadMaterialesReferenciaSap = 160002369 },
        //        new TrazabilidadMaterial{
        //            TrazabilidadMaterialesPPartNumber = "FS2636363KJJ",
        //            TrazabilidadMaterialesNAlbaran = "KIOKK212",
        //            TrazabilidadMaterialesDFecha = "200821",
        //            TrazabilidadMaterialesQCantidad = 200,
        //            TrazabilidadMaterialesVProveedor = "MENA",
        //            TrazabilidadMaterialesSSerial = "S23659874",
        //            TrazabilidadMaterialesHLote = "11456454",
        //            TrazabilidadMaterialesDescargaId = _descarga.DescargaId,
        //            TrazabilidadMaterialesCliente = GlobalSettings.UsuarioApp,
        //            TrazabilidadMaterialesReferenciaSap = 160006969 },
        //        new TrazabilidadMaterial{
        //            TrazabilidadMaterialesPPartNumber = "FS2636363KJJ",
        //            TrazabilidadMaterialesNAlbaran = "KIOKK212",
        //            TrazabilidadMaterialesDFecha = "200821",
        //            TrazabilidadMaterialesQCantidad = 200,
        //            TrazabilidadMaterialesVProveedor = "MENA",
        //            TrazabilidadMaterialesSSerial = "S23659874",
        //            TrazabilidadMaterialesHLote = "11456454",
        //            TrazabilidadMaterialesDescargaId = _descarga.DescargaId,
        //            TrazabilidadMaterialesCliente = GlobalSettings.UsuarioApp,
        //            TrazabilidadMaterialesReferenciaSap = 160006969 }
        //    };

        //    _materiales.AddRange(lista);

        //    dgv.BeginInvoke(new Action(() =>
        //    {
        //        // i = 0;

        //        foreach (var item in _materiales)
        //        {
        //            dgv.Rows.Add();
        //            dgv.Rows[_counter].Cells["Campo_P"].Value = item.TrazabilidadMaterialesPPartNumber;
        //            dgv.Rows[_counter].Cells["SAP"].Value = item.TrazabilidadMaterialesReferenciaSap;
        //            dgv.Rows[_counter].Cells["Campo_Q"].Value = item.TrazabilidadMaterialesQCantidad;
        //            dgv.Rows[_counter].Cells["Alerta0"].Value = item.TrazabilidadMaterialesHLote;
        //            dgv.Rows[_counter].Cells["Campo_V"].Value = item.TrazabilidadMaterialesVProveedor;
        //            dgv.Rows[_counter].Cells["Campo_N"].Value = item.TrazabilidadMaterialesNAlbaran;
        //            dgv.Rows[_counter].Cells["Campo_D"].Value = item.TrazabilidadMaterialesDFecha;

        //            if (_counter == 3 || _counter == 5)
        //            {
        //                for (int i = 0; i < dgv.Rows[_counter].Cells.Count; i++)
        //                {
        //                    dgv.Rows[_counter].Cells[i].Style.BackColor = Color.Red;
        //                }

        //                _repetidos++;
        //            }


        //            dgv.Rows[0].Selected = true;

        //            _counter++;
        //            lbCantidad.Text = _counter.ToString();
        //        }
        //    }));
        //}

        //private void Muestraincidencia_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var index = int.Parse(_incidencia.Name);
        //        var row = dgv.Rows[index];

        //        var sap = row.Cells["SAP"].Value.ToString();
        //        _formIncidencias = new frm_Incidencias(this, int.Parse(sap));
        //        _formIncidencias.Show();

        //        this.Hide();
        //    }
        //    catch (Exception ex)
        //    {
        //        _log.EscribirEnFichero($"ERROR en Muestraincidencia_Click : {ex.Message}");
        //    }
        //}
    }
}
