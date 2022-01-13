using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class HareketliYasam : OrtopediYontemi
    {
        public override string OrtopediTedavi()
        {
            return "HareketliYasam";
        }

        public override string Sargi()
        {
            string SargiAciklama = "Üçgen sargı (BANDAJ)";
            return SargiAciklama;
        }

        public override string OrtopediIlaci()
        {
            string IlacAciklama = "Günde 2 kere Viskosuplemantasyon İğnesi ";
            return IlacAciklama;
        }

        public override string OrtopediAmeliyati()
        {
            string AmeliyatAciklama = "Ameliyat Yok";
            return AmeliyatAciklama;
        }        
    }
}
