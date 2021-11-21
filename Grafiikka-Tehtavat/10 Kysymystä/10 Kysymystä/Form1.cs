using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Kysymystä
{
    public partial class Form1 : Form
    {
        string[] vastaukset = new string[] { "A", "D", "B", "A", "D", "C", "C", "A", "B", "D" };
        string[] vst = new string[10];
        int kysymykset = 0;
        int oikein = 0;

        public Form1()
        {
            InitializeComponent();
            VastausARBT.CheckedChanged += new EventHandler(Vaihdettu_radiobutton);
            VastausBRBT.CheckedChanged += new EventHandler(Vaihdettu_radiobutton);
            VastausCRBT.CheckedChanged += new EventHandler(Vaihdettu_radiobutton);
            VastausDRBT.CheckedChanged += new EventHandler(Vaihdettu_radiobutton);
        }

        private void Vaihdettu_radiobutton(object sender, EventArgs e)
        {
            if (sender is RadioButton && kysymykset < 10)
            {
                RadioButton radnap = (RadioButton)sender;
                vastaukset[kysymykset] = radnap.Text;
                kysymykset++;
                KysymysLB.Text = "Vastaus " + (kysymykset) + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                VastausARBT.Enabled = false;
                VastausBRBT.Enabled = false;
                VastausCRBT.Enabled = false;
                VastausDRBT.Enabled = false;
                for (int i = 0; i < 10; i++)
                {
                    if(vst[i] == vastaukset[i])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikein olivat: " + oikein;
                VastausLB.Visible = true;
            }
            Tyhjennys();
        }

        private void Tyhjennys()
        {
            if (VastausARBT.Checked == true)
            {
                VastausARBT.Checked = false;
                kysymykset--;
            }
            if (VastausBRBT.Checked == true)
            {
                VastausBRBT.Checked = false;
                kysymykset--;
            }
            if (VastausCRBT.Checked == true)
            {
                VastausCRBT.Checked = false;
                kysymykset--;
            }
            if (VastausDRBT.Checked == true)
            {
                VastausDRBT.Checked = false;
                kysymykset--;
            }
        }
        private void VastausDRBT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KysymysLB_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void VastausARBT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VastausBRBT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VastausCRBT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TurhaRBT_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
