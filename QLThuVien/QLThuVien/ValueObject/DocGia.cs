using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class DocGia
    {
        private string maDG;

        public string MaDG
        {
            get { return maDG; }
            set { maDG = value; }
        }
        private string tenDG;

        public string TenDG
        {
            get { return tenDG; }
            set { tenDG = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string Sdt;

        public string SDT
        {
            get { return Sdt; }
            set { Sdt = value; }
        }
 
    }
}
