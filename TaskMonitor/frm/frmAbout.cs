using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskMonitor.frm
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnCloseOrCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
 System.Diagnostics.Process.Start("mailto:othmanalabadi93@gmail.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
