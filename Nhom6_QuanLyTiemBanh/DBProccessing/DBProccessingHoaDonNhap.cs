using Nhom6_QuanLyTiemBanh.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingHoaDonNhap
    {
        DBConnectionQly dbConn = new DBConnectionQly();
        public DataTable getNCC()
        {
            string sql = "SELECT * FROM NhaCungCap";
            DataTable table = dbConn.GetTable(sql);
            return table;
        }
        public DataTable getNV()
        {
            string sql = "SELECT * FROM TaiKhoan";
            DataTable table = dbConn.GetTable(sql);
            return table;
        }

        public DataTable getSanPham()
        {
            String sql = "SELECT * FROM SanPham";
            DataTable table = dbConn.GetTable(sql);
            return table;
        }
    }
}
