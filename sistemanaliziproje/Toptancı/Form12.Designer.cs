namespace Toptancı
{
    partial class YonetimGirisForm
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
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYoneticiKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtYoneticiSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.Location = new System.Drawing.Point(244, 194);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(180, 42);
            this.btnYoneticiGiris.TabIndex = 0;
            this.btnYoneticiGiris.Text = "Giriş Yap";
            this.btnYoneticiGiris.UseVisualStyleBackColor = true;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetici Kullanıcı Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yönetici Şifre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtYoneticiKullaniciAdi
            // 
            this.txtYoneticiKullaniciAdi.Location = new System.Drawing.Point(244, 73);
            this.txtYoneticiKullaniciAdi.Name = "txtYoneticiKullaniciAdi";
            this.txtYoneticiKullaniciAdi.Size = new System.Drawing.Size(180, 36);
            this.txtYoneticiKullaniciAdi.TabIndex = 3;
            this.txtYoneticiKullaniciAdi.TextChanged += new System.EventHandler(this.txtYoneticiKullaniciAdi_TextChanged);
            // 
            // txtYoneticiSifre
            // 
            this.txtYoneticiSifre.Location = new System.Drawing.Point(244, 129);
            this.txtYoneticiSifre.Name = "txtYoneticiSifre";
            this.txtYoneticiSifre.Size = new System.Drawing.Size(180, 36);
            this.txtYoneticiSifre.TabIndex = 4;
            this.txtYoneticiSifre.TextChanged += new System.EventHandler(this.txtYoneticiSifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 25F);
            this.label3.Location = new System.Drawing.Point(112, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yönetici Giriş";
            // 
            // YonetimGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYoneticiSifre);
            this.Controls.Add(this.txtYoneticiKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYoneticiGiris);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "YonetimGirisForm";
            this.Text = "Yönetici Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYoneticiGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYoneticiKullaniciAdi;
        private System.Windows.Forms.TextBox txtYoneticiSifre;
        private System.Windows.Forms.Label label3;
    }
}