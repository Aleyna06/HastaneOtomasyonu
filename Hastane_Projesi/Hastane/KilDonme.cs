using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Hastane
{
    public class KilDonme : HastalikCesidiAbstraction
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
                komut.CommandText = "insert into Hasta(HastaAdi,HastaSoyadi,HastaTCKNO,Hastalik,CiltYontemi,CiltKremi,CiltIlaci,CiltAmeliyati) values('" + base.KisiAd + "','" + base.KisiSoyad + "','" + base.KisiTCKNO + "','Kıl Dönmesi','" + cilt.CiltTedavi() + "','" + cilt.CiltKremi() + "','" + cilt.CiltIlaci() + "','" + cilt.CiltAmeliyati() + "')";

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                System.Windows.Forms.MessageBox.Show("Cildiye Hasta Bilgileri Kaydedildi.");
            }
            else if (deger == 1)
            {
                komut.CommandText = "update Hasta set Hastalik='Kıl Dönmesi',CiltYontemi='" + cilt.CiltTedavi() + "',CiltKremi='" + cilt.CiltKremi() + "',CiltIlaci='" + cilt.CiltIlaci() + "',CiltAmeliyati='" + cilt.CiltAmeliyati() + "' where HastaTCKNO=" + base.KisiTCKNO + "";

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                System.Windows.Forms.MessageBox.Show("Cildiye Hasta Bilgileri Güncellendi.");
            }
        }
    }
}
