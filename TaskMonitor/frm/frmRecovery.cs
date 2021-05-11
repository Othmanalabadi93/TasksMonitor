using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TaskMonitor.frm
{
    public partial class frmRecovery : Form
    {
        public frmRecovery()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "(backup)| *.obu";
                op.Multiselect = false;
                bool re = op.ShowDialog() == DialogResult.Cancel;

                if (re)
                    return;

                string pathSource = Application.StartupPath + "\\db\\tasksdb";

                if (File.Exists(pathSource))
                {
                    File.Delete(pathSource);
                }

                File.Copy(op.FileName, pathSource);

                MessageBox.Show("تم استعادة نسخة الاحتياطية بنجاح\nجارٍ الخروج من البرنامج", "استعادة النسخة الحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseOrCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
