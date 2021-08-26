namespace Nhom6_QuanLyTiemBanh
{
    partial class NhanVien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi_nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT_nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemTheoTen = new System.Windows.Forms.Button();
            this.btnTimKiemTheoMa = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.ckbTinhTrang = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvNhanVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1310, 826);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTK,
            this.TenDangNhap,
            this.MatKhau,
            this.TinhTrang,
            this.HoTen,
            this.DiaChi_nv,
            this.SoDT_nv,
            this.GioiTinh});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 498);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(1304, 325);
            this.dgvNhanVien.TabIndex = 2;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // MaTK
            // 
            this.MaTK.DataPropertyName = "MaTk";
            this.MaTK.HeaderText = "Mã tài khoản";
            this.MaTK.MinimumWidth = 8;
            this.MaTK.Name = "MaTK";
            this.MaTK.Width = 150;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.MinimumWidth = 8;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 150;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 8;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TinhTrang.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // DiaChi_nv
            // 
            this.DiaChi_nv.DataPropertyName = "DiaChi_nv";
            this.DiaChi_nv.HeaderText = "Địa chỉ";
            this.DiaChi_nv.MinimumWidth = 8;
            this.DiaChi_nv.Name = "DiaChi_nv";
            this.DiaChi_nv.Width = 150;
            // 
            // SoDT_nv
            // 
            this.SoDT_nv.DataPropertyName = "SoDT_nv";
            this.SoDT_nv.HeaderText = "Số điện thoại";
            this.SoDT_nv.MinimumWidth = 8;
            this.SoDT_nv.Name = "SoDT_nv";
            this.SoDT_nv.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 489);
            this.panel1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(952, 37);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 30);
            this.txtTimKiem.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(805, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nhập tìm kiếm:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnTimKiemTheoTen);
            this.groupBox2.Controls.Add(this.btnTimKiemTheoMa);
            this.groupBox2.Controls.Add(this.btnHienThi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(735, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 398);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn";
            // 
            // btnTimKiemTheoTen
            // 
            this.btnTimKiemTheoTen.Location = new System.Drawing.Point(299, 194);
            this.btnTimKiemTheoTen.Name = "btnTimKiemTheoTen";
            this.btnTimKiemTheoTen.Size = new System.Drawing.Size(231, 42);
            this.btnTimKiemTheoTen.TabIndex = 12;
            this.btnTimKiemTheoTen.Text = "Tìm kiếm theo họ tên";
            this.btnTimKiemTheoTen.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoTen.Click += new System.EventHandler(this.btnTimKiemTheoTen_Click);
            // 
            // btnTimKiemTheoMa
            // 
            this.btnTimKiemTheoMa.Location = new System.Drawing.Point(24, 194);
            this.btnTimKiemTheoMa.Name = "btnTimKiemTheoMa";
            this.btnTimKiemTheoMa.Size = new System.Drawing.Size(229, 42);
            this.btnTimKiemTheoMa.TabIndex = 11;
            this.btnTimKiemTheoMa.Text = "Tìm kiếm theo mã";
            this.btnTimKiemTheoMa.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoMa.Click += new System.EventHandler(this.btnTimKiemTheoMa_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(24, 38);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(229, 40);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(299, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(231, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(24, 116);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(229, 40);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(299, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(231, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.txtMaTaiKhoan);
            this.groupBox1.Controls.Add(this.ckbTinhTrang);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 398);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(199, 280);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(309, 30);
            this.txtSoDienThoai.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(199, 239);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(309, 30);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(199, 198);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(309, 30);
            this.txtHoTen.TabIndex = 12;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(199, 117);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(309, 30);
            this.txtMatKhau.TabIndex = 11;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(199, 76);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(309, 30);
            this.txtTenDangNhap.TabIndex = 10;
            // 
            // txtMaTaiKhoan
            // 
            this.txtMaTaiKhoan.Enabled = false;
            this.txtMaTaiKhoan.Location = new System.Drawing.Point(199, 35);
            this.txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            this.txtMaTaiKhoan.Size = new System.Drawing.Size(309, 30);
            this.txtMaTaiKhoan.TabIndex = 9;
            // 
            // ckbTinhTrang
            // 
            this.ckbTinhTrang.AutoSize = true;
            this.ckbTinhTrang.Checked = true;
            this.ckbTinhTrang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbTinhTrang.Location = new System.Drawing.Point(199, 158);
            this.ckbTinhTrang.Name = "ckbTinhTrang";
            this.ckbTinhTrang.Size = new System.Drawing.Size(126, 29);
            this.ckbTinhTrang.TabIndex = 8;
            this.ckbTinhTrang.Text = "Nhân viên";
            this.ckbTinhTrang.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbNu);
            this.groupBox3.Controls.Add(this.rdbNam);
            this.groupBox3.Location = new System.Drawing.Point(34, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 55);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giới tính";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(285, 14);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(62, 29);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(102, 14);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(78, 29);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tài khoản";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 826);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMaTaiKhoan;
        private System.Windows.Forms.CheckBox ckbTinhTrang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiemTheoMa;
        private System.Windows.Forms.Button btnTimKiemTheoTen;
    }
}