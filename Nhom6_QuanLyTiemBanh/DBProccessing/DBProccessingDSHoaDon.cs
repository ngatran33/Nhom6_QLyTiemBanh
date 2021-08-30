using Nhom6_QuanLyTiemBanh.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingDSHoaDon
    {
        DBConnectionQly dbConn = new DBConnectionQly();
        public DataTable getHDN()
        {
            string sql = "SELECT * FROM HoaDonNhap";
            return dbConn.GetTable(sql);
        }
        public DataTable getHD()
        {
            string sql = "SELECT * FROM HoaDon";
            return dbConn.GetTable(sql);
        }
        public void deleteHDN(int sopn)
        {
            String sql = "Delete from HoaDonNhap where SoPN=" + sopn;
            dbConn.ExecuteNonQuery(sql);
        }
        public bool checkSoPN(int sopn)
        {
            string sql = "SELECT * FROM ChiTietHoaDonNhap WHERE SoPN=" + sopn;
            DataTable table = dbConn.GetTable(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void deleteHD(int mahd)
        {
            string sql = "Delete from HoaDon where MaHD= " + mahd;
            dbConn.ExecuteNonQuery(sql);
        }
        public bool checkMaHD(int mahd)
        {
            string sql = "SELECT * FROM  ChiTietHoaDon WHERE MaHD=" + mahd;
            DataTable table = dbConn.GetTable(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable getTimKiem(int mahd)
        {
            String sql = "Select * from HoaDon WHERE MaHD= " + mahd;
            return dbConn.GetTable(sql);
        }
        public DataTable getTimKiemHDN(int sp)
        {
            String sql = "Select * from HoaDonNhap WHERE SoPN= " + sp;
            return dbConn.GetTable(sql);
        }
    }
}
