using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuProgrami
{
    public class UyelerDTO
    {
        public int ID { get; set; }
        public int NO { get; set; }
        public string AdSoyad { get; set; }
        public string Telefonu { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string KanGrubu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string OzelDersAliyorMu { get; set; }
        public string Mail { get; set; }
        public string Not { get; set; }
        public bool AktifMi { get; set; }
        public int KimGirisYapti { get; set; }
    }
}
