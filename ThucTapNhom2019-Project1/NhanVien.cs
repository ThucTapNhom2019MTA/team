using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom2019_Project1
{
    class NhanVien
    {
        private string manv;
        private string hoten;
        private DateTime ngaysinh;
        private string diachi;
        private string sdt;
        private string email;
        private string to;
        private string chucvu;
        private int luong;

        public NhanVien() { }

        public NhanVien(string manv, string hoten, DateTime ngaysinh, 
                        string diachi, string sdt, string email, 
                        string to, string chucvu)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
            this.to = to;
            this.chucvu = chucvu;
        }

        public NhanVien(string manv, string hoten, DateTime ngaysinh, string diachi, string sdt, string email, string to, string chucvu, int luong)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
            this.to = to;
            this.chucvu = chucvu;
            this.luong = luong;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string To { get => to; set => to = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public int Luong { get => luong; set => luong = value; }
    }
}
