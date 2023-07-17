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
    public partial class XtraFormYeniKullaniciEkleme : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormYeniKullaniciEkleme()
        {
            InitializeComponent();
        }
        SporSalonuEntities DbSpr = new SporSalonuEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.AdSoyad = txtAdSoyad.Text;
            yonetici.KullaniciAdi = txtKullaniciAdi.Text;
            yonetici.Sifre = txtSifre.Text;
            DbSpr.Yonetici.Add(yonetici);
            DbSpr.SaveChanges();
            txtKayitNo.Clear();
            txtAdSoyad.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
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
    }
}