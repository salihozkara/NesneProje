using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.Classes
{
    public class Urun
    {
        public string UrunGrubu { get; set; } // "Gıda", "Temizlik", "Haftalık Kampanya"
        public int Stok { get; set; }
        public int Fiyat { get; set; }
        public int IndirimliFiyat { get; set; }
        public int MarketID { get; set; }
    }
}
