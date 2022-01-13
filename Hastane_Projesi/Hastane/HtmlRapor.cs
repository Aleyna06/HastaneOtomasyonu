using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    public class HtmlRapor : Rapor
    {
        public HtmlRapor(RaporBilgisi rb) : base(rb)
        { }

        public override string KisiBilgileriOlustur()
        {
            // veri tabanından kisisel bilgileri getir 
            // string bir değişkene aktar
            // değişkeni döndür
            string metin = string.Format("<h1>Kişi Bilgileri</h1>");

            metin += string.Format("<h3>Ad : {0}</h3>", this.raporbilgisi.Ad);
            metin += string.Format("<h3>Soyad : {0}</h3>", this.raporbilgisi.Soyad);
            metin += string.Format("<h3>TC Kimlik Numarası : {0}</h3>", this.raporbilgisi.TCKNO);

            return metin;
        }

        public override string DiyetBilgileriOlustur()
        {
            // veri tabanından diyet bilgileri getir 
            // string bir değişkene aktar
            // değişkeni döndür

            string metin = string.Format("<h1>Hastalık Bilgileri</h1>");

            metin += string.Format("<h3>Hastalık : {0}</h3>", this.raporbilgisi.Hastalik);
            metin += string.Format("<h3>Diyet Yöntemi : {0}</h3>", this.raporbilgisi.DiyetYontemi);
            metin += string.Format("<h3>Kahvaltı Menünüz : <br>{0}</h3>", this.raporbilgisi.Kahvalti);
            metin += string.Format("<h3>Öğle Yemeği Menünüz : <br>{0}</h3>", this.raporbilgisi.OgleYemegi);
            metin += string.Format("<h3>Akşam Yemeği Menünüz : <br>{0}</h3>", this.raporbilgisi.AksamYemegi);

            return metin;
        }

        public override string CiltBilgileriOlustur()
        {
            // veri tabanından cilt bilgileri getir 
            // string bir değişkene aktar
            // değişkeni döndür

            string metin = string.Format("<h1>Hastalık Bilgileri</h1>");

            metin += string.Format("<h3>Hastalık : {0}</h3>", this.raporbilgisi.Hastalik);
            metin += string.Format("<h3>Cilt Yöntemi : {0}</h3>", this.raporbilgisi.CiltYontemi);
            metin += string.Format("<h3>Cilt Kremi : <br>{0}</h3>", this.raporbilgisi.CiltKremi);
            metin += string.Format("<h3>Cilt İlacı : <br>{0}</h3>", this.raporbilgisi.CiltIlaci);
            metin += string.Format("<h3>Cilt Ameliyatı : <br>{0}</h3>", this.raporbilgisi.CiltAmeliyati);

            return metin;
        }

        public override string GozBilgileriOlustur()
        {
            // veri tabanından göz bilgileri getir 
            // string bir değişkene aktar
            // değişkeni döndür

            string metin = string.Format("<h1>Hastalık Bilgileri</h1>");

            metin += string.Format("<h3>Hastalık : {0}</h3>", this.raporbilgisi.Hastalik);
            metin += string.Format("<h3>Göz Yöntemi : {0}</h3>", this.raporbilgisi.GozYontemi);
            metin += string.Format("<h3>Gözlük : <br>{0}</h3>", this.raporbilgisi.Gozluk);
            metin += string.Format("<h3>Göz Damlası : <br>{0}</h3>", this.raporbilgisi.GozDamlasi);
            metin += string.Format("<h3>Göz Ameliyatı : <br>{0}</h3>", this.raporbilgisi.GozAmeliyati);

            return metin;
        }

        public override string OrtopediBilgileriOlustur()
        {
            // veri tabanından ortopedi bilgileri getir 
            // string bir değişkene aktar
            // değişkeni döndür

            string metin = string.Format("<h1>Hastalık Bilgileri</h1>");

            metin += string.Format("<h3>Hastalık : {0}</h3>", this.raporbilgisi.Hastalik);
            metin += string.Format("<h3>Ortopedi Yöntemi : {0}</h3>", this.raporbilgisi.OrtopediYontemi);
            metin += string.Format("<h3>Sargı : <br>{0}</h3>", this.raporbilgisi.Sargi);
            metin += string.Format("<h3>Ortopedi İlacı : <br>{0}</h3>", this.raporbilgisi.OrtopediIlaci);
            metin += string.Format("<h3>Ortopedi Ameliyatı : <br>{0}</h3>", this.raporbilgisi.OrtopediAmeliyati);

            return metin;
        }
    }
}
