using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Descargas_NET.Forms
{
    public partial class Frm_Wait : Form
    {
        //private readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        //private readonly IntPtr HWND_NOTOPMOST = new IntPtr(2);
        //private readonly IntPtr HWND_TOP = new IntPtr(0);
        //private readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        //private enum SetWindowPosFlags : uint
        //{
        //    SynchronousWindowPosition = 0x4000,
        //    DeferErase = 0x2000,
        //    DrawFrame = 0x0020,
        //    FrameChanged = 0x0020,
        //    HideWindow = 0x0080,
        //    DoNotActivate = 0x0010,
        //    DoNotCopyBits = 0x0100,
        //    IgnoreMove = 0x0002,
        //    DoNotChangeOwnerZOrder = 0x0200,
        //    DoNotRedraw = 0x0008,
        //    DoNotReposition = 0x0200,
        //    DoNotSendChangingEvent = 0x0400,
        //    IgnoreResize = 0x0001,
        //    IgnoreZOrder = 0x0004,
        //    ShowWindow = 0x0040,
        //}

        //private const uint DoNotActivate = 0x0010;
        //private const uint IgnoreMove = 0x0002;
        //private const uint IgnoreResize = 0x0001;

        //[DllImport("user32.dll")]
        //static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public Frm_Wait()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        public Frm_Wait(Form parent, string text)
        {
            InitializeComponent();

            lbLoading.Text = text;
            if(parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(((parent.Location.X + parent.Width) / 2) - (this.Width / 2),
                                            ((parent.Location.Y + parent.Height) / 2) - (this.Height / 2));
                //int posX = ((parent.Location.X + parent.Width) / 2) - (this.Width / 2);
                //int posY = ((parent.Location.Y + parent.Height) / 2) - (this.Height / 2);
                //SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, IgnoreMove | IgnoreResize);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }

        public void CloseWait()
        {
            //SetWindowPos(this.Handle, HWND_NOTOPMOST, 0, 0, 0, 0, DoNotActivate | IgnoreMove | IgnoreResize);
            this.DialogResult = DialogResult.OK;
            this.Close();

            if(pbWait.Image != null)
            {
                pbWait.Image.Dispose();
            }
        }
    }
}
