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
    public partial class XtraFormUyeOlculeriGuncelle : DevExpress.XtraEditors.XtraForm
    {
        OlculerDTO _olculer;
        public XtraFormUyeOlculeriGuncelle(OlculerDTO olculer)
        {
            InitializeComponent();
            _olculer = olculer;
        }
        UyeProvider uyeProvider = new UyeProvider();
        void Listele()
        {
            OlculerDTO olculer = new OlculerDTO();
            olculer.ID = _olculer.ID;
            dtmpckrTarih.Value = _olculer.Tarih;
            txtBoy.Text = Convert.ToString(_olculer.Boy);
            txtKilo.Text = Convert.ToString(_olculer.Kilo);
            txtOmuz.Text = Convert.ToString(_olculer.Omuz);
            txtGogus.Text = Convert.ToString(_olculer.Gogus);
            txtKol.Text = Convert.ToString(_olculer.Kol);
            txtBel.Text = Convert.ToString(_olculer.Bel);
            txtKalca.Text = Convert.ToString(_olculer.Kalca);
            txtBacak.Text = Convert.ToString(_olculer.Bacak);
        }
        void Guncelle()
        {
            UyeOlculeriGuncelle uye = new UyeOlculeriGuncelle();
            uye.ID = _olculer.ID;
            uye.Tarih = _olculer.Tarih;
            uye.UyeAdSoyad = _olculer.UyeAdSoyad;
            uye.Boy = Convert.ToInt32(txtBoy.Text);
            uye.Kilo = Convert.ToInt32(txtKilo.Text);
            uye.Omuz = Convert.ToInt32(txtOmuz.Text);
            uye.Gogus = Convert.ToInt32(txtGogus.Text);
            uye.Bel = Convert.ToInt32(txtBel.Text);
            uye.Kalca = Convert.ToInt32(txtKalca.Text);
            uye.Bacak = Convert.ToInt32(txtBacak.Text);
            uye.Kol = Convert.ToInt32(txtKol.Text);
            uye.SilindiMi = true;
            uyeProvider.UyeOlculerGuncelle(uye);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void XtraFormUyeOlculeriGuncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}