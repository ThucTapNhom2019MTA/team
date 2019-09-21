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
        public FormSuaHS(string mahs, int index, DataGridView datagv)
        {
            InitializeComponent();
            InitializeComponent();
            txt_hoten.Text = datagv.Rows[index].Cells[1].Value.ToString();
            txt_gioitinh.Text = datagv.Rows[index].Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(datagv.Rows[index].Cells[2].Value.ToString());
            txt_quequan.Text = datagv.Rows[index].Cells[4].Value.ToString();
        }

        private void Bt_luu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "UPDATE dbo.HOCSINH SET HOTEN=@HOTEN,GIOITINH=@GIOITINH,NGAYSINH=@NGAYSINH,NOISINH=@NOISINH,CHUYENMON=@CHUYENMON,SODIENTHOAI=@SDT WHERE MAHS= = @MAHS  ";
            SqlCommand comm = new SqlCommand(strQueryDanhSach, conn);
            comm.Parameters.AddWithValue("@MAHS", txt_mahs.Text);
            comm.Parameters.AddWithValue("@HOTEN", txt_hoten.Text);
            comm.Parameters.AddWithValue("@GIOITINH", txt_gioitinh.Text);
            comm.Parameters.AddWithValue("@NGAYSINH", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            comm.Parameters.AddWithValue("@QUEQUAN", txt_quequan.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công!", "Thông báo!");
            this.Close();
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formhocsinh fhs = new Formhocsinh();
            fhs.ShowDialog();
        }
    }
}
