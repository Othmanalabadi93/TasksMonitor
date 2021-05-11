using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskMonitor.Models;

namespace TaskMonitor.frm
{
    public partial class frmTask : Form
    {
        DAL.Repository db = new DAL.Repository();
        Task _Task;
        public frmTask(Task task = null)
        {
            InitializeComponent();
            _Task = task;
            FillData();
        }

        private void FillData()
        {

            if (_Task != null)
            {
                txtTitle.Text = _Task.Title;
                rchContent.Text = _Task.Content;
                dtpStart.Value = _Task.DateStart;
                if (_Task.IsDateExpire)
                {
                    dtpExpire.Value = _Task.DateExpire;
                    dtpExpire.MinDate = dtpStart.Value.AddDays(1);
                    chkRemember.Checked = _Task.Remember;
                    chkRemember.Enabled = true;
                }

                else
                {
                    dtpExpire.Value = dtpStart.Value.AddDays(1);
                    dtpExpire.MinDate = dtpStart.Value.AddDays(1);
                }

                int type = _Task.TaskType.GetHashCode();
                if (type == 1)
                {
                    rdoDanger.Checked = true;
                    rdoExclamation.Checked = false;
                    rdoSuccessfuly.Checked = false;
                }
                else if (type == 2)
                {
                    rdoDanger.Checked = false;
                    rdoExclamation.Checked = true;
                    rdoSuccessfuly.Checked = false;
                }
                else
                {
                    rdoDanger.Checked = false;
                    rdoExclamation.Checked = false;
                    rdoSuccessfuly.Checked = true;
                }
            }
            else
            {
                dtpStart.Value = DateTime.Now;
                dtpStart.MinDate = DateTime.Now;
                dtpExpire.Value = DateTime.Now.AddDays(15);
                dtpExpire.MinDate = DateTime.Now.AddDays(1);
            }
        }
        private void btnCloseOrCancel_Click(object sender, EventArgs e)
        {
            if (_Task==null)
            {
                // Add Task
                bool res = MessageBox.Show("هل انت متأكد من اغلاق النافذة؟", "اغلاق", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.OK;
                if (res)
                    this.Close();
            }
            else
            {
                //Save Task
                bool res = MessageBox.Show("هل انت متأكد من الغاء اخر التعديلات التي اجريتها؟", "الغاء", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.OK;
                if (res)
                    this.Close();
            }
        }

        private void btnSaveOrAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || rchContent.Text == "")
            {
                MessageBox.Show("لطفا اكمل المعلومات المطلوبة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            if (_Task==null)
            {
                // Add Task
                Models.Task t = new Models.Task();
                t.ID = db.GetMaxId();
                t.Title = txtTitle.Text;
                t.Content = rchContent.Text;
                t.DateStart = dtpStart.Value;

                if (dtpExpire.Checked)
                {
                    t.IsDateExpire = true;
                    t.DateExpire = dtpExpire.Value;

                    if (chkRemember.Checked)
                        t.Remember = true;
                    else
                        t.Remember = false;

                }
                else
                {
                    t.IsDateExpire = false;
                    t.DateExpire = DateTime.Now.AddDays(1);
                }

                if (rdoDanger.Checked)
                    t.TaskType = TaskType.Danger;
                else if(rdoExclamation.Checked)
                    t.TaskType = TaskType.Exclamation;
                else
                    t.TaskType = TaskType.Successfuly;

                db.Insert(t);
                MessageBox.Show("تمت اضافة المهمة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            
            }
            else
            {
                //Update Task
                _Task.Title = txtTitle.Text;
                _Task.Content = rchContent.Text;
                _Task.DateStart = dtpStart.Value;

                if (dtpExpire.Checked)
                {
                    _Task.IsDateExpire = true;
                    _Task.DateExpire = dtpExpire.Value;

                    if (chkRemember.Checked)
                        _Task.Remember = true;
                    else
                        _Task.Remember = false;

                }
                else
                {
                    _Task.IsDateExpire = false;
                    _Task.DateExpire = DateTime.Now.AddDays(1);
                }

                if (rdoDanger.Checked)
                    _Task.TaskType = TaskType.Danger;
                else if (rdoExclamation.Checked)
                    _Task.TaskType = TaskType.Exclamation;
                else
                    _Task.TaskType = TaskType.Successfuly;

                db.Update(_Task);
                db.Save();
                MessageBox.Show("تم تعديل المهمة بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
            this.Close();
        }

    private void dtpExpire_ValueChanged(object sender, EventArgs e)
    {
        if (dtpExpire.Checked)
            chkRemember.Enabled = true;
        else
            chkRemember.Enabled = false;
    }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpExpire.Value = dtpStart.Value.AddDays(1);
            dtpExpire.MinDate = dtpStart.Value.AddDays(1);
        }

        private void frmTask_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();

        }
    }
}
