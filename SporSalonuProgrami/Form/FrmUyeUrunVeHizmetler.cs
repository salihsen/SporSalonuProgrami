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
    public partial class XtraFormUyeUrunVeHizmetler : DevExpress.XtraEditors.XtraForm
    {
        UyelerDTO _uye;
        public int KimGirisYapti;
        public XtraFormUyeUrunVeHizmetler(UyelerDTO uye)
        {
            InitializeComponent();
            _uye = uye;
        }
        SporSalonuEntities DbSpr;
        XtraFormYeniUyeUrunVeHizmetler frmYeniUrunVeHizmetler;
        UyeProvider uyeProvider = new UyeProvider();
        bool AktifMi = true;
        void Listeleme()
        {
            DbSpr = new SporSalonuEntities();
            var degerler = (from u in DbSpr.UrunVeHizmetler
                            join y in DbSpr.Yonetici on u.KimGirisYapti equals y.ID
                            join uy in DbSpr.Uyeler on u.UyeID equals uy.ID
                            join ur in DbSpr.Urunler on u.UrunlerID equals ur.ID
                            where u.UyeID == _uye.ID
                            where uy.AktifMi == true
                            where u.SilindiMi == false
                            select new UrunVeHizmetlerDetayDTO
                            {
                                ID = u.ID,
                                Tarih = (DateTime)u.Tarih,
                                UrunlerID = u.UrunlerID,
                                Miktari = u.Miktari,
                                Fiyati = (decimal)u.Fiyati,
                                UyeID = uy.ID,
                                Tip = u.Tip,
                                Aciklama = u.Aciklama,
                                SilindiMi = u.SilindiMi,
                                KimGirisYapti = y.AdSoyad
                            }).ToList();
            gridControl1.DataSource = degerler;
        }
        void Sil()
        {
            OlculerDTO olculerDTO = new OlculerDTO();
            UrunVeHizmetlerDetayDTO urunVeHizmetler = new UrunVeHizmetlerDetayDTO();
            UrunVeHizmetlerDetayDTO SecilenKisi = uyeProvider.UrunVeHizmetlerListele(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")));
            urunVeHizmetler.ID = SecilenKisi.ID;
            urunVeHizmetler.SilindiMi = AktifMi;
            uyeProvider.UrunveHizmetlerSil(urunVeHizmetler);
        }
        void Guncelleme()
        {
            UrunVeHizmetlerDetayDTO SecilenKisi = uyeProvider.UrunVeHizmetlerListele(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")));
            XtraFormUrunVeHizmetlerGuncelle frmUrunVeHizmetlerGuncelle = new XtraFormUrunVeHizmetlerGuncelle(SecilenKisi);
            frmUrunVeHizmetlerGuncelle.Show();
        }
        private void XtraFormUyeUrunVeHizmetler_Load(object sender, EventArgs e)
        {
            Listeleme();
            gridView1.Columns["ID"].Visible = false;
            //gridView1.Columns["Kategori"].Visible = false;
            gridView1.Columns["SilindiMi"].Visible = false;
            gridView1.Columns["UyeID"].Visible = false;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniUrunVeHizmetler == null || frmYeniUrunVeHizmetler.IsDisposed)
            {
                frmYeniUrunVeHizmetler = new XtraFormYeniUyeUrunVeHizmetler(_uye);
                frmYeniUrunVeHizmetler.KimGirisYapti = KimGirisYapti;
                frmYeniUrunVeHizmetler.Show();
            }
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sil();
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guncelleme();
        }
    }
}