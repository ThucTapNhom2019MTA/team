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
    
    public partial class Form1 : Form
    {
        public  static string MaNV = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string startTime = DateTime.Now.ToString("HH:mm:ss");
            SqlConnection conn = ConnectDB.getConnection();
            conn.Open();
            string query = "SELECT MaNV FROM dbo.ACOUNT WHERE UserName=@username AND Password=@password";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@username", txbUsername.Text);
            comm.Parameters.AddWithValue("@password", txbPassword.Text);
            MaNV = Convert.ToString(comm.ExecuteScalar()).Replace(" ","");
                if (MaNV != null)
                {
                    MainForm mainform = new MainForm();
                    this.Hide();
                    mainform.ShowDialog();
                    conn.Close();
                    conn.Open();
                    query = "INSERT INTO SUDUNGPM VALUES(GETDATE(),@startTime,@endTime,@maNV)";
                    comm = new SqlCommand(query, conn);
                    comm.Parameters.AddWithValue("@startTime", startTime);
                    comm.Parameters.AddWithValue("@endTime", DateTime.Now.ToString("HH:mm:ss"));
                    comm.Parameters.AddWithValue("@maNV",MaNV);
                    comm.ExecuteNonQuery();
                    this.Show();
            }
            conn.Close();
        }
    }
}
