using Descargas_NET.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Descargas_NET.Services
{
    public class WaitFunction : IWaitFunction
    {
        Frm_Wait _wait;
        Thread _loadThread;
        string _msg;

        public void Show()
        {
            _loadThread = new Thread(new ThreadStart(LoadingProcess));
            _loadThread.Start();
        }

        public void Show(Form parent, string msg)
        {
            _msg = msg;
            _loadThread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            _loadThread.Start(parent);
        }

        public void Close()
        {
            if (_wait != null)
            {
                _wait.BeginInvoke(new ThreadStart(_wait.CloseWait));
                _wait = null;
                _loadThread = null;
            }
        }

        public void LoadingProcess()
        {
            _wait = new Frm_Wait();
            _wait.ShowDialog();
        }

        public void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            _wait = new Frm_Wait(parent1, _msg);
            _wait.ShowDialog();
        }
    }
}
