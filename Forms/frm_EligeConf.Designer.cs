namespace Descargas_NET.Forms
{
    partial class frm_EligeConf
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarSi = new FontAwesome.Sharp.IconButton();
            this.btnCancelarNo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.lbTitulo.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(562, 51);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "MENU CONFIGURACIÓN";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseDown);
            this.lbTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseMove);
            // 
            // dgMenu
            // 
            this.dgMenu.AllowUserToAddRows = false;
            this.dgMenu.AllowUserToDeleteRows = false;
            this.dgMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenu.ColumnHeadersVisible = false;
            this.dgMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VALOR,
            this.DATO});
            this.dgMenu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgMenu.Location = new System.Drawing.Point(0, 62);
            this.dgMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgMenu.MultiSelect = false;
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.ReadOnly = true;
            this.dgMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMenu.RowHeadersVisible = false;
            this.dgMenu.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgMenu.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgMenu.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SteelBlue;
            this.dgMenu.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgMenu.RowTemplate.ReadOnly = true;
            this.dgMenu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMenu.Size = new System.Drawing.Size(561, 197);
            this.dgMenu.TabIndex = 1;
            this.dgMenu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenu_CellDoubleClick);
            // 
            // VALOR
            // 
            this.VALOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // DATO
            // 
            this.DATO.HeaderText = "DATO";
            this.DATO.Name = "DATO";
            this.DATO.ReadOnly = true;
            this.DATO.Visible = false;
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
            this.btnAceptarSi.Location = new System.Drawing.Point(418, 285);
            this.btnAceptarSi.Name = "btnAceptarSi";
            this.btnAceptarSi.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnAceptarSi.Size = new System.Drawing.Size(67, 67);
            this.btnAceptarSi.TabIndex = 51;
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
            this.btnCancelarNo.Location = new System.Drawing.Point(491, 285);
            this.btnCancelarNo.Name = "btnCancelarNo";
            this.btnCancelarNo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnCancelarNo.Size = new System.Drawing.Size(67, 67);
            this.btnCancelarNo.TabIndex = 50;
            this.btnCancelarNo.Text = "Cancelar";
            this.btnCancelarNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarNo.UseVisualStyleBackColor = false;
            this.btnCancelarNo.Click += new System.EventHandler(this.btnCancelarNo_Click);
            // 
            // frm_EligeConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 354);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptarSi);
            this.Controls.Add(this.btnCancelarNo);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.lbTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EligeConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_EligeConf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATO;
        private FontAwesome.Sharp.IconButton btnAceptarSi;
        private FontAwesome.Sharp.IconButton btnCancelarNo;
    }
}