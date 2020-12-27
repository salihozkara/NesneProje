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
using NesneProje.Classes.tekilSiniflar;
using NesneProje.Formlar;

namespace NesneProje
{
    public partial class FrmMarketler : Form
    {
        FrmAnasayfa frmAnasayfa = (FrmAnasayfa)Application.OpenForms["FrmAnasayfa"];
        Market market;
        public FrmMarketler()
        {
            InitializeComponent();
        }

        // market veirlerini çeker ve dataGrid e yazdırır.
        private void FrmMarketler_Load(object sender, EventArgs e)
        {
            foreach (var a in frmAnasayfa.Markets)
            {
                DataGVMarket.Rows.Add(a.MarketAd, a.MarketAdres, "Çalışanları Görüntüle", "Ürünleri görüntüle",a.MarketID);
            }
            DataGVMarket.ClearSelection();
        }

        // Tıklanan butona göre yönlendirme yapar (çalışanlar/ürünler)
        private void DataGVMarket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGVMarket.ClearSelection();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                foreach (var market in frmAnasayfa.Markets)
                {
                    if (market.MarketID == Convert.ToInt32(DataGVMarket.Rows[e.RowIndex].Cells[4].Value))
                    {
                       this.market = market;
                    }
                }
                if (e.ColumnIndex == 2)
                {
                    frmAnasayfa.panelCalistir(new FrmCalisanlar(market));
                    frmAnasayfa.FormList.Add(this.Name);
                }
                else if (e.ColumnIndex == 3)
                {
                    frmAnasayfa.panelCalistir(new FrmUrunler(market, "Yönetici"));
                    frmAnasayfa.FormList.Add(this.Name);
                }
            }
        }
    }
}
