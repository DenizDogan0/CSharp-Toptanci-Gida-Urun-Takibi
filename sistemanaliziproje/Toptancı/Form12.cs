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
    public partial class YonetimGirisForm : Form
    {
        public YonetimGirisForm()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=projedbb;Uid=root;Pwd=;");

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sorgu = "SELECT * FROM yoneticiler WHERE kullanici_adi=@kullaniciAdi AND sifre=@sifre";
                MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@kullaniciAdi", txtYoneticiKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@sifre", txtYoneticiSifre.Text);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı!");
                    this.Hide();
                    // ToptanciYonetimPaneli projesindeki Form1'i açın
                    ToptanciYonetimPaneli.Form1 yonetimPaneli = new ToptanciYonetimPaneli.Form1();
                    yonetimPaneli.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtYoneticiSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtYoneticiKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
