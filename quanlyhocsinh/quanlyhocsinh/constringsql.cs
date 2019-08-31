using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace quanlyhocsinh
{
    class constringsql
    {
        public static SqlConnection getConnection()
        {
            //string connString = @"Data Source=DESKTOP-BBQPTV7\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
            string connString = @"Data Source=.; Initial Catalog=QuanLyHocSinh;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

    }
}
