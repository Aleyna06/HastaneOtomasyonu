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
    public partial class FrmDiyetisyen : Form
    {
        public FrmDiyetisyen()
        {
            InitializeComponent();
        }

        public int DTckNo;

        private void FrmDiyetisyen_Load(object sender, EventArgs e)
        {
            txtTckNo.Text = DTckNo.ToString();
        }

        private void btnDHastaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDHastalık.Text == "Obez")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Obez();

                    hastalikcesidi.KisiAd = txtDHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtDHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtDHastaTckNo.Text);

                    if (cmbDiyetYontemi.Text == "Akdeniz")
                    {
                        hastalikcesidi.diyet = new Akdeniz();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbDiyetYontemi.Text == "Gluten Free")
                    {
                        hastalikcesidi.diyet = new GlutenFree();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbDiyetYontemi.Text == "Deniz Urunleri")
                    {
                        hastalikcesidi.diyet = new DenizUrunleri();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbDiyetYontemi.Text == "Yesillikler Dunyasi")
                    {
                        hastalikcesidi.diyet = new YesilliklerDunyasi();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Diyet Yöntemi Seçiniz.");
                    }
                }
                else if (cmbDHastalık.Text == "Colyak")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Colyak();

                    hastalikcesidi.KisiAd = txtDHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtDHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtDHastaTckNo.Text);

                    if (cmbDiyetYontemi.Text == "Akdeniz")
                    {
                        hastalikcesidi.diyet = new Akdeniz();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbDiyetYontemi.Text == "Gluten Free")
                    {
                        hastalikcesidi.diyet = new GlutenFree();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbDiyetYontemi.Text == "Deniz Urunleri")
                    {
                        hastalikcesidi.diyet = new DenizUrunleri();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbDiyetYontemi.Text == "Yesillikler Dunyasi")
                    {
                        hastalikcesidi.diyet = new YesilliklerDunyasi();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Diyet Yöntemi Seçiniz.");
                    }
                }
                else if (cmbDHastalık.Text == "Seker")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Seker();

                    hastalikcesidi.KisiAd = txtDHastaAd.Text;
                    hastalikcesidi.KisiSoyad = txtDHastaSoyad.Text;
                    hastalikcesidi.KisiTCKNO = Convert.ToInt32(txtDHastaTckNo.Text);

                    if (cmbDiyetYontemi.Text == "Akdeniz")
                    {
                        hastalikcesidi.diyet = new Akdeniz();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbDiyetYontemi.Text == "Gluten Free")
                    {
                        hastalikcesidi.diyet = new GlutenFree();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbDiyetYontemi.Text == "Deniz Urunleri")
                    {
                        hastalikcesidi.diyet = new DenizUrunleri();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmbDiyetYontemi.Text == "Yesillikler Dunyasi")
                    {
                        hastalikcesidi.diyet = new YesilliklerDunyasi();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Diyet Yöntemi Seçiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Hastalık Seçiniz..");
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Meydana Geldi.\nLütfen Sonra Tekrar Deneyiniz." + hata.Message);
            }
        }

        ////////////////// RAPOR KISMI  //////////////////////////////////////////////////////////////////////// 

        private void txtDHastaRprTckNo_TextChanged_1(object sender, EventArgs e)
        {
            btnDHastaRapor.Enabled = true;
        }

        private void btnDHastaRapor_Click_1(object sender, EventArgs e)
        {
            //dosya işlemleri için
            StreamWriter sw;
            string dosya = "";
            string metin = "";

            string raporcesidi = cmbDRaporCesidi.Text;
            string raporonceligi = cmbDRaporOnceligi.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=C:/Users/Aleyna/Desktop/Hastane_Projesi/Hastane.accdb");
            OleDbCommand komut = new OleDbCommand();
            OleDbDataReader dr;
            komut.Connection = baglanti;

            //raporu alınacak hastanın tcno numarasını gönder.
            int tckno = Convert.ToInt32(txtDHastaRprTckNo.Text);

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
                rb.DiyetYontemi = dr[5].ToString();
                rb.Kahvalti = dr[6].ToString();
                rb.OgleYemegi = dr[7].ToString();
                rb.AksamYemegi = dr[8].ToString();
            }
            baglanti.Close();

            if (raporcesidi == "HTML")
            {
                Rapor rapor = new HtmlRapor(rb);
                RaporYonetimi raporyonetimi = new RaporYonetimi(rapor);
                if (raporonceligi == "Kişi Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.DiyetisyenOlustur();
                    dosya = @"C:/Users/Aleyna/Desktop/Hastane_Projesi/HtmlRapor.html";
                }
                else if (raporonceligi == "Hastalık Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.TerstenDiyetOlustur();
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
