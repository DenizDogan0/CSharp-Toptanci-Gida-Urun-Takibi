using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toptancı
{
    public partial class UyeKayitForm : Form
    {
        public UyeKayitForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string email = txtEmail.Text;
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;
            string firmaAdi = txtFirmaAdi.Text;
            string vergiNo = txtVergiNo.Text;


            try
            {
                using(var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"INSERT INTO uyeler (kullanici_adi, sifre, ad, soyad, email, telefon, adres, firma_adi, vergi_no) 
                                 VALUES (@kullaniciAdi, @sifre, @ad, @soyad, @email, @telefon, @adres, @firmaAdi, @vergiNo)";

                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        komut.Parameters.AddWithValue("@sifre", sifre);
                        komut.Parameters.AddWithValue("@ad", ad);
                        komut.Parameters.AddWithValue("@soyad", soyad);
                        komut.Parameters.AddWithValue("@email", email);
                        komut.Parameters.AddWithValue("@telefon", telefon);
                        komut.Parameters.AddWithValue("@adres", adres);
                        komut.Parameters.AddWithValue("@firmaAdi", firmaAdi);
                        komut.Parameters.AddWithValue("@vergiNo", vergiNo);

                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Üye kaydı başarıyla oluşturuldu. Yönetici onayından sonra giriş yapabilirsiniz.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt oluşturulurken bir hata oluştu: " + ex.Message);
            }

        }
    }
}
