using ProyectoFinal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Purchasing_Module
{
    public partial class ProductsAnalysis : Form
    {
        #region Props
        String strConexion;
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
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
            test();
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

                using (SqlCommand cmd2 = new SqlCommand("SP_GetProductsLowStock", connection))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda2 = new SqlDataAdapter())
                    {
                        sda2.SelectCommand = cmd2;
                        using (DataTable dt2 = new DataTable())
                        {
                            sda2.Fill(dt2);
                            DGV.DataSource = dt2;
                        }
                    }
                }
            }
        }

        public void test()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 products
                    command.CommandText = @"SELECT TOP 5 P.Name, SUM(SalesDetails.Qty) AS Q FROM SalesDetails
                                            inner join Products P ON P.ProductId = SalesDetails.ProductId inner join [Orders] O ON O.OrderId = SalesDetails.SaleId
                                            GROUP BY P.Name
                                            ORDER BY Q DESC";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
            chartTopProducts.DataSource = TopProductsList;
            chartTopProducts.Series[0].XValueMember = "Key";
            chartTopProducts.Series[0].YValueMembers = "Value";
            chartTopProducts.DataBind();
        }
    }
}
