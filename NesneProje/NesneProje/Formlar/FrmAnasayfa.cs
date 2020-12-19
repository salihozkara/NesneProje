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

namespace NesneProje.Formlar
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        FrmAdminPanel frmAdmin = new FrmAdminPanel();
        public Form Form { get; set; }
        public int BoyutWidht { get; set; }
        public int BoyutHeight { get; set; }
        public bool Kontrol { get; set; }
        public List<string> FormList { get; set; }
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            FormList=new List<string>();
            BoyutHeight = 229;
            BoyutWidht = 373;
            
            Form = frmAdmin;
            BoyutHeight = frmAdmin.Height;
            BoyutWidht = frmAdmin.Width;
            Kontrol = true;
            timer1.Start();
        }
        public void PaneleEkle(Form form)//ilk formdaki panele formları ekleyerek işlem yap
        {
            panel1.Controls.Clear();//panelden önceki formu sil
            form.TopLevel = false;
            //form.Top = 20;
            panel1.Controls.Add(form);//formu panele ekle
            form.Show();//formu göster
            form.Dock = DockStyle.Fill;//formun panelin tamamını kapsaması
            form.BringToFront();//formu panelde ön plana çıkart
            this.ClientSize=new Size(BoyutWidht,BoyutHeight);
            this.Kontrol = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Kontrol)
            {
                PaneleEkle(Form);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (FormList.Count!=0)
            {
                Form formdon= Application.OpenForms[FormList[FormList.Count-1]];
                FormList.RemoveAt(FormList.Count-1);
                this.Form = formdon;
                BoyutWidht = formdon.Width;
                BoyutHeight= formdon.Height;
                Kontrol = true;
            }
        }
    }
}
