//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoiTap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoiTap()
        {
            this.LichTrinhTaps = new HashSet<LichTrinhTap>();
        }
    
        public Nullable<int> IDKH { get; set; }
        public Nullable<int> IDHD { get; set; }
        public int IDGT { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> HanSuDung { get; set; }
        public string Name { get; set; }
        public Nullable<double> Price { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichTrinhTap> LichTrinhTaps { get; set; }
    }
}