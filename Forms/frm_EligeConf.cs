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
    public partial class frm_EligeConf : Form
    {
        public frm_EligeConf()
        {
            InitializeComponent();
        }

        int PosX, PosY;

        private void lbTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            PosX = e.X;
            PosY = e.Y;
        }

        private void lbTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            int l;
            int t;
            l = this.Left;
            t = this.Top;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = (l + e.X) - PosX;
                this.Top = (t + e.Y) - PosY;
            }
        }

        private void btnCancelarNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerDato();
        }

        private void ObtenerDato()
        {
            try
            {
                
                if (dgMenu.SelectedRows.Count > 0)
                {
                    DataGridViewSelectedRowCollection dgr = dgMenu.SelectedRows;

                    string param = dgr[0].Cells[1].Value.ToString();
                    AbreConfiguracion(param);
                }
            }
            catch { }
        }

        private void AbreConfiguracion(string dato)
        {
            Frm_Config fr = new Frm_Config();
            fr.ElParametro = dato;

            fr.ShowDialog(this);
            fr.Dispose();
        }

        private void btnAceptarSi_Click(object sender, EventArgs e)
        {
            ObtenerDato();
        }

        private void frm_EligeConf_Load(object sender, EventArgs e)
        {
            dgMenu.Rows.Add("TODOS LOS PARAMETROS","TODOS");
            dgMenu.Rows.Add("CONFIGURACIONES CLOUD", "API");
            dgMenu.Rows.Add("CONFIGURACIONES MSCOMM","COM");
        }
    }
}
