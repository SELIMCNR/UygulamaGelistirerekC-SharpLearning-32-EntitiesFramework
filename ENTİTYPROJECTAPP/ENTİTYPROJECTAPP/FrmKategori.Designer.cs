namespace ENTİTYPROJECTAPP
{
    partial class FrmKategori
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_Listele = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Güncelle = new System.Windows.Forms.Button();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KATEGORİ İD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "KATEGORİ ADI:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.Location = new System.Drawing.Point(127, 143);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(75, 23);
            this.Btn_Listele.TabIndex = 2;
            this.Btn_Listele.Text = "LİSTELE";
            this.Btn_Listele.UseVisualStyleBackColor = true;
            this.Btn_Listele.Click += new System.EventHandler(this.Btn_Listele_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(208, 143);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sil.TabIndex = 2;
            this.Btn_Sil.Text = "SİL";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Güncelle
            // 
            this.Btn_Güncelle.Location = new System.Drawing.Point(208, 172);
            this.Btn_Güncelle.Name = "Btn_Güncelle";
            this.Btn_Güncelle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Güncelle.TabIndex = 2;
            this.Btn_Güncelle.Text = "GÜNCELLE";
            this.Btn_Güncelle.UseVisualStyleBackColor = true;
            this.Btn_Güncelle.Click += new System.EventHandler(this.Btn_Güncelle_Click);
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Location = new System.Drawing.Point(127, 172);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ekle.TabIndex = 2;
            this.Btn_Ekle.Text = "EKLE";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 236);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 260);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.Btn_Güncelle);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Listele);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_Listele;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Güncelle;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

