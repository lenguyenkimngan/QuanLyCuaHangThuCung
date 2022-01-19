using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangThuCung.DAO
{
    class DAO_NhanVien
    {
        QuanLyCuaHangThuCungEntities db;
        
        public DAO_NhanVien()
        {
            db = new QuanLyCuaHangThuCungEntities();
        }

        //Lấy DSNV từ database:
        public dynamic LayDSNhanVien()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.MaNV,
                s.HoTenNV,
                s.GioiTinh,
                s.NgaySinh,
                s.SDT,
                s.DiaChi,
                s.EMAIL
            }).ToList();
            return ds;
        }

        public dynamic LayDSNhanVienTK()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.MaNV,
                s.HoTenNV
            }).ToList();
            return ds;
        }

        //Thêm NV:
        public void ThemNhanVien(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }

        //Sửa NV: 
            //Kiểm tra nv có tồn tại hay không?
        public bool KiemTraNV(NhanVien nv)
        {
            NhanVien nvien = db.NhanViens.Find(nv.MaNV);
            if (nv != null)
            {
                return true;
            }
            else
                return false;
        }

            //Sửa nhân viên:
        public void SuaNV(NhanVien nv)
        {
            NhanVien nvien = db.NhanViens.Find(nv.MaNV);
            nvien.NgaySinh = nv.NgaySinh;
            nvien.GioiTinh = nv.GioiTinh;
            nvien.HoTenNV = nv.HoTenNV;
            nvien.SDT = nv.SDT;
            nvien.DiaChi = nv.DiaChi;
            nvien.EMAIL = nv.EMAIL;
            db.SaveChanges();
        }

            //Xóa NV:
        public void XoaNV(NhanVien nv)
        {
            NhanVien nvien = db.NhanViens.Find(nv.MaNV);
            db.NhanViens.Remove(nvien);
            db.SaveChanges();
        }

        //Tìm NV:
        public dynamic TimNhanVien(string kW)
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.MaNV,
                s.HoTenNV,
                s.GioiTinh,
                s.NgaySinh,
                s.SDT,
                s.DiaChi,
                s.EMAIL
            }).Where(b => b.HoTenNV.Contains(kW) || b.GioiTinh.Contains(kW) || b.DiaChi.Contains(kW) || b.SDT.Contains(kW) || b.EMAIL.Contains(kW)).ToList();
            return ds;
        }

    }
}
