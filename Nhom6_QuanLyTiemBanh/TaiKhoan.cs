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
    public partial class TaiKhoan : Form
    {
        DBProccessing.DBProccessingTaiKhoan data = new DBProccessing.DBProccessingTaiKhoan();
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = data.ShowTaiKhoan();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = data.ShowTaiKhoan();
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

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaTaiKhoan.Text = dgvTaiKhoan.Rows[row].Cells[0].Value.ToString();
                txtTenDangNhap.Text = dgvTaiKhoan.Rows[row].Cells[1].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[row].Cells[2].Value.ToString();
                if (dgvTaiKhoan.Rows[row].Cells[3].Value.Equals(true))
                    ckbTinhTrang.Checked = true;
                else
                    ckbTinhTrang.Checked = false;
                txtHoTen.Text = dgvTaiKhoan.Rows[row].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvTaiKhoan.Rows[row].Cells[5].Value.ToString();
                txtSoDienThoai.Text = dgvTaiKhoan.Rows[row].Cells[6].Value.ToString();
                if (dgvTaiKhoan.Rows[row].Cells[7].Value.ToString().Equals("Nam"))
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTaiKhoan.Text == "")
                {
                    MessageBox.Show("Mã tài khoản không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

                data.ThemTaiKhoan(txtMaTaiKhoan.Text, txtTenDangNhap.Text, txtMatKhau.Text, ckbTinhTrang.Checked ? true : false, txtHoTen.Text,  txtDiaChi.Text, txtSoDienThoai.Text, gt);
                TaiKhoan_Load(sender, e);
                ClearTextBox();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nhập dữ liệu sai định dạng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key"))
                    MessageBox.Show("Trùng mã tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
