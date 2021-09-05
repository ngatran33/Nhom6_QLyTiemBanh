using iTextSharp.text;
using iTextSharp.text.pdf;
using Nhom6_QuanLyTiemBanh.DBProccessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        //load
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

        //close
        private void form_close(object sender, FormClosedEventArgs e)
        {
            mahd = -1;
        }

        //xuat
        private void btnxuat_Click(object sender, EventArgs e)
        {
            if (mahd != -1)
            {
                string filename = "HDB" + lblMaHD.Text;
                var saveFile = new SaveFileDialog();
                saveFile.FileName = filename;
                saveFile.DefaultExt = ".pdf";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {

                    //set up de them dl
                    Document document = new Document(PageSize.A4, 10f, 20f, 20f, 20f);
                    try
                    {
                        Stream stream = new FileStream(saveFile.FileName, FileMode.Create);
                        PdfWriter.GetInstance(document, stream);
                        document.Open();

                        //dl cua hoa don
                        PdfPTable table = new PdfPTable(2);
                        float[] columnsWidth = { 1, 1 };
                        table.SetWidths(columnsWidth);
                        table.DefaultCell.BorderWidth = 0;
                        table.DefaultCell.Padding = 20;
                        table.WidthPercentage = 100;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;

                        // font chữ
                        string path = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources") + @"\font.ttf";
                        BaseFont baseFont = BaseFont.CreateFont(path, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);


                        iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL);
                        iTextSharp.text.Font fontHearder = new iTextSharp.text.Font(baseFont, 20, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font fontBold = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD);

                        //tiêu đề
                        PdfPCell pdfPCell2 = new PdfPCell(new Phrase("HÓA ĐƠN XUẤT", fontHearder));
                        pdfPCell2.Colspan = 2;
                        pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPCell2.PaddingBottom = 20;
                        table.AddCell(pdfPCell2);

                        //tieu de
                        PdfPCell pCell1 = new PdfPCell(new Phrase("Thông tin khách hàng", font));
                        pCell1.Colspan = 1;
                        pCell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pCell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        pCell1.PaddingTop = 5;
                        pCell1.PaddingLeft = 20;
                        table.AddCell(pCell1);

                        //tieu de
                        PdfPCell pCell2 = new PdfPCell(new Phrase("Thông tin hóa đơn", font));
                        pCell2.Colspan = 1;
                        pCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pCell2.HorizontalAlignment = Element.ALIGN_LEFT;
                        pCell2.PaddingTop = 5;
                        pCell2.PaddingLeft = 20;
                        table.AddCell(pCell2);


                        //tên kh:
                        PdfPCell pdfPCell3 = new PdfPCell(new Phrase("Tên KH: " + lblTenKH.Text, font));
                        pdfPCell3.Colspan = 1;
                        pdfPCell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell3.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell3.PaddingTop = 5;
                        pdfPCell3.PaddingLeft = 20;
                        table.AddCell(pdfPCell3);

                        //mã hóa đơn:
                        PdfPCell pdfPCell4 = new PdfPCell(new Phrase("Mã HD: " + lblMaHD.Text, font));
                        pdfPCell4.Colspan = 1;
                        pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell4.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell4.PaddingTop = 5;
                        pdfPCell4.PaddingLeft = 20;
                        table.AddCell(pdfPCell4);

                        //sdt:
                        PdfPCell pdfPCell5 = new PdfPCell(new Phrase("SDT: " + lblSDT.Text, font));
                        pdfPCell5.Colspan = 1;
                        pdfPCell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell5.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell5.PaddingTop = 5;
                        pdfPCell5.PaddingLeft = 20;
                        table.AddCell(pdfPCell5);

                        //ngay lap:
                        PdfPCell pdfPCell6 = new PdfPCell(new Phrase("Ngày Lập:  " + lblNgayLap.Text, font));
                        pdfPCell6.Colspan = 1;
                        pdfPCell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell6.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell6.PaddingTop = 5;
                        pdfPCell6.PaddingLeft = 20;
                        table.AddCell(pdfPCell6);

                        //địa chỉ
                        PdfPCell pdfPCell7 = new PdfPCell(new Phrase("Địa chỉ:  " + lblDC.Text, font));
                        pdfPCell7.Colspan = 2;
                        pdfPCell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell7.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell7.PaddingTop = 5;
                        pdfPCell7.PaddingLeft = 20;
                        table.AddCell(pdfPCell7);

                        //danh sách
                        PdfPCell pdfPCell8 = new PdfPCell(new Phrase("Danh sách hàng: ", font));
                        pdfPCell8.Colspan = 2;
                        pdfPCell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell8.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell8.PaddingTop = 5;
                        pdfPCell8.PaddingLeft = 20;
                        pdfPCell8.PaddingBottom = 20;
                        table.AddCell(pdfPCell8);


                        //bảng sản phẩm
                        PdfPTable tableHang = new PdfPTable(dgvDsachHang.ColumnCount);
                        float[] columnsWidth1 = { 1, 2, 1.5f, 1, 1.5f };
                        tableHang.SetWidths(columnsWidth1);
                        tableHang.DefaultCell.BorderWidth = 1;
                        tableHang.WidthPercentage = 100;
                        tableHang.HorizontalAlignment = Element.ALIGN_CENTER;


                        //tiêu đề cột
                        foreach (DataGridViewColumn column in dgvDsachHang.Columns)
                        {
                            PdfPCell pdf = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                            pdf.HorizontalAlignment = Element.ALIGN_CENTER;
                            pdf.PaddingBottom = 2;
                            tableHang.AddCell(pdf);
                        }

                        //thêm dl cho bảng
                        foreach (DataGridViewRow row in dgvDsachHang.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                                pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                pCell.PaddingBottom = 2;
                                tableHang.AddCell(pCell);
                            }
                        }

                        //tổng tiền:
                        Paragraph element1 = new Paragraph("\n\nTổng tiền: " + lblTongTien.Text, font);


                        //add dl vào document
                        document.Add(table);
                        document.Add(tableHang);
                        document.Add(element1);

                        //đóng kết nối
                        document.Close();
                        stream.Close();
                        MessageBox.Show("In hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //mở file
                        try
                        {
                            System.Diagnostics.Process.Start("explorer.exe", saveFile.FileName); // XML NHẬP
                        }
                        catch (Exception)
                        {
                            System.Diagnostics.Process.Start("msedge.exe", saveFile.FileName);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        document.Close();
                    }
                }
            }
            
        }

        //thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn chắc chán muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
