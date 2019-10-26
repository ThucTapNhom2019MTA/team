using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public  class TuaSach
    {
        private string maTS;

        public string MaTS
        {
            get { return maTS; }
            set { maTS = value; }
        }
        private string tenTS;

        public string TenTS
        {
            get { return tenTS; }
            set { tenTS = value; }
        }
        private int namXB;

        public int NamXB
        {
            get { return namXB; }
            set { namXB = value; }
        }
      
        private string maKe;

        public string MaKe
        {
            get { return maKe; }
            set { maKe = value; }
        }
        private string theLoai;

        public string TheLoai
        {
            get { return theLoai; }
            set { theLoai = value; }
        }

        private string maNXB;

        public string MaNXB
        {
            get { return maNXB; }
            set { maNXB = value; }

        }
        private string sl;

        public string SoLuong
        {
            get { return sl; }
            set { sl = value; }
        }
    }
}
