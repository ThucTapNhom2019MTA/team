using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyhocsinh
{
    public partial class formTimKiem : Form
    {
        DataTable dtDanhSach;
        SqlConnection conn = constringsql.getConnection();
        public formTimKiem()
        {
            InitializeComponent();
        }

        private void formTimKiem_Load(object sender, EventArgs e)
        {

        }
    }
}
