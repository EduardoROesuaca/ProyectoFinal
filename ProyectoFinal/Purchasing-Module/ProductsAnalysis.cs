using ProyectoFinal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Purchasing_Module
{
    public partial class ProductsAnalysis : Form
    {
        #region Props
        String strConexion;
        #endregion
        public ProductsAnalysis()
        {
            InitializeComponent();
            //this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //GERALDO
            this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO-DESKTOP
            //this.strConexion = "Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";             //EDUARDO-LAPTOP
        }

        private void ProductsAnalysis_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetQtyVar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            lblProductsQty.Text = dt.Rows[0][0].ToString();
                            lblSuppliersQty.Text = dt.Rows[0][1].ToString();
                            lblPresentationsQty.Text = dt.Rows[0][2].ToString();
                            lblCategoryQty.Text = dt.Rows[0][3].ToString();
                        }
                    }
                }
            }
        }
    }
}
