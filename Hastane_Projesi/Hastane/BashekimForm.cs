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
    public partial class FrmBashekim : Form
    {
        public FrmBashekim()
        {
            InitializeComponent();
        }       

        private void btnDoktorKaydet_Click(object sender, EventArgs e)
        {
                DoktorEkle de = new DoktorEkle();
                de.DoktorAd = txtDoktorAd.Text;
                de.DoktorSoyad = txtDoktorSoyad.Text;
                de.TCNO = Convert.ToInt32(txtDoktorTckNo.Text);
                de.Sifre = Convert.ToInt32(txtDoktorSifre.Text);
                de.DoktorBolum = cmbDoktorBolum.Text; 

                de.DoktorKaydet();
        }
    }
}
