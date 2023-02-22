using Descargas_NET.Helpers;
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

namespace Descargas_NET.Forms
{
    public partial class frm_Incidencias : Form
    {
        private readonly frm_Descarga _parent;
        private readonly int _sap;
        private readonly IRepositorio _repositorio;
        private List<MensajesIncidenciasIn> _mensajes;
        private const string _endPoint = "api/MensajesIncidenciasIn";
        private bool _enCarga = false;
        private readonly Log _log;

        public frm_Incidencias(frm_Descarga parent, int sap)
        {
            InitializeComponent();

            this._parent = parent;
            this._sap = sap;
            this._repositorio = Injector.GetService<IRepositorio>();
            _log = new Log("Form_Incidencias");
        }

        private async void frm_Incidencias_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = -5;
            //this.WindowState = FormWindowState.Maximized;
            BorrarDatos();
            lbUsuario.Text = GlobalSettings.UsuarioApp;
            lbSap.Text = _sap.ToString();
            await ObtenerIncidencias();
        }

        private async Task ObtenerIncidencias()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}{_endPoint}",
                };

                var resp = await _repositorio.Get<List<MensajesIncidenciasIn>>(url.ToString());

                if (!resp.Error)
                {
                    _mensajes = resp.Response;


                    if (_mensajes.Count > 0)
                    {
                        int i = 0;
                        _enCarga = true;
                        foreach (var item in _mensajes)
                        {
                            dgv.Rows.Add();
                            dgv.Rows[i].Cells["Id"].Value = item.Id;
                            dgv.Rows[i].Cells["Incidencia"].Value = item.Incidencia;
                            i++;
                        }

                        dgv.Rows[0].Selected = true;
                        _enCarga = false;

                        RellenarDatos(0);

                    }
                }
                else
                {
                    _log.EscribirEnFichero($"ERROR en ObtenerIncidencias : {resp.HttpResponseMessage}");
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerIncidencias : {ex.Message}");
            }
        }

        private async Task AnotarIncidencia()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/MensajesIncidenciasOut"
                };

                var incidencia = new MensajesIncidenciasOut
                {
                    Sap = _sap.ToString(),
                    Usuario = GlobalSettings.UsuarioApp,
                    FechaEntrada = DateTime.Now,
                    Incidencia = lbDescripcion.Text,
                    Formulario = _parent.Name//"FrmReposicionesLineas"
                };

                var resp = await _repositorio.Post(url.ToString(), incidencia);

                if (!resp.Error)
                {
                    this.Close();
                    _parent.Show();
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en AnotarIncidencia : {ex.Message}");
            }
        }

        private void RellenarDatos(int index)
        {
            var mensaje = _mensajes.Where(x => x.Id.ToString() == dgv.Rows[index].Cells["Id"].Value.ToString()).FirstOrDefault();

            lbDescripcion.Text = mensaje.Incidencia;
        }

        private void BorrarDatos()
        {
            lbDescripcion.Text = "";

            dgv.Rows.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private async void btAceptar_Click(object sender, EventArgs e)
        {
            var dialog = Aviso.Msg("¿Deseas guardar la incidencia seleccionada?", true);

            if(dialog == DialogResult.OK)
            {
                await AnotarIncidencia();
            }
        }

        #region eventos_botones_navegacion
        private void BtBackAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    dgv.Rows[0].Selected = true;
                    RellenarDatos(0);
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
                        RellenarDatos(index);

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
                        RellenarDatos(index);
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
                    RellenarDatos (ultima);
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
                    RellenarDatos(index);
                }
            }
            catch { }//ignoro los errores
        }
        #endregion
    }
}
