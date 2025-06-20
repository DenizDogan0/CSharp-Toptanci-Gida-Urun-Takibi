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
using Microsoft.VisualBasic;

namespace Toptancı
{
    public partial class FiyatListesiForm : Form
    {
        public FiyatListesiForm()
        {
            InitializeComponent();
        }

        private void FiyatListesiForm_Load(object sender, EventArgs e)
        {
            FiyatListesiniListele();
        }

        private void FiyatListesiniListele()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "SELECT urun_id, urun_adi, birim_fiyat FROM urunler";
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFiyatListesi.DataSource = dt;
                    }
                }

                // Sütun başlıklarını düzenle
                dgvFiyatListesi.Columns["urun_id"].HeaderText = "Ürün ID";
                dgvFiyatListesi.Columns["urun_adi"].HeaderText = "Ürün Adı";
                dgvFiyatListesi.Columns["birim_fiyat"].HeaderText = "Birim Fiyat";

                // Para birimi formatını ayarla
                dgvFiyatListesi.Columns["birim_fiyat"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyat listesi listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvFiyatListesi.SelectedRows.Count > 0)
            {
                int urunId = Convert.ToInt32(dgvFiyatListesi.SelectedRows[0].Cells["urun_id"].Value);
                string urunAdi = dgvFiyatListesi.SelectedRows[0].Cells["urun_adi"].Value.ToString();
                decimal mevcutFiyat = Convert.ToDecimal(dgvFiyatListesi.SelectedRows[0].Cells["birim_fiyat"].Value);

                string yeniFiyatStr = Microsoft.VisualBasic.Interaction.InputBox($"{urunAdi} için yeni fiyatı girin:", "Fiyat Güncelle", mevcutFiyat.ToString("F2"));

                if (decimal.TryParse(yeniFiyatStr, out decimal yeniFiyat))
                {
                    FiyatGuncelle(urunId, yeniFiyat);
                }
                else
                {
                    MessageBox.Show("Geçerli bir fiyat girmelisiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz ürünü seçin.");
            }
        }

        private void FiyatGuncelle(int urunId, decimal yeniFiyat)
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "UPDATE urunler SET birim_fiyat = @yeniFiyat WHERE urun_id = @urunId";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yeniFiyat", yeniFiyat);
                        komut.Parameters.AddWithValue("@urunId", urunId);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Fiyat başarıyla güncellendi.");
                            FiyatListesiniListele(); // Listeyi güncelle
                        }
                        else
                        {
                            MessageBox.Show("Fiyat güncellenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyat güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnTopluGuncelle_Click(object sender, EventArgs e)
        {
            string yuzdeStr = Microsoft.VisualBasic.Interaction.InputBox("Fiyatları güncellemek için yüzde değerini girin (örn: 10 için artış, -10 için azalış)", "Toplu Fiyat Güncelleme", "0");

            if (decimal.TryParse(yuzdeStr, out decimal yuzde))
            {
                DialogResult result = MessageBox.Show($"Tüm ürünlerin fiyatlarını %{yuzde} oranında güncellemek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                        {
                            baglanti.Open();
                            string sorgu = "UPDATE urunler SET birim_fiyat = birim_fiyat * (1 + @yuzde / 100)";
                            using (var komut = new MySqlCommand(sorgu, baglanti))
                            {
                                komut.Parameters.AddWithValue("@yuzde", yuzde);
                                int etkilenenSatir = komut.ExecuteNonQuery();
                                if (etkilenenSatir > 0)
                                {
                                    MessageBox.Show($"{etkilenenSatir} ürünün fiyatı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FiyatListesiniListele(); // Listeyi güncelle
                                }
                                else
                                {
                                    MessageBox.Show("Fiyatlar güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fiyatlar güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir yüzde değeri girmelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
