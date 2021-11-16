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
        private int idUtilisateur;
        private string nom;
        private string prenom;
        private string poste;
        private string identifiant;
        private string mdp;
        private string role;

        public int IdUtilisateur
        {
            get { return idUtilisateur; }
            protected set { idUtilisateur = value; }
        }
        public string Nom
        {
            get { return nom; }
            protected set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            protected set { prenom = value; }
        }
        public string Poste
        {
            get { return poste; }
            protected set { poste = value; }
        }
        public string Identifiant
        {
            get { return identifiant; }
            protected set { identifiant = value; }
        }
        public string Mdp
        {
            get { return mdp; }
            protected set { mdp = value; }
        }
        public string Role
        { 
            get { return role; }
            protected set { role = value; }
        }

        // CLASSE MODELE APPELE DANS TOUT LES AUTRES MODELES
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        // ------------------------------------ SELECT INFOS CONNEXION ------------------------------------
        public bool recupererInfosConnexion(string identifiantSaisi)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@identifiantSaisi", identifiantSaisi);
            command.CommandText = "SELECT mdp, role FROM utilisateurs WHERE identifiant = @identifiantSaisi";

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Mdp = reader.GetString(0);
                Role = reader.GetString(1);
            }
            if(string.IsNullOrEmpty(mdp) || string.IsNullOrEmpty(role))
            {
                return false;
            }
            else
            {
                return true;
            }

            conn.Close();
        }

<<<<<<< HEAD
        // ------------------------------------ AJOUTER ------------------------------------
        public bool ajouterUtilisateur(string nomSaisi, string prenomSaisi, string identifiant, string mdpSaisiHash, string posteSaisi, string roleSaisi)
=======
        // ------------------------------------------------------------------------------------ AJOUTER ------------------------------------------------------------------------------------
        public bool ajouterUtilisateur(string nomSaisi, string prenomSaisi, string identifiant, string mdpSaisiHash, string posteSaisi, string idRoleSaisi)
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@nomSaisi", nomSaisi);
            command.Parameters.AddWithValue("@prenomSaisi", prenomSaisi);
            command.Parameters.AddWithValue("@identifiant", identifiant);
            command.Parameters.AddWithValue("@mdpSaisi", mdpSaisiHash);
            command.Parameters.AddWithValue("@posteSaisi", posteSaisi);
<<<<<<< HEAD
            command.Parameters.AddWithValue("@roleSaisi", roleSaisi);
=======
            command.Parameters.AddWithValue("@idRoleSaisi", idRoleSaisi);

            command.CommandText = "INSERT INTO utilisateurs (nom, prenom, identifiant, mdp, poste, idRole) VALUES(@nomSaisi, @prenomSaisi, @identifiant, @mdpSaisi, @posteSaisi, @idRoleSaisi)";
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd

            command.CommandText = "INSERT INTO utilisateurs (nom, prenom, identifiant, mdp, poste, role) VALUES(@nomSaisi, @prenomSaisi, @identifiant, @mdpSaisi, @posteSaisi, @roleSaisi)";
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

<<<<<<< HEAD
        // ------------------------------------ MODIFIER ------------------------------------
        public bool modifierUtilisateur(int idUtilisateur, string nomSaisi, string prenomSaisi, string posteSaisi, string roleSaisi)
=======
        // ------------------------------------------------------------------------------------ MODIFIER ------------------------------------------------------------------------------------
        public bool modifierUtilisateur(int idUtilisateur, string nomSaisi, string prenomSaisi, string posteSaisi, string idRoleSaisi)
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@nomSaisi", nomSaisi);
            command.Parameters.AddWithValue("@prenomSaisi", prenomSaisi);
            command.Parameters.AddWithValue("@posteSaisi", posteSaisi);
<<<<<<< HEAD
            command.Parameters.AddWithValue("@roleSaisi", roleSaisi);

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.CommandText = "UPDATE utilisateurs SET nom = @nomSaisi, prenom = @prenomSaisi, poste = @posteSaisi, " +
                                  "role = @roleSaisi WHERE idUtilisateur = @idUtilisateur";
=======
            command.Parameters.AddWithValue("@idRoleSaisi", idRoleSaisi);

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.CommandText = "UPDATE utilisateurs SET nom = @nomSaisi, prenom = @prenomSaisi, poste = @posteSaisi, " +
                                  "idRole = @idRoleSaisi WHERE idUtilisateur = @idUtilisateur";
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd

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

        // ------------------------------------ SELECT ROLES ------------------------------------
        public MySqlDataAdapter recupererNomsRoles()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT nomRole FROM roles", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

                conn.Close();
                return sda;
        }

        // ------------------------------------ SELECT INFOS UTILISATEURS ------------------------------------
        public MySqlDataAdapter recupererInfosUtilisateur()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idUtilisateur, nom, prenom, identifiant, poste, role FROM utilisateurs", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
    }
}