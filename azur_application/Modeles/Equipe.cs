using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace azur_application.Modeles
{
    class Equipe
    {
        private int idEquipe;
        private int idSecteur;
        private string nomEquipe;
        private string image;

        public int IdEquipe
        {
            get { return idEquipe; }
            protected set { idEquipe = value; }
        }
        public int IdSecteur
        {
            get { return idSecteur; }
            protected set { idSecteur = value; }
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

        //Partie MySQL
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        
        //Ajout équipe
        public bool ajout_equipe(string nomSaisi, string imageSaisi, int idSecteurSaisi)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nom_equipe", nomSaisi);
            command.Parameters.AddWithValue("@idSecteur", idSecteurSaisi);
            command.Parameters.AddWithValue("@image", imageSaisi);


            command.CommandText = "INSERT INTO equipe (nomEquipe, idSecteur, image) VALUES(@nom_equipe, @idSecteur, @image)";
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

        //Modifier équipe

        public bool modifier_equipe(string nom_equipe, int idSecteur, string image, int idEquipe)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nom_equipe", nom_equipe);
            command.Parameters.AddWithValue("@idSecteur", idSecteur);
            command.Parameters.AddWithValue("@image", image);
            command.Parameters.AddWithValue("@idEquipe", idEquipe);



            command.CommandText = "UPDATE equipe SET nomEquipe=@nom_equipe, idSecteur=@idSecteur, image=@image WHERE idEquipe=@idEquipe";
           

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

        //Supprimer équipe
        public bool supprimer_equipe(int idEquipe)
        {

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEquipe", idEquipe);



            command.CommandText = "DELETE FROM equipe WHERE idEquipe=@idEquipe; DELETE FROM equipe_employe WHERE idEquipe=@idEquipe";
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

        //Affichage info équipe
        public MySqlDataAdapter recupererInfosEquipe()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idEquipe, idSecteur, nomEquipe, image FROM equipe", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
    }
}
