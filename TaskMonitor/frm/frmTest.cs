using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskMonitor.Styles;

namespace TaskMonitor.frm
{
    public partial class frmTest : Form
    {
        DAL.Repository db = new DAL.Repository();
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = db.GetById(1).DateStart.ToString();
        }
    }
}
