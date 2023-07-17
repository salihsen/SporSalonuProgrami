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
using System.Net.Mail;

namespace SporSalonuProgrami
{
    public partial class XtraFormAntreman : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormAntreman()
        {
            InitializeComponent();
        }
        SporSalonuEntities DbSpr = new SporSalonuEntities();
        void Listeleme()
        {
            DbSpr = new SporSalonuEntities();
            var degerler = (from u in DbSpr.Uyeler
                                //where x.SeviyeID == id
                            select new UyeDetayDTO
                            {
                                ID = u.ID,
                                AdSoyad = u.AdSoyad
                            }).ToList();
            //gridControl1.DataSource = degerler;
            uyelerBindingSource.DataSource = degerler;
        }
        void MailGonder()
        {
            //MailMessage message = new MailMessage();
            //SmtpClient istemci = new SmtpClient();
            //istemci.Credentials = new System.Net.NetworkCredential("shennsalih@gmail.com", "351@salih*1650!");
            //istemci.Port = 587;
            //istemci.Host = "smtp.gmail.com";
            //istemci.EnableSsl = false;
            //message.To.Add(textBox1.Text);
            //message.From = new MailAddress("shennsalih@gmail.com");
            //message.Subject = textBox2.Text;
            //message.Body = textBox3.Text;
            //istemci.Send(message);

            //FirmaBilgileri firmaBilgileri = new FirmaBilgileri();
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(textBox1.Text/*uye maili gelicek*/));//Gönderilecek Mail Adresi
            msg.From = new MailAddress("salihsen1923@gmail.com"/*firmaBilgileri.Mail*/);//Gönderen Mail Adresi
            msg.Subject = textBox2.Text;
            msg.Body = textBox2.Text;
            msg.IsBodyHtml = true;

            //string FileName = Application.StartupPath + "..\\..\\..\\Documents\\tf02930055_win321.xlsx";//Dosya Yolunu bulamadıgı İçin \\..\\..\\..\\ üste çık dedik
            ////var attachmnet = new Attachment(File.Open(@"‪‪C:\Users\SALİH\Desktop\tf02930055_win32.xlsx", FileMode.Open), "fileName.xls");
            ////attachmnet.ContentType = new ContentType("application/vnd.ms-excel");
            //msg.Attachments.Add(new Attachment(FileName));

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("salihsen1923@gmail.com", "5382951650s");//From mail şifre
            client.Port = 587; // You can use Port 25 if 587 is blocked (mine is!)
            client.Host = "smtp.gmail.com";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            //client.Send(msg);
            try
            {
                client.Send(msg);
                MessageBox.Show("Başarılı Bir Şekilde Mailiniz İletilmiştir");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciAntremanBindingSource.RemoveCurrent();
            DbSpr.SaveChanges();
        }
        private void XtraForm2_Load(object sender, EventArgs e)
        {
            Listeleme();
            antremanBindingSource.DataSource = DbSpr.Antreman.ToList();
            DbSpr.KullaniciAntreman.Load();
            kullaniciAntremanBindingSource.DataSource = DbSpr.KullaniciAntreman.Local;
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DbSpr.SaveChanges();
        }
        private void btnMailGonder_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MailGonder();
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm1 xtraForm1 = new XtraForm1();
            xtraForm1.Show();
        }
        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "Sıra No")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }
    }
}