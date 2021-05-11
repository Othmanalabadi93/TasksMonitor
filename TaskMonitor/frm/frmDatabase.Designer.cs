
namespace TaskMonitor.frm
{
    partial class frmDatabase
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
            this.pnlDatabase = new System.Windows.Forms.Panel();
            this.btnCloseOrCancel = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoRecoveryAuto = new System.Windows.Forms.RadioButton();
            this.rdoRecovery = new System.Windows.Forms.RadioButton();
            this.rdoBackup = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatabase
            // 
            this.pnlDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatabase.Controls.Add(this.btnCloseOrCancel);
            this.pnlDatabase.Controls.Add(this.button1);
            this.pnlDatabase.Controls.Add(this.rdoRecoveryAuto);
            this.pnlDatabase.Controls.Add(this.rdoRecovery);
            this.pnlDatabase.Controls.Add(this.rdoBackup);
            this.pnlDatabase.Controls.Add(this.label2);
            this.pnlDatabase.Controls.Add(this.label1);
            this.pnlDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatabase.Location = new System.Drawing.Point(0, 0);
            this.pnlDatabase.Name = "pnlDatabase";
            this.pnlDatabase.Size = new System.Drawing.Size(411, 215);
            this.pnlDatabase.TabIndex = 0;
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
            this.btnCloseOrCancel.Location = new System.Drawing.Point(11, 11);
            this.btnCloseOrCancel.Name = "btnCloseOrCancel";
            this.btnCloseOrCancel.Size = new System.Drawing.Size(23, 28);
            this.btnCloseOrCancel.TabIndex = 5;
            this.btnCloseOrCancel.UseVisualStyleBackColor = true;
            this.btnCloseOrCancel.Click += new System.EventHandler(this.btnCloseOrCancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(277, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "التالي";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoRecoveryAuto
            // 
            this.rdoRecoveryAuto.AutoSize = true;
            this.rdoRecoveryAuto.Font = new System.Drawing.Font("Sultan Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoRecoveryAuto.ForeColor = System.Drawing.Color.White;
            this.rdoRecoveryAuto.Location = new System.Drawing.Point(32, 129);
            this.rdoRecoveryAuto.Name = "rdoRecoveryAuto";
            this.rdoRecoveryAuto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoRecoveryAuto.Size = new System.Drawing.Size(332, 20);
            this.rdoRecoveryAuto.TabIndex = 1;
            this.rdoRecoveryAuto.Text = "استعدة النسخة الاحتياطية التي تم انشائها بشكل تلقائي";
            this.rdoRecoveryAuto.UseVisualStyleBackColor = true;
            // 
            // rdoRecovery
            // 
            this.rdoRecovery.AutoSize = true;
            this.rdoRecovery.Font = new System.Drawing.Font("Sultan Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoRecovery.ForeColor = System.Drawing.Color.White;
            this.rdoRecovery.Location = new System.Drawing.Point(189, 104);
            this.rdoRecovery.Name = "rdoRecovery";
            this.rdoRecovery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoRecovery.Size = new System.Drawing.Size(175, 20);
            this.rdoRecovery.TabIndex = 1;
            this.rdoRecovery.Text = "استعدة النسخة الاحتياطية";
            this.rdoRecovery.UseVisualStyleBackColor = true;
            // 
            // rdoBackup
            // 
            this.rdoBackup.AutoSize = true;
            this.rdoBackup.Checked = true;
            this.rdoBackup.Font = new System.Drawing.Font("Sultan Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoBackup.ForeColor = System.Drawing.Color.White;
            this.rdoBackup.Location = new System.Drawing.Point(221, 79);
            this.rdoBackup.Name = "rdoBackup";
            this.rdoBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoBackup.Size = new System.Drawing.Size(143, 20);
            this.rdoBackup.TabIndex = 1;
            this.rdoBackup.TabStop = true;
            this.rdoBackup.Text = "عمل نسخة احتياطية";
            this.rdoBackup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "رجاءً اختر الاجراء المناسب الذي تود القيام به لتنفيذه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sultan Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اهلا وسهلا بك في مركز التحكم بالبيانات";
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 215);
            this.Controls.Add(this.pnlDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatabase";
            this.pnlDatabase.ResumeLayout(false);
            this.pnlDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoRecoveryAuto;
        private System.Windows.Forms.RadioButton rdoRecovery;
        private System.Windows.Forms.RadioButton rdoBackup;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnCloseOrCancel;
    }
}