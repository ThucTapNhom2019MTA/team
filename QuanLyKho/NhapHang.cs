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
<<<<<<< HEAD

=======
            // for something load
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
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
<<<<<<< HEAD
=======
                // thông báo lỗi
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
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
            dataGridView1.DataSource = Database.getTable(sql);
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

        private void btthem_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "insert";
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "update";
            binding();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "delete";
            binding();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (validate())  //kiểm tra trường k rỗng thì:
            {
<<<<<<< HEAD



=======
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
                if (state == "insert")  //sự kiện nút thêm
                {
                    //MessageBox.Show("INSERT INTO PhieuNhap(MaPhieuNhap, TenNCC, TenMH, SoLuongNhap,GiaNhap,TienDaThanhToan,NgayThanhToan) VALUES (" + Convert.ToInt32(txtMaPhieuNhap.Text) + ",N'" + txtTenNCC.Text + "',N'" + txtTenMH.Text + "'," + Convert.ToInt32(txtSoLuongNhap.Text) + "," + Convert.ToInt32(txtGiaNhap.Text) + "," + Convert.ToInt32(txtTienDaThanhToan.Text) + ",'"+txtNgayThanhToan.Value.ToShortDateString().ToString() +"')");
                    string sql = @"INSERT INTO [QLKhoHang].[dbo].[PhieuNhap]
                    ([NgayNhap]
                    ,[NguoiNhap]
                    ,[MaNCC]
                    ,[SoLuongNhap]
                    ,[MaHH])
                    VALUES
                    ('" + fieldNgayNhap.Value.ToString("yyyy/MM/dd") + @"'
                    ,N'" + fieldNguoiNhap.Text + @"'
                    ," + fieldMaNCC.SelectedValue + @"
                    ," + Convert.ToInt64(fieldSoLuong.Text) + @"
                    ," + fieldMAHH.SelectedValue + @"
                    )";


                    if (Database.Query(sql) != -1)  //hàm thực hiện lênh sql, trả về giá trị là -1 khi không có dòng nào bị ảnh hưởng (k có dòng nào thay đổi)
                    {
                        MessageBox.Show("Thêm thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm");
                    }
                }
                //end add
                else if (state == "update")  //tương tự nút thêm
                {
                    string sql = @"UPDATE [QLKhoHang].[dbo].[PhieuNhap]
                    SET [NgayNhap] = '" + fieldNgayNhap.Value.ToString("yyyy/MM/dd") + @"'
                    ,[NguoiNhap] = N'" + fieldNguoiNhap.Text + @"'
                    ,[MaNCC] = " + fieldMaNCC.SelectedValue + @"
                    ,[SoLuongNhap] = " + Convert.ToInt64(fieldSoLuong.Text) + @"
                    ,[MaHH] = " + fieldMAHH.SelectedValue + @"
                    WHERE MaPNK=" + Convert.ToInt64(fieldMaPNK.Text);



                    if (Database.Query(sql) != -1)
                    {
                        MessageBox.Show("Sửa thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình Sửa");
                    }

                }

                hien();
                dongtxt();
                mobtn();
            }//end validate
            if (state == "delete" && validate()) //tương tự nút thêm
            {
                string sql = @"DELETE FROM [QLKhoHang].[dbo].[PhieuNhap]
                WHERE MaPNK=" + Convert.ToInt64(fieldMaPNK.Text);


                if (Database.Query(sql) != -1)
                {
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình Xóa");
                }

                hien();
                dongtxt();
                mobtn();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            mobtn();
            dongtxt();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.ExportExcel(dataGridView1);
        }


    }
}
