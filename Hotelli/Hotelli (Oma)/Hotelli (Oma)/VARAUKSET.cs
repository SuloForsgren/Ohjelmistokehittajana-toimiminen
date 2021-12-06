using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelli__Oma_
{
    public partial class VARAUKSET : Form
    {
        VARAUS varaus = new VARAUS();
        ASIAKKAIDENHALLINTA_OLIOT asiakas = new ASIAKKAIDENHALLINTA_OLIOT();
        public VARAUKSET()
        {
            InitializeComponent();
        }

        private void VARAUKSET_Load(object sender, EventArgs e)
        {

        }

        private void VarauksetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            YksiöCB.Text = VarauksetDG.CurrentRow.Cells[0].Value.ToString();
            KaksioCB.Text = VarauksetDG.CurrentRow.Cells[1].Value.ToString();
            VarausTB.Text = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            PerheCB.Text = VarauksetDG.CurrentRow.Cells[3].Value.ToString();
            SviittiCB.Text = VarauksetDG.CurrentRow.Cells[4].Value.ToString();
        }

        private void EraseBT_Click(object sender, EventArgs e)
        {
            VarausnTB.Text = "";
            PerheCB.Text = "";
            SviittiCB.Text = "";
            VarausTB.Text = "";
            YksiöCB.Text = "";
            KaksioCB.Text = "";
            SisaanDTP.Value = DateTime.Now;
            UlosDTP.Value = DateTime.Now;
            YksiöCB.Enabled = true;
            SviittiCB.Enabled = true;
            KaksioCB.Enabled = true;
            PerheCB.Enabled = true;
        }

        private void HuonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBT_Click(object sender, EventArgs e)
        {

        }
        
        //yksiö
        private void HuonenroCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxTarkistukset();
            KaksioCB.Enabled = false;
            PerheCB.Enabled = false;
            SviittiCB.Enabled = false;
        }
        
        //kaksio
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxTarkistukset();
            YksiöCB.Enabled = false;
            PerheCB.Enabled = false;
            SviittiCB.Enabled = false;
        }
        private void PerheCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxTarkistukset();
            YksiöCB.Enabled = false;
            KaksioCB.Enabled = false;
            SviittiCB.Enabled = false;
        }

        private void SviittiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxTarkistukset();
            YksiöCB.Enabled = false;
            KaksioCB.Enabled = false;
            PerheCB.Enabled = false;
        }
        private void comboboxTarkistukset()
        {
            if (YksiöCB.SelectedIndex > -1)
            {
                KaksioCB.Enabled = false;
                PerheCB.Enabled = false;
                SviittiCB.Enabled = false;
            }
            else if (KaksioCB.SelectedIndex > -1)
            {
                YksiöCB.Enabled = false;
                PerheCB.Enabled = false;
                SviittiCB.Enabled = false;
            }
            else if (PerheCB.SelectedIndex > -1)
            {
                YksiöCB.Enabled = false;
                KaksioCB.Enabled = false;
                SviittiCB.Enabled = false;
            }
            else
            {
                YksiöCB.Enabled = false;
                KaksioCB.Enabled = false;
                PerheCB.Enabled = false;
            }
        }


    }
}
