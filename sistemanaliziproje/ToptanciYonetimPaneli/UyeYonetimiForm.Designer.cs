namespace ToptanciYonetimPaneli
{
    partial class UyeYonetimiForm
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
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.btnUyeOnayla = new System.Windows.Forms.Button();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.btnUyeReddet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Location = new System.Drawing.Point(23, 72);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.Size = new System.Drawing.Size(1102, 648);
            this.dgvUyeler.TabIndex = 0;
            // 
            // btnUyeOnayla
            // 
            this.btnUyeOnayla.Location = new System.Drawing.Point(23, 12);
            this.btnUyeOnayla.Name = "btnUyeOnayla";
            this.btnUyeOnayla.Size = new System.Drawing.Size(159, 38);
            this.btnUyeOnayla.TabIndex = 1;
            this.btnUyeOnayla.Text = "Üye Onayla";
            this.btnUyeOnayla.UseVisualStyleBackColor = true;
            this.btnUyeOnayla.Click += new System.EventHandler(this.btnUyeOnayla_Click);
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.Location = new System.Drawing.Point(438, 12);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(159, 38);
            this.btnUyeSil.TabIndex = 2;
            this.btnUyeSil.Text = "Üye Sil";
            this.btnUyeSil.UseVisualStyleBackColor = true;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // btnUyeReddet
            // 
            this.btnUyeReddet.Location = new System.Drawing.Point(228, 12);
            this.btnUyeReddet.Name = "btnUyeReddet";
            this.btnUyeReddet.Size = new System.Drawing.Size(159, 38);
            this.btnUyeReddet.TabIndex = 3;
            this.btnUyeReddet.Text = "Üye Reddet";
            this.btnUyeReddet.UseVisualStyleBackColor = true;
            this.btnUyeReddet.Click += new System.EventHandler(this.btnUyeReddet_Click);
            // 
            // UyeYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 782);
            this.Controls.Add(this.btnUyeReddet);
            this.Controls.Add(this.btnUyeSil);
            this.Controls.Add(this.btnUyeOnayla);
            this.Controls.Add(this.dgvUyeler);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UyeYonetimiForm";
            this.Text = "Üye Yönetim ";
            this.Load += new System.EventHandler(this.UyeYonetimiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.Button btnUyeOnayla;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Button btnUyeReddet;
    }
}