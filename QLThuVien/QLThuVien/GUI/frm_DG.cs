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
using QLThuVien.ValueObject;
using System.Data.SqlClient;
using QLThuVien.DataAccessLayer;

namespace QLThuVien.GUI
{
    public partial class frm_DG : DevExpress.XtraEditors.XtraUserControl
    {
        private int currenRowIndex;
        private readonly DocGia dg;
        DataTable dt = BUS.Select_DG();
        bool insert = false;
        bool update = false;
        public frm_DG()
        {
            InitializeComponent();
            dg = new DocGia();
        }
        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaDG.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaDG"]).ToString();
            txt_TenDG.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenDG"]).ToString();
            cmb_GT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["GioiTinh"]).ToString();
            date_NS.EditValue = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgaySinh"]);
            txt_DC.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["DiaChi"]).ToString();
            txt_SDT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SDT"]).ToString();
        }
        private void frm_DG_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt;
            gridColumn6.Width = 80;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataTable kttt = new DataTable(); // kttt kiểm tra thông tin có trong bảng khác không???

                string sql = "select *from PhieuMuon where MaDG= '" + txt_MaDG.Text + "'";
                kttt = DataProvider.GetData(sql);
                int i = kttt.Rows.Count;
                if (i > 0)
                    MessageBox.Show("Dữ liệu " + txt_MaDG.Text + " có trong bảng PhieuMuon!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    dg.MaDG = txt_MaDG.Text;
                    gridControl1.DataSource = BUS.Delete_DG(dg);
                    MessageBox.Show("Đã xóa thành công");
                    gridControl1.DataSource = BUS.Select_DG();
                    LoadData();
                }
            }
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string std = string.Format("TenDG like '%{0}%'", txt_search.Text);
            dt.DefaultView.RowFilter = std;
           
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_update.Enabled = false;
            txt_MaDG.Enabled = true; btn_cancel.Enabled = true;
            insert = true; update = false;
            txt_MaDG.Text = ""; txt_TenDG.Text = ""; cmb_GT.Text = "";
            date_NS.Text = ""; txt_SDT.Text = ""; txt_DC.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_insert.Enabled = false;
            update = true; btn_cancel.Enabled = true;
            insert = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DocGia dg2 = new DocGia();
            dg2.MaDG = txt_MaDG.Text; dg2.TenDG = txt_TenDG.Text;
            dg2.NgaySinh = date_NS.DateTime; dg2.GioiTinh = cmb_GT.Text;
            dg2.SDT = txt_SDT.Text; dg2.DiaChi = txt_DC.Text;

            if (insert)
            {
                if (MessageBox.Show("Bạn muốn lưu dữ liệu được thêm mơi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable test = new DataTable(); //  kiểm tra mã đã  có trong bảng chưa???

                    string sql = "select *from DocGia where MaDG= '" + txt_MaDG.Text + "'";
                    test = DataProvider.GetData(sql);
                    int i = test.Rows.Count;
                    if (i > 0)
                        MessageBox.Show("Đã tồn tại " + txt_MaDG.Text, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        gridControl1.DataSource = BUS.Insert_DG(dg2);
                        MessageBox.Show("Đã lưu thành công");
                        gridControl1.DataSource = BUS.Select_DG();
                        LoadData();
                    }
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn muốn lưu thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridControl1.DataSource = BUS.Update_DG(dg2);
                    MessageBox.Show("Đã lưu thành công");
                    gridControl1.DataSource = BUS.Select_DG();
                    LoadData();
                }
            }
            txt_MaDG.Enabled = false;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
            btn_insert.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy hay không", "Hủy thay đổi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                txt_MaDG.Enabled = false;
                btn_insert.Enabled = true;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                btn_save.Enabled = false;
                btn_cancel.Enabled = false;
                LoadData();
            }
        }
    }
}
