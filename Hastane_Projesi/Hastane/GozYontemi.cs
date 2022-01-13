using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public abstract class GozYontemi
    {
        public abstract string GozTedavi();
        public abstract string Gozluk();        
        public abstract string GozDamlasi();
        public abstract string GozAmeliyati();
    }
}
