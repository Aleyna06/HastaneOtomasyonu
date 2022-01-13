using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class Leke : CiltYontemi
    {
        public override string CiltTedavi()
        {
            return "Leke";
        }

        public override string CiltKremi()
        {
            string KremAciklama = "Günde 4 kere Madecassol Kremi ve günde 1 kere yatmadan önce Fito Kremi lekeli bölgeye uygula. ";
            return KremAciklama;
        }

        public override string CiltIlaci()
        {
            string IlacAciklama = " Günde 1 kere yüzünü yıkadıktan sonra  Skin Ceuticals C E Ferulic serumunu  sür ve haftada 2 kere  Nuxe Splendieuse Anti-Dark Spot Perfecting Maskesini yap.     ";
             return IlacAciklama;
        }

        public override string CiltAmeliyati()
        {
            string AmeliyatAciklama = " İlaç ve Krem tedavisinden sonra karar verilecektir. ";
            return AmeliyatAciklama;
        }
    }
}
