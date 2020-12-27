using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NesneProje.Classes.tekilSiniflar;

namespace NesneProje.Formlar
{
    public partial class FrmCalisanlar : Form
    {
        // anasayfadaki verileri kullanmamızı sağlayan fonksiyon
        
        private Market m; // çalışanları listelenecek olan marketin verisini tutan değişken
        FrmAnasayfa frmAnasayfa = (FrmAnasayfa)Application.OpenForms["FrmAnasayfa"];

        // bilgisi alınacak marketi değişkene atar
        public FrmCalisanlar(Market market)
        {
            InitializeComponent();
            m= market;
        }

        // pozisyon belirleme fonkisyonu
        private void FrmCalisanlar_Load(object sender, EventArgs e)
        {
            ColumnPozisyon.Items.Add("Kasiyer");
            ColumnPozisyon.Items.Add("Müdür Yardımcısı");
            ColumnPozisyon.Items.Add("Müdür");
            listele();
        }

        // çalışanları listeleyen fonksiyon
        void listele()
        {
            foreach (var market in frmAnasayfa.Markets)
            {
                ColumnMarket.Items.Add(market.MarketAd);
            }
            gridDoldur(date);
        }

        // çalışan verilerini datagrid elementine aktaran fonksiyon
        DateTime date = DateTime.Now.Date;
        private void gridDoldur(DateTime date)
        {
            foreach (var a in m.calisanListele())
            {
                var calistigiSure = date - a.BaslangicTarihi;

                string haftalikIzin = "";
                switch (a.HaftalikIzin)
                {
                    case 1:
                        haftalikIzin = "Pazartesi";
                        break;
                    case 2:
                        haftalikIzin = "Salı";
                        break;
                    case 3:
                        haftalikIzin = "Çarşamba";
                        break;
                    case 4:
                        haftalikIzin = "Perşembe";
                        break;
                    case 5:
                        haftalikIzin = "Cuma";
                        break;
                    case 6:
                        haftalikIzin = "Cumartesi";
                        break;
                    case 7:
                        haftalikIzin = "Pazar";
                        break;
                }

                dataGVCalisanlar.Rows.Add(a.Ad, a.Adres, calistigiSure.Days + " gün", a.MarketAD, a.Pozisyon, a.Maas,
                    haftalikIzin, a.YillikIzin, a.KullaniciID, a.MarketID, "Güncelle");
            }

            dataGVCalisanlar.ClearSelection();
        }

        // Çalışan verilerini güncellemeye yarayan fonksiyonlar
        private void dataGVCalisanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Calisan c;
                foreach (var calisan in m.calisanListele())
                {
                    if (calisan.KullaniciID == Convert.ToInt32(dataGVCalisanlar.Rows[e.RowIndex].Cells[8].Value))
                    {
                        c = calisan;
                        m.CalisanGuncelle(c.KullaniciID, Convert.ToInt32(dataGVCalisanlar.Rows[e.RowIndex].Cells[5].Value), dataGVCalisanlar.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGVCalisanlar.Rows[e.RowIndex].Cells[3].Value.ToString(), frmAnasayfa.Markets);
                        DatalariGuncelle dtg = new DatalariGuncelle();
                        dtg.CalisanGuncelle(c);
                        dataGVCalisanlar.Rows.Clear();
                        gridDoldur(date);
                        break;
                    }
                }
            }
        }
    }
}

