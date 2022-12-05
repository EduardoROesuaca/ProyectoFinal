using ProyectoFinal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal.Inventory_Module
{
    public partial class ProductsAdministration : Form
    {
        #region Props
        String strConexion;
        #endregion
        public ProductsAdministration()
        {
            InitializeComponent();
            lblTrackBarValue.Text = tbReorderLevel.Value.ToString() + "%";
            //this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //GERALDO
            this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO-DESKTOP
            //this.strConexion = "Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";             //EDUARDO-LAPTOP
        }

        private void tbReorderLevel_Scroll(object sender, EventArgs e)
        {
            lblTrackBarValue.Text = tbReorderLevel.Value.ToString()+"%";
        }

        private void ProductsAdministration_Load(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            loadTax();
            loadCategory();
            loadSuppliers();
            loadPresentation();
            loadProducts();
        }
        public void loadTax()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TaxId, Description=CONCAT_WS(' %- ',Rate,Name) FROM dbo.Taxes", connection);
                da.Fill(dt);
                cmbxTax.DataSource = dt;
                cmbxTax.DisplayMember = "Description";
                cmbxTax.ValueMember = "TaxId";
                connection.Close();
                System.GC.Collect();
            }
        }

        public void loadProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT P.ProductId, P.SupplierId, P.CategoryId, P.PresentationId,
	                                                                         P.TaxId,P.Discontinued,Producto=P.Name, Precio=P.Price,Stock=P.QtyAvail,Reorden=P.ReorderLevel,
	                                                                         Proveedor=S.Name, Prescripcion=C.Description, Presentacion=PR.Description,
                                                                             Tax=(SELECT f=CONCAT_WS('%- ',Rate,Name) FROM dbo.Taxes WHERE TaxId=P.TaxId),Estado=IIF(P.Discontinued=1,'DESCONTINUADO','ACTIVO') 
                                                                    FROM Products P, Suppliers S,ProductsCategory C,ProductsPresentation PR,Taxes T
                                                                    WHERE
	                                                                    S.SupplierId=P.SupplierId AND C.CategoryId=P.CategoryId AND PR.PresentationId=P.PresentationId AND T.TaxId=P.TaxId", connection);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    DGV.DataSource = dt;
                    connection.Close();
                    DGV.Columns[0].Visible = false;
                    DGV.Columns[1].Visible = false;
                    DGV.Columns[2].Visible = false;
                    DGV.Columns[3].Visible = false;
                    DGV.Columns[4].Visible = false;
                    DGV.Columns[5].Visible = false;
                    cmbxDiscontinued.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void loadPresentation()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT PresentationId, Description FROM DBO.ProductsPresentation", connection);
                da.Fill(dt);
                cmbxPresentation.DataSource = dt;
                cmbxPresentation.DisplayMember = "Description";
                cmbxPresentation.ValueMember = "PresentationId";
                connection.Close();
                System.GC.Collect();
            }

        }
        void loadCategory()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryId, Description FROM DBO.ProductsCategory", connection);
                da.Fill(dt);
                cmbxCategory.DataSource = dt;
                cmbxCategory.DisplayMember = "Description";
                cmbxCategory.ValueMember = "CategoryId";
                connection.Close();
                System.GC.Collect();

            }
        }

        void loadSuppliers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT SupplierId, Name FROM DBO.Suppliers", connection);
                da.Fill(dt);
                cmbxSupplier.DataSource = dt;
                cmbxSupplier.DisplayMember = "Name";
                cmbxSupplier.ValueMember = "SupplierId";
                connection.Close();
                System.GC.Collect();
            }

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txtId.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
                cmbxSupplier.SelectedValue = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString());
                cmbxCategory.SelectedValue = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString());
                cmbxPresentation.SelectedValue = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString());
                cmbxTax.SelectedValue = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[4].Value.ToString());
                cmbxDiscontinued.SelectedIndex = (DGV.Rows[DGV.CurrentRow.Index].Cells[14].Value.ToString().Equals("ACTIVO"))? 0 : 1;

                txtName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[6].Value.ToString();
                txtPrice.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[7].Value.ToString();
                txtStock.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[8].Value.ToString();
                tbReorderLevel.Value = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[9].Value.ToString());
                lblTrackBarValue.Text = tbReorderLevel.Value.ToString()+"%";


            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.ResetText();
            txtName.ResetText();
            txtPrice.ResetText();
            txtStock.ResetText();
            cmbxTax.SelectedIndex = 0;
            tbReorderLevel.Value = 0;
            lblTrackBarValue.Text = tbReorderLevel.Value.ToString() + "%";
            cmbxPresentation.SelectedIndex = 10;
            cmbxCategory.SelectedIndex = 0;
            cmbxSupplier.SelectedIndex = 0;
            cmbxDiscontinued.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string invalidcharPattern = "[!\"·$&/()=¿¡?'_:;,|@#€*+]";
            string numbersPattern = "^\\d+$";
            if (txtId.Text.Trim().Length > 0)
            {
                MessageBox.Show(this, "Debe de limpiar todos los campos antes de registrar un nuevo producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Regex.IsMatch(txtName.Text.Trim(), invalidcharPattern) || txtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show(this, "Debe registrar un nombre de producto que no contenga:\n{!\"·$&/()=¿¡?'_:;,|@#€*+}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int number=0;
                    decimal numberf;
                    if (!decimal.TryParse(txtPrice.Text.Trim().Replace('.', ','), out numberf) || numberf < 0)
                    {
                        MessageBox.Show(this, "El precio del producto solo debe contener numeros, comas y debe ser mayor a ¢0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrice.ResetText();
                    }
                    else
                    {
                        if (!Regex.IsMatch(txtStock.Text.Trim(), numbersPattern) || !int.TryParse(txtStock.Text.Trim(), out number) || number<0)
                        {
                            MessageBox.Show(this, "El Stock del producto debe ser un número mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtStock.ResetText();
                        }
                        else
                        {
                            using (SqlConnection connection = new SqlConnection(strConexion))
                            {
                                using (SqlCommand cmd = new SqlCommand("SP_InsertProduct", connection))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@SupplierID", cmbxSupplier.SelectedValue);
                                    cmd.Parameters.AddWithValue("@CategoryID", cmbxCategory.SelectedValue);
                                    cmd.Parameters.AddWithValue("@PresentationID", cmbxPresentation.SelectedValue);
                                    cmd.Parameters.AddWithValue("@TaxID", cmbxTax.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Price", numberf);
                                    cmd.Parameters.AddWithValue("@Stock", txtStock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@ReorderLevel", tbReorderLevel.Value);
                                    connection.Open();
                                    int rows = cmd.ExecuteNonQuery();
                                    if (rows == 1)
                                    {
                                        loadProducts();
                                        btnClear_Click(sender, e);
                                        insertLog("El usuario{"+UserCache.Name+"} ha registrado un nuevo producto!");
                                        MessageBox.Show(this, "Producto registrado!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Error al registrar el producto\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string invalidcharPattern = "[!\"·$&/()=¿¡?'_:;,|@#€*+]";
            string numbersPattern = "^\\d+$";
            if (txtId.Text.Trim().Length > 0)
            {
                if (Regex.IsMatch(txtName.Text.Trim(), invalidcharPattern) || txtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show(this, "Debe registrar un nombre de producto que no contenga:\n{!\"·$&/()=¿¡?'_:;,|@#€*+}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int number = 0;
                    decimal numberf;
                    if (!decimal.TryParse(txtPrice.Text.Trim().Replace('.',','), out numberf) || numberf < 0)
                    {
                        MessageBox.Show(this, "El precio del producto solo debe contener numeros, comas y debe ser mayor a ¢0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrice.ResetText();
                    }
                    else
                    {
                        if (!Regex.IsMatch(txtStock.Text.Trim(), numbersPattern) || !int.TryParse(txtStock.Text.Trim(), out number))
                        {
                            MessageBox.Show(this, "El Stock del producto debe ser un número mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtStock.ResetText();
                        }
                        else
                        {
                            using (SqlConnection connection = new SqlConnection(strConexion))
                            {
                                using (SqlCommand cmd = new SqlCommand("SP_UpdateProduct", connection))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@ProductID", txtId.Text);
                                    cmd.Parameters.AddWithValue("@SupplierID", cmbxSupplier.SelectedValue);
                                    cmd.Parameters.AddWithValue("@CategoryID", cmbxCategory.SelectedValue);
                                    cmd.Parameters.AddWithValue("@PresentationID", cmbxPresentation.SelectedValue);
                                    cmd.Parameters.AddWithValue("@TaxID", cmbxTax.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Price", numberf);
                                    cmd.Parameters.AddWithValue("@Stock", txtStock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@ReorderLevel", tbReorderLevel.Value);
                                    cmd.Parameters.AddWithValue("@State", cmbxDiscontinued.SelectedIndex);
                                    connection.Open();
                                    int rows = cmd.ExecuteNonQuery();
                                    if (rows == 1)
                                    {
                                        loadProducts();
                                        btnClear_Click(sender, e);
                                        insertLog("El usuario{" + UserCache.Name + "} ha actualizado los datos del producto{"+txtName.Text.Trim()+"}");
                                        MessageBox.Show(this, "Producto actualizado!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Error al actualizar el producto\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione el producto que desea actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show(this, "ATENCIÓN\n\nSE ELIMINARÁ UN PRODUCTO, SE RECOMIENDA DESCONTINUAR Y NO ELIMINAR\n\n¿DESEA CONTINUAR?", "¿Estás seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(strConexion))
                    {
                        using (SqlCommand cmd = new SqlCommand("SP_DeleteProduct", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ProductID", txtId.Text.Trim());
                            connection.Open();
                            int rows = cmd.ExecuteNonQuery();
                            if (rows != -1)
                            {
                                loadProducts();
                                btnClear_Click(sender, e);
                                insertLog("El usuario{" + UserCache.Name + "} ha eliminado el producto{"+txtName.Text.Trim()+"}");
                                MessageBox.Show(this, "Producto eliminado!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Error al eliminar el producto\nIntentelo nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    btnClear_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione el producto que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
