namespace ToptanciYonetimPaneli
{
    partial class UrunYonetimiForm
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
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.grpUrunEkle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.grpUrunEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(5, 200);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(1213, 555);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.SelectionChanged += new System.EventHandler(this.dgvUrunler_SelectionChanged);
            // 
            // grpUrunEkle
            // 
            this.grpUrunEkle.Controls.Add(this.label4);
            this.grpUrunEkle.Controls.Add(this.txtStokMiktari);
            this.grpUrunEkle.Controls.Add(this.label3);
            this.grpUrunEkle.Controls.Add(this.btnUrunEkle);
            this.grpUrunEkle.Controls.Add(this.label2);
            this.grpUrunEkle.Controls.Add(this.txtUrunAdi);
            this.grpUrunEkle.Controls.Add(this.label1);
            this.grpUrunEkle.Controls.Add(this.txtBirimFiyat);
            this.grpUrunEkle.Controls.Add(this.cmbKategori);
            this.grpUrunEkle.Location = new System.Drawing.Point(12, 12);
            this.grpUrunEkle.Name = "grpUrunEkle";
            this.grpUrunEkle.Size = new System.Drawing.Size(772, 182);
            this.grpUrunEkle.TabIndex = 1;
            this.grpUrunEkle.TabStop = false;
            this.grpUrunEkle.Text = "Ürün ekle";
            this.grpUrunEkle.Enter += new System.EventHandler(this.grpUrunEkle_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kategori:";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(134, 118);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(200, 36);
            this.txtStokMiktari.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stok Miktarı:";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(488, 122);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(265, 32);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Birim Fiyat:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(133, 34);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 36);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(133, 76);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(201, 36);
            this.txtBirimFiyat.TabIndex = 2;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(488, 34);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(265, 36);
            this.cmbKategori.TabIndex = 2;
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(834, 31);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(249, 37);
            this.btnUrunGuncelle.TabIndex = 2;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(834, 129);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(249, 37);
            this.btnUrunSil.TabIndex = 3;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // UrunYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 767);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.grpUrunEkle);
            this.Controls.Add(this.dgvUrunler);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UrunYonetimiForm";
            this.Text = "Ürün Yonetimi";
            this.Load += new System.EventHandler(this.UrunYonetimiFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.grpUrunEkle.ResumeLayout(false);
            this.grpUrunEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.GroupBox grpUrunEkle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
    }
}