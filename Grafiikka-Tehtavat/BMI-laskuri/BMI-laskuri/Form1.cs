using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PainoIndeksiBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);

            if (bmi < 18.5)
            {
                TulostekstiLB.Text = "painoindeksi on: " + bmi;
                PainotulosLB.Text = "Alipaino";
                TulostekstiLB.ForeColor = Color.Aqua;
                PainotulosLB.ForeColor = Color.Aqua;
                TulostekstiLB.Visible = true;
                PainotulosLB.Visible = true;
            }
            else if (bmi < 25)
            {
                TulostekstiLB.Text = "painoindeksi on: " + bmi;
                PainotulosLB.Text = "Normaalipaino";
                TulostekstiLB.ForeColor = Color.ForestGreen;
                PainotulosLB.ForeColor = Color.ForestGreen;
                TulostekstiLB.Visible = true;
                PainotulosLB.Visible = true;
            }
            else if (bmi < 40)
            {
                TulostekstiLB.Text = "painoindeksi on: " + bmi;
                PainotulosLB.Text = "Ylipaino";
                TulostekstiLB.ForeColor = Color.LightYellow;
                PainotulosLB.ForeColor = Color.LightYellow;
                TulostekstiLB.Visible = true;
                PainotulosLB.Visible = true;
            }
            else //if (indeksi > 40)
            {
                TulostekstiLB.Text = "painoindeksi on: " + bmi;
                PainotulosLB.Text = "Huomattava ylipaino";
                TulostekstiLB.ForeColor = Color.DarkRed;
                PainotulosLB.ForeColor = Color.DarkRed;
                TulostekstiLB.Visible = true;
                PainotulosLB.Visible = true;
            }
        }
    }
}
