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
    public partial class FrmPrincDescargas : Form
    {
        private readonly IRepositorio _repositorio;
        private readonly IWaitFunction _wait;
        private readonly IHubClient hub;
        private readonly Frm_Principal _parent;
        private List<DescargaMuelles> _muelles;
        private const string _endPoint = "api/descargamuelles";
        private bool _enCarga = false;
        private readonly Log _log;
        private int _cuentaTicks;
        private bool _enConfig = false;
        private bool _enArranque = true;

        public FrmPrincDescargas(Frm_Principal parent)
        {
            InitializeComponent();

            this._repositorio = Injector.GetService<IRepositorio>();
            this._wait = Injector.GetService<IWaitFunction>();
            this.hub = Injector.GetService<IHubClient>();

            hub.Hub_DataReceive += Connection_DataReceive;

            _log = new Log("Form_PrincipalDescargas");
            _parent = parent;
        }

        private async void Frm_Principal_Load(object sender, EventArgs e)
        {
            _wait.Show(this, "CARGANDO...");
            this.Top = 0;
            this.Left = -5;
            await ObtenerDescargas();
            timer1.Enabled = true;

            await Task.Delay(1000);
            _wait.Close();
            this.Focus();
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
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerDescargas : {ex.Message}");
            }
        }

        private void BorrarDatos()
        {
            dgv.Rows.Clear();
        }

        private void BtDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                var currentIndex = dgv.SelectedRows[0].Index;
                var nave = int.Parse(dgv.Rows[currentIndex].Cells["Id"].Value.ToString());

                hub.Hub_DataReceive -= Connection_DataReceive;

                GlobalSettings.formListDescargas = new frm_ListDescargas(nave, this);
                GlobalSettings.formListDescargas.Show();

                this.Hide();
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {

                _cuentaTicks++;
                if (_cuentaTicks >= 4)
                {
                    _cuentaTicks = 0;
                    BorrarDatos();
                    await ObtenerDescargas();
                }

                if (_cuentaTicks >= 1 && _enConfig)
                {
                    _enConfig = false;
                }

            }
            catch (Exception ex) { _log.EscribirEnFichero($"ERROR en Timer1 : {ex.Message}"); }
            finally { timer1.Enabled = true; }
        }

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

        private void Connection_DataReceive(object sender, string e)
        {
            this.BeginInvoke(new Action(() =>
            {

                Aviso.Msg(e, false);

            }));
        }
        #endregion

        private void Frm_Principal_VisibleChanged(object sender, EventArgs e)
        {
            if (!_enArranque && this.Visible)
            {
                hub.Hub_DataReceive += Connection_DataReceive;
            }

            if (_enArranque) _enArranque = false;
        }

        private void BtExit_Click_1(object sender, EventArgs e)
        {
            hub.Hub_DataReceive -= Connection_DataReceive;
            this.Close();
            _parent.Show();
        }
    }
}
