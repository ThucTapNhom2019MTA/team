using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            loadThongTinKhacHang();
        }

        private void loadThongTinKhacHang()
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT GioiTinh,Tuoi,ThoiGianLap AS ThoiGianMuaHang FROM dbo.KHACHHANG,dbo.LAPHOADON WHERE KHACHHANG.MaKH = LAPHOADON.MaKH";
            SqlCommand comm = new SqlCommand(strQueryDanhSach, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dgvKhachHang.DataSource = dtDanhSach;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            conn.Open();
            string query = "INSERT INTO dbo.KHACHHANG ( MaKH, GioiTinh, Tuoi ) VALUES (@MaKH, @GioiTinh, @Tuoi )";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaKH", Form1.CreatePassword(10));
            comm.Parameters.AddWithValue("@GioiTinh", txbGioiTinh.Text);
            comm.Parameters.AddWithValue("@Tuoi", txbDoTuoi.Text);
            comm.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công", "Thông báo");
        }
    }
}
