namespace Nhom6_QuanLyTiemBanh
{
    partial class DanhSachHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimPhieu = new System.Windows.Forms.TextBox();
            this.txttimMA = new System.Windows.Forms.TextBox();
            this.btnXemCTHD = new System.Windows.Forms.Button();
            this.btnXemCTHDN = new System.Windows.Forms.Button();
            this.btnxoaHD = new System.Windows.Forms.Button();
            this.btnXoaHDN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.dgvHoaDOn = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sopn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDOn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 663);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn đã lập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTimPhieu);
            this.panel2.Controls.Add(this.txttimMA);
            this.panel2.Controls.Add(this.btnXemCTHD);
            this.panel2.Controls.Add(this.btnXemCTHDN);
            this.panel2.Controls.Add(this.btnxoaHD);
            this.panel2.Controls.Add(this.btnXoaHDN);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvHDN);
            this.panel2.Controls.Add(this.dgvHoaDOn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 563);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tìm Theo số phiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tìm Theo Mã ";
            // 
            // txtTimPhieu
            // 
            this.txtTimPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimPhieu.Location = new System.Drawing.Point(709, 506);
            this.txtTimPhieu.Name = "txtTimPhieu";
            this.txtTimPhieu.Size = new System.Drawing.Size(284, 27);
            this.txtTimPhieu.TabIndex = 7;
            // 
            // txttimMA
            // 
            this.txttimMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimMA.Location = new System.Drawing.Point(709, 454);
            this.txttimMA.Name = "txttimMA";
            this.txttimMA.Size = new System.Drawing.Size(284, 27);
            this.txttimMA.TabIndex = 7;
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCTHD.Location = new System.Drawing.Point(227, 506);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(232, 41);
            this.btnXemCTHD.TabIndex = 6;
            this.btnXemCTHD.Text = "Xem Chi Tiết Hóa Đơn Bán";
            this.btnXemCTHD.UseVisualStyleBackColor = true;
            // 
            // btnXemCTHDN
            // 
            this.btnXemCTHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCTHDN.Location = new System.Drawing.Point(227, 451);
            this.btnXemCTHDN.Name = "btnXemCTHDN";
            this.btnXemCTHDN.Size = new System.Drawing.Size(229, 41);
            this.btnXemCTHDN.TabIndex = 5;
            this.btnXemCTHDN.Text = "Xem Chi Tiết Hóa Đơn Nhập";
            this.btnXemCTHDN.UseVisualStyleBackColor = true;
            this.btnXemCTHDN.Click += new System.EventHandler(this.btnXemCTHDN_Click);
            // 
            // btnxoaHD
            // 
            this.btnxoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaHD.Location = new System.Drawing.Point(23, 506);
            this.btnxoaHD.Name = "btnxoaHD";
            this.btnxoaHD.Size = new System.Drawing.Size(179, 41);
            this.btnxoaHD.TabIndex = 4;
            this.btnxoaHD.Text = "Xóa Đơn Bán";
            this.btnxoaHD.UseVisualStyleBackColor = true;
            this.btnxoaHD.Click += new System.EventHandler(this.btnxoaHD_Click);
            // 
            // btnXoaHDN
            // 
            this.btnXoaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHDN.Location = new System.Drawing.Point(23, 451);
            this.btnXoaHDN.Name = "btnXoaHDN";
            this.btnXoaHDN.Size = new System.Drawing.Size(179, 41);
            this.btnXoaHDN.TabIndex = 3;
            this.btnXoaHDN.Text = "Xóa Đơn Nhập";
            this.btnXoaHDN.UseVisualStyleBackColor = true;
            this.btnXoaHDN.Click += new System.EventHandler(this.btnXoaHDN_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách hóa đơn nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh sách hóa đơn bán";
            // 
            // dgvHDN
            // 
            this.dgvHDN.AllowUserToAddRows = false;
            this.dgvHDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sopn,
            this.MaNCC,
            this.MaTk,
            this.NgayNhap});
            this.dgvHDN.Location = new System.Drawing.Point(524, 54);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.RowTemplate.Height = 24;
            this.dgvHDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDN.Size = new System.Drawing.Size(469, 381);
            this.dgvHDN.TabIndex = 1;
            this.dgvHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDN_cellclick);
            // 
            // dgvHoaDOn
            // 
            this.dgvHoaDOn.AllowUserToAddRows = false;
            this.dgvHoaDOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDOn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.NgayLap});
            this.dgvHoaDOn.Location = new System.Drawing.Point(0, 54);
            this.dgvHoaDOn.Name = "dgvHoaDOn";
            this.dgvHoaDOn.RowTemplate.Height = 24;
            this.dgvHoaDOn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDOn.Size = new System.Drawing.Size(456, 381);
            this.dgvHoaDOn.TabIndex = 0;
            this.dgvHoaDOn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hd_cellclick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.Name = "MaHD";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKh";
            this.MaKH.HeaderText = "Mã Khach";
            this.MaKH.Name = "MaKH";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // sopn
            // 
            this.sopn.DataPropertyName = "SoPN";
            this.sopn.HeaderText = "Số phiếu";
            this.sopn.Name = "sopn";
            this.sopn.Width = 70;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 70;
            // 
            // MaTk
            // 
            this.MaTk.DataPropertyName = "MaTk";
            this.MaTk.HeaderText = "Mã TK";
            this.MaTk.Name = "MaTk";
            this.MaTk.Width = 70;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // DanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 663);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DanhSachHoaDon";
            this.Text = "DanhSachHoaDoncs";
            this.Load += new System.EventHandler(this.DanhSachHoaDon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDOn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.DataGridView dgvHoaDOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimPhieu;
        private System.Windows.Forms.TextBox txttimMA;
        private System.Windows.Forms.Button btnXemCTHD;
        private System.Windows.Forms.Button btnXemCTHDN;
        private System.Windows.Forms.Button btnxoaHD;
        private System.Windows.Forms.Button btnXoaHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn sopn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTk;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
    }
}