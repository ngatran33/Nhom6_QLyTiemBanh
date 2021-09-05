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
    public partial class DangNhap : Form
    {
        DBProccessingDangNhap obj = new DBProccessingDangNhap();
        public DangNhap()
        {
            InitializeComponent();
        }
        //đăng nhập
        private void dkbtnDangNhap_Click(object sender, EventArgs e)
        {
            if(dnTxtMatKhau.Text.Length==0 || dnTxtTenDn.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống tên đăng nhập và tài khoản.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(obj.checkTaiKhoan(dnTxtTenDn.Text, dnTxtMatKhau.Text)){
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TrangChu.tt = obj.getMaTk(dnTxtTenDn.Text, dnTxtMatKhau.Text);

                    TrangChu fm = new TrangChu();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       
        
        //xóa trắng
        private void btnReset_Click(object sender, EventArgs e)
        {
            dnTxtMatKhau.Clear();
            dnTxtTenDn.Clear();
            dnTxtTenDn.Focus();
        }

        // thoát
        private void lblThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chán muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
