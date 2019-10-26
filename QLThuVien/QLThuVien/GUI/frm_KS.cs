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
    public partial class frm_KS : DevExpress.XtraEditors.XtraUserControl
    {
        private int currenRowIndex;
        DataTable dt = BUS.Select_KeSach();
        private readonly KeSach ks;
        bool insert = false;
        bool update = false;
        public frm_KS()
        {
            InitializeComponent();
            ks = new KeSach();
        }


        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaKe.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaKe"]).ToString();
            txt_CL.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["ChatLieu"]).ToString();
            txt_SC.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SucChua"]).ToString();
            txt_SL.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SL"]).ToString();
           }
        private void frm_KS_Load(object sender, EventArgs e)
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
            string std = string.Format("MaKe like '%{0}%'", txt_search.Text);
            dt.DefaultView.RowFilter = std;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataTable kttt = new DataTable(); // kttt kiểm tra thông tin có trong bảng khác không???

                string sql = "select *from TuaSach where MaKe= '" + txt_MaKe.Text + "'";
                kttt = DataProvider.GetData(sql);
                int i = kttt.Rows.Count;
                if (i > 0)
                    MessageBox.Show("Dữ liệu " + txt_MaKe.Text + " có trong bảng TuaSach!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ks.MaKe = txt_MaKe.Text;
                    gridControl1.DataSource = BUS.Delete_KeSach(ks);
                    MessageBox.Show("Đã xóa thành công");
                    gridControl1.DataSource = BUS.Select_KeSach();
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
            txt_MaKe.Enabled = true; btn_cancel.Enabled = true;
            insert = true; update = false;
            txt_MaKe.Text = ""; txt_CL.Text = ""; txt_SC.Text = ""; txt_SL.Text = "";
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_insert.Enabled = false;
            update = true; btn_cancel.Enabled = true;
            insert = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            KeSach ks2 = new KeSach();
            ks2.MaKe = txt_MaKe.Text; ks2.ChatLieu = txt_CL.Text;
            ks2.SucChua = txt_SC.Text;


            if (insert)
            {
                if (MessageBox.Show("Bạn muốn lưu dữ liệu được thêm mơi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable test = new DataTable(); //  kiểm tra mã đã  có trong bảng chưa???

                    string sql = "select *from KeSach where MaKe= '" + txt_MaKe.Text + "'";
                    test = DataProvider.GetData(sql);
                    int i = test.Rows.Count;
                    if (i > 0)
                        MessageBox.Show("Đã tồn tại " + txt_MaKe.Text, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        gridControl1.DataSource = BUS.Insert_KeSach(ks2);
                        MessageBox.Show("Đã lưu thành công");
                        gridControl1.DataSource = BUS.Select_KeSach();
                        LoadData();
                    }
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn muốn lưu thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridControl1.DataSource = BUS.Update_KeSach(ks2);
                    MessageBox.Show("Đã lưu thành công");
                    gridControl1.DataSource = BUS.Select_KeSach();
                    LoadData();
                }
            }
            txt_MaKe.Enabled = false;
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
                txt_MaKe.Enabled = false;
                btn_insert.Enabled = true;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                btn_save.Enabled = false;
                btn_cancel.Enabled = false;
                LoadData();
            }
        }

        private void txt_SC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
