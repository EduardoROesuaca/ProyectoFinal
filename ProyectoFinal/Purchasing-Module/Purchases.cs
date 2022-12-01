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
    public partial class Purchases : Form
    {
        #region Props
        String strConexion;
        #endregion
        public Purchases()
        {
            InitializeComponent();
            //this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //GERALDO
            //this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO-DESKTOP
            this.strConexion = "Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";             //EDUARDO-LAPTOP
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            loadPurchases();
        }

        public void loadPurchases()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetOrders", connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        DGV.DataSource = dt;
                        connection.Close();
                        DGV.Columns[0].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblOrderId.Text = "N.orden " + DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            lblDate.Text = "Fecha " + DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchByOrderID_Click(object sender, EventArgs e)
        {
            int number;
            if(!int.TryParse(txtOrderID.Text.Trim(), out number) || number < 0)
            {
                MessageBox.Show(this, "Ingrese un número de orden válido\nSolo se admiten números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(strConexion))
                    {
                        using (SqlCommand cmd = new SqlCommand("SP_GetOrdersById", connection))
                        {
                            connection.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@OrderID", number);
                            SqlDataReader reader = cmd.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            if (dt.Rows.Count > 0)
                            {
                                DGV.DataSource = dt;
                                connection.Close();
                                DGV.Columns[0].Visible = false;
                            }
                            else
                            {
                                MessageBox.Show(this, "No se ha registrado ninguna orden con el ID proporcionado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadPurchases();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearchByUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length<3 || txtUserName.Text.Trim().Length>25)
            {
                MessageBox.Show(this, "Ingrese un nombre de usuario válido\nMínimo 3 caracteres y máximo 25", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(strConexion))
                    {
                        using (SqlCommand cmd = new SqlCommand("SP_GetOrdersByUserName", connection))
                        {
                            connection.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Name", txtUserName.Text.Trim());
                            SqlDataReader reader = cmd.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            if (dt.Rows.Count > 0)
                            {
                                DGV.DataSource = dt;
                                connection.Close();
                                DGV.Columns[0].Visible = false;
                            }
                            else
                            {
                                MessageBox.Show(this, "No se ha registrado ninguna orden con el nombre de usuario proporcionado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadPurchases();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.ResetText();
            txtOrderID.ResetText();
            loadPurchases();
        }

        private void btnSearchByOrderID_MouseEnter(object sender, EventArgs e)
        {
            btnSearchByOrderID.BackColor = Color.DarkGray;
        }

        private void btnSearchByOrderID_MouseLeave(object sender, EventArgs e)
        {
            btnSearchByOrderID.BackColor = Color.Transparent;
        }

        private void btnSearchByUserName_MouseEnter(object sender, EventArgs e)
        {
            btnSearchByUserName.BackColor = Color.DarkGray;
        }

        private void btnSearchByUserName_MouseLeave(object sender, EventArgs e)
        {
            btnSearchByUserName.BackColor = Color.Transparent;
        }
    }
}
