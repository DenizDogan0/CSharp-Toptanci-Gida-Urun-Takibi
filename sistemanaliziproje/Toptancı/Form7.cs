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
    public partial class SiparisDetayForm : Form
    {

        private int siparisId;

        public SiparisDetayForm(int siparisId)
        {
            InitializeComponent();
            this.siparisId = siparisId;
        }

        private void SiparisDetayForm_Load(object sender, EventArgs e)
        {
            SiparisBilgileriniGoster();
            SiparisDetaylariniListele();
        }

        private void SiparisBilgileriniGoster()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"SELECT s.siparis_id, s.siparis_tarihi, s.toplam_tutar, s.durum, u.ad, u.soyad
                                     FROM siparisler s
                                     JOIN uyeler u ON s.uye_id = u.uye_id
                                     WHERE s.siparis_id = @siparisId";

                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@siparisId", siparisId);
                        using (var okuyucu = komut.ExecuteReader())
                        {
                            if (okuyucu.Read())
                            {
                                lblSiparisBilgileri.Text = $"Sipariş No: {okuyucu["siparis_id"]}\n" +
                                                           $"Tarih: {okuyucu["siparis_tarihi"]}\n" +
                                                           $"Toplam Tutar: {okuyucu["toplam_tutar"]:C}\n" +
                                                           $"Durum: {okuyucu["durum"]}\n" +
                                                           $"Müşteri: {okuyucu["ad"]} {okuyucu["soyad"]}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş bilgileri alınırken bir hata oluştu: " + ex.Message);
            }
        }

        private void SiparisDetaylariniListele()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"SELECT u.urun_adi, sd.miktar, sd.birim_fiyat, (sd.miktar * sd.birim_fiyat) AS toplam_fiyat
                                     FROM siparis_detaylari sd
                                     JOIN urunler u ON sd.urun_id = u.urun_id
                                     WHERE sd.siparis_id = @siparisId";

                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@siparisId", siparisId);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSiparisDetaylari.DataSource = dt;
                    }
                }

                // Sütun başlıklarını düzenle
                dgvSiparisDetaylari.Columns["urun_adi"].HeaderText = "Ürün Adı";
                dgvSiparisDetaylari.Columns["miktar"].HeaderText = "Miktar";
                dgvSiparisDetaylari.Columns["birim_fiyat"].HeaderText = "Birim Fiyat";
                dgvSiparisDetaylari.Columns["toplam_fiyat"].HeaderText = "Toplam Fiyat";

                // Para birimi formatını ayarla
                dgvSiparisDetaylari.Columns["birim_fiyat"].DefaultCellStyle.Format = "C2";
                dgvSiparisDetaylari.Columns["toplam_fiyat"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş detayları listelenirken bir hata oluştu: " + ex.Message);
            }
        }


      

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
