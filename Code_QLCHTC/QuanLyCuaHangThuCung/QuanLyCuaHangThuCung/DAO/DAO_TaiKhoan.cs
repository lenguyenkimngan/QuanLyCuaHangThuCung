using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangThuCung.DAO
{
    class DAO_TaiKhoan
    {
        QuanLyCuaHangThuCungEntities db;

        public DAO_TaiKhoan()
        {
            db = new QuanLyCuaHangThuCungEntities();
        }

        public void ThemTaiKhoan(TaiKhoan tk)
        {
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
        }

        //Lấy TTTK:
        public TaiKhoan LayTTTaiKhoan(string tk, string mk)
        {
            TaiKhoan tkhoan = db.TaiKhoans.Where(s => s.TenDangNhap.Contains(tk) && s.MatKhau.Contains(mk)).FirstOrDefault();
            return tkhoan;
        }
    }
}
