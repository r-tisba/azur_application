using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace azur_application.Services
{
    class Fonctions
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        // ---------------------------------- PROFIL ----------------------------------
        public int recupererNbDiscussionsActives(int idUtilisateurSession)
        {
            conn.Open();
            int nbDiscussions = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idDiscussion) AS nbDiscussions FROM discussions WHERE idEnvoyeur = @idUtilisateur OR idDestinataire = @idUtilisateur", conn);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateurSession);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbDiscussions = Convert.ToInt32(reader["nbDiscussions"]); }
            conn.Close();
            return nbDiscussions;
        }
        public int recupererNbMessagesEnvoyes(int idUtilisateurSession)
        {
            conn.Open();
            int nbMessageEnvoyes = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idMessage) AS nbMessageEnvoyes FROM messages WHERE idUtilisateur = @idUtilisateur", conn);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateurSession);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbMessageEnvoyes = Convert.ToInt32(reader["nbMessageEnvoyes"]); }
            conn.Close();
            return nbMessageEnvoyes;
        }

        public int recupererNbMessagesRecus(int idUtilisateurSession)
        {
            conn.Open();
            int nbMessageRecus = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idMessage) AS nbMessageRecus FROM messages m LEFT JOIN discussions d USING(idDiscussion) WHERE d.idDestinataire = @idUtilisateur AND m.idUtilisateur != @idUtilisateur", conn);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateurSession);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbMessageRecus = Convert.ToInt32(reader["nbMessageRecus"]); }
            conn.Close();
            return nbMessageRecus;
        }
        public int recupererNbEvenementsCrees(int idUtilisateurSession)
        {
            conn.Open();
            int nbEvenementCrees = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(id) AS nbEvenementCrees FROM evenements WHERE idCreateur = @idUtilisateur", conn);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateurSession);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbEvenementCrees = Convert.ToInt32(reader["nbEvenementCrees"]); }
            conn.Close();
            return nbEvenementCrees;
        }
        public int recupererNbEvenementsParticipes(int idUtilisateurSession)
        {
            conn.Open();
            int nbEvenementParticipes = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idEvenement) AS nbEvenementParticipes FROM evenements e LEFT JOIN participants_evenements pe ON e.id = pe.idEvenement WHERE pe.idUtilisateur = @idUtilisateur", conn);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateurSession);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbEvenementParticipes = Convert.ToInt32(reader["nbEvenementParticipes"]); }
            conn.Close();
            return nbEvenementParticipes;
        }
        public int recupererNbProjetsEnCours(int idUtilisateurSession)
        {
            conn.Open();
            int nbProjets = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idProjet) AS nbProjets FROM projets p LEFT JOIN composition_equipes ce USING(idEquipe) LEFT JOIN utilisateurs u USING(idUtilisateur) WHERE p.etatProjet = 0 AND u.idUtilisateur = @idUtilisateur AND ((NOW() >= p.dateDebut AND NOW() <= p.dateFin) OR NOW() >= p.dateDebut AND ISNULL(p.dateFin))", conn);
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateurSession);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbProjets = Convert.ToInt32(reader["nbProjets"]); }
            conn.Close();
            return nbProjets;
        }

        // ---------------------------------- STATISTIQUES ----------------------------------

        public int recupererNbUtilisateurs()
        {
            conn.Open();
            int nbUtilisateur = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idUtilisateur) AS nbUtilisateur FROM utilisateurs", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbUtilisateur = Convert.ToInt32(reader["nbUtilisateur"]); }
            conn.Close();
            return nbUtilisateur;
        }
        public int recupererNbAdmins()
        {
            conn.Open();
            int nbAdmins = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idUtilisateur) AS nbAdmins FROM utilisateurs WHERE role = 'Admin' OR role = 'SuperAdmin'", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbAdmins = Convert.ToInt32(reader["nbAdmins"]); }
            conn.Close();
            return nbAdmins;
        }
        public int recupererNbConnexionsDepuis24h()
        {
            conn.Open();
            int nbConnexions = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idLog) AS nbConnexions FROM logs WHERE date >= NOW() - INTERVAL 1 DAY", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbConnexions = Convert.ToInt32(reader["nbConnexions"]); }
            conn.Close();
            return nbConnexions;
        }
        public int recupererNbMessages()
        {
            conn.Open();
            int nbMessages = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idMessage) AS nbMessages FROM messages", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbMessages = Convert.ToInt32(reader["nbMessages"]); }
            conn.Close();
            return nbMessages;
        }
        public int recupererNbDiscussions()
        {
            conn.Open();
            int nbDiscussions = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idDiscussion) AS nbDiscussions FROM discussions", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbDiscussions = Convert.ToInt32(reader["nbDiscussions"]); }
            conn.Close();
            return nbDiscussions;
        }
        public int recupererNbEvenements()
        {
            conn.Open();
            int nbEvenements = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(id) AS nbEvenements FROM evenements", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbEvenements = Convert.ToInt32(reader["nbEvenements"]); }
            conn.Close();
            return nbEvenements;
        }
        public int recupererMoyenneEtapesParProjet()
        {
            conn.Open();
            int moyenneEtapes = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT AVG(count) AS moyenneEtapes FROM (SELECT COUNT(idEtape) AS count FROM etapes e GROUP BY e.idProjet) AS countEtapesParProjet", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { moyenneEtapes = Convert.ToInt32(reader["moyenneEtapes"]); }
            conn.Close();
            return moyenneEtapes;
        }
        public int recupererNbProjetTermines()
        {
            conn.Open();
            int nbProjetsTermines = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idProjet) AS nbProjetsTermines FROM projets WHERE etatProjet = 1", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbProjetsTermines = Convert.ToInt32(reader["nbProjetsTermines"]); }
            conn.Close();
            return nbProjetsTermines;
        }
        public int recupererNbProjets()
        {
            conn.Open();
            int nbProjets = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idProjet) AS nbProjets FROM projets", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbProjets = Convert.ToInt32(reader["nbProjets"]); }
            conn.Close();
            return nbProjets;
        }
        public int recupererNbEtapesTerminees()
        {
            conn.Open();
            int nbEtapes = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idEtape) AS nbEtapes FROM etapes WHERE etatEtape = 1", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbEtapes = Convert.ToInt32(reader["nbEtapes"]); }
            conn.Close();
            return nbEtapes;
        }
        public int recupererNbEtapes()
        {
            conn.Open();
            int nbEtapes = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(idEtape) AS nbEtapes FROM etapes", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbEtapes = Convert.ToInt32(reader["nbEtapes"]); }
            conn.Close();
            return nbEtapes;
        }
        public int recupererNbEvenementsTerminesSemaine()
        {
            conn.Open();
            int nbEvenementsTerminesSemaine = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(id) AS nbEvenementsTerminesSemaine FROM evenements WHERE WEEK(start) = WEEK(NOW()) AND NOW() >= end", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbEvenementsTerminesSemaine = Convert.ToInt32(reader["nbEvenementsTerminesSemaine"]); }
            conn.Close();
            return nbEvenementsTerminesSemaine;

        }
        public int recupererNbEvenementsSemaine()
        {
            conn.Open();
            int nbEvenementsSemaine = 0;
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT COUNT(id) AS nbEvenementsSemaine FROM evenements WHERE WEEK(start) = WEEK(NOW())", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) { nbEvenementsSemaine = Convert.ToInt32(reader["nbEvenementsSemaine"]); }
            conn.Close();
            return nbEvenementsSemaine;
           
        }
    }
}
