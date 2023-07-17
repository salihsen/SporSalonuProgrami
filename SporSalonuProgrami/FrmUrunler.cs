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
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SporSalonuEntities DbSpr = new SporSalonuEntities();
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            urunlerBindingSource.DataSource = DbSpr.Urunler.ToList();
        }
        private void btnYeniEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormStokEkleme stokEkleme = new XtraFormStokEkleme();
            stokEkleme.Show();
        }
    }
}