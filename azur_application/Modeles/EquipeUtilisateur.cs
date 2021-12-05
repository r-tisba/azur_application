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

        //partie MySQL
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        //Ajout employée à un équipe
        public bool association_utilisateur_equipe(int idEquipe, int idUtilisateur)
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

        //Modifier équipe utilisateur
        public bool modifier_utilisateur_equipe(int idEquipe, int idUtilisateur, int labelIdEquipe)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEquipe", idEquipe);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@labelIdEquipe", labelIdEquipe);


            command.CommandText = "UPDATE composition_equipes SET idEquipe=@idEquipe, idUtilisateur=@idUtilisateur WHERE idUtilisateur=@idUtilisateur AND WHERE=@labelIdEquipe";


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
        public bool supprimer_utilisateur_equipe(int idUtilisateur, int labelIdEquipe)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@labelIdEquipe", labelIdEquipe);

            command.CommandText = "DELETE FROM composition_equipes WHERE idUtilisateur=@idUtilisateur AND idEquipe=@labelIdEquipe";


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
        public MySqlDataAdapter donneeCompo()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idEquipe, idUtilisateur, utilisateurs.identifiant, equipes.nomEquipe FROM composition_equipes LEFT JOIN utilisateurs USING(idUtilisateur) LEFT JOIN equipes USING(idEquipe)", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public MySqlDataAdapter liste_utilisateurs()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT identifiant FROM utilisateurs", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
        public MySqlDataAdapter liste_equipes()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT nomEquipe FROM equipes", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
        public MySqlDataAdapter liste_composition_equipe()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idEquipe, equipes.nomEquipe, idUtilisateur, utilisateurs.identifiant FROM composition_equipes LEFT JOIN equipe USING(idEquipe) LEFT JOIN utilisateurs USING(idUtilisateur)", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
        public bool verif_compos(int idEquipe, int idUtilisateur)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@idEquipe", idEquipe);
            command.CommandText = "SELECT idEquipe, idUtilisateur FROM composition_equipes WHERE idEquipe=@idEquipe AND idUtilisateur=@idUtilisateur";
            MySqlDataReader reader = command.ExecuteReader();
            
            if (reader.HasRows)
            {
                reader.Close();
                conn.Close();
                return false;
                
            }
            else
            {
                reader.Close();
                conn.Close();
                return true;
                
            }
            
        }
    }
}
