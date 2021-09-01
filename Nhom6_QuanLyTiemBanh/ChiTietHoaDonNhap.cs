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
    public partial class ChiTietHoaDonNhap : Form
    {
        public static int sopn=-1;
        DBProccessingCTNhap obj = new DBProccessingCTNhap();
        public ChiTietHoaDonNhap()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            if (sopn != -1)
            {
                dgvDsachHang.DataSource = obj.getSP(sopn);
                DataTable table = obj.getHDN(sopn);
                lblSoPN.Text = sopn+"";
                lblNgayLap.Text = table.Rows[0][3].ToString();
                int mancc = int.Parse(table.Rows[0][1].ToString());
                int matk = int.Parse(table.Rows[0][2].ToString());
                DataTable table1 = obj.getNCC(mancc);
                lblTenNcc.Text = table1.Rows[0][1].ToString();
                lblDCNCC.Text = table1.Rows[0][2].ToString();
                lblSDTNcc.Text = table1.Rows[0][3].ToString();
                DataTable table2 = obj.getNV(matk);
                lblHotenNv.Text = table2.Rows[0][4].ToString();
                lblSdtNv.Text = table2.Rows[0][6].ToString();
                lblDcNv.Text = table2.Rows[0][5].ToString();
                if (dgvDsachHang.Rows.Count > 0)
                {
                    double tong = 0;
                    foreach (DataGridViewRow row in dgvDsachHang.Rows)
                    {
                        tong += double.Parse(row.Cells[4].Value.ToString());
                    }
                    lblTongTien.Text = tong + ".0000 VND";
                }
            }
        }

        private void form_close(object sender, FormClosingEventArgs e)
        {
            sopn = -1;
        }
    }
}
