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
    
    public partial class TK
    {
        public string TenTK { get; set; }
        public Nullable<int> IDUser { get; set; }
        public string MatkhauTK { get; set; }
        public int IDQuyen { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual PhanQuyen PhanQuyen { get; set; }
        public virtual User User { get; set; }
    }
}
