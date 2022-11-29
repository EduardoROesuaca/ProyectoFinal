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

namespace ProyectoFinal.Inventory_Module
{
    public partial class SuppliersAdministration : Form
    {
        #region Props
        String strConexion;
        #endregion
        public SuppliersAdministration()
        {
            InitializeComponent();
            //this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //GERALDO
            //this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO-DESKTOP
            this.strConexion = "Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";             //EDUARDO-LAPTOP
        }

        private void SuppliersAdministration_Load(object sender, EventArgs e)
        {
            loadSuppliers();
        }

        public void loadSuppliers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT SupplierId,Cliente=Name,Dirección=Address,Correo=Email,Teléfono=TelNumber FROM DBO.Suppliers", connection);
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
            txtAddress.ResetText();
            txtEmail.ResetText();
            txtTel.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            /*using (SqlConnection connection = new SqlConnection(strConexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteSupplier", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierID", cmbxSupplier.SelectedValue);
                    cmd.Parameters.AddWithValue("@CategoryID", cmbxCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@PresentationID", cmbxPresentation.SelectedValue);
                    cmd.Parameters.AddWithValue("@TaxID", cmbxTax.SelectedValue);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
                    cmd.Parameters.AddWithValue("@Stock", txtStock.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReorderLevel", tbReorderLevel.Value);
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        loadProducts();
                        btnClear_Click(sender, e);
                        MessageBox.Show(this, "Producto registrado!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "Error al registrar el producto\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtId.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
                txtName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
                txtAddress.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString();
                txtEmail.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString();
                txtTel.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string invalidcharPattern = "[!\"·$&/()%=¿¡?'_:;,|@#€*+]";
            string telregex = "^\\d+$";

            if (txtId.Text.Trim().Length > 0)
            {
                if (!Regex.IsMatch(txtName.Text.Trim(), invalidcharPattern) || txtName.Text.Trim().Length < 1)
                {
                    MessageBox.Show(this, "El nombre del proveedor no puede contener:\n{!\"·$&/()%=¿¡?'_:;,|@#€*+}\nNi puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.ResetText();
                }
                else
                {
                    if (txtAddress.Text.Trim().Length < 1)
                    {
                        MessageBox.Show(this, "Debe ingresar la dirección del proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!Regex.IsMatch(txtTel.Text.Trim(), telregex) || txtTel.Text.Trim().Length < 8)
                        {
                            MessageBox.Show(this, "Ingrese un número de teléfono válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                MailAddress address = new MailAddress(txtEmail.Text.Trim());

                                /*using (SqlConnection connection = new SqlConnection(strConexion))
                                {
                                    using (SqlCommand cmd = new SqlCommand("SP_InsertProduct", connection))
                                    {
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.AddWithValue("@SupplierID", cmbxSupplier.SelectedValue);
                                        cmd.Parameters.AddWithValue("@CategoryID", cmbxCategory.SelectedValue);
                                        cmd.Parameters.AddWithValue("@PresentationID", cmbxPresentation.SelectedValue);
                                        cmd.Parameters.AddWithValue("@TaxID", cmbxTax.SelectedValue);
                                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
                                        cmd.Parameters.AddWithValue("@Stock", txtStock.Text.Trim());
                                        cmd.Parameters.AddWithValue("@ReorderLevel", tbReorderLevel.Value);
                                        connection.Open();
                                        int rows = cmd.ExecuteNonQuery();
                                        if (rows == 1)
                                        {
                                            loadProducts();
                                            btnClear_Click(sender, e);
                                            MessageBox.Show(this, "Producto registrado!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show(this, "Error al registrar el producto\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }*/

                            }
                            catch (FormatException)
                            {
                                MessageBox.Show(this, "Ingrese una dirección de correo electrónico válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione el proveedor que desea actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
