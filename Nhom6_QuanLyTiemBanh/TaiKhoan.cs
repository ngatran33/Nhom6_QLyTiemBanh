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
        private void AddForm(Form f)
        {
            panelTaiKhoan.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelTaiKhoan.Controls.Add(f);
            f.Show();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            TTCaNhan fm = new TTCaNhan();
            AddForm(fm);
        }

        

        private void ThongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTCaNhan fm = new TTCaNhan();
            AddForm(fm);
        }

        private void QuanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (data.checkMaTaiKhoanNhanVien(int.Parse(TrangChu.tt)))
            {
                MessageBox.Show("Chức năng quản lý nhân viên của Admin. Vui lòng chọn chức năng khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NhanVien fm = new NhanVien();
                AddForm(fm);
            }
        }
    }
}
