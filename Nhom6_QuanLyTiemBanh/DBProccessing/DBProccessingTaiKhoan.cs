using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingTaiKhoan
    {
        DBConnection.DBConnectionQly dataConn = new DBConnection.DBConnectionQly();

        public DataTable ShowTaiKhoan()
        {
            String sql = "Select * from TaiKhoan";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public void ThemTaiKhoan(String maTK, String tenDangNhap, String matKhau, Boolean tinhTrang, String hoTen, String diaChi, String soDT, String gioiTinh)
        {
            String sql = "Insert into TaiKhoan Values ('" + maTK + "', '" + tenDangNhap + "', '" + matKhau + "', '" + tinhTrang + "', N'" + hoTen + "', N'" + diaChi + "', '" + soDT + "', N'" + gioiTinh + "')";
            dataConn.ExecuteNonQuery(sql);
        }

        public void SuaTaiKhoan(String maTK, String tenDangNhap, String matKhau, Boolean tinhTrang, String hoTen, String diaChi, String soDT, String gioiTinh)
        {
            String sql = "Update TaiKhoan Set TenDangNhap='" + tenDangNhap + "', MatKhau='" + matKhau + "', TinhTrang='" + tinhTrang + "', HoTen=N'" + hoTen + "', DiaChi_nv=N'" + diaChi + "', SoDT_nv=N'" + soDT + "', GioiTinh=N'" + gioiTinh + "' where MaTk='" + maTK + "'";
            dataConn.ExecuteNonQuery(sql);
        }

        public void XoaTaiKhoan(String maTK)
        {
            String sql = "Delete TaiKhoan where MaTk='" + maTK + "'";
            dataConn.ExecuteNonQuery(sql);
        }

        public bool checkMaTaiKhoan(String maTK)
        {
            String sql = "Select * from TaiKhoan where MaTk='" + maTK + "'";
            DataTable table = dataConn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
