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
    public partial class XtraFormKullaniciEkleme : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormKullaniciEkleme()
        {
            InitializeComponent();
        }
        UyeProvider uyeProvider = new UyeProvider();
        XtraFormYeniKullaniciEkleme frmYeniKullaniciEkleme;
        SporSalonuEntities DbSpr;
        public void Listele()
        {
            DbSpr = new SporSalonuEntities();
            var degerler = (from x in DbSpr.Yonetici
                                //where x.SeviyeID == id
                            select new YoneticiDTO
                            {
                                ID = x.ID,
                                AdSoyad = x.AdSoyad,
                                KullaniciAdi = x.KullaniciAdi,
                                Sifre = x.Sifre,
                                AdminMi = (bool)x.AdminMi
                            }).ToList();
            gridControl1.DataSource = degerler.ToList();
            //gridControl1.DataSource = uyeProvider.YoneticiListele();
        }
        void Güncelle() 
        {
            YoneticiDTO yonetici = new YoneticiDTO();
            YoneticiDTO SecilenKisi = uyeProvider.yoneticiBilgileriniGor(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")));
            //yonetici = (YoneticiDTO)gridView1.GetFocusedRowCellValue("ID");
            yonetici.ID = Convert.ToInt32(SecilenKisi.ID);
            yonetici.Sifre = txtSifre.Text;
            uyeProvider.YoneticiGuncelleme(yonetici);
        }
        public void UyeBilgileriniGor()
        {
            int focusedRow = gridView1.FocusedRowHandle;
            gridView1.FocusedRowHandle = focusedRow;
            gridView1.SelectRow(focusedRow);
            gridView1.Focus();
            txtAdSoyad.Text = gridView1.GetFocusedRowCellValue("AdSoyad").ToString();
            txtKullaniciAdi.Text = gridView1.GetFocusedRowCellValue("KullaniciAdi").ToString();
        }
        private void XtraFormKullaniciEkleme_Load(object sender, EventArgs e)
        {
            Listele();
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["Sifre"].Visible = false;
            gridView1.Columns["KullaniciAdi"].Visible = false;
            gridView1.Columns["AdminMi"].Visible = false;
            btnSifreDegistir.Enabled = false;
            btnKaydet.Enabled = false;
            btnKullaniciSil.Enabled = false;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                //Application.Exit();
            }
        }
        private void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (frmYeniKullaniciEkleme == null || frmYeniKullaniciEkleme.IsDisposed)
            {
                frmYeniKullaniciEkleme = new XtraFormYeniKullaniciEkleme();
                frmYeniKullaniciEkleme.Show();
                Listele();
            }
        }
        private void gridView1_Click(object sender, EventArgs e)
        {
            btnSifreDegistir.Enabled = true;
            btnKaydet.Enabled = true;
            btnKullaniciSil.Enabled = true;
            //txtKayitNo.Text = gridView1.GetFocusedRowCellValue("No").ToString();
            //txtAdSoyad.Text = gridView1.GetFocusedRowCellValue("AdSoyad").ToString();
            //txtKullaniciAdi.Text = gridView1.GetFocusedRowCellValue("KullaniciAdi").ToString();
            UyeBilgileriniGor();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string ID = gridView1.GetFocusedRowCellValue("AdSoyad").ToString();
            UyeBilgileriniGor();
        }
        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            YoneticiDTO yonetici = new YoneticiDTO();
            yonetici = (YoneticiDTO)gridView1.GetFocusedRowCellValue("ID");
            uyeProvider.YoneticiSil(yonetici);
            Listele();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Güncelle();
        }
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            Güncelle();
        }
    }
}