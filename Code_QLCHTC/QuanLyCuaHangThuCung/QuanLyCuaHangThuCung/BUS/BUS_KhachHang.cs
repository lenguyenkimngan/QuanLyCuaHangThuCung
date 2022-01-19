using QuanLyCuaHangThuCung.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.BUS
{
    class BUS_KhachHang
    {
        DAO_KhachHang dKhachHang;

        public BUS_KhachHang()
        {
            dKhachHang = new DAO_KhachHang();
        }

        //Lấy DSKH gửi cho GUI:
        public void LayDSKhachHang(DataGridView dg)
        {
            dg.DataSource = dKhachHang.LayDSKhachHang();
        }

        //Thêm KH:
        public bool ThemKH(KhachHang kh)
        {
            try
            {
                dKhachHang.ThemKhachHang(kh);
                return true;
            }
            catch (Exception)
            {

                return false;
            }           
        }

        //Sửa KH:
        public bool SuaKH(KhachHang kh)
        {
            //kiểm tra khách hàng có tồn tại hay ko?
            if (dKhachHang.KiemTraKH(kh))
            {
                try
                {
                    dKhachHang.SuaKH(kh);
                    return true; //Sửa
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Xóa KH:
        public bool XoaKH(KhachHang kh)
        {
            if (dKhachHang.KiemTraKH(kh))
            {
                try
                {
                    dKhachHang.XoaKH(kh);
                    return true; //Sửa
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Tìm KH:
        public void TimKhachHang(DataGridView dg, String kW)
        {
            dg.DataSource = dKhachHang.TimKhachHang(kW);
        }
    }
}
