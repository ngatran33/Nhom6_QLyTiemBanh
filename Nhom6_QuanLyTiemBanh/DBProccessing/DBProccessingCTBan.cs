using Nhom6_QuanLyTiemBanh.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingCTBan
    {
        DBConnectionQly dbConn = new DBConnectionQly();
        public DataTable getHD(int maHD)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaHD= "+ maHD;
            return dbConn.GetTable(sql);
        }
        public DataTable getKH(int maKh)
        {
            String sql = "SELECT * FROM KhachHang WHERE MaKH=" + maKh;
            return dbConn.GetTable(sql);
        }
        public DataTable getSp(int MaHD)
        {
            string sql = " SELECT s.MaSP, TenSP, Gia, Slco, TongTien" +
                " FROM ChiTietHoaDon h INNER JOIN SanPham s ON h.MaSP= s.MaSP" +
                " WHERE MaHD= " + MaHD;
            return dbConn.GetTable(sql);
        }
    }
}
