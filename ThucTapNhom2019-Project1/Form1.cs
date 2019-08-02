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
        public Form1()
        {
            InitializeComponent();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            //Lay ten cac phong;
            //string strQueryPhong = "Select * from Phong";
            //SqlDataAdapter da = new SqlDataAdapter(strQueryPhong, conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //comboBox1.DataSource = dt;
            //comboBox1.DisplayMember = "TenPhong";
            //comboBox1.ValueMember = "MaPhong";
            //
            string strQueryDanhSach = "Select MaNhanVien as Mã, HoTen as [Họ và tên], " +
                "NgaySinh as [Ngày Sinh], DiaChi as [Địa Chỉ], SoDienThoai as [Số Điện Thoại], Email, Luong as [Lương] from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
