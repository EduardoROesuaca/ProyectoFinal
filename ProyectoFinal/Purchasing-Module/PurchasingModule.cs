using ProyectoFinal.Inventory_Module;
using ProyectoFinal.Purchasing_Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class PurchasingModule : Form
    {
        #region Props
        String strConexion;
        ProductsAnalysis ProductsAnalysisForm;
        #endregion
        public PurchasingModule()
        {
            InitializeComponent();
            //this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //GERALDO
            this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO-DESKTOP
            //this.strConexion = "Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";             //EDUARDO-LAPTOP
        }

        private void PurchasingModule_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Análisis de productos";
            if (this.ProductsAnalysisForm != null)
            {
                this.ProductsAnalysisForm.BringToFront();
            }
            else
            {
                this.ProductsAnalysisForm = new ProductsAnalysis();
                this.ProductsAnalysisForm.TopLevel = false;
                this.pnlContainer.Controls.Add(ProductsAnalysisForm);
                this.ProductsAnalysisForm.Show();
            }
        }

        private void ProductsAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Análisis de productos";
            if (this.ProductsAnalysisForm != null)
            {
                this.ProductsAnalysisForm.BringToFront();
            }
            else
            {
                this.ProductsAnalysisForm = new ProductsAnalysis();
                this.ProductsAnalysisForm.TopLevel = false;
                this.pnlContainer.Controls.Add(ProductsAnalysisForm);
                this.ProductsAnalysisForm.Show();
            }
        }
    }
}
