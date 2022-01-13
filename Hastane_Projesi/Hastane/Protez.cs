using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class Protez : OrtopediYontemi
    {
        public override string OrtopediTedavi()
        {
            return "Protez";
        }

        public override string Sargi()
        {
            string SargiAciklama = "Elastik Bandaj Uygulaması ";
            return SargiAciklama;
        }

        public override string OrtopediIlaci()
        {
            string IlacAciklama = "Günde 1 kere Paracetamol ";
            return IlacAciklama;
        }

        public override string OrtopediAmeliyati()
        {
            string AmeliyatAciklama = "Protez Ameliyatı ";
            return AmeliyatAciklama;
        }        
    }
}
