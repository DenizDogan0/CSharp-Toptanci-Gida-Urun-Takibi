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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void üyeYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltFormGoster(new UyeYonetimiForm());
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltFormGoster(new UrunYonetimiForm());
        }

        private void siparişYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltFormGoster(new SiparisYonetimiForm());
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltFormGoster(new RaporlarForm());
        }

        private void AltFormGoster(Form altForm)
        {
            pnlIcerik.Controls.Clear();
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(altForm);
            altForm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
