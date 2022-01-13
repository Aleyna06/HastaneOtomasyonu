using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public abstract class OrtopediYontemi
    {
        public abstract string OrtopediTedavi();
        public abstract string Sargi();
        public abstract string OrtopediIlaci();
        public abstract string OrtopediAmeliyati();
    }
}
