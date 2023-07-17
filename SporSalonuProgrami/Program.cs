using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuProgrami
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();// bu 
            DevExpress.Skins.SkinManager.EnableFormSkins();//ve bunu bonus Skin için ekledim formun görünümünü değiştiriyormuş
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmKullanıcıAnaSayfa());

        }
    }
}
