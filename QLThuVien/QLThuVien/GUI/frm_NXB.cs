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
    public partial class frm_NXB : DevExpress.XtraEditors.XtraUserControl
    {
        private int currenRowIndex;
        private readonly NXB nxb;
        DataTable dt = BUS.Select_NXB();
        bool insert = false;
        bool update = false;
        public frm_NXB()
        {
            InitializeComponent();
            nxb = new NXB();
        }

        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaNXB.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaNXB"]).ToString();
            txt_TenNXB.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenNXB"]).ToString();
            txt_DC.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["DiaChi"]).ToString();
            txt_SDT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SDT"]).ToString();
            txt_Email.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Email"]).ToString();

        }
        private void frm_NXB_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataTable kttt = new DataTable();

                string sql = "select *from TuaSach where MaNXB= '" + txt_MaNXB.Text + "'";
                kttt = DataProvider.GetData(sql);
                int i = kttt.Rows.Count;
                if (i > 0)
                    MessageBox.Show("Dữ liệu '" +txt_MaNXB.Text+ "' có trong bảng Tựa Sách  !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nxb.MaNXB = txt_MaNXB.Text;
                    gridControl1.DataSource = BUS.Delete_NXB(nxb);
                    MessageBox.Show("Đã xóa thành công");
                    gridControl1.DataSource = BUS.Select_NXB();
                    LoadData();
                }
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string std = string.Format("TenNXB like '%{0}%'", txt_search.Text);
            dt.DefaultView.RowFilter = std;
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_update.Enabled = false;
            txt_MaNXB.Enabled = true;btn_cancel.Enabled = true;
            insert = true; update = false;
            txt_MaNXB.Text = ""; txt_TenNXB.Text = ""; txt_SDT.Text = "";
            txt_DC.Text = ""; txt_Email.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_insert.Enabled = false;
            update = true; btn_cancel.Enabled = true;
            insert = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            NXB nxb2 = new NXB();
            nxb2.MaNXB = txt_MaNXB.Text; nxb2.TenNXB = txt_TenNXB.Text;
            nxb2.DiaChi = txt_DC.Text;
            nxb2.SDT = txt_SDT.Text; nxb2.Email = txt_Email.Text;

            if (insert)
            {
                if (MessageBox.Show("Bạn muốn lưu dữ liệu thêm mới không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable test = new DataTable(); //  kiểm tra mã đã  có trong bảng chưa???

                    string sql = "select *from NXB where MaNXB= '" + txt_MaNXB.Text + "'";
                    test = DataProvider.GetData(sql);
                    int i = test.Rows.Count;
                    if (i > 0)
                        MessageBox.Show("Đã tồn tại " + txt_MaNXB.Text, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        gridControl1.DataSource = BUS.Insert_NXB(nxb2);
                        MessageBox.Show("Đã lưu thành công");
                        gridControl1.DataSource = BUS.Select_NXB();
                        LoadData();
                    }
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn muốn lưu thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridControl1.DataSource = BUS.Update_NXB(nxb2);
                    MessageBox.Show("Đã lưu thành công");
                    gridControl1.DataSource = BUS.Select_NXB();
                    LoadData();
                }
               
            }
            txt_MaNXB.Enabled = false;
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
                txt_MaNXB.Enabled = false;
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
