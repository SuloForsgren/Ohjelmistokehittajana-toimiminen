using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pojat_ja_tytöt
{
    public partial class NimiFORM : Form
    {
        public NimiFORM()
        {
            InitializeComponent();
        }

        private void TarkistusBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";

            string[] pojat = File.ReadAllLines("F:/Pojat ja tytöt tehtävä/Pojat.txt");
            string[] tytöt = File.ReadAllLines("F:/Pojat ja tytöt tehtävä/Tytöt.txt");

            string nimi = NimiTB.Text;

            int laskuripojat = 1;
            int laskuritytot = 1;

            //Pojat
            foreach (string poika in pojat)
            {
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskuripojat + " suosituin nimi vuonna 2020!";
                    VastausLB.Visible = true;
                }
                laskuripojat++;
            }
            //Tytöt
            foreach (string tyttö in tytöt)
            {
                if (nimi == tyttö)
                {
                    VastausLB.Text = "Nimesi on " + laskuritytot + " suosituin nimi vuonna 2020!";
                    VastausLB.Visible = true;
                }
              laskuritytot++;
            }
        }
    }
}
