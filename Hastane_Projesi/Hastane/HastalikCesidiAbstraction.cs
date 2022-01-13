using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Hastane
{
    public abstract class HastalikCesidiAbstraction
    {
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataReader dr;

        private string kisiad;
        private string kisisoyad;
        private int kisitcno;

        public string KisiAd { get { return kisiad; } set { this.kisiad = value; } }
        public string KisiSoyad { get { return kisisoyad; } set { this.kisisoyad = value; } }
        public int KisiTCKNO { get { return kisitcno; } set { this.kisitcno = value; } }

        public DiyetYontemi diyet;
        public CiltYontemi cilt;
        public GozYontemi goz;
        public OrtopediYontemi ortopedi;

        public abstract void Hastalik();
        protected int KullaniciKontrol()
        {
            //Veritabanında girilen kullanıcı adı var mı diye kontrol et varsa 1 yoksa 0 döndür
            int deger = 0;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:/Users/Aleyna/Desktop/Hastane_Projesi/Hastane.accdb");
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            baglanti.Open();

            komut.CommandText = "select * from Hasta where HastaTCKNO=" + KisiTCKNO + "";

            dr = komut.ExecuteReader();
            if (dr.Read())
                deger = 1;

            baglanti.Close();
            return deger;
        }
    }
}
