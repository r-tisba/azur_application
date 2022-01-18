using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace azur_application.Modeles
{
    class EquipeUtilisateur
    {
        private int idUtilisateur;
        private int idEquipe;

        public int IdEquipe
        {
            get { return idEquipe; }
            protected set { idEquipe = value; }
        }
        public int IdUtilisateur
        {
            get { return idUtilisateur; }
            protected set { idUtilisateur = value; }
        }

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        // Ajout employée à un équipe
        public bool associationUtilisateurEquipe(int idEquipe, int idUtilisateur)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@idEquipe", idEquipe);

            command.CommandText = "INSERT INTO composition_equipes (idUtilisateur, idEquipe) VALUES(@idUtilisateur, @idEquipe)";
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

        // Modifier équipe utilisateur
        public bool modifier_utilisateur_equipe(int idEquipe, int idUtilisateur, int labelIdEquipe)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEquipe", idEquipe);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@labelIdEquipe", labelIdEquipe);


            command.CommandText = "UPDATE composition_equipes SET idEquipe = @idEquipe, idUtilisateur = @idUtilisateur WHERE idUtilisateur = @idUtilisateur AND WHERE = @labelIdEquipe";


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
        public bool supprimerAssociation(int idUtilisateur, int idEquipe)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@idEquipe", idEquipe);

            command.CommandText = "DELETE FROM composition_equipes WHERE idUtilisateur = @idUtilisateur AND idEquipe = @idEquipe";
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
        public MySqlDataAdapter donneeCompoBrutes()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idEquipe, idUtilisateur, utilisateurs.identifiant, equipes.nomEquipe FROM composition_equipes LEFT JOIN utilisateurs USING(idUtilisateur) LEFT JOIN equipes USING(idEquipe)", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public MySqlDataAdapter donneeCompoClaires()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT u.identifiant AS IDENTIFIANT, e.nomEquipe AS EQUIPE FROM composition_equipes LEFT JOIN utilisateurs u USING(idUtilisateur) LEFT JOIN equipes e USING(idEquipe)", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public MySqlDataAdapter listeUtilisateurs()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT identifiant FROM utilisateurs", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
        public MySqlDataAdapter listeEquipes()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT nomEquipe FROM equipes", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
        public MySqlDataAdapter listeCompositionEquipe()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idEquipe, equipes.nomEquipe, idUtilisateur, utilisateurs.identifiant FROM composition_equipes LEFT JOIN equipe USING(idEquipe) LEFT JOIN utilisateurs USING(idUtilisateur)", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        // Renvoi true si l'association idUtilisateur - idEquipe existe
        public bool verifierAssociation(int idUtilisateur, int idEquipe)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT * FROM composition_equipes WHERE idUtilisateur = @idUtilisateur AND idEquipe = @idEquipe", conn);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@idEquipe", idEquipe);
            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                // L'association existe déjà
                conn.Close();
                return true;
            }
            else
            {
                // L'association n'existe pas
                conn.Close();
                return false;
            }

        }


    }
}
