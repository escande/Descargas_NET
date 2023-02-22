
namespace Descargas_NET.Forms
{
    partial class Frm_Wait
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
            this.pbWait = new System.Windows.Forms.PictureBox();
            this.lbLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWait
            // 
            this.pbWait.Image = global::Descargas_NET.Properties.Resources.spinner;
            this.pbWait.Location = new System.Drawing.Point(26, 12);
            this.pbWait.Name = "pbWait";
            this.pbWait.Size = new System.Drawing.Size(66, 66);
            this.pbWait.TabIndex = 0;
            this.pbWait.TabStop = false;
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.lbLoading.Location = new System.Drawing.Point(4, 88);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(103, 16);
            this.lbLoading.TabIndex = 1;
            this.lbLoading.Text = "Procesando...";
            // 
            // frm_Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(130, 111);
            this.ControlBox = false;
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.pbWait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_Wait";
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWait;
        private System.Windows.Forms.Label lbLoading;
    }
}