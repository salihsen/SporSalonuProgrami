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
    public partial class XtraFormUyeAntreman : DevExpress.XtraEditors.XtraForm
    {
        UyelerDTO _uye;
        public XtraFormUyeAntreman(UyelerDTO uye)
        {
            InitializeComponent();
            _uye = uye;
        }
        SporSalonuEntities DbSpr;
        void Listeleme()
        {
            DbSpr = new SporSalonuEntities();
            var degerler = (from k in DbSpr.KullaniciAntreman
                            where k.UyelerID == _uye.ID
                            select new KullaniciAntremanDetayDTO
                            {
                                ID = k.ID,
                                Tarih = (DateTime)k.Tarih,
                                UyelerID = (int)k.UyelerID,
                                AntremanID = (int)k.AntremanID,
                                Set = k.Set,
                                Tekrar = k.Tekrar
                            }).ToList();
            //gridControl1.DataSource = degerler;
            kullaniciAntremanBindingSource.DataSource = degerler;
        }
        private void XtraFormUyeAntreman_Load(object sender, EventArgs e)
        {
            Listeleme();
            uyelerBindingSource.DataSource = DbSpr.Uyeler.ToList();
            antremanBindingSource.DataSource = DbSpr.Antreman.ToList();
        }
    }
}