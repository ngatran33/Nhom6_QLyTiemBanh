using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingNhaCungCap
    {
        DBConnection.DBConnectionQly dataConn = new DBConnection.DBConnectionQly();

        public DataTable ShowNhaCungCap()
        {
            String sql = "Select * from NhaCungCap";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public void ThemNhaCungCap(String TenNCC, String DiaChi, String SoDT)
        {
            String sql = "Insert into NhaCungCap Values (N'" + TenNCC + "', N'" + DiaChi + "', '" + SoDT + "')";
            dataConn.ExecuteNonQuery(sql);
        }

        public void SuaNhaCungCap(int maNCC, String TenNCC, String DiaChi, String SoDT)
        {
            String sql = "Update NhaCungCap Set TenNcc=N'" + TenNCC + "', DiaChi_NCC=N'" + DiaChi + "', SoDT='" + SoDT + "' where MaNCC = " + maNCC + "";
            dataConn.ExecuteNonQuery(sql);
        }

        public void XoaNhaCungCap(int maNCC)
        {
            String sql = "Delete NhacungCap where MaNCC=" + maNCC + "";
            dataConn.ExecuteNonQuery(sql);
        }

        public DataTable TimKiemTheoTen(String hoTen)
        {
            String sql = "Select * from NhaCungCap where TenNcc=N'" + hoTen + "'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }
        public bool checkNhaCungCap(String tenNCC)
        {
            String sql = "Select * from NhaCungCap where TenNcc=N'" + tenNCC + "'";
            DataTable table = dataConn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
