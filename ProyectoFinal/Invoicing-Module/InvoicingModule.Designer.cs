namespace ProyectoFinal
{
    partial class InvoicingModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plnHeader = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dataFacturacion = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalColones = new System.Windows.Forms.TextBox();
            this.txtTotalDolares = new System.Windows.Forms.TextBox();
            this.ColProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCatProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImpuestosProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscarProdID = new System.Windows.Forms.TextBox();
            this.txtBuscarProdNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnQuitarProd = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.PBMin = new System.Windows.Forms.PictureBox();
            this.PB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPagoCol = new System.Windows.Forms.TextBox();
            this.txtPagoDol = new System.Windows.Forms.TextBox();
            this.txtPagoTC = new System.Windows.Forms.TextBox();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bntPagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.plnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.PB);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 886);
            this.panel1.TabIndex = 0;
            // 
            // plnHeader
            // 
            this.plnHeader.Controls.Add(this.PBMin);
            this.plnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.plnHeader.Location = new System.Drawing.Point(259, 0);
            this.plnHeader.Name = "plnHeader";
            this.plnHeader.Size = new System.Drawing.Size(1162, 30);
            this.plnHeader.TabIndex = 2;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(205)))));
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(205)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(33, 774);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(168, 45);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "<<< Regresar";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(72, 52);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(77, 17);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "{RolName}";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(72, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 17);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "{UserName}";
            // 
            // dataFacturacion
            // 
            this.dataFacturacion.AllowUserToAddRows = false;
            this.dataFacturacion.AllowUserToDeleteRows = false;
            this.dataFacturacion.AllowUserToResizeColumns = false;
            this.dataFacturacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFacturacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProdID,
            this.ColNombreProd,
            this.ColCatProd,
            this.ColPrecioProd,
            this.ColCantProd,
            this.ColImpuestosProd,
            this.ColSubTotal});
            this.dataFacturacion.Location = new System.Drawing.Point(300, 242);
            this.dataFacturacion.Name = "dataFacturacion";
            this.dataFacturacion.ReadOnly = true;
            this.dataFacturacion.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFacturacion.Size = new System.Drawing.Size(1109, 428);
            this.dataFacturacion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(1145, 689);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total ₡";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(1145, 723);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total $";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalColones
            // 
            this.txtTotalColones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalColones.Location = new System.Drawing.Point(1271, 689);
            this.txtTotalColones.Name = "txtTotalColones";
            this.txtTotalColones.ReadOnly = true;
            this.txtTotalColones.Size = new System.Drawing.Size(139, 22);
            this.txtTotalColones.TabIndex = 13;
            // 
            // txtTotalDolares
            // 
            this.txtTotalDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDolares.Location = new System.Drawing.Point(1271, 723);
            this.txtTotalDolares.Name = "txtTotalDolares";
            this.txtTotalDolares.ReadOnly = true;
            this.txtTotalDolares.Size = new System.Drawing.Size(139, 22);
            this.txtTotalDolares.TabIndex = 14;
            // 
            // ColProdID
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColProdID.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColProdID.FillWeight = 27.8342F;
            this.ColProdID.HeaderText = "ProdID";
            this.ColProdID.Name = "ColProdID";
            this.ColProdID.ReadOnly = true;
            // 
            // ColNombreProd
            // 
            this.ColNombreProd.FillWeight = 532.9949F;
            this.ColNombreProd.HeaderText = "Nombre";
            this.ColNombreProd.Name = "ColNombreProd";
            this.ColNombreProd.ReadOnly = true;
            this.ColNombreProd.Width = 260;
            // 
            // ColCatProd
            // 
            this.ColCatProd.FillWeight = 27.8342F;
            this.ColCatProd.HeaderText = "Categoria";
            this.ColCatProd.Name = "ColCatProd";
            this.ColCatProd.ReadOnly = true;
            this.ColCatProd.Width = 150;
            // 
            // ColPrecioProd
            // 
            this.ColPrecioProd.FillWeight = 27.8342F;
            this.ColPrecioProd.HeaderText = "Precio";
            this.ColPrecioProd.Name = "ColPrecioProd";
            this.ColPrecioProd.ReadOnly = true;
            this.ColPrecioProd.Width = 150;
            // 
            // ColCantProd
            // 
            this.ColCantProd.FillWeight = 27.8342F;
            this.ColCantProd.HeaderText = "Cantidad";
            this.ColCantProd.Name = "ColCantProd";
            this.ColCantProd.ReadOnly = true;
            this.ColCantProd.Width = 150;
            // 
            // ColImpuestosProd
            // 
            this.ColImpuestosProd.FillWeight = 27.8342F;
            this.ColImpuestosProd.HeaderText = "Impuestos";
            this.ColImpuestosProd.Name = "ColImpuestosProd";
            this.ColImpuestosProd.ReadOnly = true;
            this.ColImpuestosProd.Width = 150;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.FillWeight = 27.8342F;
            this.ColSubTotal.HeaderText = "SubTotal";
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            this.ColSubTotal.Width = 150;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1197, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 30);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1197, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Finalizar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscarProdID
            // 
            this.txtBuscarProdID.Location = new System.Drawing.Point(431, 49);
            this.txtBuscarProdID.Name = "txtBuscarProdID";
            this.txtBuscarProdID.Size = new System.Drawing.Size(139, 20);
            this.txtBuscarProdID.TabIndex = 17;
            // 
            // txtBuscarProdNom
            // 
            this.txtBuscarProdNom.Location = new System.Drawing.Point(431, 95);
            this.txtBuscarProdNom.Name = "txtBuscarProdNom";
            this.txtBuscarProdNom.Size = new System.Drawing.Size(139, 20);
            this.txtBuscarProdNom.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(305, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Producto ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(305, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(664, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 30);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar por ID";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.BackColor = System.Drawing.Color.White;
            this.lblVistaPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrevia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVistaPrevia.Location = new System.Drawing.Point(497, 151);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(289, 19);
            this.lblVistaPrevia.TabIndex = 22;
            this.lblVistaPrevia.Text = "                              ";
            this.lblVistaPrevia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(305, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vista previa Producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(305, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cantidad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProd.Location = new System.Drawing.Point(431, 202);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(60, 22);
            this.txtCantidadProd.TabIndex = 24;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombre.Location = new System.Drawing.Point(664, 92);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(153, 30);
            this.btnBuscarNombre.TabIndex = 26;
            this.btnBuscarNombre.Text = "Buscar por Nombre";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnQuitarProd
            // 
            this.btnQuitarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProd.Location = new System.Drawing.Point(1197, 92);
            this.btnQuitarProd.Name = "btnQuitarProd";
            this.btnQuitarProd.Size = new System.Drawing.Size(171, 30);
            this.btnQuitarProd.TabIndex = 27;
            this.btnQuitarProd.Text = "Quitar Producto";
            this.btnQuitarProd.UseVisualStyleBackColor = true;
            this.btnQuitarProd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1197, 140);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(171, 30);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo Pedido";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // PBMin
            // 
            this.PBMin.Image = global::ProyectoFinal.Properties.Resources.MinIcon;
            this.PBMin.Location = new System.Drawing.Point(1134, 2);
            this.PBMin.Name = "PBMin";
            this.PBMin.Size = new System.Drawing.Size(25, 25);
            this.PBMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMin.TabIndex = 9;
            this.PBMin.TabStop = false;
            this.PBMin.Click += new System.EventHandler(this.PBMin_Click);
            // 
            // PB
            // 
            this.PB.Image = global::ProyectoFinal.Properties.Resources.AppLogo;
            this.PB.Location = new System.Drawing.Point(1, 242);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(256, 256);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 10;
            this.PB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.user_128;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtPagoCol
            // 
            this.txtPagoCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoCol.Location = new System.Drawing.Point(1270, 751);
            this.txtPagoCol.Name = "txtPagoCol";
            this.txtPagoCol.Size = new System.Drawing.Size(139, 22);
            this.txtPagoCol.TabIndex = 29;
            // 
            // txtPagoDol
            // 
            this.txtPagoDol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoDol.Location = new System.Drawing.Point(1271, 779);
            this.txtPagoDol.Name = "txtPagoDol";
            this.txtPagoDol.Size = new System.Drawing.Size(139, 22);
            this.txtPagoDol.TabIndex = 30;
            // 
            // txtPagoTC
            // 
            this.txtPagoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoTC.Location = new System.Drawing.Point(1270, 807);
            this.txtPagoTC.Name = "txtPagoTC";
            this.txtPagoTC.Size = new System.Drawing.Size(139, 22);
            this.txtPagoTC.TabIndex = 31;
            // 
            // txtVuelto
            // 
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(1270, 835);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(139, 22);
            this.txtVuelto.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(1145, 751);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Pago ₡";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(1145, 779);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Pago $";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(1145, 807);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "Pago Tarjeta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(1148, 835);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 36;
            this.label10.Text = "Vuelto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bntPagar
            // 
            this.bntPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPagar.Location = new System.Drawing.Point(884, 803);
            this.bntPagar.Name = "bntPagar";
            this.bntPagar.Size = new System.Drawing.Size(128, 30);
            this.bntPagar.TabIndex = 37;
            this.bntPagar.Text = "Pagar";
            this.bntPagar.UseVisualStyleBackColor = true;
            this.bntPagar.Click += new System.EventHandler(this.bntPagar_Click);
            // 
            // InvoicingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1421, 886);
            this.Controls.Add(this.bntPagar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVuelto);
            this.Controls.Add(this.txtPagoTC);
            this.Controls.Add(this.txtPagoDol);
            this.Controls.Add(this.txtPagoCol);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnQuitarProd);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVistaPrevia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarProdNom);
            this.Controls.Add(this.txtBuscarProdID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotalDolares);
            this.Controls.Add(this.txtTotalColones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataFacturacion);
            this.Controls.Add(this.plnHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoicingModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoicingModule";
            this.Load += new System.EventHandler(this.InvoicingModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plnHeader;
        private System.Windows.Forms.PictureBox PBMin;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCatProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImpuestosProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalColones;
        private System.Windows.Forms.TextBox txtTotalDolares;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscarProdID;
        private System.Windows.Forms.TextBox txtBuscarProdNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnQuitarProd;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtPagoCol;
        private System.Windows.Forms.TextBox txtPagoDol;
        private System.Windows.Forms.TextBox txtPagoTC;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bntPagar;
    }
}