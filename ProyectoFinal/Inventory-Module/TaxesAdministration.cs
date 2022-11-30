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
    public partial class TaxesAdministration : Form
    {
        #region Props
        String strConexion;
        #endregion
        public TaxesAdministration()
        {
            InitializeComponent();
            //this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //GERALDO
            //this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO-DESKTOP
            this.strConexion = "Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";             //EDUARDO-LAPTOP
        }

        private void TaxesAdministration_Load(object sender, EventArgs e)
        {
            loadTaxes();
        }
        public void loadTaxes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT * FROM DBO.Taxes", connection);
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
            txtId.ResetText();
            txtName.ResetText();
            txtRate.ResetText();
            txtDescription.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {

                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DeleteTax", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TaxID", txtId.Text.Trim());
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 1)
                        {
                            loadTaxes();
                            btnClear_Click(sender, e);
                            MessageBox.Show(this, "Registro de impuesto eliminado!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "No se puede eliminar el registro del impuesto seleccionada\nEste impuesto tiene productos asociados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show(this, "Seleccione el registro de impuesto que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string invalidcharPattern = "[!\"·$&/()=¿¡?'_:;,|@#€*+]";
            if (txtId.Text.Trim().Length > 0)
            {
                if (Regex.IsMatch(txtDescription.Text.Trim(), invalidcharPattern) || txtDescription.Text.Trim().Length < 10 || txtDescription.Text.Trim().Length >110)
                {
                    MessageBox.Show(this, "Debe registrar una descripción que no contenga:\n{!\"·$&/()=¿¡?'_:;,|@#€*+}\nDe al menos 10 caracteres y maximo 110", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                }
                else
                {
                    if (Regex.IsMatch(txtName.Text.Trim(), invalidcharPattern) || txtName.Text.Trim().Length < 3 || txtName.Text.Trim().Length > 50)
                    {
                        MessageBox.Show(this, "Debe registrar un nombre de impuesto que no contenga:\n{!\"·$&/()=¿¡?'_:;,|@#€*+}\nDe al menos 4 caracteres y maximo 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Focus();
                    }
                    else
                    {
                        decimal numberf;
                        if (!decimal.TryParse(txtRate.Text.Trim().Replace('.',','), out numberf) || numberf<0)
                        {
                            MessageBox.Show(this, "Por favor ingrese una taza de impuesto válida e intentolo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtRate.Focus();
                        }
                        else
                        {
                            using (SqlConnection connection = new SqlConnection(strConexion))
                            {
                                using (SqlCommand cmd = new SqlCommand("SP_UpdateTax", connection))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@TaxID", txtId.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Rate", numberf);
                                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                                    connection.Open();
                                    int rows = cmd.ExecuteNonQuery();
                                    if (rows == 1)
                                    {
                                        loadTaxes();
                                        btnClear_Click(sender, e);
                                        MessageBox.Show(this, "Detalles de impuesto actualizados exitosamente!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Error al actualizar los detalles del impuesto\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione el registro del impuesto que desea actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string invalidcharPattern = "[!\"·$&/()=¿¡?'_:;,|@#€*+]";
            if (txtId.Text.Trim().Length == 0)
            {
                if (Regex.IsMatch(txtDescription.Text.Trim(), invalidcharPattern) || txtDescription.Text.Trim().Length < 10 || txtDescription.Text.Trim().Length > 110)
                {
                    MessageBox.Show(this, "Debe registrar una descripción que no contenga:\n{!\"·$&/()=¿¡?'_:;,|@#€*+}\nDe al menos 10 caracteres y maximo 110", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                }
                else
                {
                    if (Regex.IsMatch(txtName.Text.Trim(), invalidcharPattern) || txtName.Text.Trim().Length < 4 || txtName.Text.Trim().Length > 110)
                    {
                        MessageBox.Show(this, "Debe registrar un nombre de impuesto que no contenga:\n{!\"·$&/()=¿¡?'_:;,|@#€*+}\nDe al menos 4 caracteres y maximo 110", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Focus();
                    }
                    else
                    {
                        decimal numberf; ;
                        if (!decimal.TryParse(txtRate.Text.Trim().Replace('.', ','), out numberf) || numberf<0)
                        {
                            MessageBox.Show(this, "Por favor ingrese una taza de impuesto válida e intentolo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtRate.Focus();
                        }
                        else
                        {
                            using (SqlConnection connection = new SqlConnection(strConexion))
                            {
                                using (SqlCommand cmd = new SqlCommand("SP_InsertTax", connection))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Rate", numberf);
                                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                                    connection.Open();
                                    int rows = cmd.ExecuteNonQuery();
                                    if (rows == 1)
                                    {
                                        loadTaxes();
                                        btnClear_Click(sender, e);
                                        MessageBox.Show(this, "Impuesto registrado exitosamente!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Error al registrar el impuesto\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Limpie los campos de texto antes de registrar un nuevo impuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
            txtRate.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString();
            txtDescription.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString();

        }
    }
}
