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
        DBProccessing.DBProccessingNhaCungCap data = new DBProccessing.DBProccessingNhaCungCap();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = data.ShowNhaCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNCC.Text == "")
                {
                    MessageBox.Show("Tên khách hàng không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Địa chỉ không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSoDT.Text == "")
                {
                    MessageBox.Show("Số điện thoại không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                data.ThemNhaCC(txtTenNCC.Text, txtDiaChi.Text, txtSoDT.Text);
                ClearTextBox();
                NhaCungCap_Load(sender, e);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nhập dữ liệu sai định dạng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            ActiveControl = txtTenNCC;
        }
    }
}
