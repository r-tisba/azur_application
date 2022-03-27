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
    using BCrypt.Net;
    public class Utilisateur
    {
        public static int idUtilisateurSession;
        private int idUtilisateur;
        private string nom;
        private string prenom;
        private string poste;
        private string identifiant;
        private string mdp;
        private string role;
        private string avatar;
        private int validation;
        private string[] equipes;

        public int IdUtilisateurSession
        {
            get { return idUtilisateurSession; } set { idUtilisateurSession = value; }
        }
        public int IdUtilisateur
        {
            get { return idUtilisateur; } set { idUtilisateur = value; }
        }
        public string Nom
        {
            get { return nom; } set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; } set { prenom = value; }
        }
        public string Poste
        {
            get { return poste; } set { poste = value; }
        }
        public string Identifiant
        {
            get { return identifiant; } set { identifiant = value; }
        }
        public string Mdp
        {
            get { return mdp; } set { mdp = value; }
        }
        public string Role
        { 
            get { return role; } set { role = value; }
        }
        public string Avatar
        {
            get { return avatar; } set { avatar = value; }
        }
        public int Validation
        {
            get { return validation; } set { validation = value; }
        }
        public string[] Equipes
        {
            get { return equipes; } set { equipes = value; }
        }

        public Utilisateur(int idUtilisateur = 0)
        {
            if (idUtilisateur != 0)
            {
                conn.Open();
                MySqlCommand query = conn.CreateCommand();
                query.CommandText = "SELECT * FROM utilisateurs WHERE idUtilisateur = @idUtilisateur";
                query.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdUtilisateur = reader.GetInt32(0);
                    this.Nom = reader.GetString(1);
                    this.Prenom = reader.GetString(2);
                    this.Poste = reader.GetString(3);
                    this.Identifiant = reader.GetString(4);
                    this.Mdp = reader.GetString(5);
                    this.Role = reader.GetString(6);
                    this.Avatar = reader.GetString(8);
                    this.Validation = reader.GetInt32(9);
                }
                reader.Close();

                int i = 0;
                query = conn.CreateCommand();
                query.CommandText = "SELECT e.nomEquipe, u.identifiant FROM equipes e LEFT JOIN composition_equipes ce USING(idEquipe) LEFT JOIN utilisateurs u USING(idUtilisateur) WHERE idUtilisateur = 1";
                query.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                reader = query.ExecuteReader();

                int count = 0;
                while (reader.Read()) { count++; }
                reader.Close();
                string[] arrayAvatar = new string[count];

                query.CommandText = "SELECT e.nomEquipe, u.identifiant FROM equipes e LEFT JOIN composition_equipes ce USING(idEquipe) LEFT JOIN utilisateurs u USING(idUtilisateur) WHERE idUtilisateur = 1";
                reader = query.ExecuteReader();
                while (reader.Read() == true)
                {
                    arrayAvatar[i] = reader.GetString(0);
                    i++;
                }
                reader.Close();
                this.Equipes = arrayAvatar;
                conn.Close();
            }
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
            string mdp = BCrypt.HashPassword("MotDePasse123!");
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@mdp", mdp);
            command.Parameters.AddWithValue("@validation", 0);
            command.CommandText = "UPDATE utilisateurs SET validation = @validation, mdp = @mdp WHERE idUtilisateur = @idUtilisateur";
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
        // ------------------------------------ SELECT INFOS UTILISATEURS ONGLET AFFECTATIONS ------------------------------------
        public MySqlDataAdapter recuperationReduiteInfosUtilisateur()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT identifiant AS IDENTIFIANT, poste AS POSTE FROM utilisateurs", conn);
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

        // ------------------------------------ SELECT AVATAR ------------------------------------
        public string recupererAvatarViaIdentifiant(string identifiant)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT avatar FROM utilisateurs WHERE identifiant = @identifiant", conn);
            command.Parameters.AddWithValue("@identifiant", identifiant);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                avatar = (string)reader["avatar"];
            }

            reader.Close();
            conn.Close();
            return avatar;
        }
        // ------------------------------------ MODIFIER AVATAR ------------------------------------
        public bool modifierAvatar(int idUtilisateur, string nomImage)
        {
            conn.Open();
            string pathImageSaisi = "../images/avatar/" + nomImage;

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@pathImageSaisi", pathImageSaisi);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.CommandText = "UPDATE utilisateurs SET avatar = @pathImageSaisi WHERE idUtilisateur = @idUtilisateur";
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

        public MySqlDataAdapter recupererEquipesUtilisateur(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command = new MySqlCommand("SELECT e.nomEquipe, u.identifiant FROM equipes e LEFT JOIN composition_equipes ce USING(idEquipe) LEFT JOIN utilisateurs u USING(idUtilisateur) WHERE idUtilisateur = 1");
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
    }
}