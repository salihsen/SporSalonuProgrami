using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SporSalonuProgrami
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        int id;
        bool AdminMi;
        public int KimGirisYaptiID;
        SqlConnection conn = new SqlConnection();
        UyeProvider uyeProvider = new UyeProvider();
        UyelerDTO u = new UyelerDTO();
        string connect = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
        public void AdminListele()
        {
            conn.ConnectionString = connect;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From Yonetici a Where a.KullaniciAdi=@UserName and a.Sifre=@Password";
            cmd.Parameters.AddWithValue("@UserName", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@Password", txtSifre.Text);
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = (int)reader["ID"];
                    u.KimGirisYapti= id;
                    KimGirisYaptiID = u.KimGirisYapti;
                }
                if (AdminMi == false)
                {
                    AdminMi = (bool)reader["AdminMi"];
                }
                if (AdminMi == true)
                {
                    XtraFormAnaSayfa frmAnaSayfa = new XtraFormAnaSayfa();
                    frmAnaSayfa.KimGirisYapti = KimGirisYaptiID;
                    frmAnaSayfa.Show();
                }
                if (AdminMi == false)
                {
                    XtraMessageBox.Show("Admin Yetkiniz Olmadığı için Kullanıcı Sayfasına Yönlendiriliceksiniz!!!");//Devexpress messagebox
                    FrmKullanıcıAnaSayfa frmKullanıcıAnaSayfa = new FrmKullanıcıAnaSayfa();
                    frmKullanıcıAnaSayfa.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);//Devexpress messagebox 
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdminListele();
            AdminMi = false;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            PrivateFontCollection modernfont = new PrivateFontCollection();
            modernfont.AddFontFile("..\\..\\Fonts\\Avengeance-E1zj.otf");
            labelControl1.Font = new Font(modernfont.Families[0], 15);
            labelControl2.Font = new Font(modernfont.Families[0], 15);
            labelControl3.Font = new Font(modernfont.Families[0], 30);
        }
    }
}
