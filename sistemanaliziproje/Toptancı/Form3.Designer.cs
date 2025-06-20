namespace Toptancı
{
    partial class UyeGirisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(158, 88);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(192, 36);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(158, 152);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(192, 36);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(158, 220);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(192, 43);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(99, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "ÜYE GİRİŞ";
            // 
            // UyeGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UyeGirisForm";
            this.Text = "Üye Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label3;
    }
}