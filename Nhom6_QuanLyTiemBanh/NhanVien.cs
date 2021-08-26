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
    public partial class NhanVien : Form
    {
        DBProccessing.DBProccessingTaiKhoan data = new DBProccessing.DBProccessingTaiKhoan();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = data.ShowNhanVien();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = data.ShowNhanVien();
        }

        private void ClearTextBox()
        {
            txtMaTaiKhoan.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            ActiveControl = txtMaTaiKhoan;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaTaiKhoan.Text = dgvNhanVien.Rows[row].Cells[0].Value.ToString();
                txtTenDangNhap.Text = dgvNhanVien.Rows[row].Cells[1].Value.ToString();
                txtMatKhau.Text = dgvNhanVien.Rows[row].Cells[2].Value.ToString();
                if (dgvNhanVien.Rows[row].Cells[3].Value.Equals(true))
                    ckbTinhTrang.Checked = true;
                else
                    ckbTinhTrang.Checked = false;
                txtHoTen.Text = dgvNhanVien.Rows[row].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[row].Cells[5].Value.ToString();
                txtSoDienThoai.Text = dgvNhanVien.Rows[row].Cells[6].Value.ToString();
                if (dgvNhanVien.Rows[row].Cells[7].Value.ToString().Equals("Nam"))
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Họ tên không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                String gt;
                if (rdbNam.Checked)
                    gt = "Nam";
                else
                    gt = "Nữ";

                data.ThemTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text, ckbTinhTrang.Checked ? true : false, txtHoTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, gt);
                NhanVien_Load(sender, e);
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaTaiKhoan.Text != "")
                {
                    if (txtTenDangNhap.Text == "")
                    {
                        MessageBox.Show("Tên đăng nhập không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtMatKhau.Text == "")
                    {
                        MessageBox.Show("Mật khẩu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtHoTen.Text == "")
                    {
                        MessageBox.Show("Họ tên không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    String gt;
                    if (rdbNam.Checked)
                        gt = "Nam";
                    else
                        gt = "Nữ";

                    data.SuaTaiKhoan(int.Parse(txtMaTaiKhoan.Text), txtTenDangNhap.Text, txtMatKhau.Text, ckbTinhTrang.Checked ? true : false, txtHoTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, gt);
                    NhanVien_Load(sender, e);
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Chọn nhân viên cần cập nhật", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if(txtMaTaiKhoan.Text != "")
                {
                    data.XoaTaiKhoan(int.Parse(txtMaTaiKhoan.Text));
                    NhanVien_Load(sender, e);
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Chọn nhân viên cần xoá", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemTheoMa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    MessageBox.Show("Nhập mã tài khoản cần tìm vào ô tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvNhanVien.DataSource = data.TimKiemTheoMaTK(int.Parse(txtTimKiem.Text));
                if (data.checkMaTaiKhoanNhanVien(int.Parse(txtTimKiem.Text)))
                {                 
                    txtTimKiem.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã tài khoản của nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (txtTimKiem.Text == "")
                {
                    MessageBox.Show("Nhập họ tên cần tìm vào ô tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvNhanVien.DataSource = data.TimKiemTheoHoTen(txtTimKiem.Text);
                if (data.checkHoTenNhanVien(txtTimKiem.Text))
                {
                    txtTimKiem.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy họ tên của nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
