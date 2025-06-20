namespace Toptancı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUyeGiris = new System.Windows.Forms.Button();
            this.btnUyeKayit = new System.Windows.Forms.Button();
            this.btnTonetimGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUyeGiris
            // 
            this.btnUyeGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeGiris.Location = new System.Drawing.Point(23, 213);
            this.btnUyeGiris.Name = "btnUyeGiris";
            this.btnUyeGiris.Size = new System.Drawing.Size(204, 52);
            this.btnUyeGiris.TabIndex = 0;
            this.btnUyeGiris.Text = "Üye Giriş";
            this.btnUyeGiris.UseVisualStyleBackColor = true;
            this.btnUyeGiris.Click += new System.EventHandler(this.btnUyeGiris_Click);
            // 
            // btnUyeKayit
            // 
            this.btnUyeKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeKayit.Location = new System.Drawing.Point(270, 213);
            this.btnUyeKayit.Name = "btnUyeKayit";
            this.btnUyeKayit.Size = new System.Drawing.Size(204, 52);
            this.btnUyeKayit.TabIndex = 1;
            this.btnUyeKayit.Text = "Üye Kayıt";
            this.btnUyeKayit.UseVisualStyleBackColor = true;
            this.btnUyeKayit.Click += new System.EventHandler(this.btnUyeKayit_Click);
            // 
            // btnTonetimGiris
            // 
            this.btnTonetimGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTonetimGiris.Location = new System.Drawing.Point(522, 213);
            this.btnTonetimGiris.Name = "btnTonetimGiris";
            this.btnTonetimGiris.Size = new System.Drawing.Size(204, 52);
            this.btnTonetimGiris.TabIndex = 2;
            this.btnTonetimGiris.Text = "Yönetici Giriş";
            this.btnTonetimGiris.UseVisualStyleBackColor = true;
            this.btnTonetimGiris.Click += new System.EventHandler(this.btnTonetimGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25F);
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOĞAN TOPTANCI GIDAYA HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.label2.Location = new System.Drawing.Point(105, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "İŞLEM YAPABİLMEK İÇİN LÜTFEN GİRİŞ YAPINIZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label3.Location = new System.Drawing.Point(190, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "HESABINIZ YOK İSE KAYIT OLUNUZ LÜTFEN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTonetimGiris);
            this.Controls.Add(this.btnUyeKayit);
            this.Controls.Add(this.btnUyeGiris);
            this.Name = "Form1";
            this.Text = "Doğan Toptancı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUyeGiris;
        private System.Windows.Forms.Button btnUyeKayit;
        private System.Windows.Forms.Button btnTonetimGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

