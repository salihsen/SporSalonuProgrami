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
    public partial class FrmUrunVeHizmetler : Form
    {
        public FrmUrunVeHizmetler()
        {
            InitializeComponent();
        }
        public int KimGirisYapti;
        UyeProvider uyeProvider = new UyeProvider();
        SporSalonuEntities DbSpr;
        XtraFormYeniUrunVeHizmetler XtraFormYeniUrunVeHizmetler;
        bool AktifMi = true;
        void Listele()
        {
            UrunVeHizmetlerDetayDTO SecilenKisi = uyeProvider.UrunVeHizmetlerListele(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")));
            XtraFormUrunVeHizmetlerGuncelle frmUrunVeHizmetlerGuncelle = new XtraFormUrunVeHizmetlerGuncelle(SecilenKisi);
            frmUrunVeHizmetlerGuncelle.Show();
        }
        void Listeleme()
        {
            DbSpr = new SporSalonuEntities();
            var degerler = (from u in DbSpr.UrunVeHizmetler
                            join y in DbSpr.Yonetici on u.KimGirisYapti equals y.ID
                            join uy in DbSpr.Uyeler on u.UyeID equals uy.ID
                            where u.SilindiMi == false
                            where uy.AktifMi == true
                            select new UrunVeHizmetlerDetayDTO
                            {
                                ID = u.ID,
                                Tarih = (DateTime)u.Tarih,
                                UrunlerID = u.UrunlerID,
                                Miktari = u.Miktari,
                                Fiyati = u.Fiyati,
                                UyeID = uy.ID,
                                Tip = u.Tip,
                                Aciklama = u.Aciklama,
                                SilindiMi = u.SilindiMi,
                                KimGirisYapti = y.ID.ToString()
                            }).ToList();
            ////gridControl1.DataSource = degerler;
            urunVeHizmetlerBindingSource.DataSource = degerler;
        }
        private void FrmUrunVeHizmetler_Load(object sender, EventArgs e)
        {
            Listeleme();
            yoneticiBindingSource.DataSource = DbSpr.Yonetici.ToList();
            uyelerBindingSource.DataSource = DbSpr.Uyeler.ToList();
            urunlerBindingSource.DataSource = DbSpr.Urunler.ToList();
            gridView1.Columns["ID"].Visible = false;
        }
        private void btnYeniKayitOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraFormYeniUrunVeHizmetler == null || XtraFormYeniUrunVeHizmetler.IsDisposed)
            {
                XtraFormYeniUrunVeHizmetler = new XtraFormYeniUrunVeHizmetler();
                XtraFormYeniUrunVeHizmetler.KimGirisYapti = KimGirisYapti;
                XtraFormYeniUrunVeHizmetler.Show();
            }
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunVeHizmetlerDetayDTO urunVeHizmetlerDTO = new UrunVeHizmetlerDetayDTO();
            UrunVeHizmetlerDetayDTO SecilenKisi = uyeProvider.UrunVeHizmetlerListele(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")));
            urunVeHizmetlerDTO.ID = SecilenKisi.ID;
            urunVeHizmetlerDTO.SilindiMi = AktifMi;
            uyeProvider.UrunveHizmetlerSil(urunVeHizmetlerDTO);
            Listeleme();
        }
    }
}
