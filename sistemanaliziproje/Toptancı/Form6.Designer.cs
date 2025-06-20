namespace Toptancı
{
    partial class SiparislerimForm
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
            this.btnSipraisDetay = new System.Windows.Forms.Button();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(20, 225);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.Size = new System.Drawing.Size(805, 462);
            this.dgvSiparisler.TabIndex = 0;
            // 
            // btnSipraisDetay
            // 
            this.btnSipraisDetay.Location = new System.Drawing.Point(20, 12);
            this.btnSipraisDetay.Name = "btnSipraisDetay";
            this.btnSipraisDetay.Size = new System.Drawing.Size(159, 40);
            this.btnSipraisDetay.TabIndex = 1;
            this.btnSipraisDetay.Text = "Sipariş Detay";
            this.btnSipraisDetay.UseVisualStyleBackColor = true;
            this.btnSipraisDetay.Click += new System.EventHandler(this.btnSipraisDetay_Click);
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Location = new System.Drawing.Point(20, 73);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(159, 40);
            this.btnSiparisIptal.TabIndex = 2;
            this.btnSiparisIptal.Text = "Sipariş İptal";
            this.btnSiparisIptal.UseVisualStyleBackColor = true;
            this.btnSiparisIptal.Click += new System.EventHandler(this.btnSiparisIptal_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(20, 135);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(159, 40);
            this.btnGeriDon.TabIndex = 3;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click_1);
            // 
            // SiparislerimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 699);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.btnSipraisDetay);
            this.Controls.Add(this.dgvSiparisler);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SiparislerimForm";
            this.Text = "Siparişlerim";
            this.Load += new System.EventHandler(this.SiparislerimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Button btnSipraisDetay;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.Button btnGeriDon;
    }
}