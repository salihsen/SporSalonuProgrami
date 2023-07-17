using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuProgrami
{
    class Cikis
    {
        public void Kapatma()
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                //this.Close();  ---KIZIYOR---
                Application.Exit();
            }
        }
    }
}
