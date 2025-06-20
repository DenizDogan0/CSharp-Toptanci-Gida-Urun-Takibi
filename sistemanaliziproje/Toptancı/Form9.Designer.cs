namespace Toptancı
{
    partial class StokDurumuForm
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
            this.dgvStokDurumu = new System.Windows.Forms.DataGridView();
            this.btnStokGuncelle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokDurumu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStokDurumu
            // 
            this.dgvStokDurumu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStokDurumu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokDurumu.Location = new System.Drawing.Point(18, 91);
            this.dgvStokDurumu.Name = "dgvStokDurumu";
            this.dgvStokDurumu.Size = new System.Drawing.Size(787, 580);
            this.dgvStokDurumu.TabIndex = 0;
            // 
            // btnStokGuncelle
            // 
            this.btnStokGuncelle.Location = new System.Drawing.Point(17, 25);
            this.btnStokGuncelle.Name = "btnStokGuncelle";
            this.btnStokGuncelle.Size = new System.Drawing.Size(154, 39);
            this.btnStokGuncelle.TabIndex = 1;
            this.btnStokGuncelle.Text = "Stok Güncelle";
            this.btnStokGuncelle.UseVisualStyleBackColor = true;
            this.btnStokGuncelle.Click += new System.EventHandler(this.btnStokGuncelle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(637, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(154, 39);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // StokDurumuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 683);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnStokGuncelle);
            this.Controls.Add(this.dgvStokDurumu);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StokDurumuForm";
            this.Text = "Stok Durumu";
            this.Load += new System.EventHandler(this.StokDurumuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokDurumu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStokDurumu;
        private System.Windows.Forms.Button btnStokGuncelle;
        private System.Windows.Forms.Button btnKapat;
    }
}