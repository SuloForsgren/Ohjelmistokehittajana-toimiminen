using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lukujenjärjestys
{
    public partial class Lukujenjarjestys : Form
    {
        public Lukujenjarjestys()
        {
            InitializeComponent();
        }

        private void TyhjennaLomake()
        {
            uusiLukuTB.Text = "";
        }

        List<int> lista = new List<int>();
        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = lista.ToArray();
                    Array.Sort(taulukko);

                    foreach (var luku in taulukko)
                    {
                        VastausLB.Text += luku + " ";
                    }
                    VastausLB.Visible = true;
                }
                else if (uusiLukuTB.Text == "")
                {
                    MessageBox.Show("Et syöttänyt yhtään lukua kenttään", "Luvun syöttö", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lista.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjennaLomake();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}