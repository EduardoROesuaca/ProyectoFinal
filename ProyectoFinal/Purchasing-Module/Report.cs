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

namespace ProyectoFinal.Purchasing_Module
{
    public partial class Report : Form
    {
        String strConexion;
        public Report()
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

        private void Report_Load(object sender, EventArgs e)
        {
            this.lblDate.Text = "Generado a las: "+DateTime.Now.ToString();
            this.lblHeader.Text = "Reporte de Orden";
            DGV.ScrollBars = ScrollBars.Vertical;
        }

        public void loadReport(int PurchaseID, double subtotal, double tax, double total)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetPurchaseDetails", connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        DGV.DataSource = dt;
                        connection.Close();
                        foreach (DataGridViewRow row in DGV.Rows)
                        {
                            row.DefaultCellStyle.Format = "N2";
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtSubTotal.Text = "¢"+subtotal.ToString();
            txtTaxes.Text = "¢" + tax.ToString();
            txtTotal.Text = "¢" + total.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            System.GC.Collect();
        }
    }
}
