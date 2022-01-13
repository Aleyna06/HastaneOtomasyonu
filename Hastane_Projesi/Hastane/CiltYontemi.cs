using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public abstract class CiltYontemi
    {
        public abstract string CiltTedavi();
        public abstract string CiltKremi();
        public abstract string CiltIlaci();
        public abstract string CiltAmeliyati();
    }
}
