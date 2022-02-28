using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace azur_application.Modeles
{
    class Etape
    {
        private int idEtape;
        private int idProjet;
        private string nomEtape;
        private string dateDebut;
        private string dateFin;
        private int etatEtape;

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        // ------------------------------------ AJOUTER ------------------------------------
        public bool ajouterEtape(string nomEtapeSaisi, DateTime dateDebutSaisi, DateTime dateFinSaisi, string etatSaisi, string projetSaisi)
        {
            conn.Open();

            Projet projet = new Projet();
            int idProjet = projet.recupererIdProjetViaNomProjet(projetSaisi);

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idProjet", idProjet);
            command.Parameters.AddWithValue("@nomEtape", nomEtapeSaisi);
            command.Parameters.AddWithValue("@dateDebut", dateDebutSaisi);
            command.Parameters.AddWithValue("@dateFin", dateFinSaisi);
            if (etatSaisi == "En cours") { command.Parameters.AddWithValue("@etat", 0); }
            else { command.Parameters.AddWithValue("@etat", 1); }

            command.CommandText = "INSERT INTO etapes(idProjet, nomEtape, dateDebut, dateFin, etatEtape) VALUES(@idProjet, @nomEtape, @dateDebut, @dateFin, @etat)";
            try
            {
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch 
            {
                conn.Close();
                return false;
            }
        }

        // ------------------------------------ MODIFIER ------------------------------------
        public bool modifierEtape(int idEtape, string nomEtapeSaisi, string dateDebutSaisi, string dateFinSaisi, string etatSaisi)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEtape", idEtape);
            command.Parameters.AddWithValue("@nomEtape", nomEtapeSaisi);
            command.Parameters.AddWithValue("@dateDebut", dateDebutSaisi);
            command.Parameters.AddWithValue("@dateFin", dateFinSaisi);
            if (etatSaisi == "En cours") { command.Parameters.AddWithValue("@etat", 0); }
            else { command.Parameters.AddWithValue("@etat", 1); }

            command.CommandText = "UPDATE etapes SET nomEtape = @nomEtape, dateDebut = @dateDebut, dateFin = @dateFin, etatEtape = @etat WHERE idEtape = @idEtape";
            try
            {
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        // ------------------------------------ SUPPRIMER ------------------------------------
        public bool supprimerEtape(int idEtape)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEtape", idEtape);
            command.CommandText = "DELETE FROM etapes WHERE idEtape = @idEtape";
            try
            {
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        public MySqlDataAdapter recupererInfosEtape(int idProjet)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT nomEtape AS NOM, e.dateDebut AS DEBUT, e.dateFin AS FIN, etatEtape AS ETAT, p.nomProjet AS PROJET FROM etapes e LEFT JOIN projets p USING(idProjet) WHERE idProjet = @idProjet", conn);
            command.Parameters.AddWithValue("@idProjet", idProjet);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
        public MySqlDataAdapter recupererNomsProjets()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT nomProjet FROM projets", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public string recupererNomEtapeViaIdEtape(int idEtape)
        {
            conn.Open();
            string nomEtape = "";
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT nomEtape FROM etapes WHERE idEtape = @idEtape", conn);
            command.Parameters.AddWithValue("@idEtape", idEtape);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nomEtape = reader["nomEtape"] == DBNull.Value ? "" : (string)reader["nomEtape"];
            }
            reader.Close();
            conn.Close();
            return nomEtape;
        }

        public int recupererIdEtapeViaNomEtape(string nomEtape)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT idEtape FROM etapes WHERE nomEtape = @nomEtape", conn);
            command.Parameters.AddWithValue("@nomEtape", nomEtape);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idEtape = reader["idEtape"] == DBNull.Value ? 0 : (int)reader["idEtape"];
            }
            reader.Close();
            conn.Close();
            return idEtape;
        }
    }
}
