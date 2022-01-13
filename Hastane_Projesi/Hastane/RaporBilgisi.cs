using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class RaporBilgisi
    {
        //kişisel bilgiler
        private string ad;
        private string soyad;
        private int tckno;

        //hastalik bilgileri
        private string hastalik;

        private string diyetyontemi;
        private string kahvalti;
        private string ogleyemegi;
        private string aksamyemegi;

        private string ciltyontemi;
        private string ciltkremi;
        private string ciltilaci;
        private string ciltameliyati;

        private string gozyontemi;
        private string gozluk;
        private string gozdamlasi;
        private string gozameliyati;

        private string ortopediyontemi;
        private string sargi;
        private string ortopediilaci;
        private string ortopediameliyati;

        //Kisi Bilgileri
        public string Ad { get { return ad; } set { this.ad = value; } }
        public string Soyad { get { return soyad; } set { this.soyad = value; } }
        public int TCKNO { get { return tckno; } set { this.tckno = value; } }

        //Hastalık Bilgileri
        public string Hastalik { get { return hastalik; } set { this.hastalik = value; } }

        public string DiyetYontemi { get { return diyetyontemi; } set { this.diyetyontemi = value; } }
        public string Kahvalti { get { return kahvalti; } set { this.kahvalti = value; } }
        public string OgleYemegi { get { return ogleyemegi; } set { this.ogleyemegi = value; } }
        public string AksamYemegi { get { return aksamyemegi; } set { this.aksamyemegi = value; } }

        public string CiltYontemi { get { return ciltyontemi; } set { this.ciltyontemi = value; } }
        public string CiltKremi { get { return ciltkremi; } set { this.ciltkremi = value; } }
        public string CiltIlaci { get { return ciltilaci; } set { this.ciltilaci = value; } }
        public string CiltAmeliyati { get { return ciltameliyati; } set { this.ciltameliyati = value; } }

        public string GozYontemi { get { return gozyontemi; } set { this.gozyontemi = value; } }
        public string Gozluk { get { return gozluk; } set { this.gozluk = value; } }
        public string GozDamlasi { get { return gozdamlasi; } set { this.gozdamlasi = value; } }
        public string GozAmeliyati { get { return gozameliyati; } set { this.gozameliyati = value; } }

        public string OrtopediYontemi { get { return ortopediyontemi; } set { this.ortopediyontemi = value; } }
        public string Sargi { get { return sargi; } set { this.sargi = value; } }
        public string OrtopediIlaci { get { return ortopediilaci; } set { this.ortopediilaci = value; } }
        public string OrtopediAmeliyati { get { return ortopediameliyati; } set { this.ortopediameliyati = value; } }
    }
}
