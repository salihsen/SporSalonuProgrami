using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuProgrami
{
    public partial class FrmYoneticiGirisi : DevExpress.XtraEditors.XtraForm
    {
        public FrmYoneticiGirisi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        string connect = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
        public void Listele()
        {
            conn.ConnectionString = connect;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From YoneticiGirisi a Where a.Sifre=@Password";
            cmd.Parameters.AddWithValue("@Password", txtSifre.Text);
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    XtraFormAyarlar frmAyarlar = new XtraFormAyarlar();
                    frmAyarlar.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Hatalı Giriş Yaptınız!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            txtSifre.Clear();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}