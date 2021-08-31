using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_QuanLyTiemBanh.DBConnection
{
    class DBConnectionQly
    {
        public SqlConnection getConnect()
        {
            //String conString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=Nhom6_QLyTiemBanh;Integrated Security=True";
            //String conString = @"Data Source=DESKTOP-QMBOBJ0\SQLEXPRESS;Initial Catalog=Nhom6_QLyTiemBanh;Integrated Security=True";
            String conString = @"Data Source=DESKTOP-RK5F3LR\SQLEXPRESS;Initial Catalog=Nhom6_QLyTiemBanh;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
        public DataTable GetTable(String sql)
        {
            SqlConnection conn = getConnect();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(table);
            return table;
        }
        public void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
