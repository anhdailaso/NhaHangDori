//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAODLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhomNguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomNguoiDung()
        {
            this.NguoiDungNhomNguoiDungs = new HashSet<NguoiDungNhomNguoiDung>();
            this.PhanQuyens = new HashSet<PhanQuyen>();
        }
    
        public string MaNhomNguoiDung { get; set; }
        public string TenNhom { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDungNhomNguoiDung> NguoiDungNhomNguoiDungs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanQuyen> PhanQuyens { get; set; }
    }
}
