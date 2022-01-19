using QuanLyCuaHangThuCung.BUS;
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
    public partial class QuanLyKhachHang : Form
    {
        BUS_KhachHang busKH;
        public QuanLyKhachHang()
        {
            InitializeComponent();
            busKH = new BUS_KhachHang();
        }

        private void HienThiDSKhachHang()
        {
            dGKhachHang.DataSource = null;
            busKH.LayDSKhachHang(dGKhachHang);
            //Định dạng datagridview:
            dGKhachHang.Columns[0].Width = (int)(dGKhachHang.Width * 0.1);
            dGKhachHang.Columns[1].Width = (int)(dGKhachHang.Width * 0.3);
            dGKhachHang.Columns[2].Width = (int)(dGKhachHang.Width * 0.1);
            dGKhachHang.Columns[3].Width = (int)(dGKhachHang.Width * 0.15);
            dGKhachHang.Columns[4].Width = (int)(dGKhachHang.Width * 0.15);
            dGKhachHang.Columns[5].Width = (int)(dGKhachHang.Width * 0.15);
            dGKhachHang.Columns[6].Width = (int)(dGKhachHang.Width * 0.35);
        }
        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }

        //Xử lý nhấn vào 1 cột dưới datagridview hiển thị lên trên:
        private void dGKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTen.Text = dGKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dGKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGioiTinh.Text = dGKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDT.Text = dGKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDC.Text = dGKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dGKhachHang.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtMaKH.Text = dGKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //THÊM KH:
        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.NgaySinh = dtpNgaySinh.Value;
            khachHang.HoTenKH = txtHoTen.Text;
            khachHang.GioiTinh = txtGioiTinh.Text;
            khachHang.SDT = txtDT.Text;
            khachHang.DiaChi = txtDC.Text;
            khachHang.EMAIL = txtEmail.Text;

            //Gọi sự kiện thêm của BUS:
            if (busKH.ThemKH(khachHang))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                busKH.LayDSKhachHang(dGKhachHang);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
        }

        //SỬA KH:
        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = int.Parse(txtMaKH.Text);
            kh.HoTenKH = txtHoTen.Text;
            kh.NgaySinh = dtpNgaySinh.Value;
            kh.GioiTinh = txtGioiTinh.Text;
            kh.SDT = txtDT.Text;
            kh.DiaChi = txtDC.Text;
            kh.EMAIL = txtEmail.Text;

            //Gọi sự kiện sửa của BUS:
            if (busKH.SuaKH(kh))
            {
                MessageBox.Show("Sửa khách hàng thành công");
                busKH.LayDSKhachHang(dGKhachHang);
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại");
            }
        }

        //Xóa KH:
        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = int.Parse(txtMaKH.Text);

            //Gọi sự kiện xóa của BUS:
            if (busKH.XoaKH(kh))
            {
                MessageBox.Show("Xóa khách hàng thành công");
                busKH.LayDSKhachHang(dGKhachHang);
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }
        }

        //Thoát;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                HienThiDSKhachHang();
            }
            else
            {
                busKH.TimKhachHang(dGKhachHang, txtTimKiem.Text);
            }
        }

        private void pBQuayLai_Click(object sender, EventArgs e)
        {
            Hide();
            TChinh f = new TChinh();
            f.ShowDialog();
        }
    }
}
