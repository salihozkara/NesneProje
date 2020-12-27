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

namespace NesneProje.Formlar
{
    public partial class FrmUrunler : Form
    {
        //  ilgili marketin verilerini tutacak değişken
        private Market m;
        public FrmUrunler(Market m,string pozisyon)
        {
            InitializeComponent();
            this.m = m;
            if (pozisyon=="Müdür") // Müdür pozisyonundaki kullanıcının haftalık kampanya ürünlerini görebilmesini sağlar
            {
                cmbUrunGrup.Items.Clear();
                cmbUrunGrup.Items.Add("Haftalık Kampanya");
            }
        }

        // form yüklendiğinde listele fonksiyonunu cagırır
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        // ürün verileri ile dataGrid elementini doldurur
        void listele()
        {
           dataGVUrunler.Rows.Clear();
            foreach (var a in m.UrunListele())
            {
                string tarih;
                if (a.Indirim.Tarih==DateTime.MinValue)
                {
                    tarih = "";
                }
                else
                {
                    tarih = a.Indirim.Tarih.ToLongDateString();
                }
                dataGVUrunler.Rows.Add(a.UrunAd,a.UrunGrubu,a.Stok,a.Fiyat,a.IndirimliFiyat,tarih);
            }
            dataGVUrunler.ClearSelection();
        }

        // Seçilen ürün grubuna indirim uygulamaya yarayan fonksiyon
        private void btnIndirim_Click(object sender, EventArgs e)
        {
            DatalariGuncelle dt=new DatalariGuncelle();
            foreach (var urun in m.UrunListele())
            {
                if (urun.UrunGrubu==cmbUrunGrup.SelectedItem.ToString())
                {
                    urun.Indirim.Tarih= DateTime.Now.Date;
                    urun.Indirim.UrunGrubu = cmbUrunGrup.SelectedItem.ToString();
                    urun.Indirim.IndirimOrani = Convert.ToDouble(maskedTxtOran.Text);
                    urun.IndirimliFiyat = urun.Fiyat-urun.Fiyat* (urun.Indirim.IndirimOrani/100);
                    dt.IndirimGuncelle(urun);
                }
            }
            listele();
        }

    }
}
