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
    public partial class FrmKullanıcıAnaSayfa : Form
    {
        public FrmKullanıcıAnaSayfa()
        {
            InitializeComponent();
        }
        FrmUyeler frmAnaSayfa;
        //FrmUyeEkle frmUyeEkle;
        public int KimGirisYapti;
        XtraFormAntreman frmAntreman;
        FrmUrunVeHizmetler frmUrunVeHizmetler;
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAnaSayfa == null)
            {
                frmAnaSayfa = new FrmUyeler();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
                //frmAnaSayfa = null;//dediğim zaman tekrar açılıyor ama açılmış olsa bile yine açılıyor olmadığı zaman sadece bir kere açılıyor
            }
        }
        private void btnUyeEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (frmUyeEkle == null)
            //{
                //frmUyeEkle = new FrmUyeEkle();
                //frmUyeEkle.MdiParent = this;
                //frmUyeEkle.KimGirisYapti = KimGirisYapti;
                //frmUyeEkle.Show();
                //frmAnaSayfa = null;//dediğim zaman tekrar açılıyor ama açılmış olsa bile yine açılıyor olmadığı zaman sadece bir kere açılıyor
            //}
        }
        private void btnAntreman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAntreman == null)
            {
                frmAntreman = new XtraFormAntreman();
                frmAntreman.MdiParent = this;
                frmAntreman.Show();
            }
        }
        private void btnUrunVeHizmetler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunVeHizmetler == null)
            {
                frmUrunVeHizmetler = new FrmUrunVeHizmetler();
                frmUrunVeHizmetler.MdiParent = this;
                frmUrunVeHizmetler.KimGirisYapti = KimGirisYapti;
                frmUrunVeHizmetler.Show();
            }
        }
    }
}
