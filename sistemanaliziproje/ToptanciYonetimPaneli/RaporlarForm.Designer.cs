namespace ToptanciYonetimPaneli
{
    partial class RaporlarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUrunRporlari = new System.Windows.Forms.TabControl();
            this.tabSatisRaporlari = new System.Windows.Forms.TabPage();
            this.btnSatisExcelAktar = new System.Windows.Forms.Button();
            this.dgvSatisRaporSonuclari = new System.Windows.Forms.DataGridView();
            this.btnSatisRaporOlustur = new System.Windows.Forms.Button();
            this.grbSatisFiltreler = new System.Windows.Forms.GroupBox();
            this.cmbSatisRaporTuru = new System.Windows.Forms.ComboBox();
            this.tabUrunRaporlari = new System.Windows.Forms.TabPage();
            this.btnUrunExcelAktar = new System.Windows.Forms.Button();
            this.dgvUrunRaporSonuclari = new System.Windows.Forms.DataGridView();
            this.btnUrunRaporOlustur = new System.Windows.Forms.Button();
            this.grpUrunFiltreler = new System.Windows.Forms.GroupBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbUrunRaporTuru = new System.Windows.Forms.ComboBox();
            this.tabMusteriRaporlari = new System.Windows.Forms.TabPage();
            this.btnMusteriExcelAktar = new System.Windows.Forms.Button();
            this.dgvMusteriRaporSonuclari = new System.Windows.Forms.DataGridView();
            this.btnMusteriRaporOlustur = new System.Windows.Forms.Button();
            this.grbMusteriFiltreler = new System.Windows.Forms.GroupBox();
            this.cmbMusteriRaporTuru = new System.Windows.Forms.ComboBox();
            this.tabFinansalRaporlar = new System.Windows.Forms.TabPage();
            this.btnFinansalExcelOlustur = new System.Windows.Forms.Button();
            this.dgvFinansalRaporSonuclari = new System.Windows.Forms.DataGridView();
            this.btnFinansalRaporOlustur = new System.Windows.Forms.Button();
            this.grbFinansalFiltreler = new System.Windows.Forms.GroupBox();
            this.cmbFinansalRaporTuru = new System.Windows.Forms.ComboBox();
            this.tabUrunRporlari.SuspendLayout();
            this.tabSatisRaporlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisRaporSonuclari)).BeginInit();
            this.grbSatisFiltreler.SuspendLayout();
            this.tabUrunRaporlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunRaporSonuclari)).BeginInit();
            this.grpUrunFiltreler.SuspendLayout();
            this.tabMusteriRaporlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriRaporSonuclari)).BeginInit();
            this.grbMusteriFiltreler.SuspendLayout();
            this.tabFinansalRaporlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinansalRaporSonuclari)).BeginInit();
            this.grbFinansalFiltreler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUrunRporlari
            // 
            this.tabUrunRporlari.Controls.Add(this.tabSatisRaporlari);
            this.tabUrunRporlari.Controls.Add(this.tabUrunRaporlari);
            this.tabUrunRporlari.Controls.Add(this.tabMusteriRaporlari);
            this.tabUrunRporlari.Controls.Add(this.tabFinansalRaporlar);
            this.tabUrunRporlari.Location = new System.Drawing.Point(12, 23);
            this.tabUrunRporlari.Name = "tabUrunRporlari";
            this.tabUrunRporlari.SelectedIndex = 0;
            this.tabUrunRporlari.Size = new System.Drawing.Size(1101, 691);
            this.tabUrunRporlari.TabIndex = 0;
            // 
            // tabSatisRaporlari
            // 
            this.tabSatisRaporlari.Controls.Add(this.btnSatisExcelAktar);
            this.tabSatisRaporlari.Controls.Add(this.dgvSatisRaporSonuclari);
            this.tabSatisRaporlari.Controls.Add(this.btnSatisRaporOlustur);
            this.tabSatisRaporlari.Controls.Add(this.grbSatisFiltreler);
            this.tabSatisRaporlari.Location = new System.Drawing.Point(4, 37);
            this.tabSatisRaporlari.Name = "tabSatisRaporlari";
            this.tabSatisRaporlari.Padding = new System.Windows.Forms.Padding(3);
            this.tabSatisRaporlari.Size = new System.Drawing.Size(1093, 650);
            this.tabSatisRaporlari.TabIndex = 0;
            this.tabSatisRaporlari.Text = "Satış Raporları";
            this.tabSatisRaporlari.UseVisualStyleBackColor = true;
            // 
            // btnSatisExcelAktar
            // 
            this.btnSatisExcelAktar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSatisExcelAktar.Location = new System.Drawing.Point(3, 600);
            this.btnSatisExcelAktar.Name = "btnSatisExcelAktar";
            this.btnSatisExcelAktar.Size = new System.Drawing.Size(1087, 47);
            this.btnSatisExcelAktar.TabIndex = 3;
            this.btnSatisExcelAktar.Text = "Excel Aktar";
            this.btnSatisExcelAktar.UseVisualStyleBackColor = true;
            this.btnSatisExcelAktar.Click += new System.EventHandler(this.btnSatisExcelAktar_Click);
            // 
            // dgvSatisRaporSonuclari
            // 
            this.dgvSatisRaporSonuclari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatisRaporSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisRaporSonuclari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSatisRaporSonuclari.Location = new System.Drawing.Point(3, 159);
            this.dgvSatisRaporSonuclari.Name = "dgvSatisRaporSonuclari";
            this.dgvSatisRaporSonuclari.Size = new System.Drawing.Size(1087, 488);
            this.dgvSatisRaporSonuclari.TabIndex = 2;
            // 
            // btnSatisRaporOlustur
            // 
            this.btnSatisRaporOlustur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSatisRaporOlustur.Location = new System.Drawing.Point(3, 112);
            this.btnSatisRaporOlustur.Name = "btnSatisRaporOlustur";
            this.btnSatisRaporOlustur.Size = new System.Drawing.Size(1087, 47);
            this.btnSatisRaporOlustur.TabIndex = 1;
            this.btnSatisRaporOlustur.Text = "Rapor Oluştur";
            this.btnSatisRaporOlustur.UseVisualStyleBackColor = true;
            this.btnSatisRaporOlustur.Click += new System.EventHandler(this.btnSatisRaporOlustur_Click);
            // 
            // grbSatisFiltreler
            // 
            this.grbSatisFiltreler.Controls.Add(this.cmbSatisRaporTuru);
            this.grbSatisFiltreler.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSatisFiltreler.Location = new System.Drawing.Point(3, 3);
            this.grbSatisFiltreler.Name = "grbSatisFiltreler";
            this.grbSatisFiltreler.Size = new System.Drawing.Size(1087, 109);
            this.grbSatisFiltreler.TabIndex = 0;
            this.grbSatisFiltreler.TabStop = false;
            this.grbSatisFiltreler.Text = "Filtreler";
            // 
            // cmbSatisRaporTuru
            // 
            this.cmbSatisRaporTuru.FormattingEnabled = true;
            this.cmbSatisRaporTuru.Location = new System.Drawing.Point(6, 35);
            this.cmbSatisRaporTuru.Name = "cmbSatisRaporTuru";
            this.cmbSatisRaporTuru.Size = new System.Drawing.Size(282, 36);
            this.cmbSatisRaporTuru.TabIndex = 0;
            // 
            // tabUrunRaporlari
            // 
            this.tabUrunRaporlari.Controls.Add(this.btnUrunExcelAktar);
            this.tabUrunRaporlari.Controls.Add(this.dgvUrunRaporSonuclari);
            this.tabUrunRaporlari.Controls.Add(this.btnUrunRaporOlustur);
            this.tabUrunRaporlari.Controls.Add(this.grpUrunFiltreler);
            this.tabUrunRaporlari.Location = new System.Drawing.Point(4, 37);
            this.tabUrunRaporlari.Name = "tabUrunRaporlari";
            this.tabUrunRaporlari.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrunRaporlari.Size = new System.Drawing.Size(1093, 650);
            this.tabUrunRaporlari.TabIndex = 1;
            this.tabUrunRaporlari.Text = "Ürün Rapıırları";
            this.tabUrunRaporlari.UseVisualStyleBackColor = true;
            // 
            // btnUrunExcelAktar
            // 
            this.btnUrunExcelAktar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUrunExcelAktar.Location = new System.Drawing.Point(3, 600);
            this.btnUrunExcelAktar.Name = "btnUrunExcelAktar";
            this.btnUrunExcelAktar.Size = new System.Drawing.Size(1087, 47);
            this.btnUrunExcelAktar.TabIndex = 7;
            this.btnUrunExcelAktar.Text = "Excel Aktar";
            this.btnUrunExcelAktar.UseVisualStyleBackColor = true;
            this.btnUrunExcelAktar.Click += new System.EventHandler(this.btnUrunExcelAktar_Click);
            // 
            // dgvUrunRaporSonuclari
            // 
            this.dgvUrunRaporSonuclari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunRaporSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunRaporSonuclari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunRaporSonuclari.Location = new System.Drawing.Point(3, 163);
            this.dgvUrunRaporSonuclari.Name = "dgvUrunRaporSonuclari";
            this.dgvUrunRaporSonuclari.Size = new System.Drawing.Size(1087, 484);
            this.dgvUrunRaporSonuclari.TabIndex = 6;
            // 
            // btnUrunRaporOlustur
            // 
            this.btnUrunRaporOlustur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunRaporOlustur.Location = new System.Drawing.Point(3, 116);
            this.btnUrunRaporOlustur.Name = "btnUrunRaporOlustur";
            this.btnUrunRaporOlustur.Size = new System.Drawing.Size(1087, 47);
            this.btnUrunRaporOlustur.TabIndex = 5;
            this.btnUrunRaporOlustur.Text = "Rapor Oluştur";
            this.btnUrunRaporOlustur.UseVisualStyleBackColor = true;
            this.btnUrunRaporOlustur.Click += new System.EventHandler(this.btnUrunRaporOlustur_Click);
            // 
            // grpUrunFiltreler
            // 
            this.grpUrunFiltreler.Controls.Add(this.cmbKategori);
            this.grpUrunFiltreler.Controls.Add(this.cmbUrunRaporTuru);
            this.grpUrunFiltreler.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUrunFiltreler.Location = new System.Drawing.Point(3, 3);
            this.grpUrunFiltreler.Name = "grpUrunFiltreler";
            this.grpUrunFiltreler.Size = new System.Drawing.Size(1087, 113);
            this.grpUrunFiltreler.TabIndex = 4;
            this.grpUrunFiltreler.TabStop = false;
            this.grpUrunFiltreler.Text = "Filitreler";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(323, 39);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(300, 36);
            this.cmbKategori.TabIndex = 1;
            // 
            // cmbUrunRaporTuru
            // 
            this.cmbUrunRaporTuru.FormattingEnabled = true;
            this.cmbUrunRaporTuru.Location = new System.Drawing.Point(24, 39);
            this.cmbUrunRaporTuru.Name = "cmbUrunRaporTuru";
            this.cmbUrunRaporTuru.Size = new System.Drawing.Size(268, 36);
            this.cmbUrunRaporTuru.TabIndex = 0;
            // 
            // tabMusteriRaporlari
            // 
            this.tabMusteriRaporlari.Controls.Add(this.btnMusteriExcelAktar);
            this.tabMusteriRaporlari.Controls.Add(this.dgvMusteriRaporSonuclari);
            this.tabMusteriRaporlari.Controls.Add(this.btnMusteriRaporOlustur);
            this.tabMusteriRaporlari.Controls.Add(this.grbMusteriFiltreler);
            this.tabMusteriRaporlari.Location = new System.Drawing.Point(4, 37);
            this.tabMusteriRaporlari.Name = "tabMusteriRaporlari";
            this.tabMusteriRaporlari.Size = new System.Drawing.Size(1093, 650);
            this.tabMusteriRaporlari.TabIndex = 2;
            this.tabMusteriRaporlari.Text = "Müşteri Raporları";
            this.tabMusteriRaporlari.UseVisualStyleBackColor = true;
            // 
            // btnMusteriExcelAktar
            // 
            this.btnMusteriExcelAktar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMusteriExcelAktar.Location = new System.Drawing.Point(0, 603);
            this.btnMusteriExcelAktar.Name = "btnMusteriExcelAktar";
            this.btnMusteriExcelAktar.Size = new System.Drawing.Size(1093, 47);
            this.btnMusteriExcelAktar.TabIndex = 7;
            this.btnMusteriExcelAktar.Text = "Excel Aktar";
            this.btnMusteriExcelAktar.UseVisualStyleBackColor = true;
            this.btnMusteriExcelAktar.Click += new System.EventHandler(this.btnMusteriExcelAktar_Click);
            // 
            // dgvMusteriRaporSonuclari
            // 
            this.dgvMusteriRaporSonuclari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteriRaporSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriRaporSonuclari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteriRaporSonuclari.Location = new System.Drawing.Point(0, 157);
            this.dgvMusteriRaporSonuclari.Name = "dgvMusteriRaporSonuclari";
            this.dgvMusteriRaporSonuclari.Size = new System.Drawing.Size(1093, 493);
            this.dgvMusteriRaporSonuclari.TabIndex = 6;
            // 
            // btnMusteriRaporOlustur
            // 
            this.btnMusteriRaporOlustur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteriRaporOlustur.Location = new System.Drawing.Point(0, 110);
            this.btnMusteriRaporOlustur.Name = "btnMusteriRaporOlustur";
            this.btnMusteriRaporOlustur.Size = new System.Drawing.Size(1093, 47);
            this.btnMusteriRaporOlustur.TabIndex = 5;
            this.btnMusteriRaporOlustur.Text = "Rapor Oluştur";
            this.btnMusteriRaporOlustur.UseVisualStyleBackColor = true;
            this.btnMusteriRaporOlustur.Click += new System.EventHandler(this.btnMusteriRaporOlustur_Click);
            // 
            // grbMusteriFiltreler
            // 
            this.grbMusteriFiltreler.Controls.Add(this.cmbMusteriRaporTuru);
            this.grbMusteriFiltreler.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbMusteriFiltreler.Location = new System.Drawing.Point(0, 0);
            this.grbMusteriFiltreler.Name = "grbMusteriFiltreler";
            this.grbMusteriFiltreler.Size = new System.Drawing.Size(1093, 110);
            this.grbMusteriFiltreler.TabIndex = 4;
            this.grbMusteriFiltreler.TabStop = false;
            this.grbMusteriFiltreler.Text = "Filtreler";
            // 
            // cmbMusteriRaporTuru
            // 
            this.cmbMusteriRaporTuru.FormattingEnabled = true;
            this.cmbMusteriRaporTuru.Location = new System.Drawing.Point(6, 35);
            this.cmbMusteriRaporTuru.Name = "cmbMusteriRaporTuru";
            this.cmbMusteriRaporTuru.Size = new System.Drawing.Size(303, 36);
            this.cmbMusteriRaporTuru.TabIndex = 0;
            // 
            // tabFinansalRaporlar
            // 
            this.tabFinansalRaporlar.Controls.Add(this.btnFinansalExcelOlustur);
            this.tabFinansalRaporlar.Controls.Add(this.dgvFinansalRaporSonuclari);
            this.tabFinansalRaporlar.Controls.Add(this.btnFinansalRaporOlustur);
            this.tabFinansalRaporlar.Controls.Add(this.grbFinansalFiltreler);
            this.tabFinansalRaporlar.Location = new System.Drawing.Point(4, 37);
            this.tabFinansalRaporlar.Name = "tabFinansalRaporlar";
            this.tabFinansalRaporlar.Size = new System.Drawing.Size(1093, 650);
            this.tabFinansalRaporlar.TabIndex = 3;
            this.tabFinansalRaporlar.Text = "Finansal Raporlar";
            this.tabFinansalRaporlar.UseVisualStyleBackColor = true;
            // 
            // btnFinansalExcelOlustur
            // 
            this.btnFinansalExcelOlustur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFinansalExcelOlustur.Location = new System.Drawing.Point(0, 603);
            this.btnFinansalExcelOlustur.Name = "btnFinansalExcelOlustur";
            this.btnFinansalExcelOlustur.Size = new System.Drawing.Size(1093, 47);
            this.btnFinansalExcelOlustur.TabIndex = 7;
            this.btnFinansalExcelOlustur.Text = "Excel Aktar";
            this.btnFinansalExcelOlustur.UseVisualStyleBackColor = true;
            this.btnFinansalExcelOlustur.Click += new System.EventHandler(this.btnFinansalExcelOlustur_Click);
            // 
            // dgvFinansalRaporSonuclari
            // 
            this.dgvFinansalRaporSonuclari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinansalRaporSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinansalRaporSonuclari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFinansalRaporSonuclari.Location = new System.Drawing.Point(0, 174);
            this.dgvFinansalRaporSonuclari.Name = "dgvFinansalRaporSonuclari";
            this.dgvFinansalRaporSonuclari.Size = new System.Drawing.Size(1093, 476);
            this.dgvFinansalRaporSonuclari.TabIndex = 6;
            // 
            // btnFinansalRaporOlustur
            // 
            this.btnFinansalRaporOlustur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinansalRaporOlustur.Location = new System.Drawing.Point(0, 127);
            this.btnFinansalRaporOlustur.Name = "btnFinansalRaporOlustur";
            this.btnFinansalRaporOlustur.Size = new System.Drawing.Size(1093, 47);
            this.btnFinansalRaporOlustur.TabIndex = 5;
            this.btnFinansalRaporOlustur.Text = "Rapor Oluştur";
            this.btnFinansalRaporOlustur.UseVisualStyleBackColor = true;
            this.btnFinansalRaporOlustur.Click += new System.EventHandler(this.btnFinansalRaporOlustur_Click_1);
            // 
            // grbFinansalFiltreler
            // 
            this.grbFinansalFiltreler.Controls.Add(this.cmbFinansalRaporTuru);
            this.grbFinansalFiltreler.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFinansalFiltreler.Location = new System.Drawing.Point(0, 0);
            this.grbFinansalFiltreler.Name = "grbFinansalFiltreler";
            this.grbFinansalFiltreler.Size = new System.Drawing.Size(1093, 127);
            this.grbFinansalFiltreler.TabIndex = 4;
            this.grbFinansalFiltreler.TabStop = false;
            this.grbFinansalFiltreler.Text = "Filtreler";
            // 
            // cmbFinansalRaporTuru
            // 
            this.cmbFinansalRaporTuru.FormattingEnabled = true;
            this.cmbFinansalRaporTuru.Location = new System.Drawing.Point(6, 35);
            this.cmbFinansalRaporTuru.Name = "cmbFinansalRaporTuru";
            this.cmbFinansalRaporTuru.Size = new System.Drawing.Size(274, 36);
            this.cmbFinansalRaporTuru.TabIndex = 0;
            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 726);
            this.Controls.Add(this.tabUrunRporlari);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RaporlarForm";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.RaporlarForm_Load);
            this.tabUrunRporlari.ResumeLayout(false);
            this.tabSatisRaporlari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisRaporSonuclari)).EndInit();
            this.grbSatisFiltreler.ResumeLayout(false);
            this.tabUrunRaporlari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunRaporSonuclari)).EndInit();
            this.grpUrunFiltreler.ResumeLayout(false);
            this.tabMusteriRaporlari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriRaporSonuclari)).EndInit();
            this.grbMusteriFiltreler.ResumeLayout(false);
            this.tabFinansalRaporlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinansalRaporSonuclari)).EndInit();
            this.grbFinansalFiltreler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUrunRporlari;
        private System.Windows.Forms.TabPage tabSatisRaporlari;
        private System.Windows.Forms.TabPage tabUrunRaporlari;
        private System.Windows.Forms.TabPage tabMusteriRaporlari;
        private System.Windows.Forms.TabPage tabFinansalRaporlar;
        private System.Windows.Forms.DataGridView dgvSatisRaporSonuclari;
        private System.Windows.Forms.Button btnSatisRaporOlustur;
        private System.Windows.Forms.GroupBox grbSatisFiltreler;
        private System.Windows.Forms.Button btnSatisExcelAktar;
        private System.Windows.Forms.Button btnUrunExcelAktar;
        private System.Windows.Forms.DataGridView dgvUrunRaporSonuclari;
        private System.Windows.Forms.Button btnUrunRaporOlustur;
        private System.Windows.Forms.GroupBox grpUrunFiltreler;
        private System.Windows.Forms.Button btnMusteriExcelAktar;
        private System.Windows.Forms.DataGridView dgvMusteriRaporSonuclari;
        private System.Windows.Forms.Button btnMusteriRaporOlustur;
        private System.Windows.Forms.GroupBox grbMusteriFiltreler;
        private System.Windows.Forms.Button btnFinansalExcelOlustur;
        private System.Windows.Forms.DataGridView dgvFinansalRaporSonuclari;
        private System.Windows.Forms.Button btnFinansalRaporOlustur;
        private System.Windows.Forms.GroupBox grbFinansalFiltreler;
        private System.Windows.Forms.ComboBox cmbFinansalRaporTuru;
        private System.Windows.Forms.ComboBox cmbMusteriRaporTuru;
        private System.Windows.Forms.ComboBox cmbUrunRaporTuru;
        private System.Windows.Forms.ComboBox cmbSatisRaporTuru;
        private System.Windows.Forms.ComboBox cmbKategori;
    }
}