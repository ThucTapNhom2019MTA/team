﻿using System;
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
    
    public partial class Form1 : Form
    {
        public  static string MaNV = "";
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string startTime = DateTime.Now.ToString("HH:mm:ss");
            SqlConnection conn = ConnectDB.getConnection();
            conn.Open();
            string query = "SELECT MaNV FROM dbo.ACOUNT WHERE UserName=@username AND Password=@password";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@username", txbUsername.Text);
            comm.Parameters.AddWithValue("@password", txbPassword.Text);
            MaNV = Convert.ToString(comm.ExecuteScalar()).Replace(" ","");
            if (MaNV != null && MaNV != "" ){
                    MainForm mainform = new MainForm();
                    this.Hide();
                    mainform.ShowDialog();
                    conn.Close();
                    conn.Open();
                    query = "INSERT INTO SUDUNGPM VALUES(GETDATE(),@startTime,@endTime,@maNV)";
                    comm = new SqlCommand(query, conn);
                    comm.Parameters.AddWithValue("@startTime", startTime);
                    comm.Parameters.AddWithValue("@endTime", DateTime.Now.ToString("HH:mm:ss"));
                    comm.Parameters.AddWithValue("@maNV",MaNV);
                    comm.ExecuteNonQuery();
                    this.Show();
            }
            else
            {
                MessageBox.Show("Không thành công","Thông báo");
            }
            conn.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
