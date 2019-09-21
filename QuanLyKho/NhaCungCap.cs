using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lớp_BUS;
using Lớp_DAL;
using Lớp_Entites;

namespace QuanLyKho
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        BUS_tblNhaCungCap bus = new BUS_tblNhaCungCap();
        EC_tblNhaCungCap ec = new EC_tblNhaCungCap();
        bool themmoi;
        void modieukhien()
        {
            fieldMaNCC.Enabled = true;
            fieldTenNCC.Enabled = true;
            fieldSDT.Enabled = true;
            fieldEmail.Enabled = true;
            fieldDiaChi.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
        }
        void khoadieukhien()
        {
            fieldMaNCC.Enabled = false;
            fieldTenNCC.Enabled = false;
            fieldSDT.Enabled = false;
            fieldEmail.Enabled = false;
            fieldDiaChi.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
        }
        void setnull()
        {
            fieldMaNCC.Text = "";
            fieldTenNCC.Text = "";
            fieldSDT.Text = "";
            fieldEmail.Text = "";
            fieldDiaChi.Text = "";
        }
        void hienthidulieu(string DieuKien)
        {
            dataGridView1.DataSource = bus.taobang(DieuKien);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM DMNhaCungCap";
            DataTable data = Database.getTable(sql);  //lấy dữ liệu từ bảng KhachHang
            if (fieldTim.Text != "")
            {
                data.DefaultView.RowFilter = "tenncc LIKE '%" + fieldTim.Text + "%' ";  //filter lọc dữ liệu
            }
            else
            {
                data.DefaultView.RowFilter = "";
            }

            dataGridView1.DataSource = data;  //gán giá trị vào datagridview
        }
    }
}
