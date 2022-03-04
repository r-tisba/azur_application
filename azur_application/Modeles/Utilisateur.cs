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
using System.Data.SqlClient;
using System.Configuration;

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
            conn.Close();
            if(string.IsNullOrEmpty(mdp) || string.IsNullOrEmpty(role))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        // ------------------------------------ AJOUTER ------------------------------------
        public bool ajouterUtilisateur(string nomSaisi, string prenomSaisi, string identifiant, string mdpSaisiHash, string posteSaisi, string roleSaisi)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@nomSaisi", nomSaisi);
            command.Parameters.AddWithValue("@prenomSaisi", prenomSaisi);
            command.Parameters.AddWithValue("@identifiant", identifiant);
            command.Parameters.AddWithValue("@mdpSaisi", mdpSaisiHash);
            command.Parameters.AddWithValue("@posteSaisi", posteSaisi);
            command.Parameters.AddWithValue("@roleSaisi", roleSaisi);

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

        // ------------------------------------ MODIFIER ------------------------------------
        public bool modifierUtilisateur(int idUtilisateur, string nomSaisi, string prenomSaisi, string posteSaisi, string roleSaisi)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@nomSaisi", nomSaisi);
            command.Parameters.AddWithValue("@prenomSaisi", prenomSaisi);
            command.Parameters.AddWithValue("@posteSaisi", posteSaisi);
            command.Parameters.AddWithValue("@roleSaisi", roleSaisi);

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.CommandText = "UPDATE utilisateurs SET nom = @nomSaisi, prenom = @prenomSaisi, poste = @posteSaisi, " +
                                  "role = @roleSaisi WHERE idUtilisateur = @idUtilisateur";
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

        // ------------------------------------ REINITIALISATION ------------------------------------
        public bool reinitialiserUtilisateur(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@validation", 0);
            command.CommandText = "UPDATE utilisateurs SET validation = @validation WHERE idUtilisateur = @idUtilisateur";
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

        // ------------------------------------ SUPPRIMER ------------------------------------
        public bool supprimerUtilisateur(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.CommandText = "DELETE FROM utilisateurs WHERE idUtilisateur = @idUtilisateur; DELETE FROM composition_equipes WHERE idUtilisateur = @idUtilisateur";
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

            command = new MySqlCommand("SELECT idUtilisateur AS ID, nom AS NOM, prenom AS PRENOM, identifiant AS IDENTIFIANT, poste AS POSTE, role AS ROLE FROM utilisateurs", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
        // --------------- Récupération réduite info utilisateur pour facilité la lecteur dans Ajout Utilisateur ---------------
        public MySqlDataAdapter recuperationReduiteInfosUtilisateur()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idUtilisateur AS ID, identifiant AS IDENTIFIANT FROM utilisateurs", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public int recupererIdUtilisateurViaIdentifiant(string identifiant)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT idUtilisateur FROM utilisateurs WHERE identifiant = @identifiant", conn);
            command.Parameters.AddWithValue("@identifiant", identifiant);
            MySqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                idUtilisateur = (int)reader["idUtilisateur"];
            }
            reader.Close();
            conn.Close();
            return idUtilisateur;
        }
    }
}