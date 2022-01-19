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
    public partial class ChiTietDonHang : Form
    {
        public int maDH;// truyền dữ liệu từ form QuanLyDonHang qua cho form ChiTietDonHang 
        BUS_CTDH busCTDH;
        BUS_DonHang bDH;
        BUS_SanPham busSP;
        bool co = false;

        public ChiTietDonHang()
        {
            InitializeComponent();
            busCTDH = new BUS_CTDH();
            bDH = new BUS_DonHang();
            busSP = new BUS_SanPham();
        }

        private void HienThiDSCTDH()
        {
            dGCTDH.DataSource = null;
            busCTDH.LayDSCTDH(dGCTDH, maDH);
            //Định dạng datagridview:
            dGCTDH.Columns[0].Width = (int)(dGCTDH.Width * 0.1);
            dGCTDH.Columns[1].Width = (int)(dGCTDH.Width * 0.4);
            dGCTDH.Columns[2].Width = (int)(dGCTDH.Width * 0.15);
            dGCTDH.Columns[3].Width = (int)(dGCTDH.Width * 0.15);
            dGCTDH.Columns[4].Width = (int)(dGCTDH.Width * 0.15);
        }

        private void ChiTietDonHang_Load(object sender, EventArgs e)
        {
            HienThiDSCTDH();
            busCTDH.LayDSCTDHang(cbTenSP);
           // LayDSCTDH(maDH);
            co = true;
        }

        private void dGCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDH.Text = dGCTDH.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbTenSP.Text = dGCTDH.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoLuong.Text = dGCTDH.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDonGia.Text = dGCTDH.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGiamGia.Text = dGCTDH.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        //Thêm CTDH:
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChiTietHDBan cTHD = new ChiTietHDBan();
            cTHD.MaHD = int.Parse(txtMaDH .Text);
            cTHD.MaSP = int.Parse(cbTenSP.SelectedValue.ToString());
            cTHD.SoLuong = int.Parse(txtSoLuong.Text);
            cTHD.TyLeGiamGia = float.Parse(txtGiamGia.Text);
            cTHD.DonGia = decimal.Parse(txtDonGia.Text);

            //Gọi sự kiện thêm của BUS:
            if (busCTDH.ThemCTDH(cTHD))
            {
                MessageBox.Show("Thêm chi tiết đơn hàng thành công");
                busCTDH.LayDSCTDH(dGCTDH,maDH);
            }
            else
            {
                MessageBox.Show("Thêm chi tiết đơn hàng thất bại");
            }
        }
        //Xóa CTĐH:
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiTietHDBan ct = new ChiTietHDBan();
            ct.MaHD = int.Parse(txtMaDH.Text);
            ct.MaSP = int.Parse(dGCTDH.CurrentRow.Cells[0].Value.ToString());

            //Gọi sự kiện xóa của BUS:
            if (busCTDH.XoaCTDH(ct))
            {
                MessageBox.Show("Xóa chi tiết đơn hàng thành công");
                busCTDH.LayDSCTDH(dGCTDH,maDH);
            }
            else
            {
                MessageBox.Show("Xóa chi tiết đơn hàng thất bại");
            }
        }

        //Sửa CTĐH:
        private void btnSua_Click(object sender, EventArgs e)
        {
            ChiTietHDBan chiTiet = new ChiTietHDBan();
            int soLuong = int.Parse(txtSoLuong.Text);
            chiTiet.MaHD = int.Parse(txtMaDH.Text);//Kiểm tra đơn hàng có tồn tại hay k?
            chiTiet.SoLuong = soLuong;
            chiTiet.DonGia = decimal.Parse(txtDonGia.Text);
            chiTiet.TyLeGiamGia = float.Parse(txtGiamGia.Text);
            chiTiet.MaSP = int.Parse(cbTenSP.SelectedValue.ToString());

            //Gọi sự kiện sửa của BUS:
            if (busCTDH.SuaCTDH(chiTiet))
            {
                MessageBox.Show("Sửa chi tiết đơn hàng thành công");
                //busCTDH.LayDSCTDH(dGCTDH,maDH);
                HienThiDSCTDH();
            }
            else
            {
                MessageBox.Show("Sửa chi tiết đơn hàng thất bại");
            }
        }
 
        //private void LayDSCTDH(int ma)
        //{
        //    dGCTDH.DataSource = null;
        //    bDH.LayDSCTDonHang(dGCTDH,ma);
        //}

        private void ChiTietDonHang_Activated(object sender, EventArgs e)
        {
            //LayDSCTDH(maDH);
            txtMaDH.Text = maDH.ToString();
        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                SanPham sp;
                int maSP;

                maSP = int.Parse(cbTenSP.SelectedValue.ToString());
                sp = busSP.LayThongTinSP(maSP);
                //txtNCC.Text = p.Supplier.CompanyName.ToString();
                txtDonGia.Text = sp.GiaSP.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pBQuayLai_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyDonHang f = new QuanLyDonHang();
            f.ShowDialog();
        }
    }
}
