using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.Classes.tekilSiniflar
{
    // SQL veritabanındaki verileri güncellemeye yarayan sınıf
    class DatalariGuncelle
    {
        Baglan baglan=new Baglan();

        public void CalisanGuncelle(Calisan m)
        {
            baglan.baglan();
            baglan.cmd.Connection = baglan.baglanti;
            
                baglan.cmd.CommandText = "UPDATE Kullanicilar set Pozisyon='" + m.Pozisyon + "',Maas='" + m.Maas + "',MarketID='" + m.MarketID + "',MarketAd='" + m.MarketAD + "' where KullaniciID='" + m.KullaniciID + "'";
                baglan.cmd.ExecuteNonQuery();
            
            baglan.baglantiKapat();
        }

        public void IndirimGuncelle(Urun urun)
        {
            baglan.baglan();
            baglan.cmd.Connection = baglan.baglanti;
            baglan.cmd.CommandText = "UPDATE Urunler set IndirimliFiyat='" + urun.IndirimliFiyat +"',SonIndirimTarihi='" + urun.Indirim.Tarih.ToString("yyyy-MM-dd") + "' where UrunAd='" + urun.UrunAd + "'";
            baglan.cmd.ExecuteNonQuery();
            baglan.baglantiKapat();
        }
    }
}
