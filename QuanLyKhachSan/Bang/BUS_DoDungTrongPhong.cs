using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public class BUS_DoDungTrongPhong
    {
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
    }
}
