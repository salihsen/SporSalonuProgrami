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
using System.Data.Entity;

namespace SporSalonuProgrami
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        SporSalonuEntities DbSpr = new SporSalonuEntities();
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            DbSpr.KullaniciAntreman.Load();
            kullaniciAntremanBindingSource.DataSource = DbSpr.KullaniciAntreman.Local;
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DbSpr.SaveChanges();
        }
    }
}