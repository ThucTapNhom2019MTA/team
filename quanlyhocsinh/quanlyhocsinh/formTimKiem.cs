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

namespace quanlyhocsinh
{
    public partial class formTimKiem : Form
    {
        DataTable dtDanhSach;
        SqlConnection conn = constringsql.getConnection();
        public formTimKiem()
        {
            InitializeComponent();
        }

        private void formTimKiem_Load(object sender, EventArgs e)
        {
            conn.Open();
            string strQueryDanhSach;
            if (Form1.chooseGV_Stu == 2)
            {
                strQueryDanhSach = "SELECT MAHOCSINH AS [MÃ HỌC SINH], HOTEN AS [HỌ TÊN], GIOITINH AS [GIỚI TÍNH], NGAYSINH AS [NGÀY SINH], NOISINH AS [QUÊ QUÁN] FROM dbo.HOCSINH";
                cbTimKiemGV.Hide();
            }
            else 
            {
                strQueryDanhSach = "SELECT MAGIAOVIEN AS [MÃ GIÁO VIÊN], HOTEN AS [HỌ TÊN], SODIENTHOAI AS [ĐIỆN THOẠI]" +
                                        ", CHUYENMON AS[MÔN HỌC], GIOITINH AS[GIỚI TÍNH], NOISINH AS[NƠI SINH]  FROM dbo.GIAOVIEN";
                cbTimkiemSV.Hide();
            }
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dataGridView1.DataSource = dtDanhSach;
            conn.Close();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            if(Form1.chooseGV_Stu == 1)
            {
                Formgiaovien form = new Formgiaovien();
                form.Show();
                this.Hide();
            }
            if (Form1.chooseGV_Stu == 2)
            {
                Formhocsinh form = new Formhocsinh();
                form.Show();
                this.Hide();
            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (cbTimKiemGV.Text == "ID" || cbTimkiemSV.Text == "ID")
            {
                string ID = tb_timkiem.Text;
                string strQueryDanhSach;
                if (Form1.chooseGV_Stu == 2)
                {
                    strQueryDanhSach = "SELECT MAHOCSINH AS [MÃ HỌC SINH], HOTEN AS [HỌ TÊN], GIOITINH AS [GIỚI TÍNH], NGAYSINH AS [NGÀY SINH], NOISINH AS [QUÊ QUÁN] FROM dbo.HOCSINH where MAHOCSINH LIKE '%" + ID + "%'";
                }
                else strQueryDanhSach = "SELECT MAGIAOVIEN AS [MÃ GIÁO VIÊN], HOTEN AS [HỌ TÊN], SODIENTHOAI AS [ĐIỆN THOẠI]" +
                                        ", CHUYENMON AS[MÔN HỌC], GIOITINH AS[GIỚI TÍNH], NOISINH AS[NƠI SINH]  FROM dbo.GIAOVIEN where MAGIAOVIEN LIKE '%" + ID + "%'";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridView1.DataSource = dtDanhSach;
            }
            if (cbTimKiemGV.Text == "Name" || cbTimkiemSV.Text == "Name")
            {
                string Name = tb_timkiem.Text;
                string strQueryDanhSach;
                if (Form1.chooseGV_Stu == 2)
                {
                    strQueryDanhSach = "SELECT MAHOCSINH AS [MÃ HỌC SINH], HOTEN AS [HỌ TÊN], GIOITINH AS [GIỚI TÍNH], NGAYSINH AS [NGÀY SINH], NOISINH AS [QUÊ QUÁN] FROM dbo.HOCSINH where HOTEN LIKE N'%" + Name + "%'";
                }
                else strQueryDanhSach = "SELECT MAGIAOVIEN AS [MÃ GIÁO VIÊN], HOTEN AS [HỌ TÊN], SODIENTHOAI AS [ĐIỆN THOẠI]" +
                                        ", CHUYENMON AS[MÔN HỌC], GIOITINH AS[GIỚI TÍNH], NOISINH AS[NƠI SINH]  FROM dbo.GIAOVIEN where HOTEN LIKE N'%" + Name + "%'";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridView1.DataSource = dtDanhSach;
            }
            //if (cbTimKiem.Text == "Phone")
            //{
            //    string Phone = tb_timkiem.Text;
            //    string strQueryDanhSach = "SELECT HoTen, NgaySinh, DiaChi, SoDienThoai, TenChucVu, TenPhong FROM dbo.NhanVien, dbo.ChucVu, dbo.[To], dbo.Phong WHERE ChucVu.MaChucVu = NhanVien.MaChucVu AND NhanVien.MaTo =[To].MaTo AND Phong.MaPhong =[To].MaPhong AND SoDienThoai like '%" + Phone + "%'";
            //    SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            //    dtDanhSach = new DataTable();
            //    da.Fill(dtDanhSach);
            //    dataGridView1.DataSource = dtDanhSach;
            //}
            if (cbTimKiemGV.Text == "Address" || cbTimkiemSV.Text == "Address")
            {
                string Address = tb_timkiem.Text;
                string strQueryDanhSach;
                if (Form1.chooseGV_Stu == 2)
                {
                    strQueryDanhSach = "SELECT MAHOCSINH AS [MÃ HỌC SINH], HOTEN AS [HỌ TÊN], GIOITINH AS [GIỚI TÍNH], NGAYSINH AS [NGÀY SINH], NOISINH AS [QUÊ QUÁN] FROM dbo.HOCSINH where NOISINH LIKE N'%" + Name + "%'";
                }
                else strQueryDanhSach = "SELECT MAGIAOVIEN AS [MÃ GIÁO VIÊN], HOTEN AS [HỌ TÊN], SODIENTHOAI AS [ĐIỆN THOẠI]" +
                                        ", CHUYENMON AS[MÔN HỌC], GIOITINH AS[GIỚI TÍNH], NOISINH AS[NƠI SINH]  FROM dbo.GIAOVIEN where NOISINH LIKE N'%" + Name + "%'";

                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridView1.DataSource = dtDanhSach;
            }
            //if (cbTimKiem.Text == "Position")
            //{
            //    string Position = tb_timkiem.Text;
            //    string strQueryDanhSach = "SELECT HoTen, NgaySinh, DiaChi, SoDienThoai, TenChucVu, TenPhong FROM dbo.NhanVien, dbo.ChucVu, dbo.[To], dbo.Phong WHERE ChucVu.MaChucVu = NhanVien.MaChucVu AND NhanVien.MaTo =[To].MaTo AND Phong.MaPhong =[To].MaPhong AND TenChucVu LIKE N'%" + Position + "%'";
            //    SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            //    dtDanhSach = new DataTable();
            //    da.Fill(dtDanhSach);
            //    dataGridView1.DataSource = dtDanhSach;
            //}
            conn.Close();
        }
    }
}
