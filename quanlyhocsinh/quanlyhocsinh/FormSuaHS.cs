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
    public partial class FormSuaHS : Form
    {
        public FormSuaHS()
        {
            InitializeComponent();
        }

        private void Bt_luu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "UPDATE dbo.GIAOVIEN SET HOTEN=@HOTEN,GIOITINH=@GIOITINH,NGAYSINH=@NGAYSINH,NOISINH=@NOISINH,CHUYENMON=@CHUYENMON,SODIENTHOAI=@SDT WHERE MAGIAOVIEN = @MAGV ";
            SqlCommand comm = new SqlCommand(strQueryDanhSach, conn);
            comm.Parameters.AddWithValue("@MANV", txt_magv.Text);
            comm.Parameters.AddWithValue("@HOTEN", txt_hoten.Text);
            comm.Parameters.AddWithValue("@GIOITINH", txt_gioitinh.Text);
            comm.Parameters.AddWithValue("@NGAYSINH", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            comm.Parameters.AddWithValue("@NOISINH", txt_noisinh.Text);
            comm.Parameters.AddWithValue("@CHUYENMON", txt_chuyenmon);
            comm.Parameters.AddWithValue("@SODIENTHOAI", txt_sdt.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công!", "Thông báo!");
            this.Close();
        }
    }
}
