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
    public partial class frm_Login : Form
    {
        private readonly IRepositorio _repositorio;
        private const string _endPoint = "api/perfilesclientes";
        private readonly Log _log;
        public string Token { get; set; }

        public string Puesto { get; set; }

        public frm_Login()
        {
            InitializeComponent();

            _repositorio = Injector.GetService<IRepositorio>();
            _log = new Log("Login");
            GlobalSettings.MSCommNet._comm_DataReceive += DatosRecibidosEscaner;
        }

        private async void Frm_Login_Load(object sender, EventArgs e)
        {
            _log.EscribirEnFichero("Abriendo formulario de login");

            await ObtenerPuestos();
        }

        private async Task ObtenerPuestos()
        {
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}api/puestos"
                };

                var resp = await _repositorio.Get<List<PuestosCarretilla>>(url.ToString());

                if (!resp.Error)
                {
                    var puestos = resp.Response;

                    //var listadoPuestos = puestos.Select(x => x.Descripcion).ToList();

                    int i = 0;
                    foreach(var sitio in puestos)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[i].Cells[0].Value = sitio.Descripcion;
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerPuestos : {ex.Message}");
            }
        }

        private async void BtnAceptarSi_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(lbUsuario.Text) & !string.IsNullOrEmpty(lbPuesto.Text))
            {
                if(lbErr.Visible)
                {
                    lbErr.Visible = false;
                }
                var respUser = await ObtenerCliente(lbUsuario.Text.ToUpper());

                if (respUser)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private async Task<bool> ObtenerCliente(string cliente)
        {
            bool bResp = false;
            try
            {
                var url = new UriBuilder(GlobalSettings.BASE_SERVER_URL)
                {
                    Path = $"{GlobalSettings.VirtualHost}{_endPoint}/{cliente}"
                };

                var resp = await _repositorio.Get<Perfilesclientes>(url.ToString());

                if (!resp.Error)
                {
                    var perfilCliente = resp.Response;

                    if (perfilCliente != null)
                    {
                        GlobalSettings.UsuarioApp = perfilCliente.PerfilesClientesNombreUsuario.Trim();//.Replace(" ", "");

                        Token = perfilCliente.Token;

                        _log.EscribirEnFichero($"Usuario leido para Login: {perfilCliente.PerfilesClientesNombreUsuario}");

                        bResp = true;
                    }
                    else
                    {
                        lbErr.Visible = true;
                    }
                }

                return bResp;
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en ObtenerCliente : {ex.Message}");
                return bResp;
            }
        }

        private void DatosRecibidosEscaner(LecturaOdette odette)
        {
            try
            {
                if (odette.CodeType == CodeType.Code1D)
                {
                    lbUsuario.BeginInvoke(new Action(() =>
                    {
                        var lectura = odette.Lectura.Replace(((char)13).ToString(), "").Replace(((char)10).ToString(), "");
                        lbUsuario.Text = lectura;
                    }));
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"ERROR en DatosRecibidosEscaner: {ex.Message}");
            }
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalSettings.MSCommNet._comm_DataReceive -= DatosRecibidosEscaner;
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    var index = e.RowIndex;
                    dgv.Rows[index].Selected = true;

                    lbPuesto.Text = dgv.Rows[index].Cells[0].Value.ToString();
                    Puesto = dgv.Rows[index].Cells[0].Value.ToString();
                }
            }
            catch { }
        }
    }
}
