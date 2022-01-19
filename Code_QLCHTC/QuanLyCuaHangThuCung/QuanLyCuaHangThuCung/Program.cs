using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrangChu());
            //Application.Run(new ThongTin());
            // Application.Run(new QuanLyNhanVien());
            //Application.Run(new QuanLyKhachHang());
            //Application.Run(new QuanLySanPham());
            //Application.Run(new QuanLyDonHang());
            //Application.Run(new ChiTietDonHang());
            //Application.Run(new DangKyThongTin());
             //Application.Run(new DangKyTaiKhoan());
            // Application.Run(new DangNhap());
            //Application.Run(new TChinh());

        }
    }
}
