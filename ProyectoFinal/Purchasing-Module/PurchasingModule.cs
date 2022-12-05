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
        Purchases PurchasesForm;
        NewPurchase NewPurchaseForm;
        #endregion
        public PurchasingModule()
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

        private void PurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Consulta de Pedidos";
            if (this.PurchasesForm != null)
            {
                this.PurchasesForm.BringToFront();
                this.PurchasesForm.loadPurchases();
            }
            else
            {
                this.PurchasesForm = new Purchases();
                this.PurchasesForm.TopLevel = false;
                this.pnlContainer.Controls.Add(PurchasesForm);
                this.PurchasesForm.Show();
            }
        }

        private void NewPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Registrar Nuevo Pedido";
            if (this.NewPurchaseForm != null)
            {
                this.NewPurchaseForm.BringToFront();
                this.NewPurchaseForm.loadPresentation();
                this.NewPurchaseForm.loadProducts();
            }
            else
            {
                this.NewPurchaseForm = new NewPurchase();
                this.NewPurchaseForm.TopLevel = false;
                this.pnlContainer.Controls.Add(NewPurchaseForm);
                this.NewPurchaseForm.Show();
            }
        }
    }
}
