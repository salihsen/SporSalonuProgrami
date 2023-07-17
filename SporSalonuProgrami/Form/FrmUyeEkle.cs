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
    public partial class XtraFormUyeEkle : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormUyeEkle()
        {
            InitializeComponent();
        }
        public int KimGirisYapti;
        UyeProvider uyeProvider = new UyeProvider();
        UyeAdd uye = new UyeAdd();
        SporSalonuEntities DbSpr;
        bool Aktifmi = true;
        void Ekleme()
        {
            try
            {
                DbSpr = new SporSalonuEntities();
                Uyeler uyeler = new Uyeler();
                uyeler.AdSoyad = txtAdSoyad.Text;
                uyeler.Telefon = txtTellNo.Text;
                uyeler.DogumTarihi = dtmpkrDogumTarihi.Value;
                uyeler.Cinsiyet = cmbxCinsiyet.Text;
                uyeler.KanGrubu = cmbxKanGrubu.Text;
                uyeler.BaslangicTarihi = dtmpkrBaslangicTarihi.Value;
                uyeler.BitisTarihi = dtmpkrBitisTarihi.Value;
                uyeler.P_Coaching = cmbxOzelDersAliyorMu.Text;
                uyeler.Mail = txtMail.Text;
                uyeler.NOT = txtNot.Text;
                uyeler.AktifMi = Aktifmi;
                uyeler.KimGirisYapti = KimGirisYapti;
                DbSpr.Uyeler.Add(uyeler);
                DbSpr.SaveChanges();
                MessageBox.Show("Bir Kayıt Gerçekleşti");
            }
            catch (Exception)
            {
                throw;
            }

            //uye.AdSoyad = txtAdSoyad.Text;
            //uye.Telefonu = txtTellNo.Text;
            //uye.DogumTarihi = dtmpkrDogumTarihi.Value;
            //uye.Cinsiyet = cmbxCinsiyet.Text;
            //uye.KanGrubu = cmbxKanGrubu.Text;
            //uye.BaslangicTarihi = dtmpkrBaslangicTarihi.Value;
            //uye.BitisTarihi = dtmpkrBitisTarihi.Value;
            //uye.OzelDersAliyorMu = cmbxOzelDersAliyorMu.Text;
            //uye.Mail = txtMail.Text;
            //uye.Not = txtNot.Text;
            //uye.AktifMi = false;
            //uye.KimGirisYapti = KimGirisYapti;
            //uyeProvider.Ekle(uye);
        }
        void CmbBoxEkleme()
        {
            cmbxUyelikTipi.SelectedItem.ToString();
            int a = Convert.ToInt32(cmbxUyelikTipi.SelectedIndex.ToString());
            if (a == 0)
            {
                dtmpkrBitisTarihi.Value = Convert.ToDateTime(DateTime.Today);
                dtmpkrBitisTarihi.Value = dtmpkrBitisTarihi.Value.AddMonths(1);
            }
            if (a == 1)
            {
                dtmpkrBitisTarihi.Value = Convert.ToDateTime(DateTime.Today);
                dtmpkrBitisTarihi.Value = dtmpkrBitisTarihi.Value.AddMonths(3);
            }
            if (a == 2)
            {
                dtmpkrBitisTarihi.Value = Convert.ToDateTime(DateTime.Today);
                dtmpkrBitisTarihi.Value = dtmpkrBitisTarihi.Value.AddMonths(6);
            }
            if (a == 3)
            {
                dtmpkrBitisTarihi.Value = Convert.ToDateTime(DateTime.Today);
                dtmpkrBitisTarihi.Value = dtmpkrBitisTarihi.Value.AddYears(1);
            }
        }
        private void cmbxUyelikTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbBoxEkleme();
        }
        private void XtraFormUyeEkle_Load(object sender, EventArgs e)
        {

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ekleme();
        }
    }
}