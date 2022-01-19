
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
    public partial class DangNhap : Form
    {
        BUS_TaiKhoan  bTK;
        public DangNhap()
        {
            InitializeComponent();
            // HienThiDSTaiKhoan();
            bTK = new BUS_TaiKhoan();
        }
        private string tenDangNhap;
        private string matKhau;


        public DangNhap(string ten, string mk)
        {
            InitializeComponent();
            this.tenDangNhap = ten;
            this.matKhau = mk;
        }

        public DangNhap(string text)
        {
            Text = text;
        }

        bool co = true;

          
        SqlConnection connection = new SqlConnection(@"Data Source=NGANLE\SERVERQT;Initial Catalog=QuanLyCuaHangThuCung;User ID=sa");

        private string ten, matkhau;

        private void ktDL()
        {
            try
            {
                if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
                {
                    ten = txtTenDangNhap.Text;
                    matkhau = txtMatKhau.Text;
                    connection.Open();
                    string sql = "SELECT TenDangNhap, MatKhau FROM TaiKhoan WHERE TenDangNhap = '" + ten + "'and MatKhau = '" + matkhau + "'";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        if (MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            co = false;
                            Hide();
                            TChinh f = new TChinh();
                            f.ShowDialog();
                            f.taiKhoan = bTK.LayTTTaiKhoan(ten, matKhau);
                          Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn không tồn tại!");
                        txtTenDangNhap.Text = txtMatKhau.Text = "";
                    }
                    connection.Close();
                }
                else
                    MessageBox.Show("Vui lòng nhập thông tin để đăng nhập!");
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi kết nối !");
            }
        }


        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
            txtMatKhau.Focus();
        }
        private void lbDangNhap_Click(object sender, EventArgs e)
        {

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ktDL();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKyThongTin dk = new DangKyThongTin();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }

        private void lbXoaTatCa_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Focus();
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo!",
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
               
            }
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Teal;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.DarkGray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Teal;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.DarkGray;
            }
        }
    }
}
