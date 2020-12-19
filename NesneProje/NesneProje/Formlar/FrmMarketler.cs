using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NesneProje.Classes;
using NesneProje.Formlar;

namespace NesneProje
{
    public partial class FrmMarketler : Form
    {
        public FrmMarketler()
        {
            InitializeComponent();
        }
        Baglan baglan=new Baglan();
        Marketlerim marketlerim = new Marketlerim();
        private void FrmMarketler_Load(object sender, EventArgs e)
        {
            if (baglan.baglan())
            {
                baglan.cmd.Connection = baglan.baglanti;
                baglan.cmd.CommandText = ("SELECT * FROM dbo.Market");
            }
            SqlDataReader dr = baglan.cmd.ExecuteReader();
            while (dr.Read())
            {
                marketlerim.MarketEkle(dr["Ad"].ToString(), dr["Adres"].ToString(),dr["MarketID"].ToString());
            }
            baglan.baglantiKapat();
            foreach (var a in marketlerim.MarketListele())
            {
                DataGVMarket.Rows.Add(a.MarketAd, a.MarketAdres, "Çalışanları Görüntüle", "Ürünleri görüntüle",a.MarketID);
            }
            DataGVMarket.ClearSelection();
        }

     
        
        private void DataGVMarket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    FrmCalisanlar frmCalisanlar = new FrmCalisanlar(Convert.ToInt32(DataGVMarket.Rows[e.RowIndex].Cells[4].Value),DataGVMarket.Rows[e.RowIndex].Cells[0].Value.ToString(),marketlerim.MarketListele());
                    FrmAnasayfa frmAnasayfa = (FrmAnasayfa)Application.OpenForms["FrmAnasayfa"];
                    frmAnasayfa.Form = frmCalisanlar;
                    frmAnasayfa.BoyutWidht = frmCalisanlar.Width;
                    frmAnasayfa.BoyutHeight = frmCalisanlar.Height;
                    frmAnasayfa.Kontrol = true;
                    frmAnasayfa.FormList.Add(this.Text);
                }
                else if (e.ColumnIndex == 3)
                {
                    FrmUrunler frmUrunler = new FrmUrunler(Convert.ToInt32(DataGVMarket.Rows[e.RowIndex].Cells[4].Value));
                    FrmAnasayfa frmAnasayfa = (FrmAnasayfa)Application.OpenForms["FrmAnasayfa"];
                    frmAnasayfa.Form = frmUrunler;
                    frmAnasayfa.BoyutWidht = frmUrunler.Width;
                    frmAnasayfa.BoyutHeight = frmUrunler.Height;
                    frmAnasayfa.Kontrol = true;
                    frmAnasayfa.FormList.Add(this.Text);
                }
            }
        }
    }
}
