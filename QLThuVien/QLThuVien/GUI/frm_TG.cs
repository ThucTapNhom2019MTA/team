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
    public partial class frm_TG : DevExpress.XtraEditors.XtraUserControl
    {
        private int currenRowIndex;
        private readonly TacGia tg;
        DataTable dt = BUS.Select_TG();
        bool insert = false;
        bool update = false;
        public frm_TG()
        {
            InitializeComponent();
            tg = new TacGia();
        }

        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaTG.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaTG"]).ToString();
            txt_TenTG.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTG"]).ToString();
            cmb_GT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["GioiTinh"]).ToString();
            date_NS.EditValue = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgaySinh"]);
            txt_QQ.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["QueQuan"]).ToString();
        }
        private void frm_TG_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = dt;
            gridColumn5.Width = 100;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            LoadData();
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
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

                string sql = "select *from Viet where MaTG= '" + txt_MaTG.Text + "'";
                kttt = DataProvider.GetData(sql);
                int i = kttt.Rows.Count;
                if (i > 0)
                    MessageBox.Show("Dữ liệu '" +txt_MaTG.Text+ "' có trong bảng Viet!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    tg.MaTG = txt_MaTG.Text;
                    gridControl1.DataSource = BUS.Delete_TG(tg);
                    MessageBox.Show("Đã xóa thành công");
                    gridControl1.DataSource = BUS.Select_TG();
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
            string std = string.Format("TenTG like '%{0}%'", txt_search.Text);
            dt.DefaultView.RowFilter = std;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_update.Enabled = false;
            txt_MaTG.Enabled = true; btn_cancel.Enabled = true;
            insert = true; update = false;
            txt_MaTG.Text = ""; txt_TenTG.Text = "";
            cmb_GT.Text = ""; txt_QQ.Text = ""; date_NS.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_insert.Enabled = false;
            update = true; btn_cancel.Enabled = true;
            insert = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            TacGia tg2 = new TacGia();
            tg2.MaTG = txt_MaTG.Text; tg2.TenTG = txt_TenTG.Text;
            tg2.NgaySinh = date_NS.DateTime; tg2.GioiTinh = cmb_GT.Text;
            tg2.QueQuan = txt_QQ.Text;


            if (insert)
            {
                if (MessageBox.Show("Bạn muốn lưu dữ liệu thêm mới không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable test = new DataTable(); //  kiểm tra mã đã  có trong bảng chưa???

                    string sql = "select *from TacGia where MaTG= '" + txt_MaTG.Text + "'";
                    test = DataProvider.GetData(sql);
                    int i = test.Rows.Count;
                    if (i > 0)
                        MessageBox.Show("Đã tồn tại " + txt_MaTG.Text, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        gridControl1.DataSource = BUS.Insert_TG(tg2);
                        MessageBox.Show("Đã lưu thành công");
                        gridControl1.DataSource = BUS.Select_TG();
                        LoadData();
                    }
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn muốn lưu thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridControl1.DataSource = BUS.Update_TG(tg2);
                    MessageBox.Show("Đã lưu thành công");
                    gridControl1.DataSource = BUS.Select_TG();
                    LoadData();
                }
            }
            txt_MaTG.Enabled = false;
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
                txt_MaTG.Enabled = false;
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
