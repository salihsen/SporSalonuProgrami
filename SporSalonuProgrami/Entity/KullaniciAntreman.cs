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
    
    public partial class KullaniciAntreman
    {
        public int ID { get; set; }
        public Nullable<int> UyelerID { get; set; }
        public Nullable<int> AntremanID { get; set; }
        public string Set { get; set; }
        public string Tekrar { get; set; }
        public Nullable<bool> SilindiMi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Aciklama { get; set; }
    
        public virtual Antreman Antreman { get; set; }
        public virtual Uyeler Uyeler { get; set; }
    }
}
