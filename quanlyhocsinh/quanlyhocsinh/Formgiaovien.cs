using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlyhocsinh
{
    public partial class Formgiaovien : Form
    {
        public Formgiaovien()
        {
            InitializeComponent();
        }

        private void Formgiaovien_Load(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "SELECT MAGIAOVIEN AS [MÃ GIÁO VIÊN], HOTEN AS [HỌ TÊN], SODIENTHOAI AS [ĐIỆN THOẠI]"+
                                        ", CHUYENMON AS[MÔN HỌC], GIOITINH AS[GIỚI TÍNH], NOISINH AS[NƠI SINH]  FROM dbo.GIAOVIEN";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dataGridViewGiaoVien.DataSource = dtDanhSach;
            conn.Close();

        }
    }
}
