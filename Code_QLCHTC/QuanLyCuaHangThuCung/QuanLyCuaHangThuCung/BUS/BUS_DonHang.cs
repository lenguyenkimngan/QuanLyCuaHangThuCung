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
    class BUS_DonHang
    {
        DAO_DonHang dDonHang;
    

        public BUS_DonHang()
        {
            dDonHang = new DAO_DonHang();
        }
        //Lấy DSDH gửi cho GUI;
        public void LayDSDonHang(DataGridView dg)
        {
            dg.DataSource = dDonHang.LayDSDonHang();
        }

        //Lấy DSCTĐH:
        public void LayDSCTDonHang(DataGridView dg, int maDH)
        {
            dg.DataSource = dDonHang.DSCTDH(maDH);
        }

        public void LayDSKH(ComboBox cb)
        {
            cb.DataSource = dDonHang.LayDSKhachHang();
            cb.DisplayMember = "HoTenKH";
            cb.ValueMember = "MaKH";
        }
        public void LayDSNV(ComboBox cb)
        {
            cb.DataSource = dDonHang.LayDSNhanVien();
            cb.DisplayMember = "HoTenNV";
            cb.ValueMember = "MaNV";
        }

        //Thêm ĐH:
        public bool ThemDH(HoaDonBan dh)
        {
            try
            {
                dDonHang.ThemDonHang(dh);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        //Sửa ĐH:
        public bool SuaDH(HoaDonBan dh)
        {
            //kiểm tra dh có tồn tại hay ko?
            if (dDonHang.KiemTraDH(dh))
            {
                try
                {
                    dDonHang.SuaDH(dh);
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

        //Xóa ĐH:
        public bool XoaDH(HoaDonBan dh)
        {
            if (dDonHang.KiemTraDH(dh))
            {
                try
                {
                    dDonHang.XoaDH(dh);
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
    }
}
