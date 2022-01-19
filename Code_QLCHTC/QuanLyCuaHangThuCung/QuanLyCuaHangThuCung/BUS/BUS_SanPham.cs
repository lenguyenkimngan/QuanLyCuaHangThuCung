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
    class BUS_SanPham
    {
        DAO_SanPham dSanPham;

        public BUS_SanPham()
        {
            dSanPham = new DAO_SanPham();
        }

        //Lấy DSSP gửi cho GUI;
        public void LayDSSanPham(DataGridView dg)
        {
            dg.DataSource = dSanPham.LayDSSanPham();
        }

        //Lấy DSLoaiSP:
        public void LayDSLoaiSP(ComboBox cb)
        {
            cb.DataSource = dSanPham.LayDSLoaiSP();
            cb.DisplayMember = "TenLoaiSP";
            cb.ValueMember = "MaLoaiSP";
        }

        //Thêm SP:
        public bool ThemSP(SanPham sp)
        {
            try
            {
                dSanPham.ThemSanPham(sp);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Sửa SP:
        public bool SuaSP(SanPham sp)
        {
            //kiểm tra sp có tồn tại hay ko?
            if (dSanPham.KiemTraSP(sp))
            {
                try
                {
                    dSanPham.SuaSP(sp);
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

        //Xóa SP:
        public bool XoaSP(SanPham sp)
        {
            if (dSanPham.KiemTraSP(sp))
            {
                try
                {
                    dSanPham.XoaSP(sp);
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

        //Tìm SP:
        public void TimSanPham(DataGridView dg, String kW)
        {
            dg.DataSource = dSanPham.TimSanPham(kW);
        }

        public SanPham LayThongTinSP(int maSP)
        {
            return dSanPham.LayThongTinSP(maSP);
        }
    }
}
