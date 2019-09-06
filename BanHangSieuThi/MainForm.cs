using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuanLyND_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung userForm = new QuanLyNguoiDung();
            this.Hide();
            userForm.ShowDialog();
            this.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            NhapHang form = new NhapHang();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnNhapHangCu_Click(object sender, EventArgs e)
        {
            NhapHangCu form = new NhapHangCu();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {

        }
    }
}
