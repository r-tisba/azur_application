using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using azur_application.Modeles;
using azur_application.Services;
using MySql.Data.MySqlClient;

namespace azur_application.Onglets
{
    public partial class ongletStatistiques : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        Utilisateur utilisateur = new Utilisateur();

        public ongletStatistiques()
        {
            InitializeComponent();
        }

        private void ongletStatistiques_Load(object sender, EventArgs e)
        {
            LoadTheme();
            afficherStatsGlobales();
            afficherStatsCirculaires();
        }
        private void LoadTheme()
        {
            lbl_statistiques.ForeColor = ThemeColor.ActiveColor;
            nb_utilisateurs.ForeColor = ThemeColor.ActiveColor;
            nb_admins.ForeColor = ThemeColor.ActiveColor;
            nb_connexions.ForeColor = ThemeColor.ActiveColor;
            nb_messages.ForeColor = ThemeColor.ActiveColor;
            nb_discussions.ForeColor = ThemeColor.ActiveColor;
            nb_evenementT.ForeColor = ThemeColor.ActiveColor;
            moyenne_etapes.ForeColor = ThemeColor.ActiveColor;
        }

        // ------------------------------------ AFFICHAGE STATS GENERALES ------------------------------------
        public void afficherStatsGlobales()
        {
            Utilisateur utilisateur = new Utilisateur();
            int idUtilisateur = utilisateur.IdUtilisateurSession;
            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! A CHANGER !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Utilisateur utilisateurSession = new Utilisateur(1);
            Fonctions fonctions = new Fonctions();

            nb_utilisateurs.Text = fonctions.recupererNbUtilisateurs().ToString();
            nb_admins.Text = fonctions.recupererNbAdmins().ToString();
            nb_connexions.Text = fonctions.recupererNbConnexionsDepuis24h().ToString();
            nb_messages.Text = fonctions.recupererNbMessages().ToString();
            nb_discussions.Text = fonctions.recupererNbDiscussions().ToString();
            nb_evenementT.Text = fonctions.recupererNbEvenements().ToString();
            moyenne_etapes.Text = fonctions.recupererMoyenneEtapesParProjet().ToString();

        }
        // ------------------------------------ AFFICHAGE STATS CIRCULAIRES ------------------------------------
        public void afficherStatsCirculaires()
        {
            Utilisateur utilisateur = new Utilisateur();
            int idUtilisateur = utilisateur.IdUtilisateurSession;
            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! A CHANGER !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Utilisateur utilisateurSession = new Utilisateur(1);
            Fonctions fonctions = new Fonctions();

            nb_projets_termines.Text = fonctions.recupererNbProjetTermines().ToString() + " terminé(s)";
            nb_projetsT.Text = fonctions.recupererNbProjets().ToString() + " projet(s)";
            nb_etapes_terminees.Text = fonctions.recupererNbEtapesTerminees().ToString() + " terminée(s)";
            nb_etapesT.Text = fonctions.recupererNbEtapes().ToString() + " étape(s)";
            nb_evenements_termines.Text = fonctions.recupererNbEvenementsTerminesSemaine().ToString() + " terminé(s)";
            nb_evenements_semaine.Text = fonctions.recupererNbEvenementsSemaine().ToString() + " évenement(s) cette semaine";

            /* ------------------------- Barre projets ------------------------- */
            int nbProjets = fonctions.recupererNbProjets();
            int nbProjetsTermines = fonctions.recupererNbProjetTermines();
            if (nbProjets == 0 || nbProjetsTermines == 0)
            {
                br_prg_projets.Value = 0;
                br_prg_projets.SubscriptText = "0";
                br_prg_projets.SuperscriptMargin = new System.Windows.Forms.Padding(-2, 49, 0, 0);
            }
            else
            {
                double barreProgValue = (double)nbProjetsTermines / nbProjets;
                barreProgValue = (double)System.Math.Round(barreProgValue, 2);
                barreProgValue = barreProgValue * 100;

                br_prg_projets.Minimum = 0;
                br_prg_projets.Maximum = 100;
                if (barreProgValue == 100)
                {
                    br_prg_projets.SuperscriptMargin = new System.Windows.Forms.Padding(-55, 52, 0, 0);
                }
                else if (barreProgValue >= 10 && barreProgValue < 100)
                {
                    br_prg_projets.SuperscriptMargin = new System.Windows.Forms.Padding(-60, 52, 0, 0);
                }
                else if (barreProgValue < 10)
                {
                    br_prg_projets.SuperscriptMargin = new System.Windows.Forms.Padding(-65, 52, 0, 0);
                }
                br_prg_projets.SubscriptText = barreProgValue.ToString();
                br_prg_projets.Value = (int)barreProgValue;
            }

            /* ------------------------- Barre étapes ------------------------- */
            int nbEtapes = fonctions.recupererNbEtapes();
            int nbEtapesTerminees = fonctions.recupererNbEtapesTerminees();
            if (nbEtapes == 0 || nbEtapesTerminees == 0)
            {
                br_prg_etapes.Value = 0;
                br_prg_etapes.SubscriptText = "0";
                br_prg_etapes.SuperscriptMargin = new System.Windows.Forms.Padding(-2, 49, 0, 0);
            }
            else
            {
                double barreProgValue = (double)nbEtapesTerminees / nbEtapes;
                barreProgValue = (double)System.Math.Round(barreProgValue, 2);
                barreProgValue = barreProgValue * 100;

                br_prg_etapes.Minimum = 0;
                br_prg_etapes.Maximum = 100;
                if (barreProgValue == 100)
                {
                    br_prg_etapes.SuperscriptMargin = new System.Windows.Forms.Padding(-55, 52, 0, 0);
                }
                else if (barreProgValue >= 10 && barreProgValue < 100)
                {
                    br_prg_etapes.SuperscriptMargin = new System.Windows.Forms.Padding(-60, 52, 0, 0);
                }
                else if (barreProgValue < 10)
                {
                    br_prg_etapes.SuperscriptMargin = new System.Windows.Forms.Padding(-65, 52, 0, 0);
                }
                br_prg_etapes.SubscriptText = barreProgValue.ToString();
                br_prg_etapes.Value = (int)barreProgValue;
            }

            /* ------------------------- Barre évenements ------------------------- */
            int nbEvenements = fonctions.recupererNbEvenementsSemaine();
            int nbEvenementsTermines = fonctions.recupererNbEvenementsTerminesSemaine();
            if (nbEvenements == 0 || nbEvenementsTermines == 0)
            {
                br_prg_evenements.Value = 0;
                br_prg_evenements.SubscriptText = "0";
                br_prg_evenements.SuperscriptMargin = new System.Windows.Forms.Padding(-2, 49, 0, 0);
            }
            else
            {
                double barreProgValue = (double)nbEvenementsTermines / nbEvenements;
                barreProgValue = (double)System.Math.Round(barreProgValue, 2);
                barreProgValue = barreProgValue * 100;

                br_prg_evenements.Minimum = 0;
                br_prg_evenements.Maximum = 100;
                if (barreProgValue == 100)
                {
                    br_prg_evenements.SuperscriptMargin = new System.Windows.Forms.Padding(-55, 52, 0, 0);
                }
                else if (barreProgValue >= 10 && barreProgValue < 100)
                {
                    br_prg_evenements.SuperscriptMargin = new System.Windows.Forms.Padding(-60, 52, 0, 0);
                }
                else if (barreProgValue < 10)
                {
                    br_prg_evenements.SuperscriptMargin = new System.Windows.Forms.Padding(-65, 52, 0, 0);
                }
                br_prg_evenements.SubscriptText = barreProgValue.ToString();
                br_prg_evenements.Value = (int)barreProgValue;
            }
        }
    }
}
