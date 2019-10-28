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
    public partial class XuatHang : Form
    {
        public XuatHang()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            if (fieldMaHH.Text == "" || fieldMaKH.Text == "" || fieldNguoiXuat.Text == "" || fieldSoLuongXuat.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"SELECT     PhieuXuat.NgayXuat, PhieuXuat.NguoiXuat, PhieuXuat.MaKH, PhieuXuat.SoLuongXuat, PhieuXuat.MaHH, PhieuXuat.MaPXK, DMKhachHang.tenkh, 
                      DMHangHoa.tenhh
                FROM  DMHangHoa INNER JOIN
                      PhieuXuat ON DMHangHoa.mahh = PhieuXuat.MaHH INNER JOIN
                      DMKhachHang ON PhieuXuat.MaKH = DMKhachHang.makh";

            dataGridView1.DataSource = Database.getTable(sql);
        }

        private void binding()
        {
            fieldMaHH.DataBindings.Clear();
            fieldMaKH.DataBindings.Clear();
            fieldMaPXK.DataBindings.Clear();
            fieldNgayXuat.DataBindings.Clear();
            fieldNguoiXuat.DataBindings.Clear();
            fieldSoLuongXuat.DataBindings.Clear();

            fieldMaHH.DataBindings.Add("Text", dataGridView1.DataSource, "MaHH");
            fieldMaKH.DataBindings.Add("Text", dataGridView1.DataSource, "MaKH");
            fieldMaPXK.DataBindings.Add("Text", dataGridView1.DataSource, "MaPXK");
            fieldNgayXuat.DataBindings.Add("Text", dataGridView1.DataSource, "NgayXuat");
            fieldNguoiXuat.DataBindings.Add("Text", dataGridView1.DataSource, "NguoiXuat");
            fieldSoLuongXuat.DataBindings.Add("Text", dataGridView1.DataSource, "SoLuongXuat");

        }
        private void motxt()
        {
            fieldMaHH.Enabled = true;
            fieldMaKH.Enabled = true;
            fieldNgayXuat.Enabled = true;
            fieldNguoiXuat.Enabled = true;
            fieldSoLuongXuat.Enabled = true;
        }

        private void dongtxt()
        {
            fieldMaHH.Enabled = false;
            fieldMaKH.Enabled = false;
            fieldNgayXuat.Enabled = false;
            fieldNguoiXuat.Enabled = false;
            fieldSoLuongXuat.Enabled = false;
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

        string state = "";

        private void XuatHang_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM DMKhachHang";

            fieldMaKH.DataSource = Database.getTable(sql);

            fieldMaKH.DisplayMember = "tenkh";

            fieldMaKH.ValueMember = "makh";


            string sql1 = @"SELECT * FROM DMHangHoa";

            fieldMaHH.DataSource = Database.getTable(sql1);

            fieldMaHH.DisplayMember = "tenhh";

            fieldMaHH.ValueMember = "mahh";


            mobtn();
            dongtxt();
            hien();
        }
    }
}
