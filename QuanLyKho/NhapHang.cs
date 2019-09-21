using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private bool validate()
        {   //hàm kiểm tra hợp lệ dữ liệu
            if (fieldMAHH.Text == "" || fieldMaNCC.Text == "" || fieldNgayNhap.Text == "" || fieldNguoiNhap.Text == "" || fieldSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()  //hàm hiện
        {
            //chuỗi sql select
            string sql = @"SELECT MaPNK,PhieuNhap.NgayNhap,NguoiNhap,PhieuNhap.MaNCC,SoLuongNhap,PhieuNhap.MaHH,tenncc,tenhh FROM PhieuNhap INNER JOIN DMNhaCungCap ON DMNhaCungCap.mancc = PhieuNhap.MaNCC INNER JOIN DMHangHoa ON DMHangHoa.mahh = PhieuNhap.MaHH";


            //Gán datasource của datagridview = dữ liệu lệnh được từ câu lệnh sql trên
            dataGridView1.DataSource = DbHelper.getTable(sql);
        }

        private void binding()  //hàm đưa dữ liệu từ datagridview lên textbox(binding)
        {
            //xóa dữ liệu binding
            fieldMAHH.DataBindings.Clear();
            fieldMaNCC.DataBindings.Clear();
            fieldMaPNK.DataBindings.Clear();
            fieldNgayNhap.DataBindings.Clear();
            fieldNguoiNhap.DataBindings.Clear();
            fieldSoLuong.DataBindings.Clear();

            //nạp binding
            fieldMAHH.DataBindings.Add("SelectedValue", dataGridView1.DataSource, "MaHH");
            fieldMaNCC.DataBindings.Add("SelectedValue", dataGridView1.DataSource, "MaNCC");
            fieldMaPNK.DataBindings.Add("Text", dataGridView1.DataSource, "MaPNK");
            fieldNgayNhap.DataBindings.Add("Value", dataGridView1.DataSource, "NgayNhap");
            fieldNguoiNhap.DataBindings.Add("Text", dataGridView1.DataSource, "NguoiNhap");
            fieldSoLuong.DataBindings.Add("Text", dataGridView1.DataSource, "SoLuongNhap");
        }
        private void motxt()
        {
            fieldMAHH.Enabled = true;
            fieldMaNCC.Enabled = true;
            fieldNgayNhap.Enabled = true;
            fieldNguoiNhap.Enabled = true;
            fieldSoLuong.Enabled = true;
        }

        private void dongtxt()
        {
            fieldMAHH.Enabled = false;
            fieldMaNCC.Enabled = false;
            fieldNgayNhap.Enabled = false;
            fieldNguoiNhap.Enabled = false;
            fieldSoLuong.Enabled = false;
        }

        private void mobtn()
        {
            btluu.Enabled = false;
            btnhuy.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }

        private void dongbtn()
        {
            btluu.Enabled = true;
            btnhuy.Enabled = true;
            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }

        string state = "";  //lưu trạng thái khi ấn các nút thêm sửa xóa


        private void button2_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu để lọc
            string sql = @"SELECT MaPNK,PhieuNhap.NgayNhap,NguoiNhap,PhieuNhap.MaNCC,SoLuongNhap,PhieuNhap.MaHH,tenncc,tenhh FROM PhieuNhap INNER JOIN DMNhaCungCap ON DMNhaCungCap.mancc = PhieuNhap.MaNCC INNER JOIN DMHangHoa ON DMHangHoa.mahh = PhieuNhap.MaHH";

            DataTable data = Database.getTable(sql);  //lấy dữ liệu từ bảng KhachHang

            if (txtTim.Text != "")
            {
                data.DefaultView.RowFilter = "NguoiNhap LIKE '%" + txtTim.Text + "%' OR tenncc LIKE '%" + txtTim.Text + "%' OR tenhh LIKE '%" + txtTim.Text + "%'";  //filter lọc dữ liệu
            }
            else
            {
                data.DefaultView.RowFilter = "";
            }

            dataGridView1.DataSource = data;  //gán giá trị vào datagridview
        }


    }
}
