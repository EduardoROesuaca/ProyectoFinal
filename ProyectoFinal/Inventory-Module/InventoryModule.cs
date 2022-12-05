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

namespace ProyectoFinal.Inventory_Module
{
    public partial class InventoryModule : Form
    {
        #region Props
        String strConexion;
        SuppliersAdministration SuppliersForm;
        ProductsAdministration ProductsForm;
        CategoryAdministration CategoryForm;
        PresentationAdministration PresentationForm;
        TaxesAdministration TaxesForm;
        #endregion
        public InventoryModule()
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

        private void InventoryModule_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Administración de Productos";
            if (this.ProductsForm != null)
            {
                this.ProductsForm.BringToFront();
            }
            else
            {
                this.ProductsForm = new ProductsAdministration();
                this.ProductsForm.TopLevel = false;
                this.pnlContainer.Controls.Add(ProductsForm);
                this.ProductsForm.Show();
            }
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Administración de Productos";
            if (this.ProductsForm != null)
            {
                this.ProductsForm.BringToFront();
                this.ProductsForm.update();
            }
            else
            {
                this.ProductsForm = new ProductsAdministration();
                this.ProductsForm.TopLevel = false;
                this.pnlContainer.Controls.Add(ProductsForm);
                this.ProductsForm.Show();
            }
        }

        private void SuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Administración de Proveedores";
            if (this.SuppliersForm != null)
            {
                this.SuppliersForm.BringToFront();
                this.SuppliersForm.update();
            }
            else
            {
                this.SuppliersForm = new SuppliersAdministration();
                this.SuppliersForm.TopLevel = false;
                this.pnlContainer.Controls.Add(SuppliersForm);
                this.SuppliersForm.Show();
            }
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Administración de Categorías";
            if (this.CategoryForm != null)
            {
                this.CategoryForm.BringToFront();
                this.CategoryForm.loadCategory();
            }
            else
            {
                this.CategoryForm = new CategoryAdministration();
                this.CategoryForm.TopLevel = false;
                this.pnlContainer.Controls.Add(CategoryForm);
                this.CategoryForm.Show();
            }
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Administración de Presentaciones";
            if (this.PresentationForm != null)
            {
                this.PresentationForm.BringToFront();
                this.PresentationForm.loadPresentation();
            }
            else
            {
                this.PresentationForm = new PresentationAdministration();
                this.PresentationForm.TopLevel = false;
                this.pnlContainer.Controls.Add(PresentationForm);
                this.PresentationForm.Show();
            }
        }

        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Administración de Impuestos";
            if (this.TaxesForm != null)
            {
                this.TaxesForm.BringToFront();
                this.TaxesForm.loadTaxes();
            }
            else
            {
                this.TaxesForm = new TaxesAdministration();
                this.TaxesForm.TopLevel = false;
                this.pnlContainer.Controls.Add(TaxesForm);
                this.TaxesForm.Show();
            }
        }
    }
}
