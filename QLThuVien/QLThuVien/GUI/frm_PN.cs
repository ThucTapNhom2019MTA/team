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
    public partial class frm_PN : DevExpress.XtraEditors.XtraUserControl
    {
        private int currenRowIndex;
        DataTable dt = BUS.Select_PN();
        private readonly PhieuNhap pn;
        bool insert = false;
        bool update = false;

        public frm_PN()
        {
            InitializeComponent();
            pn = new PhieuNhap();
        }

        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaPN.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaPN"]).ToString();
            txt_SL.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SoLuong"]).ToString();
            txt_Gia.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["DonGia"]).ToString();
            txt_Tong.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TongTien"]).ToString();
            cmb_TenTS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTS"]).ToString();
            cmb_TenTT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTT"]).ToString();
            cmb_NCC.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenNCC"]).ToString();
            date_NL.EditValue = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayLap"]);
            txt_TT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TT"]).ToString();
            
        }
        private void frm_PN_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt;
            btn_save.Enabled = false; btn_cancel.Enabled = false;           
            string sqltt = "select *from ThuThu";
            cmb_TenTT.DataSource = DataProvider.GetData(sqltt);
            cmb_TenTT.DisplayMember = "TenTT";
            cmb_TenTT.ValueMember = "MaTT";
            string sqlts = "select *from TuaSach";
            cmb_TenTS.DataSource = DataProvider.GetData(sqlts);
            cmb_TenTS.DisplayMember = "TenTS";
            cmb_TenTS.ValueMember = "MaTS";
            string sqlncc = "select *from NCC";
            cmb_NCC.DataSource = DataProvider.GetData(sqlncc);
            cmb_NCC.DisplayMember = "TenNCC";
            cmb_NCC.ValueMember = "MaNCC";
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
                pn.MaPN = txt_MaPN.Text;
                gridControl1.DataSource = BUS.Delete_PN(pn);
                MessageBox.Show("Đã xóa thành công");
                gridControl1.DataSource = BUS.Select_PN();
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
            txt_MaPN.Enabled = true; btn_cancel.Enabled = true;
            insert = true; update = false;
            txt_MaPN.Text = ""; date_NL.Text = ""; 
            cmb_NCC.Text = ""; cmb_TenTS.Text = ""; cmb_TenTT.Text = "";
            txt_SL.Text = ""; txt_Gia.Text = ""; txt_TT.Text = ""; txt_Tong.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_insert.Enabled = false;
            update = true; btn_cancel.Enabled = true;
            insert = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy hay không", "Hủy thay đổi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                txt_MaPN.Enabled = false;
                btn_insert.Enabled = true;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                btn_save.Enabled = false;
                btn_cancel.Enabled = false;
                LoadData();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            PhieuNhap pn2 = new PhieuNhap();
            pn2.MaPN = txt_MaPN.Text; 
            pn2.NgayLap = date_NL.DateTime;
            pn2.MaNCC = cmb_NCC.SelectedValue.ToString();
            pn2.MaTT = cmb_TenTT.SelectedValue.ToString();
            
            ChiTietNhap ctn = new ChiTietNhap();
            ctn.MaPN = txt_MaPN.Text;
            ctn.MaTS = cmb_TenTS.SelectedValue.ToString();
            ctn.SoLuong = int.Parse(txt_SL.Text);
            ctn.DonGia = int.Parse(txt_Gia.Text);
         
            if (insert)
            {
                if (MessageBox.Show("Bạn muốn lưu dữ liệu được thêm mơi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable test = new DataTable(); //  kiểm tra mã đã  có trong bảng chưa???

                    string sql = "select *from PhieuNhap where MaPN= '" + txt_MaPN.Text + "'";
                    test = DataProvider.GetData(sql);
                    int i = test.Rows.Count;
                    if (i > 0)
                    {
                        BUS.Insert_CTN(ctn);
                        MessageBox.Show("Đã thêm chi tiết mượn vào  " + txt_MaPN.Text, "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControl1.DataSource = BUS.Select_PN();
                        LoadData();
                    }
                    else
                    {

                        BUS.Insert_PN(pn2);
                        BUS.Insert_CTN(ctn);
                        MessageBox.Show("Đã lưu thành công");
                        gridControl1.DataSource = BUS.Select_PN();
                        LoadData();
                    }
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn muốn lưu thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridControl1.DataSource = BUS.Update_PN(pn2);
                    gridControl1.DataSource = BUS.Update_CTN(ctn);
                    MessageBox.Show("Đã lưu thành công");
                    gridControl1.DataSource = BUS.Select_PN();
                    LoadData();
                }
            }
            txt_MaPN.Enabled = false;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
            btn_insert.Enabled = true;
        }
    }
}
