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

namespace NesneProje.Formlar
{
    public partial class FrmUrunler : Form
    {
        private int marketID;
        public FrmUrunler(int marketID)
        {
            InitializeComponent();
            this.marketID = marketID;
        }
        Urunler urunler=new Urunler();
        Baglan baglan=new Baglan();
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            if (baglan.baglan())
            {
                baglan.cmd.Connection = baglan.baglanti;
                baglan.cmd.CommandText = ("SELECT * FROM Urunler");
            }
            SqlDataReader dr = baglan.cmd.ExecuteReader();
            while (dr.Read())
            {
                int indirim;
                if (dr["IndirimliFiyat"]==DBNull.Value)
                {
                    indirim = Convert.ToInt32(dr["Fiyat"]);
                }
                else
                {
                    indirim = Convert.ToInt32(dr["IndirimliFiyat"]);
                }
                urunler.UrunEkle(dr["UrunGrubu"].ToString(),Convert.ToInt32(dr["Stok"]),Convert.ToInt32(dr["Fiyat"]),indirim,Convert.ToInt32(dr["MarketID"]));
            }
            baglan.baglantiKapat();
            foreach (var a in urunler.UrunListele(marketID))
            {
                dataGVUrunler.Rows.Add(a.MarketID,a.UrunGrubu,a.Stok,a.Fiyat,a.IndirimliFiyat);
            }
            dataGVUrunler.ClearSelection();
        }
        
    }
}
