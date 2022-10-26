using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Common
{
    public partial class Home : Form
    {
        String strConexion;
        public Home()
        {
            InitializeComponent();
            this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblName.Text = UserCache.Name;
            if (UserCache.RoleID == 1)
            {
                lblRol.Text = "Cajero";
            }else if (UserCache.RoleID==2)
            {
                lblRol.Text = "Vendedor";
            }
            else
            {
                lblRol.Text = "Administrador de Sistema";
            }

            switch (UserCache.RoleID)
            {
                case 1:
                    this.btnPurchasingModule.Visible = false;
                    this.btnInventoryModule.Visible = false;
                    this.btnSysAdmin.Visible = false;
                    break;
                case 2:
                    this.btnPurchasingModule.Visible = false;
                    this.btnInventoryModule.Visible = false;
                    this.btnSysAdmin.Visible = false;
                    this.btnReports.Visible = false;
                    break;

            }
        }

        private void PBClose_Click(object sender, EventArgs e)
        {

        }

        private void PBMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                using (SqlCommand cmd4 = new SqlCommand("SP_InsertLog", connection))
                {
                    connection.Open();
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@UserID", UserCache.UserID);
                    cmd4.Parameters.AddWithValue("@message", "Nuevo cierre de Sesión!");
                    cmd4.ExecuteNonQuery();
                }
            }

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void plnMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
