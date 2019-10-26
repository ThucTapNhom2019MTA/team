using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class ChiTietMuon
    {
        private string maPM;

        public string MaPM
        {
            get { return maPM; }
            set { maPM = value; }
        }
        private string maCS;

        public string MaCS
        {
            get { return maCS; }
            set { maCS = value; }
        }
        private string tinhtrang;

        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }


    }
}
