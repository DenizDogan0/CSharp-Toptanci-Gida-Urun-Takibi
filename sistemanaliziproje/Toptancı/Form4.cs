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
    public partial class UyeIslemlerForm : Form
    {
        private int uyeId;
        private string uyeAdi;

        public UyeIslemlerForm(int uyeId)
        {
            InitializeComponent();
            this.uyeId = uyeId;
        }

        private void UyeIslemleriForm_Load(object sender, EventArgs e)
        {
            uyeAdi = GetUyeAdi();
            lblHosgeldin.Text = $"Hoş geldiniz, {uyeAdi}!";
        }

        private string GetUyeAdi()
        {
            string ad = "";
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "SELECT ad, soyad FROM uyeler WHERE uye_id = @uyeId";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@uyeId", uyeId);
                        using (var okuyucu = komut.ExecuteReader())
                        {
                            if (okuyucu.Read())
                            {
                                ad = $"{okuyucu["ad"]} {okuyucu["soyad"]}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye bilgileri alınırken bir hata oluştu: " + ex.Message);
            }
            return ad;
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            SiparisVerForm siparisVerForm = new SiparisVerForm(uyeId);
            siparisVerForm.ShowDialog();
        }

        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            SiparislerimForm siparislerimForm = new SiparislerimForm(uyeId);
            siparislerimForm.ShowDialog();
        }

        private void btnProfilDuzenle_Click(object sender, EventArgs e)
        {
            ProfilDuzenleForm profilDuzenleForm = new ProfilDuzenleForm(uyeId);
            profilDuzenleForm.ShowDialog();
        }

        private void btnStokDurumu_Click(object sender, EventArgs e)
        {
            StokDurumuForm stokDurumuForm = new StokDurumuForm();
            stokDurumuForm.ShowDialog();
        }

        private void btnFiyatListesi_Click(object sender, EventArgs e)
        {
            FiyatListesiForm fiyatListesiForm = new FiyatListesiForm();
            fiyatListesiForm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
