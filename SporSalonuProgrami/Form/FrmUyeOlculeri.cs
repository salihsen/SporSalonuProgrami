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
    public partial class XtraFormUyeOlculeri : DevExpress.XtraEditors.XtraForm
    {
        UyelerDTO _uye;
        public XtraFormUyeOlculeri(UyelerDTO uye)
        {
            InitializeComponent();
            _uye = uye;
        }
        SporSalonuEntities DbSpr;
        XtraFormYeniUyeOlculeri xtraFormYeniUyeOlculeri;
        UyeProvider uyeProvider = new UyeProvider();
        bool AktifMi = false;
        void Listele()  
        {
            DbSpr = new SporSalonuEntities();
            var degerler = (from o in DbSpr.Olculer
                            join u in DbSpr.Uyeler on o.UyelerID equals u.ID
                            where o.UyelerID == _uye.ID where o.SilindiMi==true
                            select new OlculerDTO
                            {
                                ID = o.ID,
                                Tarih = (DateTime)o.Tarih,
                                UyeAdSoyad = u.AdSoyad,
                                Boy = (int)o.Boy,
                                Kilo = (int)o.Kilo,
                                Omuz = (int)o.Omuz,
                                Gogus = (int)o.Gogus,
                                Kol = (int)o.Kol,
                                Bel = (int)o.Bel,
                                Kalca = (int)o.Kalca,
                                Bacak = (int)o.Bacak
                            }).ToList();
            //gridControl1.DataSource = degerler;

            olculerBindingSource.DataSource = degerler;
        }
        void Guncelleme()
        {
            OlculerDTO olculerDTO = new OlculerDTO();
            OlculerDTO SecilenKisi = uyeProvider.UyeOlculeriniGor(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")));
            XtraFormUyeOlculeriGuncelle olculer = new XtraFormUyeOlculeriGuncelle(SecilenKisi);
            olculer.Show();
        }
        void Sil()
        {
            OlculerDTO olculerDTO = new OlculerDTO();
            OlculerDTO SecilenKisi = uyeProvider.UyeOlculeriniGor(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")));
            olculerDTO.ID = SecilenKisi.ID;
            olculerDTO.SilindiMi = AktifMi;
            uyeProvider.UyeOlculerSil(olculerDTO);
        }
        void Gizle()
        {
            //gridView1.Columns["ID"].Visible = false;
            //gridView1.Columns["UyeAdSoyad"].Visible = false;
            //gridView1.Columns["SilindiMi"].Visible = false;
        }
        private void XtraFormUyeOlculeri_Load(object sender, EventArgs e)
        {
            Listele();
            label9.Text = _uye.AdSoyad;
            Gizle();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xtraFormYeniUyeOlculeri == null || xtraFormYeniUyeOlculeri.IsDisposed)
            {
                xtraFormYeniUyeOlculeri = new XtraFormYeniUyeOlculeri(_uye);
                xtraFormYeniUyeOlculeri.Show();
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