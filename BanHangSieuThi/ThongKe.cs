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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            if (cbbThongKe.SelectedIndex == 1)
            {
                lbEndTime.Visible = true;
                lbStartTime.Visible = true;
                dtpEndTime.Visible = true;
                dtpStartTime.Visible = true;
                chart2.Visible = true;
            }
            else
            {
                chart2.Visible = false;
                lbEndTime.Visible = false;
                lbStartTime.Visible = false;
                dtpEndTime.Visible = false;
                dtpStartTime.Visible = false;
                loadChart();
            }
            LoadChartLuuLuong();
        }

        private void loadChart()
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT TenHang,SoLuong FROM dbo.HANGHOA";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            for(int i = 0; i < dtDanhSach.Rows.Count; i++)
            {
                string name = dtDanhSach.Rows[i][0].ToString();
                int value = Convert.ToInt16(dtDanhSach.Rows[i][1].ToString());
                chart1.Series["HangHoa"].Points.AddXY(name, value);
            }
        }

        private void LoadChartLuuLuong()
        {
            LoadChartNhap(dtpStartTime.Value.ToShortDateString(),dtpEndTime.Value.ToShortDateString());
            LoadChartXuat(dtpStartTime.Value.ToShortDateString(), dtpEndTime.Value.ToShortDateString());
        }

        private void LoadChartXuat(string startTime, string endTime)
        {
            SqlConnection conn = ConnectDB.getConnection();
            //conn.Open();
            string query = "SELECT TenHang,SUM(SoLuong) AS SoLuong FROM dbo.XUATHANG WHERE NgayLap>=@StartTime AND NgayLap<=@EndTime GROUP BY TenHang";
            SqlCommand comm = new SqlCommand(query, conn);
            //comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@StartTime", startTime);
            comm.Parameters.AddWithValue("@EndTime", endTime);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            for (int i = 0; i < dtDanhSach.Rows.Count; i++)
            {
                string name = dtDanhSach.Rows[i][0].ToString();
                int value = Convert.ToInt16(dtDanhSach.Rows[i][1].ToString());
                chart2.Series["Lưu lượng xuất"].Points.AddXY(name, value);
            }
            //conn.Close();
        }
        private void LoadChartNhap(string startTime, string endTime)
        {
            SqlConnection conn = ConnectDB.getConnection();
            conn.Open();
            string query = "SELECT ten,Sum(soluong) FROM dbo.ThongKe(@StartTime,@EndTime) GROUP BY ten";
            SqlCommand comm = new SqlCommand(query, conn);
            //comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@StartTime", startTime);
            comm.Parameters.AddWithValue("@EndTime",endTime);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            for (int i = 0; i < dtDanhSach.Rows.Count; i++)
            {
                string name = dtDanhSach.Rows[i][0].ToString();
                int value = Convert.ToInt16(dtDanhSach.Rows[i][1].ToString());
                chart2.Series["Lưu lượng nhập"].Points.AddXY(name, value);
            }
            conn.Close();
        }

        private void cbbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThongKe.SelectedIndex == 1)
            {
                lbEndTime.Visible = true;
                lbStartTime.Visible = true;
                dtpEndTime.Visible = true;
                dtpStartTime.Visible = true;
                chart1.Visible = false;
                chart2.Visible = true;
            }
            else
            {
                lbEndTime.Visible = false;
                lbStartTime.Visible = false;
                dtpEndTime.Visible = false;
                dtpStartTime.Visible = false;
                chart1.Visible = true;
                chart2.Visible = false;
            }
        }
    }
}
