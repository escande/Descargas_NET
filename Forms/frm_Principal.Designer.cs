
namespace Descargas_NET.Forms
{
    partial class frm_Principal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btSettings = new FontAwesome.Sharp.IconButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btDescargar = new FontAwesome.Sharp.IconButton();
            this.btFowardAll = new FontAwesome.Sharp.IconButton();
            this.btFoward = new FontAwesome.Sharp.IconButton();
            this.btBack = new FontAwesome.Sharp.IconButton();
            this.btBackAll = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsCloud = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSerialPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHub = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.btLogin = new FontAwesome.Sharp.IconButton();
            this.tsVersion = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.White;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btExit.FlatAppearance.BorderSize = 2;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btExit.IconSize = 40;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.Location = new System.Drawing.Point(730, 1);
            this.btExit.Name = "btExit";
            this.btExit.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btExit.Size = new System.Drawing.Size(61, 52);
            this.btExit.TabIndex = 29;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 52);
            this.label1.TabIndex = 28;
            this.label1.Text = "PRINCIPAL DESCARGAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSettings
            // 
            this.btSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSettings.BackColor = System.Drawing.Color.White;
            this.btSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btSettings.FlatAppearance.BorderSize = 2;
            this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSettings.IconSize = 40;
            this.btSettings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSettings.Location = new System.Drawing.Point(665, 1);
            this.btSettings.Name = "btSettings";
            this.btSettings.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btSettings.Size = new System.Drawing.Size(61, 52);
            this.btSettings.TabIndex = 30;
            this.btSettings.UseVisualStyleBackColor = false;
            this.btSettings.Click += new System.EventHandler(this.BtSettings_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAVE});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(97, 156);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(583, 298);
            this.dgv.TabIndex = 31;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // NAVE
            // 
            this.NAVE.HeaderText = "DESCARGA";
            this.NAVE.Name = "NAVE";
            this.NAVE.ReadOnly = true;
            this.NAVE.Width = 300;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(97, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 52);
            this.label2.TabIndex = 32;
            this.label2.Text = "ELIGE NAVE DESCARGA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDescargar
            // 
            this.btDescargar.BackColor = System.Drawing.Color.White;
            this.btDescargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btDescargar.FlatAppearance.BorderSize = 2;
            this.btDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDescargar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDescargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btDescargar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btDescargar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDescargar.IconSize = 30;
            this.btDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDescargar.Location = new System.Drawing.Point(271, 471);
            this.btDescargar.Name = "btDescargar";
            this.btDescargar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btDescargar.Size = new System.Drawing.Size(245, 71);
            this.btDescargar.TabIndex = 37;
            this.btDescargar.Text = "IR A DESCARGA";
            this.btDescargar.UseVisualStyleBackColor = false;
            this.btDescargar.Click += new System.EventHandler(this.BtDescargar_Click);
            // 
            // btFowardAll
            // 
            this.btFowardAll.BackColor = System.Drawing.Color.White;
            this.btFowardAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btFowardAll.FlatAppearance.BorderSize = 2;
            this.btFowardAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFowardAll.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            this.btFowardAll.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btFowardAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btFowardAll.IconSize = 30;
            this.btFowardAll.Location = new System.Drawing.Point(660, 471);
            this.btFowardAll.Name = "btFowardAll";
            this.btFowardAll.Size = new System.Drawing.Size(121, 71);
            this.btFowardAll.TabIndex = 36;
            this.btFowardAll.UseVisualStyleBackColor = false;
            this.btFowardAll.Click += new System.EventHandler(this.BtFowardAll_Click);
            // 
            // btFoward
            // 
            this.btFoward.BackColor = System.Drawing.Color.White;
            this.btFoward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btFoward.FlatAppearance.BorderSize = 2;
            this.btFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFoward.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btFoward.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btFoward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btFoward.IconSize = 30;
            this.btFoward.Location = new System.Drawing.Point(533, 471);
            this.btFoward.Name = "btFoward";
            this.btFoward.Size = new System.Drawing.Size(121, 71);
            this.btFoward.TabIndex = 35;
            this.btFoward.UseVisualStyleBackColor = false;
            this.btFoward.Click += new System.EventHandler(this.BtFoward_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btBack.FlatAppearance.BorderSize = 2;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBack.IconSize = 30;
            this.btBack.Location = new System.Drawing.Point(132, 471);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(121, 71);
            this.btBack.TabIndex = 34;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // btBackAll
            // 
            this.btBackAll.BackColor = System.Drawing.Color.White;
            this.btBackAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btBackAll.FlatAppearance.BorderSize = 2;
            this.btBackAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackAll.IconChar = FontAwesome.Sharp.IconChar.StepBackward;
            this.btBackAll.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btBackAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBackAll.IconSize = 30;
            this.btBackAll.Location = new System.Drawing.Point(5, 471);
            this.btBackAll.Name = "btBackAll";
            this.btBackAll.Size = new System.Drawing.Size(121, 71);
            this.btBackAll.TabIndex = 33;
            this.btBackAll.UseVisualStyleBackColor = false;
            this.btBackAll.Click += new System.EventHandler(this.BtBackAll_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCloud,
            this.tsSerialPort,
            this.tsHub,
            this.tsUser,
            this.tsVersion,
            this.tsHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsCloud
            // 
            this.tsCloud.AutoSize = false;
            this.tsCloud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsCloud.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.tsCloud.Name = "tsCloud";
            this.tsCloud.Size = new System.Drawing.Size(150, 17);
            this.tsCloud.Text = "WEB API";
            // 
            // tsSerialPort
            // 
            this.tsSerialPort.AutoSize = false;
            this.tsSerialPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsSerialPort.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.tsSerialPort.Name = "tsSerialPort";
            this.tsSerialPort.Size = new System.Drawing.Size(150, 17);
            this.tsSerialPort.Text = "MSCOMM1";
            // 
            // tsHub
            // 
            this.tsHub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsHub.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.tsHub.Name = "tsHub";
            this.tsHub.Size = new System.Drawing.Size(77, 17);
            this.tsHub.Text = "WEBSOCKET";
            // 
            // tsUser
            // 
            this.tsUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsUser.ForeColor = System.Drawing.Color.Blue;
            this.tsUser.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(130, 17);
            this.tsUser.Text = "NOMBRE DEL CLIENTE";
            // 
            // tsHora
            // 
            this.tsHora.BackColor = System.Drawing.Color.Black;
            this.tsHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsHora.ForeColor = System.Drawing.Color.Lime;
            this.tsHora.Name = "tsHora";
            this.tsHora.Size = new System.Drawing.Size(221, 17);
            this.tsHora.Spring = true;
            this.tsHora.Text = "01/01/2021 22:00:00";
            this.tsHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogin.BackColor = System.Drawing.Color.White;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btLogin.FlatAppearance.BorderSize = 2;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLogin.IconSize = 40;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLogin.Location = new System.Drawing.Point(600, 1);
            this.btLogin.Name = "btLogin";
            this.btLogin.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btLogin.Size = new System.Drawing.Size(61, 52);
            this.btLogin.TabIndex = 46;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // tsVersion
            // 
            this.tsVersion.BackColor = System.Drawing.Color.Black;
            this.tsVersion.ForeColor = System.Drawing.Color.Lime;
            this.tsVersion.Name = "tsVersion";
            this.tsVersion.Size = new System.Drawing.Size(26, 17);
            this.tsVersion.Text = "Ver.";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 584);
            this.ControlBox = false;
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btDescargar);
            this.Controls.Add(this.btFowardAll);
            this.Controls.Add(this.btFoward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btBackAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.VisibleChanged += new System.EventHandler(this.frm_Principal_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btExit;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btSettings;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btDescargar;
        private FontAwesome.Sharp.IconButton btFowardAll;
        private FontAwesome.Sharp.IconButton btFoward;
        private FontAwesome.Sharp.IconButton btBack;
        private FontAwesome.Sharp.IconButton btBackAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAVE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsCloud;
        private System.Windows.Forms.ToolStripStatusLabel tsSerialPort;
        private System.Windows.Forms.ToolStripStatusLabel tsUser;
        private System.Windows.Forms.ToolStripStatusLabel tsHora;
        private FontAwesome.Sharp.IconButton btLogin;
        private System.Windows.Forms.ToolStripStatusLabel tsHub;
        private System.Windows.Forms.ToolStripStatusLabel tsVersion;
    }
}