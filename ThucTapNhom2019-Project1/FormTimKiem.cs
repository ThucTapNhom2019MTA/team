using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ThucTapNhom2019_Project1
{
    public partial class FormTimKiem : Form
    {
        DataTable dtDanhSach;
        SqlConnection conn = ConnectSQLServer.getConnection();
        public FormTimKiem()
        {
            InitializeComponent();
        }
        private void Bt_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (cbTimKiem.Text == "ID")
            {
                string ID = tb_timkiem.Text;
                string strQueryDanhSach = "SELECT HoTen, NgaySinh, DiaChi, SoDienThoai, TenChucVu, TenPhong FROM dbo.NhanVien, dbo.ChucVu, dbo.[To], dbo.Phong WHERE ChucVu.MaChucVu = NhanVien.MaChucVu AND NhanVien.MaTo =[To].MaTo AND Phong.MaPhong =[To].MaPhong AND MaNhanVien LIKE '%" + ID + "%'";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridView1.DataSource = dtDanhSach;
            }
            if (cbTimKiem.Text == "Name")
            {
                string Name = tb_timkiem.Text;
                string strQueryDanhSach = "SELECT HoTen, NgaySinh, DiaChi, SoDienThoai, TenChucVu, TenPhong FROM dbo.NhanVien, dbo.ChucVu, dbo.[To], dbo.Phong WHERE ChucVu.MaChucVu = NhanVien.MaChucVu AND NhanVien.MaTo =[To].MaTo AND Phong.MaPhong =[To].MaPhong AND HoTen LIKE N'%" + Name + "%'";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridView1.DataSource = dtDanhSach;
            }
            if (cbTimKiem.Text == "Date")
            {
                string Date = tb_timkiem.Text;
                string strQueryDanhSach = "SELECT HoTen, NgaySinh, DiaChi, SoDienThoai, TenChucVu, TenPhong FROM dbo.NhanVien, dbo.ChucVu, dbo.[To], dbo.Phong WHERE ChucVu.MaChucVu = NhanVien.MaChucVu AND NhanVien.MaTo =[To].MaTo AND Phong.MaPhong =[To].MaPhong AND NgaySinh LIKE '%" + Date + "%'";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridView1.DataSource = dtDanhSach;
            }
            if (cbTimKiem.Text == "Address")
            {
                string Address = tb_timkiem.Text;
                string strQueryDanhSach = "SELECT HoTen, NgaySinh, DiaChi, SoDienThoai, TenChucVu, TenPhong FROM dbo.NhanVien, dbo.ChucVu, dbo.[To], dbo.Phong WHERE ChucVu.MaChucVu = NhanVien.MaChucVu AND NhanVien.MaTo =[To].MaTo AND Phong.MaPhong =[To].MaPhong AND DiaChi LIKE N'%" + Address + "%'";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridView1.DataSource = dtDanhSach;
            }
            if (cbTimKiem.Text == "Position")
            {
                string Position = tb_timkiem.Text;
                string strQueryDanhSach = "SELECT HoTen, NgaySinh, DiaChi, SoDienThoai, TenChucVu, TenPhong FROM dbo.NhanVien, dbo.ChucVu, dbo.[To], dbo.Phong WHERE ChucVu.MaChucVu = NhanVien.MaChucVu AND NhanVien.MaTo =[To].MaTo AND Phong.MaPhong =[To].MaPhong AND TenChucVu LIKE N'%" + Position + "%'";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridView1.DataSource = dtDanhSach;
            }
            conn.Close();
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
