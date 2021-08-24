using Nhom6_QuanLyTiemBanh.DBProccessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom6_QuanLyTiemBanh
{
    public partial class DanhSachHoaDon : Form
    {
        DBProccessingDSHoaDon obj=new DBProccessingDSHoaDon();
        public DanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
