using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENTİTYPROJECTAPP
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBL_KATEGORİ.ToList(); //LİSTELE
            dataGridView1.DataSource = kategoriler; 
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            TBL_KATEGORİ t = new TBL_KATEGORİ();
            t.AD = textBox2.Text;
            db.TBL_KATEGORİ.Add(t);//EKLE
            db.SaveChanges(); //değişiklik kaydet
            MessageBox.Show("Kategori eklendi");
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBL_KATEGORİ.Find(x);  //id değerini bul
            db.TBL_KATEGORİ.Remove(ktgr);  //onu tablodan sil
            db.SaveChanges(); // değişikliği kaydet.
            MessageBox.Show("Kategori silindi");
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBL_KATEGORİ.Find(x);  //id değerini bul
            ktgr.AD=textBox2.Text; //tablodan ad kısmını textboxta değer göre güncelle
            db.SaveChanges(); //değişikliği kaydet.
            MessageBox.Show("Güncelleme yapıldı.");
        }
    }
}
