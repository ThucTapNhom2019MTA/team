using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class NCC
    {
        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        private string tenNCC;

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
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
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
