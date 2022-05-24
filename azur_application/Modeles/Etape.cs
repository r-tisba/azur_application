using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;


namespace azur_application.Modeles
{
    class Etape
    {
        public static int idUtilisateurSession;
        private int idEtape;
        private int idProjet;
        private string nomEtape;
        private string dateDebut;
        private string dateFin;
        private int etatEtape;
        private string dateValidation;
        private List<int> listIdEtapes = new List<int>();

        public int IdUtilisateurSession
        {
            get { return idUtilisateurSession; }
            set { idUtilisateurSession = value; }
        }
        public int IdEtape
        {
            get { return idEtape; }
            set { idEtape = value; }
        }
        public int IdProjet
        {
            get { return idProjet; }
            set { idProjet = value; }
        }
        public string NomEtape
        {
            get { return nomEtape; }
            set { nomEtape = value; }
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
        public int EtatEtape
        {
            get { return etatEtape; }
            set { etatEtape = value; }
        }
        public string DateValidation
        {
            get { return dateValidation; }
            set { dateValidation = value; }
        }
        public List<int> ListIdEtapes
        {
            get { return listIdEtapes; }
            set { listIdEtapes = value; }
        }

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");


        public Etape(int idEtape = 0)
        {
            if (idEtape != 0)
            {
                conn.Open();
                MySqlCommand query = conn.CreateCommand();
                query.CommandText = "SELECT idEtape, idProjet, nomEtape, dateDebut, dateFin, etatEtape, dateValidation FROM etapes e WHERE idEtape = @idEtape";
                query.Parameters.AddWithValue("@idEtape", idEtape);
                MySqlDataReader reader = query.ExecuteReader();
                ListIdEtapes = new List<int>();

                while (reader.Read())
                {
                    this.IdEtape = reader.GetInt32(0);
                    this.IdProjet = reader.GetInt32(1);
                    this.NomEtape = reader.GetString(2);
                    DateTime dateDebutDt = reader.GetDateTime(3);
                    this.DateDebut = dateDebutDt.ToString("HH:mm");
                    /*DateTime dateFinDt = reader.GetDateTime(4);
                    this.DateFin = dateFinDt.ToString("HH:mm");*/

                    object dateFinDt = reader[6];
                    DateTime? dt = (dateFinDt == System.DBNull.Value)
                        ? (DateTime?)null
                        : Convert.ToDateTime(dateFinDt);
                    this.DateFin = Convert.ToString(dateFinDt);

                    this.EtatEtape = reader.GetInt32(5);

                    object dateValidationDt = reader[6];
                    dt = (dateValidationDt == System.DBNull.Value)
                        ? (DateTime?)null
                        : Convert.ToDateTime(dateValidationDt);
                    this.DateValidation = Convert.ToString(dateValidationDt);
                    this.ListIdEtapes.Add(reader.GetInt32(0));
                }

                reader.Close();
                conn.Close();
            }
        }
        public static bool IsDateTimeNullOrEmpty(DateTime? date)
        {
            return date == null ? true : false;
        }

        // ------------------------------------ AJOUTER ------------------------------------
        public bool ajouterEtape(string nomEtapeSaisi, DateTime dateDebutSaisi, DateTime dateFinSaisi, string etatSaisi, string projetSaisi)
        {
            conn.Open();

            Projet projet = new Projet();
            int idProjet = projet.recupererIdProjetViaNomProjet(projetSaisi);

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idProjet", idProjet);
            command.Parameters.AddWithValue("@nomEtape", nomEtapeSaisi);
            command.Parameters.AddWithValue("@dateDebut", dateDebutSaisi);
            command.Parameters.AddWithValue("@dateFin", dateFinSaisi);
            if (etatSaisi == "En cours") { command.Parameters.AddWithValue("@etat", 0); }
            else { command.Parameters.AddWithValue("@etat", 1); }

            command.CommandText = "INSERT INTO etapes(idProjet, nomEtape, dateDebut, dateFin, etatEtape) VALUES(@idProjet, @nomEtape, @dateDebut, @dateFin, @etat)";
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
        public bool modifierEtape(int idEtape, string nomEtapeSaisi, string dateDebutSaisi, string dateFinSaisi, string etatSaisi)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEtape", idEtape);
            command.Parameters.AddWithValue("@nomEtape", nomEtapeSaisi);
            command.Parameters.AddWithValue("@dateDebut", dateDebutSaisi);
            command.Parameters.AddWithValue("@dateFin", dateFinSaisi);
            if (etatSaisi == "En cours") 
            { 
                command.Parameters.AddWithValue("@etat", 0); 
                command.Parameters.AddWithValue("@dateValidation", null); 
            }
            else {
                DateTime dateValidation = DateTime.Now;
                command.Parameters.AddWithValue("@etat", 1); 
                command.Parameters.AddWithValue("@dateValidation", dateValidation); 
            }

            command.CommandText = "UPDATE etapes SET nomEtape = @nomEtape, dateDebut = @dateDebut, dateFin = @dateFin, etatEtape = @etat, dateValidation = @dateValidation WHERE idEtape = @idEtape";
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
        public bool supprimerEtape(int idEtape)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idEtape", idEtape);
            command.CommandText = "DELETE FROM etapes WHERE idEtape = @idEtape";
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

        public MySqlDataAdapter recupererInfosEtape(int idProjet)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT nomEtape AS NOM, e.dateDebut AS DEBUT, e.dateFin AS FIN, etatEtape AS ETAT, p.nomProjet AS PROJET FROM etapes e LEFT JOIN projets p USING(idProjet) WHERE idProjet = @idProjet", conn);
            command.Parameters.AddWithValue("@idProjet", idProjet);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }
        public MySqlDataAdapter recupererNomsProjets()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT nomProjet FROM projets", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            conn.Close();
            return sda;
        }

        public string recupererNomEtapeViaIdEtape(int idEtape)
        {
            conn.Open();
            string nomEtape = "";
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT nomEtape FROM etapes WHERE idEtape = @idEtape", conn);
            command.Parameters.AddWithValue("@idEtape", idEtape);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nomEtape = reader["nomEtape"] == DBNull.Value ? "" : (string)reader["nomEtape"];
            }
            reader.Close();
            conn.Close();
            return nomEtape;
        }

        public int recupererIdEtapeViaNomEtape(string nomEtape)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT idEtape FROM etapes WHERE nomEtape = @nomEtape", conn);
            command.Parameters.AddWithValue("@nomEtape", nomEtape);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idEtape = reader["idEtape"] == DBNull.Value ? 0 : (int)reader["idEtape"];
            }
            reader.Close();
            conn.Close();
            return idEtape;
        }
        public List<int> recupererIdEtapesTermines()
        {
            conn.Open();
            List<int> listIdEtapes = new List<int>();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT idEtape FROM etapes LEFT JOIN projets USING(idProjet) WHERE etatProjet = 0 AND etatEtape = 1 ORDER BY idProjet, dateValidation", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) { listIdEtapes.Add((int)reader["idEtape"]); }

            conn.Close();
            return listIdEtapes;
        }
        public List<int> recupererIdEtapesTerminesViaIdProjet(int idProjet)
        {
            conn.Open();
            List<int> listIdEtapes = new List<int>();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT idEtape FROM etapes LEFT JOIN projets USING(idProjet) WHERE etatProjet = 0 AND etatEtape = 1 AND idProjet = @idProjet ORDER BY idProjet, dateValidation", conn);
            command.Parameters.AddWithValue("@idProjet", idProjet);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) { listIdEtapes.Add((int)reader["idEtape"]); }

            conn.Close();
            return listIdEtapes;
        }
    }
}