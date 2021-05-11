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
    public partial class frmSetPassowrd : Form
    {
        public frmSetPassowrd()
        {
            InitializeComponent();
        }

        private void btnCloseOrCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoNoSecurity.Checked)
            {
                Properties.Settings.Default.Pass = Security.Encryption("admin");
                Properties.Settings.Default.isSecurity = false;
                Properties.Settings.Default.Save();

                MessageBox.Show("تم حفظ التغيرات بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                this.Close();
            }
            else
            {
                if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtConfirmPass.Text == "") return;
                if (txtNewPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("كلمة المرور الجديدة غير مطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    return;
                }

                if (Security.Decryption(Properties.Settings.Default.Pass) != txtOldPass.Text)
                {
                    MessageBox.Show("كلمة المرور القديمة غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    return;
                }

                Properties.Settings.Default.Pass = Security.Encryption(txtNewPass.Text);
                Properties.Settings.Default.isSecurity = true;
                Properties.Settings.Default.Save();

                MessageBox.Show("تم تغير كلمة المرور بنجاح", "تغير باسورد", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                this.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isSecurity)
            {
                rdoSecurity.Checked = true;
                rdoNoSecurity.Checked = false;
                txtOldPass.Enabled = true;
                txtNewPass.Enabled = true;
                txtConfirmPass.Enabled = true;
            }
            else
            {
                rdoSecurity.Checked = false;
                rdoNoSecurity.Checked = true;
                txtOldPass.Enabled = false;
                txtNewPass.Enabled = false;
                txtConfirmPass.Enabled = false;
            }
        }

        private void rdoNoSecurity_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPass.Enabled = false;
            txtNewPass.Enabled = false;
            txtConfirmPass.Enabled = false;
            chkShowPass.Enabled = false;
        }

        private void rdoSecurity_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPass.Enabled = true;
            txtNewPass.Enabled = true;
            txtConfirmPass.Enabled = true;
            chkShowPass.Enabled = true;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtOldPass.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
                txtConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPass.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }
    }
}
