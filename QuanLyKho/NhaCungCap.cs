﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lớp_BUS;
using Lớp_DAL;
using Lớp_Entites;

namespace QuanLyKho
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        BUS_tblNhaCungCap bus = new BUS_tblNhaCungCap();
        EC_tblNhaCungCap ec = new EC_tblNhaCungCap();
        bool themmoi;
        void modieukhien()
        {
            fieldMaNCC.Enabled = true;
            fieldTenNCC.Enabled = true;
            fieldSDT.Enabled = true;
            fieldEmail.Enabled = true;
            fieldDiaChi.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
        }
        void khoadieukhien()
        {
            fieldMaNCC.Enabled = false;
            fieldTenNCC.Enabled = false;
            fieldSDT.Enabled = false;
            fieldEmail.Enabled = false;
            fieldDiaChi.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
        }
        void setnull()
        {
            fieldMaNCC.Text = "";
            fieldTenNCC.Text = "";
            fieldSDT.Text = "";
            fieldEmail.Text = "";
            fieldDiaChi.Text = "";
        }
        void hienthidulieu(string DieuKien)
        {
            dataGridView1.DataSource = bus.taobang(DieuKien);
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            mobtn();
            dongtxt();
            hien();
        }


        private bool validate()
        {
            if (fieldDiaChi.Text == "" || fieldEmail.Text == "" || fieldSDT.Text == "" || fieldTenNCC.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"SELECT * FROM DMNhaCungCap";

            dataGridView1.DataSource = Database.getTable(sql);
        }

        private void binding()
        {
            fieldDiaChi.DataBindings.Clear();
            fieldEmail.DataBindings.Clear();
            fieldMaNCC.DataBindings.Clear();
            fieldSDT.DataBindings.Clear();
            fieldTenNCC.DataBindings.Clear();

            fieldDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "diachincc");
            fieldEmail.DataBindings.Add("Text", dataGridView1.DataSource, "emailncc");
            fieldMaNCC.DataBindings.Add("Text", dataGridView1.DataSource, "mancc");
            fieldSDT.DataBindings.Add("Text", dataGridView1.DataSource, "sdtncc");
            fieldTenNCC.DataBindings.Add("Text", dataGridView1.DataSource, "tenncc");
        }
        private void motxt()
        {
            fieldTenNCC.Enabled = true;
            fieldSDT.Enabled = true;
            fieldEmail.Enabled = true;
            fieldDiaChi.Enabled = true;
        }

        private void dongtxt()
        {
            fieldMaNCC.Enabled = false;
            fieldTenNCC.Enabled = false;
            fieldSDT.Enabled = false;
            fieldEmail.Enabled = false;
            fieldDiaChi.Enabled = false;
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


    }
}
