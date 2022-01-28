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
        public bool ajouterProjet(string nomProjetSaisi, string intituleSaisi, DateTime dateDebutSaisi, DateTime dateFinSaisi, string etatSaisi, string equipeSaisi, string contexteSaisi)
        {
            conn.Open();

            Equipe equipe = new Equipe();
            int idEquipe = equipe.recupererIdEquipeViaNomEquipe(equipeSaisi);

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nomProjet", nomProjetSaisi);
            command.Parameters.AddWithValue("@intitule", intituleSaisi);
            command.Parameters.AddWithValue("@dateDebut", dateDebutSaisi);
            command.Parameters.AddWithValue("@dateFin", dateFinSaisi);
            if (etatSaisi == "En cours") { command.Parameters.AddWithValue("@etat", 0); }
            else { command.Parameters.AddWithValue("@etat", 1); }
            command.Parameters.AddWithValue("@idEquipe", idEquipe);
            command.Parameters.AddWithValue("@contexte", contexteSaisi);

            command.CommandText = "INSERT INTO projets(nomProjet, intitule, dateDebut, dateFin, etatProjet, idEquipe, contexte) VALUES(@nomProjet, @intitule, @dateDebut, @dateFin, @etat, @idEquipe, @contexte)";
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
        public bool modifierProjet(int idProjet, string nomProjetSaisi, string intituleSaisi, string dateDebutSaisi, string dateFinSaisi, string etatSaisi, string equipeSaisi, string contexteSaisi)
        {
            conn.Open();

            Equipe equipe = new Equipe();
            int idEquipe = equipe.recupererIdEquipeViaNomEquipe(equipeSaisi);

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idProjet", idProjet);
            command.Parameters.AddWithValue("@nomProjet", nomProjetSaisi);
            command.Parameters.AddWithValue("@intitule", intituleSaisi);
            command.Parameters.AddWithValue("@dateDebut", dateDebutSaisi);
            command.Parameters.AddWithValue("@dateFin", dateFinSaisi);
            if(etatSaisi == "En cours") { command.Parameters.AddWithValue("@etat", 0);  }
            else { command.Parameters.AddWithValue("@etat", 1); }
            command.Parameters.AddWithValue("@idEquipe", idEquipe);
            command.Parameters.AddWithValue("@contexte", contexteSaisi);

            /*
            System.Windows.Forms.MessageBox.Show(
                "idProjet ||| " + idProjet.ToString() + Environment.NewLine +
                "nomProjetSaisi ||| " + nomProjetSaisi + Environment.NewLine +
                "intituleSaisi ||| " + intituleSaisi + Environment.NewLine +
                "dateDebutSaisi ||| " + dateDebutSaisi.ToString() + Environment.NewLine +
                "dateFinSaisi ||| " + dateFinSaisi.ToString() + Environment.NewLine +
                "etat ||| " + temp + Environment.NewLine +
                "idEquipe ||| " + idEquipe + Environment.NewLine +
                "contexteSaisi ||| " + contexteSaisi
            );
            */

            command.CommandText = "UPDATE projets SET nomProjet = @nomProjet, intitule = @intitule, dateDebut = @dateDebut, dateFin = @dateFin, etatProjet = @etat, idEquipe = @idEquipe, contexte = @contexte WHERE idProjet = @idProjet";
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
        public bool supprimerProjet(int idProjet)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idProjet", idProjet);
            command.CommandText = "DELETE FROM projets WHERE idProjet=@idProjet; DELETE FROM etapes WHERE idProjet=@idProjet";
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

            command = new MySqlCommand("SELECT nomProjet AS NOM, intitule AS INTITULE, dateDebut AS DEBUT, dateFin AS FIN, etatProjet AS ETAT, e.nomEquipe AS EQUIPE, contexte AS CONTEXTE FROM projets LEFT JOIN equipes e USING(idEquipe)", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public string recupererNomProjetViaIdProjet(int idProjet)
        {
            conn.Open();
            string nomProjet = "";
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT nomProjet FROM projets WHERE idProjet = @idProjet", conn);
            command.Parameters.AddWithValue("@idProjet", idProjet);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nomProjet = reader["nomProjet"] == DBNull.Value ? "" : (string)reader["nomProjet"];
            }
            reader.Close();
            conn.Close();
            return nomProjet;
        }

        public int recupererIdProjetViaNomProjet(string nomProjet)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT idProjet FROM projets WHERE nomProjet = @nomProjet", conn);
            command.Parameters.AddWithValue("@nomProjet", nomProjet);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idProjet = reader["idProjet"] == DBNull.Value ? 0 : (int)reader["idProjet"];
            }
            reader.Close();
            conn.Close();
            return idProjet;
        }
    }
}
