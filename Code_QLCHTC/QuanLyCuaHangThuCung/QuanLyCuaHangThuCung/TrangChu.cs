using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            TrangChu trangChu = this;
            trangChu.Hide();
            dn.ShowDialog();
            trangChu.Show();
        }

        private void pBMuiTen_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Show();
        }

        private void pBThongTin_Click(object sender, EventArgs e)
        {
            Hide();
            ThongTin f = new ThongTin();
            f.ShowDialog();      
        }
    }
}
