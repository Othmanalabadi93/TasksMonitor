using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskMonitor.frm
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoBackup.Checked)
            {
                frmBackup frm = new frmBackup();
                this.Hide();
                frm.ShowDialog();
            }
            else if (rdoRecovery.Checked)
            {
                frmRecovery frm = new frmRecovery();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                frmRecoveryAuto frm = new frmRecoveryAuto();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void btnCloseOrCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
