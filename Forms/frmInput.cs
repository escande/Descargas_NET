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
    public partial class frmInput : Form
    {
        public frmInput(string title, string promptText, bool SoloNumero)
        {
            InitializeComponent();
            _titulo = title;
            _pText = promptText;
            _onlyNumber = SoloNumero;
        }

        string _titulo, _pText, _resp;
        bool _onlyNumber = false;

        public string Valor
        {
            get { return _resp; }
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            lbCaption.Text = _titulo;
            tbResp.Text = _pText;
            this.TopMost = true;
            //tbResp.Focus();
        }

        private void btnAceptarSi_Click(object sender, EventArgs e)
        {
            _resp = !string.IsNullOrEmpty(tbResp.Text.Trim()) ? tbResp.Text : null;
            this.Close();
        }

        private void tbResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_onlyNumber)
            {
                int keyValue = Convert.ToInt32(e.KeyChar);
                if ((keyValue >= 48 && keyValue < 58) || keyValue == 8)
                    return;
                else
                {
                    e.KeyChar = (char)8;
                }
            }
        }
    }
}
