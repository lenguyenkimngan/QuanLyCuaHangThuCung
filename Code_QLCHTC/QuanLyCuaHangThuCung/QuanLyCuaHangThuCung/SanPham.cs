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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietHDBans = new HashSet<ChiTietHDBan>();
            this.HinhSanPhams = new HashSet<HinhSanPham>();
        }
    
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public double GiaSP { get; set; }
        public string KichThuocSP { get; set; }
        public string MoTaSP { get; set; }
        public int MaLoaiSP { get; set; }
        public string TrongLuongSP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDBan> ChiTietHDBans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HinhSanPham> HinhSanPhams { get; set; }
        public virtual LoaiSP LoaiSP { get; set; }
    }
}
