﻿using ProyectoFinal.Invoicing_Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Payment_Module
{
    public partial class PaymentModule : Form
    {
        String strConexion;


        public PaymentModule()
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

        private void PaymentModule_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarFact_Click(object sender, EventArgs e)
        {
            SelectInvoice SI = new SelectInvoice();
            SI.ShowDialog();
            if (SI.DialogResult == DialogResult.OK)
            {
                DataGridViewRow dgRow = SI.DGVBuscarFact.CurrentRow;
                txtNombreCliente.Text = dgRow.Cells[0].Value.ToString();
            }
        }
    }
}
