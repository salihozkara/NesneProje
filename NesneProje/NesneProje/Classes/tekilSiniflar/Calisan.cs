using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    class Calisan
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public int Pozisyon { get; set; }
        public int Maas { get; set; }
        public int HaftalikIzin { get; set; }
        public int YillikIzin { get; set; }
        public int KullaniciID { get; set; }
        public int MarketID { get; set; }
        public DateTime BaslangicTarihi { get; set; } // YYYY-MM-GG
        //------------------------------------------------------------------------
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
