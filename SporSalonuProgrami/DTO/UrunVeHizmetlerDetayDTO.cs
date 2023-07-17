using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuProgrami.DTO
{
    public class UrunVeHizmetlerDetayDTO
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public int? UrunlerID { get; set; }
        public string Miktari { get; set; }
        public decimal? Fiyati { get; set; }
        public int UyeID { get; set; }
        public string Tip { get; set; }
        public string Aciklama { get; set; }
        public string KimGirisYapti { get; set; }
        public bool? SilindiMi { get; set; }
    }
}
