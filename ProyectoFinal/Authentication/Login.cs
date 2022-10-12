using ProyectoFinal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            UserCache.Name = ""; 
            this.Focus();
        }

        private void plnImg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PBMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.Text = "";
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Equals(""))
            {
                txtUserName.Text = "Nombre de usuario";
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Equals("Nombre de usuario"))
            {
                txtUserName.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Equals(""))
            {
                txtPassword.Text = "Contraseña";
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Equals("Contraseña"))
            {
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           //Logica del login
        }
    }
}
