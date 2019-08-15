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
    }
}
