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
    
    public partial class Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler()
        {
            this.UrunVeHizmetler = new HashSet<UrunVeHizmetler>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<decimal> SatisFiyati { get; set; }
        public Nullable<int> StokAdeti { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunVeHizmetler> UrunVeHizmetler { get; set; }
    }
}