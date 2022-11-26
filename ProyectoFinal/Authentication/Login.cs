using ProyectoFinal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        #region Propiedades
        public string strConexion;
        int retries = 0;
        #endregion

        public Login()
        {
            InitializeComponent();
            this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";
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
            this.retries++;
            if (this.retries < 4)
            {

                SqlConnection connection = new SqlConnection(strConexion);
                using (SqlCommand cmd = new SqlCommand("SP_GETUSERS", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                    SqlDataReader read = cmd.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(read);
                    if (tabla.Rows.Count > 0)
                    {
                        UserCache.UserID = (int)tabla.Rows[0]["UserId"];
                        UserCache.RoleID = (int)tabla.Rows[0]["RoleId"];
                        UserCache.UserName = tabla.Rows[0]["UserName"].ToString();
                        UserCache.Name = tabla.Rows[0]["Name"].ToString();
                        UserCache.LastName = tabla.Rows[0]["LastName"].ToString();
                        UserCache.Email = tabla.Rows[0]["Email"].ToString();
                        UserCache.Mobile = tabla.Rows[0]["Mobile"].ToString();
                        UserCache.isLockedOut = bool.Parse(tabla.Rows[0]["IsLockedOut"].ToString());
                        UserCache.CreateDate = DateTime.Parse(tabla.Rows[0]["CreateDate"].ToString());
                        UserCache.LastActivityDate = DateTime.Parse(tabla.Rows[0]["LastActivityDate"].ToString());
                        UserCache.FailedPasswordAttemptCount = (int)tabla.Rows[0]["FailedPasswordAttemptCount"];

                        if (UserCache.FailedPasswordAttemptCount > 2)
                        {
                            using (SqlCommand cmd5 = new SqlCommand("SP_LockUser", connection))
                            {
                                cmd5.CommandType = CommandType.StoredProcedure;
                                cmd5.Parameters.AddWithValue("@UserID", UserCache.UserID);
                                cmd5.ExecuteNonQuery();

                            }
                            using (SqlCommand cmd6 = new SqlCommand("SP_InsertLog", connection))
                            {
                                cmd6.CommandType = CommandType.StoredProcedure;
                                cmd6.Parameters.AddWithValue("@UserID", UserCache.UserID);
                                cmd6.Parameters.AddWithValue("@message", "Usuario ha sido bloqueado!");
                                cmd6.ExecuteNonQuery();

                            }
                            MessageBox.Show("Usuario bloqueado, contacte al administrador del sistema", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            using (SqlCommand cmd4 = new SqlCommand("SP_InsertLog", connection))
                            {
                                cmd4.CommandType = CommandType.StoredProcedure;
                                cmd4.Parameters.AddWithValue("@UserID", UserCache.UserID);
                                cmd4.Parameters.AddWithValue("@message", "Nuevo inicio de Sesión!");
                                cmd4.ExecuteNonQuery();
                            }
                            Home home = new Home();
                            home.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd2 = new SqlCommand("SP_CheckUser", connection))
                        {
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                            SqlDataReader read2 = cmd2.ExecuteReader();
                            DataTable tabla2 = new DataTable();
                            tabla2.Load(read2);
                            if (tabla2.Rows.Count > 0)
                            {
                                using (SqlCommand cmd3 = new SqlCommand("SP_IncrementCountDown", connection))
                                {
                                    cmd3.CommandType = CommandType.StoredProcedure;
                                    cmd3.Parameters.AddWithValue("@UserID", (int)tabla2.Rows[0]["UserId"]);
                                    cmd3.ExecuteNonQuery();
                                }
                                MessageBox.Show("Contraseña incorrecta, intentelo nuevamente", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show("Usuario no registrado", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Maximo numero de intentos, intentelo nuevamente mas tarde!", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void plnContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
