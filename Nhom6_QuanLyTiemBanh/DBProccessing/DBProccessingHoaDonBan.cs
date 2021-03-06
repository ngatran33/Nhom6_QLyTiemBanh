using Nhom6_QuanLyTiemBanh.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingHoaDonBan
    {
        DBConnectionQly dbConn = new DBConnectionQly();
        public DataTable getKhachHang()
        {
            String sql = "SELECT * FROM KhachHang";
            return dbConn.GetTable(sql);
        }
        public DataTable getSanPham()
        {
            String sql = "SELECT * FROM SanPham";
            return dbConn.GetTable(sql);
        }
        public String getGia(int masp)
        {
            String sql = "SELECT Gia FROM SanPham WHERE MaSP=" + masp;
            DataTable table = dbConn.GetTable(sql);
            return table.Rows[0][0].ToString();
        }
        public int getSlCo(int masp)
        {
            String sql = "SELECT SlCo FROM SanPham WHERE MaSP=" + masp;
            DataTable table = dbConn.GetTable(sql);
            return int.Parse(table.Rows[0][0].ToString());
        }
        public void insertHD(int maKh, String nl)
        {
            string sql = "INSERT INTO HoaDon VALUES(" + maKh + ",'" + nl + "')";
            dbConn.ExecuteNonQuery(sql);
        }
        public int getMaHDMoiThem()
        {
            String sql = "SELECT * FROM HoaDon ORDER BY MaHD DESC";
            DataTable table = dbConn.GetTable(sql);
            return int.Parse(table.Rows[0][0].ToString());
        }
        public void insertCTHD(int masp, int sl, double tong)
        {
            string sql = "INSERT INTO ChiTietHoaDon VALUES( " + getMaHDMoiThem() + "," + masp + "," + sl + "," + tong + ")";
            dbConn.ExecuteNonQuery(sql);
        }
        public void updateSLco(int sl, int masp)
        {
            String sql="UPDATE SanPham Set Slco= Slco-"+sl+ " WHERE MaSP=" + masp;
            dbConn.ExecuteNonQuery(sql);
        }
        public bool checkTenKH(string ten)
        {
            string sql = "SELECT * FROM KhachHang WHERE TenKH = N'" + ten + "'";
            DataTable table= dbConn.GetTable(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkTenSP(string tenSP)
        {
            string sql = "SELECT * FROM SanPham WHERE TenSP = N'" + tenSP + "'";
            DataTable table = dbConn.GetTable(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
