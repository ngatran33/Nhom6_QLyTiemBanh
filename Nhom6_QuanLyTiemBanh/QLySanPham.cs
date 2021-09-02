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
            cbbLoaiSP.DataSource = data.ShowLoaiSanPham();
            cbbLoaiSP.DisplayMember = "TenLoaiSP";
            cbbLoaiSP.ValueMember = "MaLoaiSP";

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = data.ShowSanPham();
            cbbLoaiSP.DataSource = data.ShowLoaiSanPham();
            cbbLoaiSP.DisplayMember = "TenLoaiSP";
            cbbLoaiSP.ValueMember = "MaLoaiSP";
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
                cbbLoaiSP.SelectedValue = dgvSanPham.Rows[row].Cells[4].Value.ToString();
                dtpHSD.Text= dgvSanPham.Rows[row].Cells[6].Value.ToString();
                dtpNgaySX.Text= dgvSanPham.Rows[row].Cells[5].Value.ToString();
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
                if(dtpHSD.Value< dtpNgaySX.Value)
                {
                    MessageBox.Show("Kiểm tra ngày sản xuất và hạn sử dụng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                data.ThemSanPham(txtTenSP.Text, int.Parse(txtSoLuongCo.Text), double.Parse(txtDonGia.Text), int.Parse(cbbLoaiSP.SelectedValue.ToString()), dtpNgaySX.Value, dtpHSD.Value);
                QLySanPham_Load(sender, e);
                ClearTextBox();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text != "")
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
                    if (dtpHSD.Value < dtpNgaySX.Value)
                    {
                        MessageBox.Show("Kiểm tra ngày sản xuất và hạn sử dụng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    data.SuaTaiKhoan(int.Parse(txtMaSP.Text), txtTenSP.Text, int.Parse(txtSoLuongCo.Text), double.Parse(txtDonGia.Text), int.Parse(cbbLoaiSP.SelectedValue.ToString()), dtpNgaySX.Value, dtpHSD.Value);
                    QLySanPham_Load(sender, e);
                    ClearTextBox();
                    MessageBox.Show("Cập Nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chọn sản phẩm cần cập nhật", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                if (txtMaSP.Text == "")
                {
                    MessageBox.Show("Chọn sản phẩm cần xoá", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                }
                else
                {
                    data.XoaSanPham(int.Parse(txtMaSP.Text));
                    QLySanPham_Load(sender, e);
                    ClearTextBox();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemTheoMa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTimKiem.Text == null)
                {
                    MessageBox.Show("Nhập mã sản phẩm cần tìm vào ô tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvSanPham.DataSource = data.TimKiemTheoMaSP(int.Parse(txtTimKiem.Text));
                if (data.checkMaSP(int.Parse(txtTimKiem.Text)))
                {      
                    txtTimKiem.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemTheoTen_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == null)
                {
                    MessageBox.Show("Nhập tên sản phẩm cần tìm vào ô tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvSanPham.DataSource = data.TimKiemTheoTenSP(txtTimKiem.Text);
                if (data.checkTenSP(txtTimKiem.Text))
                {
                    txtTimKiem.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
