
namespace TaskMonitor.frm
{
    partial class frmTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdoSuccessfuly = new System.Windows.Forms.RadioButton();
            this.rdoExclamation = new System.Windows.Forms.RadioButton();
            this.rdoDanger = new System.Windows.Forms.RadioButton();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.dtpExpire = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoOne = new System.Windows.Forms.RadioButton();
            this.rdoThree = new System.Windows.Forms.RadioButton();
            this.rdoTow = new System.Windows.Forms.RadioButton();
            this.pnlTask = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rchContent = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnCloseOrCancel = new FontAwesome.Sharp.IconButton();
            this.btnSaveOrAdd = new FontAwesome.Sharp.IconButton();
            this.panel5.SuspendLayout();
            this.pnlTask.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.rdoSuccessfuly);
            this.panel5.Controls.Add(this.rdoExclamation);
            this.panel5.Controls.Add(this.rdoDanger);
            this.panel5.Controls.Add(this.chkRemember);
            this.panel5.Controls.Add(this.dtpExpire);
            this.panel5.Controls.Add(this.dtpStart);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.rdoOne);
            this.panel5.Controls.Add(this.rdoThree);
            this.panel5.Controls.Add(this.rdoTow);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 467);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(594, 102);
            this.panel5.TabIndex = 4;
            // 
            // rdoSuccessfuly
            // 
            this.rdoSuccessfuly.AutoSize = true;
            this.rdoSuccessfuly.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoSuccessfuly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoSuccessfuly.Location = new System.Drawing.Point(339, 66);
            this.rdoSuccessfuly.Name = "rdoSuccessfuly";
            this.rdoSuccessfuly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoSuccessfuly.Size = new System.Drawing.Size(88, 22);
            this.rdoSuccessfuly.TabIndex = 7;
            this.rdoSuccessfuly.Text = "تمت المهمة";
            this.rdoSuccessfuly.UseVisualStyleBackColor = true;
            // 
            // rdoExclamation
            // 
            this.rdoExclamation.AutoSize = true;
            this.rdoExclamation.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoExclamation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoExclamation.Location = new System.Drawing.Point(433, 66);
            this.rdoExclamation.Name = "rdoExclamation";
            this.rdoExclamation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoExclamation.Size = new System.Drawing.Size(69, 22);
            this.rdoExclamation.TabIndex = 7;
            this.rdoExclamation.Text = "تسوية";
            this.rdoExclamation.UseVisualStyleBackColor = true;
            // 
            // rdoDanger
            // 
            this.rdoDanger.AutoSize = true;
            this.rdoDanger.Checked = true;
            this.rdoDanger.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoDanger.ForeColor = System.Drawing.Color.Red;
            this.rdoDanger.Location = new System.Drawing.Point(508, 66);
            this.rdoDanger.Name = "rdoDanger";
            this.rdoDanger.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoDanger.Size = new System.Drawing.Size(69, 22);
            this.rdoDanger.TabIndex = 7;
            this.rdoDanger.TabStop = true;
            this.rdoDanger.Text = "متابعة";
            this.rdoDanger.UseVisualStyleBackColor = true;
            // 
            // chkRemember
            // 
            this.chkRemember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRemember.AutoSize = true;
            this.chkRemember.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRemember.Enabled = false;
            this.chkRemember.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRemember.ForeColor = System.Drawing.Color.White;
            this.chkRemember.Location = new System.Drawing.Point(411, 42);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(166, 22);
            this.chkRemember.TabIndex = 6;
            this.chkRemember.Text = "قم بتنبيهي قبل انتهاء الموعد";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // dtpExpire
            // 
            this.dtpExpire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpire.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpExpire.Checked = false;
            this.dtpExpire.CustomFormat = "yyyy/MM/dd";
            this.dtpExpire.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpExpire.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpExpire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpire.Location = new System.Drawing.Point(24, 10);
            this.dtpExpire.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpExpire.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpExpire.Name = "dtpExpire";
            this.dtpExpire.ShowCheckBox = true;
            this.dtpExpire.ShowUpDown = true;
            this.dtpExpire.Size = new System.Drawing.Size(120, 25);
            this.dtpExpire.TabIndex = 5;
            this.dtpExpire.ValueChanged += new System.EventHandler(this.dtpExpire_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpStart.CustomFormat = "yyyy/MM/dd";
            this.dtpStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpStart.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(340, 9);
            this.dtpStart.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(130, 25);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = ": المدة المتوقعة لاتمام المهمة";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = ": تاريخ انشاء المهمة";
            // 
            // rdoOne
            // 
            this.rdoOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoOne.AutoSize = true;
            this.rdoOne.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rdoOne.Location = new System.Drawing.Point(907, 108);
            this.rdoOne.Name = "rdoOne";
            this.rdoOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoOne.Size = new System.Drawing.Size(63, 22);
            this.rdoOne.TabIndex = 3;
            this.rdoOne.Text = "متابعة";
            this.rdoOne.UseVisualStyleBackColor = true;
            // 
            // rdoThree
            // 
            this.rdoThree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoThree.AutoSize = true;
            this.rdoThree.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoThree.Location = new System.Drawing.Point(745, 108);
            this.rdoThree.Name = "rdoThree";
            this.rdoThree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoThree.Size = new System.Drawing.Size(80, 22);
            this.rdoThree.TabIndex = 3;
            this.rdoThree.Text = "تمت المهمة";
            this.rdoThree.UseVisualStyleBackColor = true;
            // 
            // rdoTow
            // 
            this.rdoTow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoTow.AutoSize = true;
            this.rdoTow.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoTow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rdoTow.Location = new System.Drawing.Point(834, 108);
            this.rdoTow.Name = "rdoTow";
            this.rdoTow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoTow.Size = new System.Drawing.Size(64, 22);
            this.rdoTow.TabIndex = 3;
            this.rdoTow.Text = "تسوية";
            this.rdoTow.UseVisualStyleBackColor = true;
            // 
            // pnlTask
            // 
            this.pnlTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTask.Controls.Add(this.panel1);
            this.pnlTask.Controls.Add(this.panel2);
            this.pnlTask.Controls.Add(this.panel5);
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTask.Location = new System.Drawing.Point(0, 0);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(596, 571);
            this.pnlTask.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rchContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 398);
            this.panel1.TabIndex = 5;
            // 
            // rchContent
            // 
            this.rchContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rchContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchContent.Font = new System.Drawing.Font("Sultan Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rchContent.ForeColor = System.Drawing.Color.White;
            this.rchContent.Location = new System.Drawing.Point(0, 0);
            this.rchContent.Name = "rchContent";
            this.rchContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rchContent.Size = new System.Drawing.Size(590, 394);
            this.rchContent.TabIndex = 0;
            this.rchContent.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.btnCloseOrCancel);
            this.panel2.Controls.Add(this.btnSaveOrAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 69);
            this.panel2.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Sultan Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(64, 17);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(523, 31);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCloseOrCancel
            // 
            this.btnCloseOrCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseOrCancel.FlatAppearance.BorderSize = 0;
            this.btnCloseOrCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseOrCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCloseOrCancel.IconColor = System.Drawing.Color.White;
            this.btnCloseOrCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseOrCancel.IconSize = 32;
            this.btnCloseOrCancel.Location = new System.Drawing.Point(7, 20);
            this.btnCloseOrCancel.Name = "btnCloseOrCancel";
            this.btnCloseOrCancel.Size = new System.Drawing.Size(23, 28);
            this.btnCloseOrCancel.TabIndex = 2;
            this.btnCloseOrCancel.UseVisualStyleBackColor = true;
            this.btnCloseOrCancel.Click += new System.EventHandler(this.btnCloseOrCancel_Click);
            // 
            // btnSaveOrAdd
            // 
            this.btnSaveOrAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveOrAdd.FlatAppearance.BorderSize = 0;
            this.btnSaveOrAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveOrAdd.IconColor = System.Drawing.Color.White;
            this.btnSaveOrAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveOrAdd.IconSize = 32;
            this.btnSaveOrAdd.Location = new System.Drawing.Point(33, 20);
            this.btnSaveOrAdd.Name = "btnSaveOrAdd";
            this.btnSaveOrAdd.Size = new System.Drawing.Size(23, 28);
            this.btnSaveOrAdd.TabIndex = 2;
            this.btnSaveOrAdd.UseVisualStyleBackColor = true;
            this.btnSaveOrAdd.Click += new System.EventHandler(this.btnSaveOrAdd_Click);
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 571);
            this.Controls.Add(this.pnlTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTask";
            this.Load += new System.EventHandler(this.frmTask_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlTask.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoOne;
        private System.Windows.Forms.RadioButton rdoThree;
        private System.Windows.Forms.RadioButton rdoTow;
        private System.Windows.Forms.Panel pnlTask;
        private System.Windows.Forms.DateTimePicker dtpExpire;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rchContent;
        private FontAwesome.Sharp.IconButton btnCloseOrCancel;
        private FontAwesome.Sharp.IconButton btnSaveOrAdd;
        private System.Windows.Forms.RadioButton rdoSuccessfuly;
        private System.Windows.Forms.RadioButton rdoExclamation;
        private System.Windows.Forms.RadioButton rdoDanger;
    }
}