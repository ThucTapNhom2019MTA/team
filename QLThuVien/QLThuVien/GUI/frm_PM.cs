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
    public partial class frm_PM : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dt = BUS.Select_PM();
        private int currenRowIndex;
        private readonly PhieuMuon pm;
        bool insert = false; bool update = false;
        public frm_PM()
        {
            InitializeComponent();
            pm = new PhieuMuon();
        }

        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaPM.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaPM"]).ToString();
            txt_NM.EditValue = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayTra"]);
            txt_NT.EditValue = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayTra"]);
            cmb_TenDG.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenDG"]).ToString();
            cmb_TenTS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTS"]).ToString();
            cmb_TenTT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTT"]).ToString();
            cmb_MaCS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaCS"]).ToString();
            txt_TT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TinhTrang"]).ToString();
        }

        private void frm_PM_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt;
            btn_save.Enabled = false; btn_cancel.Enabled = false;
            string sqlcs = "select *from CuonSach";
            cmb_MaCS.DataSource = DataProvider.GetData(sqlcs);
            cmb_MaCS.DisplayMember = "MaCS";
            string sqltt = "select *from ThuThu";
            cmb_TenTT.DataSource = DataProvider.GetData(sqltt);
            cmb_TenTT.DisplayMember = "TenTT";
            cmb_TenTT.ValueMember = "MaTT";
            string sqlts = "select *from TuaSach";
            cmb_TenTS.DataSource = DataProvider.GetData(sqlts);
            cmb_TenTS.DisplayMember = "TenTS";
            cmb_TenTS.ValueMember = "MaTS";
            string sqldg = "select *from DocGia";
            cmb_TenDG.DataSource = DataProvider.GetData(sqldg);
            cmb_TenDG.DisplayMember = "TenDG";
            cmb_TenDG.ValueMember = "MaDG";
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
            string std = string.Format("TenDG like '%{0}%'", txt_search.Text);
            dt.DefaultView.RowFilter = std;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {               
                    pm.MaPM = txt_MaPM.Text;
                    gridControl1.DataSource = BUS.Delete_PM(pm);
                    MessageBox.Show("Đã xóa thành công");
                    gridControl1.DataSource = BUS.Select_PM();
                    LoadData();
                
            }
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_update.Enabled = false;
            txt_MaPM.Enabled = true; btn_cancel.Enabled = true;
            insert = true; update = false;
            txt_MaPM.Text = ""; txt_TT.Text = ""; txt_NM.Text = ""; txt_NT.Text = "";
            cmb_TenDG.Text = ""; cmb_TenTS.Text = ""; cmb_TenTT.Text = ""; cmb_MaCS.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_insert.Enabled = false;
            update = true; btn_cancel.Enabled = true; cmb_MaCS.Enabled = false;
            insert = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            PhieuMuon pm2 = new PhieuMuon();
            pm2.MaPM = txt_MaPM.Text;
            pm2.NgayMuon= txt_NM.DateTime;
            pm2.NgayTra =  txt_NT.DateTime;
            pm2.MaDG = cmb_TenDG.SelectedValue.ToString();
            pm2.MaTT = cmb_TenTT.SelectedValue.ToString();
            ChiTietMuon ctm = new ChiTietMuon();
            ctm.MaPM = txt_MaPM.Text;
            ctm.MaCS = cmb_MaCS.Text;
            ctm.TinhTrang = txt_TT.Text;

            if (insert)
            {
                if (MessageBox.Show("Bạn muốn lưu dữ liệu được thêm mơi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable test = new DataTable(); //  kiểm tra mã đã  có trong bảng chưa???
                    string sql = "select *from PhieuMuon where MaPM= '" + txt_MaPM.Text + "'";
                    test = DataProvider.GetData(sql);
                    int i = test.Rows.Count;
                    if (i > 0)
                    {
                        BUS.Insert_CTM(ctm);
                        MessageBox.Show("Đã thêm chi tiết mượn vào  " + txt_MaPM.Text, "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControl1.DataSource = BUS.Select_PM();
                        LoadData();
                    }
                    else
                    {

                        BUS.Insert_PM(pm2);
                        BUS.Insert_CTM(ctm);
                        MessageBox.Show("Đã lưu thành công");
                        gridControl1.DataSource = BUS.Select_PM();
                        LoadData();
                    }
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn muốn lưu thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridControl1.DataSource = BUS.Update_PM(pm2);
                    gridControl1.DataSource = BUS.Update_CTM(ctm);
                    MessageBox.Show("Đã lưu thành công");
                    gridControl1.DataSource = BUS.Select_PM();
                    LoadData();
                }
            }
            txt_MaPM.Enabled = false; cmb_MaCS.Enabled = true;
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
                txt_MaPM.Enabled = false;
                btn_insert.Enabled = true;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                btn_save.Enabled = false;
                btn_cancel.Enabled = false;
                LoadData();
            }
        }

        private void cmb_MaCS_Click(object sender, EventArgs e)
        {
            string sql = "select MaCS from CuonSach where MaTS = '" + cmb_TenTS.SelectedValue.ToString() + "'";
            cmb_MaCS.DataSource = DataProvider.GetData(sql);
            cmb_MaCS.DisplayMember = "MaCS";
        }
    }
}
