using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLThuVien.BUSLayer;
using QLThuVien.DataAccessLayer;
using QLThuVien.ValueObject;
using System.Data.SqlClient;
using QLThuVien.Form_Info;
namespace QLThuVien.GUI
{
    public partial class frm_CS : DevExpress.XtraEditors.XtraUserControl
    {
        private int currenRowIndex;
        DataTable dt = BUS.Select_CS();
        private readonly CuonSach cs;
       
        public frm_CS()
        {
            InitializeComponent();
            cs = new CuonSach();
        }

        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaCS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaCS"]).ToString();
            txt_TenTS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTS"]).ToString();

        }
        private void frm_CS_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadData();
        }

        private void btn_TTTS_Click(object sender, EventArgs e)
        {
            frm_TTTS.MaTS = txt_MaCS.Text;
            frm_TTTS ttts = new frm_TTTS();
            ttts.ShowDialog();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string std = string.Format("TenTS like '%{0}%'", txt_search.Text);
            dt.DefaultView.RowFilter = std;

        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                BUS.Delete_CS(cs);
        }
    }
}
