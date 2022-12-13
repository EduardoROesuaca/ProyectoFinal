using ProyectoFinal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Administration_Module
{
    public partial class UsersAdministration : Form
    {
        #region Props
        String strConexion;
        #endregion
        public UsersAdministration()
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

        private void UsersAdministration_Load(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            loadUsers();
            loadRol();
        }
        public void loadUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UserId,RoleId,Usuario=UserName,Nombre=Name,Apellidos=LastName,Email,Telefon=Mobile," +
                        "Estado=IIF(IsLockedOut=1,'BLOQUEADO','ACTIVO') , Creado=CreateDate, UltimoIngreso=LastActivityDate, Fallidos=FailedPasswordAttemptCount FROM DBO.Users", connection);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    DGV.DataSource = dt;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void loadRol()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT RoleId, RoleName FROM DBO.Roles", connection);
                da.Fill(dt);
                cmbxRol.DataSource = dt;
                cmbxRol.DisplayMember = "RoleName";
                cmbxRol.ValueMember = "RoleId";
                connection.Close();
                System.GC.Collect();

            }
        }


        public void insertLog(String Messsage)
        {
            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_InsertLog", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserCache.UserID);
                    cmd.Parameters.AddWithValue("@message", Messsage);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.ResetText();
            cmbxRol.SelectedIndex = 0;
            txtUser.ResetText();
            txtName.ResetText();
            txtApellidos.ResetText();
            txtEmail.ResetText();
            txtTelefono.ResetText();
            cmbxBlock.SelectedIndex = 0;
            txtIntentosFallidos.ResetText();
            txtFechaCreacion.Text = DateTime.Now.ToString();
            txtUltimaActividad.Text = DateTime.Now.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DeleteUser", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", txtId.Text.Trim());

                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 1)
                        {
                            loadUsers();
                            btnClear_Click(sender, e);
                            insertLog("El usuario{" + UserCache.Name + "} ha eliminado al usuario {" + txtName.Text.Trim() + "}");
                            MessageBox.Show(this, "Usuario eliminado!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "No se pudo eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione el usuario que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtId.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
                cmbxRol.SelectedValue = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString());
                txtUser.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString();
                txtName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString();
                txtApellidos.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[4].Value.ToString();
                txtEmail.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[5].Value.ToString();
                txtTelefono.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[6].Value.ToString();
                cmbxBlock.SelectedIndex = (DGV.Rows[DGV.CurrentRow.Index].Cells[7].Value.ToString().Equals("ACTIVO")) ? 0 : 1;
                txtFechaCreacion.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[8].Value.ToString();
                txtUltimaActividad.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[9].Value.ToString();
                txtIntentosFallidos.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[10].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string invalidcharPattern = "[!\"·$&/()%=¿¡?'_:;,|@#€*+]";
            string telregex = "^\\d+$";

            if (txtId.Text.Trim().Length > 0)
            {
                if (Regex.IsMatch(txtName.Text.Trim(), invalidcharPattern) || txtName.Text.Trim().Length < 1 
                    || Regex.IsMatch(txtUser.Text.Trim(), invalidcharPattern) || txtUser.Text.Trim().Length < 1
                    || Regex.IsMatch(txtApellidos.Text.Trim(), invalidcharPattern) || txtApellidos.Text.Trim().Length < 1
                    || Regex.IsMatch(txtTelefono.Text.Trim(), invalidcharPattern) || txtTelefono.Text.Trim().Length < 1)
                {
                    MessageBox.Show(this, "Los campos a editar no pueden contener caracteres como:\n{!\"·$&/()%=¿¡?'_:;,|@#€*+}\nNi pueden estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.ResetText();
                }
                if (!Regex.IsMatch(txtTelefono.Text.Trim(), telregex) || txtTelefono.Text.Trim().Length < 8)
                {
                    MessageBox.Show(this, "Ingrese un número de teléfono válido\n(8 digitos, sin espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        MailAddress address = new MailAddress(txtEmail.Text.Trim());

                        using (SqlConnection connection = new SqlConnection(strConexion))
                        {
                            using (SqlCommand cmd = new SqlCommand("SP_UpdateUsers", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@UserID", txtId.Text.Trim());
                                cmd.Parameters.AddWithValue("@RolID", cmbxRol.SelectedValue);
                                cmd.Parameters.AddWithValue("@User", txtUser.Text.Trim());
                                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                cmd.Parameters.AddWithValue("@LastName", txtApellidos.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@TelNumber", txtTelefono.Text.Trim());
                                cmd.Parameters.AddWithValue("@Lock", cmbxBlock.SelectedIndex);
                                cmd.Parameters.AddWithValue("@CreatD", txtFechaCreacion.Text.Trim());
                                cmd.Parameters.AddWithValue("@LastA", txtUltimaActividad.Text.Trim());
                                cmd.Parameters.AddWithValue("@FailedPass", txtIntentosFallidos.Text.Trim());
                                connection.Open();
                                int rows = cmd.ExecuteNonQuery();
                                if (rows == 1)
                                {
                                    loadUsers();
                                    btnClear_Click(sender, e);
                                    insertLog("El usuario{" + UserCache.Name + "} ha actualizado los datos del usuario{" + txtName.Text.Trim() + "}!");
                                    MessageBox.Show(this, "Usuario actualizado!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(this, "Error al actualizar el usuario\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show(this, "Ingrese una dirección de correo electrónico válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione el usuario que desea actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string invalidcharPattern = "[!\"·$&/()%=¿¡?'_:;,|@#€*+]";
            string telregex = "^\\d+$";

            if (txtId.Text.Trim().Length > 0)
            {
                MessageBox.Show(this, "Limpie los campos antes de registrar un nuevo usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Regex.IsMatch(txtName.Text.Trim(), invalidcharPattern) || txtName.Text.Trim().Length < 1
    || Regex.IsMatch(txtUser.Text.Trim(), invalidcharPattern) || txtUser.Text.Trim().Length < 1
    || Regex.IsMatch(txtApellidos.Text.Trim(), invalidcharPattern) || txtApellidos.Text.Trim().Length < 1
    || Regex.IsMatch(txtTelefono.Text.Trim(), invalidcharPattern) || txtTelefono.Text.Trim().Length < 1)
                {
                    MessageBox.Show(this, "Los campos a insertar no pueden contener caracteres como:\n{!\"·$&/()%=¿¡?'_:;,|@#€*+}\nNi pueden estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.ResetText();
                }
                if (!Regex.IsMatch(txtTelefono.Text.Trim(), telregex) || txtTelefono.Text.Trim().Length < 8)
                {
                    MessageBox.Show(this, "Ingrese un número de teléfono válido\n(8 digitos, sin espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        MailAddress address = new MailAddress(txtEmail.Text.Trim());

                        using (SqlConnection connection = new SqlConnection(strConexion))
                        {
                            using (SqlCommand cmd = new SqlCommand("SP_InsertUsers", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@RolID", cmbxRol.SelectedValue);
                                cmd.Parameters.AddWithValue("@User", txtUser.Text.Trim());
                                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                cmd.Parameters.AddWithValue("@LastName", txtApellidos.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@TelNumber", txtTelefono.Text.Trim());
                                cmd.Parameters.AddWithValue("@Lock", cmbxBlock.SelectedIndex);
                                cmd.Parameters.AddWithValue("@CreatD", txtFechaCreacion.Text.Trim());
                                cmd.Parameters.AddWithValue("@LastA", txtUltimaActividad.Text.Trim());
                                cmd.Parameters.AddWithValue("@FailedPass", txtIntentosFallidos.Text.Trim());
                                connection.Open();
                                int rows = cmd.ExecuteNonQuery();
                                if (rows == 1)
                                {
                                    loadUsers();
                                    btnClear_Click(sender, e);
                                    insertLog("El usuario{" + UserCache.Name + "} ha registrado los datos del usuario");
                                    MessageBox.Show(this, "Usuario registrado!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(this, "Error al registrar el usuario\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show(this, "Ingrese una dirección de correo electrónico válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
