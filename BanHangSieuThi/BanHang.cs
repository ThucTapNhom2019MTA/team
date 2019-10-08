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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
            lbTongTien.Visible = false;
            txbTongTien.Visible = false;
            txbMaKH.Text = Form1.CreatePassword(10);
            FillData();
        }

        private void FillData()
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT MaHang FROM dbo.HANGHOA";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            for (int i = 0; i < dtDanhSach.Rows.Count; i++)
            {
                cbbMaMatHang.Items.Add(dtDanhSach.Rows[i][0].ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int index = dgvHienThi.Rows.Add();
            dgvHienThi.Rows[index].Cells[0].Value = cbbMaMatHang.SelectedItem.ToString();
            dgvHienThi.Rows[index].Cells[1].Value = txbSoLuong.Text;
        }

        private int priceOfMatHang(string MaMH)
        {
            SqlConnection conn = ConnectDB.getConnection();
            conn.Open();
            string query = "SELECT GiaTri FROM dbo.HANGHOA WHERE MaHang = @MaHang";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaHang", MaMH);
            int price =  Convert.ToInt16(comm.ExecuteScalar());
            conn.Close();
            return price;
        }

        private void insertChiTietHoaDon(SqlConnection conn,string MaHang,int GiaTri,string MaHoaDon)
        {
            conn.Open();
            string query = "INSERT INTO dbo.CHITIETHOADON ( MaCTHD, MaHang, GiaTri, MaHoaDon ) VALUES( @MaCTHD, @MaHang, @GiaTri, @MaHoaDon )";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaCTHD ", Form1.CreatePassword(10));
            comm.Parameters.AddWithValue("@MaHang", MaHang);
            comm.Parameters.AddWithValue("@GiaTri", ""+GiaTri);
            comm.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            comm.ExecuteNonQuery();
            conn.Close();
        }


        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            // khach hang
            conn.Open();
            string query = "INSERT INTO dbo.KHACHHANG ( MaKH, GioiTinh, Tuoi ) VALUES (@MaKH, @GioiTinh, @Tuoi )";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaKH ", txbMaKH.Text);
            comm.Parameters.AddWithValue("@GioiTinh", txbGioiTinh.Text);
            comm.Parameters.AddWithValue("@Tuoi", txbDoTuoi.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            // khach hang - mat hang
            conn.Open();
            query = "INSERT INTO dbo.MUAHANG ( MaKH, MaHang, SoLuong ) VALUES ( @MaKH, @MaHang, @SoLuong )";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaKH ", txbMaKH.Text);
            comm.Parameters.AddWithValue("@MaHang", cbbMaMatHang.SelectedItem.ToString());
            comm.Parameters.AddWithValue("@SoLuong", txbSoLuong.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            string MaHD = Form1.CreatePassword(10);
            // hoa don
            conn.Open();
            query = "INSERT INTO dbo.HOADON ( MaHoaDon, TongTien ) VALUES ( @MaHoaDon, @TongTien )";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaHoaDon", MaHD);
            comm.Parameters.AddWithValue("@TongTien", "");
            comm.ExecuteNonQuery();
            conn.Close();

            // khach hang - nhan vien - hoa don
            conn.Open();
            query = "INSERT INTO dbo.LAPHOADON ( NgayLap, MaKH, MaNV, MaHoaDon, ThoiGianLap ) " +
                "VALUES (@NgayLap, @MaKH, @MaNV, @MaHoaDon, @ThoiGianLap )";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@NgayLap ", ""+ DateTime.Now.ToShortDateString());
            comm.Parameters.AddWithValue("@MaKH ", txbMaKH.Text);
            comm.Parameters.AddWithValue("@MaNV", Form1.MaNV);
            comm.Parameters.AddWithValue("@MaHoaDon", MaHD);
            comm.Parameters.AddWithValue("@ThoiGianLap", DateTime.Now.ToShortTimeString());
            comm.ExecuteNonQuery();
            conn.Close();
            
            // ChiTietHoaDon
            int sum = 0;
            for (int i = 0; i < dgvHienThi.Rows.Count; i++)
            {
                string MaMH = dgvHienThi.Rows[i].Cells[0].Value.ToString();
                int SoLuong =Convert.ToInt16(dgvHienThi.Rows[i].Cells[1].Value);
                int price = priceOfMatHang(MaMH);
                sum = sum + price;
                insertChiTietHoaDon(conn,MaMH,price,MaHD);
                // update HangHoa
                conn.Open();
                query = "UPDATESOLUONG";
                comm = new SqlCommand(query, conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@SoLuong", SoLuong);
                comm.Parameters.AddWithValue("@MaHang", "" + MaMH);
                comm.ExecuteNonQuery();
                conn.Close();
            }

            // hoa don
            conn.Open();
            query = "UPDATE dbo.HOADON SET TongTien=@TongTien WHERE MaHoaDon=@MaHoaDon";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaHoaDon", MaHD);
            comm.Parameters.AddWithValue("@TongTien", ""+sum);
            comm.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Thêm thành công!", "Thông báo");
            // in hoa don
            lbTongTien.Visible = true;
            txbTongTien.Text = "" + sum;
            txbTongTien.Visible = true;
            btnThem.Visible = false;
            btnInHoaDon.Visible = false;
            
        }
        public void alert(string message,string caption)
        {
            MessageBox.Show(message, caption);
        }
    }
}