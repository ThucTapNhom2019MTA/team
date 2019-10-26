using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi
{
    public partial class QuanLiNhanVien : Form
    {
        public QuanLiNhanVien()
        {
            InitializeComponent();
            FillData();
        }
        private void FillData()
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT MaNV FROM dbo.NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            for (int i = 0; i < dtDanhSach.Rows.Count; i++)
            {
                cbbMaNhanVien.Items.Add(dtDanhSach.Rows[i][0].ToString());
                cbbMNV.Items.Add(dtDanhSach.Rows[i][0].ToString());
            }
            cbbMNV.SelectedIndex = 0;
            cbbMaNhanVien.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            // them nhan vien
            conn.Open();
            string query = "INSERT INTO dbo.NHANVIEN ( MaNV, TenNV, ChucVu ) VALUES ( @MaNV, @TenNV, @ChucVu )";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaNV ", txbMaNV.Text);
            comm.Parameters.AddWithValue("@TenNV", txbTenNV.Text);
            comm.Parameters.AddWithValue("@ChucVu", txbChucVu.Text);
            comm.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công", "Thông báo");
            FillData();
            conn.Close();
        }

        private void cbbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cbbMaNhanVien.SelectedItem.ToString();
            getNhanVien(maNV);
            fillData(maNV);
            sumWorkTime(maNV);
        }
        private void sumWorkTime(string maNV)
        {
            SqlConnection conn = ConnectDB.getConnection();
            conn.Open();
            string query = "SELECT SUM(DATEDIFF(MINUTE,ThoiGianBD,ThoiGianKT)) FROM dbo.NGAYCONG WHERE MaNV = @MaNV";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MaNV", maNV);
            txbGioLam.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
        }
        private void fillData(string maNV)
        {
            SqlConnection conn = ConnectDB.getConnection();
            string strQueryDanhSach = "SELECT * FROM dbo.NGAYCONG WHERE MaNV = @MaNV";
            SqlCommand comm = new SqlCommand(strQueryDanhSach, conn);
            comm.Parameters.AddWithValue("@MaNV", maNV);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dgvNhanVien.DataSource = dtDanhSach;
        }
        private void getNhanVien(string maNV)
        {
            SqlConnection conn = ConnectDB.getConnection();
            // them nhan vien
            conn.Open();
            string query = "SELECT TenNV FROM dbo.NHANVIEN WHERE MaNV=@maNV";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@maNV",maNV);
            txbTenNhanVien.Text =  Convert.ToString(comm.ExecuteScalar());
            conn.Close();
            conn.Open();
            query = "SELECT ChucVu FROM dbo.NHANVIEN WHERE MaNV=@maNV";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@maNV", maNV);
            txbCvu.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
        }
        private void getProfileNhanVien(string maNV)
        {
            SqlConnection conn = ConnectDB.getConnection();
            // them nhan vien
            conn.Open();
            string query = "SELECT TenNV FROM dbo.NHANVIEN WHERE MaNV=@maNV";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@maNV", maNV);
            txbTenNhanVien.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
            conn.Open();
            query = "SELECT ChucVu FROM dbo.NHANVIEN WHERE MaNV=@maNV";
            comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@maNV", maNV);
            txbCvu.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectDB.getConnection();
            string query = "INSERT INTO dbo.NGAYCONG ( Ngay, ThoiGianBD, ThoiGianKT, TraLuong, MaNV )" +
                " VALUES (@Ngay, @ThoiGianBD, @ThoiGianKT, @TraLuong, @MaNV )";
            conn.Open();
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@Ngay", dtpNgay.Value.ToShortDateString());
            comm.Parameters.AddWithValue("@ThoiGianBD", txbTGBD.Text);
            comm.Parameters.AddWithValue("@ThoiGianKT", txbTGKT.Text);
            comm.Parameters.AddWithValue("@TraLuong", cbbState.SelectedItem.ToString());
            comm.Parameters.AddWithValue("@MaNV", cbbMNV.SelectedItem.ToString());
            comm.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công","Thông báo");
            conn.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txbChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbGioLam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCvu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txbTenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txbTGKT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTGBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbbMNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown4_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker16_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown3_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker15_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker14_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker13_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown5_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown6_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker17_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown7_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker18_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker19_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown8_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker20_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker21_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker22_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker23_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker24_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker25_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker26_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker27_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker28_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void listView7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void progressBar6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void progressBar7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker29_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker30_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker31_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker32_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker33_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void label94_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }

        private void label96_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox21_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox22_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox23_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox24_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox25_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox26_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox27_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox28_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox29_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox30_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void flowLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown9_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown10_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker34_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown11_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker35_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker36_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown12_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker37_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker38_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker39_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker40_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker41_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker42_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker43_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker44_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker45_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void listView10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void listView11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {

        }

        private void label97_Click(object sender, EventArgs e)
        {

        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void textBox80_TextChanged(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker46_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox82_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox84_TextChanged(object sender, EventArgs e)
        {

        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void textBox85_TextChanged(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void label109_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label117_Click(object sender, EventArgs e)
        {

        }

        private void label118_Click(object sender, EventArgs e)
        {

        }

        private void label119_Click(object sender, EventArgs e)
        {

        }

        private void label120_Click(object sender, EventArgs e)
        {

        }

        private void label121_Click(object sender, EventArgs e)
        {

        }

        private void label122_Click(object sender, EventArgs e)
        {

        }

        private void label123_Click(object sender, EventArgs e)
        {

        }

        private void label124_Click(object sender, EventArgs e)
        {

        }

        private void label125_Click(object sender, EventArgs e)
        {

        }

        private void label126_Click(object sender, EventArgs e)
        {

        }

        private void label127_Click(object sender, EventArgs e)
        {

        }

        private void label128_Click(object sender, EventArgs e)
        {

        }

        private void label129_Click(object sender, EventArgs e)
        {

        }

        private void label130_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label131_Click(object sender, EventArgs e)
        {

        }

        private void label132_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label133_Click(object sender, EventArgs e)
        {

        }

        private void label134_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label135_Click(object sender, EventArgs e)
        {

        }

        private void progressBar9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label136_Click(object sender, EventArgs e)
        {

        }

        private void progressBar10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void label137_Click(object sender, EventArgs e)
        {

        }

        private void progressBar11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker47_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker48_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label138_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker49_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label139_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker50_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label140_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void label141_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void textBox86_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox87_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox88_TextChanged(object sender, EventArgs e)
        {

        }

        private void label142_Click(object sender, EventArgs e)
        {

        }

        private void label143_Click(object sender, EventArgs e)
        {

        }

        private void label144_Click(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox31_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox32_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox33_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox34_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox35_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox36_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox37_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox38_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox39_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox40_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void textBox89_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox90_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox91_TextChanged(object sender, EventArgs e)
        {

        }

        private void label145_Click(object sender, EventArgs e)
        {

        }

        private void label146_Click(object sender, EventArgs e)
        {

        }

        private void label147_Click(object sender, EventArgs e)
        {

        }

        private void tabPage14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView15_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox92_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox93_TextChanged(object sender, EventArgs e)
        {

        }

        private void label148_Click(object sender, EventArgs e)
        {

        }

        private void textBox94_TextChanged(object sender, EventArgs e)
        {

        }

        private void label149_Click(object sender, EventArgs e)
        {

        }

        private void label150_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label151_Click(object sender, EventArgs e)
        {

        }

        private void tabPage15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker51_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox95_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox96_TextChanged(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label152_Click(object sender, EventArgs e)
        {

        }

        private void label153_Click(object sender, EventArgs e)
        {

        }

        private void label154_Click(object sender, EventArgs e)
        {

        }

        private void label155_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label156_Click(object sender, EventArgs e)
        {

        }

        private void tabPage16_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void flowLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown13_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown14_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker52_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown15_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker53_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker54_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown16_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker55_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker56_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker57_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker58_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker59_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker60_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker61_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker62_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker63_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void listView14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox97_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void listView15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox98_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox100_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox101_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox102_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox103_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox104_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox105_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox106_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox107_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox108_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox109_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox110_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox111_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox112_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox113_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox114_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox115_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox116_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox117_TextChanged(object sender, EventArgs e)
        {

        }

        private void label157_Click(object sender, EventArgs e)
        {

        }

        private void textBox118_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox119_TextChanged(object sender, EventArgs e)
        {

        }

        private void label158_Click(object sender, EventArgs e)
        {

        }

        private void label159_Click(object sender, EventArgs e)
        {

        }

        private void textBox120_TextChanged(object sender, EventArgs e)
        {

        }

        private void label160_Click(object sender, EventArgs e)
        {

        }

        private void label161_Click(object sender, EventArgs e)
        {

        }

        private void label162_Click(object sender, EventArgs e)
        {

        }

        private void label163_Click(object sender, EventArgs e)
        {

        }

        private void label164_Click(object sender, EventArgs e)
        {

        }

        private void label165_Click(object sender, EventArgs e)
        {

        }

        private void label166_Click(object sender, EventArgs e)
        {

        }

        private void label167_Click(object sender, EventArgs e)
        {

        }

        private void label168_Click(object sender, EventArgs e)
        {

        }

        private void label169_Click(object sender, EventArgs e)
        {

        }

        private void label170_Click(object sender, EventArgs e)
        {

        }

        private void label171_Click(object sender, EventArgs e)
        {

        }

        private void label172_Click(object sender, EventArgs e)
        {

        }

        private void label173_Click(object sender, EventArgs e)
        {

        }

        private void label174_Click(object sender, EventArgs e)
        {

        }

        private void label175_Click(object sender, EventArgs e)
        {

        }

        private void label176_Click(object sender, EventArgs e)
        {

        }

        private void label177_Click(object sender, EventArgs e)
        {

        }

        private void label178_Click(object sender, EventArgs e)
        {

        }

        private void label179_Click(object sender, EventArgs e)
        {

        }

        private void label180_Click(object sender, EventArgs e)
        {

        }

        private void label181_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView16_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label182_Click(object sender, EventArgs e)
        {

        }

        private void label183_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView17_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label184_Click(object sender, EventArgs e)
        {

        }

        private void label185_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView18_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label186_Click(object sender, EventArgs e)
        {

        }

        private void progressBar13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView19_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label187_Click(object sender, EventArgs e)
        {

        }

        private void progressBar14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void label188_Click(object sender, EventArgs e)
        {

        }

        private void progressBar15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker64_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker65_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label189_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker66_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label190_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker67_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label191_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void label192_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }
    }
}
