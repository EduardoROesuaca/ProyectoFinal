using Microsoft.VisualBasic.Devices;
using ProyectoFinal.Administration_Module;
using ProyectoFinal.Inventory_Module;
using ProyectoFinal.Payment_Module;
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

namespace ProyectoFinal.Common
{
    public partial class Home : Form
    {
        #region Props
        String strConexion;
        bool Move = false;
        int mx, my;
        #endregion

        #region MDIChilds
        ExportLogs ExportLogsForm;
        AdministrationModule AdministrationForm;
        InvoicingModule InvoicingForm;
        PurchasingModule PurchasingForm;
        InventoryModule InventoryForm;
        PaymentModule PaymentForm;

        #endregion
        public Home()
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

        private void Home_Load(object sender, EventArgs e)
        {
            lblName.Text = UserCache.Name;
            if (UserCache.RoleID == 1)
            {
                lblRol.Text = "Cajero";
            }else if (UserCache.RoleID==2)
            {
                lblRol.Text = "Vendedor";
            }
            else
            {
                lblRol.Text = "Administrador de Sistema";
            }

            switch (UserCache.RoleID)
            {
                case 1:
                    this.btnInvoicingModule.Visible = false;
                    this.btnPurchasingModule.Visible = false;
                    this.btnInventoryModule.Visible = false;
                    this.btnSysAdmin.Visible = false;
                    break;
                case 2:
                    this.btnCajas.Visible = false;
                    this.btnPurchasingModule.Visible = false;
                    this.btnInventoryModule.Visible = false;
                    this.btnSysAdmin.Visible = false;
                    this.btnReports.Visible = false;

                    InvoicingForm = new InvoicingModule();
                    this.InvoicingForm.TopLevel = false;
                    this.plnContainer.Controls.Add(InvoicingForm);
                    this.InvoicingForm.Show();
                    break;
                default:
                    InvoicingForm = new InvoicingModule();
                    this.InvoicingForm.TopLevel = false;
                    this.plnContainer.Controls.Add(InvoicingForm);
                    this.InvoicingForm.Show();
                    break;

            }
        }

        private void PBClose_Click(object sender, EventArgs e)
        {

        }

        private void PBMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                using (SqlCommand cmd4 = new SqlCommand("SP_InsertLog", connection))
                {
                    connection.Open();
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@UserID", UserCache.UserID);
                    cmd4.Parameters.AddWithValue("@message", "Nuevo cierre de Sesión!");
                    cmd4.ExecuteNonQuery();
                }
            }

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnInvoicingModule_Click(object sender, EventArgs e)
        {
            if (this.InvoicingForm != null)
            {
                this.InvoicingForm.BringToFront();
            }
            else
            {
                this.InvoicingForm = new InvoicingModule();
                this.InvoicingForm.TopLevel = false;
                this.plnContainer.Controls.Add(InvoicingForm);
                this.InvoicingForm.Show();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (this.ExportLogsForm != null)
            {
                this.ExportLogsForm.BringToFront();
            }
            else{
                this.ExportLogsForm = new ExportLogs();
                this.ExportLogsForm.TopLevel = false;
                this.plnContainer.Controls.Add(ExportLogsForm);
                this.ExportLogsForm.Show();
            }
        }

        private void plnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            this.Move = true;
            this.mx = e.X;
            this.my = e.Y;
        }

        private void plnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Move)
            {
                this.Left = this.Left + (e.X - mx); this.Top = this.Top + (e.Y - my);
            }
        }

        private void btnSysAdmin_Click(object sender, EventArgs e)
        {
            if (this.AdministrationForm != null)
            {
                this.AdministrationForm.BringToFront();
            }
            else
            {
                this.AdministrationForm = new AdministrationModule();
                this.AdministrationForm.TopLevel = false;
                this.plnContainer.Controls.Add(AdministrationForm);
                this.AdministrationForm.Show();
            }
        }

        private void btnPurchasingModule_Click(object sender, EventArgs e)
        {
            if (this.PurchasingForm != null)
            {
                this.PurchasingForm.BringToFront();
            }
            else
            {
                this.PurchasingForm = new PurchasingModule();
                this.PurchasingForm.TopLevel = false;
                this.plnContainer.Controls.Add(PurchasingForm);
                this.PurchasingForm.Show();
            }
        }

        private void btnInventoryModule_Click(object sender, EventArgs e)
        {
            if (this.InventoryForm != null)
            {
                this.InventoryForm.BringToFront();
            }
            else
            {
                this.InventoryForm = new InventoryModule();
                this.InventoryForm.TopLevel = false;
                this.plnContainer.Controls.Add(InventoryForm);
                this.InventoryForm.Show();
            }
        }

        private void plnContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            if (this.PaymentForm != null)
            {
                this.PaymentForm.BringToFront();
            }
            else
            {
                this.PaymentForm = new PaymentModule();
                this.PaymentForm.TopLevel = false;
                this.plnContainer.Controls.Add(PaymentForm);
                this.PaymentForm.Show();
            }
        }

        private void plnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            this.Move = false;
            this.my = 0;
            this.mx = 0;
        }
    }
}
