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
using System.Data;

namespace QuanLyKhachSan.src
{
    public partial class frmDoDungCuaKhachSan : Form
    {
        public frmDoDungCuaKhachSan()
        {
            InitializeComponent();
        }
        BUS_DoDung dd = new BUS_DoDung();
        public void HienThi()
        {
            dgvDoDung.DataSource = dd.HienThiDoDung1();
        }

        private void dgvDoDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDD.Text = dgvDoDung.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDD.Text = dgvDoDung.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvDoDung.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonViTinh.Text = dgvDoDung.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGiaNhap.Text = dgvDoDung.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
