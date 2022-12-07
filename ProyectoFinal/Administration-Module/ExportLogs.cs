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

namespace ProyectoFinal.Administration_Module
{
    public partial class ExportLogs : Form
    {
        #region Props
        String strConexion;
        #endregion
        public ExportLogs()
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

        private void ExportLogs_Load(object sender, EventArgs e)
        {
            loadUsers();
        }

        void loadUsers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT UserId, Name FROM DBO.Users", connection);
                da.Fill(dt);
                cmbxUsers.DataSource = dt;
                cmbxUsers.DisplayMember = "Name";
                cmbxUsers.ValueMember = "UserId";
                connection.Close();
                System.GC.Collect();
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Se generará un reporte de bitácora del usuario {"+cmbxUsers.Text+"}\n¿Desea continuar?","Atención",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                String query = "SELECT L.LogId,L.RegisterDate,U.Name,L.Description FROM DBO.Logs L, Users U WHERE L.UserId="+cmbxUsers.SelectedValue+" AND L.UserId=U.UserId";
                if (!chkDate.Checked)
                {
                    if(dtInicio.Value.ToString("yyyy-MM-dd HH:mm:ss").Equals(dtFinal.Value.ToString("yyyy-MM-dd HH:mm:ss")))
                    {
                        query += " AND L.RegisterDate > CONVERT(SMALLDATETIME,'" + dtInicio.Value.ToString("yyyy-MM-dd")+" 00:00:00" + "',120) AND L.RegisterDate < CONVERT(SMALLDATETIME,'" + dtFinal.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',120)";
                    }
                    else
                    {
                        query += " AND L.RegisterDate > CONVERT(SMALLDATETIME,'" + dtInicio.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',120) AND L.RegisterDate < CONVERT(SMALLDATETIME,'" + dtFinal.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',120)";
                    }
                    
                }
                ReportContainer rc = new ReportContainer();
                using (SqlConnection connection = new SqlConnection(strConexion))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query,connection);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string userName = Environment.UserName;
                    rc.reportViewer1.LocalReport.ReportPath = "C:\\Users\\"+userName+"\\source\\repos\\ProyectoFinal\\ProyectoFinal\\Administration-Module\\rptLogs.rdlc";
                    rc.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

                    rc.reportViewer1.RefreshReport();
                    rc.ShowDialog();
                }
            }
        }
    }
}
