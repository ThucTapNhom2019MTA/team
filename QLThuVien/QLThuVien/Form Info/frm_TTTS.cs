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
using QLThuVien.BUSLayer;
using QLThuVien.DataAccessLayer;
using QLThuVien.ValueObject;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace QLThuVien.Form_Info
{
    public partial class frm_TTTS : DevExpress.XtraEditors.XtraForm
    {
        public static string MaTS;
        public frm_TTTS()
        {
            InitializeComponent();
        }

        private void frm_TTTS_Load(object sender, EventArgs e)
        {
           char  MaTS1 = Convert.ToChar(MaTS);
            DataTable dt = BUS.Get_TS(MaTS1);
            txt_MaTS.Text = MaTS;
          
        }
    }
}