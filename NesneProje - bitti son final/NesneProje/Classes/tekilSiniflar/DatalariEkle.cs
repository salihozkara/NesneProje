using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.Classes.tekilSiniflar
{

    // SQL veritabanından verileri çeken sınıf
    class DatalariEkle
    {
        Baglan baglan = new Baglan();

        public void tumEkle(Market market)
        {
            CalisanEkle(market);
            UrunEkle(market);
        }

        public void tumMarketlereEkle(List<Market> markets)
        {
            foreach (var market in markets)
            {
                tumEkle(market);
            }
        }
        public void MarketEkle(List<Market> market)
        {
            if (baglan.baglan())
            {
                baglan.cmd.Connection = baglan.baglanti;
                baglan.cmd.CommandText = ("SELECT * FROM dbo.Market");
            }
            SqlDataReader dr = baglan.cmd.ExecuteReader();
            while (dr.Read())
            {
                market.Add(new Market{MarketAd = dr["Ad"].ToString(),MarketAdres = dr["Adres"].ToString(),MarketID = Convert.ToInt32(dr["MarketID"])});
            }
            baglan.baglantiKapat();
           
        }

        public void CalisanEkle(Market market)
        {
            if (baglan.baglan())
            {
                baglan.cmd.Connection = baglan.baglanti;
                baglan.cmd.CommandText = ("SELECT * FROM Kullanicilar where MarketID='" + market.MarketID + "'");
            }
            SqlDataReader dr = baglan.cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Pozisyon"].ToString()=="Yönetici")
                {
                    continue;
                }
                market.calisanEkle(
                    dr["Ad"].ToString(),
                    dr["Adres"].ToString(), 
                    dr["Pozisyon"].ToString(),
                    Convert.ToInt32(dr["Maas"]),
                    Convert.ToInt32(dr["HaftalikIzin"]),
                    Convert.ToInt32(dr["YillikIzin"]), 
                    Convert.ToInt32(dr["MarketID"]),
                    Convert.ToDateTime(dr["BaslangicTarihi"]), 
                    dr["KullaniciAdi"].ToString(), 
                    dr["Sifre"].ToString(), 
                    Convert.ToInt32(dr["KUllaniciID"]),
                    dr["MarketAD"].ToString());
            }
            baglan.baglantiKapat();
        }

        public void UrunEkle(Market market)
        {
            if (baglan.baglan())
            {
                baglan.cmd.Connection = baglan.baglanti;
                baglan.cmd.CommandText = ("SELECT * FROM Urunler where MarketID='" + market.MarketID + "'");
            }
            SqlDataReader dr = baglan.cmd.ExecuteReader();
            while (dr.Read())
            {
                double indirim=0;
                if (dr["IndirimliFiyat"] == DBNull.Value)
                {
                    indirim = Convert.ToDouble(dr["Fiyat"]);
                }
                else
                {
                    indirim = Convert.ToDouble(dr["IndirimliFiyat"]);
                }

                Indırım i=new Indırım();
                if (dr["SonIndirimTarihi"]!=DBNull.Value)
                {
                    i.Tarih = Convert.ToDateTime(dr["SonIndirimTarihi"]);
                    i.UrunGrubu = dr["UrunGrubu"].ToString();
                }
               
                market.UrunEkle(dr["UrunGrubu"].ToString(), Convert.ToInt32(dr["Stok"]), Convert.ToInt32(dr["Fiyat"]), indirim, Convert.ToInt32(dr["MarketID"]),dr["UrunAd"].ToString(),i);
            }
            baglan.baglantiKapat();
        }
        public void TedarikciEkle( List<Tedarikci> tedarikcis)
        {
            if (baglan.baglan())
            {
                baglan.cmd.Connection = baglan.baglanti;
                baglan.cmd.CommandText = ("SELECT * FROM Tedarikciler");
            }
            SqlDataReader dr = baglan.cmd.ExecuteReader();
            while (dr.Read())
            {
                tedarikcis.Add(new Tedarikci{Adres = dr["Adres"].ToString(), Grup = dr["Grup"].ToString()});
            }
            baglan.baglantiKapat();
        }
    }
}
