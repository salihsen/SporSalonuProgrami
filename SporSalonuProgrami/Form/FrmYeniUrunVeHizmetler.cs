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

namespace SporSalonuProgrami
{
    public partial class XtraFormYeniUrunVeHizmetler : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormYeniUrunVeHizmetler()
        {
            InitializeComponent();
        }
        public int KimGirisYapti;
        UyeProvider uyeProvider = new UyeProvider();
        UrunVeHizmetlerAdd urunVeHizmetlerAdd = new UrunVeHizmetlerAdd();
        SporSalonuEntities DbSpr;
        void cmbBoxEkle()
        {
            int secilenDeger = Convert.ToInt32(cmbxUrunAdi.SelectedIndex.ToString());
            if (secilenDeger == 0)
            {
                txtMiktari.Text = cmbxUrunAdi.SelectedItem.ToString() + "1 Adet ";//SU
            }
            if (secilenDeger == 1)
            {
                txtMiktari.Text = cmbxUrunAdi.SelectedItem.ToString() + "1 Bardak ";//Kahve
            }
            if (secilenDeger == 2)
            {
                txtMiktari.Text = cmbxUrunAdi.SelectedItem.ToString() + "1 Adet ";//Soda
            }
            if (secilenDeger == 3)
            {
                txtMiktari.Text = cmbxUrunAdi.SelectedItem.ToString() + "1 Ölçek ";//Protein Tozu
            }
            if (secilenDeger == 4)
            {
                txtMiktari.Text = cmbxUrunAdi.SelectedItem.ToString() + "BCA ";//BCA
            }
            if (secilenDeger == 5)
            {
                txtMiktari.Text = cmbxUrunAdi.SelectedItem.ToString() + "Pre Workout ";//PRE Workout
            }
            if (secilenDeger == 6)
            {
                txtMiktari.Text = cmbxUrunAdi.SelectedItem.ToString() + "Vitamin Mineral  ";//Vitamin Mineral
            }
            if (secilenDeger == 7)
            {
                txtMiktari.Text = cmbxUrunAdi.SelectedItem.ToString() + "1. AY + 3.AY + 6.AY + 12.AY  ";//P.Coaching
                MessageBox.Show("1.Aylık = 350 TL " + "\n" + "3.Aylık = 900 TL" + "\n" + "6.Aylık = 1600TL" + "\n" + "1.Yıllık = 2200TL");
            }
        }
        void Ekle()
        {
            UrunVeHizmetler urunVeHizmetler = new UrunVeHizmetler();
            urunVeHizmetler.UyeID = Convert.ToInt32(lookUpEdit1.EditValue);
            urunVeHizmetler.Fiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            urunVeHizmetler.UrunlerID = Convert.ToInt32(lookUpEdit2.EditValue);
            urunVeHizmetler.Miktari = txtMiktari.Text;
            urunVeHizmetler.Tarih = dtmpckrTarih.Value;
            urunVeHizmetler.SilindiMi = false;
            urunVeHizmetler.Tip = txtTip.Text;
            urunVeHizmetler.Aciklama = txtAciklama.Text;
            urunVeHizmetler.KimGirisYapti = KimGirisYapti;
            DbSpr.UrunVeHizmetler.Add(urunVeHizmetler);
            DbSpr.SaveChanges();
        }
        void LookUpEditUyeListeleme()
        {
            DbSpr = new SporSalonuEntities();

            var uyeler = (from u in DbSpr.Uyeler
                          where u.AktifMi == true
                          where u.BitisTarihi >= DateTime.Today
                          select new
                          {
                              u.ID,
                              u.AdSoyad
                          }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = uyeler;

            lookUpEdit1.Properties.PopulateColumns();
            lookUpEdit1.Properties.Columns[lookUpEdit1.Properties.ValueMember].Visible = false;//ValueMember yani bizim ID mizi gizlemek için 
        }
        void LookUpEditUrunlerListeleme()
        {
            DbSpr = new SporSalonuEntities();

            var urunler = (from u in DbSpr.Urunler
                           select new
                           {
                               u.ID,
                               u.UrunAdi
                           }).ToList();
            lookUpEdit2.Properties.ValueMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "UrunAdi";
            lookUpEdit2.Properties.DataSource = urunler;


            lookUpEdit2.Properties.PopulateColumns();
            lookUpEdit2.Properties.Columns[lookUpEdit2.Properties.ValueMember].Visible = false;//ValueMember yani bizim ID mizi gizlemek için 
            //lookUpEdit1.Properties.ShowHeader = false;//Tablo başlığını gizmelemek için 
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ekle();
        }
        private void XtraFormYeniUrunVeHizmetler_Load(object sender, EventArgs e)
        {
            LookUpEditUyeListeleme();
            LookUpEditUrunlerListeleme();
        }
        private void cmbxUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxEkle();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            UrunDetayDTO SecilenKisi = uyeProvider.StokBilgileri(Convert.ToInt32(lookUpEdit2.EditValue));
            txtSatisFiyati.Text = Convert.ToString(SecilenKisi.SatisFiyati);
        }
    }
}