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

namespace BanHangSieuThi
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "";
            // Tim kiem theo ten
            if (cbbSearch.SelectedIndex == 1)
                strQueryDanhSach = "SELECT * FROM dbo.HANGHOA WHERE TenHang LIKE N'%" + txbSearchText.Text + "%'";
            else strQueryDanhSach = "SELECT * FROM dbo.HANGHOA WHERE MaHang = N'"+ txbSearchText.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dgvHangHoa.DataSource = dtDanhSach;
        }
        private void button1_Click_New(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "";
            // Tim kiem theo ten
            if (cbbSearch.SelectedIndex == 1)
                strQueryDanhSach = "SELECT * FROM dbo.HANGHOA WHERE TenHang LIKE N'%" + txbSearchText.Text + "%'";
            else strQueryDanhSach = "SELECT * FROM dbo.HANGHOA WHERE MaHang = N'" + txbSearchText.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dgvHangHoa.DataSource = dtDanhSach;
        }
    }
}
