using Nhom6_QuanLyTiemBanh.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_QuanLyTiemBanh.DBProccessing
{
    class DBProccessingDangNhap
    {
        DBConnectionQly dbconn = new DBConnectionQly();
        public bool checkTaiKhoan(string tenDN, String MK)
        {
            String sql = "Select * from TaiKhoan where TenDangNhap= '" + tenDN + "' and MatKhau='" + MK + "'";
            DataTable table = dbconn.getTable(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public string getMaTk(string tenDN, String MK)
        {
            String sql = "Select * from TaiKhoan where TenDangNhap= '" + tenDN + "' and MatKhau='" + MK + "'";
            DataTable table = dbconn.getTable(sql);
            return table.Rows[0].ItemArray[0].ToString();
            
        }
    }
}
