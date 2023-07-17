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
    public partial class XtraFormYeniUyeOlculeri : DevExpress.XtraEditors.XtraForm
    {
        UyelerDTO _uye;
        public XtraFormYeniUyeOlculeri(UyelerDTO uye)
        {
            InitializeComponent();
            _uye = uye;
        }
        void Ekle()
        {
            SporSalonuEntities DbSpr = new SporSalonuEntities();
            Olculer olculer = new Olculer();
            olculer.Tarih = dtmpckrTarih.Value;
            olculer.UyelerID = _uye.ID;
            olculer.Boy = Convert.ToInt32(txtBoy.Text);
            olculer.Kilo = Convert.ToInt32(txtKilo.Text);
            olculer.Omuz = Convert.ToInt32(txtOmuz.Text);
            olculer.Kol = Convert.ToInt32(txtKol.Text);
            olculer.Gogus = Convert.ToInt32(txtGogus.Text);
            olculer.Kalca = Convert.ToInt32(txtKalca.Text);
            olculer.Bel = Convert.ToInt32(txtBel.Text);
            olculer.Bacak = Convert.ToInt32(txtBacak.Text);
            olculer.SilindiMi = true;
            DbSpr.Olculer.Add(olculer);
            DbSpr.SaveChanges();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ekle();
        }
    }
}