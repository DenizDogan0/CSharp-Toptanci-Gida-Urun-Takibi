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
    public partial class StokDurumuForm : Form
    {
        public StokDurumuForm()
        {
            InitializeComponent();
        }

        private void StokDurumuForm_Load(object sender, EventArgs e)
        {
            StokDurumuListele();
        }

        private void StokDurumuListele()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "SELECT urun_id, urun_adi, stok_miktari, birim_fiyat FROM urunler";
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvStokDurumu.DataSource = dt;
                    }
                }

                // Sütun başlıklarını düzenle
                dgvStokDurumu.Columns["urun_id"].HeaderText = "Ürün ID";
                dgvStokDurumu.Columns["urun_adi"].HeaderText = "Ürün Adı";
                dgvStokDurumu.Columns["stok_miktari"].HeaderText = "Stok Miktarı";
                dgvStokDurumu.Columns["birim_fiyat"].HeaderText = "Birim Fiyat";

                // Para birimi formatını ayarla
                dgvStokDurumu.Columns["birim_fiyat"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok durumu listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvStokDurumu.SelectedRows.Count > 0)
            {
                int urunId = Convert.ToInt32(dgvStokDurumu.SelectedRows[0].Cells["urun_id"].Value);
                string urunAdi = dgvStokDurumu.SelectedRows[0].Cells["urun_adi"].Value.ToString();
                int mevcutStok = Convert.ToInt32(dgvStokDurumu.SelectedRows[0].Cells["stok_miktari"].Value);

                string yeniStokStr = Microsoft.VisualBasic.Interaction.InputBox($"{urunAdi} için yeni stok miktarını girin:", "Stok Güncelle", mevcutStok.ToString());

                if (int.TryParse(yeniStokStr, out int yeniStok))
                {
                    StokGuncelle(urunId, yeniStok);
                }
                else
                {
                    MessageBox.Show("Geçerli bir sayı girmelisiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz ürünü seçin.");
            }
        }

        private void StokGuncelle(int urunId, int yeniStok)
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "UPDATE urunler SET stok_miktari = @yeniStok WHERE urun_id = @urunId";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yeniStok", yeniStok);
                        komut.Parameters.AddWithValue("@urunId", urunId);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Stok miktarı başarıyla güncellendi.");
                            StokDurumuListele(); // Listeyi güncelle
                        }
                        else
                        {
                            MessageBox.Show("Stok miktarı güncellenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
