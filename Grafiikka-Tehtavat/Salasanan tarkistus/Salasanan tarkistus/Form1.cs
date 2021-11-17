using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salasanan_tarkistus
{
    public partial class salasanaForm : Form
    {
        public salasanaForm()
        {
            InitializeComponent();
        }

        private void salasanaOikeinPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salasanaForm_Load(object sender, EventArgs e)
        {

        }
        private void KayttajatunnusTB_TextChanged(object sender, EventArgs e)
        {
            if (KayttajatunnusTB.Focus() == true)
            {
                KayttajaNaytaLB.Text = "Käyttäjänimi = Sulo";
                SalasanaNaytaLB.Text = "Salasana = 1234";

                KayttajaNaytaLB.Visible = true;
                SalasanaNaytaLB.Visible = true;

                VirheviestiLB.Visible = false;
            }
        }
        private void TarkistaBT_Click_1(object sender, EventArgs e)
        {
            if (KayttajatunnusTB.Text == "Sulo" && SalasanaTB.Text == "1234")
            {
                KayttajaNaytaLB.Visible = false;
                SalasanaNaytaLB.Visible = false;
                salasanaOikeinPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("On tapahtunut virhe suorittaessa kirjautumista!", "Virhe tiedoissa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VirheviestiLB.Text = "Olet syöttänyt tiedot väärin!";
                VirheviestiLB.Visible = true;
            }
        }
        private void SalasanaTB_TextChanged(object sender, EventArgs e)
        {
            SalasanaTB.PasswordChar = '*';
            SalasanaTB.MaxLength = 25;
        }
    }
}
