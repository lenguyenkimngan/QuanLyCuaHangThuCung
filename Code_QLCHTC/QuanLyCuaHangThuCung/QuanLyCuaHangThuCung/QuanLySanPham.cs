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
    public partial class QuanLySanPham : Form
    {
        BUS_SanPham busSP;
        public QuanLySanPham()
        {
            InitializeComponent();
            busSP = new BUS_SanPham();
        }

        private void HienThiDSSanPham()
        {
            dGSanPham.DataSource = null;
            busSP.LayDSSanPham (dGSanPham);
            //Định dạng datagridview:
            dGSanPham.Columns[0].Width = (int)(dGSanPham.Width * 0.07);
            dGSanPham.Columns[1].Width = (int)(dGSanPham.Width * 0.3);
            dGSanPham.Columns[2].Width = (int)(dGSanPham.Width * 0.1);
            dGSanPham.Columns[3].Width = (int)(dGSanPham.Width * 0.15);
            dGSanPham.Columns[4].Width = (int)(dGSanPham.Width * 0.16);
            dGSanPham.Columns[5].Width = (int)(dGSanPham.Width * 0.3);
        }
        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            busSP.LayDSLoaiSP(cbLoaiSP);
        }

        //Xử lý nhấn vào 1 cột dưới datagridview hiển thị lên trên:
        private void dGSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dGSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSP.Text = dGSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGiaSP.Text = dGSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
            if(dGSanPham.Rows[e.RowIndex].Cells[3].Value != null)
            {
                txtKichThuoc.Text = dGSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            if (dGSanPham.Rows[e.RowIndex].Cells[4].Value != null)
            {
                txtTrongLuong.Text = dGSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            cbLoaiSP.Text = dGSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        //THÊM SP:
        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.TenSP = txtTenSP.Text;
            sanPham.GiaSP = int.Parse(txtGiaSP.Text);
            sanPham.KichThuocSP = txtKichThuoc.Text;
            sanPham.TrongLuongSP = txtTrongLuong.Text;
            sanPham.MaLoaiSP = int.Parse(cbLoaiSP.SelectedValue.ToString());

            //Gọi sự kiện thêm của BUS:
            if (busSP.ThemSP(sanPham))
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                busSP.LayDSSanPham(dGSanPham);
            }
            else
            {
               MessageBox.Show("Thêm sản phẩm thất bại");
            }
        }

        //SỬA SP:
        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();           
            sanPham.MaSP = int.Parse(txtMaSP.Text);//Kiểm tra sp có tồn tại hay k?
            sanPham.TenSP = txtTenSP.Text;
            sanPham.GiaSP = int.Parse(txtGiaSP.Text);
            sanPham.KichThuocSP = txtKichThuoc.Text;
            sanPham.TrongLuongSP = txtTrongLuong.Text;
            sanPham.MaLoaiSP = int.Parse(cbLoaiSP.SelectedValue.ToString());

            //Gọi sự kiện sửa của BUS:
            if (busSP.SuaSP(sanPham))
            {
                MessageBox.Show("Sửa sản phẩm thành công");
                busSP.LayDSSanPham(dGSanPham);
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại");
            }
        }

        //XOÁ SP:
        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = int.Parse(txtMaSP.Text);

            //Gọi sự kiện xóa của BUS:
            if (busSP.XoaSP(sp))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                busSP.LayDSSanPham(dGSanPham);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }
        }

        //Thoát:
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Tìm SP:
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                HienThiDSSanPham();
            }
            else
            {
                busSP.TimSanPham(dGSanPham, txtTimKiem.Text);
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
