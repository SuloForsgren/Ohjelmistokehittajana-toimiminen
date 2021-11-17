using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudProject
{
    public partial class Kirjautumisikkuna : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        YHDISTA yhteys = new YHDISTA();

        public Kirjautumisikkuna()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = TietolaatikkoDG.CurrentRow.Cells[0].Value.ToString();
            EtunimiTB.Text = TietolaatikkoDG.CurrentRow.Cells[1].Value.ToString();
            SukunimiTB.Text = TietolaatikkoDG.CurrentRow.Cells[2].Value.ToString();
            PuhelinTB.Text = TietolaatikkoDG.CurrentRow.Cells[3].Value.ToString();
            SpostiTB.Text = TietolaatikkoDG.CurrentRow.Cells[4].Value.ToString();
            OpiskelijanroTB.Text = TietolaatikkoDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void Kirjautumisikkuna_Load(object sender, EventArgs e)
        {
            TietolaatikkoDG.DataSource = opiskelija.haeOpiskelijat();
        }
        private void TyhjennysBT_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            PuhelinTB.Text = "";
            SpostiTB.Text = "";
            OpiskelijanroTB.Text = "";
        }

        private void TallennusBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String puhelin = PuhelinTB.Text;
            String email = SpostiTB.Text;
            int onro = Int32.Parse(OpiskelijanroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("Virhe - vaaditut kentät - etu ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, onro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietolaatikkoDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void PaivitysBT_Click_1(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String puhelin = PuhelinTB.Text;
            String email = SpostiTB.Text;
            int onro = Int32.Parse(OpiskelijanroTB.Text);
            int oid = Int32.Parse(IdTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE vaaditut kentät ID, Etu ja sukunimi, puhelin sähköposti sekä opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, onro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            TietolaatikkoDG.DataSource = opiskelija.haeOpiskelijat();
        }
        /*private void TietolaatikkoDG_CellCLick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = TietolaatikkoDG.CurrentRow.Cells[0].Value.ToString();
            EtunimiTB.Text = TietolaatikkoDG.CurrentRow.Cells[1].Value.ToString();
            SukunimiTB.Text = TietolaatikkoDG.CurrentRow.Cells[2].Value.ToString();
            PuhelinTB.Text = TietolaatikkoDG.CurrentRow.Cells[3].Value.ToString();
            SpostiTB.Text = TietolaatikkoDG.CurrentRow.Cells[4].Value.ToString();
            OpiskelijanroTB.Text = TietolaatikkoDG.CurrentRow.Cells[5].Value.ToString();
        }*/
        //private void PoistoBT_Click(object sender, DataGridViewCellEventArgs e)
          private void PoistoBT_Click(object sender, EventArgs e)
        {
            String ktunnus = IdTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietolaatikkoDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelija ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennysBT.PerformClick();
        }

    }
}