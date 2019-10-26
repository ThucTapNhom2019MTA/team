using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class PhieuMuon
    {
        private string maPM;

        public string MaPM
        {
            get { return maPM; }
            set { maPM = value; }
        }
        private DateTime ngayMuon;

        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }

        private DateTime ngayTra;
        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        private string maDG;

        public string MaDG
        {
            get { return maDG; }
            set { maDG = value; }
        }
        private string maTT;

        public string MaTT
        {
            get { return maTT; }
            set { maTT = value; }
        }


    }
}
