using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class ChiTietNhap
    {
        private string maPN;

        public string MaPN
        {
            get { return maPN; }
            set { maPN = value; }
        }
        private string maTS;

        public string MaTS
        {
            get { return maTS; }
            set { maTS = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private int donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
    }
}
