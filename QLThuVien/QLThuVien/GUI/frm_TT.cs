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
using System.Xml;
using QLThuVien.ValueObject;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Mask;
using QLThuVien.DataAccessLayer;

namespace QLThuVien.GUI
{
    public partial class frm_TT : DevExpress.XtraEditors.XtraUserControl
    {

        private int currenRowIndex;      //vị trí chọn o trong gridControl
        private readonly ThuThu tt;
        DataTable dt = BUS.Select_TT();
        bool insert = false;
        bool update = false;
        public frm_TT()
        {
            InitializeComponent();
            tt = new ThuThu();
        }
        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaTT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaTT"]).ToString();
            txt_TenTT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTT"]).ToString();
            date_NS.EditValue = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgaySinh"]);
            cmb_GT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["GioiTinh"]).ToString();
            txt_DC.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["DiaChi"]).ToString();
            txt_SDT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SDT"]).ToString();
            txt_CV.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Chucvu"]).ToString();

        }

        private void frm_TT_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
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
              
                string sql = "select *from PhieuNhap where MaTT= '" + txt_MaTT.Text + "'";
                kttt = DataProvider.GetData(sql);
                int i = kttt.Rows.Count;
                if (i > 0)
                    MessageBox.Show("Dữ liệu " +txt_MaTT.Text+" có trong bảng PhieuNhap!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    tt.MaTT = txt_MaTT.Text;
                    gridControl1.DataSource = BUS.Delete_TT(tt);
                    MessageBox.Show("Đã xóa thành công");
                    gridControl1.DataSource = BUS.Select_TT();
                    LoadData();
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string std = string.Format("TenTT like '%{0}%'", txt_search.Text);
            dt.DefaultView.RowFilter = std;
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_update.Enabled = false;
            txt_MaTT.Enabled = true; btn_cancel.Enabled = true;
            insert = true; update = false;
            txt_MaTT.Text = "";txt_TenTT.Text = "";txt_SDT.Text = "";txt_DC.Text = "";
            cmb_GT.Text = ""; txt_CV.Text = ""; date_NS.Text = "";
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_insert.Enabled = false;
            update = true; btn_cancel.Enabled = true;
            insert = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ThuThu tt2 = new ThuThu();
            tt2.MaTT = txt_MaTT.Text; tt2.TenTT = txt_TenTT.Text;
            tt2.NgaySinh = date_NS.DateTime; tt2.GioiTinh = cmb_GT.Text;
            tt2.SDT = txt_SDT.Text; tt2.ChucVu = txt_CV.Text;
            tt2.DiaChi = txt_DC.Text;


            if (insert)
            {
                if (MessageBox.Show("Bạn muốn lưu dữ liệu được thêm mơi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable test = new DataTable(); //  kiểm tra mã đã  có trong bảng chưa???

                    string sql = "select *from ThuThu where MaTT= '" + txt_MaTT.Text + "'";
                    test = DataProvider.GetData(sql);
                    int i = test.Rows.Count;
                    if (i > 0)
                        MessageBox.Show("Đã tồn tại "+txt_MaTT.Text, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        gridControl1.DataSource = BUS.Insert_TT(tt2);
                        MessageBox.Show("Đã lưu thành công");
                        gridControl1.DataSource = BUS.Select_TT();
                        LoadData();
                    }
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn muốn lưu thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridControl1.DataSource = BUS.Update_TT(tt2);
                    MessageBox.Show("Đã lưu thành công");
                    gridControl1.DataSource = BUS.Select_TT();
                    LoadData();
                }
            }
            txt_MaTT.Enabled = false;
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
                txt_MaTT.Enabled = false;
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
