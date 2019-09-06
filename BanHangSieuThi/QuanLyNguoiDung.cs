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
    public partial class QuanLyNguoiDung : Form
    {
        public QuanLyNguoiDung()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT * FROM dbo.SUDUNGPM";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dgvQuanLiNguoiDung.DataSource = dtDanhSach;
        }
    }
}
