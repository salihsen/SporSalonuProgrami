using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuProgrami
{
    public class UyeOlculeriGuncelle
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public String UyeAdSoyad { get; set; }
        public int Kilo { get; set; }
        public int Boy { get; set; }
        public int Omuz { get; set; }
        public int Gogus { get; set; }
        public int Bel { get; set; }
        public int Kalca { get; set; }
        public int Bacak { get; set; }
        public int Kol { get; set; }
        public bool SilindiMi { get; set; }
    }
}
