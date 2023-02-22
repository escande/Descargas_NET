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
using System.Linq;
using Descargas_NET.Helpers;
using Descargas_NET.Services.Hub;

namespace Descargas_NET.Forms
{
    public partial class frm_ListDescargas : Form
    {
        private readonly IRepositorio _repositorio;
        private readonly IHubClient hub;
        private readonly int _idMuelle;
        private readonly frm_Principal _parent;
        private List<Descarga> _descargas;
        private const string _endPoint = "api/descargas";
        private bool _enCarga = false;
        private bool _enArranque = true;
        private Log _log;

        public frm_ListDescargas(int IdMuelle, frm_Principal parent)
        {
            InitializeComponent();

            _log = new Log("Form_ListaDescargas");
            _repositorio = Injector.GetService<IRepositorio>();
            this.hub = Injector.GetService<IHubClient>();
            hub.Hub_DataReceive += Connection_DataReceive;
            _idMuelle = IdMuelle;
            this._parent = parent;
        }

        private async void frm_ListDescargas_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = -5;

            await ObtenerDescargas();
            //CrearRegistrosMock();
            timer1.Interval = 30000;
            timer1.Enabled = true;
        }

        private async Task ObtenerDescargas()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}{_endPoint}",
                    Query = $"muelleId={_idMuelle}"
                };

                var resp = await _repositorio.Get<List<Descarga>>(url.ToString());

                if (!resp.Error)
                {
                    _descargas = resp.Response;

                    dgv.Rows.Clear();

                    if (_descargas.Count > 0)
                    {
                        int i = 0;
                        _enCarga = true;
                        foreach (var item in _descargas)
                        {
                            dgv.Rows.Add();
                            dgv.Rows[i].Cells["Id"].Value = item.DescargaId;
                            dgv.Rows[i].Cells["Descarga"].Value = item.DescargaId;
                            dgv.Rows[i].Cells["Fecha"].Value = item.DescargaFecha;
                            dgv.Rows[i].Cells["Turno"].Value = item.DescargaTurno;
                            dgv.Rows[i].Cells["Ruta"].Value = item.DescargaRuta;
                            dgv.Rows[i].Cells["Agencia"].Value = item.DescargaAgencia;
                            dgv.Rows[i].Cells["Muelle"].Value = item.DescargaMuelle;
                            dgv.Rows[i].Cells["Matricula"].Value = item.DescargaMatricula;
                            i++;
                        }

                        dgv.Rows[0].Selected = true;
                        RellenarDescarga(0);
                        _enCarga = false;
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerDescargas : {ex.Message}");
            }
        }

        private void RellenarDescarga(int index)
        {
            var descarga = _descargas.Where(x => x.DescargaId.ToString() == dgv.Rows[index].Cells["Descarga"].Value.ToString()).FirstOrDefault();

            lbDescarga.Text = descarga.DescargaId.ToString();
            lbRuta.Text = descarga.DescargaRuta;
            lbMuelle.Text = descarga.DescargaMuelle;
            lbFecha.Text = descarga.DescargaFecha.Value.ToString("dd/MM/yyyy HH:mm:ss");
            lbAgencia.Text = descarga.DescargaAgencia;
            lbMatricula.Text = descarga.DescargaMatricula;
        }

        public void BorrarDescargaFinalizada(Descarga descarga)
        {
            try
            {
                _descargas.Remove(descarga);
                var index = dgv.SelectedRows[0].Index;
                var row = dgv.Rows[index];

                if(row.Cells["Descarga"].Value.ToString() == descarga.DescargaId.ToString())
                {
                    dgv.Rows.Remove(row);
                    BorrarDatos();

                    if (dgv.Rows.Count > 0)
                    {
                        if (index > 0)
                        {
                            index--;
                            dgv.Rows[index].Selected = true;
                        }
                        else
                        {
                            dgv.Rows[index].Selected = true;
                        }

                        RellenarDescarga(index);
                    }
                }
            }
            catch(Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en BorrarDescargaFinalizada : " + ex.Message);
            }
        }

        private void BorrarDatos()
        {
            lbDescarga.Text = "";
            lbRuta.Text = "";
            lbMuelle.Text = "";
            lbFecha.Text = "";
            lbAgencia.Text = "";
            lbMatricula.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            hub.Hub_DataReceive -= Connection_DataReceive;
            this.Close();
            _parent.Show();
        }

        private void btDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                var currentIndex = dgv.SelectedRows[0].Index;
                var descarga = _descargas.Where(x => x.DescargaId.ToString() == dgv.Rows[currentIndex].Cells["Descarga"].Value.ToString()).FirstOrDefault();

                hub.Hub_DataReceive -= Connection_DataReceive;

                GlobalSettings.formDescarga = new frm_Descarga(this, descarga);
                GlobalSettings.formDescarga.Show();

                this.Hide();
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void frm_ListDescargas_VisibleChanged(object sender, EventArgs e)
        {
            if (!_enArranque && this.Visible)
            {
                timer1.Enabled = true;
                hub.Hub_DataReceive += Connection_DataReceive;
            }

            if (_enArranque) _enArranque = false;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                BorrarDatos();
                await ObtenerDescargas();
            }
            catch
            {
                
            }
            finally
            {
                timer1.Enabled = true;
            }
        }

        //private void CrearRegistros()
        //{
        //    _descargas = new List<Descarga>
        //    {
        //        new Descarga{DescargaId = 12345, DescargaAgencia = "FORD", DescargaRuta = "ABCD", DescargaTurno = "A", DescargaMatricula = "ABC12345", DescargaFecha = DateTime.Now},
        //        new Descarga{DescargaId = 69699, DescargaAgencia = "FORD2", DescargaRuta = "ZSDX", DescargaTurno = "B", DescargaMatricula = "AXC45689", DescargaFecha = DateTime.Now},
        //        new Descarga{DescargaId = 45698, DescargaAgencia = "KEMERICH", DescargaRuta = "XZ123E", DescargaTurno = "A", DescargaMatricula = "CDD58247", DescargaFecha = DateTime.Now},
        //        new Descarga{DescargaId = 69123, DescargaAgencia = "NANFOR", DescargaRuta = "ZA12WS", DescargaTurno = "C", DescargaMatricula = "DLR52654", DescargaFecha = DateTime.Now},
        //    };

        //    if (_descargas.Count > 0)
        //    {
        //        dgv.Rows.Clear();
        //        int i = 0;
        //        _enCarga = true;
        //        foreach (var item in _descargas)
        //        {
        //            dgv.Rows.Add();
        //            dgv.Rows[i].Cells["Id"].Value = item.DescargaId;
        //            dgv.Rows[i].Cells["Descarga"].Value = item.DescargaId;
        //            dgv.Rows[i].Cells["Fecha"].Value = item.DescargaFecha;
        //            dgv.Rows[i].Cells["Turno"].Value = item.DescargaTurno;
        //            dgv.Rows[i].Cells["Ruta"].Value = item.DescargaRuta;
        //            dgv.Rows[i].Cells["Agencia"].Value = item.DescargaAgencia;
        //            dgv.Rows[i].Cells["Muelle"].Value = item.DescargaMuelle;
        //            dgv.Rows[i].Cells["Matricula"].Value = item.DescargaMatricula;
        //            i++;
        //        }

        //        dgv.Rows[0].Selected = true;
        //        RellenarDescarga(0);
        //        _enCarga = false;
        //    }
        //}

        #region eventos_botones
        private void btBackAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    dgv.Rows[0].Selected = true;
                    RellenarDescarga(0);
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void btBack_Click(object sender, EventArgs e)
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

                        RellenarDescarga(index);
                    }
                    else
                    {
                        btFowardAll_Click(sender, e);
                    }
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void btFoward_Click(object sender, EventArgs e)
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

                        RellenarDescarga(index);
                    }
                    else
                    {
                        btBackAll_Click(sender, e);
                    }
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void btFowardAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    var ultima = dgv.Rows.Count - 1;
                    dgv.Rows[ultima].Selected = true;

                    RellenarDescarga(ultima);
                }
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0 && !_enCarga)
                {
                    var index = e.RowIndex;
                    dgv.Rows[index].Selected = true;
                    RellenarDescarga(index);
                }
            }
            catch { }//ignoro los errores
        }

        private void Connection_DataReceive(object sender, string e)
        {
            this.BeginInvoke(new Action(() =>
            {

                Aviso.Msg(e, false);

            }));
        }
        #endregion
    }
}
