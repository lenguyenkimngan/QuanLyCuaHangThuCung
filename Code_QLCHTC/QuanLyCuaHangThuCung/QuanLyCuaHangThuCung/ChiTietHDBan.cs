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
    using System.Collections.Generic;
    
    public partial class ChiTietHDBan
    {
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public Nullable<double> TyLeGiamGia { get; set; }
        public int MaHD { get; set; }
        public int MaSP { get; set; }
    
        public virtual HoaDonBan HoaDonBan { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
