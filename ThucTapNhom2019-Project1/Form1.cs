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

namespace ThucTapNhom2019_Project1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = ConnectSQLServer.getConnection();
        int soNhanVien;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            string strQueryDanhSach = "Select MaNhanVien as Mã, HoTen as [Họ và tên], " +
                "NgaySinh as [Ngày Sinh], DiaChi as [Địa Chỉ], SoDienThoai as [Số Điện Thoại], Email, " +
                "Luong as [Lương], TenChucVu AS [Tên chức vụ] from NhanVien, dbo.ChucVu " +
                "WHERE ChucVu.MaChucVu = NhanVien.MaChucVu";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            soNhanVien = dt.Rows.Count;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex <7) {
                conn.Open();
                string strQuery = "SELECT a.TenTo, b.TenPhong FROM (SELECT TenTo,MaNhanVien FROM [dbo].[To], dbo.NhanVien WHERE NhanVien.MaTo = [To].MaTo) AS a," +
            "(SELECT TenPhong, MaNhanVien FROM[To], Phong, dbo.NhanVien WHERE Phong.MaPhong = [To].MaPhong AND dbo.NhanVien.MaTo = [To].MaTo) AS b WHERE a.MaNhanVien = 'NV0001' AND a.MaNhanVien = b.MaNhanVien ";
                
            }

        }
    }
}
