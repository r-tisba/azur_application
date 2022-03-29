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
    class Evenement
    {
        public static int idUtilisateurSession;
        private int idEvenement;
        private string title;
        private string start;
        private string end;
        private string date;
        private string backgroundColor;
        private string nomCreateur;

        public int IdUtilisateurSession
        {
            get { return idUtilisateurSession; }
            set { idUtilisateurSession = value; }
        }
        public int IdEvenement
        {
            get { return idEvenement; }
            set { idEvenement = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Start
        {
            get { return start; }
            set { start = value; }
        }
        public string End
        {
            get { return end; }
            set { end = value; }
        }
        public string BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }
        public string NomCreateur
        {
            get { return nomCreateur; }
            set { nomCreateur = value; }
        }

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        public Evenement(int idEvenement = 0)
        {
            if (idEvenement != 0)
            {
                conn.Open();
                MySqlCommand query = conn.CreateCommand();
                query.CommandText = "SELECT id, title, start, end, backgroundColor, u.identifiant FROM evenements e LEFT JOIN utilisateurs u ON e.idCreateur = u.idUtilisateur WHERE id = @idEvenement";
                query.Parameters.AddWithValue("@idEvenement", idEvenement);
                MySqlDataReader reader = query.ExecuteReader();
                
                while (reader.Read())
                {
                    this.IdEvenement = reader.GetInt32(0);
                    this.Title = reader.GetString(1);
                    DateTime dateDt = reader.GetDateTime(2);
                    this.Date = dateDt.ToString("d/MM");
                    DateTime startDt = reader.GetDateTime(2);
                    this.Start = startDt.ToString("HH:mm");
                    DateTime endDt = reader.GetDateTime(3);
                    this.End = endDt.ToString("HH:mm");
                    this.BackgroundColor = reader.GetString(4);
                    this.NomCreateur = reader.GetString(5);
                }
                reader.Close();
                conn.Close();
            }
        }

        public int recupererIdEvenement(int idUtilisateurSession)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT * FROM evenements e LEFT JOIN participants_evenements pe ON pe.idEvenement = e.id WHERE pe.idUtilisateur = @idUtilisateur AND e.start > NOW() ORDER BY e.start ASC LIMIT 1", conn);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateurSession);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idEvenement = (int)reader["id"];
            }

            conn.Close();
            return idEvenement;
        }
    }
}
