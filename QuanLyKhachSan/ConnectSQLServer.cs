using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    class ConnectSQLServer
    {
        
        public static SqlConnection getConnection()
        {
            string connString = @"Data Source=DESKTOP-BBQPTV7\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}// *** * * 

