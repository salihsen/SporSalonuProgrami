//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SporSalonuProgrami.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class UrunVeHizmetler
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Miktari { get; set; }
        public Nullable<int> UyeID { get; set; }
        public Nullable<int> KimGirisYapti { get; set; }
        public Nullable<bool> SilindiMi { get; set; }
        public Nullable<decimal> Fiyati { get; set; }
        public string Tip { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> UrunlerID { get; set; }
    
        public virtual Uyeler Uyeler { get; set; }
        public virtual Yonetici Yonetici { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
