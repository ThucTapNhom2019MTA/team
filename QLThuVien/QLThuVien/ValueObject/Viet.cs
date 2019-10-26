using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class Viet
    {
        private string maTS;

        public string MaTS
        {
            get { return maTS; }
            set { maTS = value; }
        }
        private string maTG;

        public string MaTG
        {
            get { return maTG; }
            set { maTG = value; }
        }
        private int soTrang;

        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }

    }
}
