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
            //this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True"; //GERALDO
            this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO
        }

        private void tbReorderLevel_Scroll(object sender, EventArgs e)
        {
            lblTrackBarValue.Text = tbReorderLevel.Value.ToString()+"%";
        }

        private void ProductsAdministration_Load(object sender, EventArgs e)
        {
            loadProducts();
            loadCategory();
            loadSuppliers();
            loadPresentation();
        }

        public void loadProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM DBO.Products", connection);
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
                txtName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[4].Value.ToString();
                txtPrice.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[5].Value.ToString();
                tbReorderLevel.Value = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[7].Value.ToString());
                lblTrackBarValue.Text = tbReorderLevel.Value.ToString()+"%";
                cmbxPresentation.SelectedValue = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString());
                cmbxSupplier.SelectedValue = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString());
                cmbxCategory.SelectedValue = int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString());
            } 
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("SP_discontinueProduct", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserCache.UserID);
                    cmd.Parameters.AddWithValue("@ProductID", int.Parse(txtId.Text));
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
                System.GC.Collect();

            }

            loadProducts();
        }
    }
}
