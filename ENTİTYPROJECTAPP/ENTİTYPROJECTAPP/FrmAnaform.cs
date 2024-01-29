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
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }

        private void Btn_Kategori_Click(object sender, EventArgs e)
        {
            FrmKategori frm = new FrmKategori();
            frm.Show();
        }

        private void Btn_Ürün_Click(object sender, EventArgs e)
        {
            FrmUrun fr = new FrmUrun();
            fr.Show();
        }

        private void Btn_İstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr = new Frmİstatistik();
            fr.Show();
        }
    }
}
