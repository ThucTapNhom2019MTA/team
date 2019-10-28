using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ThucTapNhom2019_Project1
{
    class ConnectSQLServer
    {
        
        public static SqlConnection getConnection()
        {
            // new comment 
            //string connString = @"Data Source=LAPTOP-2GH99NQG\PHAMDANSQL;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            //string connString = "Data Source=.; Initial Catalog = QuanLiNhanSu; Integrated Security = True";
            //string connString = @"Data Source=.\SQLSERVER;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            //string connString = @"Data Source=DESKTOP-BBQPTV7\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            string connString = @"Data Source=DESKTOP-U1I0DJ3\SQLSERVER;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}// *** * * 

