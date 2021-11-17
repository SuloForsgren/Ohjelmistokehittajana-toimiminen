using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kilometrikustannukset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, polttoaine, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            pesut = Convert.ToDouble(PesuTB.Text);
            huollot = Convert.ToDouble(HuoltoTB.Text);
            renkaat = Convert.ToDouble(RengasTB.Text);
            muut = Convert.ToDouble(MuutTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            polttoaine = Convert.ToDouble(PolttoaineTB.Text);
            kustannukset = Convert.ToDouble(laina + nesteet + vakuutus + pesut + huollot + renkaat + muut + polttoaine) / (kilometrit/12);
            VastausLB.Text = "Kaikkiaan kustannukset 1 kilometria kohden ovat: " + kustannukset;
            VastausLB.Visible = true;
        }
    }
}
