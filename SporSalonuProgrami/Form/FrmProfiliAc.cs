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
    public partial class XtraFormProfiliAc : DevExpress.XtraEditors.XtraForm
    {
        UyelerDTO _uye;
        public XtraFormProfiliAc(UyelerDTO uye)
        {
            InitializeComponent();
            _uye = uye;
        }
        public int KimGirisYapti;
        UyeProvider uyeProvider = new UyeProvider();
        void Listele()
        {
            UyelerDTO u = new UyelerDTO();
            u.ID = _uye.ID;
            txtAdSoyad.Text = _uye.AdSoyad;
            txtTellNo.Text = _uye.Telefonu;
            dtmpckrDogumTarihi.Value = _uye.DogumTarihi;
            cmbxCinsiyet.Text = _uye.Cinsiyet;
            cmbxKanGrubu.Text = _uye.KanGrubu;
            dtmpckBaslangicTarihi.Value = _uye.BaslangicTarihi;
            dtmpckBitisTarihi.Value = _uye.BitisTarihi;
            cmbxPCoaching.Text = _uye.OzelDersAliyorMu;
            txtMail.Text = _uye.Mail;
            txtNot.Text = _uye.Not;
        }
        void Temizleme()
        {
            txtAdSoyad.Text = " ";
            txtTellNo.Text = " ";
            dtmpckrDogumTarihi.Value = Convert.ToDateTime(DateTime.Now);
            //txtCinsiyet.Clear();
            //txtKanGrubu.Clear();
            dtmpckBaslangicTarihi.Value = Convert.ToDateTime(DateTime.Now);
            dtmpckBitisTarihi.Value = Convert.ToDateTime(DateTime.Now);
            //txtOzelDersAlıyorMu.Clear();
            txtMail.Text = " ";
            txtNot.Text = " ";
        }
        void Ekleme()
        {
            UyeUpdate uye = new UyeUpdate();
            uye.ID = _uye.ID;
            uye.AdSoyad = txtAdSoyad.Text;
            uye.Telefonu = txtTellNo.Text;
            uye.DogumTarihi = dtmpckrDogumTarihi.Value;
            uye.Cinsiyet = cmbxCinsiyet.Text;
            uye.KanGrubu = cmbxKanGrubu.Text;
            uye.BaslangicTarihi = dtmpckBaslangicTarihi.Value;
            uye.BitisTarihi = dtmpckBitisTarihi.Value;
            uye.OzelDersAliyorMu = cmbxPCoaching.Text;
            uye.Mail = txtMail.Text;
            uye.Not = txtNot.Text;
            uyeProvider.Guncelle(uye);
        }
        void CmbBoxEkleme()
        {
            cmbxUyelikTipi.SelectedItem.ToString();
            int a = Convert.ToInt32(cmbxUyelikTipi.SelectedIndex.ToString());
            if (a == 0)
            {
                dtmpckBitisTarihi.Value = Convert.ToDateTime(DateTime.Today);
                dtmpckBitisTarihi.Value = dtmpckBitisTarihi.Value.AddMonths(1);
            }
            if (a == 1)
            {
                dtmpckBitisTarihi.Value = Convert.ToDateTime(DateTime.Today);
                dtmpckBitisTarihi.Value = dtmpckBitisTarihi.Value.AddMonths(3);
            }
            if (a == 2)
            {
                dtmpckBitisTarihi.Value = Convert.ToDateTime(DateTime.Today);
                dtmpckBitisTarihi.Value = dtmpckBitisTarihi.Value.AddMonths(6);
            }
            if (a == 3)
            {
                dtmpckBitisTarihi.Value = Convert.ToDateTime(DateTime.Today);
                dtmpckBitisTarihi.Value = dtmpckBitisTarihi.Value.AddYears(1);
            }
        }
        private void XtraFormProfiliAc_Load(object sender, EventArgs e)
        {
            Temizleme();
            Listele();
        }
        private void btnAntreman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormUyeAntreman frmUyeAntreman = new XtraFormUyeAntreman(_uye);
            frmUyeAntreman.Show();
        }
        private void btnUrunVeHizmetler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormUyeUrunVeHizmetler frmUyeUrunVeHizmetler = new XtraFormUyeUrunVeHizmetler(_uye);
            frmUyeUrunVeHizmetler.KimGirisYapti = KimGirisYapti;
            frmUyeUrunVeHizmetler.Show();
        }
        private void btnOlculer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormUyeOlculeri frmOlculer= new XtraFormUyeOlculeri(_uye);
            frmOlculer.Show();
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Ekleme();
        }
        private void cmbxUyelikTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbBoxEkleme();
        }
    }
}