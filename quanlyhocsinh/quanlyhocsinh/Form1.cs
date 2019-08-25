using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace quanlyhocsinh
{
    public partial class Form1 : Form
    {
        SqlConnection conn = constringsql.getConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Pb_gv_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formgiaovien fgv = new Formgiaovien();
            fgv.ShowDialog();
        }

        private void Pb_hs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formhocsinh fhs = new Formhocsinh();
            fhs.ShowDialog();
        }
    }
}
