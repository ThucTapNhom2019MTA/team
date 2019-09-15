using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Visible = true;
        }

        private void dMHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new HangHoa().ShowDialog();
        }

        private void dMNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new NhaCungCap().ShowDialog();
        }

        private void dMKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new KhachHang().ShowDialog();
        }

        private void nhậpKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new NhapHang().ShowDialog();
        }

        private void xuấtKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new XuatHang().ShowDialog();
        }












    }
}
