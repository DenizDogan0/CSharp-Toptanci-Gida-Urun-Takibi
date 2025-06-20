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

namespace ToptanciYonetimPaneli
{
    public partial class UyeYonetimiForm : Form
    {
        public UyeYonetimiForm()
        {
            InitializeComponent();
        }

        private void UyeYonetimiForm_Load(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void UyeleriListele()
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "SELECT uye_id, kullanici_adi, ad, soyad, email, telefon, onay_durumu FROM uyeler";
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvUyeler.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üyeler listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnUyeOnayla_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count > 0)
            {
                int uyeId = Convert.ToInt32(dgvUyeler.SelectedRows[0].Cells["uye_id"].Value);
                UyeDurumuGuncelle(uyeId, true);
            }
        }

        private void btnUyeReddet_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count > 0)
            {
                int uyeId = Convert.ToInt32(dgvUyeler.SelectedRows[0].Cells["uye_id"].Value);
                UyeDurumuGuncelle(uyeId, false);
            }

        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count > 0)
            {
                int uyeId = Convert.ToInt32(dgvUyeler.SelectedRows[0].Cells["uye_id"].Value);
                DialogResult result = MessageBox.Show("Seçili üyeyi silmek istediğinizden emin misiniz?", "Üye Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UyeSil(uyeId);
                }
            }
        }

        private void UyeDurumuGuncelle(int uyeId, bool onayDurumu)
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "UPDATE uyeler SET onay_durumu = @onayDurumu WHERE uye_id = @uyeId";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@onayDurumu", onayDurumu);
                        komut.Parameters.AddWithValue("@uyeId", uyeId);
                        komut.ExecuteNonQuery();
                    }
                }
                UyeleriListele(); // Listeyi güncelle
                MessageBox.Show(onayDurumu ? "Üye onaylandı." : "Üye reddedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye durumu güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void UyeSil(int uyeId)
        {
            try
            {
                using (var baglanti = VeriTabaniBaglantisi.BaglantiyiAl())
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM uyeler WHERE uye_id = @uyeId";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@uyeId", uyeId);
                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Üye başarıyla silindi.");
                            UyeleriListele(); // Listeyi güncelle
                        }
                        else
                        {
                            MessageBox.Show("Üye silinirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye silinirken bir hata oluştu: " + ex.Message);
            }
        }











    }
}
