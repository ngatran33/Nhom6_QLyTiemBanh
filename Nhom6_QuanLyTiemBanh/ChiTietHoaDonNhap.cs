﻿using Nhom6_QuanLyTiemBanh.DBProccessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom6_QuanLyTiemBanh
{
    public partial class ChiTietHoaDonNhap : Form
    {
        public static int sopn=-1;
        DBProccessingCTNhap obj = new DBProccessingCTNhap();
        public ChiTietHoaDonNhap()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            if (sopn != -1)
            {
                dgvDsachHang.DataSource = obj.getSP(sopn);

            }
        }

        private void form_close(object sender, FormClosingEventArgs e)
        {
            sopn = -1;
        }
    }
}
