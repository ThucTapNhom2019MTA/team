﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class CTHD
    {

        public DataTable HienCTDH(string dieukien)
        {
            string sql = "SELECT ct.MaDV, TenDV, Gia FROM CTHD ct, DichVu dv where ct.MaDV=dv.MaDV " + dieukien;
            DataTable dt = new DataTable();
            SqlConnection con = ConnectSQLServer.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        //public void ThemPhong(string TenPhong, string LoaiPhong)
        //{
        //    string sql = "ADDPhong";
        //    SqlConnection con = ConnectSQLServer.getConnection();
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
        //    cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);

        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}

        //public void SuaCTHD(string MaHD, string MaPhong, string MaDV, long TongTien, DateTime TGMuon, DateTime TGTra)
        //{
        //    string sql = "SuaCTHD";
        //    SqlConnection con = ConnectSQLServer.getConnection();
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
        //    cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
        //    cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);
        //    cmd.ExecuteNonQuery();

        //    cmd.Dispose();
        //    con.Close();
        //}
    }
}
