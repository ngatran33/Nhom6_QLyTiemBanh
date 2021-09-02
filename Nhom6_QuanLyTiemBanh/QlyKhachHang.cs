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

                data.ThemKhachHang(txtHoTen.Text, txtDiaChi.Text, txtSoDT.Text);
                ClearTextBox();
                QlyKhachHang_Load(sender, e);
            }
            catch (FormatException)
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
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            ActiveControl = txtHoTen;
        }

    }
}
