using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public class BUS_ThuePhong
    {
        public DataTable ThemHoaDon(string MaKH, string NguoiLap, DateTime TGMuon)
        {
            DataTable dt = new DataTable();
            string str = string.Format("ThemHD");
            SqlConnection con = ConnectSQLServer.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
<<<<<<< HEAD
=======

>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
            cmd.Parameters.AddWithValue("@NguoiLap", NguoiLap);
            cmd.Parameters.AddWithValue("@TGMuon", TGMuon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
<<<<<<< HEAD

=======
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
            return dt;
        }
        public DataTable ThemCTHoaDon(string MaHD, string MaPhong, string MaDV)
        {
            DataTable dt = new DataTable();
            string str = string.Format("ThemCTHD");
            SqlConnection con = ConnectSQLServer.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHD", MaHD);
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.Parameters.AddWithValue("@MaDV", MaDV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void UpdateTrangThaiPhong_Thue(string MaPhong)
        {
            string str = string.Format(@"Update Phong set TinhTrang = 'Using' where MaPhong = '" + MaPhong + "'");
            SqlConnection con = ConnectSQLServer.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
<<<<<<< HEAD
=======
        //them dich vu
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
        public void ThemDV(string MaHD, string MaPhong, string MaDV)
        {
            try
            {
                string str = string.Format(@"Insert into CTHD '" + MaHD + "'" + "','" + MaPhong + "', '" + MaDV + "'");
                SqlConnection con = ConnectSQLServer.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
            }
<<<<<<< HEAD
            catch { }
=======
            catch {
            }
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
        }
    }
}
