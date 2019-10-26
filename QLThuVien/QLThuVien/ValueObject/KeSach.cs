using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class KeSach
    {
        private string maKe;

        public string MaKe
        {
            get { return maKe; }
            set { maKe = value; }
        }
        private string chatLieu;

        public string ChatLieu
        {
            get { return chatLieu; }
            set { chatLieu = value; }
        }
        private string sucChua;

        public string SucChua
        {
            get { return sucChua; }
            set { sucChua = value; }
        }
    }
}
