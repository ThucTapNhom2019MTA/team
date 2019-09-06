using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangSieuThi
{
    class ConnectDB
    {
        public static SqlConnection getConnection()
        {
            string connString = @"Data Source=LAPTOP-2GH99NQG\PHAMDANSQL;Initial Catalog=QuanLiBanHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
