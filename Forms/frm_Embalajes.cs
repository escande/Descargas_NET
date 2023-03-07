using Descargas_NET.Helpers;
using Descargas_NET.Models;
using Descargas_NET.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargas_NET.Forms
{
    public partial class frm_Embalajes : Form
    {
        private readonly IRepositorio _repositorio;
        private TblEtiquetas _etiqueta;
        private const string _endPoint = "api/embalajes";
        private readonly Log _log;
        private readonly FrmReposiciones _parent;

        public frm_Embalajes(FrmReposiciones parent)
        {
            InitializeComponent();

            this._parent = parent;
            this._repositorio = Injector.GetService<IRepositorio>();
            _log = new Log("Form_Reposiciones");
            GlobalSettings.MSCommNet._comm_DataReceive += DatosRecibidosEscanerBis;
        }

        private void Frm_Embalajes_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = -5;
            //this.WindowState = FormWindowState.Maximized;
            BorrarDatos();
        }

        private void BorrarDatos()
        {
            lbId.Text = "";
            lbIdContenedor.Text = "";
            lbIdLote.Text = "";
            lbFecha.Text = "";
            lbFabricado.BackColor = Color.White;
            lbFabricado.Text = "";
            lbBloqueado.Visible = false;

            _etiqueta = null;
            btAnotar.Visible = false;
        }

        private async Task ObtenerEtiqueta(string id, string idContenedor, string lectura)
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}{_endPoint}",
                    Query = $"id={id}&idContenedor={idContenedor}"
                };

                var resp = await _repositorio.Get<TblEtiquetas>(url.ToString());


                if (!resp.Error)
                {
                    _etiqueta = resp.Response;


                    lbLectura.BeginInvoke(new Action(() =>
                    {
                        lbLectura.Text = lectura;
                        lbId.Text = _etiqueta.Id.ToString();
                        lbIdContenedor.Text = _etiqueta.IdContenedor.ToString();
                        lbIdLote.Text = _etiqueta.IdLote;
                        lbFecha.Text = _etiqueta.FechaHora.ToString();

                        if (_etiqueta.BloqueadoCalidad.HasValue)
                        {
                            lbBloqueado.Visible = true;

                            if (_etiqueta.BloqueadoCalidad.Value)
                            {
                                lbBloqueado.Text = "BLOQUEADO";
                                lbBloqueado.BackColor = Color.Red;
                            }
                            else
                            {
                                {
                                    lbBloqueado.Text = "LIBERADO";
                                    lbBloqueado.BackColor = Color.Lime;
                                }
                            }
                        }

                        if(_etiqueta.FechaHoraFabricado != null)
                        {
                            lbFabricado.BackColor = Color.GreenYellow;
                            lbFabricado.Text = _etiqueta.FechaHoraFabricado.ToString();
                        }
                        else
                        {
                            btAnotar.Visible = true;
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerEtiqueta: {ex.Message}");
            }
        }

        private async Task ActualizarDatos()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}{_endPoint}",
                };

                _etiqueta.FechaHoraFabricado = DateTime.Now;

                var resp = await _repositorio.Put(url.ToString(), _etiqueta);


                if (!resp.Error)
                {
                    Aviso.Msg("Datos actualizados correctamente", false);

                    this.BeginInvoke(new Action(()=> BorrarDatos()));
                    //BorrarDatos();
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ActualizarDatos: {ex.Message}");
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            GlobalSettings.MSCommNet._comm_DataReceive -= DatosRecibidosEscanerBis;
            this.Close();

            _parent.AsignarEventComm();
            _parent.Show();
        }

        private async void DatosRecibidosEscanerBis(LecturaOdette odette)
        {
            try
            {
                if (odette.CodeType == CodeType.Code_QR)
                {

                    await ObtenerEtiqueta(odette.Campo_I, odette.Campo_S, odette.Lectura);
                }
                else
                {
                    if (odette.Lectura.ToUpper() == GlobalSettings.Confirmacion)
                    {
                        if (_etiqueta != null)
                        {
                            if (_etiqueta.FechaHoraFabricado == null)
                            {
                                await ActualizarDatos();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en DatosRecibidosEscaner: {ex.Message}");
            }
        }

        private async void BtAnotar_Click(object sender, EventArgs e)
        {

            if (_etiqueta != null)
            {
                if (_etiqueta.FechaHoraFabricado == null)
                {
                    var dialog = Aviso.Msg("¿Deseas actualizar los datos a fabricado?", true);
                    if (dialog == DialogResult.OK)
                    {
                        await ActualizarDatos();
                    }
                }
            }
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            BorrarDatos();
        }
    }
}
