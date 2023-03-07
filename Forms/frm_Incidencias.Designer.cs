
namespace Descargas_NET.Forms
{
    partial class Frm_Incidencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INCIDENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAceptar = new FontAwesome.Sharp.IconButton();
            this.btFowardAll = new FontAwesome.Sharp.IconButton();
            this.btFoward = new FontAwesome.Sharp.IconButton();
            this.btBack = new FontAwesome.Sharp.IconButton();
            this.btBackAll = new FontAwesome.Sharp.IconButton();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.White;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btExit.FlatAppearance.BorderSize = 2;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btExit.IconSize = 40;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.Location = new System.Drawing.Point(732, 0);
            this.btExit.Name = "btExit";
            this.btExit.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btExit.Size = new System.Drawing.Size(61, 52);
            this.btExit.TabIndex = 32;
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
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 52);
            this.label1.TabIndex = 31;
            this.label1.Text = "ANOTAR INCIDENCIAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
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
            this.INCIDENCIA});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(18, 99);
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
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgv.RowTemplate.Height = 30;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(764, 327);
            this.dgv.TabIndex = 33;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // INCIDENCIA
            // 
            this.INCIDENCIA.HeaderText = "INCIDENCIA";
            this.INCIDENCIA.Name = "INCIDENCIA";
            this.INCIDENCIA.ReadOnly = true;
            this.INCIDENCIA.Width = 600;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.White;
            this.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btAceptar.FlatAppearance.BorderSize = 2;
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceptar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btAceptar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAceptar.IconSize = 30;
            this.btAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAceptar.Location = new System.Drawing.Point(273, 486);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btAceptar.Size = new System.Drawing.Size(245, 71);
            this.btAceptar.TabIndex = 53;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
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
            this.btFowardAll.Location = new System.Drawing.Point(664, 486);
            this.btFowardAll.Name = "btFowardAll";
            this.btFowardAll.Size = new System.Drawing.Size(121, 71);
            this.btFowardAll.TabIndex = 52;
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
            this.btFoward.Location = new System.Drawing.Point(537, 486);
            this.btFoward.Name = "btFoward";
            this.btFoward.Size = new System.Drawing.Size(121, 71);
            this.btFoward.TabIndex = 51;
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
            this.btBack.Location = new System.Drawing.Point(136, 486);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(121, 71);
            this.btBack.TabIndex = 50;
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
            this.btBackAll.Location = new System.Drawing.Point(9, 486);
            this.btBackAll.Name = "btBackAll";
            this.btBackAll.Size = new System.Drawing.Size(121, 71);
            this.btBackAll.TabIndex = 49;
            this.btBackAll.UseVisualStyleBackColor = false;
            this.btBackAll.Click += new System.EventHandler(this.BtBackAll_Click);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.BackColor = System.Drawing.Color.White;
            this.lbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDescripcion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescripcion.Location = new System.Drawing.Point(12, 443);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(771, 31);
            this.lbDescripcion.TabIndex = 54;
            this.lbDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsuario
            // 
            this.lbUsuario.BackColor = System.Drawing.Color.White;
            this.lbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUsuario.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsuario.Location = new System.Drawing.Point(18, 60);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(547, 31);
            this.lbUsuario.TabIndex = 55;
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSap
            // 
            this.lbSap.BackColor = System.Drawing.Color.White;
            this.lbSap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSap.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSap.Location = new System.Drawing.Point(571, 60);
            this.lbSap.Name = "lbSap";
            this.lbSap.Size = new System.Drawing.Size(212, 31);
            this.lbSap.TabIndex = 56;
            this.lbSap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 584);
            this.ControlBox = false;
            this.Controls.Add(this.lbSap);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btFowardAll);
            this.Controls.Add(this.btFoward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btBackAll);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frm_Incidencias";
            this.Load += new System.EventHandler(this.Frm_Incidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private FontAwesome.Sharp.IconButton btAceptar;
        private FontAwesome.Sharp.IconButton btFowardAll;
        private FontAwesome.Sharp.IconButton btFoward;
        private FontAwesome.Sharp.IconButton btBack;
        private FontAwesome.Sharp.IconButton btBackAll;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCIDENCIA;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSap;
    }
}