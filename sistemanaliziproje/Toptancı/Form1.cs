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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUyeGiris_Click(object sender, EventArgs e)
        {
            UyeGirisForm uyeGirisForm = new UyeGirisForm();
            uyeGirisForm.ShowDialog();
        }

        private void btnUyeKayit_Click(object sender, EventArgs e)
        {
            UyeKayitForm uyeKayitForm = new UyeKayitForm();
            uyeKayitForm.ShowDialog();
        }

        private void btnTonetimGiris_Click(object sender, EventArgs e)
        {
            YonetimGirisForm yonetimGirisForm = new YonetimGirisForm();
            yonetimGirisForm.ShowDialog();
        }
    }
}
