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
namespace QLThuVien
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
      
        AddTabControl.TabAdd clsAddTab = new AddTabControl.TabAdd();
        DangNhap login = new DangNhap();
        public frmHome()
        {
            InitializeComponent();
        }


        #region"Kiểm tra tab mở"
        public void TestTab(string nametab, UserControl frm)
        {

            int t = 0;

            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == nametab)
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)//tab có thì chuyển đến tab
            {

            }
            else//nếu chưa có thì mở tab mới
            {
                clsAddTab.AddTab(xtraTabControl1, "", nametab, frm);

            }
        }
        #endregion
        #region "Code cho nut Close xtraTabControl"
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {// Đóng tab đang focus trên TAb Cha
            if (MessageBox.Show("Bạn có muốn thoát hay không", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }
        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {// Khi add vào thì Focus tới ngay Tab vừa Add
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }
        #endregion

        private void bbt_TT_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thông tin Thủ thư", new GUI.frm_TT());
        }

        private void btn_DG_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thông tin Độc giả", new GUI.frm_DG());
            
        }

        private void btn_NXB_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thông tin NXB", new GUI.frm_NXB());

        }

        private void btn_TG_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thông tin Tác giả", new GUI.frm_TG());
        }

        private void btn_NCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thông tin NCC", new GUI.frm_NCC());
        }

        private void btn_TS_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thông tin Tựa sách", new GUI.frm_TS());
        }

        private void btn_KS_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thông tin Kệ sách", new GUI.frm_KS());
        }

        private void btn_GTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Giới thiệu", new GUI.frm_GT());
        }

        private void btn_CS_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Cuốn sách",new  GUI.frm_CS());
        }

        private void btn_PN_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thông tin nhập", new GUI.frm_PN());
        }

        private void btn_TTMT_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thông tin Mượn trả", new GUI.frm_PM());
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            tmp1 = tmp;
            dg1 = dg;
        }

        private void btn_DX_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();
        }
        public string tmp;
        public string tmp1;
        public string dg;
        public string dg1;

        private void btn_DN_Click_1(object sender, EventArgs e)
        {
            login.ShowDialog();
            this.Hide();


        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void btn_TTBT_Click(object sender, EventArgs e)
        {
            if (tmp1.StartsWith("TT"))
            {
                frm_TTTT tttt = new frm_TTTT();
                tttt.temp = tmp1;
                tttt.ShowDialog();
            }
            else
            {
                frm_TTDG ttdg = new frm_TTDG();
                ttdg.temp2 = dg1;
                ttdg.ShowDialog();

            }

        }

        private void btn_TK_ItemClick(object sender, ItemClickEventArgs e)
        {
            TestTab("Thống Kê", new GUI.frm_TK());
        }

    }
   
}