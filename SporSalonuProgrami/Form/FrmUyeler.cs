using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SporSalonuProgrami.DTO;
using SporSalonuProgrami.Entity;

namespace SporSalonuProgrami
{
    public partial class FrmUyeler : Form
    {
        public FrmUyeler()
        {
            InitializeComponent();
        }
        public int KimGirisYapti;
        UyeProvider uyeProvider = new UyeProvider();
        Button buttons = new Button();
        SporSalonuEntities DbSpr;
        bool AktifMi = false;
        void Listeleme()
        {
            DbSpr = new SporSalonuEntities();
            var degerler = (from u in DbSpr.Uyeler
                            join y in DbSpr.Yonetici on u.KimGirisYapti equals y.ID
                            where u.AktifMi == true
                            where u.BitisTarihi >= DateTime.Today
                            select new UyeDetayDTO
                            {
                                ID = u.ID,
                                AdSoyad = u.AdSoyad,
                                Telefon = u.Telefon,
                                BaslangicTarihi = (DateTime)u.BaslangicTarihi,
                                BitisTarihi = (DateTime)u.BitisTarihi,
                                KimGirisYapti = y.AdSoyad
                            }).ToList();
            gridControl1.DataSource = degerler;
        }
        void SecileKisi()
        {
            UyelerDTO SecilenKisi = uyeProvider.UyeBilgileriniGor(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")));
            XtraFormProfiliAc profiliAc = new XtraFormProfiliAc(SecilenKisi);
            profiliAc.KimGirisYapti = KimGirisYapti;
            profiliAc.Show();
        }
        void Sil()
        {
            UyelerDTO uyelerDTO = new UyelerDTO();
            UyelerDTO SecilenKisi = uyeProvider.UyeBilgileriniGor(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")));
            uyelerDTO.ID = SecilenKisi.ID;
            uyelerDTO.AktifMi = AktifMi;
            uyeProvider.Sil(uyelerDTO);
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Listeleme();
        }
        private void profiliAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecileKisi();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                Sil();
                Listeleme();
            }
        }
        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "Sıra No")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }
    }
}
