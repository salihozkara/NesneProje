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
    public partial class FrmTedarikciler : Form
    {

        // tedarikçileri listeler
        public FrmTedarikciler()
        {
            InitializeComponent();
            FrmAnasayfa frmAnasayfa = (FrmAnasayfa)Application.OpenForms["FrmAnasayfa"];
            foreach (var tedarikci in frmAnasayfa.Tedarikcis)
            {
                string[] item = {tedarikci.Grup, tedarikci.Adres};
                listViewTedarikcs.Items.Add(new ListViewItem(item));
            }
        }
    }
}
