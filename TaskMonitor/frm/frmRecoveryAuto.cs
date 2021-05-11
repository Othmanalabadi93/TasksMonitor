using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskMonitor.frm
{
    public partial class frmRecoveryAuto : Form
    {
        public frmRecoveryAuto()
        {
            InitializeComponent();
        }

        private void frmRecoveryAuto_Load(object sender, EventArgs e)
        {
            if (lstFileRestore.Items.Count == 0)
                btnRestore.Enabled = false;
            else
                btnRestore.Enabled = true;
        }

        private void btnCloseOrCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
