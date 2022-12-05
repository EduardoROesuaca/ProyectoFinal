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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataFacturacion = new System.Windows.Forms.DataGridView();
            this.ColProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCatProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImpuestosProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalColones = new System.Windows.Forms.TextBox();
            this.txtTotalDolares = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscarProdID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnQuitarProd = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtPagoCol = new System.Windows.Forms.TextBox();
            this.txtPagoDol = new System.Windows.Forms.TextBox();
            this.txtPagoTC = new System.Windows.Forms.TextBox();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bntPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFacturacion
            // 
            this.dataFacturacion.AllowUserToAddRows = false;
            this.dataFacturacion.AllowUserToDeleteRows = false;
            this.dataFacturacion.AllowUserToResizeColumns = false;
            this.dataFacturacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataFacturacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProdID,
            this.ColNombreProd,
            this.ColCatProd,
            this.ColPrecioProd,
            this.ColCantProd,
            this.ColImpuestosProd,
            this.ColSubTotal});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFacturacion.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataFacturacion.Location = new System.Drawing.Point(25, 201);
            this.dataFacturacion.Name = "dataFacturacion";
            this.dataFacturacion.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataFacturacion.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFacturacion.Size = new System.Drawing.Size(1109, 400);
            this.dataFacturacion.TabIndex = 5;
            this.dataFacturacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFacturacion_CellContentClick);
            // 
            // ColProdID
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColProdID.DefaultCellStyle = dataGridViewCellStyle15;
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
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(584, 625);
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
            this.label9.Location = new System.Drawing.Point(868, 625);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total $";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalColones
            // 
            this.txtTotalColones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalColones.Location = new System.Drawing.Point(710, 625);
            this.txtTotalColones.Name = "txtTotalColones";
            this.txtTotalColones.ReadOnly = true;
            this.txtTotalColones.Size = new System.Drawing.Size(139, 22);
            this.txtTotalColones.TabIndex = 13;
            // 
            // txtTotalDolares
            // 
            this.txtTotalDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDolares.Location = new System.Drawing.Point(994, 625);
            this.txtTotalDolares.Name = "txtTotalDolares";
            this.txtTotalDolares.ReadOnly = true;
            this.txtTotalDolares.Size = new System.Drawing.Size(139, 22);
            this.txtTotalDolares.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(922, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 30);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(922, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Finalizar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscarProdID
            // 
            this.txtBuscarProdID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProdID.Location = new System.Drawing.Point(170, 12);
            this.txtBuscarProdID.Name = "txtBuscarProdID";
            this.txtBuscarProdID.Size = new System.Drawing.Size(60, 27);
            this.txtBuscarProdID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Producto ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(276, 9);
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
            this.lblVistaPrevia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrevia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVistaPrevia.Location = new System.Drawing.Point(272, 80);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(289, 27);
            this.lblVistaPrevia.TabIndex = 22;
            this.lblVistaPrevia.Text = "                              ";
            this.lblVistaPrevia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Producto seleccionado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(30, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cantidad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProd.Location = new System.Drawing.Point(170, 148);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(60, 27);
            this.txtCantidadProd.TabIndex = 24;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Location = new System.Drawing.Point(473, 9);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(153, 30);
            this.btnBuscarProd.TabIndex = 26;
            this.btnBuscarProd.Text = "Ir a Inventario";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnQuitarProd
            // 
            this.btnQuitarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProd.Location = new System.Drawing.Point(922, 51);
            this.btnQuitarProd.Name = "btnQuitarProd";
            this.btnQuitarProd.Size = new System.Drawing.Size(171, 30);
            this.btnQuitarProd.TabIndex = 27;
            this.btnQuitarProd.Text = "Quitar Producto";
            this.btnQuitarProd.UseVisualStyleBackColor = true;
            this.btnQuitarProd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(922, 99);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(171, 30);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo Pedido";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtPagoCol
            // 
            this.txtPagoCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoCol.Location = new System.Drawing.Point(709, 665);
            this.txtPagoCol.Name = "txtPagoCol";
            this.txtPagoCol.Size = new System.Drawing.Size(139, 22);
            this.txtPagoCol.TabIndex = 29;
            // 
            // txtPagoDol
            // 
            this.txtPagoDol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoDol.Location = new System.Drawing.Point(994, 665);
            this.txtPagoDol.Name = "txtPagoDol";
            this.txtPagoDol.Size = new System.Drawing.Size(139, 22);
            this.txtPagoDol.TabIndex = 30;
            // 
            // txtPagoTC
            // 
            this.txtPagoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoTC.Location = new System.Drawing.Point(709, 705);
            this.txtPagoTC.Name = "txtPagoTC";
            this.txtPagoTC.Size = new System.Drawing.Size(139, 22);
            this.txtPagoTC.TabIndex = 31;
            // 
            // txtVuelto
            // 
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(992, 705);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(139, 22);
            this.txtVuelto.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(584, 665);
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
            this.label6.Location = new System.Drawing.Point(868, 665);
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
            this.label7.Location = new System.Drawing.Point(584, 705);
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
            this.label10.Location = new System.Drawing.Point(870, 705);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 36;
            this.label10.Text = "Vuelto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bntPagar
            // 
            this.bntPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPagar.Location = new System.Drawing.Point(709, 746);
            this.bntPagar.Name = "bntPagar";
            this.bntPagar.Size = new System.Drawing.Size(278, 30);
            this.bntPagar.TabIndex = 37;
            this.bntPagar.Text = "Pagar";
            this.bntPagar.UseVisualStyleBackColor = true;
            this.bntPagar.Click += new System.EventHandler(this.bntPagar_Click);
            // 
            // InvoicingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1161, 788);
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
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVistaPrevia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarProdID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotalDolares);
            this.Controls.Add(this.txtTotalColones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoicingModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoicingModule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InvoicingModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataFacturacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalColones;
        private System.Windows.Forms.TextBox txtTotalDolares;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscarProdID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Button btnBuscarProd;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCatProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImpuestosProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
    }
}