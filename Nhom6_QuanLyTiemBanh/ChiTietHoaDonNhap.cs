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
    public partial class ChiTietHoaDonNhap : Form
    {
        public static int sopn=-1;
        DBProccessingCTNhap obj = new DBProccessingCTNhap();
        public ChiTietHoaDonNhap()
        {
            InitializeComponent();
        }

        //load
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
                    lblTongTien.Text = tong + " VND";
                }
            }
        }

        //close
        private void form_close(object sender, FormClosingEventArgs e)
        {
            sopn = -1;
        }

        //thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chán muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        //xuat file
        private void btn_xuat_Click(object sender, EventArgs e)
        {
            if (sopn != -1)
            {
                string filename = "HDN" + lblSoPN.Text;
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
                        PdfPCell pdfPCell2 = new PdfPCell(new Phrase("HÓA ĐƠN NHẬP", fontHearder));
                        pdfPCell2.Colspan = 2;
                        pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPCell2.PaddingBottom = 20;
                        table.AddCell(pdfPCell2);

                        //số phiếu
                        PdfPCell pCell1 = new PdfPCell(new Phrase("Số PN: "+ lblSoPN.Text, font));
                        pCell1.Colspan = 2;
                        pCell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pCell1.HorizontalAlignment = Element.ALIGN_CENTER;
                        pCell1.PaddingBottom = 10;
                        table.AddCell(pCell1);


                        //ngày lập
                        PdfPCell pCell2 = new PdfPCell(new Phrase("Ngày Lập: " + lblNgayLap.Text, font));
                        pCell2.Colspan = 2;
                        pCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                        pCell2.PaddingBottom = 10;
                        table.AddCell(pCell2);

                        //Thong tin
                        PdfPCell pdfPCell3 = new PdfPCell(new Phrase("Thông tin nhà cung cấp", font));
                        pdfPCell3.Colspan = 1;
                        pdfPCell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell3.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell3.PaddingTop = 5;
                        pdfPCell3.PaddingLeft = 20;
                        table.AddCell(pdfPCell3);

                        //thông tin
                        PdfPCell pdfPCell4 = new PdfPCell(new Phrase("Thông tin nhân viên", font));
                        pdfPCell4.Colspan = 1;
                        pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell4.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell4.PaddingTop = 5;
                        pdfPCell4.PaddingLeft = 20;
                        table.AddCell(pdfPCell4);

                        //tên ncc
                        PdfPCell pdfPCell5 = new PdfPCell(new Phrase("Tên NCC: " + lblTenNcc.Text, font));
                        pdfPCell5.Colspan = 1;
                        pdfPCell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell5.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell5.PaddingTop = 5;
                        pdfPCell5.PaddingLeft = 20;
                        table.AddCell(pdfPCell5);

                        //tên nv
                        PdfPCell pdfPCell6 = new PdfPCell(new Phrase("Tên NV:  " + lblHotenNv.Text, font));
                        pdfPCell6.Colspan = 1;
                        pdfPCell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell6.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell6.PaddingTop = 5;
                        pdfPCell6.PaddingLeft = 20;
                        table.AddCell(pdfPCell6);

                        //sdt ncc
                        PdfPCell pdfPCell7 = new PdfPCell(new Phrase("SĐT:  " + lblSDTNcc.Text, font));
                        pdfPCell7.Colspan = 1;
                        pdfPCell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell7.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell7.PaddingTop = 5;
                        pdfPCell7.PaddingLeft = 20;
                        table.AddCell(pdfPCell7);

                        //sdt nv
                        PdfPCell pdfPCell8 = new PdfPCell(new Phrase("SĐT:  " + lblSdtNv.Text, font));
                        pdfPCell8.Colspan = 1;
                        pdfPCell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell8.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell8.PaddingTop = 5;
                        pdfPCell8.PaddingLeft = 20;
                        table.AddCell(pdfPCell8);

                        //dia chi ncc
                        PdfPCell pdfPCell9 = new PdfPCell(new Phrase("Địa chỉ:  " + lblDCNCC.Text, font));
                        pdfPCell9.Colspan = 1;
                        pdfPCell9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell9.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell9.PaddingTop = 5;
                        pdfPCell9.PaddingLeft = 20;
                        table.AddCell(pdfPCell9);


                        //địa chỉ nhân viên
                        PdfPCell pdfPCell1 = new PdfPCell(new Phrase("Địa chỉ:  " + lblDcNv.Text, font));
                        pdfPCell1.Colspan = 1;
                        pdfPCell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pdfPCell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPCell1.PaddingTop = 5;
                        pdfPCell1.PaddingLeft = 20;
                        table.AddCell(pdfPCell1);


                        //danh sách
                        PdfPCell pCell3 = new PdfPCell(new Phrase("Danh sách hàng: ", font));
                        pCell3.Colspan = 2;
                        pCell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pCell3.HorizontalAlignment = Element.ALIGN_LEFT;
                        pCell3.PaddingTop = 20;
                        pCell3.PaddingLeft = 20;
                        pCell3.PaddingBottom = 10;
                        table.AddCell(pCell3);


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
    }
}
