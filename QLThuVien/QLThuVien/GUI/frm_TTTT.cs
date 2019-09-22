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
    public partial class frm_TTTT : DevExpress.XtraEditors.XtraForm
    {
        public frm_TTTT()
        {
            InitializeComponent();
        }
        public string temp;
        private void frm_TTTT_Load(object sender, EventArgs e)
        {
            txt_MaTT.Text = temp;
            DataTable tttt = new DataTable();
            string sql = "select *from ThuThu where MaTT='" + temp + "'";
            tttt = DataProvider.GetData(sql);
            txt_MaTT.Text = tttt.Rows[0][0].ToString();
            txt_TenTT.Text = tttt.Rows[0][1].ToString();
            txt_NS.EditValue = tttt.Rows[0][2];
            txt_GT.Text = tttt.Rows[0][3].ToString();
            txt_DC.Text = tttt.Rows[0][4].ToString();
            txt_SDT.Text = tttt.Rows[0][5].ToString();
            txt_CV.Text = tttt.Rows[0][6].ToString();

        }


    }
}