﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kodusorServis.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kodusorDBEntities : DbContext
    {
        public kodusorDBEntities()
            : base("name=kodusorDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cevaplar> Cevaplar { get; set; }
        public virtual DbSet<Etiketler> Etiketler { get; set; }
        public virtual DbSet<FavoriCevaplar> FavoriCevaplar { get; set; }
        public virtual DbSet<FavoriSorular> FavoriSorular { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<SoruEtiket> SoruEtiket { get; set; }
        public virtual DbSet<Sorular> Sorular { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }
    }
}
