using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class Lasik : GozYontemi
    {
        public override string GozTedavi()
        {
            return "Lasik";
        }

        public override string Gozluk()
        {
            string GozlukAciklama = "R:1 ,l:0.75 Yakın/Uzak Gözlük ";
            return GozlukAciklama;
        }

        public override string GozDamlasi()
        {
            string GozDamlasiAciklama = "Tobrex Göz Damlası Günde 3 Kere ";
            return GozDamlasiAciklama;
        }

        public override string GozAmeliyati()
        {
            string AmeliyatAciklama = "Excimer Operasyonu";
            return AmeliyatAciklama;
        }
    }
}