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
    class BUS_CTDH
    {
        DAO_CTDH dCTDH;
        
        public BUS_CTDH()
        {
            dCTDH = new DAO_CTDH();
        }

        //Lấy DSCTDH gửi cho GUI;
        public void LayDSCTDH(DataGridView dg, int maDH)
        {
            dg.DataSource = dCTDH.LayDSCTDH(maDH);
        }

        //Lấy DSTenSP:
        public void LayDSCTDHang(ComboBox cb)
        {
            cb.DataSource = dCTDH.LayDSCTDHang();
            cb.DisplayMember = "TenSP";
            cb.ValueMember = "MaSP";
        }

        //Thêm CTDH:
        public bool ThemCTDH(ChiTietHDBan ct)
        {
            try
            {
                dCTDH.ThemCTDH(ct);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Sửa CTDH:
        public bool SuaCTDH(ChiTietHDBan ct)
        {
            //kiểm tra đơn hàng có tồn tại hay ko?
            if (dCTDH.KiemTraCTDH(ct))
            {
                try
                {
                    dCTDH.SuaCTDH(ct);
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

        //Xóa CTĐH:
        public bool XoaCTDH(ChiTietHDBan ct)
        {
            if (dCTDH.KiemTraCTDH(ct))
            {
                try
                {
                    dCTDH.XoaCTDH(ct);
                    return true; //Xóa
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
