using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NesneProje.Classes;
using NesneProje.Formlar;

namespace NesneProje
{
    public class Market
    {
        public string MarketAd { get; set; }
        public string MarketAdres { get; set; }
        public int MarketID { get; set; }

        private List<Urun> uruns;
        private List<Calisan> calisans;
        public Market()
        {
            uruns = new List<Urun>();
            calisans = new List<Calisan>();
        }
        public void UrunEkle(string urunGrubu, int stok, int fiyat, double IndimliFiyat, int marketId,string urunAd,Indırım indirim)
        {
            uruns.Add(new Urun { UrunGrubu = urunGrubu, Fiyat = fiyat, IndirimliFiyat = IndimliFiyat, MarketID = marketId, Stok = stok ,UrunAd = urunAd,Indirim=indirim});
        }

        public List<Urun> UrunListele()
        {
            return uruns;
        }
        
        public void calisanEkle(string ad, string adres, string pozisyon, int maas, int h_izin, int y_izin, int marketID, DateTime baslanGicTarihi, string kullaniciAdi, string sifre, int kullaniciID,string marketAd)
        {
            calisans.Add(new Calisan { Ad = ad, Adres = adres, BaslangicTarihi = baslanGicTarihi, HaftalikIzin = h_izin, KullaniciAdi = kullaniciAdi, Sifre = sifre, KullaniciID = kullaniciID, Maas = maas, MarketID = marketID, Pozisyon = pozisyon, YillikIzin = y_izin,MarketAD = marketAd});
        }

        public List<Calisan> calisanListele()
        {
            return calisans;
        }

        public void CalisanGuncelle(int kullaniciId,int yeniMaas, string yeniPozisyon, string yeniMarketAD,List<Market> markets)
        {
            foreach (var calisan in calisanListele())
            {
                if (calisan.KullaniciID == kullaniciId)
                {
                    calisan.Pozisyon = yeniPozisyon;
                    foreach (var market in markets)
                    {
                        if (market.MarketAd == yeniMarketAD)
                        {
                            calisan.MarketID = market.MarketID;
                            calisan.MarketAD = yeniMarketAD;
                            calisans.Remove(calisan);
                            market.calisans.Add(calisan);
                            break;
                        }
                    }
                    if (yeniMaas >= calisan.Maas)
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
