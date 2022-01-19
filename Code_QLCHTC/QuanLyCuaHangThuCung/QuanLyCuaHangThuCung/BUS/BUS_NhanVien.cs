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
    class BUS_NhanVien
    {
        DAO_NhanVien dNhanVien;
        public BUS_NhanVien()
        {
            dNhanVien = new DAO_NhanVien();
        }

        //Lấy DSNV gửi cho GUI;
        public void LayDSNhanVien(DataGridView dg)
        {
            dg.DataSource = dNhanVien.LayDSNhanVien();
        }

        public void LayDSNV(ComboBox cb)
        {
            cb.DataSource = dNhanVien.LayDSNhanVien();
            cb.DisplayMember = "HoTenNV";
            cb.ValueMember = "MaNV";
        }

        public void LayDSNVTK(ComboBox cb)
        {
            cb.DataSource = dNhanVien.LayDSNhanVienTK();
            cb.DisplayMember = "HoTenNV";
            cb.ValueMember = "MaNV";
        }

        //Thêm NV:
        public bool ThemNV(NhanVien nv)
        {
            try
            {
                dNhanVien.ThemNhanVien(nv);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Sửa NV:
        public bool SuaNV(NhanVien nv)
        {
            //kiểm tra nv có tồn tại hay ko?
            if (dNhanVien.KiemTraNV(nv))
            {
                try
                {
                    dNhanVien.SuaNV(nv);
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

        //Xóa NV:
        public bool XoaNV(NhanVien nv)
        {
            if (dNhanVien.KiemTraNV(nv))
            {
                try
                {
                    dNhanVien.XoaNV(nv);
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

        //Tìm NV:
        public void TimNhanVien(DataGridView dg, String kW)
        {
            dg.DataSource = dNhanVien.TimNhanVien(kW);
        }
    }
}
