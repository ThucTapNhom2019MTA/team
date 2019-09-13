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

namespace QLThuVien.GUI
{
    public partial class frm_NCC : DevExpress.XtraEditors.XtraUserControl
    {
        private int currenRowIndex;
        DataTable dt = BUS.Select_NCC();
        private readonly NCC ncc;
        bool insert = false;
        bool update = false;
        public frm_NCC()
        {
            InitializeComponent();
            ncc = new NCC();
        }

        #region
        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaNCC.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaNCC"]).ToString();
            txt_TenNCC.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenNCC"]).ToString();
            txt_DC.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["DiaChi"]).ToString();
            txt_SDT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SDT"]).ToString();
            txt_Email.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Email"]).ToString();
            }
        #endregion
        private void frm_NCC_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt;
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string std = string.Format("TenNCC like '%{0}%'", txt_search.Text);
            dt.DefaultView.RowFilter = std;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataTable kttt = new DataTable(); // kttt kiểm tra thông tin có trong bảng khác không???

                string sql = "select *from PhieuNhap where MaNCC= '" + txt_MaNCC.Text + "'";
                kttt = DataProvider.GetData(sql);
                int i = kttt.Rows.Count;
                if (i > 0)
                    MessageBox.Show("Dữ liệu  " +txt_MaNCC.Text+ " có trong bảng PhieuNhap!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ncc.MaNCC = txt_MaNCC.Text;
                    gridControl1.DataSource = BUS.Delete_NCC(ncc);
                    MessageBox.Show("Đã xóa thành công");
                    gridControl1.DataSource = BUS.Select_NCC();
                    LoadData();
                }
            }
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_update.Enabled = false;
            txt_MaNCC.Enabled = true; btn_cancel.Enabled = true;
            insert = true; update = false;
            txt_MaNCC.Text = ""; txt_TenNCC.Text = "";  txt_DC.Text = "";
            txt_Email.Text = ""; txt_SDT.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_insert.Enabled = false;
            update = true; btn_cancel.Enabled = true;
            insert = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            NCC ncc2 = new NCC();
            ncc2.MaNCC = txt_MaNCC.Text; ncc2.TenNCC = txt_TenNCC.Text;
            ncc2.SDT = txt_SDT.Text; ncc2.Email = txt_Email.Text;
            ncc2.DiaChi = txt_DC.Text;


            if (insert)
            {
                if (MessageBox.Show("Bạn muốn lưu dữ liệu được thêm mới không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable test = new DataTable(); //  kiểm tra mã đã  có trong bảng chưa???

                    string sql = "select *from NCC where MaNCC= '" + txt_MaNCC.Text + "'";
                    test = DataProvider.GetData(sql);
                    int i = test.Rows.Count;
                    if (i > 0)
                        MessageBox.Show("Đã tồn tại " + txt_MaNCC.Text, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        gridControl1.DataSource = BUS.Insert_NCC(ncc2);
                        MessageBox.Show("Đã lưu thành công");
                        gridControl1.DataSource = BUS.Select_NCC();
                        LoadData();
                    }
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn muốn lưu thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridControl1.DataSource = BUS.Update_NCC(ncc2);
                    MessageBox.Show("Đã lưu thành công");
                    gridControl1.DataSource = BUS.Select_NCC();
                    LoadData();
                }
            }
            txt_MaNCC.Enabled = false;
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
                txt_MaNCC.Enabled = false;
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
