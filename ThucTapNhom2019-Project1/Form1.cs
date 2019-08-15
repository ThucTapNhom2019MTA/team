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
    public partial class Form1 : Form
    {
        SqlConnection conn = ConnectSQLServer.getConnection();
        int soNhanVien;
        DataTable dtDanhSach;
        public Form1()
        {
            InitializeComponent();
            txPhong.Enabled = false;
            txTo.Enabled = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        public void ReloadForm(SqlConnection conn)
        {
            conn.Open();
            string strQueryDanhSach = "Select MaNhanVien as Mã, HoTen as [Họ và tên], " +
                "NgaySinh as [Ngày Sinh], DiaChi as [Địa Chỉ], SoDienThoai as [Số Điện Thoại], Email, " +
                "Luong as [Lương], TenChucVu AS [Tên chức vụ] from NhanVien, dbo.ChucVu " +
                "WHERE ChucVu.MaChucVu = NhanVien.MaChucVu";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dataGridView1.DataSource = dtDanhSach;
            soNhanVien = dtDanhSach.Rows.Count;
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadForm(conn);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            if (e.RowIndex <6 && e.RowIndex >=0) {
                string manv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string strQuery = "SELECT a.TenTo, b.TenPhong FROM (SELECT TenTo,MaNhanVien FROM [dbo].[To], dbo.NhanVien WHERE NhanVien.MaTo = [To].MaTo) AS a," +
            "(SELECT TenPhong, MaNhanVien FROM[To], Phong, dbo.NhanVien WHERE Phong.MaPhong = [To].MaPhong AND dbo.NhanVien.MaTo = [To].MaTo) AS b WHERE a.MaNhanVien = b.MaNhanVien and a.MaNhanVien = "+"'"+manv+"'";
                SqlDataAdapter da1 = new SqlDataAdapter(strQuery, conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                txPhong.Text = ds1.Tables[0].Rows[0]["TenPhong"].ToString();
                txTo.Text = ds1.Tables[0].Rows[0]["TenTo"].ToString();
            }
            conn.Close();
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            int selectRow = dataGridView1.SelectedRows[0].Index;
            if ( selectRow >= 0 && selectRow < dataGridView1.RowCount - 1)
            {
                string manv = dataGridView1.Rows[selectRow].Cells[0].Value.ToString();
                frmSuanv formSuanv = new frmSuanv(manv,selectRow, dataGridView1);
                formSuanv.ShowDialog();
                ReloadForm(conn);
            }
        }

    }
}
