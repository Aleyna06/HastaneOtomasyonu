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
    public partial class FrmOrtopedi : Form
    {
        public FrmOrtopedi()
        {
            InitializeComponent();
        }

        public int OTckNo;

        private void FrmOrtopedi_Load(object sender, EventArgs e)
        {
            txtTckNo.Text = OTckNo.ToString();
        }

        private void btnOHastaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOHastalık.Text == "Kireçlenme")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Kireclenme();

                    hastalikcesidi.KisiAd = txtOHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtOHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtOHastaTckNo.Text);

                    if (cmbOrtopediYontemi.Text == "Protez")
                    {
                        hastalikcesidi.ortopedi = new Protez();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbOrtopediYontemi.Text == "Hareketli Yaşam")
                    {
                        hastalikcesidi.ortopedi = new HareketliYasam();
                        hastalikcesidi.Hastalik();
                        OrtopediTedaviBilgileri tedaviBilgileri = new OrtopediTedaviBilgileri();
                        tedaviBilgileri.Sargi = "Pasuman";
                    }
                    else if (cmbOrtopediYontemi.Text == "Ultrasonik Isıtma")
                    {
                        hastalikcesidi.ortopedi = new UltrasonikIsitma();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Ortopedi Yöntemi Seçiniz.");
                    }
                }
                else if (cmbOHastalık.Text == "Fıtık")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Fitik();

                    hastalikcesidi.KisiAd = txtOHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtOHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtOHastaTckNo.Text);

                    if (cmbOrtopediYontemi.Text == "Protez")
                    {
                        hastalikcesidi.ortopedi = new Protez();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbOrtopediYontemi.Text == "Hareketli Yaşam")
                    {
                        hastalikcesidi.ortopedi = new HareketliYasam();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbOrtopediYontemi.Text == "Ultrasonik Isıtma")
                    {
                        hastalikcesidi.ortopedi = new UltrasonikIsitma();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Ortopedi Yöntemi Seçiniz.");
                    }
                }
                else if (cmbOHastalık.Text == "Çıkık")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Cikik();

                    hastalikcesidi.KisiAd = txtOHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtOHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtOHastaTckNo.Text);

                    if (cmbOrtopediYontemi.Text == "Protez")
                    {
                        hastalikcesidi.ortopedi = new Protez();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbOrtopediYontemi.Text == "Hareketli Yaşam")
                    {
                        hastalikcesidi.ortopedi = new HareketliYasam();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbOrtopediYontemi.Text == "Ultrasonik Isıtma")
                    {
                        hastalikcesidi.ortopedi = new UltrasonikIsitma();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Ortopedi Yöntemi Seçiniz.");
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

        private void txtOHastaRprTckNo_TextChanged(object sender, EventArgs e)
        {
            btnOHastaRapor.Enabled = true;
        }

        private void btnOHastaRapor_Click(object sender, EventArgs e)
        {
            //dosya işlemleri için
            StreamWriter sw;
            string dosya = "";
            string metin = "";

            string raporcesidi = cmbORaporCesidi.Text;
            string raporonceligi = cmbORaporOnceligi.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=C:/Users/Aleyna/Desktop/Hastane_Projesi/Hastane.accdb");
            OleDbCommand komut = new OleDbCommand();
            OleDbDataReader dr;
            komut.Connection = baglanti;

            //raporu alınacak hastanın tckno numarasını gönder.
            int tckno = Convert.ToInt32(txtOHastaRprTckNo.Text);

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
                rb.OrtopediYontemi = dr[17].ToString();
                rb.Sargi = dr[18].ToString();
                rb.OrtopediIlaci = dr[19].ToString();
                rb.OrtopediAmeliyati = dr[20].ToString();
            }
            baglanti.Close();

            if (raporcesidi == "HTML")
            {
                Rapor rapor = new HtmlRapor(rb);
                RaporYonetimi raporyonetimi = new RaporYonetimi(rapor);
                if (raporonceligi == "Kişi Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.OrtopediOlustur();
                    dosya = @"C:/Users/Aleyna/Desktop/Hastane_Projesi/HtmlRapor.html";
                }
                else if (raporonceligi == "Hastalık Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.TerstenOrtopediOlustur();
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
