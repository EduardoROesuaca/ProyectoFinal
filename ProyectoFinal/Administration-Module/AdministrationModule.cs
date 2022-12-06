using ProyectoFinal.Inventory_Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Administration_Module
{
    public partial class AdministrationModule : Form
    {
        #region Props
        String strConexion;
        ExportLogs LogsForm;
        UsersAdministration UsersAdminForm;
        #endregion
        public AdministrationModule()
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

        private void AdministrationModule_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Administración de Usuarios";
            if (this.UsersAdminForm != null)
            {
                this.UsersAdminForm.BringToFront();
            }
            else
            {
                this.UsersAdminForm = new UsersAdministration();
                this.UsersAdminForm.TopLevel = false;
                this.pnlContainer.Controls.Add(UsersAdminForm);
                this.UsersAdminForm.Show();
            }
        }


        private void LogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Generación de reportes de bitácora";
            if (this.LogsForm != null)
            {
                this.LogsForm.BringToFront();
            }
            else
            {
                this.LogsForm = new ExportLogs();
                this.LogsForm.TopLevel = false;
                this.pnlContainer.Controls.Add(LogsForm);
                this.LogsForm.Show();
            }
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Administración de Usuarios";
            if (this.UsersAdminForm != null)
            {
                this.UsersAdminForm.BringToFront();
            }
            else
            {
                this.UsersAdminForm = new UsersAdministration();
                this.UsersAdminForm.TopLevel = false;
                this.pnlContainer.Controls.Add(UsersAdminForm);
                this.UsersAdminForm.Show();
            }
        }
    }
}
