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
using NesneProje.Formlar;

namespace NesneProje
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMarketler frmMarketler=new FrmMarketler();
            FrmAnasayfa frmAnasayfa = (FrmAnasayfa)Application.OpenForms["FrmAnasayfa"];
            frmAnasayfa.Form = frmMarketler;
            frmAnasayfa.BoyutWidht = frmMarketler.Width;
            frmAnasayfa.BoyutHeight = frmMarketler.Height;
            frmAnasayfa.Kontrol = true;
            frmAnasayfa.FormList.Add(this.Text);
        }
    }
}
