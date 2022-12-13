using ProyectoFinal.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Reports
{
    public partial class ReportsView : Form
    {
        #region Props
        String strConexion;
        #endregion

        public ReportsView()
        {
            InitializeComponent();
            if (Environment.MachineName.Equals("EDUARDO"))
            {
                this.strConexion = "Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";            //EDUARDO-LAPTOP
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

        private void ReportsView_Load(object sender, EventArgs e)
        {
            loadDate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Saldos", connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", UserCache.UserID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        if (dt.Rows.Count > 0)
                        {
                            txtFlujoCajaCol.Text = dt.Rows[0]["COLONES"].ToString();
                            txtFlujoCajaDol.Text = dt.Rows[0]["DOLARES"].ToString();
                            txtFlujoCajaCard.Text = dt.Rows[0]["TARJETA"].ToString();
                        }
                        else
                        {
                            MessageBox.Show(this, "Algo salio mal!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void loadDate()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Date FROM Sales Where UserId ='" + int.Parse(UserCache.UserID.ToString()), connection);
                    dataAdapter.Fill(dt);
                    cmbxFechas.DataSource = dt;
                    cmbxFechas.DisplayMember = "Date";
                    connection.Close();
                    System.GC.Collect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

