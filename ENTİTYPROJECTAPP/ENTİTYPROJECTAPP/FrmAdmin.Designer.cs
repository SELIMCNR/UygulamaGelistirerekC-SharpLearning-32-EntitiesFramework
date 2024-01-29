namespace ENTİTYPROJECTAPP
{
    partial class FrmAdmin
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
            this.Btn_Giris = new System.Windows.Forms.Button();
            this.Text_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.Location = new System.Drawing.Point(173, 158);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(75, 23);
            this.Btn_Giris.TabIndex = 1;
            this.Btn_Giris.Text = "Giriş Yap";
            this.Btn_Giris.UseVisualStyleBackColor = true;
            this.Btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // Text_Ad
            // 
            this.Text_Ad.Location = new System.Drawing.Point(141, 57);
            this.Text_Ad.Name = "Text_Ad";
            this.Text_Ad.Size = new System.Drawing.Size(141, 20);
            this.Text_Ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // Text_Sifre
            // 
            this.Text_Sifre.Location = new System.Drawing.Point(141, 109);
            this.Text_Sifre.Name = "Text_Sifre";
            this.Text_Sifre.PasswordChar = '*';
            this.Text_Sifre.Size = new System.Drawing.Size(141, 20);
            this.Text_Sifre.TabIndex = 2;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 210);
            this.Controls.Add(this.Text_Sifre);
            this.Controls.Add(this.Text_Ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Giris);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Giris;
        private System.Windows.Forms.TextBox Text_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Sifre;
    }
}