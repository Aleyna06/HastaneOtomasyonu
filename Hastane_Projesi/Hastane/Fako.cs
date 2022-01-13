using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class Fako : GozYontemi
    {
        public override string GozTedavi()
        {
            return "Fako";
        }

        public override string Gozluk()
        {
            string GozlukAciklama = "R: 0.50 ,L:0.75 Yakın/Uzak  Gözlük";
            return GozlukAciklama;
        }

        public override string GozDamlasi()
        {
            string GozDamlasiAciklama = "Günde 2 kere Refresh Göz damlası sür ";
            return GozDamlasiAciklama;
        }

        public override string GozAmeliyati()
        {
            string AmeliyatAciklama = "Ameliyat Yok ";
            return AmeliyatAciklama;
        }
    }
}
