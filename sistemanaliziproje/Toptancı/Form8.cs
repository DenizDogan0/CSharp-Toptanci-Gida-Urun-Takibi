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
    public partial class ProfilDuzenleForm : Form
    {

        private int uyeId;

        public ProfilDuzenleForm(int uyeId)
        {
            InitializeComponent();
            this.uyeId = uyeId;
        }

        private void ProfilDuzenleForm_Load(object sender, EventArgs e)
        {
            UyeBilgileriniGetir();
        }

     

        private void UyeBilgileriniGetir()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "SELECT ad, soyad, email, telefon, adres, firma_adi, vergi_no FROM uyeler WHERE uye_id = @uyeId";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@uyeId", uyeId);
                        using (var okuyucu = komut.ExecuteReader())
                        {
                            if (okuyucu.Read())
                            {
                                txtAd.Text = okuyucu["ad"].ToString();
                                txtSoyad.Text = okuyucu["soyad"].ToString();
                                txtEmail.Text = okuyucu["email"].ToString();
                                txtTelefon.Text = okuyucu["telefon"].ToString();
                                txtAdres.Text = okuyucu["adres"].ToString();
                                txtFirmaAdi.Text = okuyucu["firma_adi"].ToString();
                                txtVergiNo.Text = okuyucu["vergi_no"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye bilgileri alınırken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"UPDATE uyeler 
                                     SET ad = @ad, soyad = @soyad, email = @email, telefon = @telefon, 
                                         adres = @adres, firma_adi = @firmaAdi, vergi_no = @vergiNo 
                                     WHERE uye_id = @uyeId";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", txtAd.Text);
                        komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        komut.Parameters.AddWithValue("@email", txtEmail.Text);
                        komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                        komut.Parameters.AddWithValue("@firmaAdi", txtFirmaAdi.Text);
                        komut.Parameters.AddWithValue("@vergiNo", txtVergiNo.Text);
                        komut.Parameters.AddWithValue("@uyeId", uyeId);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Bilgileriniz başarıyla güncellendi.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Bilgileriniz güncellenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgiler güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
