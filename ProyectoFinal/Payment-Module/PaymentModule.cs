using ProyectoFinal.Common;
using ProyectoFinal.Invoicing_Module;
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
    public partial class PaymentModule : Form
    {
        String strConexion;
        int Codigo;
        double total = 0;

        public PaymentModule()
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

        private void PaymentModule_Load(object sender, EventArgs e)
        {

        }

        public void cargarPreSales(DataGridView dgv)
        {
            try
            {
                SqlConnection connection = new SqlConnection(strConexion);
                DataTable tabla = new DataTable();
                SqlDataAdapter dataPreSales = new SqlDataAdapter("Select * from PreSaleDetail Where PreSaleId='" + Codigo , connection);
                dataPreSales.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex);
            }
        }

        private void btnBuscarFact_Click(object sender, EventArgs e)
        {
            SelectInvoice SI = new SelectInvoice();
            SI.ShowDialog();
            if (SI.DialogResult == DialogResult.OK)
            {
                DataGridViewRow dgRow = SI.DGVBuscarFact.CurrentRow;
                txtCodigo.Text = dgRow.Cells[0].Value.ToString();
                Codigo = int.Parse(txtCodigo.Text);
                txtNombreCliente.Text = dgRow.Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetPreSales", connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PreSaleID", Codigo);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        if (dt.Rows.Count > 0)
                        {
                            dataFacturacion.DataSource = dt;
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show(this, "Transaccion errone", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        foreach (DataGridViewRow Fila in dataFacturacion.Rows)
                        {
                            total += Convert.ToDouble(Fila.Cells[6].Value);
                        }
                        txtTotalColones.Text = total.ToString();
                        txtTotalDolares.Text = (total / 620).ToString("0.##");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Fila in dataFacturacion.Rows)
            {
                if (Fila.Cells[2].Value.ToString() == "3")
                {
                    PassVal PassAdm = new PassVal();
                    PassAdm.ShowDialog();
                }
            }
        }
    }
}
