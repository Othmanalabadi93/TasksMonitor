using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskMonitor.DAL;
using TaskMonitor.Models;
using TaskMonitor.Styles;
using static System.Windows.Forms.ListViewItem;

namespace TaskMonitor.frm
{
    public partial class frmMain : Form
    {
        Repository db = new Repository();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                FillData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FillData()
        {
            dgvDanger.Rows.Clear();
            dgvExclamation.Rows.Clear();
            dgvSuccessfuly.Rows.Clear();
            db.InitializeData();
            List<Task> tasks = db.GetAllTasks();
            if (tasks.Count == 0)
            {
                MessageBox.Show("عفوا قاعدة البيانات الخاصة بك فارغة!", "تحذير!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            int dangerCount = 0, exclamationCount = 0, successfulyCount = 0;
            foreach (Task t in tasks)
            {
                int code = t.TaskType.GetHashCode();
                if (code == 1)
                {
                    object[] r = new object[3];
                    r[0] = t.ID;
                    r[1] = t.Title;
                    r[2] = Properties.Resources.ic_delete_forever;
                    dgvDanger.Rows.Add(r);

                    dangerCount++;
                }
                else if (code == 2)
                {
                    object[] r = new object[3];
                    r[0] = t.ID;
                    r[1] = t.Title;
                    r[2] = Properties.Resources.ic_delete_forever;
                    dgvExclamation.Rows.Add(r);

                    exclamationCount++;
                }
                else
                {

                    object[] r = new object[3];
                    r[0] = t.ID;
                    r[1] = t.Title;
                    r[2] = Properties.Resources.ic_delete_forever;
                    dgvSuccessfuly.Rows.Add(r);

                    successfulyCount++;
                }
            }
            btnDanger.Text = string.Format("({0}) | متابعة", dangerCount.ToString());
            btnExclamation.Text = string.Format("({0}) | تسوية", exclamationCount.ToString());
            btnSuccessfuly.Text = string.Format("({0}) | تمت المهمة", successfulyCount.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool click = false;
        private void chkMaximaze_CheckedChanged(object sender, EventArgs e)
        {

            if (click == false)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                click = true;
                return;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                click = false;
                return;
            }
        }

        private void btnMinimaize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTask frm = new frmTask();
            pnlShowTask.Controls.Clear();
            frm.ShowDialog();
        }

        bool btnDangerIsClicked = false;
        private void btnDanger_Click(object sender, EventArgs e)
        {
            if (!btnDangerIsClicked)
            {
                pnlDanger.Height = 427;
                btnDangerIsClicked = true;
                btnDanger.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            }
            else
            {
                pnlDanger.Height = 35;
                btnDangerIsClicked = false;
                btnDanger.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            }


            pnlExclamation.Height = 35;
            pnlSuccessfuly.Height = 35;

            btnExclamation.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            btnSuccessfuly.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
        }

        bool btnExclamationIsClicked = false;
        private void btnExclamation_Click(object sender, EventArgs e)
        {
            pnlDanger.Height = 35;

            if (!btnExclamationIsClicked)
            {
                pnlExclamation.Height = 427;
                btnExclamationIsClicked = true;
                btnExclamation.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            }
            else
            {
                pnlExclamation.Height = 35;
                btnExclamationIsClicked = false;
                btnExclamation.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            }

            pnlSuccessfuly.Height = 35;
            btnDanger.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            btnSuccessfuly.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
        }

        bool btnSuccessfulyIsClicked = false;
        private void btnSuccessfuly_Click(object sender, EventArgs e)
        {
            pnlDanger.Height = 35;
            pnlExclamation.Height = 35;

            if (!btnSuccessfulyIsClicked)
            {
                pnlSuccessfuly.Height = 427;
                btnSuccessfulyIsClicked = true;
                btnSuccessfuly.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;

            }
            else
            {
                pnlSuccessfuly.Height = 35;
                btnSuccessfulyIsClicked = false;
                btnSuccessfuly.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;

            }

            btnDanger.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            btnExclamation.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
        }

        private void dgvDanger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (dgvDanger.Rows.Count == 0)
                    return;

                //delete task
                if (dgvDanger.CurrentCell.ColumnIndex == 2)
                {
                    bool rs = MessageBox.Show("هل انت متأكد من حذف هذه المهمة؟", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Cancel;
                    if (rs) return;

                    int idTask = int.Parse(dgvDanger.CurrentRow.Cells[0].FormattedValue.ToString());
                    DeleteTask(idTask);
                }

                // show task
                if (dgvDanger.CurrentCell.ColumnIndex == 1)
                {
                    int idTask = int.Parse(dgvDanger.CurrentRow.Cells[0].FormattedValue.ToString());
                    ShowTask(idTask);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvExclamation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgvExclamation.Rows.Count == 0)
                    return;

                // delete task
                if (dgvExclamation.CurrentCell.ColumnIndex == 2)
                {
                    bool rs = MessageBox.Show("هل انت متأكد من حذف هذه المهمة؟", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Cancel;
                    if (rs) return;

                    int idTask = int.Parse(dgvExclamation.CurrentRow.Cells[0].FormattedValue.ToString());
                    DeleteTask(idTask);
                }

                // show task
                if (dgvExclamation.CurrentCell.ColumnIndex == 1)
                {
                    int idTask = int.Parse(dgvExclamation.CurrentRow.Cells[0].FormattedValue.ToString());
                    ShowTask(idTask);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSuccessfuly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (dgvSuccessfuly.Rows.Count == 0)
                    return;

                //delete task
                if (dgvSuccessfuly.CurrentCell.ColumnIndex == 2)
                {
                    bool rs = MessageBox.Show("هل انت متأكد من حذف هذه المهمة؟", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Cancel;
                    if (rs) return;

                    int idTask = int.Parse(dgvSuccessfuly.CurrentRow.Cells[0].FormattedValue.ToString());
                    DeleteTask(idTask);
                }

                // show task
                if (dgvSuccessfuly.CurrentCell.ColumnIndex == 1)
                {
                    int idTask = int.Parse(dgvSuccessfuly.CurrentRow.Cells[0].FormattedValue.ToString());
                    ShowTask(idTask);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowTask(int id)
        {
            frmTask frm = new frmTask(db.GetById(id));
            pnlShowTask.Controls.Clear();
            frm.TopLevel = false;
            pnlShowTask.Controls.Add(frm);
            frm.Show();
        }

        private void DeleteTask(int id)
        {
            db.Delete(id);
            db.Save();
            FillData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillData();
            pnlDanger.Height = 35;
            pnlExclamation.Height = 35;
            pnlSuccessfuly.Height = 35;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTask frm = new frmTask();
            pnlShowTask.Controls.Clear();
            frm.TopLevel = false;
            pnlShowTask.Controls.Add(frm);
            frm.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            frmDatabase frm = new frmDatabase();
            frm.ShowDialog();
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            frmSetPassowrd frm = new frmSetPassowrd();
            frm.ShowDialog();
        }

        private void btnNotefactions_Click(object sender, EventArgs e)
        {

        }
    }
}
