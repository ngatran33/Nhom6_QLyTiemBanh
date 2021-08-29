using Nhom6_QuanLyTiemBanh.DBProccessing;
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
    public partial class HoaDonBan : Form
    {
        int index = -1;
        DBProccessingHoaDonBan obj = new DBProccessingHoaDonBan();
        public HoaDonBan()
        {
            InitializeComponent();
        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            cbbKH.DataSource = obj.getKhachHang();
            cbbKH.DisplayMember = "TenKH";
            cbbKH.ValueMember = "MaKH";
            cbbSP.DataSource = obj.getSanPham();
            cbbSP.DisplayMember = "TenSP";
            cbbSP.ValueMember = "MaSP";

        }

        private void cbbSP_textchanged(object sender, EventArgs e)
        {
            try
            {
                txtDG.Text = obj.getGia(int.Parse(cbbSP.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                txtDG.Text = "0";
            }
        }

        private void sl_textchanged(object sender, EventArgs e)
        {
            try
            {
                int sl = int.Parse(txtSL.Text);
                double gia = double.Parse(txtDG.Text);
                txtThanhTien.Text = (sl * gia) + "";
            }
            catch (Exception ex)
            {
                txtThanhTien.Text = "NaN";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSL.Text.Equals(""))
                {
                    MessageBox.Show("Nhập đủ dữ liệu vào", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (UInt32.Parse(txtSL.Text) == 0)
                {
                    MessageBox.Show("Hãy nhập số lượng lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (UInt32.Parse(txtSL.Text) > obj.getSlCo(int.Parse(cbbSP.SelectedValue.ToString())))
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
                    if (dgvSP.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvSP.Rows)
                        {
                            if (masp.Equals(row.Cells[0].Value.ToString()))
                            {
                                MessageBox.Show("Mặt hàng này đã có", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    dgvSP.Rows.Add(masp, tensp, sl, donG, thanhTien);
                    cleartxt();
                }
                if (dgvSP.Rows.Count > 0)
                {
                    Double tong = 0;
                    foreach (DataGridViewRow row in dgvSP.Rows)
                    {
                        tong += double.Parse(row.Cells[4].Value.ToString());
                    }
                    lblTongTien.Text = tong + ".000 VND";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng và đơn giá phải là số nguyên lơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cleartxt()
        {
            txtSL.Clear();
            txtDG.Text = "0";
            txtThanhTien.Text = "NaN";
        }

        private void dgv_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            cbbSP.SelectedValue = dgvSP.Rows[index].Cells[0].Value.ToString();
            txtSL.Text = dgvSP.Rows[index].Cells[2].Value.ToString();
            txtDG.Text = dgvSP.Rows[index].Cells[3].Value.ToString();
            txtThanhTien.Text = dgvSP.Rows[index].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng " + (index + 1), "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvSP.Rows.RemoveAt(index);
                    cleartxt();
                }
                index = -1;
            }
            else
            {
                MessageBox.Show("Chọn dòng để xóa ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kiểm trả thông tin", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {//int masp, int sl, int tong
                    obj.insertHD(int.Parse(cbbKH.SelectedValue.ToString()), dtpNgayLap.Value);
                    txtMaHD.Text = obj.getMaHDMoiThem() + "";
                    if (dgvSP.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvSP.Rows)
                        {
                            int masp = int.Parse(row.Cells[0].Value.ToString());
                            int sl = int.Parse(row.Cells[2].Value.ToString());
                            int thanhtien = int.Parse(row.Cells[4].Value.ToString());
                            obj.insertCTHD(masp, sl, thanhtien);
                            obj.updateSLco(masp, sl);
                        }
                        MessageBox.Show("Lập hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSP.Rows.Clear();
                        lblTongTien.Text = "0";
                        ChiTietHoaDonBan.mahd = obj.getMaHDMoiThem();
                        ChiTietHoaDonBan fm = new ChiTietHoaDonBan();
                        fm.Show();
                        txtMaHD.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Hay chọn hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dg_textchange(object sender, EventArgs e)
        {
            try
            {
                int sl = int.Parse(txtSL.Text);
                double gia = double.Parse(txtDG.Text);
                txtThanhTien.Text = (sl * gia) + "";
            }
            catch (Exception ex)
            {
                txtThanhTien.Text = "NaN";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn hủy hóa đơn", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvSP.Rows.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSP.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSP.Rows)
                {
                    if (cbbSP.SelectedValue.ToString().Equals(row.Cells[0].Value.ToString()))
                    {
                        row.Cells[2].Value = txtSL.Text;
                        cleartxt();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
