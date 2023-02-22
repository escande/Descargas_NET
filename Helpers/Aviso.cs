using Descargas_NET.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargas_NET.Helpers
{
    static class Aviso
    {
        public static DialogResult Input(string _titulo, ref string _prompText, bool _soloNums)
        {
            frmInput fi = new frmInput(_titulo, _prompText, _soloNums);
            DialogResult dialog = fi.ShowDialog();
            _prompText = fi.Valor;
            fi.Dispose();
            fi = null;

            return dialog;
        }

        public static DialogResult Msg(string prompText, bool yesNo)
        {
            frmMessag fm = new frmMessag(prompText, yesNo);
            DialogResult dialog = fm.ShowDialog();
            fm.Dispose();
            fm = null;

            return dialog;
        }
    }
}
