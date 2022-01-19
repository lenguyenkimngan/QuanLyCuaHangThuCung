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
    public partial class QuanLyDonHang : Form
    {
        BUS_DonHang busDH;

        public QuanLyDonHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }

        private void btnCTDH_Click(object sender, EventArgs e)
        {
            ChiTietDonHang ctdh = new ChiTietDonHang();
            this.Hide();
            ctdh.ShowDialog();
            this.Show();
        }

        private void HienThiDSDonHang()
        {
            dGDonHang.DataSource = null;
            busDH.LayDSDonHang(dGDonHang);
            //Định dạng datagridview:
            dGDonHang.Columns[0].Width = (int)(dGDonHang.Width * 0.25);
            dGDonHang.Columns[1].Width = (int)(dGDonHang.Width * 0.25);
            dGDonHang.Columns[2].Width = (int)(dGDonHang.Width * 0.25);
            dGDonHang.Columns[3].Width = (int)(dGDonHang.Width * 0.3);
        }

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            HienThiDSDonHang();
            busDH.LayDSKH(cbKhachHang);
            busDH.LayDSNV(cbNhanVien);
        }

        //Xử lý nhấn vào 1 cột dưới datagridview hiển thị lên trên:
        private void dGDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDH.Text = dGDonHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbKhachHang.Text = dGDonHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbNhanVien.Text = dGDonHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpNgayDatHang.Text = dGDonHang.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //Thêm ĐH:
        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDonBan donHang= new HoaDonBan();
            donHang.MaKH = int.Parse(cbKhachHang.SelectedValue.ToString());
            donHang.MaNV = int.Parse(cbNhanVien.SelectedValue.ToString());
            donHang.NgayGioMua = dtpNgayDatHang.Value;

            //Gọi sự kiện thêm của BUS:
            if (busDH.ThemDH(donHang))
            {
                MessageBox.Show("Thêm đơn hàng thành công");
                busDH.LayDSDonHang(dGDonHang);
            }
            else
            {
                MessageBox.Show("Thêm đơn hàng thất bại");
            }
        }

        //Sửa ĐH:
        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDonBan donHang = new HoaDonBan();
            donHang.MaHD = int.Parse(txtMaDH.Text);//Kiểm tra đh có tồn tại hay k?
            donHang.MaKH = int.Parse(cbKhachHang.SelectedValue.ToString());
            donHang.MaNV = int.Parse(cbNhanVien.SelectedValue.ToString());
            donHang.NgayGioMua = dtpNgayDatHang.Value;

            //Gọi sự kiện sửa của BUS:
            if (busDH.SuaDH(donHang))
            {
                MessageBox.Show("Sửa đơn hàng thành công");
                busDH.LayDSDonHang(dGDonHang);
            }
            else
            {
                MessageBox.Show("Sửa đơn hàng thất bại");
            }
        }

        //Xóa ĐH:
        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDonBan dh = new HoaDonBan();
            dh.MaHD = int.Parse(txtMaDH.Text);

            //Gọi sự kiện xóa của BUS:
            if (busDH.XoaDH(dh))
            {
                MessageBox.Show("Xóa đơn hàng thành công");
                busDH.LayDSDonHang(dGDonHang);
            }
            else
            {
                MessageBox.Show("Xóa đơn hàng thất bại");
            }
        }

        //Thoát:
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dGDonHang_DoubleClick(object sender, EventArgs e)
        {
            //Lấy mã đơn hàng: để lấy được mã đơn hàng phải biết người ta click vào dòng nào
            int ma;
            ma = int.Parse(dGDonHang.CurrentRow.Cells[0].Value.ToString());//CurrentRow:dòng đang click, Cells[0]:ô đầu tiên

            //Truyền ma cho form CTDH:
            Hide();
            ChiTietDonHang f = new ChiTietDonHang();
            f.maDH= ma; // truyền được mã qua form CTDH
            f.ShowDialog();
        }

        private void pBQuayLai_Click(object sender, EventArgs e)
        {
            Hide();
            TChinh f = new TChinh();
            f.ShowDialog();
        }
    }
}
