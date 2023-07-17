using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuProgrami
{
    public class KullaniciAntremanDetayDTO
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public int UyelerID { get; set; }
        public int AntremanID { get; set; }
        public string Set { get; set; }
        public string Tekrar { get; set; }
    }
}
