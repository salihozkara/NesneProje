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

namespace NesneProje.Formlar
{
    public partial class FrmAnasayfa : Form
    {
        // veritabanından verileri sınıflara çeker
        DatalariEkle dtEkle=new DatalariEkle();

        // listeler ilgili oldukları verileri tutar
        public List<Market> Markets { get; set; }
        public List<Tedarikci> Tedarikcis { get; set; }
        public List<YeniKayit> YeniKayits { get; set; }
        public List<string> FormList { get; set; }
        public FrmAnasayfa()
        {
            // property lere ilgili oldukları classların listesi atanır
            InitializeComponent();
            Markets = new List<Market>();
            Tedarikcis=new List<Tedarikci>();
            YeniKayits=new List<YeniKayit>();
            // veri listesinin içeriğini doldurur
            dtEkle.MarketEkle(Markets);
            dtEkle.tumMarketlereEkle(Markets);
            dtEkle.TedarikciEkle(Tedarikcis);
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            // formların adını tutar (previous page)
            FormList =new List<string>();
            panelCalistir(new FrmGiris());
        }

        // önceki sayfaya dönüş fonksiyonu
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (FormList.Count!=0)
            {
                panelCalistir(Application.OpenForms[FormList[FormList.Count - 1]]);
                FormList.RemoveAt(FormList.Count - 1);
            }
        }

        // bütün formları tek bir formda görüntüleyebilmemizi sağlayan fonksiyon
        public void panelCalistir(Form form)
        {
            int boyutWidht = form.Width;
            int boyutHeight = form.Height + 27;
            panel1.Controls.Clear();//panelden önceki formu sil
            form.TopLevel = false; 
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);//formu panele ekle
            form.Show();//formu göster
            form.Dock = DockStyle.Fill;//formun panelin tamamını kapsaması
            form.BringToFront();//formu panelde ön plana çıkart
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.ClientSize = new Size(boyutWidht, boyutHeight);
            }
            toolStripLabel1.Text = form.Text;
        }

        // Çıkış yapma fonksiyonu
        private void toolStripButtonCikis_Click(object sender, EventArgs e)
        {
            panelCalistir(Application.OpenForms["FrmGiris"]);
            toolStripButtonCikis.Visible = false;
        }
    }
}
