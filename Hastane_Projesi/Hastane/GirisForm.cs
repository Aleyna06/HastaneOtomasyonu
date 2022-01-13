using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hastane
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        
        public void Kontrol()
        {
            int tckno = Convert.ToInt32(txtGirisTckNo.Text);
            int sifre = Convert.ToInt32(txtGirisSifre.Text);


            if ((tckno == 11111) && (sifre == 123))//bashekim girişi
            {
                FrmBashekim af = new FrmBashekim();
                af.Show();
            }
            else //doktor kontrolu yap. tcno ve şifre uyumlu ise ilgili doktor  ekranına geçiş yap.
            {
                DoktorVeritabani vt = new DoktorVeritabani(baglanti);  //doktorveritabanına erişim sağlıyo              
                vt.DoktorGiris(tckno, sifre);
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kontrol(); //yukarıdaki fonksiyonu çağırdık
        }
    }
}
