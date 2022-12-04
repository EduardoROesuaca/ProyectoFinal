using Microsoft.Reporting.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoFinal.Purchasing_Module
{
    public partial class NewPurchase : Form
    {
        #region Props
        String strConexion;
        DataTable dtProducts;
        DataTable dt;

        double taxes = 0;
        double subtotal = 0;
        double total = 0;
        #endregion
        public NewPurchase()
        {
            InitializeComponent();
            //this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //GERALDO
            this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO-DESKTOP
            //this.strConexion = "Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";             //EDUARDO-LAPTOP
        }

        private void NewPurchase_Load(object sender, EventArgs e)
        {
            loadProducts();
            loadPresentation();
        }
        public void loadProducts()
        {
            dtProducts = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DBO.Products", connection);
                da.Fill(dtProducts);
                cmbxProducts.DataSource = dtProducts;
                cmbxProducts.DisplayMember = "Name";
                cmbxProducts.ValueMember = "ProductId";
                connection.Close();
                System.GC.Collect();
            }

        }

        public void loadPresentation()
        {
            dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DBO.ProductsPresentation", connection);
                da.Fill(dt);
                cmbxPresentation.DataSource = dt;
                cmbxPresentation.DisplayMember = "Description";
                cmbxPresentation.ValueMember = "PresentationId";
                connection.Close();
                System.GC.Collect();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQty.ResetText();
            txtName.ResetText();
            txtPrice.ResetText();
            txtProductId.ResetText();
        }

        private void cmbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < dtProducts.Rows.Count; i++)
            {
                if (dtProducts.Rows[i]["ProductId"].Equals(cmbxProducts.SelectedValue))
                {
                    txtProductId.Text = dtProducts.Rows[i]["ProductId"].ToString();
                    txtName.Text = dtProducts.Rows[i]["Name"].ToString();
                    txtPrice.Text = dtProducts.Rows[i]["Price"].ToString();
                    cmbxPresentation.SelectedValue = int.Parse(dtProducts.Rows[i]["PresentationId"].ToString());
                }
            }
        }

        private void btnSearchByProductID_Click(object sender, EventArgs e)
        {
            if(txtProductId.Text.Trim().Length < 1)
            {
                MessageBox.Show(this, "Ingrese el codígo delproducto que desea buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool flag = false;
                for (int i = 0; i < dtProducts.Rows.Count; i++)
                {
                    if (dtProducts.Rows[i]["ProductId"].ToString().Trim().Equals(txtProductId.Text.Trim()))
                    {
                        flag = true;
                        cmbxProducts.SelectedValue = int.Parse(txtProductId.Text.Trim());
                    }
                }
                if(!flag) MessageBox.Show(this, "No existen productos con este codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); txtProductId.ResetText();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //try
            //{
                int number;
                if (!int.TryParse(txtQty.Text.Trim(), out number) || number < 1)
                {
                    MessageBox.Show(this, "Ingrese una cantidad válida mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double tempSubtotal = int.Parse(txtQty.Text.Trim()) * double.Parse(txtPrice.Text.Trim());
                    subtotal += tempSubtotal;
                    double tempTax = getTaxes(int.Parse(txtProductId.Text.Trim()),tempSubtotal);
                    taxes += tempTax;
                    total += tempSubtotal + tempTax;

                    DGV.Rows.Insert(0,
                        cmbxProducts.SelectedValue, txtName.Text,
                        txtQty.Text.Trim(),txtPrice.Text.Trim(), tempSubtotal, tempTax, tempSubtotal+tempTax);

                    btnClear_Click(sender, e);
                    txtSubTotal.Text = "¢"+subtotal.ToString();
                    txtTaxes.Text = "¢" + taxes.ToString();
                    txtTotal.Text = "¢" + total.ToString();

                }
            //}
            //catch (Exception ex)
            //{
                //MessageBox.Show(ex.Message);
                //MessageBox.Show(this, "Ingrese un ID de producto válido e intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //} 
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this.DGV, "Desea confirmar el siguiente pedido?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (DGV.Rows.Count == 0)
                {

                }
                else
                {

                }
            }
        }

        public double getTaxes(int ProductID, double Subtotal)
        {
            int TaxID = 0;
            double TaxRate = 0;
            DataTable dtt = new DataTable();
            for (int i = 0; i < dtProducts.Rows.Count; i++)
            {
                if (dtProducts.Rows[i]["ProductId"].ToString().Trim().Equals(ProductID.ToString()))
                {
                    int.TryParse(dtProducts.Rows[i]["TaxId"].ToString(), out TaxID);

                    using (SqlConnection connection = new SqlConnection(strConexion))
                    {
                        connection.Open();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT Rate FROM DBO.Taxes WHERE TaxId="+ TaxID, connection);
                        da.Fill(dtt);
                        double.TryParse(dtt.Rows[0]["Rate"].ToString().Trim(), out TaxRate);
                        connection.Close();
                        System.GC.Collect();
                    }
                }
            }
            return TaxRate*Subtotal*0.01;
        }

    }
}
