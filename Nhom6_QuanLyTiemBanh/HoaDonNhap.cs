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
    public partial class HoaDonNhap : Form
    {
        DBProccessingHoaDonNhap obj = new DBProccessingHoaDonNhap();
        int index = -1;
        public HoaDonNhap()
        {
            InitializeComponent();
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            cbbNCC.DataSource = obj.getNCC();
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";
            DataTable table = obj.getNV();
            txtNhanVien.Text = table.Rows[0][4].ToString();
            cbbSP.DataSource = obj.getSanPham();
            cbbSP.DisplayMember = "TenSP";
            cbbSP.ValueMember = "MaSP";
           
        }

        private void btnThemSp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSL.Text.Equals("") || txtDG.Text.Equals(""))
                {
                    MessageBox.Show("Nhập đủ dữ liệu vào", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (UInt32.Parse(txtSL.Text) == 0)
                {
                    MessageBox.Show("Hãy nhập số lượng lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (UInt32.Parse(txtDG.Text) == 0)
                {
                    MessageBox.Show("Hãy nhập đơn giá lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String masp = cbbSP.SelectedValue.ToString();
                    String tensp = cbbSP.Text;
                    String sl = txtSL.Text;
                    String donG = txtDG.Text;
                    String thanhTien = txtThanhTien.Text;
                    if (dgvDsachSP.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvDsachSP.Rows)
                        {
                            if (masp.Equals(row.Cells[0].Value.ToString()))
                            {
                                MessageBox.Show("Mặt hàng này đã có", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    dgvDsachSP.Rows.Add(masp, tensp, sl, donG, thanhTien);
                    cleartxt();
                }
                if (dgvDsachSP.Rows.Count > 0)
                {
                    int tong = 0;
                    foreach (DataGridViewRow row in dgvDsachSP.Rows)
                    {
                        tong += int.Parse(row.Cells[4].Value.ToString());
                    }
                    lblTongTien.Text = tong + "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Số lượng và đơn giá phải là số nguyên lơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cleartxt()
        {
            txtDG.Clear();
            txtSL.Clear();
            txtThanhTien.Clear();
        }

        private void sl_textchanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = ""+(UInt32.Parse(txtSL.Text) * UInt32.Parse(txtDG.Text));
            }
            catch
            {
                txtThanhTien.Text = "";
            }
        }

        private void donGia_textChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = "" + (UInt32.Parse(txtSL.Text) * UInt32.Parse(txtDG.Text));
            }
            catch
            {
                txtThanhTien.Text = "";
            }
        }

        private void dgvSP_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            cbbSP.SelectedValue = dgvDsachSP.Rows[index].Cells[0].Value.ToString();
            txtSL.Text = dgvDsachSP.Rows[index].Cells[2].Value.ToString();
            txtDG.Text = dgvDsachSP.Rows[index].Cells[3].Value.ToString();
            txtThanhTien.Text =dgvDsachSP.Rows[index].Cells[4].Value.ToString();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                if(MessageBox.Show("Bạn chắc chắn muốn xóa dòng "+ index, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvDsachSP.Rows.RemoveAt(index);
                    index = -1;
                    cleartxt();
                }
            }
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kiểm trả thông tin", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {//(int sp, int masp, int sl, int gia, int tong)
                    obj.insertHDN(int.Parse(cbbNCC.SelectedValue.ToString()), int.Parse(TrangChu.tt), dtpNgayLap.Value);
                    txtSPN.Text = obj.getspn();
                    if (dgvDsachSP.Rows.Count > 0)
                    {
                        foreach(DataGridViewRow row in dgvDsachSP.Rows)
                        {
                            int sopn =int.Parse(txtSPN.Text);
                            int masp =int.Parse(row.Cells[0].Value.ToString());
                            int sl =int.Parse(row.Cells[2].Value.ToString());
                            int dg =int.Parse(row.Cells[3].Value.ToString());
                            int thanhtien =int.Parse(row.Cells[4].Value.ToString());
                            obj.insertctHDN(sopn, masp, sl, dg, thanhtien);
                            obj.upDateSl(masp, sl);
                        }
                        MessageBox.Show("Lập hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDsachSP.Rows.Clear();
                        lblTongTien.Text = "0";
                        ChiTietHoaDonNhap.sopn = int.Parse(txtSPN.Text);
                        ChiTietHoaDonNhap fm = new ChiTietHoaDonNhap();
                        fm.Show();
                        txtSPN.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Hay chọn hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn hủy hóa đơn nhập", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvDsachSP.Rows.Clear();
            }
        }
    }
}
