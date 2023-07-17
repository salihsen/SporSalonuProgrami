using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuProgrami
{
    public class UrunVeHizmetlerDTO
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public string UrunAdi { get; set; }
        public string Miktari { get; set; }
        public decimal SatisFiyat { get; set; }
        public string UyeID { get; set; }
        public string Kategori { get; set; }
        public bool PCoaching { get; set; }
        public decimal SalonUcreti { get; set; }
        public string KimGirisYapti { get; set; }
        public bool SilindiMi { get; set; }
    }
}
