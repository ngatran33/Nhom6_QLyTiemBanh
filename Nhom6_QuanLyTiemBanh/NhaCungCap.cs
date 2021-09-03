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
    public partial class NhaCungCap : Form
    {
        int row = -1;
        DBProccessing.DBProccessingNhaCungCap data = new DBProccessing.DBProccessingNhaCungCap();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = data.ShowNhaCungCap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNCC.Text == "")
                {
                    MessageBox.Show("Tên nhà cung cấp không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                data.ThemNhaCungCap(txtTenNCC.Text, txtDiaChi.Text, txtSoDT.Text);
                NhaCungCap_Load(sender, e);
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
                    MessageBox.Show("Trùng mã nhà cung cấp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBox()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            ActiveControl = txtTenNCC;
            txtMaNCC.Enabled = false;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = data.ShowNhaCungCap();
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtMaNCC.Text = dgvNhaCC.Rows[row].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNhaCC.Rows[row].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhaCC.Rows[row].Cells[2].Value.ToString();
                txtSoDT.Text = dgvNhaCC.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (row != -1)
            {
                try
                {

                    if (txtTenNCC.Text == "")
                    {
                        MessageBox.Show("Tên nhà cung cấp không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtDiaChi.Text == "")
                    {
                        MessageBox.Show("Địa chỉ nhà cung cấp không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtSoDT.Text == "")
                    {
                        MessageBox.Show("Số điện thoại nhà cung cấp khách hàng không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (data.checkSDT(txtSoDT.Text, int.Parse(txtMaNCC.Text)))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    data.SuaNhaCungCap(int.Parse(txtMaNCC.Text), txtTenNCC.Text, txtDiaChi.Text, txtSoDT.Text);
                    NhaCungCap_Load(sender, e);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (row != -1)
            {
                try
                {
                    if (txtMaNCC.Text == null)
                    {
                        MessageBox.Show("Chọn khách hàng cần xoá!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        data.XoaNhaCungCap(int.Parse(txtMaNCC.Text));
                        NhaCungCap_Load(sender, e);
                        ClearTextBox();
                        row = -1;
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
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
                    MessageBox.Show("Nhập tên nhà cung cấp vào ô tìm kiếm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvNhaCC.DataSource = data.TimKiemTheoTen(txtTimKiem.Text);
                if (data.checkNhaCungCap(txtTimKiem.Text))
                {
                    txtTimKiem.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên nhà cung cấp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
