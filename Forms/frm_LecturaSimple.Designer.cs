
namespace Descargas_NET.Forms
{
    partial class frm_LecturaSimple
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAceptarSi = new FontAwesome.Sharp.IconButton();
            this.btnCancelarNo = new FontAwesome.Sharp.IconButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbLectura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbManual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarSi
            // 
            this.btnAceptarSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptarSi.BackColor = System.Drawing.Color.White;
            this.btnAceptarSi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnAceptarSi.FlatAppearance.BorderSize = 2;
            this.btnAceptarSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnAceptarSi.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnAceptarSi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnAceptarSi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptarSi.IconSize = 30;
            this.btnAceptarSi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptarSi.Location = new System.Drawing.Point(309, 411);
            this.btnAceptarSi.Name = "btnAceptarSi";
            this.btnAceptarSi.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnAceptarSi.Size = new System.Drawing.Size(67, 67);
            this.btnAceptarSi.TabIndex = 47;
            this.btnAceptarSi.Text = "Aceptar";
            this.btnAceptarSi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptarSi.UseVisualStyleBackColor = false;
            this.btnAceptarSi.Click += new System.EventHandler(this.btnAceptarSi_Click);
            // 
            // btnCancelarNo
            // 
            this.btnCancelarNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarNo.BackColor = System.Drawing.Color.White;
            this.btnCancelarNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnCancelarNo.FlatAppearance.BorderSize = 2;
            this.btnCancelarNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnCancelarNo.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCancelarNo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnCancelarNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarNo.IconSize = 30;
            this.btnCancelarNo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarNo.Location = new System.Drawing.Point(382, 411);
            this.btnCancelarNo.Name = "btnCancelarNo";
            this.btnCancelarNo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnCancelarNo.Size = new System.Drawing.Size(67, 67);
            this.btnCancelarNo.TabIndex = 46;
            this.btnCancelarNo.Text = "Cancelar";
            this.btnCancelarNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarNo.UseVisualStyleBackColor = false;
            this.btnCancelarNo.Click += new System.EventHandler(this.btnCancelarNo_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.campo,
            this.lectura});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(4, 145);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(446, 260);
            this.dgv.TabIndex = 45;
            // 
            // campo
            // 
            this.campo.HeaderText = "CAMPO";
            this.campo.Name = "campo";
            this.campo.ReadOnly = true;
            this.campo.Width = 120;
            // 
            // lectura
            // 
            this.lectura.HeaderText = "LECTURA";
            this.lectura.Name = "lectura";
            this.lectura.ReadOnly = true;
            this.lectura.Width = 260;
            // 
            // lbLectura
            // 
            this.lbLectura.BackColor = System.Drawing.Color.White;
            this.lbLectura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLectura.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLectura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbLectura.Location = new System.Drawing.Point(4, 59);
            this.lbLectura.Name = "lbLectura";
            this.lbLectura.Size = new System.Drawing.Size(445, 32);
            this.lbLectura.TabIndex = 48;
            this.lbLectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 52);
            this.label1.TabIndex = 49;
            this.label1.Text = "LECTURA INDIVIDUAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbManual
            // 
            this.tbManual.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbManual.Location = new System.Drawing.Point(187, 104);
            this.tbManual.Name = "tbManual";
            this.tbManual.Size = new System.Drawing.Size(262, 29);
            this.tbManual.TabIndex = 50;
            this.tbManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbManual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbManual_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 51;
            this.label2.Text = "Entrada manual: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_LecturaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 481);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbManual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLectura);
            this.Controls.Add(this.btnAceptarSi);
            this.Controls.Add(this.btnCancelarNo);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_LecturaSimple";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_LecturaSimple_FormClosing);
            this.Load += new System.EventHandler(this.frm_LecturaSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAceptarSi;
        private FontAwesome.Sharp.IconButton btnCancelarNo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectura;
        private System.Windows.Forms.Label lbLectura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbManual;
        private System.Windows.Forms.Label label2;
    }
}