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
    public partial class UrunYonetimiForm : Form
    {
        public UrunYonetimiForm()
        {
            InitializeComponent();
        }

        private void grpUrunEkle_Enter(object sender, EventArgs e)
        {

        }

        private void UrunYonetimiFormcs_Load(object sender, EventArgs e)
        {
            UrunleriListele();
            KategorileriYukle();
        }

        private void UrunleriListele()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"SELECT u.urun_id, u.urun_adi, k.kategori_adi, u.birim_fiyat, u.stok_miktari 
                                     FROM urunler u
                                     JOIN kategoriler k ON u.kategori_id = k.kategori_id";
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

        private void KategorileriYukle()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "SELECT kategori_id, kategori_adi FROM kategoriler";
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbKategori.DataSource = dt;
                        cmbKategori.DisplayMember = "kategori_adi";
                        cmbKategori.ValueMember = "kategori_id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || string.IsNullOrWhiteSpace(txtBirimFiyat.Text) || string.IsNullOrWhiteSpace(txtStokMiktari.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"INSERT INTO urunler (urun_adi, kategori_id, birim_fiyat, stok_miktari) 
                                     VALUES (@urunAdi, @kategoriId, @birimFiyat, @stokMiktari)";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                        komut.Parameters.AddWithValue("@kategoriId", cmbKategori.SelectedValue);
                        komut.Parameters.AddWithValue("@birimFiyat", Convert.ToDecimal(txtBirimFiyat.Text));
                        komut.Parameters.AddWithValue("@stokMiktari", Convert.ToInt32(txtStokMiktari.Text));
                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ürün başarıyla eklendi.");
                UrunleriListele();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek ürünü seçin.");
                return;
            }

            int urunId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urun_id"].Value);

            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = @"UPDATE urunler 
                             SET urun_adi = @urunAdi, 
                                 kategori_id = @kategoriId, 
                                 birim_fiyat = @birimFiyat, 
                                 stok_miktari = @stokMiktari 
                             WHERE urun_id = @urunId";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                        komut.Parameters.AddWithValue("@kategoriId", cmbKategori.SelectedValue);
                        komut.Parameters.AddWithValue("@birimFiyat", Convert.ToDecimal(txtBirimFiyat.Text));
                        komut.Parameters.AddWithValue("@stokMiktari", Convert.ToInt32(txtStokMiktari.Text));
                        komut.Parameters.AddWithValue("@urunId", urunId);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Ürün başarıyla güncellendi.");
                            UrunleriListele();
                            FormuTemizle();
                        }
                        else
                        {
                            MessageBox.Show("Ürün güncellenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçin.");
                return;
            }

            int urunId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urun_id"].Value);

            DialogResult result = MessageBox.Show("Seçili ürünü silmek istediğinizden emin misiniz?", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                    {
                        baglanti.Open();
                        string sorgu = "DELETE FROM urunler WHERE urun_id = @urunId";
                        using (var komut = new MySqlCommand(sorgu, baglanti))
                        {
                            komut.Parameters.AddWithValue("@urunId", urunId);
                            int etkilenenSatir = komut.ExecuteNonQuery();
                            if (etkilenenSatir > 0)
                            {
                                MessageBox.Show("Ürün başarıyla silindi.");
                                UrunleriListele();
                                FormuTemizle();
                            }
                            else
                            {
                                MessageBox.Show("Ürün silinirken bir hata oluştu.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün silinirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void FormuTemizle()
        {
            txtUrunAdi.Clear();
            txtBirimFiyat.Clear();
            txtStokMiktari.Clear();
            cmbKategori.SelectedIndex = -1;
        }

        private void dgvUrunler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUrunler.SelectedRows[0];
                txtUrunAdi.Text = selectedRow.Cells["urun_adi"].Value.ToString();
                txtBirimFiyat.Text = selectedRow.Cells["birim_fiyat"].Value.ToString();
                txtStokMiktari.Text = selectedRow.Cells["stok_miktari"].Value.ToString();
                cmbKategori.Text = selectedRow.Cells["kategori_adi"].Value.ToString();
            }
        }
    }
}
