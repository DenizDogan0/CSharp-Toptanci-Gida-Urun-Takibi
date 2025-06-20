namespace ToptanciYonetimPaneli
{
    partial class SiparisYonetimiForm
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
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.grpSiparisDurumu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.cmbSiparisDurumu = new System.Windows.Forms.ComboBox();
            this.btnSiparisDetay = new System.Windows.Forms.Button();
            this.btnSiparisİptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.grpSiparisDurumu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(12, 250);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.Size = new System.Drawing.Size(1112, 420);
            this.dgvSiparisler.TabIndex = 0;
            // 
            // grpSiparisDurumu
            // 
            this.grpSiparisDurumu.Controls.Add(this.label1);
            this.grpSiparisDurumu.Controls.Add(this.btnDurumGuncelle);
            this.grpSiparisDurumu.Controls.Add(this.cmbSiparisDurumu);
            this.grpSiparisDurumu.Location = new System.Drawing.Point(34, 32);
            this.grpSiparisDurumu.Name = "grpSiparisDurumu";
            this.grpSiparisDurumu.Size = new System.Drawing.Size(588, 185);
            this.grpSiparisDurumu.TabIndex = 1;
            this.grpSiparisDurumu.TabStop = false;
            this.grpSiparisDurumu.Text = "Sipariş Durumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sipariş Durumu:";
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.Location = new System.Drawing.Point(11, 105);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(196, 36);
            this.btnDurumGuncelle.TabIndex = 1;
            this.btnDurumGuncelle.Text = "Durum Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // cmbSiparisDurumu
            // 
            this.cmbSiparisDurumu.FormattingEnabled = true;
            this.cmbSiparisDurumu.Location = new System.Drawing.Point(182, 48);
            this.cmbSiparisDurumu.Name = "cmbSiparisDurumu";
            this.cmbSiparisDurumu.Size = new System.Drawing.Size(121, 36);
            this.cmbSiparisDurumu.TabIndex = 0;
            // 
            // btnSiparisDetay
            // 
            this.btnSiparisDetay.Location = new System.Drawing.Point(682, 51);
            this.btnSiparisDetay.Name = "btnSiparisDetay";
            this.btnSiparisDetay.Size = new System.Drawing.Size(191, 39);
            this.btnSiparisDetay.TabIndex = 2;
            this.btnSiparisDetay.Text = "Sipariş Detay";
            this.btnSiparisDetay.UseVisualStyleBackColor = true;
            this.btnSiparisDetay.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSiparisİptal
            // 
            this.btnSiparisİptal.Location = new System.Drawing.Point(899, 51);
            this.btnSiparisİptal.Name = "btnSiparisİptal";
            this.btnSiparisİptal.Size = new System.Drawing.Size(191, 39);
            this.btnSiparisİptal.TabIndex = 3;
            this.btnSiparisİptal.Text = "Sipariş İptal";
            this.btnSiparisİptal.UseVisualStyleBackColor = true;
            this.btnSiparisİptal.Click += new System.EventHandler(this.button3_Click);
            // 
            // SiparisYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 682);
            this.Controls.Add(this.btnSiparisİptal);
            this.Controls.Add(this.btnSiparisDetay);
            this.Controls.Add(this.grpSiparisDurumu);
            this.Controls.Add(this.dgvSiparisler);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SiparisYonetimiForm";
            this.Text = "Sipariş Yönetimi";
            this.Load += new System.EventHandler(this.SiparisYonetimiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.grpSiparisDurumu.ResumeLayout(false);
            this.grpSiparisDurumu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.GroupBox grpSiparisDurumu;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.ComboBox cmbSiparisDurumu;
        private System.Windows.Forms.Button btnSiparisDetay;
        private System.Windows.Forms.Button btnSiparisİptal;
        private System.Windows.Forms.Label label1;
    }
}