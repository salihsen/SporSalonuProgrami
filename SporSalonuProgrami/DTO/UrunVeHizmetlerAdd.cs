using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuProgrami
{
    public class UrunVeHizmetlerAdd
    {
        public DateTime Tarih { get; set; }
        public String UrunAdi { get; set; }
        public string Miktari { get; set; }
        public int SatisFiyat { get; set; }
        public int UyeID { get; set; }
        public string Kategori { get; set; }
        public string PCoaching { get; set; }
        public string SalonUcreti { get; set; }
        public int KimGirisYapti { get; set; }
    }
}
