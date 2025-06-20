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
    public partial class UyeGirisForm : Form
    {
        public UyeGirisForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;


            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre girin.");
                return;
            }

            try
            {
                using(var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "SELECT * FROM uyeler WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre AND onay_durumu = TRUE";

                    using(var komut =new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        komut.Parameters.AddWithValue("@sifre", sifre);

                        using (var okuyucu = komut.ExecuteReader())
                        {
                            if (okuyucu.Read())
                            {
                                int uyeId = okuyucu.GetInt32("uye_id");
                                MessageBox.Show("Giriş başarılı!");
                                UyeIslemlerForm uyeIslemlerForm = new UyeIslemlerForm(uyeId);
                                this.Hide();
                                uyeIslemlerForm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre hatalı, ya da hesabınız henüz onaylanmamış.");
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Giriş yapılırken bir hata oluştu: " + ex.Message);
            }

        }
    }
}
