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
    public partial class QuanLiNhanVien : Form
    {
        public QuanLiNhanVien()
        {
            InitializeComponent();
            FillData();
        }
        private void FillData()
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT MaNV FROM dbo.NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            for (int i = 0; i < dtDanhSach.Rows.Count; i++)
            {
                cbbMaNhanVien.Items.Add(dtDanhSach.Rows[i][0].ToString());
                cbbMNV.Items.Add(dtDanhSach.Rows[i][0].ToString());
            }
            cbbMNV.SelectedIndex = 0;
            cbbMaNhanVien.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            // them nhan vien
            conn.Open();
            string query = "INSERT INTO dbo.NHANVIEN ( MaNV, TenNV, ChucVu ) VALUES ( @MaNV, @TenNV, @ChucVu )";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaNV ", txbMaNV.Text);
            comm.Parameters.AddWithValue("@TenNV", txbTenNV.Text);
            comm.Parameters.AddWithValue("@ChucVu", txbChucVu.Text);
            comm.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công", "Thông báo");
            FillData();
            conn.Close();
        }

        private void cbbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cbbMaNhanVien.SelectedItem.ToString();
            getNhanVien(maNV);
            fillData(maNV);
            sumWorkTime(maNV);
        }
        private void sumWorkTime(string maNV)
        {
            SqlConnection conn = ConnectDB.getConnection();
            conn.Open();
            string query = "SELECT SUM(DATEDIFF(MINUTE,ThoiGianBD,ThoiGianKT)) FROM dbo.NGAYCONG WHERE MaNV = @MaNV";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaNV", maNV);
            txbGioLam.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
        }
        private void fillData(string maNV)
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT * FROM dbo.NGAYCONG WHERE MaNV = @MaNV";
            SqlCommand comm = new SqlCommand(strQueryDanhSach, conn);
            comm.Parameters.AddWithValue("@MaNV", maNV);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dgvNhanVien.DataSource = dtDanhSach;
        }
        private void getNhanVien(string maNV)
        {
            SqlConnection conn = ConnectDB.getConnection();
            // them nhan vien
            conn.Open();
            string query = "SELECT TenNV FROM dbo.NHANVIEN WHERE MaNV=@maNV";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@maNV",maNV);
            txbTenNhanVien.Text =  Convert.ToString(comm.ExecuteScalar());
            conn.Close();
            conn.Open();
            query = "SELECT ChucVu FROM dbo.NHANVIEN WHERE MaNV=@maNV";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@maNV", maNV);
            txbCvu.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
        }
        private void getProfileNhanVien(string maNV)
        {
            SqlConnection conn = ConnectDB.getConnection();
            // them nhan vien
            conn.Open();
            string query = "SELECT TenNV FROM dbo.NHANVIEN WHERE MaNV=@maNV";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@maNV", maNV);
            txbTenNhanVien.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
            conn.Open();
            query = "SELECT ChucVu FROM dbo.NHANVIEN WHERE MaNV=@maNV";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@maNV", maNV);
            txbCvu.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            string query = "INSERT INTO dbo.NGAYCONG ( Ngay, ThoiGianBD, ThoiGianKT, TraLuong, MaNV )" +
                " VALUES (@Ngay, @ThoiGianBD, @ThoiGianKT, @TraLuong, @MaNV )";
            conn.Open();
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@Ngay", dtpNgay.Value.ToShortDateString());
            comm.Parameters.AddWithValue("@ThoiGianBD", txbTGBD.Text);
            comm.Parameters.AddWithValue("@ThoiGianKT", txbTGKT.Text);
            comm.Parameters.AddWithValue("@TraLuong", cbbState.SelectedItem.ToString());
            comm.Parameters.AddWithValue("@MaNV", cbbMNV.SelectedItem.ToString());
            comm.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công","Thông báo");
            conn.Close();
        }
    }
}
