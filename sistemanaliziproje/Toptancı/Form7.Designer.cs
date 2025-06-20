namespace Toptancı
{
    partial class SiparisDetayForm
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
            this.lblSiparisBilgileri = new System.Windows.Forms.Label();
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSiparisBilgileri
            // 
            this.lblSiparisBilgileri.AutoSize = true;
            this.lblSiparisBilgileri.Location = new System.Drawing.Point(27, 20);
            this.lblSiparisBilgileri.Name = "lblSiparisBilgileri";
            this.lblSiparisBilgileri.Size = new System.Drawing.Size(0, 28);
            this.lblSiparisBilgileri.TabIndex = 0;
            // 
            // dgvSiparisDetaylari
            // 
            this.dgvSiparisDetaylari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(32, 288);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(1016, 393);
            this.dgvSiparisDetaylari.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(931, 20);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(117, 43);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click_1);
            // 
            // SiparisDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Controls.Add(this.lblSiparisBilgileri);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SiparisDetayForm";
            this.Load += new System.EventHandler(this.SiparisDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSiparisBilgileri;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
        private System.Windows.Forms.Button btnKapat;
    }
}