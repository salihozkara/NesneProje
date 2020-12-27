using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.Classes
{
    public class Indırım
    {

        public double IndirimOrani { get; set; } // "25" = %25
    
        public string UrunGrubu { get; set; }
        public DateTime Tarih { get; set; } // YYYY-MM-GG

        public Indırım()
        {
            Tarih=new DateTime();
        }

    }
}
