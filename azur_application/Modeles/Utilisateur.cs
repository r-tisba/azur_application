using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CustomWindowsForm;
using MySql.Data.MySqlClient;

namespace azur_application.Modeles
{
    class Utilisateur
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        public MySqlDataReader recupererInfosConnexion(string identifiantSaisi)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@identifiantSaisi", identifiantSaisi);
            command.CommandText = "SELECT mdp, idRole FROM utilisateurs WHERE identifiant = @identifiantSaisi";

            MySqlDataReader reader = command.ExecuteReader();
            conn.Close();
            return reader;
        }

        // ------------------------------------------------------------------------------------ AJOUTER ------------------------------------------------------------------------------------
        public bool ajouterUtilisateur(string nomSaisi, string prenomSaisi, string identifiant, string mdpSaisiHash, string posteSaisi, string idRoleSaisi)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@nomSaisi", nomSaisi);
            command.Parameters.AddWithValue("@prenomSaisi", prenomSaisi);
            command.Parameters.AddWithValue("@identifiant", identifiant);
            command.Parameters.AddWithValue("@mdpSaisi", mdpSaisiHash);
            command.Parameters.AddWithValue("@posteSaisi", posteSaisi);
            command.Parameters.AddWithValue("@idRoleSaisi", idRoleSaisi);

            command.CommandText = "INSERT INTO utilisateurs (nom, prenom, identifiant, mdp, poste, idRole) VALUES(@nomSaisi, @prenomSaisi, @identifiant, @mdpSaisi, @posteSaisi, @idRoleSaisi)";

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

        // ------------------------------------------------------------------------------------ MODIFIER ------------------------------------------------------------------------------------
        public bool modifierUtilisateur(int idUtilisateur, string nomSaisi, string prenomSaisi, string posteSaisi, string idRoleSaisi)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@nomSaisi", nomSaisi);
            command.Parameters.AddWithValue("@prenomSaisi", prenomSaisi);
            command.Parameters.AddWithValue("@posteSaisi", posteSaisi);
            command.Parameters.AddWithValue("@idRoleSaisi", idRoleSaisi);

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.CommandText = "UPDATE utilisateurs SET nom = @nomSaisi, prenom = @prenomSaisi, poste = @posteSaisi, " +
                                  "idRole = @idRoleSaisi WHERE idUtilisateur = @idUtilisateur";

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

        // ------------------------------------------------------------------------------------ SUPPRIMER ------------------------------------------------------------------------------------
        public bool supprimerUtilisateur(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.CommandText = "DELETE FROM utilisateurs WHERE idUtilisateur = @idUtilisateur";
            command.ExecuteNonQuery();

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
