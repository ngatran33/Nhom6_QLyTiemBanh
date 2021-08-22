namespace Nhom6_QuanLyTiemBanh
{
    partial class QLyHoaDon
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDB = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHD = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHDN,
            this.mnuHDB});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHDN
            // 
            this.mnuHDN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHDN.Name = "mnuHDN";
            this.mnuHDN.Size = new System.Drawing.Size(137, 27);
            this.mnuHDN.Text = "Hóa Đơn Nhập";
            this.mnuHDN.Click += new System.EventHandler(this.mnuHDN_Click);
            // 
            // mnuHDB
            // 
            this.mnuHDB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHDB.Name = "mnuHDB";
            this.mnuHDB.Size = new System.Drawing.Size(124, 27);
            this.mnuHDB.Text = "Hóa Đơn Bán";
            this.mnuHDB.Click += new System.EventHandler(this.mnuHDB_Click);
            // 
            // pnlHD
            // 
            this.pnlHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHD.Location = new System.Drawing.Point(0, 31);
            this.pnlHD.Name = "pnlHD";
            this.pnlHD.Size = new System.Drawing.Size(1062, 707);
            this.pnlHD.TabIndex = 1;
            // 
            // QLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 738);
            this.Controls.Add(this.pnlHD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLyHoaDon";
            this.Load += new System.EventHandler(this.QLyHoaDon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHDN;
        private System.Windows.Forms.ToolStripMenuItem mnuHDB;
        private System.Windows.Forms.Panel pnlHD;
    }
}