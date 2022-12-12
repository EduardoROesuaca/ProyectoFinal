namespace ProyectoFinal.Payment_Module
{
    partial class PaymentModule
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
            this.txtTotalDolares = new System.Windows.Forms.TextBox();
            this.txtTotalColones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.txtColones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarFact = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
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
            this.dataFacturacion.Location = new System.Drawing.Point(25, 170);
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
            this.dataFacturacion.TabIndex = 6;
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
            // txtTotalDolares
            // 
            this.txtTotalDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDolares.Location = new System.Drawing.Point(992, 634);
            this.txtTotalDolares.Name = "txtTotalDolares";
            this.txtTotalDolares.ReadOnly = true;
            this.txtTotalDolares.Size = new System.Drawing.Size(139, 22);
            this.txtTotalDolares.TabIndex = 18;
            // 
            // txtTotalColones
            // 
            this.txtTotalColones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalColones.Location = new System.Drawing.Point(992, 594);
            this.txtTotalColones.Name = "txtTotalColones";
            this.txtTotalColones.ReadOnly = true;
            this.txtTotalColones.Size = new System.Drawing.Size(139, 22);
            this.txtTotalColones.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(866, 634);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total $";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(866, 594);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total ₡";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDolares
            // 
            this.txtDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolares.Location = new System.Drawing.Point(683, 634);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(139, 22);
            this.txtDolares.TabIndex = 22;
            // 
            // txtColones
            // 
            this.txtColones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColones.Location = new System.Drawing.Point(683, 594);
            this.txtColones.Name = "txtColones";
            this.txtColones.Size = new System.Drawing.Size(139, 22);
            this.txtColones.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(557, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(557, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "₡";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeta.Location = new System.Drawing.Point(683, 672);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(139, 22);
            this.txtTarjeta.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(557, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tarjeta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtVuelto
            // 
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(992, 672);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.ReadOnly = true;
            this.txtVuelto.Size = new System.Drawing.Size(139, 22);
            this.txtVuelto.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(866, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Vuelto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(428, 75);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(325, 27);
            this.txtNombreCliente.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(206, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 27);
            this.label11.TabIndex = 41;
            this.label11.Text = "Nombre del Cliente";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscarFact
            // 
            this.btnBuscarFact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFact.Location = new System.Drawing.Point(789, 59);
            this.btnBuscarFact.Name = "btnBuscarFact";
            this.btnBuscarFact.Size = new System.Drawing.Size(153, 52);
            this.btnBuscarFact.TabIndex = 43;
            this.btnBuscarFact.Text = "Consultar Facturas";
            this.btnBuscarFact.UseVisualStyleBackColor = true;
            this.btnBuscarFact.Click += new System.EventHandler(this.btnBuscarFact_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(615, 712);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(153, 52);
            this.btnPagar.TabIndex = 44;
            this.btnPagar.Text = "Finalizar Compra";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // PaymentModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1161, 788);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnBuscarFact);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVuelto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.txtColones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalDolares);
            this.Controls.Add(this.txtTotalColones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentModule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaymentModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCatProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImpuestosProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.TextBox txtTotalDolares;
        private System.Windows.Forms.TextBox txtTotalColones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.TextBox txtColones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscarFact;
        private System.Windows.Forms.Button btnPagar;
    }
}