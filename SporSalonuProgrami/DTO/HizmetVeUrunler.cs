using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuProgrami
{
   public class HizmetVeUrunler
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public String UrunAdi { get; set; }
        public string Miktari { get; set; }
        public string SatisFiyat { get; set; }
        public string Alici { get; set; }
        public string Kategori { get; set; }
        public  string PCoaching { get; set; }
        public string SalonUcreti { get; set; }
        public int KimGirisYapti{ get; set; }
    }
}
