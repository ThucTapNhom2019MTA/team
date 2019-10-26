using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class TacGia
    {
        private string maTG;

        public string MaTG
        {
            get { return maTG; }
            set { maTG = value; }
        }
        private string tenTG;

        public string TenTG
        {
            get { return tenTG; }
            set { tenTG = value; }
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
        private string queQuan;

        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }
    }
}
