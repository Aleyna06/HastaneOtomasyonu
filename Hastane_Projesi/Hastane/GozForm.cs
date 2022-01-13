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
    public partial class FrmGoz : Form
    {
        public FrmGoz()
        {
            InitializeComponent();
        }

        public int GTckNo;
        private void FrmGoz_Load(object sender, EventArgs e)
        {
            txtTckNo.Text = GTckNo.ToString();
        }

        private void btnGHastaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGHastalık.Text == "Miyop")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Miyop();

                    hastalikcesidi.KisiAd = txtGHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtGHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtGHastaTckNo.Text);

                    if (cmbGozYontemi.Text == "Lazer")
                    {
                        hastalikcesidi.goz = new Lazer();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbGozYontemi.Text == "Fako")
                    {
                        hastalikcesidi.goz = new Fako();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbGozYontemi.Text == "Lasik")
                    {
                        hastalikcesidi.goz = new Lasik();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Göz Yöntemi Seçiniz.");
                    }
                }
                else if (cmbGHastalık.Text == "Hipermetrop")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Hipermetrop();

                    hastalikcesidi.KisiAd = txtGHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtGHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtGHastaTckNo.Text);

                    if (cmbGozYontemi.Text == "Lazer")
                    {
                        hastalikcesidi.goz = new Lazer();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbGozYontemi.Text == "Fako")
                    {
                        hastalikcesidi.goz = new Fako();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbGozYontemi.Text == "Lasik")
                    {
                        hastalikcesidi.goz = new Lasik();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Goz Yöntemi Seçiniz.");
                    }
                }
                else if (cmbGHastalık.Text == "Astigmat")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Astigmat();
                    hastalikcesidi.KisiAd = txtGHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtGHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtGHastaTckNo.Text);

                    if (cmbGozYontemi.Text == "Lazer")
                    {
                        hastalikcesidi.goz = new Lazer();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbGozYontemi.Text == "Fako")
                    {
                        hastalikcesidi.goz = new Fako();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbGozYontemi.Text == "Lasik")
                    {
                        hastalikcesidi.goz = new Lasik();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Goz Yöntemi Seçiniz.");
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

        private void txtGHastaRprTckNo_TextChanged(object sender, EventArgs e)
        {
            btnGHastaRapor.Enabled = true;
        }

        private void btnGHastaRapor_Click(object sender, EventArgs e)
        {
            //dosya işlemleri için
            StreamWriter sw;
            string dosya = "";
            string metin = "";

            string raporcesidi = cmbGRaporCesidi.Text;
            string raporonceligi = cmbGRaporOnceligi.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=C:/Users/Aleyna/Desktop/Hastane_Projesi/Hastane.accdb");
            OleDbCommand komut = new OleDbCommand();
            OleDbDataReader dr;
            komut.Connection = baglanti;

            //raporu alınacak hastanın tckno numarasını gönder.
            int tckno = Convert.ToInt32(txtGHastaRprTckNo.Text);

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
                rb.GozYontemi = dr[13].ToString();
                rb.Gozluk = dr[14].ToString();
                rb.GozDamlasi = dr[15].ToString();
                rb.GozAmeliyati = dr[16].ToString();
            }
            baglanti.Close();

            if (raporcesidi == "HTML")
            {
                Rapor rapor = new HtmlRapor(rb);
                RaporYonetimi raporyonetimi = new RaporYonetimi(rapor);
                if (raporonceligi == "Kişi Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.GozOlustur();
                    dosya = @"C:/Users/Aleyna/Desktop/Hastane_Projesi/HtmlRapor.html";
                }
                else if (raporonceligi == "Hastalık Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.TerstenGozOlustur();
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
