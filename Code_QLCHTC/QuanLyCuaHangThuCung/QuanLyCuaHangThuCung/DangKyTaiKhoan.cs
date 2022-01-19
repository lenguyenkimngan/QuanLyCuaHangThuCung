using QuanLyCuaHangThuCung.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung
{
    public partial class DangKyTaiKhoan : Form
    {
        BUS_NhanVien busNV;
        BUS_TaiKhoan busTK;
        public DangKyTaiKhoan()
        {
            InitializeComponent();
            busTK = new BUS_TaiKhoan();
            busNV = new BUS_NhanVien();
        }

        private void DangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            busNV.LayDSNVTK(cbMaNV); 
        }

       //Chữ ẩn bên dưới textbox:
        private void txtTenDN_Enter(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "Tên đăng nhập")
            {
                txtTenDN.Text = "";
                txtTenDN.ForeColor = Color.Teal;
            }
        }
        private void txtTenDN_Leave(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "")
            {
                txtTenDN.Text = "Tên đăng nhập";
                txtTenDN.ForeColor = Color.DarkGray;
            }
        }

        private void txtMK_Enter(object sender, EventArgs e)
        {
            if (txtMK.Text == "Mật khẩu")
            {
                txtMK.Text = "";
                txtMK.ForeColor = Color.Teal;
            }
        }
        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                txtMK.Text = "Mật khẩu";
                txtMK.ForeColor = Color.DarkGray;
            }
        }

        private void txtXacNhanMK_Enter(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text == "Xác nhận mật khẩu")
            {
                txtXacNhanMK.Text = "";
                txtXacNhanMK.ForeColor = Color.Teal;
            }
        }
        private void txtXacNhanMK_Leave(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text == "")
            {
                txtXacNhanMK.Text = "Xác nhận mật khẩu";
                txtXacNhanMK.ForeColor = Color.DarkGray;
            }
        }

        private void txtLoaiTK_Enter(object sender, EventArgs e)
        {
            if (txtLoaiTK.Text == "Loại tài khoản")
            {
                txtLoaiTK.Text = "";
                txtLoaiTK.ForeColor = Color.Teal;
            }
        }
        private void txtLoaiTK_Leave(object sender, EventArgs e)
        {
            if (txtLoaiTK.Text == "")
            {
                txtLoaiTK.Text = "Loại tài khoản";
                txtLoaiTK.ForeColor = Color.DarkGray;
            }
        }

       //ĐĂNG KÝ:
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào tên đăng nhập");
                txtTenDN.Focus();
            }
            else if (txtMK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào mật khẩu");
                txtMK.Focus();
            }
            else if (txtMK.Text != txtXacNhanMK.Text) // ràng buộc mk và xác nhận mk phải giống nhau
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không giống nhau");
                txtXacNhanMK.Focus();
                txtXacNhanMK.SelectAll();
            }

            ////Kiểm tra mật khẩu phải hợp lệ theo đúng định dạng
            //else
            //{
            //    NguoiDung nd = new NguoiDung();  

            //    if (nd.KiemTraDinhDangMK() == true)
            //    {
            //        MessageBox.Show("Mật khẩu hợp lệ");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Mật khẩu không hợp lệ");
            //    }
            //}

         //ĐĂNG KÍ TÀI KHOẢN:
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.TenDangNhap = txtTenDN.Text;
            taikhoan.MatKhau = txtMK.Text;
            taikhoan.LoaiTK = txtLoaiTK.Text;
            taikhoan.MaNV = int.Parse(cbMaNV.SelectedValue.ToString());

                //Gọi sự kiện thêm của BUS:
            if (busTK.ThemTK(taikhoan))
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }

            Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void pBQuayLai_Click(object sender, EventArgs e)
        {
            DangKyThongTin dktt = new DangKyThongTin();
            this.Hide();
            dktt.ShowDialog();
            this.Show();
        }
    }
}
