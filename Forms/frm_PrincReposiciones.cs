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
    public partial class frm_PrincReposiciones : Form
    {
        private readonly IRepositorio _repositorio;
        private readonly IWaitFunction _wait;
        private readonly IHubClient hub;
        private List<Reposicioneslineas> _reposicioneslineas;
        private const string _endPoint = "api/reposicioneslineas";
        private bool _enCarga = false;
        private int _nave = 1;
        private readonly Log _log;
        private readonly Frm_Principal _parent;
        private bool _enArranque;
        private int _cuentaTicks = 0;
        private bool _enConfig = false;

        public frm_PrincReposiciones(Frm_Principal parent)
        {
            InitializeComponent();

            _repositorio = Injector.GetService<IRepositorio>();
            _wait = Injector.GetService<IWaitFunction>();
            hub = Injector.GetService<IHubClient>();
            hub.Hub_DataReceive += Connection_DataReceive;
            _parent = parent;
            _log = new Log("frm_PrincReposiciones");
        }

        private async void Frm_Principal_Load(object sender, EventArgs e)
        {
            _wait.Show(this, "CARGANDO...");
            this.Top = 0;
            this.Left = -5;
            BorrarDatos();
            await ObtenerReposicionesAgrupadas();
            timer1.Enabled = true;
            //CargarRegistrosMock();

            if (_nave == 1)
            {
                btNave1.BackColor = Color.FromArgb(192, 255, 255);
            }
            else
            {
                btNave2.BackColor = Color.FromArgb(192, 255, 255);
            }

            await Task.Delay(1000);
            _wait.Close();
            this.Focus();
        }

        public async Task ObtenerReposicionesAgrupadas()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}{_endPoint}/listadonaves/{_nave}"
                };

                var resp = await _repositorio.Get<List<Reposicioneslineas>>(url.ToString());

                if (!resp.Error)
                {
                    _reposicioneslineas = resp.Response;

                    //Creo la agrupacion para poder displayar los datos
                    var grouping = _reposicioneslineas.GroupBy(x => x.ReposicionesLineasSector[..1],
                                                                    j => j.ReposicionesLineasSector.Length,
                                                                    (z, y) => new
                                                                    {
                                                                        Sector = z,
                                                                        Reposiciones = y.ToList()
                                                                    }).ToList();

                    if (grouping.Count > 0)
                    {
                        int i = 0;
                        _enCarga = true;
                        foreach (var item in grouping)
                        {
                            dgv.Rows.Add();
                            dgv.Rows[i].Cells["Sector"].Value = item.Sector;
                            dgv.Rows[i].Cells["Reposiciones"].Value = item.Reposiciones.Count;
                            i++;
                        }

                        dgv.Rows[0].Selected = true;
                        _enCarga = false;

                        RellenarDatos(0);

                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerReposicionesAgrupadas : {ex.Message}");
            }
        }

        private void RellenarDatos(int index)
        {

            if (dgv.Rows.Count > 0)
            {
                lbReposicion.Text = dgv.Rows[index].Cells["Reposiciones"].Value.ToString();
                lbSector.Text = dgv.Rows[index].Cells["Sector"].Value.ToString();
            }
        }

        public void BorrarDatos()
        {
            lbReposicion.Text = "0";
            lbSector.Text = "0";
            dgv.Rows.Clear();
        }

        private void BtDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                _cuentaTicks = 0;
                timer1.Enabled = false;
                var currentIndex = dgv.SelectedRows[0].Index;

                hub.Hub_DataReceive -= Connection_DataReceive;

                var sector = dgv.Rows[currentIndex].Cells["Sector"].Value.ToString();
                GlobalSettings.formReposiciones = new FrmReposiciones(_nave, sector, this);
                GlobalSettings.formReposiciones.Show();

                this.Hide();
            }
            catch { }//Me la pela si se produce un error de indice de row o cell
        }

        private void Connection_DataReceive(object sender, string e)
        {
            this.BeginInvoke(new Action(() =>
            {

                Aviso.Msg(e, false);

            }));
        }

        #region eventos_botones
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
                    RellenarDatos(ultima);
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
                    await ObtenerReposicionesAgrupadas();
                }

                if (_cuentaTicks >= 1 && _enConfig)
                {
                    _enConfig = false;
                }
            }
            catch (Exception ex) { _log.EscribirEnFichero($"ERROR en Timer1 : {ex.Message}"); }
            finally { timer1.Enabled = true; }
        }

        private async void BtNave1_Click(object sender, EventArgs e)
        {
            if (_nave != 1)
            {
                _nave = 1;
                _cuentaTicks = 0;
                BorrarDatos();
                await ObtenerReposicionesAgrupadas();
                btNave1.BackColor = Color.FromArgb(192, 255, 255);
                btNave2.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private async void BtNave2_Click(object sender, EventArgs e)
        {
            if (_nave != 2)
            {
                _nave = 2;
                _cuentaTicks = 0;
                BorrarDatos();
                await ObtenerReposicionesAgrupadas();
                btNave2.BackColor = Color.FromArgb(192, 255, 255);
                btNave1.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void Frm_Principal_VisibleChanged(object sender, EventArgs e)
        {
            if (!_enArranque && this.Visible)
            {
                timer1.Enabled = true;
            }

            if (_enArranque) _enArranque = false;
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            hub.Hub_DataReceive -= Connection_DataReceive;
            this.Close();
            _parent.Show();
        }
    }
}
