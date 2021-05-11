
namespace TaskMonitor.frm
{
    partial class frmBackup
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
            this.pnlBackup = new System.Windows.Forms.Panel();
            this.btnCloseOrCancel = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackup
            // 
            this.pnlBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackup.Controls.Add(this.btnCloseOrCancel);
            this.pnlBackup.Controls.Add(this.iconPictureBox1);
            this.pnlBackup.Controls.Add(this.iconButton1);
            this.pnlBackup.Controls.Add(this.label1);
            this.pnlBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackup.Location = new System.Drawing.Point(0, 0);
            this.pnlBackup.Name = "pnlBackup";
            this.pnlBackup.Size = new System.Drawing.Size(465, 148);
            this.pnlBackup.TabIndex = 0;
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
            this.btnCloseOrCancel.Location = new System.Drawing.Point(8, 11);
            this.btnCloseOrCancel.Name = "btnCloseOrCancel";
            this.btnCloseOrCancel.Size = new System.Drawing.Size(23, 28);
            this.btnCloseOrCancel.TabIndex = 4;
            this.btnCloseOrCancel.UseVisualStyleBackColor = true;
            this.btnCloseOrCancel.Click += new System.EventHandler(this.btnCloseOrCancel_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 135;
            this.iconPictureBox1.Location = new System.Drawing.Point(323, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(138, 135);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(262, 97);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 37);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sultan Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(310, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "لعمل نسخة احتياطية يرجى حفظ هذه النسخة في مكان امن للحفاظ على سلامة البيانات في د" +
    "اخلها";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 148);
            this.Controls.Add(this.pnlBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackup";
            this.pnlBackup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackup;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnCloseOrCancel;
    }
}