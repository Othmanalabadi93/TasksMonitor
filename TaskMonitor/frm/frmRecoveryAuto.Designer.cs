
namespace TaskMonitor.frm
{
    partial class frmRecoveryAuto
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
            this.pnlRecoveryAuto = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFileRestore = new System.Windows.Forms.ListBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnCloseOrCancel = new FontAwesome.Sharp.IconButton();
            this.pnlRecoveryAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRecoveryAuto
            // 
            this.pnlRecoveryAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlRecoveryAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecoveryAuto.Controls.Add(this.btnCloseOrCancel);
            this.pnlRecoveryAuto.Controls.Add(this.btnRestore);
            this.pnlRecoveryAuto.Controls.Add(this.lstFileRestore);
            this.pnlRecoveryAuto.Controls.Add(this.label1);
            this.pnlRecoveryAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecoveryAuto.Location = new System.Drawing.Point(0, 0);
            this.pnlRecoveryAuto.Name = "pnlRecoveryAuto";
            this.pnlRecoveryAuto.Size = new System.Drawing.Size(480, 243);
            this.pnlRecoveryAuto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(450, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "تم انشاء نسخ احتياطية بشكل تلقائي من قبل البرنامج، الرجاء اختار احد هذه النسخ لاس" +
    "تعادتها";
            // 
            // lstFileRestore
            // 
            this.lstFileRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstFileRestore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFileRestore.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstFileRestore.ForeColor = System.Drawing.Color.White;
            this.lstFileRestore.FormattingEnabled = true;
            this.lstFileRestore.ItemHeight = 18;
            this.lstFileRestore.Location = new System.Drawing.Point(20, 91);
            this.lstFileRestore.Name = "lstFileRestore";
            this.lstFileRestore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstFileRestore.Size = new System.Drawing.Size(441, 92);
            this.lstFileRestore.TabIndex = 1;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(370, 191);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(91, 34);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "استعادة";
            this.btnRestore.UseVisualStyleBackColor = false;
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
            this.btnCloseOrCancel.TabIndex = 6;
            this.btnCloseOrCancel.UseVisualStyleBackColor = true;
            this.btnCloseOrCancel.Click += new System.EventHandler(this.btnCloseOrCancel_Click);
            // 
            // frmRecoveryAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 243);
            this.Controls.Add(this.pnlRecoveryAuto);
            this.Name = "frmRecoveryAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecoveryAuto";
            this.Load += new System.EventHandler(this.frmRecoveryAuto_Load);
            this.pnlRecoveryAuto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRecoveryAuto;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ListBox lstFileRestore;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseOrCancel;
    }
}