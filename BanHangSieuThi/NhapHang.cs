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
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            conn.Open();
            string query = "INSERT INTO HANGHOA ( MaHang, TenHang, LoaiHang, GiaTri, HanSuDung, SoLuong) " +
                "VALUES ( @MaHang, @TenHang, @LoaiHang, @GiaTri, @HanSuDung, @SoLuong )";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaHang", txbMaHang.Text);
            comm.Parameters.AddWithValue("@TenHang", txbTenHang.Text);
            comm.Parameters.AddWithValue("@LoaiHang", txbLoaiHang.Text);
            comm.Parameters.AddWithValue("@GiaTri", txbGiaTri.Text);
            comm.Parameters.AddWithValue("@HanSuDung", dtpHSD.Value.ToShortDateString());
            comm.Parameters.AddWithValue("@SoLuong", txbSoLuong.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
}
