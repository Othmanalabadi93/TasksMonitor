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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnCloseOrCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "(backup)| *.obu";
                bool re = sv.ShowDialog() == DialogResult.Cancel;

                if (re)
                    return;

                string pathSource = Application.StartupPath + "\\db\\tasksdb";
                File.Copy(pathSource, sv.FileName+ ".obu");

                MessageBox.Show("تم عمل نسخة احتياطية بنجاح", "نسخ الحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
