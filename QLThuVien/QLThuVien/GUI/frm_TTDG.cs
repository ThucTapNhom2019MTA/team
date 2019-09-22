using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Windows.Forms.VisualStyles;
using QLThuVien.DataAccessLayer;

namespace QLThuVien.GUI
{
    public partial class frm_TTDG : DevExpress.XtraEditors.XtraForm
    {
        public frm_TTDG()
        {
            InitializeComponent();
        }
        public string temp2;

        private void frm_TTDG_Load(object sender, EventArgs e)
        {
            txt_MaDG.Text = temp2;
            DataTable ttdg = new DataTable();
            string sql = "select *from DocGia where MaDG='" + temp2 + "'";
            ttdg = DataProvider.GetData(sql);
            txt_MaDG.Text = ttdg.Rows[0][0].ToString();
            txt_TenDG.Text = ttdg.Rows[0][1].ToString();
            txt_NS.EditValue = ttdg.Rows[0][2];
            txt_GT.Text = ttdg.Rows[0][3].ToString();
            txt_DC.Text = ttdg.Rows[0][4].ToString();
            txt_SDT.Text = ttdg.Rows[0][5].ToString();
        }
    }
}