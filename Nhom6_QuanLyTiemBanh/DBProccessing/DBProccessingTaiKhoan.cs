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

        public DataTable ShowNhanVien()
        {
            String sql = "Select * from TaiKhoan where TinhTrang='" + true + "'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public void ThemTaiKhoan(String tenDangNhap, String matKhau, Boolean tinhTrang, String hoTen, String diaChi, String soDT, String gioiTinh)
        {
            String sql = "Insert into TaiKhoan Values ('" + tenDangNhap + "', '" + matKhau + "', '" + tinhTrang + "', N'" + hoTen + "', N'" + diaChi + "', '" + soDT + "', N'" + gioiTinh + "')";
            dataConn.ExecuteNonQuery(sql);
        }

        public void SuaTaiKhoan(int maTK, String tenDangNhap, String matKhau, Boolean tinhTrang, String hoTen, String diaChi, String soDT, String gioiTinh)
        {
            String sql = "Update TaiKhoan Set TenDangNhap='" + tenDangNhap + "', MatKhau='" + matKhau + "', TinhTrang='" + tinhTrang + "', HoTen=N'" + hoTen + "', DiaChi_nv=N'" + diaChi + "', SoDT_nv=N'" + soDT + "', GioiTinh=N'" + gioiTinh + "' where MaTk=" + maTK + "";
            dataConn.ExecuteNonQuery(sql);
        }

        public void XoaTaiKhoan(int maTK)
        {
            String sql = "Delete TaiKhoan where MaTk=" + maTK + "";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable TimKiemTheoMaTK(int maTK)
        {
            String sql = "Select * from TaiKhoan where MaTk=" + maTK + " and TinhTrang='" + true + "'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }
        public DataTable TimKiemTheoHoTen(String hoTen)
        {
            String sql = "Select * from TaiKhoan where HoTen=N'" + hoTen+ "' and TinhTrang='" + true + "'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }
        

        public bool checkMaTaiKhoan(int maTK)
        {
            String sql = "Select * from TaiKhoan where MaTk=" + maTK + "";
            DataTable table = dataConn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool checkHoTen(String hoTen)
        {
            String sql = "Select * from TaiKhoan where HoTen=N'" + hoTen + "'";
            DataTable table = dataConn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool checkMaTaiKhoanNhanVien(int maTK)
        {
            String sql = "Select * from TaiKhoan where MaTk=" + maTK + " and TinhTrang='" + true + "'";
            DataTable table = dataConn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool checkHoTenNhanVien(String hoTen)
        {
            String sql = "Select * from TaiKhoan where HoTen=N'" + hoTen + "' and TinhTrang='" + true + "'";
            DataTable table = dataConn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
