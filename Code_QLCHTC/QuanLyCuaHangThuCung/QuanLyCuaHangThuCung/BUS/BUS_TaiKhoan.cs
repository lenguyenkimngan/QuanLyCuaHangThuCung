using QuanLyCuaHangThuCung.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangThuCung.BUS
{
    class BUS_TaiKhoan
    {
        DAO_TaiKhoan dTaiKhoan;
        public BUS_TaiKhoan()
        {
            dTaiKhoan = new DAO_TaiKhoan();
        }


        //Thêm TK:
        public bool ThemTK(TaiKhoan tk)
        {
            try
            {
                dTaiKhoan.ThemTaiKhoan(tk);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public TaiKhoan LayTTTaiKhoan(string tk, string mk)
        {
           return dTaiKhoan.LayTTTaiKhoan(tk, mk);
        }
    }
}
