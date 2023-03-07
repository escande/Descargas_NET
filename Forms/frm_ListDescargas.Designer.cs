
namespace Descargas_NET.Forms
{
    partial class frm_ListDescargas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDescarga = new System.Windows.Forms.Label();
            this.lbMuelle = new System.Windows.Forms.Label();
            this.lbRuta = new System.Windows.Forms.Label();
            this.lbAgencia = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCARGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUELLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATRICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBackAll = new FontAwesome.Sharp.IconButton();
            this.btBack = new FontAwesome.Sharp.IconButton();
            this.btFoward = new FontAwesome.Sharp.IconButton();
            this.btFowardAll = new FontAwesome.Sharp.IconButton();
            this.btDescargar = new FontAwesome.Sharp.IconButton();
            this.btExit = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCARGAS PENDIENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descarga:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Muelle:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ruta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(377, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Agencia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(377, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Matricula:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(377, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDescarga
            // 
            this.lbDescarga.BackColor = System.Drawing.Color.White;
            this.lbDescarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDescarga.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbDescarga.Location = new System.Drawing.Point(162, 61);
            this.lbDescarga.Name = "lbDescarga";
            this.lbDescarga.Size = new System.Drawing.Size(196, 32);
            this.lbDescarga.TabIndex = 7;
            this.lbDescarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMuelle
            // 
            this.lbMuelle.BackColor = System.Drawing.Color.White;
            this.lbMuelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMuelle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMuelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbMuelle.Location = new System.Drawing.Point(162, 133);
            this.lbMuelle.Name = "lbMuelle";
            this.lbMuelle.Size = new System.Drawing.Size(196, 32);
            this.lbMuelle.TabIndex = 8;
            this.lbMuelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRuta
            // 
            this.lbRuta.BackColor = System.Drawing.Color.White;
            this.lbRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRuta.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbRuta.Location = new System.Drawing.Point(162, 97);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(196, 32);
            this.lbRuta.TabIndex = 9;
            this.lbRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAgencia
            // 
            this.lbAgencia.BackColor = System.Drawing.Color.White;
            this.lbAgencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAgencia.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAgencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbAgencia.Location = new System.Drawing.Point(517, 97);
            this.lbAgencia.Name = "lbAgencia";
            this.lbAgencia.Size = new System.Drawing.Size(196, 32);
            this.lbAgencia.TabIndex = 12;
            this.lbAgencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMatricula
            // 
            this.lbMatricula.BackColor = System.Drawing.Color.White;
            this.lbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMatricula.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbMatricula.Location = new System.Drawing.Point(517, 133);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(196, 32);
            this.lbMatricula.TabIndex = 11;
            this.lbMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFecha
            // 
            this.lbFecha.BackColor = System.Drawing.Color.White;
            this.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFecha.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbFecha.Location = new System.Drawing.Point(517, 61);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(196, 32);
            this.lbFecha.TabIndex = 10;
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.DESCARGA,
            this.FECHA,
            this.TURNO,
            this.RUTA,
            this.AGENCIA,
            this.MUELLE,
            this.MATRICULA});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(5, 179);
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
            this.dgv.Size = new System.Drawing.Size(780, 298);
            this.dgv.TabIndex = 13;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DESCARGA
            // 
            this.DESCARGA.HeaderText = "DESCARGA";
            this.DESCARGA.Name = "DESCARGA";
            this.DESCARGA.ReadOnly = true;
            this.DESCARGA.Width = 105;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Width = 105;
            // 
            // TURNO
            // 
            this.TURNO.HeaderText = "TURNO";
            this.TURNO.Name = "TURNO";
            this.TURNO.ReadOnly = true;
            this.TURNO.Width = 105;
            // 
            // RUTA
            // 
            this.RUTA.HeaderText = "RUTA";
            this.RUTA.Name = "RUTA";
            this.RUTA.ReadOnly = true;
            this.RUTA.Width = 105;
            // 
            // AGENCIA
            // 
            this.AGENCIA.HeaderText = "AGENCIA";
            this.AGENCIA.Name = "AGENCIA";
            this.AGENCIA.ReadOnly = true;
            this.AGENCIA.Width = 105;
            // 
            // MUELLE
            // 
            this.MUELLE.HeaderText = "MUELLE";
            this.MUELLE.Name = "MUELLE";
            this.MUELLE.ReadOnly = true;
            this.MUELLE.Width = 105;
            // 
            // MATRICULA
            // 
            this.MATRICULA.HeaderText = "MATRICULA";
            this.MATRICULA.Name = "MATRICULA";
            this.MATRICULA.ReadOnly = true;
            this.MATRICULA.Width = 105;
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
            this.btBackAll.Location = new System.Drawing.Point(5, 485);
            this.btBackAll.Name = "btBackAll";
            this.btBackAll.Size = new System.Drawing.Size(121, 71);
            this.btBackAll.TabIndex = 20;
            this.btBackAll.UseVisualStyleBackColor = false;
            this.btBackAll.Click += new System.EventHandler(this.BtBackAll_Click);
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
            this.btBack.Location = new System.Drawing.Point(132, 485);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(121, 71);
            this.btBack.TabIndex = 21;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.BtBack_Click);
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
            this.btFoward.Location = new System.Drawing.Point(537, 485);
            this.btFoward.Name = "btFoward";
            this.btFoward.Size = new System.Drawing.Size(121, 71);
            this.btFoward.TabIndex = 22;
            this.btFoward.UseVisualStyleBackColor = false;
            this.btFoward.Click += new System.EventHandler(this.BtFoward_Click);
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
            this.btFowardAll.Location = new System.Drawing.Point(664, 485);
            this.btFowardAll.Name = "btFowardAll";
            this.btFowardAll.Size = new System.Drawing.Size(121, 71);
            this.btFowardAll.TabIndex = 23;
            this.btFowardAll.UseVisualStyleBackColor = false;
            this.btFowardAll.Click += new System.EventHandler(this.BtFowardAll_Click);
            // 
            // btDescargar
            // 
            this.btDescargar.BackColor = System.Drawing.Color.White;
            this.btDescargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btDescargar.FlatAppearance.BorderSize = 2;
            this.btDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDescargar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDescargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btDescargar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btDescargar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDescargar.IconSize = 30;
            this.btDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDescargar.Location = new System.Drawing.Point(271, 485);
            this.btDescargar.Name = "btDescargar";
            this.btDescargar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btDescargar.Size = new System.Drawing.Size(245, 71);
            this.btDescargar.TabIndex = 24;
            this.btDescargar.Text = "DESCARGAR";
            this.btDescargar.UseVisualStyleBackColor = false;
            this.btDescargar.Click += new System.EventHandler(this.BtDescargar_Click);
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
            this.btExit.TabIndex = 25;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frm_ListDescargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(794, 584);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDescargar);
            this.Controls.Add(this.btFowardAll);
            this.Controls.Add(this.btFoward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btBackAll);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbAgencia);
            this.Controls.Add(this.lbMatricula);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbRuta);
            this.Controls.Add(this.lbMuelle);
            this.Controls.Add(this.lbDescarga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frm_ListDescargas";
            this.Load += new System.EventHandler(this.Frm_ListDescargas_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_ListDescargas_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDescarga;
        private System.Windows.Forms.Label lbMuelle;
        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.Label lbAgencia;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DataGridView dgv;
        private FontAwesome.Sharp.IconButton btBackAll;
        private FontAwesome.Sharp.IconButton btBack;
        private FontAwesome.Sharp.IconButton btFoward;
        private FontAwesome.Sharp.IconButton btFowardAll;
        private FontAwesome.Sharp.IconButton btDescargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCARGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUELLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATRICULA;
        private FontAwesome.Sharp.IconButton btExit;
        private System.Windows.Forms.Timer timer1;
    }
}