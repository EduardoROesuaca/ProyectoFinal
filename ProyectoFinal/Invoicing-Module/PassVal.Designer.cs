namespace ProyectoFinal.Invoicing_Module
{
    partial class PassVal
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnLogin.Location = new System.Drawing.Point(107, 269);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(294, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Validar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtAdminPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminPass.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtAdminPass.HideSelection = false;
            this.txtAdminPass.Location = new System.Drawing.Point(107, 198);
            this.txtAdminPass.MaxLength = 15;
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(294, 24);
            this.txtAdminPass.TabIndex = 5;
            this.txtAdminPass.TabStop = false;
            this.txtAdminPass.Text = "Contraseña";
            this.txtAdminPass.Enter += new System.EventHandler(this.txtAdminPass_Enter);
            this.txtAdminPass.Leave += new System.EventHandler(this.txtAdminPass_Leave);
            // 
            // txtAdminName
            // 
            this.txtAdminName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtAdminName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminName.ForeColor = System.Drawing.Color.DimGray;
            this.txtAdminName.Location = new System.Drawing.Point(107, 128);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.ShortcutsEnabled = false;
            this.txtAdminName.Size = new System.Drawing.Size(294, 24);
            this.txtAdminName.TabIndex = 3;
            this.txtAdminName.TabStop = false;
            this.txtAdminName.Text = "Nombre de usuario";
            this.txtAdminName.Click += new System.EventHandler(this.txtAdminName_Click);
            this.txtAdminName.DoubleClick += new System.EventHandler(this.txtAdminName_DoubleClick);
            this.txtAdminName.Enter += new System.EventHandler(this.txtAdminName_Enter);
            this.txtAdminName.Leave += new System.EventHandler(this.txtAdminName_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(92, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(327, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Validacion de Administrador";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassVal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(503, 342);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtAdminPass);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassVal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassVal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label lblTitle;
    }
}