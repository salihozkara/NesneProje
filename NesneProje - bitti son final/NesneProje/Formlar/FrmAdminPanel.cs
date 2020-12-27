using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    
    public partial class FrmAdminPanel : Form
    {
        // FrmAnasayfa daki verileri manipüle edebilmemizi sağlar
        FrmAnasayfa frmAnasayfa = (FrmAnasayfa)Application.OpenForms["FrmAnasayfa"];
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        // Kayıt bildirimlerini gönderen fonksiyon
        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            if (frmAnasayfa.YeniKayits.Count == 0)
            {
                lblKayit.Visible = false;
            }
            else
            {
                lblKayit.Text = $"{frmAnasayfa.YeniKayits.Count} yeni kayıt var";
            }
        }

        // Marketler sayfasına yönlendiren fonksyion
        private void btnMarketler_Click(object sender, EventArgs e)
        {
            frmAnasayfa.panelCalistir(new FrmMarketler());
            frmAnasayfa.FormList.Add(this.Name);
        }

        // Tedarikçilçer sayfasına yönlendiren fonksiyon
        private void btnTedarikcilerlar_Click(object sender, EventArgs e)
        {
            frmAnasayfa.panelCalistir(new FrmTedarikciler());
            frmAnasayfa.FormList.Add(this.Name);
        }

        // Çalışan ekleme sayfasına yönlendiren fonksiyon
        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            FrmKayit frmKayit=new FrmKayit(3);
            frmKayit.ShowDialog();
        }
        
        // Yeni kayıtı onaylama formnu açan fonksiyon
        private void lblKayit_Click(object sender, EventArgs e)
        {
            while (frmAnasayfa.YeniKayits.Count!=0)
            {
                FrmKayit frm=new FrmKayit(2,frmAnasayfa.YeniKayits[0]);
                frm.ShowDialog();
            }
            lblKayit.Visible = false;
        }
    }
}
