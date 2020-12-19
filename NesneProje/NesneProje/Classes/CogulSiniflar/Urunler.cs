using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.Classes
{
    class Urunler
    {
        private List<Urun> uruns;

        public Urunler()
        {
            uruns = new List<Urun>();
        }

        public void UrunEkle(string urunGrubu, int stok,int fiyat,int IndimliFiyat,int marketId)
        {
            uruns.Add(new Urun{UrunGrubu = urunGrubu,Fiyat = fiyat,IndirimliFiyat = IndimliFiyat,MarketID = marketId,Stok = stok});
        }

        public List<Urun> UrunListele(int marketID)
        {
            List<Urun> urunlList=new List<Urun>();
            foreach (var urun in uruns)
            {
                if (urun.MarketID==marketID)
                {
                    urunlList.Add(urun);
                }
            }

            return urunlList;
        }
    }
}
