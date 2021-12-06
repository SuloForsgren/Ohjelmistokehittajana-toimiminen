using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hotelli__Oma_
{
    class VARAUS
    {
        YHDISTA yhteys = new YHDISTA();

        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
        public DataTable haeVaraukset()
        {
            MySqlCommand komentoloinen = new MySqlCommand("SELECT * FROM huoneet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komentoloinen;
            adapteri.Fill(taulu);
            return taulu;
        }
        public bool lisaaVaraus(int hnro, int anro, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komentoo = new MySqlCommand();
            string kysely = "INSERT INTO huoneet" + "(Huoneennumero, AsiakasID, Sisaan, Ulos) " + "VALUES (@hno, @aid, @sis, @ulo);";

            komentoo.CommandText = kysely;
            komentoo.Connection = yhteys.otaYhteys();

            komentoo.Parameters.Add("@hno", MySqlDbType.VarChar).Value = hnro;
            komentoo.Parameters.Add("@aid", MySqlDbType.VarChar).Value = anro;
            komentoo.Parameters.Add("@sis", MySqlDbType.VarChar).Value = sisaan;
            komentoo.Parameters.Add("@ulo", MySqlDbType.VarChar).Value = ulos;
            
            yhteys.avaaYhteys();
            try
            {
                if (komentoo.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }
        }

        public bool muokkaaVarausta(int hnro, int asid, DateTime sisaan, DateTime ulos, int varaus)
        {
            MySqlCommand komento = new MySqlCommand();
            string paivitys = "UPDATE huoneet SET Huoneennumero = @hno," + " AsiakasID = @aid, Sisaan = @sis, Ulos = @ulo" + " WHERE VarausId = vid";
            komento.CommandText = paivitys;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.VarChar).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.VarChar).Value = asid;
            komento.Parameters.Add("@sis", MySqlDbType.VarChar).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.VarChar).Value = ulos;
            komento.Parameters.Add("@ulo", MySqlDbType.Int32).Value = varaus;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public bool poistavaraus(String varausnumero)
        {
            MySqlCommand komento = new MySqlCommand();
            String poisto = "DELETE FROM huoneet WHERE VarausID = @vno";
            komento.CommandText = poisto;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@vno", MySqlDbType.VarChar).Value = varausnumero;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public DataTable tyypillisetHuoneet (int htype)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisays = "SELECT * from hallinta WHERE Huonetyyppi = @hty";
            komento.CommandText = lisays;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = htype;
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
    }
}
