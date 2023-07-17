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

namespace SporSalonuProgrami
{
    public partial class XtraFormAyarlar : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormAyarlar()
        {
            InitializeComponent();
        }
        UyeProvider uyeProvider = new UyeProvider();
        FirmaBilgileriDTO fb = new FirmaBilgileriDTO();
        OpenFileDialog file = new OpenFileDialog();
        XtraFormKullaniciEkleme frmKullaniciEkleme;
        XtraFormGirisSifresi frmGirisSifresi;
        FrmUyelikSozlesmesi frmUyelikSozlesmesi;
        FrmUrunler urunler;
        FrmUyeligiBitenler frmUyeligiBitenler;
        void FirmaBilgileriniListele()
        {
            uyeProvider.FrmListele(fb);
            txtFirmaAdi.Text = fb.FirmaAdi;
            txtAdres.Text = fb.Adres;
            txtSehir.Text = fb.Sehir;
            txtTellNo.Text = fb.SirketNo;
            txtFaxNo.Text = fb.Fax;
            txtEmail.Text = fb.Email;
            txtWebSitesi.Text = fb.WebSitesi;
        }
        private void XtraFormAyarlar_Load(object sender, EventArgs e)
        {
            FirmaBilgileriniListele();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            fb.FirmaAdi = txtFirmaAdi.Text;
            fb.Adres = txtAdres.Text;
            fb.Sehir = txtSehir.Text;
            fb.SirketNo = txtTellNo.Text;
            fb.Fax = txtFaxNo.Text;
            fb.Email = txtEmail.Text;
            fb.WebSitesi = txtWebSitesi.Text;
            uyeProvider.FirmaBilgileriEkle(fb);
        }
        private void btnStokEkleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunler == null || urunler.IsDisposed)
            {
                urunler = new FrmUrunler();
                urunler.Show();
            }
        }
        private void btnFirmaBilgileri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grpbxFirmaBilgileri.Show();
        }
        private void btnKullaniciEkleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKullaniciEkleme == null || frmKullaniciEkleme.IsDisposed)
            {
                frmKullaniciEkleme = new XtraFormKullaniciEkleme();
                frmKullaniciEkleme.Show();
                frmGirisSifresi = null;
                frmUyelikSozlesmesi = null;
            }
        }
        private void btnGirisSifresi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGirisSifresi == null || frmGirisSifresi.IsDisposed)
            {
                frmGirisSifresi = new XtraFormGirisSifresi();
                frmGirisSifresi.Show();
                frmKullaniciEkleme = null;
                frmUyelikSozlesmesi = null;
            }
        }
        private void btnUyelikSozlesmesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUyelikSozlesmesi == null || frmUyelikSozlesmesi.IsDisposed)
            {
                frmUyelikSozlesmesi = new FrmUyelikSozlesmesi();
                frmUyelikSozlesmesi.Show();
                frmKullaniciEkleme = null;
                frmGirisSifresi = null;
            }
        }
        private void btnUyeligiBitenler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUyeligiBitenler == null || frmUyeligiBitenler.IsDisposed)
            {
                frmUyeligiBitenler = new FrmUyeligiBitenler();
                frmUyeligiBitenler.Show();
            }
        }
    }
}