using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kahvio
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
            MeistaPL.Visible = true;
        }

        private void KoriPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            MeistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 joka välitunti \n";
            MeistaLB.Text += "9:00-14:30 joka päivä maanantaista perjantaihin\n";
            MeistaLB.Text += "9:00-12:30. \n\nKahvilasta saa lämpimien \n";
            MeistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia\n";
            MeistaLB.Text += "Tervetuloa tutustumaan!";
            MeistaLB.Font = new Font("Arial", 12);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RuoatPL.Visible = false;
            HerkutPL.Visible = false;
            JuomatPL.Visible = false;
            KoriPL.Visible = false;
            MeistaPL.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RuoatPL.Visible = true;
            HerkutPL.Visible = false;
            JuomatPL.Visible = false;
            KoriPL.Visible = false;
            MeistaPL.Visible = false;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            RuoatPL.Visible = false;
            HerkutPL.Visible = false;
            JuomatPL.Visible = true;
            KoriPL.Visible = false;
            MeistaPL.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RuoatPL.Visible = false;
            HerkutPL.Visible = true;
            JuomatPL.Visible = false;
            KoriPL.Visible = false;
            MeistaPL.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RuoatPL.Visible = false;
            HerkutPL.Visible = false;
            JuomatPL.Visible = false;
            KoriPL.Visible = true;
            MeistaPL.Visible = false;
        }
    }
}
