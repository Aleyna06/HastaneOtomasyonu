using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public abstract class Rapor
    {
        protected RaporBilgisi raporbilgisi;
        public Rapor(RaporBilgisi rb)
        {
            this.raporbilgisi = rb;
        }
        public abstract string KisiBilgileriOlustur();
        public abstract string DiyetBilgileriOlustur();
        public abstract string CiltBilgileriOlustur();
        public abstract string GozBilgileriOlustur();
        public abstract string OrtopediBilgileriOlustur();

        public string DiyetCiktiOlustur()
        {
            string cikti = KisiBilgileriOlustur();
            cikti += DiyetBilgileriOlustur()+CiltBilgileriOlustur()+GozBilgileriOlustur()+OrtopediBilgileriOlustur();
            return cikti;
        }
        public string CiltCiktiOlustur()
        {
            string cikti = KisiBilgileriOlustur();
            cikti += CiltBilgileriOlustur();
            return cikti;
        }

        public string GozCiktiOlustur()
        {
            string cikti = KisiBilgileriOlustur();
            cikti += GozBilgileriOlustur();
            return cikti;
        }

        public string OrtopediCiktiOlustur()
        {
            string cikti = KisiBilgileriOlustur();
            cikti += OrtopediBilgileriOlustur();
            return cikti;
        }

        public string TerstenDiyetCiktiOlustur()
        {
            string cikti = DiyetBilgileriOlustur();
            cikti += KisiBilgileriOlustur();
            return cikti;
        }

        public string TerstenCiltCiktiOlustur()
        {
            string cikti = CiltBilgileriOlustur();
            cikti += KisiBilgileriOlustur();
            return cikti;
        }

        public string TerstenGozCiktiOlustur()
        {
            string cikti = GozBilgileriOlustur();
            cikti += KisiBilgileriOlustur();
            return cikti;
        }

        public string TerstenOrtopediCiktiOlustur()
        {
            string cikti = OrtopediBilgileriOlustur();
            cikti += KisiBilgileriOlustur();
            return cikti;
        }
    }
}
