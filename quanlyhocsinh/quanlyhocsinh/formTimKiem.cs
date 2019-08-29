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

namespace quanlyhocsinh
{
    public partial class formTimKiem : Form
    {
        DataTable dtDanhSach;
        SqlConnection conn = constringsql.getConnection();
        public formTimKiem()
        {
            InitializeComponent();
        }

        private void formTimKiem_Load(object sender, EventArgs e)
        {
            conn.Open();
            string strQueryDanhSach = "SELECT MAHOCSINH AS [MÃ HỌC SINH], HOTEN AS [HỌ TÊN], GIOITINH AS [GIỚI TÍNH], NGAYSINH AS [NGÀY SINH], NOISINH AS [QUÊ QUÁN] FROM dbo.HOCSINH";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dataGridView1.DataSource = dtDanhSach;
            conn.Close();
        }
    }
}
