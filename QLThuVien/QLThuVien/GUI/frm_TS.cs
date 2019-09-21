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
using QLThuVien.DataAccessLayer;

namespace QLThuVien.GUI
{
    public partial class frm_TS : DevExpress.XtraEditors.XtraUserControl
    {
        private int currenRowIndex;
        DataTable dt = BUS.Select_TS();
        private readonly TuaSach ts;
        bool insert = false;
        bool update = false;
        public frm_TS()
        {
            InitializeComponent();
            ts = new TuaSach();
        }

        #region
        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaTS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaTS"]).ToString();
            txt_TenTS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTS"]).ToString();
            txt_TL.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TheLoai"]).ToString();
            txt_XB.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NamXB"]).ToString();
            txt_SL.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SoLuong"]).ToString();
            txt_ST.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SoTrang"]).ToString();
            cmb_TG.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTG"]).ToString();
            cmb_KS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaKe"]).ToString();
            cmb_NXB.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenNXB"]).ToString();
        }
        #endregion
        private void frm_TS_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
            string sqltg = "select *from TacGia";
            cmb_TG.DataSource = DataProvider.GetData(sqltg);
            cmb_TG.DisplayMember = "TenTG";
            cmb_TG.ValueMember = "MaTG";
            string sqlnxb = "select *from NXB";
            cmb_NXB.DataSource = DataProvider.GetData(sqlnxb);
            cmb_NXB.DisplayMember = "TenNXB";
            cmb_NXB.ValueMember = "MaNXB";
            string sqlks = "select *from KeSach";
            cmb_KS.DataSource = DataProvider.GetData(sqlks);
            cmb_KS.DisplayMember = "MaKe";
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
            string std = string.Format("TenTS like '%{0}%'", txt_search.Text);
            dt.DefaultView.RowFilter = std;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataTable kttt = new DataTable(); // kttt kiểm tra thông tin có trong bảng khác không???

                string sql = "select *from CuonSach where MaTS= '" + txt_MaTS.Text + "'";
                kttt = DataProvider.GetData(sql);
                int i = kttt.Rows.Count;
                if (i > 0)
                    MessageBox.Show("Dữ liệu " + txt_MaTS.Text + " có trong bảng CuonSach!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ts.MaTS = txt_MaTS.Text;
                    gridControl1.DataSource = BUS.Delete_TS(ts);
                    MessageBox.Show("Đã xóa thành công");
                    gridControl1.DataSource = BUS.Select_TS();
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
            txt_MaTS.Enabled = true; btn_cancel.Enabled = true; txt_SL.Enabled = true;
            insert = true; update = false;
            txt_MaTS.Text = ""; txt_TenTS.Text = ""; txt_TL.Text = ""; txt_XB.Text = "";
            cmb_TG.Text = ""; txt_SL.Text = ""; txt_ST.Text = ""; cmb_KS.Text = "";
            cmb_NXB.Text = "";

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_insert.Enabled = false;
            update = true; btn_cancel.Enabled = true;
            insert = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            TuaSach ts2 = new TuaSach();
            ts2.MaTS = txt_MaTS.Text; ts2.TenTS = txt_TenTS.Text;
            ts2.NamXB = int.Parse( txt_XB.Text) ; ts2.TheLoai = txt_TL.Text;
            ts2.MaNXB = cmb_NXB.SelectedValue.ToString(); ts2.MaKe = cmb_KS.Text;
            ts2.SoLuong=txt_SL.Text;
            Viet v = new Viet();
            v.MaTS = txt_MaTS.Text;
            v.MaTG = cmb_TG.SelectedValue.ToString();
            v.SoTrang = int.Parse(txt_ST.Text);

            if (insert)
            {
                if (MessageBox.Show("Bạn muốn lưu dữ liệu được thêm mơi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable test = new DataTable(); //  kiểm tra mã đã  có trong bảng chưa???

                    string sql = "select *from TuaSach where MaTS= '" + txt_MaTS.Text + "'";
                    test = DataProvider.GetData(sql);
                    int i = test.Rows.Count;
                    if (i > 0)
                        MessageBox.Show("Đã tồn tại " + txt_MaTS.Text, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                       
                        BUS.Insert_TS(ts2);
                        BUS.Insert_Viet(v);
                        MessageBox.Show("Đã lưu thành công");
                        gridControl1.DataSource = BUS.Select_TS();
                        LoadData();
                    }
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn muốn lưu thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridControl1.DataSource = BUS.Update_TS(ts2);
                    gridControl1.DataSource = BUS.Update_Viet(v);
                    MessageBox.Show("Đã lưu thành công");
                    gridControl1.DataSource = BUS.Select_TS();
                    LoadData();
                }
            }
            txt_MaTS.Enabled = false; txt_SL.Enabled = false;
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
                txt_MaTS.Enabled = false; txt_SL.Enabled = false;
                btn_insert.Enabled = true;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                btn_save.Enabled = false;
                btn_cancel.Enabled = false;
                LoadData();
            }
        }

        private void txt_XB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_ST_KeyPress(object sender, KeyPressEventArgs e)
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
