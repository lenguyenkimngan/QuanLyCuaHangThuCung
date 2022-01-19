using QuanLyCuaHangThuCung.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung
{
    public partial class QuanLyNhanVien : Form
    {
        BUS_NhanVien busNV;

        public QuanLyNhanVien()
        {
            InitializeComponent();
            busNV = new BUS_NhanVien();
        }

        private void HienThiDSNhanVien()
        {
            dGNhanVien.DataSource = null;
            busNV.LayDSNhanVien(dGNhanVien);
            //Định dạng datagridview:
            dGNhanVien.Columns[0].Width = (int)(dGNhanVien.Width * 0.1);
            dGNhanVien.Columns[1].Width = (int)(dGNhanVien.Width * 0.2);
            dGNhanVien.Columns[2].Width = (int)(dGNhanVien.Width * 0.1);
            dGNhanVien.Columns[3].Width = (int)(dGNhanVien.Width * 0.15);
            dGNhanVien.Columns[4].Width = (int)(dGNhanVien.Width * 0.15);
            dGNhanVien.Columns[5].Width = (int)(dGNhanVien.Width * 0.3);
            dGNhanVien.Columns[6].Width = (int)(dGNhanVien.Width * 0.3);
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
        }

        //Xử lý nhấn vào 1 cột dưới datagridview hiển thị lên trên:
        private void dDNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTen.Text = dGNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dGNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGioiTinh.Text = dGNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDT.Text = dGNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDC.Text = dGNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dGNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtMaNV.Text = dGNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //Thêm NV:
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.NgaySinh = dtpNgaySinh.Value;
            nhanVien.HoTenNV = txtHoTen.Text;
            nhanVien.GioiTinh = txtGioiTinh.Text;
            nhanVien.SDT = txtDT.Text;
            nhanVien.DiaChi = txtDC.Text;
            nhanVien.EMAIL = txtEmail.Text;

            //Gọi sự kiện thêm của BUS:
            if(busNV.ThemNV(nhanVien))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                busNV.LayDSNhanVien(dGNhanVien);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }

        //Sửa NV:
        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = int.Parse(txtMaNV.Text); //kiểm tra mã NV có tồn tại hay ko?
            nv.HoTenNV = txtHoTen.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.SDT = txtDT.Text;
            nv.DiaChi = txtDC.Text;
            nv.EMAIL = txtEmail.Text;

            //Gọi sự kiện sửa của BUS:
            if (busNV.SuaNV(nv))
            {
                MessageBox.Show("Sửa nhân viên thành công");
                busNV.LayDSNhanVien(dGNhanVien);
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }

        //Xóa NV:
        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = int.Parse(txtMaNV.Text);

            //Gọi sự kiện xóa của BUS:
            if (busNV.XoaNV(nv))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                busNV.LayDSNhanVien(dGNhanVien);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        //Thoát:
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Tìm:
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                HienThiDSNhanVien();
            }else
            {
                busNV.TimNhanVien(dGNhanVien, txtTimKiem.Text);
            }
        }

        private void pBQuayLai_Click(object sender, EventArgs e)
        {
            Hide();
            TChinh f = new TChinh();
            f.ShowDialog();
        }
    }
}
