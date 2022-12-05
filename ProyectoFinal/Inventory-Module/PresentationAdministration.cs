using ProyectoFinal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Inventory_Module
{
    public partial class PresentationAdministration : Form
    {
        #region Props
        String strConexion;
        #endregion
        public PresentationAdministration()
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

        public void loadPresentation()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT * FROM DBO.ProductsPresentation", connection);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    DGV.DataSource = dt;
                    connection.Close();
                    DGV.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.ResetText();
            txtId.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {

                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DeletePresentation", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PresentationID", txtId.Text.Trim());
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 1)
                        {
                            loadPresentation();
                            btnClear_Click(sender, e);
                            insertLog("El usuario{" + UserCache.Name + "} ha eliminado la presentacion {"+txtDescription.Text.Trim()+"}");
                            MessageBox.Show(this, "Presentación eliminada!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "No se puede eliminar la presentación seleccionada\nEsta presentación tiene productos asociados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show(this, "Seleccione la presentación que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string invalidcharPattern = "[!\"·$&/()=¿¡?'_:;,|@#€*+]";
            if (txtId.Text.Trim().Length == 0)
            {
                if (Regex.IsMatch(txtDescription.Text.Trim(), invalidcharPattern) || txtDescription.Text.Trim().Length < 4 || txtDescription.Text.Trim().Length > 20)
                {
                    MessageBox.Show(this, "Debe registrar una descripción que no contenga:\n{!\"·$&/()=¿¡?'_:;,|@#€*+}\ny de al menos 5 caracteres y maximo 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    using (SqlConnection connection = new SqlConnection(strConexion))
                    {
                        using (SqlCommand cmd = new SqlCommand("SP_InsertPresentation", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                            connection.Open();
                            int rows = cmd.ExecuteNonQuery();
                            if (rows == 1)
                            {
                                loadPresentation();
                                btnClear_Click(sender, e);
                                insertLog("El usuario{" + UserCache.Name + "} ha registrado una nueva presentacion de producto {"+txtDescription.Text.Trim()+"}!");
                                MessageBox.Show(this, "Presentación registrada!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Error al registrar la presentación\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Limpie los campos antes de registrar una nueva presentación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string invalidcharPattern = "[!\"·$&/()=¿¡?'_:;,|@#€*+]";
            if (txtId.Text.Trim().Length > 0)
            {
                if (Regex.IsMatch(txtDescription.Text.Trim(), invalidcharPattern) || txtDescription.Text.Trim().Length < 4)
                {
                    MessageBox.Show(this, "Debe registrar una descripción que no contenga:\n{!\"·$&/()=¿¡?'_:;,|@#€*+}\ny de al menos 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    using (SqlConnection connection = new SqlConnection(strConexion))
                    {
                        using (SqlCommand cmd = new SqlCommand("SP_UpdatePresentation", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@PresentationID", txtId.Text.Trim());
                            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                            connection.Open();
                            int rows = cmd.ExecuteNonQuery();
                            if (rows == 1)
                            {
                                loadPresentation();
                                btnClear_Click(sender, e);
                                insertLog("El usuario{" + UserCache.Name + "} ha actualizado los datos de la presentacion {"+txtDescription.Text.Trim()+"}");
                                MessageBox.Show(this, "Presentación actualizada!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Error al actualizar la presentación\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione la presentación que desea actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtDescription.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void PresentationAdministration_Load(object sender, EventArgs e)
        {
            loadPresentation();
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
    }
}
