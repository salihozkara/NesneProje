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
using NesneProje.Classes.CogulSiniflar;

namespace NesneProje.Formlar
{
    public partial class FrmCalisanlar : Form
    {
        public FrmCalisanlar(int marketID,string marketAdi,List<Market> markets)
        {
            InitializeComponent();
            MarketID = marketID;
            MarketAdi = marketAdi;
            Markets = markets;
        }

        public int MarketID { get; set; }
        public string MarketAdi { get; set; }

        public List<Market> Markets { get; set; }
        Calisanlar calisanlar=new Calisanlar();
        Baglan baglan = new Baglan();
        private void FrmCalisanlar_Load(object sender, EventArgs e)
        {
            ColumnPozisyon.Items.Add("kasiyer");
            ColumnPozisyon.Items.Add("Müdür Yardımcısı");
            ColumnPozisyon.Items.Add("Müdür");
            listele();
        }
        void listele()
        {
            if (baglan.baglan())
            {
                baglan.cmd.Connection = baglan.baglanti;
                baglan.cmd.CommandText = ("SELECT * FROM Kullanicilar");
            }
            SqlDataReader dr = baglan.cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["Pozisyon"])==3)
                {
                    continue;
                }
                calisanlar.calisanEkle(dr["Ad"].ToString(),dr["Adres"].ToString(),Convert.ToInt32(dr["Pozisyon"]),Convert.ToInt32(dr["Maas"]),Convert.ToInt32(dr["HaftalikIzin"]),Convert.ToInt32(dr["YillikIzin"]),Convert.ToInt32(dr["MarketID"]),Convert.ToDateTime(dr["BaslangicTarihi"]),dr["KullaniciAdi"].ToString(),dr["Sifre"].ToString(),Convert.ToInt32(dr["KUllaniciID"]));
            }
            baglan.baglantiKapat();

            foreach (var market in Markets)
            {
                ColumnMarket.Items.Add(market.MarketAd);
            }

            gridDoldur(date);
        }


        DateTime date = DateTime.Now.Date;
        private void gridDoldur(DateTime date)
        {
            foreach (var a in calisanlar.Listele(MarketID))
            {
                string pozisyon = "";
                var calistigiSure = date - a.BaslangicTarihi;
                switch (Convert.ToInt32(a.Pozisyon))
                {
                    case 0:
                        pozisyon = "kasiyer";
                        break;
                    case 1:
                        pozisyon = "Müdür Yardımcısı";
                        break;
                    case 2:
                        pozisyon = "Müdür";
                        break;
                    default:
                        break;
                }

                dataGVCalisanlar.Rows.Add(a.Ad, a.Adres, calistigiSure.Days + " gün", MarketAdi, pozisyon, a.Maas,
                    a.HaftalikIzin, a.YillikIzin, a.KullaniciID, a.MarketID, "Güncelle");
            }

            dataGVCalisanlar.ClearSelection();
        }

        private void dataGVCalisanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show(dataGVCalisanlar.Rows[e.RowIndex].Cells[5].Value.ToString());
                calisanlar.maasDegistir(Convert.ToInt32(dataGVCalisanlar.Rows[e.RowIndex].Cells[8].Value),MarketID, Convert.ToInt32(dataGVCalisanlar.Rows[e.RowIndex].Cells[5].Value));
                dataGVCalisanlar.Rows.Clear();
                Thread.Sleep(1000);
                gridDoldur(date);
            }
        }
    }
}

