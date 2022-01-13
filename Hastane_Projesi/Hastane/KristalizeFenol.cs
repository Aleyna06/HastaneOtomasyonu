using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class KristalizeFenol : CiltYontemi
    {
        public override string CiltTedavi()
        {
            return "KristalFenol";
        }

        public override string CiltKremi()
        {
            string KremAciklama = "ilgili bölgeye günde 2 kere expigment krem sür ";
            return KremAciklama;
        }

        public override string CiltIlaci()
        {
            string IlacAciklama = "Günde 1 kere Majezik Ağrı kesici  ";
            return IlacAciklama;
        }

        public override string CiltAmeliyati()
        {
            string AmeliyatAciklama = "Ameliyat Yoktur";
            return AmeliyatAciklama;
        }
    }
}
