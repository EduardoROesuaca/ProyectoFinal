namespace ProyectoFinal
{
    partial class PurchasingModule
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsAnalysisToolStripMenuItem,
            this.PurchasesToolStripMenuItem,
            this.NewPurchaseToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.productosToolStripMenuItem.Text = "Administrar";
            // 
            // ProductsAnalysisToolStripMenuItem
            // 
            this.ProductsAnalysisToolStripMenuItem.Name = "ProductsAnalysisToolStripMenuItem";
            this.ProductsAnalysisToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.ProductsAnalysisToolStripMenuItem.Text = "Análisis de Productos";
            this.ProductsAnalysisToolStripMenuItem.Click += new System.EventHandler(this.ProductsAnalysisToolStripMenuItem_Click);
            // 
            // PurchasesToolStripMenuItem
            // 
            this.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem";
            this.PurchasesToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.PurchasesToolStripMenuItem.Text = "Consultar Pedidos";
            this.PurchasesToolStripMenuItem.Click += new System.EventHandler(this.PurchasesToolStripMenuItem_Click);
            // 
            // NewPurchaseToolStripMenuItem
            // 
            this.NewPurchaseToolStripMenuItem.Name = "NewPurchaseToolStripMenuItem";
            this.NewPurchaseToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.NewPurchaseToolStripMenuItem.Text = "Registrar Pedido";
            this.NewPurchaseToolStripMenuItem.Click += new System.EventHandler(this.NewPurchaseToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(375, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Administración de {type}";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Silver;
            this.pnlContainer.Location = new System.Drawing.Point(12, 73);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1177, 715);
            this.pnlContainer.TabIndex = 6;
            // 
            // PurchasingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1201, 798);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchasingModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchasingModule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchasingModule_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsAnalysisToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainer;
    }
}