using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class BUS_DichVu
    {
        public DataTable HienThiDV()
        {
            string sql = "SELECT * FROM DichVu ";
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}