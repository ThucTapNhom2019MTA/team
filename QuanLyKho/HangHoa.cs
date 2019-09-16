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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM DMHangHoa";
            DataTable data = Database.getTable(sql);  //lấy dữ liệu từ bảng KhachHang
            if (fieldTim.Text != "")
            {
                data.DefaultView.RowFilter = "tenhh LIKE '%" + fieldTim.Text + "%'";  //filter lọc dữ liệu
            }
            else
            {
                data.DefaultView.RowFilter = "";
            }

            dataGridView1.DataSource = data;  //gán giá trị vào datagridview
        }

        private void btsua_Click(object sender, EventArgs e)
        {

        }

        private void motxt()
        {
            fieldDonViTinh.Enabled = true;
            fieldNgayNhap.Enabled = true;
            fieldSL.Enabled = true;
            fieldTenHH.Enabled = true;
        }

        private bool validate()
        {
            if (fieldDonViTinh.Text == "" || fieldSL.Text == "" || fieldTenHH.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"SELECT * FROM DMHangHoa";

            dataGridView1.DataSource = Database.getTable(sql);
        }

        private void binding()
        {
            fieldDonViTinh.DataBindings.Clear();
            fieldMaHH.DataBindings.Clear();
            fieldNgayNhap.DataBindings.Clear();
            fieldSL.DataBindings.Clear();
            fieldTenHH.DataBindings.Clear();


            fieldDonViTinh.DataBindings.Add("Text", dataGridView1.DataSource, "donvitinh");
            fieldMaHH.DataBindings.Add("Text", dataGridView1.DataSource, "mahh");
            fieldNgayNhap.DataBindings.Add("value", dataGridView1.DataSource, "ngaynhap");
            fieldSL.DataBindings.Add("Text", dataGridView1.DataSource, "soluong");
            fieldTenHH.DataBindings.Add("Text", dataGridView1.DataSource, "tenhh");
        }
        private void dongtxt()
        {
            fieldDonViTinh.Enabled = false;
            fieldNgayNhap.Enabled = false;
            fieldSL.Enabled = false;
            fieldTenHH.Enabled = false;
        }

        private void mobtn()
        {
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btnhuy.Enabled = false;
            btluu.Enabled = false;
        }

        private void dongbtn()
        {
            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btnhuy.Enabled = true;
            btluu.Enabled = true;
        }

        string state = "";
        private void btthem_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "insert";
        }



        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Visible = true;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "delete";
            binding();
        }
    }
}
