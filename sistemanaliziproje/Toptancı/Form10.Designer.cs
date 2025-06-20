namespace Toptancı
{
    partial class FiyatListesiForm
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
            this.dgvFiyatListesi = new System.Windows.Forms.DataGridView();
            this.btnFiyatGuncelle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnTopluGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiyatListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiyatListesi
            // 
            this.dgvFiyatListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiyatListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiyatListesi.Location = new System.Drawing.Point(11, 101);
            this.dgvFiyatListesi.Name = "dgvFiyatListesi";
            this.dgvFiyatListesi.Size = new System.Drawing.Size(1090, 591);
            this.dgvFiyatListesi.TabIndex = 0;
            // 
            // btnFiyatGuncelle
            // 
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(12, 43);
            this.btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(210, 38);
            this.btnFiyatGuncelle.TabIndex = 1;
            this.btnFiyatGuncelle.Text = "Fiyat Güncelle";
            this.btnFiyatGuncelle.UseVisualStyleBackColor = true;
            this.btnFiyatGuncelle.Click += new System.EventHandler(this.btnFiyatGuncelle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(891, 43);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(210, 38);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnTopluGuncelle
            // 
            this.btnTopluGuncelle.Location = new System.Drawing.Point(447, 43);
            this.btnTopluGuncelle.Name = "btnTopluGuncelle";
            this.btnTopluGuncelle.Size = new System.Drawing.Size(210, 38);
            this.btnTopluGuncelle.TabIndex = 3;
            this.btnTopluGuncelle.Text = "Toplu Güncelle";
            this.btnTopluGuncelle.UseVisualStyleBackColor = true;
            this.btnTopluGuncelle.Click += new System.EventHandler(this.btnTopluGuncelle_Click);
            // 
            // FiyatListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 704);
            this.Controls.Add(this.btnTopluGuncelle);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnFiyatGuncelle);
            this.Controls.Add(this.dgvFiyatListesi);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FiyatListesiForm";
            this.Text = "Fiyat Listesi";
            this.Load += new System.EventHandler(this.FiyatListesiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiyatListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiyatListesi;
        private System.Windows.Forms.Button btnFiyatGuncelle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnTopluGuncelle;
    }
}