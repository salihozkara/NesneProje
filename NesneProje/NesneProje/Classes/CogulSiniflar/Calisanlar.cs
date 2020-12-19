using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.Classes.CogulSiniflar
{
    class Calisanlar
    {
        private List<Calisan> calisans;

        public Calisanlar()
        {
            calisans=new List<Calisan>();
        }

        public void calisanEkle(string ad,string adres,int pozisyon,int maas,int h_izin,int y_izin,int marketID,DateTime baslanGicTarihi,string kullaniciAdi,string sifre,int kullaniciID)
        {
            calisans.Add(new Calisan{Ad = ad,Adres = adres,BaslangicTarihi = baslanGicTarihi,HaftalikIzin = h_izin,KullaniciAdi = kullaniciAdi,Sifre = sifre,KullaniciID = kullaniciID,Maas = maas,MarketID = marketID,Pozisyon = pozisyon,YillikIzin = y_izin});
        }

        public List<Calisan> Listele(int marketID)
        {
            List<Calisan> calisanlList = new List<Calisan>();
            foreach (var calisan in calisans)
            {
                if (calisan.MarketID == marketID)
                {
                    calisanlList.Add(calisan);
                }
            }
            return calisanlList;
        }
        public void pozisyonDegistir(int kullaniciId, int marketID,int yeniPozisyon)
        {
            foreach (var calisan in Listele(marketID))
            {
                if (calisan.KullaniciID==kullaniciId)
                {
                    calisan.Pozisyon = yeniPozisyon;
                    break;
                }
            }
        }
        public void marketDegistir(int kullaniciId, int marketID, int yeniMarketID)
        {
            foreach (var calisan in Listele(marketID))
            {
                if (calisan.KullaniciID == kullaniciId)
                {
                    calisan.MarketID = yeniMarketID;
                    break;
                }
            }
        }
        public void maasDegistir(int kullaniciId, int marketID, int yeniMaas)
        {
            foreach (var calisan in Listele(marketID))
            {
                if (calisan.KullaniciID == kullaniciId)
                {
                    if (yeniMaas>=calisan.Maas)
                    {
                        calisan.Maas = yeniMaas;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("yeni maaş esksinden düşük olamaz");
                        break;
                    }
                }
            }
        }
    }
}
