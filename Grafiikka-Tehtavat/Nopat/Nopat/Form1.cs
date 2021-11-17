using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nopat
{
    public partial class Nopat : Form
    {
        public Nopat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            piirraNoppa(Noppa01PB);
            piirraNoppa(Noppa02PB);
        }
        private void piirraNoppa(PictureBox Nopat)
        {
            Random sattumanvarainen = new Random();
            int noppa = sattumanvarainen.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    Nopat.Image = Properties.Resources.dice01;
                    break;
                case 2:
                    Nopat.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    Nopat.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    Nopat.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    Nopat.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    Nopat.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
}
