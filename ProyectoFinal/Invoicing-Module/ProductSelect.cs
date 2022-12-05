using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Invoicing_Module
{
    public partial class ProductSelect : Form
    {
        String strConexion;

        public ProductSelect()
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

        private void ProductSelect_Load(object sender, EventArgs e)
        {

            cargarProductos(DGVBuscarProd);
        }
        public void cargarProductos(DataGridView dgv)
        {
            try
            {
                SqlConnection connection = new SqlConnection(strConexion);
                DataTable tabla = new DataTable();
                SqlDataAdapter dataProduct = new SqlDataAdapter("Select * from Products", connection);
                dataProduct.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " +ex);
            }
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            if (DGVBuscarProd.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
