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
    public partial class FrmUyeligiBitenler : DevExpress.XtraEditors.XtraForm
    {
        public FrmUyeligiBitenler()
        {
            InitializeComponent();
        }
        SporSalonuEntities DbSpr;
        void Listeleme()
        {
            DbSpr = new SporSalonuEntities();
            var degerler = (from u in DbSpr.Uyeler
                            join y in DbSpr.Yonetici on u.KimGirisYapti equals y.ID
                            /*where u.AktifMi == false */where u.BitisTarihi <= DateTime.Today
                            select new UyeDetayDTO
                            {
                                ID = u.ID,
                                AdSoyad = u.AdSoyad,
                                Telefon = u.Telefon,
                                BaslangicTarihi = (DateTime)u.BaslangicTarihi,
                                BitisTarihi = (DateTime)u.BitisTarihi,
                                KimGirisYapti = y.AdSoyad,
                                AktifMi = (bool)u.AktifMi
                            }).ToList();
            uyelerBindingSource.DataSource = degerler;
        }
        private void FrmUyeligiBitenler_Load(object sender, EventArgs e)
        {
            DbSpr = new SporSalonuEntities();
            Listeleme();
        }
        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "Sıra No")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }
    }
}