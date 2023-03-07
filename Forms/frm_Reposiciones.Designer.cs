
namespace Descargas_NET.Forms
{
    partial class FrmReposiciones
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
            this.lbCabecera = new System.Windows.Forms.Label();
            this.btExit = new FontAwesome.Sharp.IconButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.REPOSICION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCONTENEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFowardAll = new FontAwesome.Sharp.IconButton();
            this.btFoward = new FontAwesome.Sharp.IconButton();
            this.btBack = new FontAwesome.Sharp.IconButton();
            this.btBackAll = new FontAwesome.Sharp.IconButton();
            this.lbPN = new System.Windows.Forms.Label();
            this.lbSap = new System.Windows.Forms.Label();
            this.lbUbicacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.btAnular = new FontAwesome.Sharp.IconButton();
            this.btEmbalajes = new FontAwesome.Sharp.IconButton();
            this.lbEscaner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtAlerta0 = new FontAwesome.Sharp.IconButton();
            this.BtAlertaMinimo = new FontAwesome.Sharp.IconButton();
            this.BtIncidencia = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCabecera
            // 
            this.lbCabecera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.lbCabecera.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCabecera.ForeColor = System.Drawing.Color.White;
            this.lbCabecera.Location = new System.Drawing.Point(-3, 0);
            this.lbCabecera.Name = "lbCabecera";
            this.lbCabecera.Size = new System.Drawing.Size(731, 52);
            this.lbCabecera.TabIndex = 29;
            this.lbCabecera.Text = "PRINCIPAL REPOSICIONES";
            this.lbCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btExit.Location = new System.Drawing.Point(731, 0);
            this.btExit.Name = "btExit";
            this.btExit.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btExit.Size = new System.Drawing.Size(61, 52);
            this.btExit.TabIndex = 30;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
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
            this.REPOSICION,
            this.SAP,
            this.UBICACION,
            this.IDK,
            this.TCONTENEDOR,
            this.SECTOR});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(18, 164);
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
            this.dgv.Size = new System.Drawing.Size(764, 248);
            this.dgv.TabIndex = 32;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // REPOSICION
            // 
            this.REPOSICION.HeaderText = "REPOSICION";
            this.REPOSICION.Name = "REPOSICION";
            this.REPOSICION.ReadOnly = true;
            this.REPOSICION.Width = 115;
            // 
            // SAP
            // 
            this.SAP.HeaderText = "SAP";
            this.SAP.Name = "SAP";
            this.SAP.ReadOnly = true;
            this.SAP.Width = 115;
            // 
            // UBICACION
            // 
            this.UBICACION.HeaderText = "UBICACION";
            this.UBICACION.Name = "UBICACION";
            this.UBICACION.ReadOnly = true;
            this.UBICACION.Width = 115;
            // 
            // IDK
            // 
            this.IDK.HeaderText = "P. NUMBER";
            this.IDK.Name = "IDK";
            this.IDK.ReadOnly = true;
            this.IDK.Width = 115;
            // 
            // TCONTENEDOR
            // 
            this.TCONTENEDOR.HeaderText = "TIPO CONT.";
            this.TCONTENEDOR.Name = "TCONTENEDOR";
            this.TCONTENEDOR.ReadOnly = true;
            this.TCONTENEDOR.Width = 115;
            // 
            // SECTOR
            // 
            this.SECTOR.HeaderText = "SECTOR";
            this.SECTOR.Name = "SECTOR";
            this.SECTOR.ReadOnly = true;
            this.SECTOR.Width = 115;
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
            this.btFowardAll.Location = new System.Drawing.Point(664, 517);
            this.btFowardAll.Name = "btFowardAll";
            this.btFowardAll.Size = new System.Drawing.Size(121, 63);
            this.btFowardAll.TabIndex = 40;
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
            this.btFoward.Location = new System.Drawing.Point(537, 517);
            this.btFoward.Name = "btFoward";
            this.btFoward.Size = new System.Drawing.Size(121, 63);
            this.btFoward.TabIndex = 39;
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
            this.btBack.Location = new System.Drawing.Point(136, 517);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(121, 63);
            this.btBack.TabIndex = 38;
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
            this.btBackAll.Location = new System.Drawing.Point(9, 517);
            this.btBackAll.Name = "btBackAll";
            this.btBackAll.Size = new System.Drawing.Size(121, 63);
            this.btBackAll.TabIndex = 37;
            this.btBackAll.UseVisualStyleBackColor = false;
            this.btBackAll.Click += new System.EventHandler(this.BtBackAll_Click);
            // 
            // lbPN
            // 
            this.lbPN.BackColor = System.Drawing.Color.White;
            this.lbPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPN.Location = new System.Drawing.Point(18, 92);
            this.lbPN.Name = "lbPN";
            this.lbPN.Size = new System.Drawing.Size(242, 31);
            this.lbPN.TabIndex = 41;
            this.lbPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSap
            // 
            this.lbSap.BackColor = System.Drawing.Color.White;
            this.lbSap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSap.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSap.Location = new System.Drawing.Point(280, 92);
            this.lbSap.Name = "lbSap";
            this.lbSap.Size = new System.Drawing.Size(242, 31);
            this.lbSap.TabIndex = 42;
            this.lbSap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUbicacion
            // 
            this.lbUbicacion.BackColor = System.Drawing.Color.White;
            this.lbUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUbicacion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUbicacion.Location = new System.Drawing.Point(543, 92);
            this.lbUbicacion.Name = "lbUbicacion";
            this.lbUbicacion.Size = new System.Drawing.Size(242, 31);
            this.lbUbicacion.TabIndex = 43;
            this.lbUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 31);
            this.label5.TabIndex = 44;
            this.label5.Text = "PART NUMBER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(290, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 31);
            this.label6.TabIndex = 45;
            this.label6.Text = "SAP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(556, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 31);
            this.label7.TabIndex = 46;
            this.label7.Text = "UBICACIÓN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.BackColor = System.Drawing.Color.White;
            this.lbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDescripcion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescripcion.Location = new System.Drawing.Point(18, 127);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(767, 31);
            this.lbDescripcion.TabIndex = 47;
            this.lbDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAnular
            // 
            this.btAnular.BackColor = System.Drawing.Color.White;
            this.btAnular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btAnular.FlatAppearance.BorderSize = 2;
            this.btAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnular.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAnular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btAnular.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btAnular.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btAnular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAnular.IconSize = 30;
            this.btAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnular.Location = new System.Drawing.Point(273, 517);
            this.btAnular.Name = "btAnular";
            this.btAnular.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btAnular.Size = new System.Drawing.Size(245, 63);
            this.btAnular.TabIndex = 48;
            this.btAnular.Text = "ANULAR";
            this.btAnular.UseVisualStyleBackColor = false;
            this.btAnular.Click += new System.EventHandler(this.BtAnular_Click);
            // 
            // btEmbalajes
            // 
            this.btEmbalajes.BackColor = System.Drawing.Color.White;
            this.btEmbalajes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btEmbalajes.FlatAppearance.BorderSize = 2;
            this.btEmbalajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmbalajes.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEmbalajes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btEmbalajes.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btEmbalajes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btEmbalajes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btEmbalajes.IconSize = 20;
            this.btEmbalajes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEmbalajes.Location = new System.Drawing.Point(642, 0);
            this.btEmbalajes.Name = "btEmbalajes";
            this.btEmbalajes.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btEmbalajes.Size = new System.Drawing.Size(83, 52);
            this.btEmbalajes.TabIndex = 49;
            this.btEmbalajes.Text = "EMBALAJES";
            this.btEmbalajes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEmbalajes.UseVisualStyleBackColor = false;
            this.btEmbalajes.Click += new System.EventHandler(this.BtEmbalajes_Click);
            // 
            // lbEscaner
            // 
            this.lbEscaner.BackColor = System.Drawing.Color.White;
            this.lbEscaner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEscaner.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEscaner.Location = new System.Drawing.Point(154, 416);
            this.lbEscaner.Name = "lbEscaner";
            this.lbEscaner.Size = new System.Drawing.Size(628, 31);
            this.lbEscaner.TabIndex = 50;
            this.lbEscaner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "ESCANER:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BtAlerta0
            // 
            this.BtAlerta0.BackColor = System.Drawing.Color.White;
            this.BtAlerta0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtAlerta0.FlatAppearance.BorderSize = 2;
            this.BtAlerta0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAlerta0.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtAlerta0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtAlerta0.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.BtAlerta0.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtAlerta0.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtAlerta0.IconSize = 30;
            this.BtAlerta0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAlerta0.Location = new System.Drawing.Point(9, 450);
            this.BtAlerta0.Name = "BtAlerta0";
            this.BtAlerta0.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtAlerta0.Size = new System.Drawing.Size(121, 63);
            this.BtAlerta0.TabIndex = 52;
            this.BtAlerta0.Text = "Alerta 0";
            this.BtAlerta0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAlerta0.UseVisualStyleBackColor = false;
            this.BtAlerta0.Click += new System.EventHandler(this.BtAlerta0_Click);
            // 
            // BtAlertaMinimo
            // 
            this.BtAlertaMinimo.BackColor = System.Drawing.Color.White;
            this.BtAlertaMinimo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtAlertaMinimo.FlatAppearance.BorderSize = 2;
            this.BtAlertaMinimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAlertaMinimo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtAlertaMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtAlertaMinimo.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.BtAlertaMinimo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtAlertaMinimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtAlertaMinimo.IconSize = 30;
            this.BtAlertaMinimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAlertaMinimo.Location = new System.Drawing.Point(136, 450);
            this.BtAlertaMinimo.Name = "BtAlertaMinimo";
            this.BtAlertaMinimo.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.BtAlertaMinimo.Size = new System.Drawing.Size(121, 63);
            this.BtAlertaMinimo.TabIndex = 53;
            this.BtAlertaMinimo.Text = "Alerta Min.";
            this.BtAlertaMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAlertaMinimo.UseVisualStyleBackColor = false;
            this.BtAlertaMinimo.Click += new System.EventHandler(this.BtAlertaMinimo_Click);
            // 
            // BtIncidencia
            // 
            this.BtIncidencia.BackColor = System.Drawing.Color.White;
            this.BtIncidencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtIncidencia.FlatAppearance.BorderSize = 2;
            this.BtIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncidencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtIncidencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtIncidencia.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
            this.BtIncidencia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtIncidencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtIncidencia.IconSize = 30;
            this.BtIncidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtIncidencia.Location = new System.Drawing.Point(661, 450);
            this.BtIncidencia.Name = "BtIncidencia";
            this.BtIncidencia.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtIncidencia.Size = new System.Drawing.Size(121, 63);
            this.BtIncidencia.TabIndex = 54;
            this.BtIncidencia.Text = "Incidencia";
            this.BtIncidencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtIncidencia.UseVisualStyleBackColor = false;
            this.BtIncidencia.Click += new System.EventHandler(this.BtIncidencia_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frm_Reposiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 584);
            this.ControlBox = false;
            this.Controls.Add(this.BtIncidencia);
            this.Controls.Add(this.BtAlertaMinimo);
            this.Controls.Add(this.BtAlerta0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbEscaner);
            this.Controls.Add(this.btAnular);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbUbicacion);
            this.Controls.Add(this.lbSap);
            this.Controls.Add(this.lbPN);
            this.Controls.Add(this.btFowardAll);
            this.Controls.Add(this.btFoward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btBackAll);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbCabecera);
            this.Controls.Add(this.btEmbalajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Reposiciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Reposiciones_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Reposiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCabecera;
        private FontAwesome.Sharp.IconButton btExit;
        private System.Windows.Forms.DataGridView dgv;
        private FontAwesome.Sharp.IconButton btFowardAll;
        private FontAwesome.Sharp.IconButton btFoward;
        private FontAwesome.Sharp.IconButton btBack;
        private FontAwesome.Sharp.IconButton btBackAll;
        private System.Windows.Forms.Label lbPN;
        private System.Windows.Forms.Label lbSap;
        private System.Windows.Forms.Label lbUbicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDescripcion;
        private FontAwesome.Sharp.IconButton btAnular;
        private FontAwesome.Sharp.IconButton btEmbalajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPOSICION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCONTENEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECTOR;
        private System.Windows.Forms.Label lbEscaner;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtAlerta0;
        private FontAwesome.Sharp.IconButton BtAlertaMinimo;
        private FontAwesome.Sharp.IconButton BtIncidencia;
        private System.Windows.Forms.Timer timer1;
    }
}