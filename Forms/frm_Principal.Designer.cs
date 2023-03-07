namespace Descargas_NET.Forms
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btLogin = new FontAwesome.Sharp.IconButton();
            btSettings = new FontAwesome.Sharp.IconButton();
            btExit = new FontAwesome.Sharp.IconButton();
            label1 = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            tsCloud = new System.Windows.Forms.ToolStripStatusLabel();
            tsSerialPort = new System.Windows.Forms.ToolStripStatusLabel();
            tsHub = new System.Windows.Forms.ToolStripStatusLabel();
            tsUser = new System.Windows.Forms.ToolStripStatusLabel();
            tsVersion = new System.Windows.Forms.ToolStripStatusLabel();
            tsHora = new System.Windows.Forms.ToolStripStatusLabel();
            BtReposiciones = new FontAwesome.Sharp.IconButton();
            BtDescargas = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btLogin.BackColor = System.Drawing.Color.White;
            btLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btLogin.FlatAppearance.BorderSize = 2;
            btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btLogin.IconChar = FontAwesome.Sharp.IconChar.User;
            btLogin.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btLogin.IconSize = 40;
            btLogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btLogin.Location = new System.Drawing.Point(601, 1);
            btLogin.Name = "btLogin";
            btLogin.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            btLogin.Size = new System.Drawing.Size(61, 52);
            btLogin.TabIndex = 50;
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += BtLogin_Click;
            // 
            // btSettings
            // 
            btSettings.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btSettings.BackColor = System.Drawing.Color.White;
            btSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btSettings.FlatAppearance.BorderSize = 2;
            btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            btSettings.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSettings.IconSize = 40;
            btSettings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btSettings.Location = new System.Drawing.Point(666, 1);
            btSettings.Name = "btSettings";
            btSettings.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            btSettings.Size = new System.Drawing.Size(61, 52);
            btSettings.TabIndex = 49;
            btSettings.UseVisualStyleBackColor = false;
            btSettings.Click += BtSettings_Click;
            // 
            // btExit
            // 
            btExit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btExit.BackColor = System.Drawing.Color.White;
            btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btExit.FlatAppearance.BorderSize = 2;
            btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            btExit.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btExit.IconSize = 40;
            btExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btExit.Location = new System.Drawing.Point(731, 1);
            btExit.Name = "btExit";
            btExit.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            btExit.Size = new System.Drawing.Size(61, 52);
            btExit.TabIndex = 48;
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += BtExit_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.FromArgb(21, 67, 96);
            label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(-1, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(596, 52);
            label1.TabIndex = 47;
            label1.Text = "PRINCIPAL";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsCloud, tsSerialPort, tsHub, tsUser, tsVersion, tsHora });
            statusStrip1.Location = new System.Drawing.Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(794, 22);
            statusStrip1.TabIndex = 51;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsCloud
            // 
            tsCloud.AutoSize = false;
            tsCloud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tsCloud.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            tsCloud.Name = "tsCloud";
            tsCloud.Size = new System.Drawing.Size(150, 17);
            tsCloud.Text = "WEB API";
            // 
            // tsSerialPort
            // 
            tsSerialPort.AutoSize = false;
            tsSerialPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tsSerialPort.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            tsSerialPort.Name = "tsSerialPort";
            tsSerialPort.Size = new System.Drawing.Size(150, 17);
            tsSerialPort.Text = "MSCOMM1";
            // 
            // tsHub
            // 
            tsHub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tsHub.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            tsHub.Name = "tsHub";
            tsHub.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            tsHub.Size = new System.Drawing.Size(97, 17);
            tsHub.Text = "WEBSOCKET";
            // 
            // tsUser
            // 
            tsUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tsUser.ForeColor = System.Drawing.Color.Blue;
            tsUser.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            tsUser.Name = "tsUser";
            tsUser.Size = new System.Drawing.Size(130, 17);
            tsUser.Text = "NOMBRE DEL CLIENTE";
            // 
            // tsVersion
            // 
            tsVersion.BackColor = System.Drawing.Color.Black;
            tsVersion.ForeColor = System.Drawing.Color.Lime;
            tsVersion.Name = "tsVersion";
            tsVersion.Size = new System.Drawing.Size(26, 17);
            tsVersion.Text = "Ver.";
            // 
            // tsHora
            // 
            tsHora.BackColor = System.Drawing.Color.Black;
            tsHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tsHora.ForeColor = System.Drawing.Color.Lime;
            tsHora.Name = "tsHora";
            tsHora.Size = new System.Drawing.Size(201, 17);
            tsHora.Spring = true;
            tsHora.Text = "01/01/2021 22:00:00";
            tsHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtReposiciones
            // 
            BtReposiciones.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtReposiciones.BackColor = System.Drawing.Color.White;
            BtReposiciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            BtReposiciones.FlatAppearance.BorderSize = 2;
            BtReposiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtReposiciones.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtReposiciones.ForeColor = System.Drawing.Color.FromArgb(21, 67, 96);
            BtReposiciones.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            BtReposiciones.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            BtReposiciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtReposiciones.IconSize = 140;
            BtReposiciones.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            BtReposiciones.Location = new System.Drawing.Point(75, 125);
            BtReposiciones.Name = "BtReposiciones";
            BtReposiciones.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            BtReposiciones.Size = new System.Drawing.Size(304, 339);
            BtReposiciones.TabIndex = 54;
            BtReposiciones.Text = "REPOSICIONES";
            BtReposiciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            BtReposiciones.UseVisualStyleBackColor = false;
            BtReposiciones.Click += BtReposiciones_Click;
            // 
            // BtDescargas
            // 
            BtDescargas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtDescargas.BackColor = System.Drawing.Color.White;
            BtDescargas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            BtDescargas.FlatAppearance.BorderSize = 2;
            BtDescargas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtDescargas.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtDescargas.ForeColor = System.Drawing.Color.FromArgb(21, 67, 96);
            BtDescargas.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            BtDescargas.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            BtDescargas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtDescargas.IconSize = 140;
            BtDescargas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            BtDescargas.Location = new System.Drawing.Point(415, 125);
            BtDescargas.Name = "BtDescargas";
            BtDescargas.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            BtDescargas.Size = new System.Drawing.Size(304, 339);
            BtDescargas.TabIndex = 55;
            BtDescargas.Text = "DESCARGAS";
            BtDescargas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            BtDescargas.UseVisualStyleBackColor = false;
            BtDescargas.Click += BtDescargas_Click;
            // 
            // timer1
            // 
            timer1.Interval = 30000;
            timer1.Tick += Timer1_Tick;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(794, 561);
            ControlBox = false;
            Controls.Add(BtDescargas);
            Controls.Add(BtReposiciones);
            Controls.Add(statusStrip1);
            Controls.Add(btLogin);
            Controls.Add(btSettings);
            Controls.Add(btExit);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Frm_Principal";
            FormClosing += Frm_Principal_FormClosing;
            Load += Frm_Principal_Load;
            VisibleChanged += Frm_Principal_VisibleChanged;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btLogin;
        private FontAwesome.Sharp.IconButton btSettings;
        private FontAwesome.Sharp.IconButton btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsCloud;
        private System.Windows.Forms.ToolStripStatusLabel tsSerialPort;
        private System.Windows.Forms.ToolStripStatusLabel tsHub;
        private System.Windows.Forms.ToolStripStatusLabel tsUser;
        private System.Windows.Forms.ToolStripStatusLabel tsVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsHora;
        private FontAwesome.Sharp.IconButton BtReposiciones;
        private FontAwesome.Sharp.IconButton BtDescargas;
        private System.Windows.Forms.Timer timer1;
    }
}