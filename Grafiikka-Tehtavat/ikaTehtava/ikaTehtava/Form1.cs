using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikaTehtava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Nappula_Click(object sender, EventArgs e)
        {
            //Määritetään muuttujat
            DateTime nyt;
            DateTime synttarit;

            //"The actual code"
            nyt = DateTime.Now;
            synttarit = Pvm.Value;

            //Vuodet
            double vastaus1 = Math.Round((nyt - synttarit).TotalDays);
            Vuosi.Text = Math.Ceiling(vastaus1 / 365.25) + "Vuotta";
            Vuosi.Visible = true;

            //Kuukaudet
            double vastaus2 = Math.Round((nyt - synttarit).TotalDays);
            kuukausi.Text = Math.Ceiling(vastaus2 * 12 / 365.25) + "Kuukautta";
            kuukausi.Visible = true;

            //Päivät
            double vastaus3 = Math.Round((nyt - synttarit).TotalDays);
            Päivä.Text = vastaus3 + "Päivää";
            Päivä.Visible = true;

            //Tunnit
            double vastaus4 = Math.Round((nyt - synttarit).TotalHours);
            Tunti.Text = vastaus4 + "Tuntia";
            Tunti.Visible = true;

            //Minuutit
            double vastaus5 = Math.Round((nyt - synttarit).TotalMinutes);
            Minuutti.Text = vastaus5 + "Minuuttia";
            Minuutti.Visible = true;

            //Sekunnit
            double vastaus6 = Math.Round((nyt - synttarit).TotalSeconds);
            Sekunti.Text = vastaus6 + "Sekuntia";
            Sekunti.Visible = true;
        }
    }
}
