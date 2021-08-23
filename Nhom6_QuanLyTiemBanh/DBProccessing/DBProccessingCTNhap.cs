using Nhom6_QuanLyTiemBanh.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingCTNhap
    {
        DBConnectionQly dbConn = new DBConnectionQly();
        public DataTable getHDN(int sopn)
        {
            string sql = "SELECT * FROM HoaDonNhap WHERE SoPN= " + sopn;
            DataTable table =dbConn.GetTable(sql);
            return table;
        }
        public DataTable getNCC(int MaNcc)
        {
            String sql = "SELECT * FROM NhaCungCap WHERE MaNCC=" + MaNcc;
            DataTable table = dbConn.GetTable(sql);
            return table;
        }
        public DataTable getNV(int matk)
        {
            String sql = "SELECT * FROM TaiKhoan WHERE MaTK=" + matk;
            DataTable table = dbConn.GetTable(sql);
            return table;
        }
        public DataTable getSP(int sopn)
        {
            String sql = "SELECT s.MaSP, TenSP, GiaNhap, SoLuongNhap, TongTienNhap" +
                " FROM HoaDonNhap h inner join SanPham s On s.MaSP=h.MaSP" +
                " WHERE SoPN=" + sopn;
            DataTable table = dbConn.GetTable(sql);
            return table;
        }
    }
}
