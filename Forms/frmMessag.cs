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
    public partial class frmMessag : Form
    {
        public frmMessag(string title, bool YesNo)
        {
            InitializeComponent();
            _titulo = title;
            _yesno = YesNo;
        }

        //string _resp;
        string _titulo;
        bool _yesno = false;

        //public string Valor
        //{
        //    get { return _resp; }
        //}

        private void frmInput_Load(object sender, EventArgs e)
        {
            lbCaption.Text = _titulo;
            this.TopMost = true;
            if (!_yesno)
            {
                btnCancelarNo.Visible = false;
                btnAceptarSi.Location = new System.Drawing.Point(398, 159);
            }
        }

        private void btnAceptarSi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
