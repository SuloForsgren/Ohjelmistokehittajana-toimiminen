using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float lasku = 0;
            float luku1 = float.Parse(LukuyksiTB.Text);
            float luku2 = float.Parse(LukukaksiTB.Text);
            string teksti = LaskutoimitusCB.Text;

            switch (teksti)
            {
                case "+":
                    lasku = luku1 + luku2;
                    break;
                case "-":
                    lasku = luku1 - luku2;
                    break;
                case "*":
                    lasku = luku1 * luku2;
                    break;
                case "/":
                    if (luku2 == 0)
                    {
                        VastausLB.Text = "Nollalla ei voi jakaa";
                        goto loppu;
                    }
                    else
                    {
                        lasku = luku1 / luku2;
                    }
                    break;
                default:
                    VastausLB.Text = "Jokin meni pieleen";
                    break;
            }
            VastausLB.Text = lasku + "";
                loppu:
            VastausLB.Visible = true;
        }
    }
}