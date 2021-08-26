namespace Nhom6_QuanLyTiemBanh
{
    partial class QLySanPham
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTimKiemTheoTen = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTimKiemTheoMa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuongCo = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvSanPham, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 789);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 467);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(658, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nhập tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(819, 55);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 30);
            this.txtTimKiem.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnTimKiemTheoTen);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnHienThi);
            this.groupBox2.Controls.Add(this.btnTimKiemTheoMa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(620, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(257, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(196, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(32, 115);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(190, 41);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTimKiemTheoTen
            // 
            this.btnTimKiemTheoTen.Location = new System.Drawing.Point(257, 190);
            this.btnTimKiemTheoTen.Name = "btnTimKiemTheoTen";
            this.btnTimKiemTheoTen.Size = new System.Drawing.Size(196, 42);
            this.btnTimKiemTheoTen.TabIndex = 5;
            this.btnTimKiemTheoTen.Text = "Tìm kiếm theo tên";
            this.btnTimKiemTheoTen.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoTen.Click += new System.EventHandler(this.btnTimKiemTheoTen_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(257, 44);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(196, 41);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(32, 44);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(190, 41);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTimKiemTheoMa
            // 
            this.btnTimKiemTheoMa.Location = new System.Drawing.Point(32, 190);
            this.btnTimKiemTheoMa.Name = "btnTimKiemTheoMa";
            this.btnTimKiemTheoMa.Size = new System.Drawing.Size(190, 42);
            this.btnTimKiemTheoMa.TabIndex = 4;
            this.btnTimKiemTheoMa.Text = "Tìm kiếm theo mã";
            this.btnTimKiemTheoMa.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoMa.Click += new System.EventHandler(this.btnTimKiemTheoMa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cbbLoaiSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSoLuongCo);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Location = new System.Drawing.Point(208, 277);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(248, 33);
            this.cbbLoaiSP.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loại sản phẩm";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(208, 220);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(248, 30);
            this.txtDonGia.TabIndex = 7;
            // 
            // txtSoLuongCo
            // 
            this.txtSoLuongCo.Location = new System.Drawing.Point(208, 163);
            this.txtSoLuongCo.Name = "txtSoLuongCo";
            this.txtSoLuongCo.Size = new System.Drawing.Size(248, 30);
            this.txtSoLuongCo.TabIndex = 6;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(208, 106);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(248, 30);
            this.txtTenSP.TabIndex = 5;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(208, 49);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(248, 30);
            this.txtMaSP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng có";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSp,
            this.Slco,
            this.Gia,
            this.MaLoaiSP});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 476);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.Size = new System.Drawing.Size(1134, 310);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 150;
            // 
            // TenSp
            // 
            this.TenSp.DataPropertyName = "TenSp";
            this.TenSp.HeaderText = "Tên sản phẩm";
            this.TenSp.MinimumWidth = 8;
            this.TenSp.Name = "TenSp";
            this.TenSp.Width = 150;
            // 
            // Slco
            // 
            this.Slco.DataPropertyName = "Slco";
            this.Slco.HeaderText = "Số lượng có";
            this.Slco.MinimumWidth = 8;
            this.Slco.Name = "Slco";
            this.Slco.Width = 150;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Đơn giá";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            this.Gia.Width = 150;
            // 
            // MaLoaiSP
            // 
            this.MaLoaiSP.DataPropertyName = "MaLoaiSP";
            this.MaLoaiSP.HeaderText = "Loại sản phẩm";
            this.MaLoaiSP.MinimumWidth = 8;
            this.MaLoaiSP.Name = "MaLoaiSP";
            this.MaLoaiSP.Width = 150;
            // 
            // QLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 789);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QLySanPham";
            this.Text = "QLySanPham";
            this.Load += new System.EventHandler(this.QLySanPham_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiemTheoTen;
        private System.Windows.Forms.Button btnTimKiemTheoMa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuongCo;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}