using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;

namespace ToptanciYonetimPaneli
{
    public partial class RaporlarForm : Form
    {
        public RaporlarForm()
        {
            InitializeComponent();
        }

        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            // Satış Raporları sekmesi için filtreleri ayarla
            cmbSatisRaporTuru.Items.AddRange(new string[] {
                "Günlük Satış Raporu",
                "Aylık Satış Raporu",
                "Yıllık Satış Raporu",
                "Ürün Bazlı Satış Raporu"
            });

            // Ürün Raporları sekmesi için filtreleri ayarla
            cmbUrunRaporTuru.Items.AddRange(new string[] {
                "En Çok Satan Ürünler",
                "Stok Durumu Raporu",
                "Ürün Kategori Raporu"
            });
            KategorileriYukle();

            // Müşteri Raporları sekmesi için filtreleri ayarla
            cmbMusteriRaporTuru.Items.AddRange(new string[] {
                "En Çok Alışveriş Yapan Müşteriler",
                "Müşteri Segmentasyonu Raporu",
                "Yeni Müşteri Kazanım Raporu"
            });

            // Finansal Raporlar sekmesi için filtreleri ayarla
            cmbFinansalRaporTuru.Items.AddRange(new string[] {
                "Gelir Tablosu",
                "Kar Marjı Raporu",
                "Ödeme Yöntemi Analizi"
            });
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

        private void btnFinansalRaporOlustur_Click(object sender, EventArgs e)
        {
            FinansalRaporOlustur();
        }

        private void FinansalRaporOlustur()
        {
            try
            {
                DataTable dt = new DataTable();
                string sorgu = @"
            SELECT 
                DATE_FORMAT(s.siparis_tarihi, '%Y-%m') AS Ay,
                COUNT(*) AS SiparisSayisi,
                SUM(s.toplam_tutar) AS ToplamGelir,
                SUM(sd.miktar * u.maliyet) AS ToplamMaliyet,
                SUM(s.toplam_tutar) - SUM(sd.miktar * u.maliyet) AS Kar,
                ((SUM(s.toplam_tutar) - SUM(sd.miktar * u.maliyet)) / SUM(s.toplam_tutar)) * 100 AS KarMarjiYuzde
            FROM 
                siparisler s
                JOIN siparis_detaylari sd ON s.siparis_id = sd.siparis_id
                JOIN urunler u ON sd.urun_id = u.urun_id
            GROUP BY 
                DATE_FORMAT(s.siparis_tarihi, '%Y-%m')
            ORDER BY 
                Ay DESC
            LIMIT 24"; // Son 24 ayın finansal raporunu göster

                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.Fill(dt);
                    }
                }

                dgvFinansalRaporSonuclari.DataSource = dt;
                dgvFinansalRaporSonuclari.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Para birimi formatını ayarla
                dgvFinansalRaporSonuclari.Columns["ToplamGelir"].DefaultCellStyle.Format = "C2";
                dgvFinansalRaporSonuclari.Columns["ToplamMaliyet"].DefaultCellStyle.Format = "C2";
                dgvFinansalRaporSonuclari.Columns["Kar"].DefaultCellStyle.Format = "C2";
                dgvFinansalRaporSonuclari.Columns["KarMarjiYuzde"].DefaultCellStyle.Format = "F2";

                MessageBox.Show("Finansal rapor başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SatisRaporuOlustur()
        {
            try
            {
                DataTable dt = new DataTable();
                string sorgu = @"
            SELECT 
                DATE(s.siparis_tarihi) AS Tarih,
                COUNT(*) AS SiparisSayisi,
                SUM(s.toplam_tutar) AS ToplamSatis,
                AVG(s.toplam_tutar) AS OrtalamaSiparisTutari,
                COUNT(DISTINCT s.uye_id) AS BenzersizMusteriSayisi,
                (
                    SELECT urun_adi 
                    FROM urunler u 
                    JOIN siparis_detaylari sd ON u.urun_id = sd.urun_id 
                    WHERE sd.siparis_id IN (SELECT siparis_id FROM siparisler WHERE DATE(siparis_tarihi) = DATE(s.siparis_tarihi))
                    GROUP BY u.urun_id 
                    ORDER BY SUM(sd.miktar) DESC 
                    LIMIT 1
                ) AS EnCokSatanUrun
            FROM 
                siparisler s
            WHERE 
                s.siparis_tarihi >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)
            GROUP BY 
                DATE(s.siparis_tarihi)
            ORDER BY 
                Tarih DESC";

                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.Fill(dt);
                    }
                }

                dgvSatisRaporSonuclari.DataSource = dt;
                dgvSatisRaporSonuclari.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Para birimi formatını ayarla
                dgvSatisRaporSonuclari.Columns["ToplamSatis"].DefaultCellStyle.Format = "C2";
                dgvSatisRaporSonuclari.Columns["OrtalamaSiparisTutari"].DefaultCellStyle.Format = "C2";

                MessageBox.Show("Satış raporu başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void UrunRaporuOlustur()
        {
            string raporTuru = cmbUrunRaporTuru.SelectedItem?.ToString();
            int? kategoriId = cmbKategori.SelectedValue as int?;

            if (string.IsNullOrEmpty(raporTuru))
            {
                MessageBox.Show("Lütfen bir rapor türü seçin.");
                return;
            }

            try
            {
                DataTable dt = new DataTable();
                string sorgu = "";

                switch (raporTuru)
                {
                    case "En Çok Satan Ürünler":
                        sorgu = @"
                    SELECT 
                        u.urun_adi,
                        SUM(sd.miktar) AS SatilanMiktar,
                        SUM(sd.miktar * sd.birim_fiyat) AS ToplamSatis
                    FROM 
                        siparis_detaylari sd
                        JOIN urunler u ON sd.urun_id = u.urun_id
                        JOIN siparisler s ON sd.siparis_id = s.siparis_id
                    WHERE 
                        (@kategoriId IS NULL OR u.kategori_id = @kategoriId)
                    GROUP BY 
                        u.urun_id
                    ORDER BY 
                        SatilanMiktar DESC
                    LIMIT 10";
                        break;

                    case "Stok Durumu Raporu":
                        sorgu = @"
                    SELECT 
                        u.urun_adi,
                        u.stok_miktari,
                        k.kategori_adi
                    FROM 
                        urunler u
                        JOIN kategoriler k ON u.kategori_id = k.kategori_id
                    WHERE 
                        (@kategoriId IS NULL OR u.kategori_id = @kategoriId)
                    ORDER BY 
                        u.stok_miktari ASC";
                        break;

                    case "Ürün Kategori Raporu":
                        sorgu = @"
                    SELECT 
                        k.kategori_adi,
                        COUNT(u.urun_id) AS UrunSayisi,
                        SUM(u.stok_miktari) AS ToplamStok,
                        AVG(u.birim_fiyat) AS OrtalamaBirimFiyat
                    FROM 
                        kategoriler k
                        LEFT JOIN urunler u ON k.kategori_id = u.kategori_id
                    WHERE 
                        (@kategoriId IS NULL OR k.kategori_id = @kategoriId)
                    GROUP BY 
                        k.kategori_id
                    ORDER BY 
                        UrunSayisi DESC";
                        break;

                    default:
                        MessageBox.Show("Geçersiz rapor türü.");
                        return;
                }

                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@kategoriId", kategoriId.HasValue ? (object)kategoriId.Value : DBNull.Value);
                        adapter.Fill(dt);
                    }
                }

                dgvUrunRaporSonuclari.DataSource = dt;
                dgvUrunRaporSonuclari.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor oluşturulurken bir hata oluştu: " + ex.Message);
            }
        }

        private void MusteriRaporuOlustur()
        {
            try
            {
                DataTable dt = new DataTable();
                string sorgu = @"
            SELECT 
                u.ad, u.soyad, u.email,
                COUNT(s.siparis_id) AS SiparisSayisi,
                SUM(s.toplam_tutar) AS ToplamHarcama,
                AVG(s.toplam_tutar) AS OrtalamaSiparisTutari
            FROM 
                uyeler u
                LEFT JOIN siparisler s ON u.uye_id = s.uye_id
            GROUP BY 
                u.uye_id
            ORDER BY 
                ToplamHarcama DESC
            LIMIT 100";

                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.Fill(dt);
                    }
                }

                dgvMusteriRaporSonuclari.DataSource = dt;
                dgvMusteriRaporSonuclari.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                MessageBox.Show("Müşteri raporu başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnFinansalRaporOlustur_Click_1(object sender, EventArgs e)
        {
            FinansalRaporOlustur();
        }

        private void btnSatisRaporOlustur_Click(object sender, EventArgs e)
        {
            SatisRaporuOlustur();
        }

        private void btnUrunRaporOlustur_Click(object sender, EventArgs e)
        {
            UrunRaporuOlustur();
        }

        private void btnMusteriRaporOlustur_Click(object sender, EventArgs e)
        {
            MusteriRaporuOlustur();
           
        }


        private void btnFinansalExcelOlustur_Click(object sender, EventArgs e) 
        {
            try
            {
                if (dgvFinansalRaporSonuclari.Rows.Count == 0)
                {
                    MessageBox.Show("Aktarılacak veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Dosyası (*.xlsx)|*.xlsx",
                    FileName = "FinansalRapor_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Finansal Rapor");

                        // Başlıkları ekle
                        for (int i = 0; i < dgvFinansalRaporSonuclari.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvFinansalRaporSonuclari.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        }

                        // Verileri ekle
                        for (int i = 0; i < dgvFinansalRaporSonuclari.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvFinansalRaporSonuclari.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvFinansalRaporSonuclari.Rows[i].Cells[j].Value?.ToString() ?? "";
                            }
                        }

                        // Otomatik genişlik ayarı
                        worksheet.Columns().AdjustToContents();

                        // Tablo oluştur
                        var range = worksheet.Range(1, 1, dgvFinansalRaporSonuclari.Rows.Count + 1, dgvFinansalRaporSonuclari.Columns.Count);
                        var table = range.CreateTable();
                        table.Theme = XLTableTheme.TableStyleMedium2;

                        // Para birimi formatını ayarla
                        worksheet.Column(3).Style.NumberFormat.Format = "₺#,##0.00"; // ToplamGelir
                        worksheet.Column(4).Style.NumberFormat.Format = "₺#,##0.00"; // ToplamMaliyet
                        worksheet.Column(5).Style.NumberFormat.Format = "₺#,##0.00"; // Kar
                        worksheet.Column(6).Style.NumberFormat.Format = "0.00%"; // KarMarjiYuzde

                        // Excel dosyasını kaydet
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Finansal rapor başarıyla Excel dosyasına aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel'e aktarma sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }





        private void btnSatisExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSatisRaporSonuclari.Rows.Count == 0)
                {
                    MessageBox.Show("Aktarılacak veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Dosyası (*.xlsx)|*.xlsx",
                    FileName = "SatisRaporu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Satış Raporu");

                        // Başlıkları ekle
                        for (int i = 0; i < dgvSatisRaporSonuclari.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvSatisRaporSonuclari.Columns[i].HeaderText;
                        }

                        // Verileri ekle
                        for (int i = 0; i < dgvSatisRaporSonuclari.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvSatisRaporSonuclari.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvSatisRaporSonuclari.Rows[i].Cells[j].Value?.ToString() ?? "";
                            }
                        }

                        // Otomatik genişlik ayarı
                        worksheet.Columns().AdjustToContents();

                        // Excel dosyasını kaydet
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Satış raporu başarıyla Excel dosyasına aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel'e aktarma sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUrunExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUrunRaporSonuclari.Rows.Count == 0)
                {
                    MessageBox.Show("Aktarılacak veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Dosyası (*.xlsx)|*.xlsx",
                    FileName = "UrunRaporu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Ürün Raporu");

                        // Başlıkları ekle
                        for (int i = 0; i < dgvUrunRaporSonuclari.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvUrunRaporSonuclari.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        }

                        // Verileri ekle
                        for (int i = 0; i < dgvUrunRaporSonuclari.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvUrunRaporSonuclari.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvUrunRaporSonuclari.Rows[i].Cells[j].Value?.ToString() ?? "";
                            }
                        }

                        // Otomatik genişlik ayarı
                        worksheet.Columns().AdjustToContents();

                        // Tablo oluştur
                        var range = worksheet.Range(1, 1, dgvUrunRaporSonuclari.Rows.Count + 1, dgvUrunRaporSonuclari.Columns.Count);
                        var table = range.CreateTable();
                        table.Theme = XLTableTheme.TableStyleMedium2;

                        // Excel dosyasını kaydet
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Ürün raporu başarıyla Excel dosyasına aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel'e aktarma sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMusteriRaporSonuclari.Rows.Count == 0)
                {
                    MessageBox.Show("Aktarılacak veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Dosyası (*.xlsx)|*.xlsx",
                    FileName = "MusteriRaporu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Müşteri Raporu");

                        // Başlıkları ekle
                        for (int i = 0; i < dgvMusteriRaporSonuclari.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvMusteriRaporSonuclari.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        }

                        // Verileri ekle
                        for (int i = 0; i < dgvMusteriRaporSonuclari.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvMusteriRaporSonuclari.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvMusteriRaporSonuclari.Rows[i].Cells[j].Value?.ToString() ?? "";
                            }
                        }

                        // Otomatik genişlik ayarı
                        worksheet.Columns().AdjustToContents();

                        // Tablo oluştur
                        var range = worksheet.Range(1, 1, dgvMusteriRaporSonuclari.Rows.Count + 1, dgvMusteriRaporSonuclari.Columns.Count);
                        var table = range.CreateTable();
                        table.Theme = XLTableTheme.TableStyleMedium2;

                        // Para birimi formatını ayarla
                        var toplamHarcamaSutunu = worksheet.Column(5); // ToplamHarcama sütunu (indeks değişebilir)
                        toplamHarcamaSutunu.Style.NumberFormat.Format = "₺#,##0.00";

                        var ortalamaSiparisTutariSutunu = worksheet.Column(6); // OrtalamaSiparisTutari sütunu (indeks değişebilir)
                        ortalamaSiparisTutariSutunu.Style.NumberFormat.Format = "₺#,##0.00";

                        // Excel dosyasını kaydet
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Müşteri raporu başarıyla Excel dosyasına aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel'e aktarma sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
