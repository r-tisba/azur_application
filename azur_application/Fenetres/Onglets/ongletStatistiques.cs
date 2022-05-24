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
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;

namespace azur_application.Onglets
{
    public partial class ongletStatistiques : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        Utilisateur utilisateur = new Utilisateur();
        static List<string> listDatesValidations = new List<string>();
        public SeriesCollection SeriesCollection { get; set; }

        /*static Color[] colors =
        {
            Color.FromArgb(40, 167, 69), Color.FromArgb(0, 123, 255), Color.FromArgb(217, 83, 79),
            Color.FromArgb(255, 152, 0), Color.FromArgb(156, 39, 176), Color.FromArgb(33, 150, 243),
            Color.FromArgb(1, 135, 144), Color.FromArgb(239, 147, 126), Color.FromArgb(139, 194, 64),
            Color.FromArgb(120, 81, 169), Color.FromArgb(0, 148, 188), Color.FromArgb(67, 183, 110)
        };*/

        public ongletStatistiques()
        {
            InitializeComponent();
        }

        private void ongletStatistiques_Load(object sender, EventArgs e)
        {
            LoadTheme();
            afficherStatsGlobales();
            afficherStatsCirculaires();
            afficherGraph();
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
            int idUtilisateurSession = utilisateur.IdUtilisateurSession;
            Utilisateur utilisateurSession = new Utilisateur(idUtilisateurSession);
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
            int idUtilisateurSession = utilisateur.IdUtilisateurSession;
            Utilisateur utilisateurSession = new Utilisateur(idUtilisateurSession);
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
                br_prg_projets.SuperscriptMargin = new System.Windows.Forms.Padding(-25, 49, 0, 0);
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
                    br_prg_projets.SuperscriptMargin = new System.Windows.Forms.Padding(-15, 49, 0, 0);
                }
                else if (barreProgValue >= 10 && barreProgValue < 100)
                {
                    br_prg_projets.SuperscriptMargin = new System.Windows.Forms.Padding(-20, 49, 0, 0);
                }
                else if (barreProgValue < 10)
                {
                    br_prg_projets.SuperscriptMargin = new System.Windows.Forms.Padding(-25, 49, 0, 0);
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
                br_prg_etapes.SuperscriptMargin = new System.Windows.Forms.Padding(-25, 49, 0, 0);
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
                    br_prg_etapes.SuperscriptMargin = new System.Windows.Forms.Padding(-15, 49, 0, 0);
                }
                else if (barreProgValue >= 10 && barreProgValue < 100)
                {
                    br_prg_etapes.SuperscriptMargin = new System.Windows.Forms.Padding(-20, 49, 0, 0);
                }
                else if (barreProgValue < 10)
                {
                    br_prg_etapes.SuperscriptMargin = new System.Windows.Forms.Padding(-25, 49, 0, 0);
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
                br_prg_evenements.SuperscriptMargin = new System.Windows.Forms.Padding(-45, 49, 0, 0);
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
                    br_prg_evenements.SuperscriptMargin = new System.Windows.Forms.Padding(-35, 49, 0, 0);
                }
                else if (barreProgValue >= 10 && barreProgValue < 100)
                {
                    br_prg_evenements.SuperscriptMargin = new System.Windows.Forms.Padding(-40, 49, 0, 0);
                }
                else if (barreProgValue < 10)
                {
                    br_prg_evenements.SuperscriptMargin = new System.Windows.Forms.Padding(-45, 49, 0, 0);
                }
                br_prg_evenements.SubscriptText = barreProgValue.ToString();
                br_prg_evenements.Value = (int)barreProgValue;
            }
        }

        // ------------------------------------ AFFICHAGE CART GRAPH ------------------------------------
        public void afficherGraph()
        {
            Color[] colors =
            {
                Color.FromArgb(40, 167, 69), Color.FromArgb(0, 123, 255), Color.FromArgb(217, 83, 79),
                Color.FromArgb(255, 152, 0), Color.FromArgb(156, 39, 176), /*Color.FromArgb(33, 150, 243),*/
                Color.FromArgb(1, 135, 144), Color.FromArgb(239, 147, 126), Color.FromArgb(139, 194, 64),
                Color.FromArgb(120, 81, 169), /*Color.FromArgb(0, 148, 188),*/ Color.FromArgb(67, 183, 110)
            };

            // Initialisation du graph
            graphBarre.Series["Etape"].XValueMember = "Équipe";
            graphBarre.Series["Etape"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            graphBarre.Series["Etape"].YValueMembers = "Nb étapes";
            graphBarre.Series["Etape"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            // Données du graph
            Random rnd = new Random();
            Equipe equipe = new Equipe();
            List<int> listIdEquipe = new List<int>();
            List<int> listIdProjetsEquipe = new List<int>();
            listIdEquipe = equipe.recupererIdEquipes();
            int i = 0;
            foreach(int idEquipe in listIdEquipe)
            {
                equipe = new Equipe(idEquipe);
                int nbEtapesTermineesEquipe = equipe.recupererNbEtapesTermineesEquipe(idEquipe);
                graphBarre.Series["Etape"].Points.Add(nbEtapesTermineesEquipe);
                graphBarre.Series["Etape"].Points[i].Label = nbEtapesTermineesEquipe.ToString();
                graphBarre.Series["Etape"].Points[i].Color = Color.FromArgb(0, 123, 255);
                graphBarre.Series["Etape"].Points[i].AxisLabel = equipe.NomEquipe;
                graphBarre.Series["Etape"].Points[i].LegendText = equipe.NomEquipe;

                // Récupère une couleur random dans la liste puis la supprime de la liste
                var random = new Random();
                int randomInt = random.Next(colors.Length);
                var randomCouleur = colors[randomInt];
                colors = colors.Where((source, index) => index != randomInt).ToArray();

                listIdProjetsEquipe = equipe.recupererIdProjetsEquipe(idEquipe);
                equipe = new Equipe(idEquipe);
                int nbProjetsEquipe = equipe.recupererNbProjetsEquipe(idEquipe);
                graphDonut.Series["Etape"].Points.Add(nbProjetsEquipe);
                if (nbProjetsEquipe > 0)
                {
                    graphDonut.Series["Etape"].Points[i].Label = nbProjetsEquipe.ToString();
                    graphDonut.Series["Etape"].Points[i].Color = randomCouleur;
                    graphDonut.Series["Etape"].Points[i].AxisLabel = equipe.NomEquipe;
                }
                graphDonut.Series["Etape"].Points[i].LegendText = equipe.NomEquipe;
                i++;
            }

        }
    }
}