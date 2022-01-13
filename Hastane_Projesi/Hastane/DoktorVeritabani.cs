using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Hastane
{
    public class DoktorVeritabani
    {
        OleDbConnection Baglanti;
        OleDbCommand komut;
        OleDbDataReader dr;
        public DoktorVeritabani(OleDbConnection baglanti)
        {
            this.Baglanti = baglanti;
            Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:/Users/Aleyna/Desktop/Hastane_Projesi/Hastane.accdb");
        }

        public void DoktorGiris(int TCKNO, int SIFRE)
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = Baglanti;
            OleDbDataReader dr;
            Baglanti.Open();

            komut.CommandText = "select DoktorTCKNO,DoktorSifre,DoktorBolum from Doktor where DoktorTCKNO=" + TCKNO + " and DoktorSifre=" + SIFRE + "";
            dr = komut.ExecuteReader();

            if (dr.Read()) //eğer doktor varsa
            {
                if (dr[2].ToString() == "Diyetisyen")
                {
                    System.Windows.Forms.MessageBox.Show("Giriş işlemi başarılı diyetisyen hasta işlemleri sayfanıza yönlendiriliyorsunuz.");
                    FrmDiyetisyen df = new FrmDiyetisyen();
                    df.DTckNo = TCKNO;
                    df.Show();
                }
                else if (dr[2].ToString() == "Goz")
                {
                    System.Windows.Forms.MessageBox.Show("Giriş işlemi başarılı göz hasta işlemleri sayfanıza yönlendiriliyorsunuz.");
                    FrmGoz gf = new FrmGoz();
                    gf.GTckNo = TCKNO;
                    gf.Show();
                }
                else if (dr[2].ToString() == "Cildiye")
                {
                    System.Windows.Forms.MessageBox.Show("Giriş işlemi başarılı cildiye hasta işlemleri sayfanıza yönlendiriliyorsunuz.");
                    FrmCildiye cf = new FrmCildiye();
                    cf.CTckNo = TCKNO;
                    cf.Show();
                }
                else if (dr[2].ToString() == "Ortopedi")
                {
                    System.Windows.Forms.MessageBox.Show("Giriş işlemi başarılı ortopedi hasta işlemleri sayfanıza yönlendiriliyorsunuz.");
                    FrmOrtopedi of = new FrmOrtopedi();
                    of.OTckNo = TCKNO;
                    of.Show();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Doktor bölümünü boş bıraktınız..!");
                }
            }
            else
                System.Windows.Forms.MessageBox.Show("Kayıtlı böyle bir doktor bulunamadı..!");
            Baglanti.Close();
        }

        //Diyetisyen Ekleme İşlemleri
        public void DoktorEkle(string DoktorAd, string DoktorSoyad, int DoktorTCKNO, int DoktorSifre, string DoktorBolum)
        {
            int kayitlimi = 0;

            komut = new OleDbCommand();
            komut.Connection = Baglanti;
            Baglanti.Open();
            komut.CommandText = "select DoktorTCKNO,DoktorSifre from Doktor where DoktorTCKNO=" + DoktorTCKNO + " AND  DoktorSifre=" + DoktorSifre + "";
            dr = komut.ExecuteReader();

            if (dr.Read())//diyetisyen bulunduysa kayıtlı demektir.
                kayitlimi = 1;

            Baglanti.Close();

            if (kayitlimi == 1)//1'e eşitse kayıtlı demektir.
            {
                System.Windows.Forms.MessageBox.Show("\nKayıt etmek istediğiniz doktorunuz zaten kayıtlı.\n");
            }
            else //Kayıtlı değilse kayıt et
            {
                komut = new OleDbCommand();
                komut.Connection = Baglanti;
                Baglanti.Open();

                komut.CommandText = "insert into Doktor(DoktorAd,DoktorSoyad,DoktorTCKNO,DoktorSifre,DoktorBolum) values('" + DoktorAd + "','" + DoktorSoyad + "', '" + DoktorTCKNO + "','" + DoktorSifre + "','" + DoktorBolum + "')";
                komut.ExecuteNonQuery();
                Baglanti.Close();

                System.Windows.Forms.MessageBox.Show("Doktorunuzun kaydı başarıyla yapıldı.");
            }
        }       
    }
}
