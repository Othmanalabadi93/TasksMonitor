
namespace TaskMonitor.frm
{
    partial class frmSetPassowrd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseOrCancel = new FontAwesome.Sharp.IconButton();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoSecurity = new System.Windows.Forms.RadioButton();
            this.rdoNoSecurity = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkShowPass);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCloseOrCancel);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.txtOldPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdoSecurity);
            this.panel1.Controls.Add(this.rdoNoSecurity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 261);
            this.panel1.TabIndex = 0;
            // 
            // chkShowPass
            // 
            this.chkShowPass.Font = new System.Drawing.Font("Sultan Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkShowPass.ForeColor = System.Drawing.Color.White;
            this.chkShowPass.Location = new System.Drawing.Point(123, 204);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowPass.Size = new System.Drawing.Size(125, 20);
            this.chkShowPass.TabIndex = 8;
            this.chkShowPass.Text = "عرض كلمة المرور";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(388, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnCloseOrCancel.Location = new System.Drawing.Point(11, 9);
            this.btnCloseOrCancel.Name = "btnCloseOrCancel";
            this.btnCloseOrCancel.Size = new System.Drawing.Size(23, 28);
            this.btnCloseOrCancel.TabIndex = 6;
            this.btnCloseOrCancel.UseVisualStyleBackColor = true;
            this.btnCloseOrCancel.Click += new System.EventHandler(this.btnCloseOrCancel_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNewPass.Location = new System.Drawing.Point(11, 143);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(237, 26);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPass.Location = new System.Drawing.Point(11, 172);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(237, 26);
            this.txtConfirmPass.TabIndex = 4;
            this.txtConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOldPass.Location = new System.Drawing.Point(11, 113);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(237, 26);
            this.txtOldPass.TabIndex = 4;
            this.txtOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(257, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "تأكيد كلمة المرور الجديدة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(306, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "كلمة المرور الجديدة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(311, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة المرور القديمة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "لطفا اختر نوع التأمين الذي يناسبك";
            // 
            // rdoSecurity
            // 
            this.rdoSecurity.AutoSize = true;
            this.rdoSecurity.Font = new System.Drawing.Font("Sultan Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoSecurity.ForeColor = System.Drawing.Color.White;
            this.rdoSecurity.Location = new System.Drawing.Point(367, 87);
            this.rdoSecurity.Name = "rdoSecurity";
            this.rdoSecurity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoSecurity.Size = new System.Drawing.Size(96, 20);
            this.rdoSecurity.TabIndex = 2;
            this.rdoSecurity.Text = "بكلمة مرور";
            this.rdoSecurity.UseVisualStyleBackColor = true;
            this.rdoSecurity.CheckedChanged += new System.EventHandler(this.rdoSecurity_CheckedChanged);
            // 
            // rdoNoSecurity
            // 
            this.rdoNoSecurity.AutoSize = true;
            this.rdoNoSecurity.Checked = true;
            this.rdoNoSecurity.Font = new System.Drawing.Font("Sultan Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoNoSecurity.ForeColor = System.Drawing.Color.White;
            this.rdoNoSecurity.Location = new System.Drawing.Point(342, 61);
            this.rdoNoSecurity.Name = "rdoNoSecurity";
            this.rdoNoSecurity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoNoSecurity.Size = new System.Drawing.Size(121, 20);
            this.rdoNoSecurity.TabIndex = 2;
            this.rdoNoSecurity.TabStop = true;
            this.rdoNoSecurity.Text = "بدون كلمة مرور";
            this.rdoNoSecurity.UseVisualStyleBackColor = true;
            this.rdoNoSecurity.CheckedChanged += new System.EventHandler(this.rdoNoSecurity_CheckedChanged);
            // 
            // frmSetPassowrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetPassowrd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSecurity;
        private System.Windows.Forms.RadioButton rdoNoSecurity;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnCloseOrCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkShowPass;
    }
}