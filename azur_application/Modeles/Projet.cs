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
    class Projet
    {
        private int idProjet;
        private string dateDebut;
        private string dateFin;
        private int etatProjet;
        private string nom;
        private string intitule;
        private string contexte;
        private string illustration;

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        // ------------------------------------ AJOUTER ------------------------------------
        public bool ajouterEquipe(string nomEquipeSaisi, string nomImageSaisi)
        {
            conn.Open();

            string pathImageSaisi;
            if (String.IsNullOrEmpty(nomImageSaisi))
            {
                pathImageSaisi = "";
            }
            else
            {
                pathImageSaisi = "../images/design/" + nomImageSaisi;
            }

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nom_equipe", nomEquipeSaisi);
            command.Parameters.AddWithValue("@pathImageSaisi", pathImageSaisi);
            command.CommandText = "INSERT INTO equipes(nomEquipe, image) VALUES(@nom_equipe, @pathImageSaisi)";
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
        public bool modifierEquipe(int idEquipe, string nomEquipe, string nomImageSaisi)
        {
            conn.Open();

            string pathImageSaisi;
            if (String.IsNullOrEmpty(nomImageSaisi))
            {
                pathImageSaisi = "";
            }
            else
            {
                pathImageSaisi = "../images/design/" + nomImageSaisi;
            }

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEquipe", idEquipe);
            command.Parameters.AddWithValue("@nomEquipe", nomEquipe);
            command.Parameters.AddWithValue("@pathImageSaisi", pathImageSaisi);
            command.CommandText = "UPDATE equipes SET nomEquipe = @nomEquipe, image = @pathImageSaisi WHERE idEquipe = @idEquipe";
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
        public bool supprimerEquipe(int idEquipe)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEquipe", idEquipe);
            command.CommandText = "DELETE FROM equipes WHERE idEquipe=@idEquipe; DELETE FROM composition_equipes WHERE idEquipe=@idEquipe";
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
        public MySqlDataAdapter recupererNomsEquipes()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT nomEquipe FROM equipes", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public MySqlDataAdapter recupererInfosProjet()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT nom AS NOM, intitule AS INTITULE, dateDebut AS DEBUT, dateFin AS FIN, etatProjet AS ETAT, e.nomEquipe AS EQUIPE, contexte AS CONTEXTE FROM projets LEFT JOIN equipes e USING(idEquipe)", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public MySqlDataAdapter recuperationReduiteInfosEquipe()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idEquipe, nomEquipe FROM equipes", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public int recupererIdProjetViaNomProjet(string nomProjet)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idProjet FROM projets WHERE nom = @nomProjet", conn);
            command.Parameters.AddWithValue("@nomProjet", nomProjet);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idProjet = (int)reader["idProjet"];
            }
            reader.Close();
            conn.Close();
            return idProjet;
        }
    }
}
