//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPhongGym.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinhTrangLamViecHLV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinhTrangLamViecHLV()
        {
            this.DanhGiaHLVs = new HashSet<DanhGiaHLV>();
        }
    
        public int IDTTLVHLV { get; set; }
        public int IDLLV { get; set; }
        public Nullable<bool> VangKhongPhep { get; set; }
        public Nullable<bool> VangCoPhep { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGiaHLV> DanhGiaHLVs { get; set; }
        public virtual LichLamViecTrongTuan LichLamViecTrongTuan { get; set; }
    }
}