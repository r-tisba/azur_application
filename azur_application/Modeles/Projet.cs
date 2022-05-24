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
    class Projet
    {
        public static int idUtilisateurSession;
        private int idProjet;
        private int idEquipe;
        private string dateDebut;
        private string dateFin;
        private int etatProjet;
        private string nomProjet;
        private string intitule;
        private string contexte;
        private List<int> listIdProjets = new List<int>();
        private List<Projet> listProjets = new List<Projet>();
        private List<int> listIdEtapesProjet = new List<int>();

        public int IdUtilisateurSession
        {
            get { return idUtilisateurSession; }
            set { idUtilisateurSession = value; }
        }
        public int IdProjet
        {
            get { return idProjet; }
            set { idProjet = value; }
        }
        public int IdEquipe
        {
            get { return idEquipe; }
            set { idEquipe = value; }
        }
        public string DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }
        public string DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }
        public int EtatProjet
        {
            get { return etatProjet; }
            set { etatProjet = value; }
        }
        public string NomProjet
        {
            get { return nomProjet; }
            set { nomProjet = value; }
        }
        public string Intitule
        {
            get { return intitule; }
            set { intitule = value; }
        }
        public string Contexte
        {
            get { return contexte; }
            set { contexte = value; }
        }
        public List<int> ListIdProjets
        {
            get { return listIdProjets; }
            set { listIdProjets = value; }
        }
        public List<Projet> ListProjets
        {
            get { return listProjets; }
            set { listProjets = value; }
        }
        public List<int> ListIdEtapesProjet
        {
            get { return listIdEtapesProjet; }
            set { listIdEtapesProjet = value; }
        }

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        public Projet(int idProjet = 0)
        {
            if (idProjet != 0)
            {
                conn.Open();
                MySqlCommand query = conn.CreateCommand();
                query.CommandText = "SELECT idProjet, idEquipe, dateDebut, dateFin, etatProjet, nomProjet, intitule, contexte FROM projets p WHERE idProjet = @idProjet";
                query.Parameters.AddWithValue("@idProjet", idProjet);
                MySqlDataReader reader = query.ExecuteReader();
                listIdProjets = new List<int>();

                while (reader.Read())
                {
                    this.IdProjet = reader.GetInt32(0);
                    this.IdEquipe = reader.GetInt32(1);
                    DateTime dateDebutDt = reader.GetDateTime(2);
                    this.DateDebut = dateDebutDt.ToString("HH:mm");
                    DateTime dateFinDt = reader.GetDateTime(3);
                    this.DateFin = dateFinDt.ToString("HH:mm");
                    this.EtatProjet = reader.GetInt32(4);
                    this.NomProjet = reader.GetString(5);
                    this.Intitule = reader.GetString(6);
                    this.Contexte = reader.GetString(7);
                    this.ListIdProjets.Add(reader.GetInt32(0));

                    List<Projet> listProjets = new List<Projet>()
                    {
                        new Projet { IdProjet = reader.GetInt32(0), IdEquipe = reader.GetInt32(1), DateDebut = dateDebutDt.ToString("HH:mm"),
                            DateFin= dateDebutDt.ToString("HH:mm"), EtatProjet = reader.GetInt32(4), NomProjet = reader.GetString(5),
                            Intitule = reader.GetString(6), Contexte = reader.GetString(7) },
                    };
                }
                reader.Close();

                query = conn.CreateCommand();
                query.CommandText = "SELECT idEtape FROM etapes e WHERE idProjet = @idProjet";
                query.Parameters.AddWithValue("@idProjet", idProjet);
                reader = query.ExecuteReader();
                List<int> listIdEtapesProjet = new List<int>();
                while (reader.Read()) { listIdEtapesProjet.Add((int)reader["idEtape"]); }
                this.ListIdEtapesProjet = listIdEtapesProjet;

                reader.Close();
                conn.Close();
            }
        }

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
        public int recupererNbEtapesProjet(int idProjet)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(*) FROM etapes WHERE idProjet = @idProjet", conn);
            command.Parameters.AddWithValue("@idProjet", idProjet);

            Int32 nbTotalEtape = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return nbTotalEtape;
        }
        public int recupererNbEtapesTermineesProjet(int idProjet)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(*) FROM etapes WHERE idProjet = @idProjet AND etatEtape = 1", conn);
            command.Parameters.AddWithValue("@idProjet", idProjet);

            Int32 nbTotalEtape = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return nbTotalEtape;
        }
        public List<int> recupererIdProjetsEnCours()
        {
            conn.Open();
            List<int> listIdProjets = new List<int>();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT * FROM projets WHERE etatProjet = 0", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) { listIdProjets.Add((int)reader["idProjet"]); }

            conn.Close();
            return listIdProjets;
        }      
    }
}