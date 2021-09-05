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
    public partial class HoaDonBan : Form
    {
        int index = -1;
        DBProccessingHoaDonBan obj = new DBProccessingHoaDonBan();
        public HoaDonBan()
        {
            InitializeComponent();
        }

        //load csdl
        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            cbbKH.DataSource = obj.getKhachHang();
            cbbKH.DisplayMember = "TenKH";
            cbbKH.ValueMember = "MaKH";
            cbbSP.DataSource = obj.getSanPham();
            cbbSP.DisplayMember = "TenSP";
            cbbSP.ValueMember = "MaSP";

        }

        //lấy đơn giá
        private void cbbSP_textchanged(object sender, EventArgs e)
        {
            try
            {
                txtDG.Text = obj.getGia(int.Parse(cbbSP.SelectedValue.ToString()))+ "";
            }
            catch (Exception ex)
            {
                txtDG.Text = "0";
            }
        }

        //tính thành tiền
        private void sl_textchanged(object sender, EventArgs e)
        {
            try
            {
                int sl = int.Parse(txtSL.Text);
                double gia = double.Parse(txtDG.Text);
                txtThanhTien.Text = (sl * gia) + "";
            }
            catch (Exception ex)
            {
                txtThanhTien.Text = "NaN";
            }
        }

        //thêm sp vao bảng
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!obj.checkTenSP(cbbSP.Text))
            {
                MessageBox.Show("Sản Phẩm không tồn tại!", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //check dl đầu vào
                if (txtSL.Text.Equals(""))
                {
                    MessageBox.Show("Nhập đủ dữ liệu vào!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (UInt32.Parse(txtSL.Text) == 0)
                {
                    MessageBox.Show("Hãy nhập số lượng lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Double.Parse(txtDG.Text) <= 0)
                {
                    MessageBox.Show("Đơn giá lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (UInt32.Parse(txtSL.Text) > obj.getSlCo(int.Parse(cbbSP.SelectedValue.ToString())))
                {
                    MessageBox.Show("Số lượng không đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {//thêm dl vào bảng
                    String masp = cbbSP.SelectedValue.ToString();
                    String tensp = cbbSP.Text;
                    String sl = txtSL.Text;
                    String donG = txtDG.Text;
                    String thanhTien = txtThanhTien.Text;
                    if (dgvSP.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvSP.Rows)
                        {
                            if (masp.Equals(row.Cells[0].Value.ToString()))
                            {
                                MessageBox.Show("Mặt hàng này đã có!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    dgvSP.Rows.Add(masp, tensp, sl, donG, thanhTien);
                    cleartxt();
                }
                tinhtong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng phải là số nguyên lơn 0, đơn giá phải là số thực lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //tinh tong tien cua hd
        private void tinhtong()
        {
            if (dgvSP.Rows.Count > 0)
            {
                Double tong = 0;
                foreach (DataGridViewRow row in dgvSP.Rows)
                {
                    tong += double.Parse(row.Cells[4].Value.ToString());
                }
                lblTongTien.Text = tong + " VND";
            }
        }

        //xóa trắng
        private void cleartxt()
        {
            txtSL.Clear();
            txtDG.Text = "0";
            txtThanhTien.Text = "NaN";
        }

        //hiển thi dl lên text
        private void dgv_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            cbbSP.SelectedValue = dgvSP.Rows[index].Cells[0].Value.ToString();
            txtSL.Text = dgvSP.Rows[index].Cells[2].Value.ToString();
            txtDG.Text = dgvSP.Rows[index].Cells[3].Value.ToString();
            txtThanhTien.Text = dgvSP.Rows[index].Cells[4].Value.ToString();
        }

        //xóa sp khỏi bảng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSP.Rows.Count > 0)
            {
                if (index != -1)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng " + (index + 1)+ "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                        == DialogResult.Yes)
                    {
                        dgvSP.Rows.RemoveAt(index);
                        tinhtong();
                        cleartxt();
                    }
                    index = -1;
                }
                else
                {
                    MessageBox.Show("Chọn dòng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Danh sách trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //lập hóa đơn - thêm vào csdl
        private void btnLap_Click(object sender, EventArgs e)
        {
            if (!obj.checkTenKH(cbbKH.Text))
            {
                MessageBox.Show("Khách hàng không tồn tại. Tạo mới khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Vui lòng kiểm tra kỹ các thông tin trước khi lập hóa đơn!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //thêm hóa đơn
                    obj.insertHD(int.Parse(cbbKH.SelectedValue.ToString()), String.Format("{0:yyyy/MM/dd}", dtpNgayLap.Value));
                    txtMaHD.Text = obj.getMaHDMoiThem() + "";
                    if (dgvSP.Rows.Count > 0)
                    {
                        //thêm chi tiet hoa don
                        foreach (DataGridViewRow row in dgvSP.Rows)
                        {
                            int masp = int.Parse(row.Cells[0].Value.ToString());
                            int sl = int.Parse(row.Cells[2].Value.ToString());
                            double thanhtien = double.Parse(row.Cells[4].Value.ToString());
                            obj.insertCTHD(masp, sl, thanhtien);
                            obj.updateSLco(masp, sl);
                        }
                        MessageBox.Show("Lập hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSP.Rows.Clear();
                        lblTongTien.Text = "0";

                        //chuyen màn
                        ChiTietHoaDonBan.mahd = obj.getMaHDMoiThem();
                        ChiTietHoaDonBan fm = new ChiTietHoaDonBan();
                        fm.Show();
                        txtMaHD.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //tính thành tiền
        private void dg_textchange(object sender, EventArgs e)
        {
            try
            {
                int sl = int.Parse(txtSL.Text);
                double gia = double.Parse(txtDG.Text);
                txtThanhTien.Text = (sl * gia) + "";
            }
            catch (Exception ex)
            {
                txtThanhTien.Text = "NaN";
            }
        }

        //hủy hóa đơn
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn hủy hóa đơn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvSP.Rows.Clear();
                lblTongTien.Text = "0 VND";
                cleartxt();
            }
        }

        //sửa sản phẩm
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSP.Rows.Count > 0)
            {
                if (index != -1)
                {
                    if (!obj.checkTenSP(cbbSP.Text))
                    {
                        MessageBox.Show("Sản Phẩm không tồn tại!", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
                    {
                        //kiểm tra dl nhập vào
                        if (txtSL.Text.Equals(""))
                        {
                            MessageBox.Show("Nhập đủ dữ liệu vào!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (UInt32.Parse(txtSL.Text) == 0)
                        {
                            MessageBox.Show("Hãy nhập số lượng lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (Double.Parse(txtDG.Text) <= 0)
                        {
                            MessageBox.Show("Đơn giá lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (UInt32.Parse(txtSL.Text) > obj.getSlCo(int.Parse(cbbSP.SelectedValue.ToString())))
                        {
                            MessageBox.Show("Số lượng không đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {// cập nhật lại dl
                            foreach (DataGridViewRow row in dgvSP.Rows)
                            {
                                if (cbbSP.SelectedValue.ToString().Equals(row.Cells[0].Value.ToString()))
                                {
                                    row.Cells[2].Value = txtSL.Text;
                                    row.Cells[4].Value = txtThanhTien.Text;
                                    tinhtong();
                                    cleartxt();
                                    index = -1;
                                    return;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Số lượng phải là số nguyên lơn 0, đơn giá phải là số thực lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
                else
                {
                    MessageBox.Show("Bạn cần chọn dòng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Danh sách trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //chuyển màn
        private void btnhdban_Click(object sender, EventArgs e)
        {
            QlyKhachHang f = new QlyKhachHang();
            f.Show();
        }

        //load lại kh sau khi thêm
        private void click(object sender, EventArgs e)
        {
            HoaDonBan_Load(sender, e);
        }
    }
}
