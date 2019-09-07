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
    public partial class NhapHangCu : Form
    {
        public NhapHangCu()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT MaHang FROM dbo.HANGHOA";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            for(int i=0;i< dtDanhSach.Rows.Count; i++)
            {
                cbbMaHang.Items.Add(dtDanhSach.Rows[i][0].ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            conn.Open();
            // Nhập hàng
            string query = "INSERT INTO NHAPHANG ( MaHang, ThoiGian, SoLuong,MaNV) " +
                "VALUES ( @MaHang,@HanSuDung, @SoLuong,@MaNV )";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaHang", cbbMaHang.SelectedItem.ToString());
            comm.Parameters.AddWithValue("@HanSuDung", DateTime.Now.ToShortDateString());
            comm.Parameters.AddWithValue("@SoLuong", txbSoLuong.Text);
            comm.Parameters.AddWithValue("@MaNV", Form1.MaNV);
            comm.ExecuteNonQuery();
            conn.Close();
            // số lượng hàng hiện tại
            conn.Open();
            query = "SELECT SoLuong FROM dbo.HANGHOA WHERE MaHang = @MaHang";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaHang", cbbMaHang.SelectedItem.ToString());
            int soLuong = Convert.ToInt16(comm.ExecuteScalar());
            conn.Close();
            // thêm vào kho
            conn.Open();
            query = "UPDATE dbo.HANGHOA SET HanSuDung = @HanSuDung, SoLuong= @SoLuong WHERE MaHang = @MaHang";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaHang", cbbMaHang.SelectedItem.ToString());
            comm.Parameters.AddWithValue("@HanSuDung", dtpHSD.Value.ToShortDateString());
            comm.Parameters.AddWithValue("@SoLuong", ""+(Convert.ToInt16(txbSoLuong.Text)+soLuong));
            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thành công!","Thông báo");
            this.Close();
        }
    }
}
