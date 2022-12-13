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

namespace ProyectoFinal.Payment_Module
{
    public partial class SelectInvoice : Form
    {
        String strConexion;
        public SelectInvoice()
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

        private void SelectInvoice_Load(object sender, EventArgs e)
        {
            cargarPreSales(DGVBuscarFact);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarFact_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(strConexion);
                DataSet dsProd = new DataSet();
                string query = "Select * from PreSales Where Name Like('%" + txtBuscarFact.Text.Trim() + "%')";
                SqlDataAdapter dataProduct = new SqlDataAdapter(query, connection);
                dataProduct.Fill(dsProd);
                DGVBuscarFact.DataSource = dsProd.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex);
            }
        }

        private void btnSelectFact_Click(object sender, EventArgs e)
        {
            if (DGVBuscarFact.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        public void cargarPreSales(DataGridView dgv)
        {
            try
            {
                SqlConnection connection = new SqlConnection(strConexion);
                DataTable tabla = new DataTable();
                SqlDataAdapter dataPreSales = new SqlDataAdapter("Select * from PreSales", connection);
                dataPreSales.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex);
            }
        }
    }
}
