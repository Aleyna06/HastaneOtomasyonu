using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class RaporYonetimi
    {
        private Rapor rapor;
        public RaporYonetimi(Rapor r)
        {
            this.rapor = r;
        }
        public string DiyetisyenOlustur()
        {
            string cikti = rapor.DiyetCiktiOlustur();
            return cikti;
        }
        public string CildiyeOlustur()
        {
            string cikti = rapor.CiltCiktiOlustur();
            return cikti;
        }

        public string GozOlustur()
        {
            string cikti = rapor.GozCiktiOlustur();
            return cikti;
        }

        public string OrtopediOlustur()
        {
            string cikti = rapor.OrtopediCiktiOlustur();
            return cikti;
        }
        public string TerstenDiyetOlustur()
        {
            string cikti = rapor.TerstenDiyetCiktiOlustur();
            return cikti;
        }

        public string TerstenCiltOlustur()
        {
            string cikti = rapor.TerstenCiltCiktiOlustur();
            return cikti;
        }

        public string TerstenGozOlustur()
        {
            string cikti = rapor.TerstenGozCiktiOlustur();
            return cikti;
        }

        public string TerstenOrtopediOlustur()
        {
            string cikti = rapor.TerstenOrtopediCiktiOlustur();
            return cikti;
        }
    }
}
