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
    public partial class QLyHoaDon : Form
    {
        public QLyHoaDon()
        {
            InitializeComponent();
        }
        private void AddForm(Form f)
        {
            pnlHD.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlHD.Controls.Add(f);
            f.Show();
        }

        private void mnuHDN_Click(object sender, EventArgs e)
        {
            HoaDonNhap fm = new HoaDonNhap();
            AddForm(fm);
        }

        private void mnuHDB_Click(object sender, EventArgs e)
        {
            HoaDonBan fm = new HoaDonBan();
            AddForm(fm);
        }

        private void QLyHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonNhap fm = new HoaDonNhap();
            AddForm(fm);
        }
    }
}
