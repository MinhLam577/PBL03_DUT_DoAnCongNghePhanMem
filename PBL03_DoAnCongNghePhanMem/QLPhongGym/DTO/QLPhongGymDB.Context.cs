﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLPhongGymDB : DbContext
    {
        public QLPhongGymDB()
            : base("name=QLPhongGymDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CaLamViec> CaLamViecs { get; set; }
        public virtual DbSet<LichLamViecTrongTuan> LichLamViecTrongTuans { get; set; }
        public virtual DbSet<LichThueHLV> LichThueHLVs { get; set; }
        public virtual DbSet<ThietBi> ThietBis { get; set; }
        public virtual DbSet<TK> TKs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<DangKiGoiTap> DangKiGoiTaps { get; set; }
        public virtual DbSet<GoiTap> GoiTaps { get; set; }
    }
}
