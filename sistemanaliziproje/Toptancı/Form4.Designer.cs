namespace Toptancı
{
    partial class UyeIslemlerForm
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
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnFiyatListesi = new System.Windows.Forms.Button();
            this.btnStokDurumu = new System.Windows.Forms.Button();
            this.btnProfilDuzenle = new System.Windows.Forms.Button();
            this.btnSiparislerim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldin.Location = new System.Drawing.Point(112, 32);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(270, 46);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "HOŞGELDİNİZ";
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(25, 166);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(166, 34);
            this.btnSiparisVer.TabIndex = 1;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(469, 216);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(166, 34);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnFiyatListesi
            // 
            this.btnFiyatListesi.Location = new System.Drawing.Point(469, 166);
            this.btnFiyatListesi.Name = "btnFiyatListesi";
            this.btnFiyatListesi.Size = new System.Drawing.Size(166, 34);
            this.btnFiyatListesi.TabIndex = 3;
            this.btnFiyatListesi.Text = "Fiyat Listesi";
            this.btnFiyatListesi.UseVisualStyleBackColor = true;
            this.btnFiyatListesi.Click += new System.EventHandler(this.btnFiyatListesi_Click);
            // 
            // btnStokDurumu
            // 
            this.btnStokDurumu.Location = new System.Drawing.Point(247, 216);
            this.btnStokDurumu.Name = "btnStokDurumu";
            this.btnStokDurumu.Size = new System.Drawing.Size(166, 34);
            this.btnStokDurumu.TabIndex = 4;
            this.btnStokDurumu.Text = "Stok Durumu";
            this.btnStokDurumu.UseVisualStyleBackColor = true;
            this.btnStokDurumu.Click += new System.EventHandler(this.btnStokDurumu_Click);
            // 
            // btnProfilDuzenle
            // 
            this.btnProfilDuzenle.Location = new System.Drawing.Point(247, 166);
            this.btnProfilDuzenle.Name = "btnProfilDuzenle";
            this.btnProfilDuzenle.Size = new System.Drawing.Size(166, 34);
            this.btnProfilDuzenle.TabIndex = 5;
            this.btnProfilDuzenle.Text = "Profil Düzenle";
            this.btnProfilDuzenle.UseVisualStyleBackColor = true;
            this.btnProfilDuzenle.Click += new System.EventHandler(this.btnProfilDuzenle_Click);
            // 
            // btnSiparislerim
            // 
            this.btnSiparislerim.Location = new System.Drawing.Point(25, 216);
            this.btnSiparislerim.Name = "btnSiparislerim";
            this.btnSiparislerim.Size = new System.Drawing.Size(166, 34);
            this.btnSiparislerim.TabIndex = 6;
            this.btnSiparislerim.Text = "Sipraişlerim";
            this.btnSiparislerim.UseVisualStyleBackColor = true;
            this.btnSiparislerim.Click += new System.EventHandler(this.btnSiparislerim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lütfen yapacağınız işlemi seçiniz...";
            // 
            // UyeIslemlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiparislerim);
            this.Controls.Add(this.btnProfilDuzenle);
            this.Controls.Add(this.btnStokDurumu);
            this.Controls.Add(this.btnFiyatListesi);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.lblHosgeldin);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UyeIslemlerForm";
            this.Text = "Üye İşlemleri";
            this.Load += new System.EventHandler(this.UyeIslemleriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnFiyatListesi;
        private System.Windows.Forms.Button btnStokDurumu;
        private System.Windows.Forms.Button btnProfilDuzenle;
        private System.Windows.Forms.Button btnSiparislerim;
        private System.Windows.Forms.Label label1;
    }
}