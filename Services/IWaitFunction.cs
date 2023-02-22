using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Descargas_NET.Services
{
    public interface IWaitFunction
    {
        void Close();
        void LoadingProcess();
        void LoadingProcess(object parent);
        void Show();
        void Show(Form parent, string msg);
    }
}
