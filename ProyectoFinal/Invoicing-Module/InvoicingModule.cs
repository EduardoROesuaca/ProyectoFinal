using Microsoft.VisualBasic;
using ProyectoFinal.Common;
using ProyectoFinal.Invoicing_Module;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProyectoFinal
{
    public partial class InvoicingModule : Form
    {
        String strConexion;
        String NomCliente;
        public static int contFila = 0;
        public static double total = 0;


        public InvoicingModule()
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void InvoicingModule_Load(object sender, EventArgs e)
        {

        }
        private void PBMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void SelectProduct(int IdProd) 
        {
            try
            {
                SqlConnection connection = new SqlConnection(strConexion);
                using (SqlCommand cmd = new SqlCommand("SP_InfoProd", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductID", txtBuscarProdID.Text.Trim());
                    SqlDataReader read = cmd.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(read);
                    if (tabla.Rows.Count > 0)
                    {
                        UserCache.ProductoID = (int)tabla.Rows[0]["ProductId"];
                        UserCache.CategoriaID = (int)tabla.Rows[0]["CategoryId"];
                        UserCache.ProductName = tabla.Rows[0]["Name"].ToString();
                        UserCache.Price = (decimal)tabla.Rows[0]["Price"];
                        UserCache.CantidadProd = (int)tabla.Rows[0]["QtyAvail"];

                        //lblVistaPrevia.Text = UserCache.ProductName;
                    }
                    else
                    {
                        //lblVistaPrevia.Text = "ID no existe en Base de Datos";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha presentado un error: " + ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SelectProduct(UserCache.ProductoID);
                lblVistaPrevia.Text = UserCache.ProductName;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha presentado un error: " + ex);
            }


        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existe = false;   
            int numFila = 0;
            double iva = 0;
            double subtotal = 0;
            try
            {
                if (string.IsNullOrEmpty(txtCantidadProd.Text))
                {
                    MessageBox.Show("Debe completar la informacion");

                    return;
                }
                else
                {
                    if ((Convert.ToDouble(UserCache.CantidadProd) > Double.Parse(txtCantidadProd.Text)) && (Double.Parse(txtCantidadProd.Text) > 0))
                    {
                        if (contFila == 0)
                        {
                            dataFacturacion.Rows.Add(UserCache.ProductoID.ToString(), UserCache.ProductName.ToString(),
                                UserCache.CategoriaID.ToString(), UserCache.Price.ToString(), txtCantidadProd.Text);
                            if (UserCache.CategoriaID.ToString() == "1")
                            {
                                subtotal = Convert.ToDouble(UserCache.Price) * (Double.Parse(txtCantidadProd.Text));
                                iva = subtotal * 0.13;
                                subtotal += iva;
                                dataFacturacion.Rows[contFila].Cells[5].Value = iva;
                                dataFacturacion.Rows[contFila].Cells[6].Value = subtotal;
                                Limpiar();
                                contFila++;
                            }
                            if (UserCache.CategoriaID.ToString() == "2" || UserCache.CategoriaID.ToString() == "3")
                            {
                                subtotal = Convert.ToDouble(UserCache.Price) * (Double.Parse(txtCantidadProd.Text));
                                iva = subtotal * 0.02;
                                subtotal += iva;
                                dataFacturacion.Rows[contFila].Cells[5].Value = iva;
                                dataFacturacion.Rows[contFila].Cells[6].Value = subtotal;
                                Limpiar();
                                contFila++;

                            }
                        }
                        else
                        {
                            foreach (DataGridViewRow Fila in dataFacturacion.Rows)
                            {

                                if (Fila.Cells[0].Value.ToString() == txtBuscarProdID.Text)
                                {
                                    existe = true;
                                    numFila = Fila.Index;
                                }
                            }

                            if (existe == true)
                            {
                                dataFacturacion.Rows[numFila].Cells[4].Value = (Convert.ToDouble(txtCantidadProd.Text) +
                                    Convert.ToDouble(dataFacturacion.Rows[numFila].Cells[4].Value)).ToString();

                                if (UserCache.CategoriaID.ToString() == "1")
                                {
                                    subtotal = Convert.ToDouble(UserCache.Price) * (Double.Parse(txtCantidadProd.Text));
                                    iva = subtotal * 0.13;
                                    subtotal += iva;
                                    dataFacturacion.Rows[numFila].Cells[5].Value = iva;
                                    dataFacturacion.Rows[numFila].Cells[6].Value = subtotal;
                                    Limpiar();
                                }

                                if (UserCache.CategoriaID.ToString() == "2" || UserCache.CategoriaID.ToString() == "3")
                                {
                                    subtotal = Convert.ToDouble(UserCache.Price) * (Double.Parse(txtCantidadProd.Text));
                                    iva = subtotal * 0.02;
                                    subtotal += iva;
                                    dataFacturacion.Rows[numFila].Cells[5].Value = iva;
                                    dataFacturacion.Rows[numFila].Cells[6].Value = subtotal;
                                    Limpiar();
                                }
                            }
                            else
                            {
                                dataFacturacion.Rows.Add(UserCache.ProductoID.ToString(), UserCache.ProductName.ToString(),
                                                    UserCache.CategoriaID.ToString(), UserCache.Price.ToString(), txtCantidadProd.Text);
                                if (UserCache.CategoriaID.ToString() == "1")
                                {
                                    subtotal = Convert.ToDouble(UserCache.Price) * (Double.Parse(txtCantidadProd.Text));
                                    iva = subtotal * 0.13;
                                    subtotal += iva;
                                    dataFacturacion.Rows[contFila].Cells[5].Value = iva;
                                    dataFacturacion.Rows[contFila].Cells[6].Value = subtotal;
                                    Limpiar();
                                    contFila++;
                                }
                                if (UserCache.CategoriaID.ToString() == "2" || UserCache.CategoriaID.ToString() == "3")
                                {
                                    subtotal = Convert.ToDouble(UserCache.Price) * (Double.Parse(txtCantidadProd.Text));
                                    iva = subtotal * 0.02;
                                    subtotal += iva;
                                    dataFacturacion.Rows[contFila].Cells[5].Value = iva;
                                    dataFacturacion.Rows[contFila].Cells[6].Value = subtotal;
                                    Limpiar();
                                    contFila++;

                                }
                            }
                        }
                        total = 0;
                        foreach (DataGridViewRow Fila in dataFacturacion.Rows)
                        {
                            total += Convert.ToDouble(Fila.Cells[6].Value);
                        }
                        txtTotalColones.Text = total.ToString();
                        txtTotalDolares.Text = (total / 620).ToString("0.##");
                    }
                    else
                    {
                        MessageBox.Show("Cantidad no disponible");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error " +ex);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (contFila > 0)
            {
                total = total - (Convert.ToDouble(dataFacturacion.Rows[dataFacturacion.CurrentRow.Index].Cells[6].Value));
                txtTotalColones.Text = total.ToString();
                txtTotalDolares.Text = (total / 620).ToString("0.##");
                dataFacturacion.Rows.RemoveAt(dataFacturacion.CurrentRow.Index);
                contFila--;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo() {
            txtTotalColones.Text = "0";
            txtTotalDolares.Text = "0";
            dataFacturacion.Rows.Clear();
            txtBuscarProdID.Text = "0";
            lblVistaPrevia.Text = " ";
            txtBuscarProdID.Focus();
            contFila = 0;
        }

        public void Limpiar()
        {
            txtBuscarProdID.Text = "";
            txtCantidadProd.Text = "";
            lblVistaPrevia.Text = "";
            txtBuscarProdID.Focus();
        }

        //public void Cambio() { 
        //    pagoCol = Double.Parse(txtPagoCol.Text);    
        //    pagoDol = Double.Parse(txtPagoDol.Text);
        //    pagoTC = Double.Parse(txtPagoTC.Text);
        //    vuelto = (pagoCol+pagoTC+(pagoDol*610)) - total;
        //    txtVuelto.Text = vuelto.ToString();

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this.dataFacturacion, "Desea confirmar el siguiente pedido?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (dataFacturacion.Rows.Count == 0 || string.IsNullOrEmpty(txtNombreCliente.Text))
                {
                    MessageBox.Show(this, "Ingrese al menos un producto y un nombre de cliente a la orden e intentelo nuevamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(strConexion))
                    {
                        using (SqlCommand cmd = new SqlCommand("SP_InsertNewPreSale", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@UserID", UserCache.UserID);
                            cmd.Parameters.AddWithValue("@CustomerName", txtNombreCliente.Text.Trim());
                            cmd.Parameters.AddWithValue("@Total", double.Parse(txtTotalColones.Text.Trim()));
                            connection.Open();
                            using (SqlDataAdapter sda = new SqlDataAdapter())
                            {
                                sda.SelectCommand = cmd;
                                using (DataTable dt = new DataTable())
                                {
                                    sda.Fill(dt);
                                    if (insertProducts(int.Parse(dt.Rows[0][0].ToString())))
                                    {
                                        MessageBox.Show(this, "Orden registrada exitosamente!", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dataFacturacion.Rows.Clear();
                                        btnNuevo_Click(sender, e);
                                        insertLog("El usuario {" + UserCache.Name + "} ha registrado una nueva orden!");
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Error al registrar la orden, intentelo nuevamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        public bool insertProducts(int OrderID)
        {
            bool flag = true;
            foreach (DataGridViewRow row in dataFacturacion.Rows)
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_InsertNewPreSaleDetail", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PreSaleID", OrderID);
                        cmd.Parameters.AddWithValue("@ProductID", row.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@Name", row.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@CatID", row.Cells[2].Value);
                        cmd.Parameters.AddWithValue("@Price", double.Parse(row.Cells[3].Value.ToString()));
                        cmd.Parameters.AddWithValue("@Qty", row.Cells[4].Value);
                        cmd.Parameters.AddWithValue("@Taxes", double.Parse(row.Cells[5].Value.ToString()));
                        cmd.Parameters.AddWithValue("@SubTotal", double.Parse(row.Cells[6].Value.ToString()));
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows != 1)
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

        private void bntPagar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            ProductSelect PS = new ProductSelect();
            PS.ShowDialog();
            if (PS.DialogResult == DialogResult.OK)
            {
                DataGridViewRow dgRow = PS.DGVBuscarProd.CurrentRow;
                txtBuscarProdID.Text = dgRow.Cells[0].Value.ToString();
                lblVistaPrevia.Text = dgRow.Cells[5].Value.ToString();
                SelectProduct(int.Parse(txtBuscarProdID.Text));
                txtCantidadProd.Focus();
            }
        }

        private void dataFacturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTotalColones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
