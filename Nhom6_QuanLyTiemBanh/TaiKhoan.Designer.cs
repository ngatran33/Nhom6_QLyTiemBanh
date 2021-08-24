namespace Nhom6_QuanLyTiemBanh
{
    partial class TaiKhoan
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
            this.ThongTinCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongTinCaNhanToolStripMenuItem,
            this.QuanLyNhanVienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1179, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ThongTinCaNhanToolStripMenuItem
            // 
            this.ThongTinCaNhanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongTinCaNhanToolStripMenuItem.Name = "ThongTinCaNhanToolStripMenuItem";
            this.ThongTinCaNhanToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.ThongTinCaNhanToolStripMenuItem.Text = "Thông tin cá nhân";
            this.ThongTinCaNhanToolStripMenuItem.Click += new System.EventHandler(this.ThongTinCaNhanToolStripMenuItem_Click);
            // 
            // QuanLyNhanVienToolStripMenuItem
            // 
            this.QuanLyNhanVienToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyNhanVienToolStripMenuItem.Name = "QuanLyNhanVienToolStripMenuItem";
            this.QuanLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.QuanLyNhanVienToolStripMenuItem.Text = "Quản lý nhân viên";
            this.QuanLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.QuanLyNhanVienToolStripMenuItem_Click);
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaiKhoan.Location = new System.Drawing.Point(0, 38);
            this.panelTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(1179, 822);
            this.panelTaiKhoan.TabIndex = 2;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 860);
            this.Controls.Add(this.panelTaiKhoan);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThongTinCaNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.Panel panelTaiKhoan;
    }
}