using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingKhachHang
    {
        DBConnection.DBConnectionQly dataConn = new DBConnection.DBConnectionQly();

        public DataTable ShowKhachHang()
        {
            String sql = "Select * from KhachHang";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public void ThemKhachHang(String TenKH, String DiaChi, String SoDT)
        {
            String sql = "Insert into KhachHang Values (N'" + TenKH + "', N'" + DiaChi + "', '" + SoDT + "')";
            dataConn.ExecuteNonQuery(sql);
        }

        public void SuaKhachHang(int maKH, String TenKH, String DiaChi, String SoDT)
        {
            String sql = "Update TaiKhoan Set TenKh='" + TenKH + "', DiaChiKH='" + DiaChi + "', SDTKh='" + SoDT + "' where MaKh = " + maKH + "";
            dataConn.ExecuteNonQuery(sql);
        }

        public void XoaKhachHang(int maTK)
        {
            String sql = "Delete TaiKhoan where MaTk=" + maTK + "";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable TimKiemTheoMaKH(int maKH)
        {
            String sql = "Select * from TaiKhoan where MaTk=" + maKH + "";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }
        public DataTable TimKiemTheoHoTen(String hoTen)
        {
            String sql = "Select * from TaiKhoan where HoTen=N'" + hoTen + "'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }
    }
}
