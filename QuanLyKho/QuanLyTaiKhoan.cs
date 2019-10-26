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
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }


        private bool validate()
        {
            if (fieldTenDN.Text == "" || fieldMatKhau.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"SELECT * FROM TaiKhoanNV where Role <> 'A'";

            dataGridView1.DataSource = Database.getTable(sql);

            binding();
        }

        private void binding()
        {
            fieldMaTK.DataBindings.Clear();
            fieldTenDN.DataBindings.Clear();
            fieldMatKhau.DataBindings.Clear();

            fieldMaTK.DataBindings.Add("Text", dataGridView1.DataSource, "MaTK");
            fieldTenDN.DataBindings.Add("Text", dataGridView1.DataSource, "TenTK");
            fieldMatKhau.DataBindings.Add("Text", dataGridView1.DataSource, "MKTK");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string sql = @"INSERT INTO [QLKhoHang].[dbo].[TaiKhoanNV]
                                   ([TenTK]
                                   ,[Role]
                                   ,[MKTK])
                             VALUES
                                   ('" + fieldTenDN.Text + @"'
                                   ,'N'
                                   ,'" + fieldMatKhau.Text + @"'
                                    )";

                if (Database.Query(sql) == -1)
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm !");
                }
                else
                {
                    MessageBox.Show("Thêm thành công !");
                    hien();
                }
            }
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            hien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
