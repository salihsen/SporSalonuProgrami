using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuProgrami
{
    class UrunDetayDTO
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public int StokAdeti { get; set; }  
    }
}
