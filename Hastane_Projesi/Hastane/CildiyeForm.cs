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
using System.IO;

namespace Hastane
{
    public partial class FrmCildiye : Form
    {
        public FrmCildiye()
        {
            InitializeComponent();
        }

        public int CTckNo;

        private void FrmCildiye_Load(object sender, EventArgs e)
        {
            txtTckNo.Text = CTckNo.ToString();
        }

        private void btnCHastaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCHastalık.Text == "Kıl Dönmesi")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new KilDonme();

                    hastalikcesidi.KisiAd = txtCHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtCHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtCHastaTckNo.Text);

                    if (cmbCiltYontemi.Text == "Leke")
                    {
                        hastalikcesidi.cilt = new Leke();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbCiltYontemi.Text == "Doku")
                    {
                        hastalikcesidi.cilt = new Doku();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbCiltYontemi.Text == "Kristalize Fenol")
                    {
                        hastalikcesidi.cilt = new KristalizeFenol();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Cilt Yöntemi Seçiniz.");
                    }
                }
                else if (cmbCHastalık.Text == "Yanık")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Yanik();

                    hastalikcesidi.KisiAd = txtCHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtCHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtCHastaTckNo.Text);

                    if (cmbCiltYontemi.Text == "Leke")
                    {
                        hastalikcesidi.cilt = new Leke();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbCiltYontemi.Text == "Doku")
                    {
                        hastalikcesidi.cilt = new Doku();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbCiltYontemi.Text == "Kristalize Fenol")
                    {
                        hastalikcesidi.cilt = new KristalizeFenol();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Cilt Yöntemi Seçiniz.");
                    }
                }
                else if (cmbCHastalık.Text == "Akne")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Akne();
                    hastalikcesidi.KisiAd = txtCHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtCHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtCHastaTckNo.Text);

                    if (cmbCiltYontemi.Text == "Leke")
                    {
                        hastalikcesidi.cilt = new Leke();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbCiltYontemi.Text == "Doku")
                    {
                        hastalikcesidi.cilt = new Doku();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbCiltYontemi.Text == "Kristalize Fenol")
                    {
                        hastalikcesidi.cilt = new KristalizeFenol();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Cilt Yöntemi Seçiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Bir Hastalık Seçiniz..");
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Meydana Geldi.\nLütfen Sonra Tekrar Deneyiniz." + hata.Message);
            }
        }

        private void txtCHastaRprTckNo_TextChanged(object sender, EventArgs e)
        {
            btnCHastaRapor.Enabled = true;
        }

        private void btnCHastaRapor_Click(object sender, EventArgs e)
        {
            //dosya işlemleri için
            StreamWriter sw;
            string dosya = "";
            string metin = "";

            string raporcesidi = cmbCRaporCesidi.Text;
            string raporonceligi = cmbCRaporOnceligi.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=C:/Users/Aleyna/Desktop/Hastane_Projesi/Hastane.accdb");
            OleDbCommand komut = new OleDbCommand();
            OleDbDataReader dr;
            komut.Connection = baglanti;

            //raporu alınacak hastanın tckno numarasını gönder.
            int tckno = Convert.ToInt32(txtCHastaRprTckNo.Text);

            RaporBilgisi rb = new RaporBilgisi();

            baglanti.Open();
            komut.CommandText = "select * from Hasta where HastaTCKNO=" + tckno + "";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //kişisel bilgiler
                rb.Ad = dr[1].ToString();
                rb.Soyad = dr[2].ToString();
                rb.TCKNO = Convert.ToInt32(dr[3]);

                //Hastalık bilgileri
                rb.Hastalik = dr[4].ToString();
                rb.CiltYontemi = dr[9].ToString();
                rb.CiltKremi = dr[10].ToString();
                rb.CiltIlaci = dr[11].ToString();
                rb.CiltAmeliyati = dr[12].ToString();
            }
            baglanti.Close();

            if (raporcesidi == "HTML")
            {
                Rapor rapor = new HtmlRapor(rb);
                RaporYonetimi raporyonetimi = new RaporYonetimi(rapor);
                if (raporonceligi == "Kişi Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.CildiyeOlustur();
                    dosya = @"C:/Users/Aleyna/Desktop/Hastane_Projesi/HtmlRapor.html";
                }
                else if (raporonceligi == "Hastalık Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.TerstenCiltOlustur();
                    dosya = @"C:/Users/Aleyna/Desktop/Hastane_Projesi/HtmlRapor.html";
                }
                else
                {
                    MessageBox.Show("Hiçbir Alan Boş Bırakılamaz...");
                }
            }
            else
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz...");
            }
            sw = new StreamWriter(dosya);
            sw.WriteLine(metin);
            sw.Close();
            MessageBox.Show("Rapor Oluşturuldu Klasorün İçine Bakınız..");
        }
    }
}
