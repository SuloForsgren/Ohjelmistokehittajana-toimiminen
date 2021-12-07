using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ajastin
{
    public partial class AjastinFORM : Form
    {
        public AjastinFORM()
        {
            InitializeComponent();
        }

        private void AjastinFORM_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i=0; i < 60; i++)
            {
                SekunnitCB.Items.Add(i.ToString());
                MinuutitCB.Items.Add(i.ToString());
            }
            MinuutitCB.SelectedIndex = 30;
            SekunnitCB.SelectedIndex = 0;
        }
        private int kokonaisaika;
        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;

            int minutes = int.Parse(MinuutitCB.SelectedItem.ToString());
            int seconds = int.Parse(SekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minutes * 60) + seconds;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;

            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            KelloLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minutes = kokonaisaika / 60;
                int seconds = kokonaisaika - (minutes * 60);
                KelloLB.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Sinulta loppui aika", "Ajastin ilmoitus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
