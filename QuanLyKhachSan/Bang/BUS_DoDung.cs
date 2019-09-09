using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class BUS_DoDung
    {
        public DataTable HienThiDoDung(string DieuKien)
        {
            string sql = "SELECT * FROM DoDung " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public DataTable HienThiDoDung1()
        {
            string sql = "SELECT * FROM DoDung";
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

    }
}
