using Microsoft.Reporting.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoFinal.Purchasing_Module
{
    public partial class NewPurchase : Form
    {
        public NewPurchase()
        {
            InitializeComponent();
        }

        private void NewPurchase_Load(object sender, EventArgs e)
        {
           
        }
        void loadPresentation()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT PresentationId, Description FROM DBO.ProductsPresentation", connection);
                da.Fill(dt);
                cmbxPresentation.DataSource = dt;
                cmbxPresentation.DisplayMember = "Description";
                cmbxPresentation.ValueMember = "PresentationId";
                connection.Close();
                System.GC.Collect();
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this.DGV,"Desea confirmar el siguiente pedido?", "Atención",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                //TODO: Stuff
            }
        }
    }
}
