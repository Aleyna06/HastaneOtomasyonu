using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class Doku : CiltYontemi
    {
        public override string CiltTedavi()
        {
            return "Doku";
        }

        public override string CiltKremi()
        {
            string KremAciklama ="Günde 1 kere Conraxtubex krem sür  ve Sabah Akşam 1 kere Silverdin kerem sür  ";
            return KremAciklama;
        }

        public override string CiltIlaci()
        {
            string IlacAciklama ="Günde 1 kere TR-JEL Steril Yanık Pansuman Sprey Jeli 120 ml";
            return IlacAciklama;
        }

        public override string CiltAmeliyati()
        {
            string AmeliyatAciklama ="İlgili dokunun yanık izi tedavisi ";
            return AmeliyatAciklama;
        }
    }
}
