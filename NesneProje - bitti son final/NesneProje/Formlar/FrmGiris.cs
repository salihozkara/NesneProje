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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        Admin admin=new Admin();
        FrmAnasayfa frmAnasayfa = (FrmAnasayfa)Application.OpenForms["FrmAnasayfa"];

        // Kullanıcı giriş butonuna tıkladığında giriş bilgilerini kontrol edip yönlendiren fonksiyon
        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmAnasayfa.FormList.Clear();
            bool a = true;
            if (txtNick.Text == admin.kullaniciAdi)
            {
                a = false;
                if (txtSifre.Text == admin.sifre)
                {
                    frmAnasayfa.panelCalistir(new FrmAdminPanel());
                    frmAnasayfa.toolStripButtonCikis.Visible = true;
                }
                else
                {
                    MessageBox.Show("hatalı şifre");
                }
            }

            //  kontrolleri sağlayan foreach döngüsü
            foreach (var market in frmAnasayfa.Markets)
            {
                foreach (var calisan in market.calisanListele())
                {
                
                    if (txtNick.Text==calisan.KullaniciAdi)
                    {
                        a = false;
                        if (txtSifre.Text==calisan.Sifre)
                        {
                            switch (calisan.Pozisyon)
                            {
                                case "Müdür":
                                    frmAnasayfa.panelCalistir(new FrmUrunler(market,calisan.Pozisyon));
                                    frmAnasayfa.toolStripButtonCikis.Visible = true;
                                    break;
                                case "Müdür Yardımcısı":
                                    MessageBox.Show("yetkiniz yok");
                                    break;
                                case "Kasiyer":
                                    MessageBox.Show("yetkiniz yok");
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("hatalı şifre");
                            break;
                        }
                    }
                }
            }

            if (a)
            {
                MessageBox.Show("bulunamadı");
            }
        }

        // enter tuşu ile buton girişine tıklama fonksiyonunu çalıştıran fonksiyon
        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }

        // Kayıt sayfasına yönlendiren fonksiyon
        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmAnasayfa.panelCalistir(new FrmKayit(0));
            frmAnasayfa.FormList.Add(this.Name);
        }

        // Çıkış butonunu gizleyen fonksiyon
        private void FrmGiris_Load(object sender, EventArgs e)
        {
            frmAnasayfa.toolStripButtonCikis.Visible = false;
        }
    }
}
