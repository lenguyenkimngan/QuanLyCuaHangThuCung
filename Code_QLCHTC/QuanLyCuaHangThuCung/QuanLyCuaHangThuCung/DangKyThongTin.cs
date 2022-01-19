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
    public partial class DangKyThongTin : Form
    {
        string connectionString = @"Data Source=NGANLE\SERVERQT;Initial Catalog=QuanLyCuaHangThuCung;User ID=sa";
        public DangKyThongTin()
        {
            InitializeComponent();
        }

        //private void DangKy_Load(object sender, EventArgs e)
        //{

        //}

        //private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        //{

        //}

        // bool co = true;
        // SqlConnection connection = new SqlConnection(@"Data Source=NGANLE\SERVERQT;Initial Catalog=QuanLyCuaHangThuCung;User ID=sa");


        //private void luuDuLieu(string gioiTinh, DateTime date)
        //{
        //connection.Open();
        // string sql2 = @"INSERT INTO dbo.NhanVien (HoTenNV, NgaySinh, GioiTinh, SDT, Email, DiaChi)
        // VALUES (@HoTenNV, @NgaySinh, @GioiTinh, @SDT, @Email, @DiaChi);";
        //using (SqlCommand cmd = connection.CreateCommand())
        //{

        //cmd.CommandText = sql2;
        //cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDN);
        // cmd.Parameters.AddWithValue("@MatKhau", txtMK);
        //cmd.Parameters.AddWithValue("@HoTenNV", txtHoTen);
        //cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
        //cmd.Parameters.AddWithValue("@SDT", txtSDT);
        //cmd.Parameters.AddWithValue("@Email", txtEmail);
        //cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi);
        //cmd.Parameters.AddWithValue("@NgaySinh", string.Format("{0}/{1}/{2}", date.Day, date.Month, date.Year));
        //cmd.ExecuteNonQuery();
        // }
        // connection.Close();
        //}

        private void luuDL(DateTime date, string gioiTinh)
        {
            
           
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("DangKyThongTin", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@HoTenNV", txtHoTen.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đăng kí thông tin thành công");
                Clear();
            }

            ////Không được bỏ trống:
            //if (txtHoTen.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập vào họ tên");
            //    txtHoTen.Focus();
            //}
            //else if (txtSDT.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập vào số điện thoại");
            //    txtSDT.Focus();
            //}
            //else if (txtGioiTinh.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập vào giới tính");
            //    txtGioiTinh.Focus();
            //}
            //else if (txtEmail.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập vào Email");
            //    txtEmail.Focus();
            //}
            //else if (txtDiaChi.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập vào địa chỉ");
            //    txtDiaChi.Focus();
            //}
            //else if (txtNgaySinh.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập vào ngày sinh");
            //    txtNgaySinh.Focus();
            //}

            DangKyTaiKhoan dk = new DangKyTaiKhoan();
            this.Hide();
            dk.ShowDialog();
            this.Show();
    
        }

        void Clear()
        {
            txtHoTen.Text = txtEmail.Text = txtSDT.Text = txtDiaChi.Text = txtNgaySinh.Text = txtGioiTinh.Text = "";
        }




        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "Họ và tên")
            {
                txtHoTen.Text = "";
                txtHoTen.ForeColor = Color.Teal;
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Text = "Họ và tên";
                txtHoTen.ForeColor = Color.DarkGray;
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Số điện thoại")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Teal;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = "Số điện thoại";
                txtSDT.ForeColor = Color.DarkGray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Teal;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.DarkGray;
            }

            //int vt = txtEmail.Text.IndexOf("@");

            //if (!txtEmail.Text.Contains("@") || vt == 0)
            //{
            //    MessageBox.Show("Sai cú pháp! Vui lòng nhập lại email!!");
            //    txtEmail.Text = "";
            //    txtEmail.Focus();
            //}
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Địa chỉ")
            {
                txtDiaChi.Text = "";
                txtDiaChi.ForeColor = Color.Teal;
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Text = "Địa chỉ";
                txtDiaChi.ForeColor = Color.DarkGray;
            }
        }

        //private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || txtSDT.Text.Length > 10)
        //        e.Handled = true;
        //}

        //private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
        //        e.Handled = true;
        //}

        private void lbLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtHoTen.Focus(); //Cho con trỏ chuột vào Họ tên để nhập liệu
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtNgaySinh.Text = "";
        }

        private void pBQuayLai_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
            this.Show();
        }


        private void DangKyThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo!",
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private void txtGioiTinh_Enter(object sender, EventArgs e)
        {
            if (txtGioiTinh.Text == "Giới tính")
            {
                txtGioiTinh.Text = "";
                txtGioiTinh.ForeColor = Color.Teal;
            }
        }

        private void txtGioiTinh_Leave(object sender, EventArgs e)
        {
            if (txtGioiTinh.Text == "")
            {
                txtGioiTinh.Text = "Giới tính";
                txtGioiTinh.ForeColor = Color.DarkGray;
            }
        }
    }
}
