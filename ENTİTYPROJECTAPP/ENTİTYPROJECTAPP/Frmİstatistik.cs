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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            Lbl_Kategori.Text = db.TBL_KATEGORİ.Count().ToString();
            Lbl_Ürün.Text = db.TBL_URUN.Count().ToString(); 
            Lbl_Aktif.Text= db.TBL_MUSTERİ.Count(x => x.DURUM==true).ToString();
            Lbl_Pasif.Text = db.TBL_MUSTERİ.Count(x => x.DURUM==false).ToString();
            Lbl_Stok.Text = db.TBL_URUN.Sum(y => y.STOK).ToString();
            Lbl_KasadakiTutar.Text = db.TBL_URUN.Sum(Z => Z.FİYAT).ToString()+" TL ";
            Lbl_Enyüksekfyt.Text = (from x in db.TBL_URUN orderby x.FİYAT descending select x.URUNAD).FirstOrDefault();
            Lbl_Endüsükfyt.Text = (from x in db.TBL_URUN orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault();
            Lbl_BeyazEsya.Text = db.TBL_URUN.Count(x => x.KATEGORİ == 1).ToString();
            lbl.Text = db.TBL_URUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            Lbl_Sehir.Text =(from x in db.TBL_MUSTERİ select x.SEHIR).Distinct().Count().ToString();
            lbl_marka.Text = db.MARKAGETIR().FirstOrDefault();
        }
    }
}
