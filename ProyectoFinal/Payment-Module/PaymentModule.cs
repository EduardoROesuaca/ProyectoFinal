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
        String MetPago;
        int Codigo;
        double total = 0;
        double vuelto = 0;
        double pagoCol = 0;
        double pagoDol = 0;
        double tipoCambio = 620;
        double subTotal = 0;
        double impuestos = 0;
        double pagoTarjeta = 0;

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
                            MessageBox.Show(this, "Transaccion erronea", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        foreach (DataGridViewRow Fila in dataFacturacion.Rows)
                        {
                            total += Convert.ToDouble(Fila.Cells[6].Value);
                            impuestos += Convert.ToDouble(Fila.Cells[5].Value);
                            subTotal = total - impuestos;
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
            if (Cambio())
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

        public void Limpiar() 
        {
            txtCodigo.Text = "";
            txtNombreCliente.Text = "";
            txtColones.Text = "0";
            txtDolares.Text = "0";
            txtTarjeta.Text = "0";
            txtVuelto.Text = "0";
            txtTotalColones.Text = "0";
            txtTotalDolares.Text = "0";
            dataFacturacion.Rows.Clear();
        }
        public bool Cambio()
        {
            try
            {
                pagoCol = Double.Parse(txtColones.Text);
                pagoDol = Double.Parse(txtDolares.Text);
                pagoTarjeta = Double.Parse(txtTarjeta.Text);
                vuelto = (pagoCol + pagoTarjeta + (pagoDol * tipoCambio)) - total;
                txtVuelto.Text = vuelto.ToString();
                if (vuelto>0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(this, "Falta dinero por pagar ", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Transaccion erronea: "+ex, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


        }

        private void cmbxMetPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbxMetPago.SelectedIndex == 0)
                {
                    txtColones.Enabled = true;
                }
                if (cmbxMetPago.SelectedIndex == 1)
                {
                    txtDolares.Enabled = true;
                }
                if (cmbxMetPago.SelectedIndex == 2)
                {
                    txtTarjeta.Enabled = true;
                }
                else
                {
                    txtColones.Enabled = true;
                    txtDolares.Enabled = true;
                    txtTarjeta.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnFinCompra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this.dataFacturacion, "Desea confirmar la transacción?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dataFacturacion.Rows.Count == 0 || string.IsNullOrEmpty(txtNombreCliente.Text))
                {
                    MessageBox.Show(this, "Debe seleccionar una factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(strConexion))
                    {
                        using (SqlCommand cmd = new SqlCommand("SP_InsertNewSale", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@UserID", UserCache.UserID);
                            cmd.Parameters.AddWithValue("@PayMet", cmbxMetPago.SelectedIndex.ToString());
                            cmd.Parameters.AddWithValue("@DolarEx", tipoCambio);
                            cmd.Parameters.AddWithValue("@Dolars", pagoDol);
                            cmd.Parameters.AddWithValue("@Colons", pagoCol);
                            cmd.Parameters.AddWithValue("@Card", pagoTarjeta);
                            cmd.Parameters.AddWithValue("@SubTotal", subTotal);
                            cmd.Parameters.AddWithValue("@Taxes", impuestos);
                            cmd.Parameters.AddWithValue("@Total", total);
                            connection.Open();
                            using (SqlDataAdapter sda = new SqlDataAdapter())
                            {
                                sda.SelectCommand = cmd;
                                using (DataTable dt = new DataTable())
                                {
                                    sda.Fill(dt);
                                    if (insertData(int.Parse(dt.Rows[0][0].ToString())))
                                    {
                                        MessageBox.Show(this, "Datos de ventas registrados exitosamente!", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dataFacturacion.Rows.Clear();
                                        Limpiar();
                                        insertLog("El usuario {" + UserCache.Name + "} ha registrado una nueva orden!");
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Error al registrar los datos, intentelo nuevamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool insertData(int SaleID)
        {
            int x = 1;
            bool flag = true;
            foreach (DataGridViewRow row in dataFacturacion.Rows)
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_InsertNewSaleDetail", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SaleID", SaleID);
                        cmd.Parameters.AddWithValue("@ProductID", row.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@Taxes", x);
                        cmd.Parameters.AddWithValue("@Qty", row.Cells[3].Value);
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows != 2)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
            }
            return flag;
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
