using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    class Marketlerim
    {
        private List<Market> markets;

        public Marketlerim()
        {
            markets = new List<Market>();
        }

        public void MarketEkle(string marketAd, string marketAdres,string marketID)
        {
            markets.Add(new Market { MarketAd = marketAd, MarketAdres = marketAdres, MarketID = marketID});
        }

        public List<Market> MarketListele()
        {
            return markets;
        }
    }
}
