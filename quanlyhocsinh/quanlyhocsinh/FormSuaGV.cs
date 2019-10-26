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
    public partial class FormSuaGV : Form
    {
        public FormSuaGV(string manv, int index, DataGridView datagv)
        {
            InitializeComponent();
            txt_hoten.Text = datagv.Rows[index].Cells[1].Value.ToString();
            txt_sdt.Text = datagv.Rows[index].Cells[2].Value.ToString();
            txt_chuyenmon.Text = datagv.Rows[index].Cells[3].Value.ToString();
            txt_gioitinh.Text = datagv.Rows[index].Cells[4].Value.ToString();
            txt_noisinh.Text = datagv.Rows[index].Cells[5].Value.ToString();
//            txt_chuyenmon.Text = datagv.Rows[index].Cells[5].Value.ToString();
//            txt_sdt.Text = datagv.Rows[index].Cells[6].Value.ToString();
        }

        private void Bt_luu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "UPDATE dbo.GIAOVIEN SET HOTEN=@HOTEN,SODIENTHOAI=@SODIENTHOAI,CHUYENMON=@CHUYENMON,GIOITINH=@GIOITINH,NOISINH=@NOISINH WHERE MAGIAOVIEN = @MAGV ";
            SqlCommand comm = new SqlCommand(strQueryDanhSach, conn);
            comm.Parameters.AddWithValue("@MAGV", txt_magv.Text);
            comm.Parameters.AddWithValue("@HOTEN", txt_hoten.Text);
            comm.Parameters.AddWithValue("@GIOITINH", txt_gioitinh.Text);
            comm.Parameters.AddWithValue("@NOISINH", txt_noisinh.Text);
            comm.Parameters.AddWithValue("@CHUYENMON", txt_chuyenmon);
            comm.Parameters.AddWithValue("@SODIENTHOAI", txt_sdt.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công!", "Thông báo!");
            this.Close();
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formgiaovien fgv = new Formgiaovien();
            this.ShowDialog();
        }
    }
}
