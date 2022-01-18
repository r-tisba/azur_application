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
    class Equipe
    {
        private int idEquipe;
        private string nomEquipe;
        private string image;

        public int IdEquipe
        {
            get { return idEquipe; }
            protected set { idEquipe = value; }
        }
     
        public string NomEquipe
        {
            get { return nomEquipe; }
            protected set { nomEquipe = value; }
        }
        public string Image
        {
            get { return image; }
            protected set { image = value; }
        }

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

        //Affichage info équipe
        public MySqlDataAdapter recupererInfosEquipe()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT nomEquipe AS NOM, image AS IMAGE FROM equipes", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
        //Affichage réduit info équipe pour facilité la compréhension dans l'onglet Ajout Utilisateur

        public MySqlDataAdapter recuperationReduiteInfosEquipe()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idEquipe, nomEquipe FROM equipes", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public int recupererIdEquipeViaNomEquipe(string nomEquipe)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idEquipe FROM equipes WHERE nomEquipe = @nomEquipe", conn);
            command.Parameters.AddWithValue("@nomEquipe", nomEquipe);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idEquipe = (int)reader["idEquipe"];
            }
            reader.Close();
            conn.Close();
            return idEquipe;
        }
    }
}
