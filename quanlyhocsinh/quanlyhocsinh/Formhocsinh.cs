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
    public partial class Formhocsinh : Form
    {
        public Formhocsinh()
        {
            InitializeComponent();
        }

        private void Formhocsinh_Load(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "SELECT MAHOCSINH AS [MÃ HỌC SINH], HOTEN AS [HỌ TÊN], GIOITINH AS [GIỚI TÍNH], NGAYSINH AS [NGÀY SINH], NOISINH AS [QUÊ QUÁN] FROM dbo.HOCSINH";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dataGridViewHocSinh.DataSource = dtDanhSach;
            conn.Close();
        }

        private void bt_timkiemhs_Click(object sender, EventArgs e)
        {
            formTimKiem form = new formTimKiem();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Bt_themhs_Click(object sender, EventArgs e)
        {
            FormThem ft = new FormThem();
            ft.Show();
            this.Hide();
        }

        private void Bt_suahs_Click(object sender, EventArgs e)
        {
            int selectRow = dataGridViewHocSinh.SelectedRows[0].Index;
            if (selectRow >= 0 && selectRow < dataGridViewHocSinh.RowCount - 1)
            {
                string manv = dataGridViewHocSinh.Rows[selectRow].Cells[0].Value.ToString();
                FormSuaGV formSuanv = new FormSuaGV(manv, selectRow, dataGridViewHocSinh);
                formSuanv.ShowDialog();
            }
        }
    }
}
