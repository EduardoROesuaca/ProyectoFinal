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
        #endregion
        public InventoryModule()
        {
            InitializeComponent();
            //this.strConexion = "Data Source=DESKTOP-ASF7EIQ\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True"; //GERALDO
            this.strConexion = "Data Source=DESKTOP-KQNBJVI\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";   //EDUARDO
        }

        private void InventoryModule_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Administración de Productos";
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
            }
            else
            {
                this.SuppliersForm = new SuppliersAdministration();
                this.SuppliersForm.TopLevel = false;
                this.pnlContainer.Controls.Add(SuppliersForm);
                this.SuppliersForm.Show();
            }
        }
    }
}
