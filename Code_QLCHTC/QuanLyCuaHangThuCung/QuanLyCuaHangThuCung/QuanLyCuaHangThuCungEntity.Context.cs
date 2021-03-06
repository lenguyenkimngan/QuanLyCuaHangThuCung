//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCuaHangThuCung
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyCuaHangThuCungEntities : DbContext
    {
        public QuanLyCuaHangThuCungEntities()
            : base("name=QuanLyCuaHangThuCungEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietHDBan> ChiTietHDBans { get; set; }
        public virtual DbSet<HinhSanPham> HinhSanPhams { get; set; }
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSP> LoaiSPs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
    
        public virtual int DangKyTaiKhoan(string tenDangNhap, string matKhau)
        {
            var tenDangNhapParameter = tenDangNhap != null ?
                new ObjectParameter("TenDangNhap", tenDangNhap) :
                new ObjectParameter("TenDangNhap", typeof(string));
    
            var matKhauParameter = matKhau != null ?
                new ObjectParameter("MatKhau", matKhau) :
                new ObjectParameter("MatKhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DangKyTaiKhoan", tenDangNhapParameter, matKhauParameter);
        }
    
        public virtual int DangKyThongTin(string hoTenNV, Nullable<System.DateTime> ngaySinh, string gioiTinh, string sDT, string eMAIL, string diaChi)
        {
            var hoTenNVParameter = hoTenNV != null ?
                new ObjectParameter("HoTenNV", hoTenNV) :
                new ObjectParameter("HoTenNV", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            var gioiTinhParameter = gioiTinh != null ?
                new ObjectParameter("GioiTinh", gioiTinh) :
                new ObjectParameter("GioiTinh", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DangKyThongTin", hoTenNVParameter, ngaySinhParameter, gioiTinhParameter, sDTParameter, eMAILParameter, diaChiParameter);
        }
    }
}
