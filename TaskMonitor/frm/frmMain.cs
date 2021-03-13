using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskMonitor.Controls;

namespace TaskMonitor.frm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            fillListItem();
        }
        private void fillListItem()
        {
            ListItem[] listItems = new ListItem[20];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Title = "عثمان العبادي";
                listItems[i].Content = "نص حكيم قاطع له سر";
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                    flowLayoutPanel1.Controls.Add(listItems[i]);
            }
        }
    }
}
