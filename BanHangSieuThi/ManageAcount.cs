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
    public partial class ManageAcount : Form
    {
        public ManageAcount()
        {
            InitializeComponent();
            loadCbbData();
            loadDgvData();
        }

        private void loadDgvData()
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT TenNV,UserName,Password FROM dbo.ACOUNT,dbo.NHANVIEN WHERE ACOUNT.MaNV= NHANVIEN.MaNV";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dgvAccount.DataSource = dtDanhSach;
        }

        private void loadCbbData()
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT MaNV FROM dbo.NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            for (int i = 0; i < dtDanhSach.Rows.Count; i++)
            {
                cbbMaNhanVien.Items.Add(dtDanhSach.Rows[i][0].ToString());
            }
            cbbMaNhanVien.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            // them tai khoan
            conn.Open();
            string query = "INSERT INTO dbo.ACOUNT ( UserName, Password, MaNV ) VALUES (@UserName, @Password, @MaNV )";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaNV ", cbbMaNhanVien.Text);
            comm.Parameters.AddWithValue("@UserName", txbNameTk.Text);
            comm.Parameters.AddWithValue("@Password", txbMatKhau.Text);
            comm.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công", "Thông báo");
            conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            // xoa tai khoan
            conn.Open();
            string query = "DELETE FROM dbo.ACOUNT WHERE UserName=@UserName AND Password= @Password ";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@UserName", txbXoaTenTK.Text);
            comm.Parameters.AddWithValue("@Password", txbXoaMK.Text);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công", "Thông báo");
            conn.Close();
        }

        private void Connect()
        {
            SqlConnection conn = ConnectDB.getConnection();
            // xoa tai khoan
            conn.Open();
            string query = "DELETE FROM dbo.ACOUNT WHERE UserName=@UserName AND Password= @Password ";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@UserName", txbXoaTenTK.Text);
            comm.Parameters.AddWithValue("@Password", txbXoaMK.Text);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công", "Thông báo");
            conn.Close();
        }
    }
}
