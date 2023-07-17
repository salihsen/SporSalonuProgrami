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
    public partial class XtraFormStokEkleme : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormStokEkleme()
        {
            InitializeComponent();
        }
        SporSalonuEntities DbSpr;
        UyeProvider uyeProvider = new UyeProvider();
        void Ekleme()
        {
            try
            {
                DbSpr = new SporSalonuEntities();
                Urunler urunler = new Urunler();
                urunler.Tarih = dtmpckrTarih.Value;
                urunler.UrunAdi = txtUrunAdi.Text;
                urunler.BirimFiyati = Convert.ToInt32(txtBirimFiyati.Text);
                urunler.SatisFiyati = Convert.ToInt32(txtSatisFiyati.Text);
                urunler.StokAdeti = Convert.ToInt32(txtStokAdeti.Text);
                DbSpr.Urunler.Add(urunler);
                DbSpr.SaveChanges();
                MessageBox.Show("Bir Kayıt Gerçekleşti");
            }
            catch (Exception)
            {
                throw;
            }
        }
        void Temizleme()
        {
            txtUrunAdi.Clear();
            txtBirimFiyati.Clear();
            txtSatisFiyati.Clear();
            txtStokAdeti.Clear();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ekleme();
            Temizleme();
        }
    }
}