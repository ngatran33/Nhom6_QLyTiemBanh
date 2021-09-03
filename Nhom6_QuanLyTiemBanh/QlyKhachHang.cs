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
    public partial class QlyKhachHang : Form
    {
        int row = -1;
        DBProccessing.DBProccessingKhachHang data = new DBProccessing.DBProccessingKhachHang();
        public QlyKhachHang()
        {
            InitializeComponent();
        }

        private void QlyKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = data.ShowKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Họ tên khách hàng không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Địa chỉ không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSoDT.Text == "")
                {
                    MessageBox.Show("Số điện thoại không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (data.checkSDT(txtSoDT.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                data.ThemKhachHang(txtHoTen.Text, txtDiaChi.Text, txtSoDT.Text);
                QlyKhachHang_Load(sender, e);
                ClearTextBox();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập dữ liệu sai định dạng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key"))
                    MessageBox.Show("Trùng mã khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBox()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            ActiveControl = txtHoTen;
            txtMaKH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (row != -1)
            {
                try
                {

                    if (txtHoTen.Text == "")
                    {
                        MessageBox.Show("Họ tên khách hàng không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtDiaChi.Text == "")
                    {
                        MessageBox.Show("Địa chỉ khách hàng không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtSoDT.Text == "")
                    {
                        MessageBox.Show("Số điện thoại khách hàng không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (data.checkSDT(txtSoDT.Text, int.Parse(txtMaKH.Text)))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    data.SuaKhachHang(int.Parse(txtMaKH.Text), txtHoTen.Text, txtDiaChi.Text, txtSoDT.Text);
                    QlyKhachHang_Load(sender, e);
                    ClearTextBox();
                    row = -1;
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập dữ liệu sai định dạng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtMaKH.Text = dgvKhachHang.Rows[row].Cells[0].Value.ToString();
                txtHoTen.Text = dgvKhachHang.Rows[row].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[row].Cells[2].Value.ToString();
                txtSoDT.Text = dgvKhachHang.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (row != -1)
            {
                try
                {
                    if (txtMaKH.Text == null)
                    {
                        MessageBox.Show("Chọn khách hàng cần xoá!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        data.XoaKhachHang(int.Parse(txtMaKH.Text));
                        QlyKhachHang_Load(sender, e);
                        ClearTextBox();
                        row = -1;
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("FK_HoaDon_KhachHang"))
                    {
                        MessageBox.Show("Không thể xóa khách hàng đã có đơn hàng mua", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == null)
                {
                    MessageBox.Show("Nhập họ tên khách hàng vào ô tìm kiếm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvKhachHang.DataSource = data.TimKiemTheoHoTen(txtTimKiem.Text);
                if (data.checkTenKH(txtTimKiem.Text))
                {
                    txtTimKiem.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy họ tên khách hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = data.ShowKhachHang();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
