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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            if (fielddckh.Text == "" || fieldemailkh.Text == "" || fieldSDT.Text == "" || fieldtenkh.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"SELECT * FROM DMKhachHang";

            dataGridView1.DataSource = Database.getTable(sql);
        }

        private void binding()
        {
            fielddckh.DataBindings.Clear();
            fieldemailkh.DataBindings.Clear();
            fieldmakh.DataBindings.Clear();
            fieldSDT.DataBindings.Clear();
            fieldtenkh.DataBindings.Clear();


            fielddckh.DataBindings.Add("Text", dataGridView1.DataSource, "diachikh");
            fieldemailkh.DataBindings.Add("Text", dataGridView1.DataSource, "emailkh");
            fieldmakh.DataBindings.Add("Text", dataGridView1.DataSource, "makh");
            fieldSDT.DataBindings.Add("Text", dataGridView1.DataSource, "sdtkh");
            fieldtenkh.DataBindings.Add("Text", dataGridView1.DataSource, "tenkh");
        }
        private void motxt()
        {
            fielddckh.Enabled = true;
            fieldemailkh.Enabled = true;
            fieldSDT.Enabled = true;
            fieldtenkh.Enabled = true;
        }

        private void dongtxt()
        {
            fielddckh.Enabled = false;
            fieldemailkh.Enabled = false;
            fieldSDT.Enabled = false;
            fieldtenkh.Enabled = false;
        }

        private void mobtn()
        {
            btluu.Enabled = false;
            btnhuy.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }

        private void dongbtn()
        {
            btluu.Enabled = true;
            btnhuy.Enabled = true;
            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }

        string state = "";

        private void btthem_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "insert";
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "update";
            binding();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "delete";
            binding();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (validate())
            {



                if (state == "insert")
                {
                    //MessageBox.Show("INSERT INTO PhieuNhap(MaPhieuNhap, TenNCC, TenMH, SoLuongNhap,GiaNhap,TienDaThanhToan,NgayThanhToan) VALUES (" + Convert.ToInt32(txtMaPhieuNhap.Text) + ",N'" + txtTenNCC.Text + "',N'" + txtTenMH.Text + "'," + Convert.ToInt32(txtSoLuongNhap.Text) + "," + Convert.ToInt32(txtGiaNhap.Text) + "," + Convert.ToInt32(txtTienDaThanhToan.Text) + ",'"+txtNgayThanhToan.Value.ToShortDateString().ToString() +"')");
                    string sql = @"INSERT INTO [QLKhoHang].[dbo].[DMKhachHang]
                           ([tenkh]
                           ,[sdtkh]
                           ,[emailkh]
                           ,[diachikh])
                     VALUES
                           (N'" + fieldtenkh.Text + @"'
                           ," + Convert.ToInt64(fieldSDT.Text) + @"
                           ,N'" + fieldemailkh.Text + @"'
                           ,N'" + fielddckh.Text + @"'
                           )";

                    if (Database.Query(sql) != -1)
                    {
                        MessageBox.Show("Thêm thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm");
                    }
                }
                //end add
                else if (state == "update")
                {
                    string sql = @"UPDATE [QLKhoHang].[dbo].[DMKhachHang]
                       SET [tenkh] = N'" + fieldtenkh.Text + @"'
                          ,[sdtkh] = " + Convert.ToInt64(fieldSDT.Text) + @"
                          ,[emailkh] = N'" + fieldemailkh.Text + @"'
                          ,[diachikh] = N'" + fielddckh.Text + @"'
                     WHERE makh = " + Convert.ToInt64(fieldmakh.Text);



                    if (Database.Query(sql) != -1)
                    {
                        MessageBox.Show("Sửa thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình Sửa");
                    }

                }

                hien();
                dongtxt();
                mobtn();
            }//end validate
            if (state == "delete" && validate())
            {
                string sql = @"DELETE FROM [QLKhoHang].[dbo].[DMKhachHang]
                WHERE makh = " + Convert.ToInt64(fieldmakh.Text);


                if (Database.Query(sql) != -1)
                {
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình Xóa");
                }

                hien();
                dongtxt();
                mobtn();
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            mobtn();
            dongtxt();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Visible = true;
        }
    }
}
