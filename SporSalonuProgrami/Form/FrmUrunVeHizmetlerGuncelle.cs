using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SporSalonuProgrami.Entity;
using SporSalonuProgrami.DTO;

namespace SporSalonuProgrami
{
    public partial class XtraFormUrunVeHizmetlerGuncelle : DevExpress.XtraEditors.XtraForm
    {
        UrunVeHizmetlerDetayDTO _urun;
        UyeProvider uyeProvider = new UyeProvider();
        public XtraFormUrunVeHizmetlerGuncelle(UrunVeHizmetlerDetayDTO urun)
        {
            InitializeComponent();
            _urun = urun;
        }
        void Listele()
        {
            uyeProvider.UrunVeHizmetlerListele(_urun.ID);
            dtmpckrTarih.Value = _urun.Tarih;
            txtUrunAdi.Text = Convert.ToString(_urun.UrunlerID);
            txtMiktari.Text = _urun.Miktari;
            txtSatisFiyati.Text = Convert.ToString(_urun.Fiyati);
            txtAlici.Text = Convert.ToString(_urun.UyeID);
        }
        void Ekle()
        {
            UrunVeHizmetlerUpdate update = new UrunVeHizmetlerUpdate();
            update.ID = _urun.ID;
            update.Tarih = dtmpckrTarih.Value;
            update.UrunAdi = txtUrunAdi.Text;
            update.Miktari = txtMiktari.Text;
            update.SatisFiyat = txtSatisFiyati.Text;
            update.Alici = txtAlici.Text;
            uyeProvider.UrunVeHizmetlerGuncelle(update);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ekle();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void XtraFormUrunVeHizmetlerGuncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}