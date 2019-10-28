using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace QuanLyKhachSan.src
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }
        private void GetFileAll(string tenfile)
        {
<<<<<<< HEAD
            StreamReader doc = File.OpenText(tenfile);
=======
            string path = "help\\" + tenfile;
            StreamReader doc = File.OpenText( path);
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
            string s = doc.ReadToEnd();
            txtGioiThieu.Text = s;
        }

        private void trViewGioiThieu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "gtPhanMem")
            {
                GetFileAll("GioiThieuChung.txt");
<<<<<<< HEAD
                Image img = Image.FromFile(@"khachsan.jpg");
=======
                Image img = Image.FromFile(@"help\\khachsan.jpg");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                pictureBox1.BackgroundImage = img;


            }
            else if (e.Node.Name == "gtDangNhap")
            {
                GetFileAll("PhanDangNhap.txt");
<<<<<<< HEAD
                Image img = Image.FromFile(@"b5 dang nhap.png");
=======
                Image img = Image.FromFile(@"help\\b5 dang nhap.png");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtManHinhChinh")
            {
                GetFileAll("PhanMain.txt");
<<<<<<< HEAD
                Image img = Image.FromFile(@"b5 main.png");
=======
                Image img = Image.FromFile(@"help\\b5 main.png");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtPhong")
            {
                GetFileAll("PhanPhong.txt");
<<<<<<< HEAD
                Image img = Image.FromFile(@"b5 Phong.png");
=======
                Image img = Image.FromFile(@"help\\b5 Phong.png");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtChoThuePhong")
            {
                GetFileAll("PhanChoThuePhong.txt");
<<<<<<< HEAD
                Image img = Image.FromFile(@"b5 ChoThuePhong.png");
=======
                Image img = Image.FromFile(@"help\\b5 ChoThuePhong.png");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDoDungCuaKhachSan")
            {
                GetFileAll("PhanDoDungCuaKhachSan.txt");
<<<<<<< HEAD
                Image img = Image.FromFile(@"b5 DoDungCuaKhachSan.png");
=======
                Image img = Image.FromFile(@"help\\b5 DoDungCuaKhachSan.png");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDoDungTheoPhong")
            {
                GetFileAll("PhanDoDungTheoPhong.txt");
<<<<<<< HEAD
                Image img = Image.FromFile(@"b5 DoDungTheoPhong.png");
=======
                Image img = Image.FromFile(@"help\\b5 DoDungTheoPhong.png");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtKhachThue")
            {
                GetFileAll("PhanKhachThue.txt");
<<<<<<< HEAD
                Image img = Image.FromFile(@"b5 KhachThue.png");
=======
                Image img = Image.FromFile(@"help\\b5 KhachThue.png");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtTraPhong")
            {
                GetFileAll("PhanTraPhong.txt");
<<<<<<< HEAD
                Image img = Image.FromFile(@"b5 TraPhong.png");
=======
                Image img = Image.FromFile(@"help\\b5 TraPhong.png");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                pictureBox1.BackgroundImage = img;
            }
        }
    }
}
