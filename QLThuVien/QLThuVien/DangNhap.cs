using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QLThuVien.GUI;
using System.Collections;
using DevExpress.XtraEditors;
using System.Windows.Forms.VisualStyles;
using QLThuVien.DataAccessLayer;

namespace QLThuVien
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap login;
        
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PhanQuyen( frmHome home,string a)
        {
            if (a == "ThuThu")
            {
                home.btn_CS.Enabled = true; home.btn_TK.Enabled = true;
                home.btn_DG.Enabled = true; home.btn_TS.Enabled = true;
                home.btn_KS.Enabled = true; home.btn_TTMT.Enabled = true;
                home.btn_NCC.Enabled = true; home.btn_TT.Enabled = true;
                home.btn_NXB.Enabled = true; home.btn_TG.Enabled = true;
                home.btn_PN.Enabled = true;
                home.btn_TTBT.Enabled = true;
                home.btn_DN.Enabled = false;
                home.btn_DX.Enabled = true;

            }
            else if (a == "DocGia")
            {
                home.btn_CS.Enabled = true; home.btn_TK.Enabled = true;
                home.btn_DG.Enabled = false; home.btn_TS.Enabled = true;
                home.btn_KS.Enabled = false; home.btn_TTMT.Enabled = false;
                home.btn_NCC.Enabled = false; home.btn_TT.Enabled = false;
                home.btn_NXB.Enabled = true; home.btn_TG.Enabled = true;
                home.btn_PN.Enabled = false;
                home.btn_TTBT.Enabled = true;
                home.btn_DN.Enabled = false;
                home.btn_DX.Enabled = true;

            }
        }
        private void btn_Log_Click(object sender, EventArgs e)
        {
            string User = txt_user.Text;
            string Password = txt_pass.Text;
            DataTable log1 = new DataTable();
            string sql1 = "select *from ThuThu where MaTT= '" + User + "'" + "and NgaySinh = '" + Password + "'";
            log1 = DataProvider.GetData(sql1);
            int i = log1.Rows.Count;
            if (i > 0)
            { 
                this.Hide();
                frmHome home = new frmHome();
                PhanQuyen(home,"ThuThu");
                home.tmp = log1.Rows[0][0].ToString();
                home.Show();
               
            }
            else
            {
                lbl_TTlogin.Text = "Thông tin sai!!";
            }
            DataTable log2 = new DataTable();
            string sql2 = "select *from DocGia where MaDG= '" + User + "'" + "and NgaySinh = '" + Password + "'";
            log2 = DataProvider.GetData(sql2);
            int j = log2.Rows.Count;
            if (j > 0)
            {
                frmHome home = new frmHome();
                PhanQuyen(home,"DocGia");
                home.tmp = log2.Rows[0][0].ToString();
                home.dg = log2.Rows[0][0].ToString();
                home.Show();
                this.Hide();
                
            }
            else
            {
                lbl_TTlogin.Text = "Thông tin sai!!";
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void chk_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show.Checked) txt_pass.UseSystemPasswordChar = false;
            
            else txt_pass.UseSystemPasswordChar = true;
        }

    }
}