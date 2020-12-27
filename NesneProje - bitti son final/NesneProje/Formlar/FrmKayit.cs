using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NesneProje.Classes.tekilSiniflar;
using NesneProje.Formlar;

namespace NesneProje
{
    public partial class FrmKayit : Form
    {
        private int a;

        // yeni kayıt olan kullanıcı için combobox elementine market adlarını ekleyen fonksiyon
        public FrmKayit(int a)
        {
            InitializeComponent();
            foreach (var market in frmAnasayfa.Markets)
            {
                cmbMarket.Items.Add(market.MarketAd);
            }

            this.a = a; // gerekli işleme yönlendirecek değişken
        }

        
        private YeniKayit yeniKayit;

        // admin tarafından onaylanacak olan çalışan için combobox elementine market adlarını ekleyen fonksiyon
        public FrmKayit(int a,YeniKayit yeniKayit)
        {
            InitializeComponent();
            foreach (var market in frmAnasayfa.Markets)
            {
                cmbMarket.Items.Add(market.MarketAd);
            }

            this.a = a;
            this.yeniKayit = yeniKayit;
        }
       
        FrmAnasayfa frmAnasayfa = (FrmAnasayfa)Application.OpenForms["FrmAnasayfa"];
      

        // yeni kayıt oluşturan & yeni kayıt onaylayan fonksiyon
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            
            if (textAdres.Text!="") // adresi kontrol eder
            {
                if (a==0) // yeni kullanıcı tarafından yeni kayıt oluşturalacağı zaman çalışacak olan kod bloğu
                {
                    frmAnasayfa.YeniKayits.Add(new YeniKayit{Ad = textAd.Text,Adres = textAdres.Text,İstedigiMaas = Convert.ToInt32(textMaas.Text),İstedigiPozisyon = cmbPozisyon.SelectedItem.ToString()});
                    if (MessageBox.Show("Kaydınız alındı") == DialogResult.OK)
                    {
                        frmAnasayfa.panelCalistir(new FrmGiris());
                    }
                }else if (a==2 || a==3) // admin tarafından eklenen/onaylanan çalışan durumunda çalışacak kod bloğu
                {
                    int id=0;
                    Random random = new Random();
                    var baslangic = DateTime.Now;
                    foreach (var market in frmAnasayfa.Markets)
                    {
                        foreach (var calisan in market.calisanListele())
                        {
                            if (id <= calisan.KullaniciID)
                            {
                                id = calisan.KullaniciID + 1;
                            }
                        }
                    }
                    foreach (var Market in frmAnasayfa.Markets)
                    {
                        if (Market.MarketAd == cmbMarket.SelectedItem.ToString())
                        {
                            Market.calisanEkle(textAd.Text, textAdres.Text, cmbPozisyon.SelectedItem.ToString(), Convert.ToInt32(textMaas.Text), Convert.ToInt32(random.Next(1, 7)), 14, Market.MarketID, baslangic, null, null, id, Market.MarketAd);
                            if (MessageBox.Show("Kayıt Edildi")==DialogResult.OK)
                            {
                                this.Close();
                            }
                            break;
                        }
                    }
                }
            }
            else // adres yoksa alarm vermek için çalışan kod bloğu
            {
                if (a==0)
                {
                    MessageBox.Show("Kaydınız İptal Edildi");
                    frmAnasayfa.toolStripButtonGeri.PerformClick();
                }
                else
                {
                    MessageBox.Show("Adres boş bırakılamaz");
                }
            }
        }

        // Yeni kayıt formu içeriğini dolduran fonksiyon
        private void FrmKayit_Load(object sender, EventArgs e)
        {
            
            if (frmAnasayfa.YeniKayits == null) // yeni kayıt listesi boşsa, yeni kayıt listesini oluşturur
            {
                frmAnasayfa.YeniKayits = new List<YeniKayit>();
            }
            if (a==0) // yeni kullanıcı için
            {
                btnKayıt.Text = "Kayıt ol";
                cmbMarket.Visible = false;
                label6.Visible = false;
            }else if (a==2) // onaylancak kaydın verilerini çeker ve ekrana yazdırır
            {
                btnKayıt.Text = "onayla";
                lblmesaj.Visible = true;
                textAd.Text = yeniKayit.Ad;
                textAdres.Text = yeniKayit.Adres;
                textMaas.Text = yeniKayit.İstedigiMaas.ToString();
                cmbPozisyon.SelectedItem = yeniKayit.İstedigiPozisyon;
                frmAnasayfa.YeniKayits.Remove(yeniKayit);
            }
        }

        // Maaş inputuna sadece integer deger girilmesini sağlar
        private void textMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
