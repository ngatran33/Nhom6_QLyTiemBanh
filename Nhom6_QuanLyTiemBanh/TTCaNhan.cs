using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Nhom6_QuanLyTiemBanh
{
    public partial class TTCaNhan : Form
    {
        DBProccessing.DBProccessingTaiKhoan data = new DBProccessing.DBProccessingTaiKhoan();
        public DataTable table;
        public TTCaNhan()
        {
            InitializeComponent();
        }

        private void TTCaNhan_Load(object sender, EventArgs e)
        {
            table = data.getThongTinCaNhan(int.Parse(TrangChu.tt));
            txtMaTaiKhoan.Text = table.Rows[0].ItemArray[0].ToString();
            txtTenDangNhap.Text = table.Rows[0].ItemArray[1].ToString();
            txtMatKhau.Text = table.Rows[0].ItemArray[2].ToString();
            if (table.Rows[0].ItemArray[3].Equals(true))
                ckbTinhTrang.Checked = true;
            else
                ckbTinhTrang.Checked = false;
            txtHoTen.Text = table.Rows[0].ItemArray[4].ToString();
            txtDiaChi.Text = table.Rows[0].ItemArray[5].ToString();
            txtSoDienThoai.Text = table.Rows[0].ItemArray[6].ToString();
            if (table.Rows[0].ItemArray[7].ToString().Equals("Nam"))
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            table = data.getThongTinCaNhan(int.Parse(TrangChu.tt));
            txtMaTaiKhoan.Text = table.Rows[0].ItemArray[0].ToString();
            txtTenDangNhap.Text = table.Rows[0].ItemArray[1].ToString();
            txtMatKhau.Text = table.Rows[0].ItemArray[2].ToString();
            if (table.Rows[0].ItemArray[3].Equals(true))
                ckbTinhTrang.Checked = true;
            else
                ckbTinhTrang.Checked = false;
            txtHoTen.Text = table.Rows[0].ItemArray[4].ToString();
            txtDiaChi.Text = table.Rows[0].ItemArray[5].ToString();
            txtSoDienThoai.Text = table.Rows[0].ItemArray[6].ToString();
            if (table.Rows[0].ItemArray[7].ToString().Equals("Nam"))
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
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

                data.SuaTaiKhoan(int.Parse(txtMaTaiKhoan.Text), txtTenDangNhap.Text, txtMatKhau.Text, 
                    ckbTinhTrang.Checked ? true : false, txtHoTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, gt);
                TTCaNhan_Load(sender, e);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
