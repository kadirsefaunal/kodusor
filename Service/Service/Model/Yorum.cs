//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yorum
    {
        public int YorumID { get; set; }
        public int CevapID { get; set; }
        public int KullaniciID { get; set; }
        public string Yorum1 { get; set; }
        public System.DateTime Tarih { get; set; }
    
        public virtual Cevaplar Cevaplar { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}