using DevExpress.XtraBars.Helpers;
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
    public partial class XtraFormAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormAnaSayfa()
        {
            InitializeComponent();
        }
        UyeProvider uyeProvider = new UyeProvider();
        UyelerDTO u = new UyelerDTO();
        public int KimGirisYapti;
        FrmUyeler frmUyeler;
        XtraFormUyeEkle frmUyeEkle;
        XtraFormAntreman frmAntreman;
        FrmYoneticiGirisi frmyoneticiGirisi;
        FrmUrunVeHizmetler frmUrunVeHizmetler;
        public void UyelikSuresiDolanlar()
        {
            u.AdSoyad = "";
            uyeProvider.Listele(u);
            XtraMessageBox.Show("Üyeler: " + "\n" + u.AdSoyad + " ");
        }
        public void DogumGunuOlanUyeler()
        {
            u.AdSoyad = "";
            uyeProvider.DogumgunuOlanUyeler(u);
            XtraMessageBox.Show("Happy Birtday: " + "\n" + u.AdSoyad + " ");
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(barSubItem4);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;//Formun açılışta tam ekran yapıyor
            if (frmUyeler == null || frmUyeler.IsDisposed)
            {
                frmUyeler = new FrmUyeler();
                frmUyeler.KimGirisYapti = KimGirisYapti;
                frmUyeler.MdiParent = this;
                frmUyeler.Show();
            }
        }
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(barSubItem4);
            if (frmUyeler == null || frmUyeler.IsDisposed)
            {
                frmUyeler = new FrmUyeler();
                frmUyeler.MdiParent = this;
                frmUyeler.KimGirisYapti = KimGirisYapti;
                frmUyeler.Show();
            }
        }
        private void btnUyeEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUyeEkle == null || frmUyeEkle.IsDisposed)
            {
                frmUyeEkle = new XtraFormUyeEkle();
                frmUyeEkle.KimGirisYapti = KimGirisYapti;
                frmUyeEkle.Show();
            }
        }
        private void brBtnBaslangic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAntreman == null || frmAntreman.IsDisposed)
            {
                frmAntreman = new XtraFormAntreman();
                frmAntreman.MdiParent = this;
                frmAntreman.Show();
            }
        }
        private void btnUrunVeHizmetler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunVeHizmetler == null || frmUrunVeHizmetler.IsDisposed)
            {
                frmUrunVeHizmetler = new FrmUrunVeHizmetler();
                frmUrunVeHizmetler.KimGirisYapti = KimGirisYapti;
                frmUrunVeHizmetler.MdiParent = this;
                frmUrunVeHizmetler.Show();
            }
        }
        private void btnDogumGunu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DogumGunuOlanUyeler();
        }
        private void btnUyelikSuresi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UyelikSuresiDolanlar();
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmyoneticiGirisi == null || frmyoneticiGirisi.IsDisposed)
            {
                frmyoneticiGirisi = new FrmYoneticiGirisi();
                frmyoneticiGirisi.Show();
            }
        }
    }
}