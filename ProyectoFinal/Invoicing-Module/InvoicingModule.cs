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
        public static int contFila = 0;
        public static double total = 0;
        public static double pagoCol = 0;
        public static double pagoDol = 0;
        public static double pagoTC = 0;
        public static double vuelto = 0;

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
            txtPagoCol.Text = "0";
            txtPagoDol.Text = "0";
            txtPagoTC.Text = "0";   
            txtVuelto.Text = "0";
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
                                txtBuscarProdID.Text = "";
                                txtCantidadProd.Text = "";
                                lblVistaPrevia.Text = "";
                                contFila++;
                            }
                            if (UserCache.CategoriaID.ToString() == "2" || UserCache.CategoriaID.ToString() == "3")
                            {
                                subtotal = Convert.ToDouble(UserCache.Price) * (Double.Parse(txtCantidadProd.Text));
                                iva = subtotal * 0.02;
                                subtotal += iva;
                                dataFacturacion.Rows[contFila].Cells[5].Value = iva;
                                dataFacturacion.Rows[contFila].Cells[6].Value = subtotal;
                                txtBuscarProdID.Text = "";
                                txtCantidadProd.Text = "";
                                lblVistaPrevia.Text = "";
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
                                    txtBuscarProdID.Text = "";
                                    txtCantidadProd.Text = "";
                                    lblVistaPrevia.Text = "";
                                }

                                if (UserCache.CategoriaID.ToString() == "2" || UserCache.CategoriaID.ToString() == "3")
                                {
                                    subtotal = Convert.ToDouble(UserCache.Price) * (Double.Parse(txtCantidadProd.Text));
                                    iva = subtotal * 0.02;
                                    subtotal += iva;
                                    dataFacturacion.Rows[numFila].Cells[5].Value = iva;
                                    dataFacturacion.Rows[numFila].Cells[6].Value = subtotal;
                                    txtBuscarProdID.Text = "";
                                    txtCantidadProd.Text = "";
                                    lblVistaPrevia.Text = "";
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
                                    txtBuscarProdID.Text = "";
                                    txtCantidadProd.Text = "";
                                    lblVistaPrevia.Text = "";
                                    contFila++;
                                }
                                if (UserCache.CategoriaID.ToString() == "2" || UserCache.CategoriaID.ToString() == "3")
                                {
                                    subtotal = Convert.ToDouble(UserCache.Price) * (Double.Parse(txtCantidadProd.Text));
                                    iva = subtotal * 0.02;
                                    subtotal += iva;
                                    dataFacturacion.Rows[contFila].Cells[5].Value = iva;
                                    dataFacturacion.Rows[contFila].Cells[6].Value = subtotal;
                                    txtBuscarProdID.Text = "";
                                    txtCantidadProd.Text = "";
                                    lblVistaPrevia.Text = "";
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
                        Cambio();
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
                Cambio();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo() {
            txtTotalColones.Text = "0";
            txtTotalDolares.Text = "0";
            txtVuelto.Text = "0";
            txtPagoCol.Text = "0";
            txtPagoDol.Text = "0";
            txtPagoTC.Text = "0";
            dataFacturacion.Rows.Clear();
            txtBuscarProdID.Text = "0";
            lblVistaPrevia.Text = " ";
            txtBuscarProdID.Focus();
            contFila = 0;
        }

        public void Cambio() { 
            pagoCol = Double.Parse(txtPagoCol.Text);    
            pagoDol = Double.Parse(txtPagoDol.Text);
            pagoTC = Double.Parse(txtPagoTC.Text);
            vuelto = (pagoCol+pagoTC+(pagoDol*610)) - total;
            txtVuelto.Text = vuelto.ToString();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vuelto >= 0)
            {
                foreach (DataGridViewRow Fila in dataFacturacion.Rows)
                {
                    if (Fila.Cells[2].Value.ToString() == "2")
                    {
                        PassVal PassAdm = new PassVal();
                        PassAdm.ShowDialog();
                        Nuevo();
                    }
                }
            }
            else
            {
                MessageBox.Show("La casilla vuelto debe estar en cero");
            }
        }

        private void bntPagar_Click(object sender, EventArgs e)
        {
            Cambio();
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
    }
}
