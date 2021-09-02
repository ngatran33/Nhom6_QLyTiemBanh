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
            String sql = "Update KhachHang Set TenKh=N'" + TenKH + "', DiaChiKH=N'" + DiaChi + "', SDTKh='" + SoDT + "' where MaKh = " + maKH + "";
            dataConn.ExecuteNonQuery(sql);
        }

        public void XoaKhachHang(int maKH)
        {
            String sql = "Delete KhachHang where MaKh=" + maKH + "";
            dataConn.ExecuteNonQuery(sql);
        }
        
        public DataTable TimKiemTheoHoTen(String hoTen)
        {
            String sql = "Select * from KhachHang where TenKh=N'" + hoTen + "'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }
        public bool checkTenKH(String tenKH)
        {
            String sql = "Select * from KhachHang where TenKh=N'" + tenKH + "'";
            DataTable table = dataConn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
