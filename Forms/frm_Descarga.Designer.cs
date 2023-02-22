
namespace Descargas_NET.Forms
{
    partial class frm_Descarga
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
            this.lbAgencia = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbRuta = new System.Windows.Forms.Label();
            this.lbMuelle = new System.Windows.Forms.Label();
            this.lbDescarga = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.btGuardar = new FontAwesome.Sharp.IconButton();
            this.btFowardAll = new FontAwesome.Sharp.IconButton();
            this.btFoward = new FontAwesome.Sharp.IconButton();
            this.btBack = new FontAwesome.Sharp.IconButton();
            this.btBackAll = new FontAwesome.Sharp.IconButton();
            this.btIncidencias = new FontAwesome.Sharp.IconButton();
            this.BtLecturaSimple = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_Q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alerta0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btExit.TabIndex = 27;
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
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 50);
            this.label1.TabIndex = 26;
            this.label1.Text = "DESCARGA MATERIALES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SAP,
            this.Campo_P,
            this.Campo_Q,
            this.Alerta0,
            this.Mensaje,
            this.Campo_N,
            this.Campo_V,
            this.Campo_D,
            this.Campo_S});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(0, 185);
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
            this.dgv.Size = new System.Drawing.Size(792, 298);
            this.dgv.TabIndex = 28;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseClick);
            // 
            // lbAgencia
            // 
            this.lbAgencia.BackColor = System.Drawing.Color.White;
            this.lbAgencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAgencia.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAgencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbAgencia.Location = new System.Drawing.Point(446, 100);
            this.lbAgencia.Name = "lbAgencia";
            this.lbAgencia.Size = new System.Drawing.Size(191, 32);
            this.lbAgencia.TabIndex = 40;
            this.lbAgencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMatricula
            // 
            this.lbMatricula.BackColor = System.Drawing.Color.White;
            this.lbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMatricula.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbMatricula.Location = new System.Drawing.Point(446, 136);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(191, 32);
            this.lbMatricula.TabIndex = 39;
            this.lbMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFecha
            // 
            this.lbFecha.BackColor = System.Drawing.Color.White;
            this.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFecha.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbFecha.Location = new System.Drawing.Point(446, 64);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(191, 32);
            this.lbFecha.TabIndex = 38;
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRuta
            // 
            this.lbRuta.BackColor = System.Drawing.Color.White;
            this.lbRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRuta.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbRuta.Location = new System.Drawing.Point(108, 100);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(191, 32);
            this.lbRuta.TabIndex = 37;
            this.lbRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMuelle
            // 
            this.lbMuelle.BackColor = System.Drawing.Color.White;
            this.lbMuelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMuelle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMuelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbMuelle.Location = new System.Drawing.Point(108, 136);
            this.lbMuelle.Name = "lbMuelle";
            this.lbMuelle.Size = new System.Drawing.Size(191, 32);
            this.lbMuelle.TabIndex = 36;
            this.lbMuelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDescarga
            // 
            this.lbDescarga.BackColor = System.Drawing.Color.White;
            this.lbDescarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDescarga.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbDescarga.Location = new System.Drawing.Point(108, 64);
            this.lbDescarga.Name = "lbDescarga";
            this.lbDescarga.Size = new System.Drawing.Size(191, 32);
            this.lbDescarga.TabIndex = 35;
            this.lbDescarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(340, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 34;
            this.label5.Text = "Agencia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(340, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 32);
            this.label6.TabIndex = 33;
            this.label6.Text = "Matricula:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(340, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 32);
            this.label7.TabIndex = 32;
            this.label7.Text = "Fecha:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ruta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "Muelle:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Descarga:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCantidad
            // 
            this.lbCantidad.BackColor = System.Drawing.Color.White;
            this.lbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCantidad.Font = new System.Drawing.Font("Arial Black", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.lbCantidad.Location = new System.Drawing.Point(643, 64);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(139, 104);
            this.lbCantidad.TabIndex = 41;
            this.lbCantidad.Text = "0";
            this.lbCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.White;
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btGuardar.FlatAppearance.BorderSize = 2;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btGuardar.IconSize = 30;
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.Location = new System.Drawing.Point(270, 489);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btGuardar.Size = new System.Drawing.Size(245, 71);
            this.btGuardar.TabIndex = 46;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
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
            this.btFowardAll.Location = new System.Drawing.Point(663, 489);
            this.btFowardAll.Name = "btFowardAll";
            this.btFowardAll.Size = new System.Drawing.Size(121, 71);
            this.btFowardAll.TabIndex = 45;
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
            this.btFoward.Location = new System.Drawing.Point(536, 489);
            this.btFoward.Name = "btFoward";
            this.btFoward.Size = new System.Drawing.Size(121, 71);
            this.btFoward.TabIndex = 44;
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
            this.btBack.Location = new System.Drawing.Point(131, 489);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(121, 71);
            this.btBack.TabIndex = 43;
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
            this.btBackAll.Location = new System.Drawing.Point(4, 489);
            this.btBackAll.Name = "btBackAll";
            this.btBackAll.Size = new System.Drawing.Size(121, 71);
            this.btBackAll.TabIndex = 42;
            this.btBackAll.UseVisualStyleBackColor = false;
            this.btBackAll.Click += new System.EventHandler(this.BtBackAll_Click);
            // 
            // btIncidencias
            // 
            this.btIncidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btIncidencias.BackColor = System.Drawing.Color.White;
            this.btIncidencias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btIncidencias.FlatAppearance.BorderSize = 2;
            this.btIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncidencias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btIncidencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btIncidencias.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.btIncidencias.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btIncidencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btIncidencias.IconSize = 30;
            this.btIncidencias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btIncidencias.Location = new System.Drawing.Point(572, 0);
            this.btIncidencias.Name = "btIncidencias";
            this.btIncidencias.Size = new System.Drawing.Size(77, 52);
            this.btIncidencias.TabIndex = 47;
            this.btIncidencias.Text = "Incidecias";
            this.btIncidencias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btIncidencias.UseVisualStyleBackColor = false;
            this.btIncidencias.Click += new System.EventHandler(this.BtIncidencias_Click);
            // 
            // BtLecturaSimple
            // 
            this.BtLecturaSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtLecturaSimple.BackColor = System.Drawing.Color.White;
            this.BtLecturaSimple.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtLecturaSimple.FlatAppearance.BorderSize = 2;
            this.BtLecturaSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLecturaSimple.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtLecturaSimple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtLecturaSimple.IconChar = FontAwesome.Sharp.IconChar.SprayCan;
            this.BtLecturaSimple.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtLecturaSimple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtLecturaSimple.IconSize = 30;
            this.BtLecturaSimple.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtLecturaSimple.Location = new System.Drawing.Point(652, 0);
            this.BtLecturaSimple.Name = "BtLecturaSimple";
            this.BtLecturaSimple.Size = new System.Drawing.Size(77, 52);
            this.BtLecturaSimple.TabIndex = 48;
            this.BtLecturaSimple.Text = "Scan 1";
            this.BtLecturaSimple.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtLecturaSimple.UseVisualStyleBackColor = false;
            this.BtLecturaSimple.Click += new System.EventHandler(this.BtLecturaSimple_ClickAsync);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SAP
            // 
            this.SAP.HeaderText = "SAP";
            this.SAP.Name = "SAP";
            this.SAP.ReadOnly = true;
            this.SAP.Width = 70;
            // 
            // Campo_P
            // 
            this.Campo_P.HeaderText = "PART N. (P)";
            this.Campo_P.Name = "Campo_P";
            this.Campo_P.ReadOnly = true;
            this.Campo_P.Width = 105;
            // 
            // Campo_Q
            // 
            this.Campo_Q.HeaderText = "CT (Q)";
            this.Campo_Q.Name = "Campo_Q";
            this.Campo_Q.ReadOnly = true;
            this.Campo_Q.Width = 70;
            // 
            // Alerta0
            // 
            this.Alerta0.HeaderText = "ALT 0";
            this.Alerta0.Name = "Alerta0";
            this.Alerta0.ReadOnly = true;
            this.Alerta0.Width = 60;
            // 
            // Mensaje
            // 
            this.Mensaje.HeaderText = "MSG";
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.ReadOnly = true;
            this.Mensaje.Width = 60;
            // 
            // Campo_N
            // 
            this.Campo_N.HeaderText = "ALBAR. (N)";
            this.Campo_N.Name = "Campo_N";
            this.Campo_N.ReadOnly = true;
            this.Campo_N.Width = 105;
            // 
            // Campo_V
            // 
            this.Campo_V.HeaderText = "PROV. (V)";
            this.Campo_V.Name = "Campo_V";
            this.Campo_V.ReadOnly = true;
            this.Campo_V.Width = 105;
            // 
            // Campo_D
            // 
            this.Campo_D.HeaderText = "FECHA (D)";
            this.Campo_D.Name = "Campo_D";
            this.Campo_D.ReadOnly = true;
            // 
            // Campo_S
            // 
            this.Campo_S.HeaderText = "SERIE (S)";
            this.Campo_S.Name = "Campo_S";
            this.Campo_S.ReadOnly = true;
            this.Campo_S.Width = 85;
            // 
            // frm_Descarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(794, 584);
            this.ControlBox = false;
            this.Controls.Add(this.BtLecturaSimple);
            this.Controls.Add(this.btIncidencias);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btFowardAll);
            this.Controls.Add(this.btFoward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btBackAll);
            this.Controls.Add(this.lbCantidad);
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
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frm_Descarga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Descarga_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Descarga_Load);
            this.VisibleChanged += new System.EventHandler(this.frm_Descarga_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbAgencia;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.Label lbMuelle;
        private System.Windows.Forms.Label lbDescarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCantidad;
        private FontAwesome.Sharp.IconButton btGuardar;
        private FontAwesome.Sharp.IconButton btFowardAll;
        private FontAwesome.Sharp.IconButton btFoward;
        private FontAwesome.Sharp.IconButton btBack;
        private FontAwesome.Sharp.IconButton btBackAll;
        private FontAwesome.Sharp.IconButton btIncidencias;
        private FontAwesome.Sharp.IconButton BtLecturaSimple;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Q;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alerta0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_V;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_S;
    }
}