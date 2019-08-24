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
    public partial class frmSuanv : Form
    {
        // sua nhan vien
        public frmSuanv(string maNv,int index,DataGridView datagv)
        {
            InitializeComponent();
            bindingChucVuTxtBox();
            txbManv.Text = maNv;
            txbHoten.Text = datagv.Rows[index].Cells[1].Value.ToString();
            dateTimePicker.Value = Convert.ToDateTime(datagv.Rows[index].Cells[2].Value.ToString());
            txbDiachi.Text = datagv.Rows[index].Cells[3].Value.ToString();
            txbSodienthoai.Text = datagv.Rows[index].Cells[4].Value.ToString();
            txbEmail.Text = datagv.Rows[index].Cells[5].Value.ToString();
            txbLuong.Text = datagv.Rows[index].Cells[6].Value.ToString();
            cbbChucvu.Text = datagv.Rows[index].Cells[7].Value.ToString();
        }

        public void bindingChucVuTxtBox()
        {
            SqlConnection conn = ConnectSQLServer.getConnection();
            conn.Open();
            string strQueryDanhSach = "SELECT TenChucVu FROM dbo.ChucVu";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            cbbChucvu.DataSource = dtDanhSach;
            cbbChucvu.DisplayMember = "TenChucVu";
            cbbChucvu.ValueMember = "TenChucVu";
            conn.Close();
        }

        private void btnSaveInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectSQLServer.getConnection();
            conn.Open();
            string strQueryDanhSach = "UPDATE dbo.NhanVien SET " +
                "MaChucVu = (SELECT MaChucVu FROM dbo.ChucVu WHERE TenChucVu = @ChucVu) " +
                "WHERE MaNhanVien = @MaNv";
            SqlCommand comm = new SqlCommand(strQueryDanhSach, conn);
            comm.Parameters.AddWithValue("@ChucVu", cbbChucvu.Text);
            comm.Parameters.AddWithValue("@MaNv", txbManv.Text);
            comm.ExecuteNonQuery();
            strQueryDanhSach = "UPDATE dbo.NhanVien SET HoTen=@HoTen,NgaySinh=@NgaySinh,DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,Email=@Email WHERE MaNhanVien = @MaNv ";
            comm = new SqlCommand(strQueryDanhSach, conn);
            comm.Parameters.AddWithValue("@MaNv", txbManv.Text);
            comm.Parameters.AddWithValue("@HoTen", txbHoten.Text);
            comm.Parameters.AddWithValue("@DiaChi", txbDiachi.Text);
            comm.Parameters.AddWithValue("@Email", txbEmail.Text);
            comm.Parameters.AddWithValue("@SoDienThoai", txbSodienthoai.Text);
            comm.Parameters.AddWithValue("@NgaySinh", dateTimePicker.Value.ToString("dd/MM/yyyy"));
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công!","Thông báo!");
            this.Close();
        }
    }
}
