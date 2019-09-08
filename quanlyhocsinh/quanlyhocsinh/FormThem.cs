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
    public partial class FormThem : Form
    {
        public FormThem()
        {
            InitializeComponent();
        }

        private void Bt_themHS_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string query = "INSERT INTO dbo.HOCSINH ( MAHOCSINH, HOTEN, GIOITINH, NGAYSINH, NOISINH ) VALUES (@MAHOCSINH, @HOTEN, @GIOITINH, @NGAYSINH, @NOISINH )";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MAHOCSINH", txt_mahs.Text);
            comm.Parameters.AddWithValue("@HOTEN", txt_hoten.Text);
            comm.Parameters.AddWithValue("@GIOITINH", txt_gioitinh.Text);
            comm.Parameters.AddWithValue("@NGAYSINH", dateTimePicker1.Text);
            comm.Parameters.AddWithValue("@NOISINH", txt_noisinh.Text);
            comm.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công", "Thông báo");
        }
    }
}
