using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class PhieuNhap
    {
        private string maPN;

        public string MaPN
        {
            get { return maPN; }
            set { maPN = value; }
        }
        private DateTime ngayLap;

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        private string maTT;

        public string MaTT
        {
            get { return maTT; }
            set { maTT = value; }
        }
        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
    }
}
