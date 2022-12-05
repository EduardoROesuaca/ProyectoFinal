using ProyectoFinal.Common;
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

namespace ProyectoFinal.Invoicing_Module
{
    public partial class PassVal : Form
    {
        String strConexion;
        public PassVal()
        {
            InitializeComponent();
            if (Environment.MachineName.Equals("EDUARDO"))
            {
                this.strConexion = "Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";             //EDUARDO-LAPTOP
            }
            else if (Environment.MachineName.Equals("DESKTOP-KQNBJVI"))
            {
                this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO-DESKTOP
            }
            else
            {
                this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //GERALDO
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strConexion);
            using (SqlCommand cmd = new SqlCommand("SP_GETUSERS", connection))
            {
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", txtAdminName.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtAdminPass.Text.Trim());
                SqlDataReader read = cmd.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(read);
                if (tabla.Rows.Count > 0)
                {
                    UserCache.UserID = (int)tabla.Rows[0]["UserId"];
                    UserCache.RoleID = (int)tabla.Rows[0]["RoleId"];
                    UserCache.UserName = tabla.Rows[0]["UserName"].ToString();
                }
                if (UserCache.RoleID.ToString() == "3")
                {
                    MessageBox.Show("Aprobado con exito");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Intento de aprobacion fallido");
                    this.Close();
                }
            }
        }

        private void txtAdminName_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtAdminName_Click(object sender, EventArgs e)
        {
            txtAdminName.Text = "";
        }

        private void txtAdminName_Leave(object sender, EventArgs e)
        {
            if (txtAdminName.Text.Trim().Equals(""))
            {
                txtAdminName.Text = "Nombre de usuario";
            }
        }

        private void txtAdminName_Enter(object sender, EventArgs e)
        {
            if (txtAdminName.Text.Trim().Equals("Nombre de usuario"))
            {
                txtAdminName.Text = "";
            }
        }

        private void txtAdminPass_Leave(object sender, EventArgs e)
        {
            if (txtAdminPass.Text.Trim().Equals(""))
            {
                txtAdminPass.Text = "Contraseña";
                txtAdminPass.PasswordChar = '\0';
            }
        }

        private void txtAdminPass_Enter(object sender, EventArgs e)
        {
            if (txtAdminPass.Text.Trim().Equals("Contraseña"))
            {
                txtAdminPass.PasswordChar = '*';
                txtAdminPass.Text = "";
            }
        }
    }
}
