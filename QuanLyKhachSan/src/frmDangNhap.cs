using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.src
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        BUS_DangNhap dn = new BUS_DangNhap();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (dn.DangNhap(txtUserName.Text, txtPass.Text) == true)
            {

                MessageBox.Show("Bạn đăng nhập thành công ^^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQuanLyKhachSan frm = new frmQuanLyKhachSan();
                frm.Show();
                Hide();
            }
            else MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai. Mời bạn nhập lại !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có chắc muốn thoát ??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

<<<<<<< HEAD
=======
        //common 
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
    }
}
