namespace Toptancı
{
    partial class SiparisVerForm
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
            this.aaa = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.btnSepettenCikar = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(41, 245);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(1061, 334);
            this.dgvUrunler.TabIndex = 0;
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aaa.Location = new System.Drawing.Point(36, 29);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(80, 28);
            this.aaa.TabIndex = 1;
            this.aaa.Text = "Miktar:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(117, 26);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(152, 36);
            this.txtMiktar.TabIndex = 2;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(41, 82);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(228, 37);
            this.btnSepeteEkle.TabIndex = 3;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 28;
            this.lstSepet.Location = new System.Drawing.Point(741, 26);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(361, 144);
            this.lstSepet.TabIndex = 5;
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisOlustur.Location = new System.Drawing.Point(741, 188);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(361, 41);
            this.btnSiparisOlustur.TabIndex = 6;
            this.btnSiparisOlustur.Text = "Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // btnSepettenCikar
            // 
            this.btnSepettenCikar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepettenCikar.Location = new System.Drawing.Point(41, 133);
            this.btnSepettenCikar.Name = "btnSepettenCikar";
            this.btnSepettenCikar.Size = new System.Drawing.Size(228, 37);
            this.btnSepettenCikar.TabIndex = 7;
            this.btnSepettenCikar.Text = "Sepetten Çıkar";
            this.btnSepettenCikar.UseVisualStyleBackColor = true;
            this.btnSepettenCikar.Click += new System.EventHandler(this.btnSepettenCikar_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.lblMiktar.Location = new System.Drawing.Point(407, 76);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(0, 28);
            this.lblMiktar.TabIndex = 8;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.lblToplamTutar.Location = new System.Drawing.Point(407, 110);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 28);
            this.lblToplamTutar.TabIndex = 9;
            // 
            // SiparisVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 591);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.btnSepettenCikar);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.dgvUrunler);
            this.Name = "SiparisVerForm";
            this.Text = "Sipraiş Ver";
            this.Load += new System.EventHandler(this.SiparişVerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.Button btnSepettenCikar;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}