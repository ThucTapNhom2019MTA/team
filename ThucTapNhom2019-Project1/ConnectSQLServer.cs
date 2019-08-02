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
            string connString = "Data Source=HQH;Initial Catalog = QuanLiNhanSu; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}

