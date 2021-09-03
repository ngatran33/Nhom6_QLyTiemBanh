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
                lblMaHD.Text = table.Rows[0][0].ToString();
                lblNgayLap.Text = table.Rows[0][2].ToString();
                DataTable table1 = obj.getKH(int.Parse(table.Rows[0][1].ToString()));
                lblTenKH.Text = table1.Rows[0][1].ToString();
                lblDC.Text = table1.Rows[0][2].ToString();
                lblSDT.Text = table1.Rows[0][3].ToString();
            }
            if (dgvDsachHang.Rows.Count > 0)
            {
                double t = 0;
                foreach (DataGridViewRow row in dgvDsachHang.Rows)
                {
                    t += double.Parse(row.Cells[4].Value.ToString());
                }
                lblTongTien.Text = t + " VND";
            }

        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            mahd = -1;
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            string filename = "HDB" + lblMaHD;
            var saveFile = new SaveFileDialog();
            saveFile.FileName = filename;
            saveFile.DefaultExt = ".pdf";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //set up de them dl
            }
        }
    }
}
