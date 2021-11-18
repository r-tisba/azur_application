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
        private int idEmploye;
        private int idEquipe;

        public int IdEquipe
        {
            get { return idEquipe; }
            protected set { idEquipe = value; }
        }
        public int IdEmploye
        {
            get { return idEmploye; }
            protected set { idEmploye = value; }
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

            command.CommandText = "INSERT INTO composition_equipes (idEmploye, idEquipe) VALUES(@idUtilisateur, @idEquipe)";
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
        public bool modifier_utilisateur_equipe(int idEquipe, int idUtilisateur, int idEmploye, int labelIdEquipe)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@idEquipe", idEquipe);
            command.Parameters.AddWithValue("@idEmploye", idEmploye);
            command.Parameters.AddWithValue("@labelIdEquipe", labelIdEquipe);


            command.CommandText = "UPDATE composition_equipes SET idEquipe=@idEquipe, idEmploye=@idUtilisateur WHERE idEmploye=@idEmploye AND WHERE=@labelIdEquipe";


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
        public bool supprimer_utilisateur_equipe(int idEmploye, int labelIdEquipe)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEmploye", idEmploye);
            command.Parameters.AddWithValue("@labelIdEquipe", labelIdEquipe);

            command.CommandText = "DELETE FROM composition_equipes WHERE idEmploye=@idEmploye AND idEquipe=@labelIdEquipe";


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
    }
}
