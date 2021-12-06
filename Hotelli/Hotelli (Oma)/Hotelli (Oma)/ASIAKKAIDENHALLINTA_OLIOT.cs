﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotelli__Oma_
{
    class ASIAKKAIDENHALLINTA_OLIOT
    {
        YHDISTA yhteys = new YHDISTA();

        public bool lisaaAsiakas(String enimi, String snimi, String puh, String email)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO asujat " + "(Etunimi, Sukunimi, Puhelinnumero, sähköposti) " +
                "VALUES (@en,@sn,@puh,@ema); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@en", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@sn", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@ema", MySqlDbType.VarChar).Value = email;

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
            public DataTable haeAsiakkaat()
            {
                MySqlCommand komero = new MySqlCommand("SELECT oid, Etunimi, Sukunimi, Puhelinnumero, sähköposti FROM Asujat", yhteys.otaYhteys());
                MySqlDataAdapter adapteri = new MySqlDataAdapter();
                DataTable taulu = new DataTable();

                adapteri.SelectCommand = komero;
                adapteri.Fill(taulu);

                return taulu;
            }
        public bool poistaAsiakas(String ktunnus)
        {
            MySqlCommand komentollo = new MySqlCommand();
            String poistokysely = "DELETE FROM asujat WHERE oid = @oid";
            komentollo.CommandText = poistokysely;
            komentollo.Connection = yhteys.otaYhteys();

            komentollo.Parameters.Add("@oid", MySqlDbType.UInt32).Value = ktunnus;

            yhteys.avaaYhteys();
            if (komentollo.ExecuteNonQuery() == 1)
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

        public bool muokkaaAsiakasta(int oid, String enimi, String snimi, String puh, String email)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "update `asujat` SET `Etunimi` = @enm," + "`Sukunimi` = @snm,`Puhelinnumero` = @puh,`sähköposti`= @eml" + " WHERE oid = @oid";

            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

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

        public DataTable asiakaslista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

    }
}
