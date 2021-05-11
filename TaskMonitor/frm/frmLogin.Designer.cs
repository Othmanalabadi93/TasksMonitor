
namespace TaskMonitor.frm
{
    partial class frmLogin
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
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.chkShowPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 210);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(181, 151);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(229, 151);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(42, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Font = new System.Drawing.Font("Sultan Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkShowPass.ForeColor = System.Drawing.Color.White;
            this.chkShowPass.Location = new System.Drawing.Point(152, 115);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowPass.Size = new System.Drawing.Size(119, 19);
            this.chkShowPass.TabIndex = 3;
            this.chkShowPass.Text = "عرض كلمة المرور";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(32, 83);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(239, 26);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sultan Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "تسجيل دخول";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(311, 210);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.CheckBox chkShowPass;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}