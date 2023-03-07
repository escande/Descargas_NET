
namespace Descargas_NET.Forms
{
    partial class frm_PrincReposiciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new System.Windows.Forms.Label();
            dgv = new System.Windows.Forms.DataGridView();
            SECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            REPOSICIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btDescargar = new FontAwesome.Sharp.IconButton();
            btFowardAll = new FontAwesome.Sharp.IconButton();
            btFoward = new FontAwesome.Sharp.IconButton();
            btBack = new FontAwesome.Sharp.IconButton();
            btBackAll = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new System.Windows.Forms.Label();
            btNave1 = new FontAwesome.Sharp.IconButton();
            btNave2 = new FontAwesome.Sharp.IconButton();
            lbSector = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lbReposicion = new System.Windows.Forms.Label();
            btExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.FromArgb(21, 67, 96);
            label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(2, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(720, 52);
            label1.TabIndex = 28;
            label1.Text = "PRINCIPAL REPOSICIONES";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SECTOR, REPOSICIONES });
            dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgv.Location = new System.Drawing.Point(12, 135);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.RowHeadersWidth = 30;
            dgv.RowTemplate.Height = 30;
            dgv.RowTemplate.ReadOnly = true;
            dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dgv.Size = new System.Drawing.Size(504, 330);
            dgv.TabIndex = 31;
            dgv.CellClick += Dgv_CellClick;
            // 
            // SECTOR
            // 
            SECTOR.HeaderText = "SECTOR";
            SECTOR.Name = "SECTOR";
            SECTOR.ReadOnly = true;
            SECTOR.Width = 150;
            // 
            // REPOSICIONES
            // 
            REPOSICIONES.HeaderText = "REPOSICIONES";
            REPOSICIONES.Name = "REPOSICIONES";
            REPOSICIONES.ReadOnly = true;
            REPOSICIONES.Width = 300;
            // 
            // btDescargar
            // 
            btDescargar.BackColor = System.Drawing.Color.White;
            btDescargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btDescargar.FlatAppearance.BorderSize = 2;
            btDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btDescargar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btDescargar.ForeColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btDescargar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btDescargar.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btDescargar.IconSize = 30;
            btDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btDescargar.Location = new System.Drawing.Point(271, 490);
            btDescargar.Name = "btDescargar";
            btDescargar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btDescargar.Size = new System.Drawing.Size(245, 71);
            btDescargar.TabIndex = 37;
            btDescargar.Text = "IR A REPOSICIÓN";
            btDescargar.UseVisualStyleBackColor = false;
            btDescargar.Click += BtDescargar_Click;
            // 
            // btFowardAll
            // 
            btFowardAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btFowardAll.BackColor = System.Drawing.Color.White;
            btFowardAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btFowardAll.FlatAppearance.BorderSize = 2;
            btFowardAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btFowardAll.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            btFowardAll.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btFowardAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btFowardAll.IconSize = 30;
            btFowardAll.Location = new System.Drawing.Point(660, 490);
            btFowardAll.Name = "btFowardAll";
            btFowardAll.Size = new System.Drawing.Size(121, 71);
            btFowardAll.TabIndex = 36;
            btFowardAll.UseVisualStyleBackColor = false;
            btFowardAll.Click += BtFowardAll_Click;
            // 
            // btFoward
            // 
            btFoward.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btFoward.BackColor = System.Drawing.Color.White;
            btFoward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btFoward.FlatAppearance.BorderSize = 2;
            btFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btFoward.IconChar = FontAwesome.Sharp.IconChar.Forward;
            btFoward.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btFoward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btFoward.IconSize = 30;
            btFoward.Location = new System.Drawing.Point(533, 490);
            btFoward.Name = "btFoward";
            btFoward.Size = new System.Drawing.Size(121, 71);
            btFoward.TabIndex = 35;
            btFoward.UseVisualStyleBackColor = false;
            btFoward.Click += BtFoward_Click;
            // 
            // btBack
            // 
            btBack.BackColor = System.Drawing.Color.White;
            btBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btBack.FlatAppearance.BorderSize = 2;
            btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            btBack.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBack.IconSize = 30;
            btBack.Location = new System.Drawing.Point(132, 490);
            btBack.Name = "btBack";
            btBack.Size = new System.Drawing.Size(121, 71);
            btBack.TabIndex = 34;
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += BtBack_Click;
            // 
            // btBackAll
            // 
            btBackAll.BackColor = System.Drawing.Color.White;
            btBackAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btBackAll.FlatAppearance.BorderSize = 2;
            btBackAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btBackAll.IconChar = FontAwesome.Sharp.IconChar.StepBackward;
            btBackAll.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btBackAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBackAll.IconSize = 30;
            btBackAll.Location = new System.Drawing.Point(5, 490);
            btBackAll.Name = "btBackAll";
            btBackAll.Size = new System.Drawing.Size(121, 71);
            btBackAll.TabIndex = 33;
            btBackAll.UseVisualStyleBackColor = false;
            btBackAll.Click += BtBackAll_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += Timer1_Tick;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.BackColor = System.Drawing.Color.White;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(21, 67, 96);
            label2.Location = new System.Drawing.Point(12, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(769, 52);
            label2.TabIndex = 32;
            label2.Text = "ELIGE NAVE DESCARGA";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btNave1
            // 
            btNave1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btNave1.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            btNave1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btNave1.FlatAppearance.BorderSize = 2;
            btNave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btNave1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btNave1.ForeColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btNave1.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btNave1.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btNave1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btNave1.IconSize = 30;
            btNave1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btNave1.Location = new System.Drawing.Point(533, 135);
            btNave1.Name = "btNave1";
            btNave1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btNave1.Size = new System.Drawing.Size(248, 62);
            btNave1.TabIndex = 39;
            btNave1.Text = "Nave 1";
            btNave1.UseVisualStyleBackColor = false;
            btNave1.Click += BtNave1_Click;
            // 
            // btNave2
            // 
            btNave2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btNave2.BackColor = System.Drawing.Color.White;
            btNave2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btNave2.FlatAppearance.BorderSize = 2;
            btNave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btNave2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btNave2.ForeColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btNave2.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btNave2.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btNave2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btNave2.IconSize = 30;
            btNave2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btNave2.Location = new System.Drawing.Point(533, 204);
            btNave2.Name = "btNave2";
            btNave2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btNave2.Size = new System.Drawing.Size(248, 62);
            btNave2.TabIndex = 40;
            btNave2.Text = "Nave 2";
            btNave2.UseVisualStyleBackColor = false;
            btNave2.Click += BtNave2_Click;
            // 
            // lbSector
            // 
            lbSector.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbSector.BackColor = System.Drawing.Color.White;
            lbSector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbSector.Font = new System.Drawing.Font("Arial Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSector.ForeColor = System.Drawing.Color.FromArgb(21, 67, 96);
            lbSector.Location = new System.Drawing.Point(533, 297);
            lbSector.Name = "lbSector";
            lbSector.Size = new System.Drawing.Size(249, 63);
            lbSector.TabIndex = 41;
            lbSector.Text = "0";
            lbSector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            label4.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(533, 267);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(249, 30);
            label4.TabIndex = 42;
            label4.Text = "SECTOR";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            label5.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(532, 367);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(249, 30);
            label5.TabIndex = 44;
            label5.Text = "REPOSICIONES";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbReposicion
            // 
            lbReposicion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbReposicion.BackColor = System.Drawing.Color.White;
            lbReposicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbReposicion.Font = new System.Drawing.Font("Arial Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbReposicion.ForeColor = System.Drawing.Color.FromArgb(21, 67, 96);
            lbReposicion.Location = new System.Drawing.Point(532, 397);
            lbReposicion.Name = "lbReposicion";
            lbReposicion.Size = new System.Drawing.Size(249, 63);
            lbReposicion.TabIndex = 43;
            lbReposicion.Text = "0";
            lbReposicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExit
            // 
            btExit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btExit.BackColor = System.Drawing.Color.White;
            btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btExit.FlatAppearance.BorderSize = 2;
            btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btExit.IconColor = System.Drawing.Color.FromArgb(21, 67, 96);
            btExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btExit.IconSize = 40;
            btExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btExit.Location = new System.Drawing.Point(728, 1);
            btExit.Name = "btExit";
            btExit.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            btExit.Size = new System.Drawing.Size(61, 52);
            btExit.TabIndex = 45;
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += BtExit_Click;
            // 
            // frm_PrincReposiciones
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(794, 584);
            ControlBox = false;
            Controls.Add(btExit);
            Controls.Add(label5);
            Controls.Add(lbReposicion);
            Controls.Add(label4);
            Controls.Add(lbSector);
            Controls.Add(btNave2);
            Controls.Add(btNave1);
            Controls.Add(btDescargar);
            Controls.Add(btFowardAll);
            Controls.Add(btFoward);
            Controls.Add(btBack);
            Controls.Add(btBackAll);
            Controls.Add(label2);
            Controls.Add(dgv);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frm_PrincReposiciones";
            Load += Frm_Principal_Load;
            VisibleChanged += Frm_Principal_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private FontAwesome.Sharp.IconButton btDescargar;
        private FontAwesome.Sharp.IconButton btFowardAll;
        private FontAwesome.Sharp.IconButton btFoward;
        private FontAwesome.Sharp.IconButton btBack;
        private FontAwesome.Sharp.IconButton btBackAll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPOSICIONES;
        private FontAwesome.Sharp.IconButton btNave1;
        private FontAwesome.Sharp.IconButton btNave2;
        private System.Windows.Forms.Label lbSector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbReposicion;
        private FontAwesome.Sharp.IconButton btExit;
    }
}