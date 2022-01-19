using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangThuCung.DAO
{
    class DAO_KhachHang
    {
       QuanLyCuaHangThuCungEntities db;
    
        public DAO_KhachHang()
        {
            db = new QuanLyCuaHangThuCungEntities();
        }

        public dynamic LayDSKhachHang()
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.MaKH,
                s.HoTenKH,
                s.GioiTinh,
                s.NgaySinh,
                s.SDT,
                s.DiaChi,
                s.EMAIL
            }).ToList();
            return ds;
        }

        //Thêm KH:
        public void ThemKhachHang(KhachHang kh)
        {
            db.KhachHangs.Add(kh);
            db.SaveChanges();
        }

        //Sửa KH:
            //Kiểm tra KH có hay không?
        public bool KiemTraKH(KhachHang kh)
        {
            KhachHang khHang = db.KhachHangs.Find(kh.MaKH);
            if (kh != null)
            {
                return true;
            }
            else
                return false;
        }

            //Sửa khách hàng:
        public void SuaKH(KhachHang kh)
        {
            KhachHang khHang = db.KhachHangs.Find(kh.MaKH);
            khHang.NgaySinh = kh.NgaySinh;
            khHang.GioiTinh = kh.GioiTinh;
            khHang.HoTenKH = kh.HoTenKH;
            khHang.SDT = kh.SDT;
            khHang.DiaChi = kh.DiaChi;
            khHang.EMAIL = kh.EMAIL;
            db.SaveChanges();
        }

        //Xóa KH:
        public void XoaKH(KhachHang kh)
        {
            KhachHang khHang = db.KhachHangs.Find(kh.MaKH);
            db.KhachHangs.Remove(khHang);
            db.SaveChanges();
        }

        //Tìm KH:
        public dynamic TimKhachHang(string kW)
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.MaKH,
                s.HoTenKH,
                s.GioiTinh,
                s.NgaySinh,
                s.SDT,
                s.DiaChi,
                s.EMAIL
            }).Where(b => b.HoTenKH.Contains(kW) || b.GioiTinh.Contains(kW) || b.DiaChi.Contains(kW) || b.SDT.Contains(kW)).ToList();
            return ds;
        }
    }
}
