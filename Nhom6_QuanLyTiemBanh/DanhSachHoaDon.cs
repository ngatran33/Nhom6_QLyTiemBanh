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
    public partial class DanhSachHoaDon : Form
    {
        DBProccessingDSHoaDon obj=new DBProccessingDSHoaDon();
        int dgv_hdn_row = -1;
        int dgv_hd_row = -1;
        public DanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            dgvHDN.DataSource = obj.getHDN();
            dgvHoaDOn.DataSource = obj.getHD();
        }

        private void btnXoaHDN_Click(object sender, EventArgs e)
        {
            if (dgv_hdn_row != -1)
            {
                int sopn = int.Parse(dgvHDN.Rows[dgv_hdn_row].Cells[0].Value.ToString());
                if (obj.checkSoPN(sopn))
                {
                    MessageBox.Show("Không thể xóa hóa đơn nhâp có SoPN là: " + sopn, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn xóa hóa đơn nhâp có SoPN là: " + sopn, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        obj.deleteHDN(sopn);
                        DanhSachHoaDon_Load(sender, e);
                        dgv_hdn_row = -1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn hóa đơn nhập muốn xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_HDN_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_hdn_row = e.RowIndex;
            
        }

        private void btnXemCTHDN_Click(object sender, EventArgs e)
        {
            if (dgv_hdn_row != -1)
            {
                ChiTietHoaDonNhap fm = new ChiTietHoaDonNhap();
                ChiTietHoaDonNhap.sopn = int.Parse(dgvHDN.Rows[dgv_hdn_row].Cells[0].Value.ToString());
                fm.Show();
                dgv_hdn_row = -1;
            }
            else
            {
                MessageBox.Show("Bạn cần chọn hóa đơn nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_hd_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_hd_row = e.RowIndex;
        }

        private void btnxoaHD_Click(object sender, EventArgs e)
        {
            if (dgv_hd_row != -1)
            {
                int mahd =int.Parse( dgvHoaDOn.Rows[dgv_hd_row].Cells[0].Value.ToString());
                if (obj.checkMaHD(mahd))
                {
                    MessageBox.Show("Không thể xóa hóa đơn bán có MaHD là: " + mahd, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn xóa hóa đơn bán có MaHD là: " + mahd, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        obj.deleteHD(mahd);
                        DanhSachHoaDon_Load(sender, e);
                        dgv_hd_row = -1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn hóa đơn bán muốn xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            if (dgv_hd_row != -1)
            {
                ChiTietHoaDonBan fm = new ChiTietHoaDonBan();
                ChiTietHoaDonBan.mahd = int.Parse(dgvHoaDOn.Rows[dgv_hd_row].Cells[0].Value.ToString());
                fm.Show();
                dgv_hd_row = -1;
            }
        }
    }
}
