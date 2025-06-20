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
    public partial class SiparisDetayForm : Form
    {
        public int SiparisId { get; set; }
        public DataTable SiparisDetaylari { get; set; }

        public SiparisDetayForm()
        {
            InitializeComponent();
        }

        private void SiparisDetayForm_Load(object sender, EventArgs e)
        {
            // Form başlığını ayarla
            this.Text = $"Sipariş Detayları - Sipariş No: {SiparisId}";

            // DataGridView'e verileri yükle
            dgvSiparisDetaylari.DataSource = SiparisDetaylari;

            // Sütunları otomatik boyutlandır
            dgvSiparisDetaylari.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Para birimi formatını ayarla
            if (dgvSiparisDetaylari.Columns["birim_fiyat"] != null)
                dgvSiparisDetaylari.Columns["birim_fiyat"].DefaultCellStyle.Format = "C2";
            if (dgvSiparisDetaylari.Columns["toplam_fiyat"] != null)
                dgvSiparisDetaylari.Columns["toplam_fiyat"].DefaultCellStyle.Format = "C2";

            // Toplam tutarı hesapla ve göster
            decimal toplamTutar = SiparisDetaylari.AsEnumerable().Sum(row => row.Field<decimal>("toplam_fiyat"));
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";
            lblToplamTutar.Dock = DockStyle.Bottom;
            lblToplamTutar.Font = new Font(lblToplamTutar.Font.FontFamily, 12, FontStyle.Bold);
        }
    }
}
