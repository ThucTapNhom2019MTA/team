using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public class TimKiem
    {
        // Tìm kiếm Phòng theo mã
        public DataTable TKPhong_MaPhong(string MaPhong)
        {
            string sql = "SELECT * FROM Phong WHERE MaPhong LIKE N'%' + @MaPhong + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection(); con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

        // Tìm kiếm phòng theo tên
        public DataTable TKPhong_TenPhong(string TenPhong)
        {
            string sql = "SELECT * FROM Phong WHERE TenPhong LIKE N'%' + @TenPhong + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm phòng theo loại
        public DataTable TKPhong_LoaiPhong(string LoaiPhong)
        {
            string sql = "SELECT * FROM Phong WHERE LoaiPhong LIKE N'%' + @LoaiPhong + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //Show đồ dùng trong phòng theo mã
        public DataTable ShowDoDung_Ma(string MaPhong)
        {
            string sql = string.Format(@"SELECT     dbo.DoDung.MaDD, dbo.DoDung.TenDD, dbo.DoDungTrongPhong.SoLuong, dbo.DoDungTrongPhong.DonViTinh, dbo.DoDungTrongPhong.TinhTrang, dbo.DoDung.GiaMua
                                        FROM         dbo.DoDungTrongPhong INNER JOIN
                                                              dbo.DoDung ON dbo.DoDungTrongPhong.MaDoDung = dbo.DoDung.MaDD INNER JOIN
                                                              dbo.Phong ON dbo.DoDungTrongPhong.MaPhong = dbo.Phong.MaPhong
                                        WHERE     (dbo.Phong.MaPhong = @MaPhong)");
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // tìm kiếm khách theo mã khách
        public DataTable TKKhach_MaKhach(string MaKhach)
        {
            string sql = "SELECT * FROM KhachThuePhong WHERE MaKH LIKE N'%' + @MaKH + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaKH", MaKhach);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // tìm kiếm khách theo họ tên
        public DataTable TKKhach_TenKhach(string HoTen)
        {
            string sql = "SELECT * FROM KhachThuePhong WHERE TenKH LIKE N'%' + @TenKH + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenKH", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // tìm kiếm khách theo CMND
        public DataTable TKKhach_CMND(string CMND)
        {
            string sql = "SELECT * FROM KhachThuePhong WHERE CMND LIKE N'%' + @CMND + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@CMND", CMND);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
