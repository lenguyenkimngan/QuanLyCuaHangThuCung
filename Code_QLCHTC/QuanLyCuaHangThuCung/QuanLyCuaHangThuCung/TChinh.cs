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
    public partial class TChinh : Form
    {
        public TChinh()
        {
            InitializeComponent();
        }
        public TaiKhoan taiKhoan = new TaiKhoan();
        public int maQuyen;

        private void QLNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyNhanVien f = new QuanLyNhanVien();
            f.ShowDialog();
        }

        private void QLKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyKhachHang f = new QuanLyKhachHang();
            f.ShowDialog();
        }

        private void QLSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLySanPham f = new QuanLySanPham();
            f.ShowDialog();
        }

        private void QLĐHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyDonHang f = new QuanLyDonHang();
            f.ShowDialog();
        }

        private void CTĐHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ChiTietDonHang f = new ChiTietDonHang ();
            f.ShowDialog();
        }

        //Phân quyền:
        private void TChinh_Activated(object sender, EventArgs e)
        {
            if(taiKhoan.LoaiTK == "quản lý")
            {
                maQuyen = 1;
                QLNVToolStripMenuItem.Enabled = true;
                QLSPToolStripMenuItem.Enabled = true;
                txtPhanQuyen.Text = taiKhoan.LoaiTK;
            }
            else if(taiKhoan.LoaiTK == "nhân viên")
            {
                maQuyen = 2;
                QLNVToolStripMenuItem.Enabled = false;
                QLSPToolStripMenuItem.Enabled = false;
                txtPhanQuyen.Text = taiKhoan.LoaiTK;
            }
        }

        private void pBQuayLai_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.ShowDialog();
        }

        private void ĐXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            DangNhap f = new DangNhap();
            f.ShowDialog();
        }
    }
}
