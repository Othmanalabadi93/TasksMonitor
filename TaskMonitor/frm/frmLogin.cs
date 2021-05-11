using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskMonitor.Helper;

namespace TaskMonitor.frm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass = Security.Decryption(Properties.Settings.Default.Pass);
            if (pass!=txtPass.Text )
            {
                MessageBox.Show("كلمة المرور غير صحيحة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }
            else
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.Show();
            }
        }
    }
}
