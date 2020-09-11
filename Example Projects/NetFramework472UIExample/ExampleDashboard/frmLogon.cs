﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDashboard
{
    public partial class frmLogon : Form
    {
        public frmLogon()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SharedObjects._Client = new VMware.Horizon.RESTAPI.Client.HorizonRESTClient(teConnectionServer.Text);
                SharedObjects._Client.Logon(teUserName.Text, tePassword.Text, teDomain.Text);
                frmDashboard frd = new frmDashboard();
                frd.Show();
                teUserName.Text = "";
                tePassword.Text = "";
                teDomain.Text = "";
                this.Hide();
                frd.FormClosed += Frd_FormClosed;
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString(), "Error Signing In");
            }
           
            
        }

        private void Frd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void frmLogon_Load(object sender, EventArgs e)
        {

        }
    }
}
