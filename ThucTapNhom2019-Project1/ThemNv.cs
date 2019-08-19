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

namespace ThucTapNhom2019_Project1
{
    public partial class ThemNv : Form
    {
        public ThemNv()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txb_Manv.Text = "";
            txb_Hoten.Text = "";
            dateTimePicker1.Value = new DateTime(2000,1,1);
            txb_Diachi.Text = "";
            txb_Sodt.Text = "";
            txb_Email.Text = "";
            txb_Luong.Text = "";
            txb_Chucvu.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txb_Manv.Text != "" && txb_Hoten.Text != "" && txb_Diachi.Text != ""
                && txb_Sodt.Text != "" && txb_Luong.Text != "")
            {
                SqlConnection conn = ConnectSQLServer.getConnection();
                conn.Open();
                string query = "INSERT INTO [dbo].[NhanVien] (MaNhanvien,hoten,ngaysinh,diachi,sodienthoai,email,machucvu,luong) " +
                    "VALUES (@MaNv,@hoten,@ngaysinh,@diachi,@sodienthoai,@email,@machucvu,@luong)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@manv", this.txb_Manv.Text);
                command.Parameters.Add("@hoten", this.txb_Hoten.Text);
                command.Parameters.Add("@ngaysinh", this.dateTimePicker1.Value.ToString());
                command.Parameters.Add("@diachi", this.txb_Diachi.Text);
                command.Parameters.Add("@sodienthoai", this.txb_Sodt.Text);
                command.Parameters.Add("@email", this.txb_Email.Text);
                command.Parameters.Add("@machucvu", this.txb_Chucvu.Text);
                command.Parameters.Add("@luong", this.txb_Luong.Text);
                command.ExecuteNonQuery();
                conn.Close();
            }
            this.Dispose();
        }

        private void ThemNv_Load(object sender, EventArgs e)
        {

        }
    }
}
