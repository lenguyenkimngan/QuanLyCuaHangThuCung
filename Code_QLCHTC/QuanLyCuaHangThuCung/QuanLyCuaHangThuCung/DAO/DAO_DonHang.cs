using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangThuCung.DAO
{
    class DAO_DonHang
    {
        QuanLyCuaHangThuCungEntities db;

        public DAO_DonHang()
        {
            db = new QuanLyCuaHangThuCungEntities();
        }

        //Lấy DSDH từ database:
        public dynamic LayDSDonHang()
        {
            var ds = db.HoaDonBans.Select(s => new
            {
                s.MaHD,
                s.KhachHang.HoTenKH,
                s.NhanVien.HoTenNV,
                s.NgayGioMua
            }).ToList();
            return ds;
        }

        //Lấy DSKH:
        public dynamic LayDSKhachHang()
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.MaKH,
                s.HoTenKH
            }).ToList();
            return ds;
        }
        //Lấy DSNV:
        public dynamic LayDSNhanVien()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.MaNV,
                s.HoTenNV
            }).ToList();
            return ds;
        }

        //Thêm ĐH:
        public void ThemDonHang(HoaDonBan dh)
        {
            db.HoaDonBans.Add(dh);
            db.SaveChanges();
        }

        //Sửa ĐH: 
        //Kiểm tra đh có tồn tại hay không?
        public bool KiemTraDH(HoaDonBan dh)
        {
            HoaDonBan dhang = db.HoaDonBans.Find(dh.MaHD);
            if (dh != null)
            {
                return true;
            }
            else
                return false;
        }
        //Sửa sản phẩm:
        public void SuaDH(HoaDonBan dh)
        {
            HoaDonBan dhang = db.HoaDonBans.Find(dh.MaHD);
            dhang.MaHD = dh.MaHD;
            dhang.MaKH = dh.MaKH;
            dhang.MaNV = dh.MaNV;
            dh.NgayGioMua = dh.NgayGioMua;
            db.SaveChanges();
        }

        //Xóa ĐH:
        public void XoaDH(HoaDonBan dh)
        {
            HoaDonBan dhang = db.HoaDonBans.Find(dh.MaHD);
            db.HoaDonBans.Remove(dhang);
            db.SaveChanges();
        }

        //Lấy DSCTĐH:
        public dynamic DSCTDH(int maDH)
        {
            //Ktra maDH có hay ko. Nếu có lấy về DS, k có thì k lấy:
            var ds = db.ChiTietHDBans.Where(s => s.MaHD == maDH).
                Select(s => new
                {
                    s.MaHD,
                    s.SanPham.TenSP,
                    s.SoLuong,
                    s.DonGia,
                    s.TyLeGiamGia
                }).ToList();
            return ds;
        }
    }
}
