using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    class Baglan
    {
        public SqlConnection baglanti = new SqlConnection("Integrated Security=SSPI;" + "Initial Catalog = odevcsharp;" + "Data Source=localhost;");
        public SqlCommand cmd = new SqlCommand();
        public bool baglan()
        {
            try
            {
                baglanti.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public  void baglantiKapat()
        {
            try
            {
                baglanti.Close();
            }
            catch
            {

            }
        }

    }
}
