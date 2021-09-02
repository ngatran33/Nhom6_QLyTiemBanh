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
            string sql = "SELECT * FROM TaiKhoan where MaTk= "+ int.Parse(TrangChu.tt);
            DataTable table = dbConn.GetTable(sql);
            return table;
        }
      
        public DataTable getSanPham()
        {
            String sql = "SELECT * FROM SanPham";
            DataTable table = dbConn.GetTable(sql);
            return table;
        }
        public void insertHDN(int mancc, int maTk, DateTime ngay)
        {
            String sql="INSERT INTO HoaDonNhap VALUES (" + mancc + ", " + maTk + ", '" + ngay + "')";
            dbConn.ExecuteNonQuery(sql);
        }

        public void insertctHDN(int sp, int masp, int sl, double gia, double tong)
        {
            String sql = "INSERT INTO ChiTietHoaDonNhap VALUES (" + sp + ", " + masp+ ", " + sl + ", " + gia + ", " + tong + ")";
            dbConn.ExecuteNonQuery(sql);
        }

        public string getspn()
        {
            string sql = "SELECT * FROM HoaDonNhap ORDER BY SoPN DESC";
            DataTable table = dbConn.GetTable(sql);
            return table.Rows[0][0].ToString();
        }
        public void upDateSl(int masp, int sl)
        {
            string sql = "UPDATE SanPHam Set Slco=SLco+ " + sl + " WHERE MaSP=" + masp;
            dbConn.ExecuteNonQuery(sql);
        }
        public bool checkTenNCC(string ten)
        {
            String sql = "Select * from NhaCungCap where TenNcc= N'" + ten + "'";
            DataTable table = dbConn.GetTable(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkTenSP(string ten)
        {
            String sql = "Select * from SanPham where TenSP= N'" + ten + "'";
            DataTable table = dbConn.GetTable(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
