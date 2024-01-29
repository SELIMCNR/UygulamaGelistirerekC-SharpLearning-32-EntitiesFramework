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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = db.TBL_URUN.ToList();
          dataGridView1.DataSource = (from x in db.TBL_URUN select new
          {
              x.URUNID,
              x.URUNAD,
              x.MARKA,
              x.STOK,
              x.FİYAT,
              x.TBL_KATEGORİ.AD,
              x.DURUM
          }).ToList();
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            TBL_URUN t = new TBL_URUN();
            t.URUNAD = Text_Urnad.Text;
            t.MARKA = Text_Marka.Text;
            t.STOK =short.Parse( Text_Stok.Text);
            t.KATEGORİ = int.Parse(comboBox1.SelectedValue.ToString());
            t.FİYAT = decimal.Parse(Text_Fıyat.Text);
            t.DURUM = true;
            db.TBL_URUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün eklendi");

        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(Text_ID.Text);
            var urun = db.TBL_URUN.Find(x);
            db.TBL_URUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi");
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Text_ID.Text);
            var urun = db.TBL_URUN.Find(x);
            urun.URUNAD = Text_Urnad.Text;
            urun.STOK = short.Parse(Text_Stok.Text);
            urun.MARKA = Text_Marka.Text;
            urun.FİYAT = decimal.Parse( Text_Fıyat.Text);

            db.SaveChanges();
            MessageBox.Show("Ürün güncellendi");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBL_KATEGORİ
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();

            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.Clear();
                }
            }

        }
    }
}
