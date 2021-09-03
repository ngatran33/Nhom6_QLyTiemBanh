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
    public partial class TrangChu : Form
    {
        public static String tt;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            ManChinh fm = new ManChinh();
            AddForm(fm);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chán muốn thoát.", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chán muốn thoát.", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan fm = new TaiKhoan();
            AddForm(fm);
        }
        private void AddForm(Form f)
        {
            panelTrangChu.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelTrangChu.Controls.Add(f);
            f.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            QLySanPham fm = new QLySanPham();
            AddForm(fm);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap fm = new NhaCungCap();
            AddForm(fm);
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            QlyKhachHang fm = new QlyKhachHang();
            AddForm(fm);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            QLyHoaDon fm = new QLyHoaDon();
            AddForm(fm);
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan fm = new TaiKhoan();
            AddForm(fm);
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            QLySanPham fm = new QLySanPham();
            AddForm(fm);
        }

        private void mnuNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap fm = new NhaCungCap();
            AddForm(fm);
        }

        private void mnuKH_Click(object sender, EventArgs e)
        {
            QlyKhachHang fm = new QlyKhachHang();
            AddForm(fm);
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            QLyHoaDon fm = new QLyHoaDon();
            AddForm(fm);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ManChinh fm = new ManChinh();
            AddForm(fm);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chán muốn đăng xuất.", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap fm = new DangNhap();
                fm.ShowDialog();
                this.Close();
            }
        }

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            ManChinh fm = new ManChinh();
            AddForm(fm);
        }
    }
}
