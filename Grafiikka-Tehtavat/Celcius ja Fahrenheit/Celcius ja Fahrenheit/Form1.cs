using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celcius_ja_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuutosBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double luku = Convert.ToDouble(AnnettuTB.Text);
            if (FahrenheitRBT.Checked == true)
            {
                vastaus = luku * 1.8 + 32;
                TulosLB.Text = luku + " Celsiusta On Fahrenheitteina " + vastaus + " Fahrenheittia";
                TulosLB.Visible = true;
            }
            else if (CelciusRBT.Checked == true)
            {
                vastaus = (luku - 32) / 1.8;
                TulosLB.Text = luku + " Fahrenheitia On celciuksina " + vastaus + " astetta";
                TulosLB.Visible = true;
            }
        }
    }
}
