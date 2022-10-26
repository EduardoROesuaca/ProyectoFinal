namespace ProyectoFinal.Common
{
    partial class Home
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
            this.plnMenu = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSysAdmin = new System.Windows.Forms.Button();
            this.btnInventoryModule = new System.Windows.Forms.Button();
            this.btnPurchasingModule = new System.Windows.Forms.Button();
            this.btnInvoicingModule = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.plnHeader = new System.Windows.Forms.Panel();
            this.PBMin = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plnMenu.SuspendLayout();
            this.plnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plnMenu
            // 
            this.plnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.plnMenu.Controls.Add(this.btnReports);
            this.plnMenu.Controls.Add(this.btnSysAdmin);
            this.plnMenu.Controls.Add(this.btnInventoryModule);
            this.plnMenu.Controls.Add(this.btnPurchasingModule);
            this.plnMenu.Controls.Add(this.btnInvoicingModule);
            this.plnMenu.Controls.Add(this.btnLogOut);
            this.plnMenu.Controls.Add(this.pictureBox2);
            this.plnMenu.Controls.Add(this.lblRol);
            this.plnMenu.Controls.Add(this.lblName);
            this.plnMenu.Controls.Add(this.pictureBox1);
            this.plnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnMenu.Location = new System.Drawing.Point(0, 0);
            this.plnMenu.Name = "plnMenu";
            this.plnMenu.Size = new System.Drawing.Size(250, 681);
            this.plnMenu.TabIndex = 0;
            this.plnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.plnMenu_Paint);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(23, 444);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 35);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Modulo de Informes";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnSysAdmin
            // 
            this.btnSysAdmin.Location = new System.Drawing.Point(23, 383);
            this.btnSysAdmin.Name = "btnSysAdmin";
            this.btnSysAdmin.Size = new System.Drawing.Size(200, 35);
            this.btnSysAdmin.TabIndex = 7;
            this.btnSysAdmin.Text = "Modulo de Administración";
            this.btnSysAdmin.UseVisualStyleBackColor = true;
            // 
            // btnInventoryModule
            // 
            this.btnInventoryModule.Location = new System.Drawing.Point(23, 325);
            this.btnInventoryModule.Name = "btnInventoryModule";
            this.btnInventoryModule.Size = new System.Drawing.Size(200, 35);
            this.btnInventoryModule.TabIndex = 6;
            this.btnInventoryModule.Text = "Modulo de Inventario";
            this.btnInventoryModule.UseVisualStyleBackColor = true;
            // 
            // btnPurchasingModule
            // 
            this.btnPurchasingModule.Location = new System.Drawing.Point(23, 270);
            this.btnPurchasingModule.Name = "btnPurchasingModule";
            this.btnPurchasingModule.Size = new System.Drawing.Size(200, 35);
            this.btnPurchasingModule.TabIndex = 5;
            this.btnPurchasingModule.Text = "Modulo de Compras";
            this.btnPurchasingModule.UseVisualStyleBackColor = true;
            // 
            // btnInvoicingModule
            // 
            this.btnInvoicingModule.Location = new System.Drawing.Point(23, 212);
            this.btnInvoicingModule.Name = "btnInvoicingModule";
            this.btnInvoicingModule.Size = new System.Drawing.Size(200, 35);
            this.btnInvoicingModule.TabIndex = 2;
            this.btnInvoicingModule.Text = "Modulo de Facturación";
            this.btnInvoicingModule.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(205)))));
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(205)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(78, 634);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(120, 30);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(81, 52);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(77, 17);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "{RolName}";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(81, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "{UserName}";
            // 
            // plnHeader
            // 
            this.plnHeader.Controls.Add(this.PBMin);
            this.plnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.plnHeader.Location = new System.Drawing.Point(250, 0);
            this.plnHeader.Name = "plnHeader";
            this.plnHeader.Size = new System.Drawing.Size(1014, 30);
            this.plnHeader.TabIndex = 1;
            // 
            // PBMin
            // 
            this.PBMin.Image = global::ProyectoFinal.Properties.Resources.MinIcon;
            this.PBMin.Location = new System.Drawing.Point(986, 0);
            this.PBMin.Name = "PBMin";
            this.PBMin.Size = new System.Drawing.Size(25, 25);
            this.PBMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMin.TabIndex = 9;
            this.PBMin.TabStop = false;
            this.PBMin.Click += new System.EventHandler(this.PBMin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.LogOutLogo;
            this.pictureBox2.Location = new System.Drawing.Point(23, 629);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.user_128;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.plnHeader);
            this.Controls.Add(this.plnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.plnMenu.ResumeLayout(false);
            this.plnMenu.PerformLayout();
            this.plnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plnMenu;
        private System.Windows.Forms.Panel plnHeader;
        private System.Windows.Forms.PictureBox PBMin;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSysAdmin;
        private System.Windows.Forms.Button btnInventoryModule;
        private System.Windows.Forms.Button btnPurchasingModule;
        private System.Windows.Forms.Button btnInvoicingModule;
    }
}