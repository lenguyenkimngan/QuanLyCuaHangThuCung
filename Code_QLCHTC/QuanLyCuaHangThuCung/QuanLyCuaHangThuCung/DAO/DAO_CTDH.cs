using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.DAO
{
    class DAO_CTDH
    {
        QuanLyCuaHangThuCungEntities db;
        
        public DAO_CTDH()
        {
            db = new QuanLyCuaHangThuCungEntities();
        }

        //Lấy CTDH từ database:
        public dynamic LayDSCTDH(int maDH)
        {
            var ds = db.ChiTietHDBans.Where(s => s.MaHD == maDH)
                .Select(s => new {
                    s.SanPham.MaSP,
                    s.SanPham.TenSP,
                    s.SoLuong,
                    s.DonGia,
                    s.TyLeGiamGia
                }).ToList();
            return ds;
        }

        //Lấy DSCTDH hiện ra combobox:
        public dynamic LayDSCTDHang()
        {
            var ds = db.SanPhams.Select(s => new
            {
                s.TenSP,
                s.MaSP
            }).ToList();
            return ds;
        }

        //Thêm CTDH:
        public void ThemCTDH(ChiTietHDBan ct)
        {
            db.ChiTietHDBans.Add(ct);
            db.SaveChanges();
        }

        //Sửa CTDH: 
        //Kiểm tra đơn hàng có tồn tại hay không?
        public bool KiemTraCTDH(ChiTietHDBan ct)
        {
            ChiTietHDBan chiTiet = db.ChiTietHDBans.Where(c => (c.MaSP == ct.MaSP)).First();
            if (ct != null)
            {
                return true;
            }
            else
                return false;
        }

        //Sửa đơn hàng:
        public void SuaCTDH(ChiTietHDBan ct)
        {
            ChiTietHDBan chiTiet = db.ChiTietHDBans.Where(c => (c.MaSP == ct.MaSP)).First();
            chiTiet.SoLuong = ct.SoLuong;
            chiTiet.DonGia = ct.DonGia;
            chiTiet.TyLeGiamGia = ct.TyLeGiamGia;
            db.SaveChanges();
        }

        //Xóa CTDH:
        public void XoaCTDH(ChiTietHDBan ct)
        {
            ChiTietHDBan chiTiet = db.ChiTietHDBans.Where(c => (c.MaSP == ct.MaSP)).First();
            db.ChiTietHDBans.Remove(chiTiet);
            db.SaveChanges();
        }

    }
}
