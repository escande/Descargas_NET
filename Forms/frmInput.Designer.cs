namespace Descargas_NET.Forms
{
    partial class frmInput
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbResp = new System.Windows.Forms.TextBox();
            this.lbCaption = new System.Windows.Forms.Label();
            this.btnAceptarSi = new FontAwesome.Sharp.IconButton();
            this.btnCancelarNo = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(507, 53);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Aviso";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResp
            // 
            this.tbResp.AcceptsTab = true;
            this.tbResp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbResp.Location = new System.Drawing.Point(33, 141);
            this.tbResp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResp.Name = "tbResp";
            this.tbResp.Size = new System.Drawing.Size(455, 27);
            this.tbResp.TabIndex = 0;
            this.tbResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbResp_KeyPress);
            // 
            // lbCaption
            // 
            this.lbCaption.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCaption.Location = new System.Drawing.Point(33, 78);
            this.lbCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(456, 59);
            this.lbCaption.TabIndex = 38;
            this.lbCaption.Text = "label1";
            // 
            // btnAceptarSi
            // 
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
            this.btnAceptarSi.Location = new System.Drawing.Point(388, 182);
            this.btnAceptarSi.Name = "btnAceptarSi";
            this.btnAceptarSi.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnAceptarSi.Size = new System.Drawing.Size(67, 67);
            this.btnAceptarSi.TabIndex = 42;
            this.btnAceptarSi.Text = "Aceptar";
            this.btnAceptarSi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptarSi.UseVisualStyleBackColor = false;
            this.btnAceptarSi.Click += new System.EventHandler(this.btnAceptarSi_Click);
            // 
            // btnCancelarNo
            // 
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
            this.btnCancelarNo.Location = new System.Drawing.Point(461, 182);
            this.btnCancelarNo.Name = "btnCancelarNo";
            this.btnCancelarNo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnCancelarNo.Size = new System.Drawing.Size(67, 67);
            this.btnCancelarNo.TabIndex = 41;
            this.btnCancelarNo.Text = "Cancelar";
            this.btnCancelarNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarNo.UseVisualStyleBackColor = false;
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelarNo;
            this.ClientSize = new System.Drawing.Size(534, 255);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptarSi);
            this.Controls.Add(this.btnCancelarNo);
            this.Controls.Add(this.lbCaption);
            this.Controls.Add(this.tbResp);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbResp;
        private System.Windows.Forms.Label lbCaption;
        private FontAwesome.Sharp.IconButton btnAceptarSi;
        private FontAwesome.Sharp.IconButton btnCancelarNo;
    }
}