using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Hastane
{
    public class Fitik : HastalikCesidiAbstraction
    {
        OleDbConnection baglanti;
        OleDbCommand komut;
        public override void Hastalik()
        {
            komut = new OleDbCommand();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:/Users/Aleyna/Desktop/Hastane_Projesi/Hastane.accdb");
            komut.Connection = baglanti;

            int deger = base.KullaniciKontrol();
            if (deger == 0)
            {
                komut.CommandText = "insert into Hasta(HastaAdi,HastaSoyadi,HastaTCKNO,Hastalik,OrtopediYontemi,Sargi,OrtopediIlaci,OrtopediAmeliyati) values('" + base.KisiAd + "','" + base.KisiSoyad + "','" + base.KisiTCKNO + "','Fıtık','" + ortopedi.OrtopediTedavi() + "','" + ortopedi.Sargi() + "','" + ortopedi.OrtopediIlaci() + "','" + ortopedi.OrtopediAmeliyati() + "')";

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                System.Windows.Forms.MessageBox.Show("Ortopedi Hasta Bilgileri Kaydedildi.");
            }
            else if (deger == 1)
            {
                komut.CommandText = "update Hasta set Hastalik='Fıtık',OrtopediYontemi='" + ortopedi.OrtopediTedavi() + "' where HastaTCKNO=" + base.KisiTCKNO + "";

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                System.Windows.Forms.MessageBox.Show("Ortopedi Hasta Bilgileri Güncellendi.");
            }
        }
    }
}
