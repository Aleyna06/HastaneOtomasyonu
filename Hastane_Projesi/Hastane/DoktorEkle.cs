using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Hastane
{
    public class DoktorEkle
    {
        private string doktorad;
        private string doktorsoyad;
        private int doktorsifre;
        private int doktortckno;
        private string doktorbolum;

        public string DoktorAd { get { return doktorad; } set { this.doktorad = value; } }
        public string DoktorSoyad { get { return doktorsoyad; } set { this.doktorsoyad = value; } }
        public int Sifre { get { return doktorsifre; } set { this.doktorsifre = value; } }
        public int TCNO { get { return doktortckno; } set { this.doktortckno = value; } }
        public string DoktorBolum {get { return doktorbolum; } set { this.doktorbolum = value; } }

        OleDbConnection baglanti;
        

        public void DoktorKaydet()
        {
            DoktorVeritabani vt = new DoktorVeritabani(baglanti);
            vt.DoktorEkle(doktorad, doktorsoyad, doktortckno, doktorsifre, doktorbolum);
        }
    }
}
