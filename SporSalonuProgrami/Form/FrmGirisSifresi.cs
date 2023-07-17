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
    public partial class XtraFormGirisSifresi : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormGirisSifresi()
        {
            InitializeComponent();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UyeProvider uyeProvider = new UyeProvider();
            YoneticiGirisiDTO yoneticiGirisi = new YoneticiGirisiDTO();
            yoneticiGirisi.Sifre = txtSifre.Text;
            uyeProvider.YoneticiGirisi(yoneticiGirisi);
            txtSifre.Clear();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}