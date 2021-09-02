using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingSanPham
    {
        DBConnection.DBConnectionQly dataConn = new DBConnection.DBConnectionQly();

        public DataTable ShowSanPham()
        {
            String sql = "Select * from SanPham";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public DataTable ShowLoaiSanPham()
        {
            String sql = "Select * from LoaiSanPham";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public void ThemSanPham(String tenSP, int soLuongCo, double gia, int maLoaiSP, DateTime sx, DateTime hsd)
        {
            String sql = "Insert into SanPham Values (N'" + tenSP + "', " + soLuongCo + ", " + gia + ", " + maLoaiSP +",'"+sx+"','"+ hsd+ "')";
            dataConn.ExecuteNonQuery(sql);
        }

        public void SuaTaiKhoan(int maSP, String tenSP, int soLuongCo, double gia, int maLoaiSP, DateTime sx, DateTime hsd)
        {
            String sql = "Update SanPham Set TenSp=N'" + tenSP + "', Slco=" + soLuongCo + ", Gia=" + gia + ", MaLoaiSP=" + maLoaiSP + ", NgaySX='"+sx+"', HSD='"+hsd+ "' where MaSP=" + maSP + "";
            dataConn.ExecuteNonQuery(sql);
        }

        public void XoaSanPham(int maSP)
        {
            String sql = "Delete SanPham where MaSP=" + maSP + "";
            dataConn.ExecuteNonQuery(sql);
        }

        public DataTable TimKiemTheoMaSP(int maSP)
        {
            String sql = "Select * from SanPham where MaSP=" + maSP + "";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public DataTable TimKiemTheoTenSP(String tenSP)
        {
            String sql = "Select * from SanPham where tenSP=N'" + tenSP + "'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public bool checkMaSP(int maSP)
        {
            String sql = "Select * from SanPham where MaSP=" + maSP + "";
            DataTable table = dataConn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool checkTenSP(String tenSP)
        {
            String sql = "Select * from SanPham where TenSP=N'" + tenSP + "'";
            DataTable table = dataConn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string getMaSP()
        {
            string sql = "SELECT * FROM SanPham ORDER BY MaSP DESC";
            DataTable table = dataConn.GetTable(sql);
            return table.Rows[0][0].ToString();
        }
    }
}
