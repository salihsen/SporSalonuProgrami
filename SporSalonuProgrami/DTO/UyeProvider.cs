using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SporSalonuProgrami.Entity;
using SporSalonuProgrami.DTO;

namespace SporSalonuProgrami
{
    class UyeProvider
    {
        SqlConnection conn;
        SqlCommand cmd;
        public UyeProvider()
        {
            Baglan();
        }
        public void Baglan()
        {
            conn = new SqlConnection("server=DESKTOP-GEA71NN; database=SporSalonu; user id=sa; password=1;");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        public void Listele(UyelerDTO u)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM uyeler WHERE DATEDIFF(DAY ,GETDATE(), BitisTarihi) = 3";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //int sayac = 1;
                while (reader.Read())
                {
                    u.ID = Convert.ToInt32(reader[0].ToString());
                    //u.NO += sayac;
                    u.AdSoyad += reader[1].ToString();
                    u.AdSoyad += ", ";
                    //u.Telefonu = reader[2].ToString();
                    //u.DogumTarihi = Convert.ToDateTime(reader[3].ToString());
                    //u.Cinsiyet = reader[4].ToString();
                    //u.KanGrubu = reader[5].ToString();
                    //u.BaslangicTarihi = Convert.ToDateTime(reader[6].ToString());
                    //u.BitisTarihi = Convert.ToDateTime(reader[7].ToString());
                    //u.OzelDersAliyorMu = reader[8].ToString();
                    //u.Mail = reader[9].ToString();
                    //u.Not = reader[10].ToString();
                    //sayac++;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void Ekle(UyeAdd u)
        {
            try
            {
                string format = "yyyy-MM-dd HH:mm:ss";
                cmd.CommandText = "Insert Into Uyeler (AdSoyad,Telefon,DogumTarihi,Cinsiyet,KanGrubu,BaslangicTarihi, BitisTarihi,[P.Coaching],Mail,[NOT],KimGirisYapti) Values ('" + u.AdSoyad + "','" + u.Telefonu + "','" + u.DogumTarihi.ToString(format) + "','" + u.Cinsiyet + "','" + u.KanGrubu + "','" + u.BaslangicTarihi.ToString(format) + "','" + u.BitisTarihi.ToString(format) + "','" + u.OzelDersAliyorMu + "','" + u.Mail + "','" + u.Not + "','" + u.AktifMi + "','" + u.KimGirisYapti + "')";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Gerçekleşti", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void Guncelle(UyeUpdate YeniUye)
        {
            try
            {
                string format = "yyyy-MM-dd HH:mm:ss";
                cmd.CommandText = "Update Uyeler SET AdSoyad='" + YeniUye.AdSoyad + "',Telefon='" + YeniUye.Telefonu + "',DogumTarihi='" + YeniUye.DogumTarihi.ToString(format) + "',Cinsiyet='" + YeniUye.Cinsiyet + "',KanGrubu='" + YeniUye.KanGrubu + "',BaslangicTarihi='" + YeniUye.BaslangicTarihi.ToString(format) + "', BitisTarihi='" + YeniUye.BitisTarihi.ToString(format) + "',[P.Coaching]='" + YeniUye.OzelDersAliyorMu + "',Mail='" + YeniUye.Mail + "',[NOT]='" + YeniUye.Not + "' Where ID=" + YeniUye.ID;

                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Güncellendi", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void Sil(UyelerDTO YeniUye)
        {
            try
            {
                cmd.CommandText = "Update Uyeler SET AktifMi='" + YeniUye.AktifMi + "' Where ID=" + YeniUye.ID;

                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Silindi", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public List<OlculerDTO> OlcuListele()
        {
            try
            {
                List<OlculerDTO> olculer = new List<OlculerDTO>();
                cmd.CommandText = "Select * From Olculer";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OlculerDTO o = new OlculerDTO();
                    o.Kilo = Convert.ToInt32(reader[2].ToString());
                    o.Boy = Convert.ToInt32(reader[3].ToString());
                    o.Omuz = Convert.ToInt32(reader[4].ToString());
                    o.Gogus = Convert.ToInt32(reader[5].ToString());
                    o.Bel = Convert.ToInt32(reader[6].ToString());
                    o.Kalca = Convert.ToInt32(reader[7].ToString());
                    o.Bacak = Convert.ToInt32(reader[8].ToString());
                    o.Kol = Convert.ToInt32(reader[9].ToString());
                    olculer.Add(o);
                }
                return olculer;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void DogumgunuOlanUyeler(UyelerDTO u)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd.CommandText = "SELECT ID,AdSoyad FROM Uyeler WHERE DAY(DogumTarihi) = DAY(GETDATE()) AND MONTH(DogumTarihi) = MONTH(GETDATE())";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    u.ID = Convert.ToInt32(reader[0].ToString());
                    u.AdSoyad += reader[1].ToString();
                    u.AdSoyad += ", ";
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public UyelerDTO UyeBilgileriniGor(int UyeID)
        {
            try
            {
                cmd.CommandText = "Select * From Uyeler where ID=" + UyeID;
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                UyelerDTO uye = new UyelerDTO();
                while (reader.Read())
                {
                    uye.ID = Convert.ToInt32(reader[0].ToString());
                    uye.AdSoyad = reader[1].ToString();
                    uye.Telefonu = reader[2].ToString();
                    uye.DogumTarihi = Convert.ToDateTime(reader[3].ToString());
                    uye.Cinsiyet = reader[4].ToString();
                    uye.KanGrubu = reader[5].ToString();
                    uye.BaslangicTarihi = Convert.ToDateTime(reader[6].ToString());
                    uye.BitisTarihi = Convert.ToDateTime(reader[7].ToString());
                    uye.OzelDersAliyorMu = reader[8].ToString();
                    uye.Mail = reader[9].ToString();
                    uye.Not = reader[10].ToString();
                }
                return uye;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public List<HizmetVeUrunler> UrunVeHizmetler()
        {
            try
            {
                List<HizmetVeUrunler> hizmetVeUrunlers = new List<HizmetVeUrunler>();
                List<YoneticiDTO> yoneticis = new List<YoneticiDTO>();
                cmd.CommandText = "select u.ID,u.Tarih,u.UrunAdi,u.Miktari,u.SatisFiyati,u.uyeID,u.Kategori,u.[P.Coaching],u.SalonUcreti, y.AdSoyad as'İşlem Yapan Yöneticiler' from UrunVeHizmetler u inner Join Yonetici y on u.KimGirisYapti = y.ID";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HizmetVeUrunler hizmetVeUrunler = new HizmetVeUrunler();
                    YoneticiDTO yonetici = new YoneticiDTO();
                    hizmetVeUrunler.ID = Convert.ToInt32(reader[0].ToString());
                    hizmetVeUrunler.Tarih = Convert.ToDateTime(reader[1].ToString());
                    hizmetVeUrunler.UrunAdi = reader[2].ToString();
                    hizmetVeUrunler.Miktari = reader[3].ToString();
                    hizmetVeUrunler.SatisFiyat = reader[4].ToString();
                    hizmetVeUrunler.Alici = reader[5].ToString();
                    hizmetVeUrunler.Kategori = reader[6].ToString();
                    hizmetVeUrunler.PCoaching = reader[7].ToString();
                    hizmetVeUrunler.SalonUcreti = reader[8].ToString();
                    yonetici.ID = Convert.ToInt32(reader[0].ToString());
                    yonetici.AdSoyad = reader[2].ToString();
                    hizmetVeUrunlers.Add(hizmetVeUrunler);
                    yoneticis.Add(yonetici);
                }
                return hizmetVeUrunlers;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void FirmaBilgileriEkle(FirmaBilgileriDTO fb)
        {
            try
            {
                cmd.CommandText = "Insert Into FirmaBilgileri (FirmaAdi,Adres,Sehir,SirketNo,Fax,Email,WebSitesi) Values ('" + fb.FirmaAdi + "','" + fb.Adres + "','" + fb.Sehir + "','" + fb.SirketNo + "','" + fb.Fax + "','" + fb.Email + "','" + fb.WebSitesi + "')";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Gerçekleşti", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public List<YoneticiDTO> YoneticiListele()
        {
            try
            {
                List<YoneticiDTO> yonetici = new List<YoneticiDTO>();
                cmd.CommandText = "Select * From Yonetici";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    YoneticiDTO yoneticis = new YoneticiDTO();
                    yoneticis.ID = Convert.ToInt32(reader[0].ToString());
                    yoneticis.AdSoyad = reader[1].ToString();
                    yoneticis.KullaniciAdi = reader[2].ToString();
                    yoneticis.Sifre = reader[3].ToString();
                    yoneticis.AdminMi = Convert.ToBoolean(reader[4].ToString());

                    yonetici.Add(yoneticis);
                }
                return yonetici;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void YoneticiEkle(YoneticiDTO yn)
        {
            try
            {
                cmd.CommandText = "Insert Into Yonetici (AdSoyad,KullaniciAdi,Sifre) Values ('" + yn.AdSoyad + "','" + yn.KullaniciAdi + "','" + yn.Sifre + "')";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Gerçekleşti", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void YoneticiGuncelleme(YoneticiDTO yonetici)
        {
            try
            {
                cmd.CommandText = "Update Yonetici SET Sifre='" + yonetici.Sifre + "' Where ID=" + yonetici.ID;

                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Güncellendi", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void YoneticiSil(YoneticiDTO y)
        {
            try
            {
                cmd.CommandText = "Delete From Yonetici Where ID=" + y.ID + "";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Silindi", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void YoneticiGirisi(YoneticiGirisiDTO yoneticiGirisi)
        {
            try
            {
                cmd.CommandText = "Update YoneticiGirisi SET Sifre=" + yoneticiGirisi.Sifre;

                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifreniz Başarılı Bir Şekilde Bir Değişmiştir");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        //public void UyelikSuresiDolmusKullanicilar(Uye uyeler)
        //{
        //    try
        //    {
        //        cmd.CommandText = " SELECT * FROM uyeler WHERE DATEDIFF(DAY ,GETDATE(), BitisTarihi) = 1";
        //        cmd.CommandType = CommandType.Text;
        //        if (conn.State == ConnectionState.Closed) conn.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        int sayac = 1;
        //        while (reader.Read())
        //        {
        //            Uye u = new Uye();
        //            u.ID = Convert.ToInt32(reader[0].ToString());
        //            u.NO += sayac;
        //            u.AdSoyad = reader[1].ToString();
        //            //u.Telefonu = reader[2].ToString();
        //            //u.DogumTarihi = Convert.ToDateTime(reader[3].ToString());
        //            //u.Cinsiyet = reader[4].ToString();
        //            //u.KanGrubu = reader[5].ToString();
        //            //u.BaslangicTarihi = Convert.ToDateTime(reader[6].ToString());
        //            //u.BitisTarihi = Convert.ToDateTime(reader[7].ToString());
        //            //u.OzelDersAliyorMu = reader[8].ToString();
        //            //u.Mail = reader[9].ToString();
        //            //u.Not = reader[10].ToString();

        //            sayac++;

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (conn.State == ConnectionState.Open) conn.Close();
        //    }
        //}
        public void UrunVeHizmetlerEkle(UrunVeHizmetlerAdd hizmetVeUrunler)
        {
            try
            {
                string format = "yyyy-MM-dd HH:mm:ss";
                cmd.CommandText = "Insert Into UrunVeHizmetler (Tarih,UrunAdi,Miktari,SatisFiyati,UyeID,Kategori,[P.Coaching],SalonUcreti,KimGirisYapti) Values ('" + hizmetVeUrunler.Tarih.ToString(format) + "','" + hizmetVeUrunler.UrunAdi + "','" + hizmetVeUrunler.Miktari + "','" + hizmetVeUrunler.SatisFiyat + "','" + hizmetVeUrunler.UyeID + "','" + hizmetVeUrunler.Kategori + "','" + hizmetVeUrunler.PCoaching + "','" + hizmetVeUrunler.SalonUcreti + "','" + hizmetVeUrunler.KimGirisYapti + "')";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Gerçekleşti", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void AntremanEkle(AntremanAdd add)
        {
            try
            {
                cmd.CommandText = "Insert Into Antreman (Hareket,[Set],Tekrar,Aciklama) Values ('" + add.Hareket + "','" + add.SeviyeID + "','" + add.Aciklama + "')";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Gerçekleşti", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public UrunVeHizmetlerDetayDTO UrunVeHizmetlerListele(int urunID)
        {
            try
            {
                cmd.CommandText = "Select * From UrunVeHizmetler where ID=" + urunID;
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                UrunVeHizmetlerDetayDTO urun = new UrunVeHizmetlerDetayDTO();
                while (reader.Read())
                {
                    urun.ID = Convert.ToInt32(reader[0].ToString());
                    urun.Tarih = Convert.ToDateTime(reader[1].ToString());
                    urun.UrunlerID = Convert.ToInt32(reader[2].ToString());
                    urun.Miktari = reader[3].ToString();
                    urun.Fiyati = Convert.ToDecimal(reader[4].ToString());
                    urun.UyeID = Convert.ToInt32(reader[5].ToString());
                    urun.Tip = reader[6].ToString();
                    urun.Aciklama = reader[7].ToString();
                    urun.SilindiMi = Convert.ToBoolean(reader[8].ToString());
                    urun.KimGirisYapti = reader[9].ToString();
                }
                return urun;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void UrunVeHizmetlerGuncelle(UrunVeHizmetlerUpdate update)
        {
            try
            {
                string format = "yyyy-MM-dd HH:mm:ss";
                cmd.CommandText = "Update UrunVeHizmetler SET Tarih='" + update.Tarih.ToString(format) + "',UrunAdi='" + update.UrunAdi + "',Miktari='" + update.Miktari + "',SatisFiyati='" + update.SatisFiyat + "',UyeID='" + update.Alici + "' Where ID=" + update.ID;

                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Güncellendi", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public List<FirmaBilgileriDTO> FirmaBilgileriListele()
        {
            try
            {
                List<FirmaBilgileriDTO> fbilgileri = new List<FirmaBilgileriDTO>();
                cmd.CommandText = "SELECT * FROM FirmaBilgileri";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FirmaBilgileriDTO fb = new FirmaBilgileriDTO();
                    fb.ID = Convert.ToInt32(reader[0].ToString());
                    fb.FirmaAdi = reader[1].ToString();
                    fb.Adres = reader[2].ToString();
                    fb.Sehir = reader[3].ToString();
                    fb.SirketNo = reader[4].ToString();
                    fb.Fax = reader[5].ToString();
                    fb.Email = reader[6].ToString();
                    fb.WebSitesi = reader[7].ToString();
                    fbilgileri.Add(fb);
                }
                return fbilgileri;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void FrmListele(FirmaBilgileriDTO fb)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM FirmaBilgileri";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fb.ID = Convert.ToInt32(reader[0].ToString());
                    fb.FirmaAdi = reader[1].ToString();
                    fb.Adres = reader[2].ToString();
                    fb.Sehir = reader[3].ToString();
                    fb.SirketNo = reader[4].ToString();
                    fb.Fax = reader[5].ToString();
                    fb.Email = reader[6].ToString();
                    fb.WebSitesi = reader[7].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public List<HizmetVeUrunler> UyeUrunHizmetler()
        {
            try
            {
                List<HizmetVeUrunler> hizmetVeUrunlers = new List<HizmetVeUrunler>();
                List<YoneticiDTO> yoneticis = new List<YoneticiDTO>();
                cmd.CommandText = "select u.ID,u.Tarih,u.UrunAdi,u.Miktari,u.SatisFiyati,u.uyeID,u.Kategori,u.[P.Coaching],u.SalonUcreti, y.AdSoyad as'İşlem Yapan Yöneticiler' from UrunVeHizmetler u inner Join Yonetici y on u.KimGirisYapti = y.ID ";//where u.UyeID=
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HizmetVeUrunler hizmetVeUrunler = new HizmetVeUrunler();
                    YoneticiDTO yonetici = new YoneticiDTO();
                    hizmetVeUrunler.ID = Convert.ToInt32(reader[0].ToString());
                    hizmetVeUrunler.Tarih = Convert.ToDateTime(reader[1].ToString());
                    hizmetVeUrunler.UrunAdi = reader[2].ToString();
                    hizmetVeUrunler.Miktari = reader[3].ToString();
                    hizmetVeUrunler.SatisFiyat = reader[4].ToString();
                    hizmetVeUrunler.Alici = reader[5].ToString();
                    hizmetVeUrunler.Kategori = reader[6].ToString();
                    hizmetVeUrunler.PCoaching = reader[7].ToString();
                    hizmetVeUrunler.SalonUcreti = reader[8].ToString();
                    yonetici.ID = Convert.ToInt32(reader[0].ToString());
                    yonetici.AdSoyad = reader[2].ToString();
                    hizmetVeUrunlers.Add(hizmetVeUrunler);
                    yoneticis.Add(yonetici);
                }
                return hizmetVeUrunlers;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void AntremanListele(AntremanListele listele)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM Antreman";
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listele.ID = Convert.ToInt32(reader[0].ToString());
                    listele.Hareket = reader[1].ToString();
                    listele.SeviyeID = Convert.ToInt32(reader[2].ToString());
                    listele.Aciklama = reader[3].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void UrunveHizmetlerSil(UrunVeHizmetlerDetayDTO urunVeHizmetlerDetayDTO)
        {
            try
            {
                cmd.CommandText = "Update UrunVeHizmetler SET SilindiMİ='" + urunVeHizmetlerDetayDTO.SilindiMi + "' Where ID=" + urunVeHizmetlerDetayDTO.ID;

                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Silindi", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public OlculerDTO UyeOlculeriniGor(int OlcuID)
        {
            try
            {
                cmd.CommandText = "Select * From Olculer where ID=" + OlcuID;
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                OlculerDTO olculer = new OlculerDTO();
                while (reader.Read())
                {
                    olculer.ID = Convert.ToInt32(reader[0].ToString());
                    olculer.Tarih = Convert.ToDateTime(reader[1].ToString());
                    olculer.UyeAdSoyad = reader[2].ToString();
                    olculer.Boy = Convert.ToInt32(reader[3].ToString());
                    olculer.Kilo = Convert.ToInt32(reader[4].ToString());
                    olculer.Omuz = Convert.ToInt32(reader[5].ToString());
                    olculer.Gogus = Convert.ToInt32(reader[6].ToString());
                    olculer.Kol = Convert.ToInt32(reader[7].ToString());
                    olculer.Bel = Convert.ToInt32(reader[8].ToString());
                    olculer.Kalca = Convert.ToInt32(reader[9].ToString());
                    olculer.Bacak = Convert.ToInt32(reader[10].ToString());
                    olculer.SilindiMi = Convert.ToBoolean(reader[11].ToString());
                }
                return olculer;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void UyeOlculerSil(OlculerDTO olculer)
        {
            try
            {
                cmd.CommandText = "Update Olculer SET SilindiMi='" + olculer.SilindiMi + "' Where Olculer.ID=" + olculer.ID;

                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Silindi", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void UyeOlculerGuncelle(UyeOlculeriGuncelle olculer)
        {
            try
            {
                string format = "yyyy-MM-dd HH:mm:ss";
                cmd.CommandText = "Update Olculer SET Tarih='" + olculer.Tarih.ToString(format) + "',UyelerID='" + olculer.UyeAdSoyad + "',Kilo='" + olculer.Kilo + "',Boy='" + olculer.Boy + "',Omuz='" + olculer.Omuz + "',Gogus='" + olculer.Gogus + "', Bel='" + olculer.Bel + "',Kalca='" + olculer.Kalca + "',Bacak='" + olculer.Bacak + "',Kol='" + olculer.Kol + "',SilindiMi='" + olculer.SilindiMi + "' Where ID=" + olculer.ID;

                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} Kayıt Güncellendi", sonuc));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public YoneticiDTO yoneticiBilgileriniGor(int UyeID)
        {
            try
            {
                cmd.CommandText = "Select * From Yonetici where ID=" + UyeID;
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                YoneticiDTO yonetici = new YoneticiDTO();
                while (reader.Read())
                {
                    yonetici.ID = Convert.ToInt32(reader[0].ToString());
                    yonetici.AdSoyad = reader[1].ToString();
                    yonetici.KullaniciAdi = reader[2].ToString();
                    yonetici.Sifre = reader[3].ToString();
                }
                return yonetici;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public UrunDetayDTO StokBilgileri(int urunID)
        {
            try
            {
                cmd.CommandText = "Select * From Urunler where ID=" + urunID;
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                UrunDetayDTO urun = new UrunDetayDTO();
                while (reader.Read())
                {
                    urun.ID = Convert.ToInt32(reader[0].ToString());
                    urun.Tarih = Convert.ToDateTime(reader[1].ToString());
                    urun.UrunAdi = reader[2].ToString();
                    urun.BirimFiyati = Convert.ToDecimal(reader[3].ToString());
                    urun.SatisFiyati = Convert.ToDecimal(reader[4].ToString());
                    urun.StokAdeti = Convert.ToInt32(reader[5].ToString());
                }
                return urun;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}

