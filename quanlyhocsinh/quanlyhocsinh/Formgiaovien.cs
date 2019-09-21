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
    public partial class Formgiaovien : Form
    {
        DataTable dtDanhSach;
        string magiaovien;
        string tengiaovien;
        public Formgiaovien()
        {
            InitializeComponent();
            dataGridViewGiaoVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Formgiaovien_Load(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "SELECT MAGIAOVIEN AS [MÃ GIÁO VIÊN], HOTEN AS [HỌ TÊN], SODIENTHOAI AS [ĐIỆN THOẠI]"+
                                        ", CHUYENMON AS[MÔN HỌC], GIOITINH AS[GIỚI TÍNH], NOISINH AS[NƠI SINH]  FROM dbo.GIAOVIEN";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dataGridViewGiaoVien.DataSource = dtDanhSach;
            conn.Close();
        }

        private void bt_timkiemgv_Click(object sender, EventArgs e)
        {
            formTimKiem form = new formTimKiem();
            form.Show();
            this.Hide();
        }

        private void Bt_themgv_Click(object sender, EventArgs e)
        {
            FormThemGV form = new FormThemGV();
            form.Show();
            this.Hide();
        }

        private void Bt_suagv_Click(object sender, EventArgs e)
        {
            int selectRow = dataGridViewGiaoVien.SelectedRows[0].Index;
            if (selectRow >= 0 && selectRow < dataGridViewGiaoVien.RowCount - 1)
            {
                string magv = dataGridViewGiaoVien.Rows[selectRow].Cells[0].Value.ToString();
                FormSuaGV formSuagv = new FormSuaGV(magv, selectRow, dataGridViewGiaoVien);
                formSuagv.ShowDialog();
            }
        }

        private void Bt_xoagv_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa giáo viên : " + tengiaovien, "Xóa giáo viên",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                string query = "DELETE FROM [dbo].[GIAOVIEN] WHERE MAGIAOVIEN = " + "'" + magiaovien + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.ExecuteNonQuery();

                string strQueryDanhSach = "SELECT MAGIAOVIEN AS [MÃ GIÁO VIÊN], HOTEN AS [HỌ TÊN], SODIENTHOAI AS [ĐIỆN THOẠI]" +
                                            ", CHUYENMON AS[MÔN HỌC], GIOITINH AS[GIỚI TÍNH], NOISINH AS[NƠI SINH]  FROM dbo.GIAOVIEN";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridViewGiaoVien.DataSource = dtDanhSach;
                conn.Close();
            }
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void DataGridViewGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            if (e.RowIndex < 6 && e.RowIndex >= 0)
            {
                string magv = dataGridViewGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                tengiaovien = dataGridViewGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                magiaovien = magv;
            }
            conn.Close();
        }
    }
}
