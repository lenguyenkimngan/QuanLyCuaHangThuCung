using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangThuCung.DAO
{
    class DAO_SanPham
    {
        QuanLyCuaHangThuCungEntities db;

        public DAO_SanPham()
        {
            db = new QuanLyCuaHangThuCungEntities();
        }

        //Lấy DSSP:
        public dynamic LayDSSanPham()
        {
            var ds = db.SanPhams.Select(s => new
            {
                s.MaSP,
                s.TenSP,
                s.GiaSP,
                s.KichThuocSP,
                s.TrongLuongSP,
                s.LoaiSP.TenLoaiSP       
            }).ToList();
            return ds;
        }

        //Lấy DSLoạiSP hiện ra combobox:
        public dynamic LayDSLoaiSP()
        {
            var ds = db.LoaiSPs.Select(s => new
            {
                s.MaLoaiSP,
                s.TenLoaiSP                
            }).ToList();
            return ds;
        }


        //Thêm SP:
        public void ThemSanPham(SanPham sp)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges();
        }

        //Sửa SP: 
        //Kiểm tra sp có tồn tại hay không?
        public bool KiemTraSP(SanPham sp)
        {
            SanPham spham = db.SanPhams.Find(sp.MaSP);
            if (sp != null)
            {
                return true;
            }
            else
                return false;
        }

        //Sửa sản phẩm:
        public void SuaSP(SanPham sp)
        {
            SanPham spham = db.SanPhams.Find(sp.MaSP);
            spham.TenSP = sp.TenSP;
            spham.GiaSP = sp.GiaSP;
            spham.KichThuocSP = sp.KichThuocSP;
            spham.TrongLuongSP = sp.TrongLuongSP;
            spham.MaLoaiSP = sp.MaLoaiSP;
            db.SaveChanges();
        }

        //Xóa SP:
        public void XoaSP(SanPham sp)
        {
            SanPham spham = db.SanPhams.Find(sp.MaSP);
            db.SanPhams.Remove(spham);
            db.SaveChanges();
        }

        //Tìm SP:
        public dynamic TimSanPham(string kW)
        {
            var ds = db.SanPhams.Select(s => new
            {
                s.MaSP,
                s.TenSP,
                s.GiaSP,
                s.KichThuocSP,
                s.TrongLuongSP,
                s.LoaiSP.TenLoaiSP
            }).Where(b => b.TenSP.Contains(kW) || b.KichThuocSP.Contains(kW) || b.TrongLuongSP.Contains(kW) || b.TenLoaiSP.Contains(kW)).ToList();
            return ds;
        }

        public SanPham LayThongTinSP(int maSP)
        {
            SanPham p = db.SanPhams.Where(s => s.MaSP == maSP).FirstOrDefault();

            return p;
        }
    }   
}
