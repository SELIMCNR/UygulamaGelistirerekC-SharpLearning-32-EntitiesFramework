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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBL_ADMİN where x.KULLANICI == Text_Ad.Text && x.ŞİFRE == Text_Sifre.Text select x;
            if (sorgu.Any())
            {
                FrmAnaform fr = new FrmAnaform();
                fr .Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş.");
            }
        }
    }
}
