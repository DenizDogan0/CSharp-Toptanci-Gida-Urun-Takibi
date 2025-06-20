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
    public partial class SiparislerimForm : Form
    {

        private int uyeId;

        public SiparislerimForm(int uyeId)
        {
            InitializeComponent();
            this.uyeId = uyeId;
        }

        private void SiparislerimForm_Load(object sender, EventArgs e)
        {
            SiparisleriListele();
        }

        private void SiparisleriListele()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"SELECT s.siparis_id, s.siparis_tarihi, s.toplam_tutar, s.durum 
                                     FROM siparisler s 
                                     WHERE s.uye_id = @uyeId 
                                     ORDER BY s.siparis_tarihi DESC";

                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@uyeId", uyeId);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSiparisler.DataSource = dt;
                    }
                }

                // Sütun başlıklarını düzenle
                dgvSiparisler.Columns["siparis_id"].HeaderText = "Sipariş No";
                dgvSiparisler.Columns["siparis_tarihi"].HeaderText = "Sipariş Tarihi";
                dgvSiparisler.Columns["toplam_tutar"].HeaderText = "Toplam Tutar";
                dgvSiparisler.Columns["durum"].HeaderText = "Durum";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Siparişler listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnSipraisDetay_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count > 0)
            {
                int siparisId = Convert.ToInt32(dgvSiparisler.SelectedRows[0].Cells["siparis_id"].Value);
                SiparisDetayForm detayForm = new SiparisDetayForm(siparisId);
                detayForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen detayını görmek istediğiniz siparişi seçin.");
            }
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count > 0)
            {
                int siparisId = Convert.ToInt32(dgvSiparisler.SelectedRows[0].Cells["siparis_id"].Value);
                string siparisDurumu = dgvSiparisler.SelectedRows[0].Cells["durum"].Value.ToString();

                if (siparisDurumu.ToLower() == "beklemede" || siparisDurumu.ToLower() == "onay bekliyor")
                {
                    DialogResult result = MessageBox.Show("Seçili siparişi iptal etmek istediğinizden emin misiniz?", "Sipariş İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SiparisiIptalEt(siparisId);
                    }
                }
                else
                {
                    MessageBox.Show("Bu sipariş iptal edilemez. Sadece 'Beklemede' veya 'Onay Bekliyor' durumundaki siparişler iptal edilebilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen iptal etmek istediğiniz siparişi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SiparisiIptalEt(int siparisId)
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
                            // Siparişin durumunu güncelle
                            string siparisGuncelleSorgu = "UPDATE siparisler SET durum = 'İptal Edildi' WHERE siparis_id = @siparisId";
                            using (var komut = new MySqlCommand(siparisGuncelleSorgu, baglanti, transaction))
                            {
                                komut.Parameters.AddWithValue("@siparisId", siparisId);
                                komut.ExecuteNonQuery();
                            }

                            // Stok miktarlarını geri al
                            string stokGuncelleSorgu = @"UPDATE urunler u
                                                 JOIN siparis_detaylari sd ON u.urun_id = sd.urun_id
                                                 SET u.stok_miktari = u.stok_miktari + sd.miktar
                                                 WHERE sd.siparis_id = @siparisId";
                            using (var komut = new MySqlCommand(stokGuncelleSorgu, baglanti, transaction))
                            {
                                komut.Parameters.AddWithValue("@siparisId", siparisId);
                                komut.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Sipariş başarıyla iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SiparisleriListele(); // Sipariş listesini güncelle
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Sipariş iptal edilirken bir hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş iptal edilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       

        private void btnGeriDon_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
