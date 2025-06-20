namespace ToptanciYonetimPaneli
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
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisDetaylari
            // 
            this.dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(0, 0);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(1130, 710);
            this.dgvSiparisDetaylari.TabIndex = 0;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblToplamTutar.Font = new System.Drawing.Font("Palatino Linotype", 20F);
            this.lblToplamTutar.Location = new System.Drawing.Point(0, 674);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(84, 36);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "label1";
            // 
            // SiparisDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 710);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SiparisDetayForm";
            this.Text = "Sipariş Detay";
            this.Load += new System.EventHandler(this.SiparisDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}