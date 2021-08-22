﻿using System;
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
    public partial class QLySanPham : Form
    {
        DBProccessing.DBProccessingSanPham data = new DBProccessing.DBProccessingSanPham();
        public QLySanPham()
        {
            InitializeComponent();
        }

        private void QLySanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = data.ShowSanPham();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = data.ShowSanPham();
        }

        private void ClearTextBox()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoLuongCo.Clear();
            txtDonGia.Clear();
            ActiveControl = txtMaSP;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaSP.Text = dgvSanPham.Rows[row].Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[row].Cells[1].Value.ToString();
                txtSoLuongCo.Text = dgvSanPham.Rows[row].Cells[2].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSP.Text == "")
                {
                    MessageBox.Show("Tên sản phẩm không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.Parse(txtSoLuongCo.Text) < 0)
                {
                    MessageBox.Show("Số lượng có không được âm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (double.Parse(txtDonGia.Text) <= 0)
                {
                    MessageBox.Show("Đơn giá không được âm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                data.ThemSanPham(txtTenSP.Text, int.Parse(txtSoLuongCo.Text), double.Parse(txtDonGia.Text));
                QLySanPham_Load(sender, e);
                ClearTextBox();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nhập dữ liệu sai định dạng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key"))
                    MessageBox.Show("Trùng mã sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSP.Text == "")
                {
                    MessageBox.Show("Tên sản phẩm không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.Parse(txtSoLuongCo.Text) < 0)
                {
                    MessageBox.Show("Số lượng có không được âm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (double.Parse(txtDonGia.Text) <= 0)
                {
                    MessageBox.Show("Đơn giá không được âm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                data.SuaTaiKhoan(int.Parse(txtMaSP.Text), txtTenSP.Text, int.Parse(txtSoLuongCo.Text), double.Parse(txtDonGia.Text));
                QLySanPham_Load(sender, e);
                ClearTextBox();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nhập dữ liệu sai định dạng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                data.XoaSanPham(int.Parse(txtMaSP.Text));
                QLySanPham_Load(sender, e);
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
