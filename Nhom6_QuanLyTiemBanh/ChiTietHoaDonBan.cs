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
    public partial class ChiTietHoaDonBan : Form
    {
        public static int mahd = -1;
        DBProccessingCTBan obj = new DBProccessingCTBan();
        public ChiTietHoaDonBan()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            if (mahd != -1)
            {
                dgvDsachHang.DataSource = obj.getSp(mahd);
                DataTable table = obj.getHD(mahd);
                txtMaHD.Text = table.Rows[0][0].ToString();
                txtNgayLap.Text = table.Rows[0][2].ToString();
                DataTable table1 = obj.getKH(int.Parse(table.Rows[0][1].ToString()));
                txtTenKH.Text = table1.Rows[0][1].ToString();
                txtDC.Text = table1.Rows[0][2].ToString();
                txtSDT.Text = table1.Rows[0][3].ToString();
            }
            if (dgvDsachHang.Rows.Count > 0)
            {
                int t = 0;
                foreach(DataGridViewRow row in dgvDsachHang.Rows)
                {
                    t+=int.Parse(row.Cells[4].ToString());
                }
                lblTongTien.Text = t + ".000 VND";
            }

        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            mahd = -1;
        }
    }
}
