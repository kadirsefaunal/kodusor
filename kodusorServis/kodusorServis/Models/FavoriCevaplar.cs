//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class FavoriCevaplar
    {
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public int CevapID { get; set; }
    
        public virtual Cevaplar Cevaplar { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
