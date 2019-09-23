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
        //kiem tra dang su dung form giao vien hay hocsinh
        public static int chooseGV_Stu = 0;
        // gv =1; hs=2
        SqlConnection conn = constringsql.getConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Pb_gv_Click(object sender, EventArgs e)
        {
            chooseGV_Stu = 1;
            this.Hide();
            Formgiaovien fgv = new Formgiaovien();
            fgv.ShowDialog();
        }

        private void Pb_hs_Click(object sender, EventArgs e)
        {
            chooseGV_Stu = 2;
            this.Hide();
            Formhocsinh fhs = new Formhocsinh();
            fhs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
