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

namespace Päiväkirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("F:/Päiväkirja/teksti.txt");
            TarinaTB.Text = teksti;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TallennusBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += TarinaTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("F:/Päiväkirja/teksti.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
