using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
=======
using System.Windows.Forms;
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
using System.Data.SqlClient;

namespace QuanLyKhachSan.src
{
    public partial class frmChoThuePhong : Form
    {
<<<<<<< HEAD
=======
        //khởi tạo
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
        string MaHD = "";
        BUS_KhachThuePhong kh = new BUS_KhachThuePhong();
        BUS_ThuePhong ThuePhong = new BUS_ThuePhong();
        BUS_Phong phong = new BUS_Phong();
        BUS_DichVu dv = new BUS_DichVu();
        public frmChoThuePhong()
        {
            InitializeComponent();
        }

        public void HienThiListKhach()
        {
            dgvKhachThuePhong.DataSource = kh.HienThiKhach_2TC();
        }
        public void HienThiPhongTrong_DV()
        {
            dgvPhongTrong.DataSource = phong.HienThiPhongTrong();
            dgvDichVu.DataSource = dv.HienThiDV();
        }

        private void btnThemKhachMoi_Click(object sender, EventArgs e)
        {
            frmKhachThue frm = new frmKhachThue();
            frm.Show();

        }

        private void frmChoThuePhong_Load(object sender, EventArgs e)
        {
            HienThiListKhach();
            HienThiPhongTrong_DV();
        }

        private void dgvKhachThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = dgvKhachThuePhong.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
<<<<<<< HEAD

=======
                //return something
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
            }
        }

        private void dgvPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaPhong.Text = dgvPhongTrong.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDV.Text = dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            //try
            //{
            DataTable dt = new DataTable();
            dt = ThuePhong.ThemHoaDon(txtMaKH.Text, "Admin", DateTime.Now);
            if (dt.Rows.Count < 1)
                MessageBox.Show("Thêm Hóa Đơn Thất Bại.");
            else
                MessageBox.Show("Thêm Hóa Đơn Thành Công.");
            MaHD = dt.Rows[0]["MaHD"].ToString();
            DataTable dt2 = new DataTable();
            //try
            //{
            dt2 = ThuePhong.ThemCTHoaDon(MaHD, txtMaPhong.Text, "DV00000001");
            //}
            //catch {
            //MessageBox.Show("Thêm Chi Tiết Hóa Đơn Thất Bại.");}
            //if (dt2.Rows.Count < 1)
            //    MessageBox.Show("Thêm Chi Tiết Hóa Đơn Thất Bại.");
            //else
            //    MessageBox.Show("Thêm Chi Tiết Hóa Đơn Thành Công.");
            ThuePhong.UpdateTrangThaiPhong_Thue(txtMaPhong.Text);

            //}
            //catch { }
            HienThiPhongTrong_DV();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            ThuePhong.ThemDV(MaHD, txtMaPhong.Text, txtMaDV.Text);
            HienThiPhongTrong_DV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiListKhach();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
