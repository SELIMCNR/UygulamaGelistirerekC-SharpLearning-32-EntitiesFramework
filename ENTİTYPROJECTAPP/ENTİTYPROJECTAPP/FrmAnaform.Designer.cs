namespace ENTİTYPROJECTAPP
{
    partial class FrmAnaform
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
            this.Btn_Kategori = new System.Windows.Forms.Button();
            this.Btn_Ürün = new System.Windows.Forms.Button();
            this.Btn_İstatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Kategori
            // 
            this.Btn_Kategori.Location = new System.Drawing.Point(53, 33);
            this.Btn_Kategori.Name = "Btn_Kategori";
            this.Btn_Kategori.Size = new System.Drawing.Size(188, 83);
            this.Btn_Kategori.TabIndex = 0;
            this.Btn_Kategori.Text = "KATEGORİ İŞLEMLERİ";
            this.Btn_Kategori.UseVisualStyleBackColor = true;
            this.Btn_Kategori.Click += new System.EventHandler(this.Btn_Kategori_Click);
            // 
            // Btn_Ürün
            // 
            this.Btn_Ürün.Location = new System.Drawing.Point(268, 33);
            this.Btn_Ürün.Name = "Btn_Ürün";
            this.Btn_Ürün.Size = new System.Drawing.Size(153, 83);
            this.Btn_Ürün.TabIndex = 0;
            this.Btn_Ürün.Text = "ÜRÜN İŞLEMLERİ";
            this.Btn_Ürün.UseVisualStyleBackColor = true;
            this.Btn_Ürün.Click += new System.EventHandler(this.Btn_Ürün_Click);
            // 
            // Btn_İstatistik
            // 
            this.Btn_İstatistik.Location = new System.Drawing.Point(459, 33);
            this.Btn_İstatistik.Name = "Btn_İstatistik";
            this.Btn_İstatistik.Size = new System.Drawing.Size(159, 83);
            this.Btn_İstatistik.TabIndex = 0;
            this.Btn_İstatistik.Text = "İSTATİSTİKLER";
            this.Btn_İstatistik.UseVisualStyleBackColor = true;
            this.Btn_İstatistik.Click += new System.EventHandler(this.Btn_İstatistik_Click);
            // 
            // FrmAnaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 171);
            this.Controls.Add(this.Btn_İstatistik);
            this.Controls.Add(this.Btn_Ürün);
            this.Controls.Add(this.Btn_Kategori);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Kategori;
        private System.Windows.Forms.Button Btn_Ürün;
        private System.Windows.Forms.Button Btn_İstatistik;
    }
}