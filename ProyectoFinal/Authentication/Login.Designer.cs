namespace ProyectoFinal
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.plnImg = new System.Windows.Forms.Panel();
            this.PB = new System.Windows.Forms.PictureBox();
            this.plnContainer = new System.Windows.Forms.Panel();
            this.PBMin = new System.Windows.Forms.PictureBox();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.plnImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.plnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // plnImg
            // 
            this.plnImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.plnImg.Controls.Add(this.PB);
            this.plnImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnImg.Location = new System.Drawing.Point(0, 0);
            this.plnImg.Name = "plnImg";
            this.plnImg.Size = new System.Drawing.Size(290, 461);
            this.plnImg.TabIndex = 3;
            this.plnImg.Paint += new System.Windows.Forms.PaintEventHandler(this.plnImg_Paint);
            // 
            // PB
            // 
            this.PB.Image = global::ProyectoFinal.Properties.Resources.AppLogo;
            this.PB.Location = new System.Drawing.Point(17, 102);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(256, 256);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 0;
            this.PB.TabStop = false;
            // 
            // plnContainer
            // 
            this.plnContainer.Controls.Add(this.PBMin);
            this.plnContainer.Controls.Add(this.PBClose);
            this.plnContainer.Controls.Add(this.btnLogin);
            this.plnContainer.Controls.Add(this.txtPassword);
            this.plnContainer.Controls.Add(this.txtUserName);
            this.plnContainer.Controls.Add(this.lblTitle);
            this.plnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plnContainer.Location = new System.Drawing.Point(290, 0);
            this.plnContainer.Name = "plnContainer";
            this.plnContainer.Size = new System.Drawing.Size(494, 461);
            this.plnContainer.TabIndex = 4;
            this.plnContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.plnContainer_Paint);
            // 
            // PBMin
            // 
            this.PBMin.Image = global::ProyectoFinal.Properties.Resources.MinIcon;
            this.PBMin.Location = new System.Drawing.Point(435, 3);
            this.PBMin.Name = "PBMin";
            this.PBMin.Size = new System.Drawing.Size(25, 25);
            this.PBMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMin.TabIndex = 7;
            this.PBMin.TabStop = false;
            this.PBMin.Click += new System.EventHandler(this.PBMin_Click);
            // 
            // PBClose
            // 
            this.PBClose.Image = global::ProyectoFinal.Properties.Resources.CloseIcon;
            this.PBClose.Location = new System.Drawing.Point(466, 3);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(25, 25);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 6;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(105, 317);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(294, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.HideSelection = false;
            this.txtPassword.Location = new System.Drawing.Point(105, 246);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(294, 24);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.Location = new System.Drawing.Point(105, 176);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ShortcutsEnabled = false;
            this.txtUserName.Size = new System.Drawing.Size(294, 24);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TabStop = false;
            this.txtUserName.Text = "Nombre de usuario";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(100, 81);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(299, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Autenticación de Usuario";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.plnContainer);
            this.Controls.Add(this.plnImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.plnImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.plnContainer.ResumeLayout(false);
            this.plnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plnImg;
        private System.Windows.Forms.Panel plnContainer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox PBMin;
        private System.Windows.Forms.PictureBox PBClose;
    }
}

