
namespace Descargas_NET.Forms
{
    partial class frm_Embalajes
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
            this.btExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbIdLote = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbIdContenedor = new System.Windows.Forms.Label();
            this.btAnotar = new FontAwesome.Sharp.IconButton();
            this.lbLectura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btBorrar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFabricado = new System.Windows.Forms.Label();
            this.lbBloqueado = new System.Windows.Forms.Label();
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
            this.btExit.Location = new System.Drawing.Point(732, 1);
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
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 52);
            this.label1.TabIndex = 31;
            this.label1.Text = "EMBALAJES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(127, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 31);
            this.label6.TabIndex = 47;
            this.label6.Text = "ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.White;
            this.lbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbId.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbId.Location = new System.Drawing.Point(332, 208);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(242, 31);
            this.lbId.TabIndex = 46;
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 49;
            this.label2.Text = "FECHA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbFecha
            // 
            this.lbFecha.BackColor = System.Drawing.Color.White;
            this.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFecha.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFecha.Location = new System.Drawing.Point(332, 342);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(242, 31);
            this.lbFecha.TabIndex = 48;
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(127, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 31);
            this.label7.TabIndex = 53;
            this.label7.Text = "ID LOTE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbIdLote
            // 
            this.lbIdLote.BackColor = System.Drawing.Color.White;
            this.lbIdLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdLote.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIdLote.Location = new System.Drawing.Point(332, 298);
            this.lbIdLote.Name = "lbIdLote";
            this.lbIdLote.Size = new System.Drawing.Size(242, 31);
            this.lbIdLote.TabIndex = 52;
            this.lbIdLote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(112, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 31);
            this.label9.TabIndex = 55;
            this.label9.Text = "ID CONTENEDOR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbIdContenedor
            // 
            this.lbIdContenedor.BackColor = System.Drawing.Color.White;
            this.lbIdContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdContenedor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIdContenedor.Location = new System.Drawing.Point(332, 252);
            this.lbIdContenedor.Name = "lbIdContenedor";
            this.lbIdContenedor.Size = new System.Drawing.Size(242, 31);
            this.lbIdContenedor.TabIndex = 54;
            this.lbIdContenedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAnotar
            // 
            this.btAnotar.BackColor = System.Drawing.Color.White;
            this.btAnotar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btAnotar.FlatAppearance.BorderSize = 2;
            this.btAnotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnotar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAnotar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btAnotar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btAnotar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btAnotar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAnotar.IconSize = 30;
            this.btAnotar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnotar.Location = new System.Drawing.Point(139, 459);
            this.btAnotar.Name = "btAnotar";
            this.btAnotar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btAnotar.Size = new System.Drawing.Size(245, 71);
            this.btAnotar.TabIndex = 56;
            this.btAnotar.Text = "ANOTAR";
            this.btAnotar.UseVisualStyleBackColor = false;
            this.btAnotar.Click += new System.EventHandler(this.BtAnotar_Click);
            // 
            // lbLectura
            // 
            this.lbLectura.BackColor = System.Drawing.Color.White;
            this.lbLectura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLectura.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLectura.Location = new System.Drawing.Point(178, 79);
            this.lbLectura.Name = "lbLectura";
            this.lbLectura.Size = new System.Drawing.Size(604, 31);
            this.lbLectura.TabIndex = 57;
            this.lbLectura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 58;
            this.label4.Text = "LECTURA:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.Color.White;
            this.btBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btBorrar.FlatAppearance.BorderSize = 2;
            this.btBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBorrar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btBorrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btBorrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBorrar.IconSize = 30;
            this.btBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBorrar.Location = new System.Drawing.Point(390, 459);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btBorrar.Size = new System.Drawing.Size(245, 71);
            this.btBorrar.TabIndex = 59;
            this.btBorrar.Text = "BORRAR";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(127, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 31);
            this.label3.TabIndex = 61;
            this.label3.Text = "FABRICADO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFabricado
            // 
            this.lbFabricado.BackColor = System.Drawing.Color.White;
            this.lbFabricado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFabricado.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFabricado.Location = new System.Drawing.Point(332, 388);
            this.lbFabricado.Name = "lbFabricado";
            this.lbFabricado.Size = new System.Drawing.Size(242, 31);
            this.lbFabricado.TabIndex = 60;
            this.lbFabricado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBloqueado
            // 
            this.lbBloqueado.BackColor = System.Drawing.Color.Red;
            this.lbBloqueado.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBloqueado.Location = new System.Drawing.Point(618, 127);
            this.lbBloqueado.Name = "lbBloqueado";
            this.lbBloqueado.Size = new System.Drawing.Size(164, 86);
            this.lbBloqueado.TabIndex = 62;
            this.lbBloqueado.Text = "BLOQUEADO";
            this.lbBloqueado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBloqueado.Visible = false;
            // 
            // frm_Embalajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 584);
            this.ControlBox = false;
            this.Controls.Add(this.lbBloqueado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFabricado);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLectura);
            this.Controls.Add(this.btAnotar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbIdContenedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbIdLote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "frm_Embalajes";
            this.Load += new System.EventHandler(this.Frm_Embalajes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbIdLote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbIdContenedor;
        private FontAwesome.Sharp.IconButton btAnotar;
        private System.Windows.Forms.Label lbLectura;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btBorrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFabricado;
        private System.Windows.Forms.Label lbBloqueado;
    }
}