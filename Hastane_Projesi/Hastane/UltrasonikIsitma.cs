using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class UltrasonikIsitma : OrtopediYontemi
    {
        public override string OrtopediTedavi()
        {
            return "UltrasonikIsitma";
        }

        public override string Sargi()
        {
            string SargiAciklama = "Rulo Sargı ";
            return SargiAciklama;
        }

        public override string OrtopediIlaci()
        {
            string IlacAciklama = "Gerektiğinde ağrı kesici alabilir ";
            return IlacAciklama;
        }

        public override string OrtopediAmeliyati()
        {
            string AmeliyatAciklama = "Ameliyat Yok";
            return AmeliyatAciklama;
        }
    }
}
