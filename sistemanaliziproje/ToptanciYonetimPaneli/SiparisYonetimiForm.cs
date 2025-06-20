using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ToptanciYonetimPaneli
{
    public partial class SiparisYonetimiForm : Form
    {
        public SiparisYonetimiForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iptal edilecek siparişi seçin.");
                return;
            }

            int siparisId = Convert.ToInt32(dgvSiparisler.SelectedRows[0].Cells["siparis_id"].Value);
            string mevcutDurum = dgvSiparisler.SelectedRows[0].Cells["durum"].Value.ToString();

            if (mevcutDurum == "İptal Edildi")
            {
                MessageBox.Show("Bu sipariş zaten iptal edilmiş.");
                return;
            }

            if (mevcutDurum == "Tamamlandı" || mevcutDurum == "Kargoya Verildi")
            {
                MessageBox.Show("Tamamlanmış veya kargoya verilmiş siparişler iptal edilemez.");
                return;
            }

            DialogResult result = MessageBox.Show("Bu siparişi iptal etmek istediğinizden emin misiniz?", "Sipariş İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    using (var transaction = baglanti.BeginTransaction())
                    {
                        try
                        {
                            // Siparişin durumunu güncelle
                            string siparisGuncelleSorgu = "UPDATE siparisler SET durum = 'İptal Edildi' WHERE siparis_id = @siparisId";
                            using (var komut = new MySqlCommand(siparisGuncelleSorgu, baglanti, transaction))
                            {
                                komut.Parameters.AddWithValue("@siparisId", siparisId);
                                komut.ExecuteNonQuery();
                            }

                            // Ürün stoklarını geri al
                            string stokGuncelleSorgu = @"
                        UPDATE urunler u
                        JOIN siparis_detaylari sd ON u.urun_id = sd.urun_id
                        SET u.stok_miktari = u.stok_miktari + sd.miktar
                        WHERE sd.siparis_id = @siparisId";
                            using (var komut = new MySqlCommand(stokGuncelleSorgu, baglanti, transaction))
                            {
                                komut.Parameters.AddWithValue("@siparisId", siparisId);
                                komut.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Sipariş başarıyla iptal edildi ve ürün stokları güncellendi.");
                            SiparisleriListele(); // Sipariş listesini yenile
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Sipariş iptal işlemi sırasında bir hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş iptal edilirken bir hata oluştu: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen detaylarını görmek istediğiniz siparişi seçin.");
                return;
            }

            int siparisId = Convert.ToInt32(dgvSiparisler.SelectedRows[0].Cells["siparis_id"].Value);

            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"
                SELECT u.urun_adi, sd.miktar, sd.birim_fiyat, (sd.miktar * sd.birim_fiyat) AS toplam_fiyat
                FROM siparis_detaylari sd
                JOIN urunler u ON sd.urun_id = u.urun_id
                WHERE sd.siparis_id = @siparisId";

                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@siparisId", siparisId);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            SiparisDetayForm detayForm = new SiparisDetayForm();
                            detayForm.SiparisId = siparisId;
                            detayForm.SiparisDetaylari = dt;
                            detayForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Bu siparişe ait detay bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş detayları getirilirken bir hata oluştu: " + ex.Message);
            }
        }

        private void SiparisYonetimiForm_Load(object sender, EventArgs e)
        {
            SiparisleriListele();
            SiparisDurumlariniYukle();
        }

        private void SiparisleriListele()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"SELECT s.siparis_id, u.ad, u.soyad, s.siparis_tarihi, s.toplam_tutar, s.durum 
                                     FROM siparisler s
                                     JOIN uyeler u ON s.uye_id = u.uye_id
                                     ORDER BY s.siparis_tarihi DESC";
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSiparisler.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Siparişler listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void SiparisDurumlariniYukle()
        {
            cmbSiparisDurumu.Items.AddRange(new string[] { "Beklemede", "Onaylandı", "Hazırlanıyor", "Kargoya Verildi", "Tamamlandı", "İptal Edildi" });
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir sipariş seçin.");
                return;
            }

            int siparisId = Convert.ToInt32(dgvSiparisler.SelectedRows[0].Cells["siparis_id"].Value);
            string yeniDurum = cmbSiparisDurumu.SelectedItem.ToString();

            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "UPDATE siparisler SET durum = @durum WHERE siparis_id = @siparisId";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@durum", yeniDurum);
                        komut.Parameters.AddWithValue("@siparisId", siparisId);
                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Sipariş durumu güncellendi.");
                            SiparisleriListele();
                        }
                        else
                        {
                            MessageBox.Show("Sipariş durumu güncellenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş durumu güncellenirken bir hata oluştu: " + ex.Message);
            }
        }







    }
}
