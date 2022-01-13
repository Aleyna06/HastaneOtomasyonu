using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class Lazer : GozYontemi
    {
        public override string GozTedavi()
        {
            return "Lazer";
        }

        public override string Gozluk()
        {
            string GozlukAciklama = " Gözlük Yok ";
            return GozlukAciklama;
        }

        public override string GozDamlasi()
        {
            string GozDamlasiAciklama = "Optane Göz damlası Günde 4 kere sür ";
            return GozDamlasiAciklama;
        }

        public override string GozAmeliyati()
        {
            string AmeliyatAciklama = "Göz Çizdirme Operasyonu";
            return AmeliyatAciklama;
        }
    }
}
