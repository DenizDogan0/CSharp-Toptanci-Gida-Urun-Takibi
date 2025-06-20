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
    public partial class SiparisVerForm : Form
    {

        private int uyeId;
        private DataTable sepet = new DataTable();

        public SiparisVerForm(int uyeId)
        {
            InitializeComponent();
            this.uyeId = uyeId;
            sepet.Columns.Add("UrunId", typeof(int));
            sepet.Columns.Add("UrunAdi", typeof(string));
            sepet.Columns.Add("Miktar", typeof(int));
            sepet.Columns.Add("BirimFiyat", typeof(decimal));
            sepet.Columns.Add("ToplamFiyat", typeof(decimal), "Miktar * BirimFiyat");
        }

        private void SiparişVerForm_Load(object sender, EventArgs e)
        {
            UrunleriListele();
            GuncelleSepetListesi();
        }

        private void UrunleriListele()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "SELECT urun_id, urun_adi, birim_fiyat, stok_miktari FROM urunler WHERE stok_miktari > 0";
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvUrunler.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0 && int.TryParse(txtMiktar.Text, out int miktar) && miktar > 0)
            {
                DataGridViewRow selectedRow = dgvUrunler.SelectedRows[0];
                int urunId = Convert.ToInt32(selectedRow.Cells["urun_id"].Value);
                string urunAdi = selectedRow.Cells["urun_adi"].Value.ToString();
                decimal birimFiyat = Convert.ToDecimal(selectedRow.Cells["birim_fiyat"].Value);
                int stokMiktari = Convert.ToInt32(selectedRow.Cells["stok_miktari"].Value);

                if (miktar > stokMiktari)
                {
                    MessageBox.Show($"Stokta yeterli ürün yok. Mevcut stok: {stokMiktari}");
                    return;
                }

                DataRow[] existingRows = sepet.Select($"UrunId = {urunId}");
                if (existingRows.Length > 0)
                {
                    int yeniMiktar = Convert.ToInt32(existingRows[0]["Miktar"]) + miktar;
                    if (yeniMiktar > stokMiktari)
                    {
                        MessageBox.Show($"Stokta yeterli ürün yok. Mevcut stok: {stokMiktari}");
                        return;
                    }
                    existingRows[0]["Miktar"] = yeniMiktar;
                }
                else
                {
                    sepet.Rows.Add(urunId, urunAdi, miktar, birimFiyat);
                }

                GuncelleSepetListesi();
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin ve geçerli bir miktar girin.");
            }
        }
        private void GuncelleSepetListesi()
        {
            lstSepet.Items.Clear();
            decimal toplamTutar = 0;
            foreach (DataRow row in sepet.Rows)
            {
                lstSepet.Items.Add($"{row["UrunAdi"]} - Miktar: {row["Miktar"]} - Birim Fiyat: {row["BirimFiyat"]:C} - Toplam: {row["ToplamFiyat"]:C}");
                toplamTutar += Convert.ToDecimal(row["ToplamFiyat"]);
            }
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C}";
        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            if (sepet.Rows.Count > 0)
            {
                try
                {
                    using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                    {
                        baglanti.Open();
                        using (var transaction = baglanti.BeginTransaction())
                        {
                            try
                            {
                                string siparisEkleSorgu = "INSERT INTO siparisler (uye_id, siparis_tarihi, toplam_tutar) VALUES (@uyeId, @siparisTarihi, @toplamTutar); SELECT LAST_INSERT_ID();";
                                int siparisId;
                                decimal toplamTutar = 0;

                                foreach (DataRow row in sepet.Rows)
                                {
                                    toplamTutar += Convert.ToDecimal(row["ToplamFiyat"]);
                                }

                                using (var komut = new MySqlCommand(siparisEkleSorgu, baglanti, transaction))
                                {
                                    komut.Parameters.AddWithValue("@uyeId", uyeId);
                                    komut.Parameters.AddWithValue("@siparisTarihi", DateTime.Now);
                                    komut.Parameters.AddWithValue("@toplamTutar", toplamTutar);
                                    siparisId = Convert.ToInt32(komut.ExecuteScalar());
                                }

                                string detayEkleSorgu = "INSERT INTO siparis_detaylari (siparis_id, urun_id, miktar, birim_fiyat) VALUES (@siparisId, @urunId, @miktar, @birimFiyat)";
                                string stokGuncelleSorgu = "UPDATE urunler SET stok_miktari = stok_miktari - @miktar WHERE urun_id = @urunId";

                                foreach (DataRow row in sepet.Rows)
                                {
                                    int urunId = Convert.ToInt32(row["UrunId"]);
                                    int miktar = Convert.ToInt32(row["Miktar"]);
                                    decimal birimFiyat = Convert.ToDecimal(row["BirimFiyat"]);

                                    // Sipariş detayı ekle
                                    using (var komut = new MySqlCommand(detayEkleSorgu, baglanti, transaction))
                                    {
                                        komut.Parameters.AddWithValue("@siparisId", siparisId);
                                        komut.Parameters.AddWithValue("@urunId", urunId);
                                        komut.Parameters.AddWithValue("@miktar", miktar);
                                        komut.Parameters.AddWithValue("@birimFiyat", birimFiyat);
                                        komut.ExecuteNonQuery();
                                    }

                                    // Stok miktarını güncelle
                                    using (var komut = new MySqlCommand(stokGuncelleSorgu, baglanti, transaction))
                                    {
                                        komut.Parameters.AddWithValue("@miktar", miktar);
                                        komut.Parameters.AddWithValue("@urunId", urunId);
                                        komut.ExecuteNonQuery();
                                    }
                                }

                                transaction.Commit();
                                MessageBox.Show("Sipariş başarıyla oluşturuldu.");

                                // Sipariş özeti göster
                                SiparisOzetiGoster(siparisId, toplamTutar);

                                sepet.Clear();
                                GuncelleSepetListesi();
                                UrunleriListele();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw new Exception("Sipariş oluşturulurken bir hata oluştu: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sipariş oluşturulurken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sepetiniz boş. Lütfen önce ürün ekleyin.");
            }

        }

        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedIndex != -1)
            {
                sepet.Rows.RemoveAt(lstSepet.SelectedIndex);
                GuncelleSepetListesi();
            }
            else
            {
                MessageBox.Show("Lütfen sepetten çıkarmak istediğiniz ürünü seçin.");
            }
        }

        private void SiparisOzetiGoster(int siparisId, decimal toplamTutar)
        {
            string ozet = $"Sipariş Özeti\n\n";
            ozet += $"Sipariş No: {siparisId}\n";
            ozet += $"Tarih: {DateTime.Now}\n";
            ozet += $"Toplam Tutar: {toplamTutar:C}\n\n";
            ozet += "Ürünler:\n";
            ozet += "--------------------\n";

            foreach (DataRow row in sepet.Rows)
            {
                string urunAdi = row["UrunAdi"].ToString();
                int miktar = Convert.ToInt32(row["Miktar"]);
                decimal birimFiyat = Convert.ToDecimal(row["BirimFiyat"]);
                decimal toplamFiyat = Convert.ToDecimal(row["ToplamFiyat"]);

                ozet += $"{urunAdi}\n";
                ozet += $"  Miktar: {miktar}\n";
                ozet += $"  Birim Fiyat: {birimFiyat:C}\n";
                ozet += $"  Toplam: {toplamFiyat:C}\n";
                ozet += "--------------------\n";
            }

            MessageBox.Show(ozet, "Sipariş Özeti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
