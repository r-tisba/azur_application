using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using azur_application.Modeles;
using System.Globalization;
using azur_application.Onglets;

namespace azur_application.Fenetres.Onglets
{
    public partial class ongletEtapes : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        Projet projet = new Projet();
        Etape etape = new Etape();
        Color rouge = Color.FromArgb(255, 0, 0);
        public static int idEtape;

        int idProjet = ongletProjets.idProjet;
        public ongletEtapes()
        {
            InitializeComponent();
            displayDataProjet();

            gestion gestion = new gestion();

            gestion.labelTitreText = this.Text;
            gestion.labelTitre.Text = this.Text;
        }

        private void ongletEtapes_Load(object sender, EventArgs e)
        {
            LoadTheme();

            string nomProjet = projet.recupererNomProjetViaIdProjet(idProjet);
            label_titreProjet.Text = nomProjet;

            Etape etapes = new Etape();
            DataTable dt = new DataTable();

            // Select nomProjets
            etapes.recupererNomsProjets().Fill(dt);

            input_projet.ValueMember = "nomProjet";
            input_projet.DataSource = dt;
            input_projet.Text = nomProjet;

            input_etat.DisplayMember = "Name";
            input_etat.ValueMember = "Id";

            System.Object[] ItemObject = new System.Object[2];

            ItemObject[0] = "En cours";
            ItemObject[1] = "Terminé";

            input_etat.Items.AddRange(ItemObject);
            barre_progression.Value = 0;
            LoadBarreProgression();
        }

        private void LoadTheme()
        {
            label_tableProjet.ForeColor = ThemeColor.ActiveColor;
            label_titreProjet.ForeColor = ThemeColor.ActiveColor;
        }

        // Barre de progression
        private void LoadBarreProgression()
        {
            int nbEtapes = projet.recupererEtapesProjet(idProjet);
            int nbEtapesFinies = projet.recupererEtapesTermineesProjet(idProjet);

            if (nbEtapes == 0 || nbEtapesFinies == 0)
            {
                barre_progression.Value = 0;
                barre_progression.SubscriptText = "0";
                barre_progression.SuperscriptMargin = new System.Windows.Forms.Padding(-65, 52, 0, 0);
            }
            else
            {
                double barreProgValue = (double)nbEtapesFinies / nbEtapes;
                barreProgValue = (double)System.Math.Round(barreProgValue, 2);
                barreProgValue = barreProgValue * 100;

                barre_progression.Minimum = 0;
                barre_progression.Maximum = 100;
                if (barreProgValue == 100)
                {
                    barre_progression.SuperscriptMargin = new System.Windows.Forms.Padding(-55, 52, 0, 0);
                }
                else if (barreProgValue >= 10 && barreProgValue < 100)
                {
                    barre_progression.SuperscriptMargin = new System.Windows.Forms.Padding(-60, 52, 0, 0);
                }
                else if (barreProgValue < 10)
                {
                    barre_progression.SuperscriptMargin = new System.Windows.Forms.Padding(-65, 52, 0, 0);
                }
                barre_progression.SubscriptText = barreProgValue.ToString();
                barre_progression.Value = (int)barreProgValue;
            }
        }

        // ------------------------------------ AFFICHAGE DATAGRID ------------------------------------
        public void displayDataProjet()
        {
            DataTable dt = new DataTable();
            etape.recupererInfosEtape(idProjet).Fill(dt);
            dataGrid_etapes.DataSource = dt;
            // Par défaut : Tri croissant par dateDebut
            this.dataGrid_etapes.Sort(this.dataGrid_etapes.Columns["DEBUT"], ListSortDirection.Ascending);
        }

        // ------------------------------------ DOUBLECLICK sur DataGrid pour préremplir inputs ------------------------------------
        private void dataGrid_etapes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEtape = etape.recupererIdEtapeViaNomEtape(dataGrid_etapes.Rows[e.RowIndex].Cells[0].Value.ToString());

                input_nom.Text = dataGrid_etapes.Rows[e.RowIndex].Cells[0].Value.ToString();
                input_date_debut.Text = dataGrid_etapes.Rows[e.RowIndex].Cells[1].Value.ToString();
                input_heure_debut.Text = dataGrid_etapes.Rows[e.RowIndex].Cells[1].Value.ToString();
                input_date_fin.Text = dataGrid_etapes.Rows[e.RowIndex].Cells[2].Value.ToString();
                input_heure_fin.Text = dataGrid_etapes.Rows[e.RowIndex].Cells[2].Value.ToString();

                int bool_etat = Int16.Parse(dataGrid_etapes.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (bool_etat == 0)
                {
                    input_etat.Text = "En cours";
                }
                else
                {
                    input_etat.Text = "Terminé";
                }
                input_etat.Text = dataGrid_etapes.Rows[e.RowIndex].Cells[3].Value.ToString();

                input_projet.Text = dataGrid_etapes.Rows[e.RowIndex].Cells[4].Value.ToString();

                // Barre de progression
            }
        }

        // ------------------------------------ CREER ETAPE ------------------------------------
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Etape etape = new Etape();

            string nomProjetSaisi = input_nom.Text;
            string jourDebutSaisi = input_date_debut.Value.ToString("yyyy-MM-dd");
            string heureDebutSaisi = input_heure_debut.Value.ToString("HH:mm:ss");
            string dateDebutSaisi = jourDebutSaisi + " " + heureDebutSaisi;
            string jourFinSaisi = input_date_fin.Value.ToString("yyyy-MM-dd");
            string heureFinSaisi = input_heure_fin.Value.ToString("HH:mm:ss");
            string dateFinSaisi = jourFinSaisi + " " + heureFinSaisi;
            string etatSaisi = input_etat.Text;
            string projetSaisi = input_projet.Text;

            if (String.IsNullOrEmpty(nomProjetSaisi) || String.IsNullOrEmpty(dateDebutSaisi) || String.IsNullOrEmpty(dateFinSaisi) || String.IsNullOrEmpty(etatSaisi) || String.IsNullOrEmpty(projetSaisi))
            {
                if (String.IsNullOrEmpty(nomProjetSaisi)) { label_erreur.Text = "Le champ 'Nom' est obligatoire"; }
                if (String.IsNullOrEmpty(dateDebutSaisi)) { label_erreur.Text = "Le champ 'Début' est obligatoire"; }
                if (String.IsNullOrEmpty(dateFinSaisi)) { label_erreur.Text = "Le champ 'Fin' est obligatoire"; }
                if (String.IsNullOrEmpty(etatSaisi)) { label_erreur.Text = "Le champ 'État' est obligatoire"; }
                if (String.IsNullOrEmpty(projetSaisi)) { label_erreur.Text = "Le champ 'Projet' est obligatoire"; }
                conn.Close();
            }
            else
            {
                DateTime dateDebutSaisiDt = DateTime.Parse(dateDebutSaisi);
                DateTime dateFinSaisiDt = DateTime.Parse(dateFinSaisi);

                if (etape.ajouterEtape(nomProjetSaisi, dateDebutSaisiDt, dateFinSaisiDt, etatSaisi, projetSaisi) == true)
                {
                    displayDataProjet();
                    LoadBarreProgression();
                    clear();
                }
                else
                {
                    label_erreur.Text = "Erreur lors de la création";
                    label_erreur.ForeColor = rouge;
                    displayDataProjet();
                }
            }
        }
        // ------------------------------------ MODIFIER ETAPE ------------------------------------
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            MySqlCommand command = conn.CreateCommand();
            Etape etape = new Etape();

            string nomEtapeSaisi = input_nom.Text;
            string jourDebutSaisi = input_date_debut.Value.ToString("yyyy-MM-dd");
            string heureDebutSaisi = input_heure_debut.Value.ToString("HH:mm:ss");
            string dateDebutSaisi = jourDebutSaisi + " " + heureDebutSaisi;
            string jourFinSaisi = input_date_fin.Value.ToString("yyyy-MM-dd");
            string heureFinSaisi = input_heure_fin.Value.ToString("HH:mm:ss");
            string dateFinSaisi = jourFinSaisi + " " + heureFinSaisi;
            string etatSaisi = input_etat.Text;

            if (String.IsNullOrEmpty(nomEtapeSaisi) || String.IsNullOrEmpty(dateDebutSaisi) || String.IsNullOrEmpty(dateFinSaisi) || String.IsNullOrEmpty(etatSaisi))
            {
                if (String.IsNullOrEmpty(nomEtapeSaisi)) { label_erreur.Text = "Le champ 'Nom' est obligatoire"; }
                if (String.IsNullOrEmpty(dateDebutSaisi)) { label_erreur.Text = "Le champ 'Début' est obligatoire"; }
                if (String.IsNullOrEmpty(dateFinSaisi)) { label_erreur.Text = "Le champ 'Fin' est obligatoire"; }
                if (String.IsNullOrEmpty(etatSaisi)) { label_erreur.Text = "Le champ 'État' est obligatoire"; }
                conn.Close();
            }
            else
            {
                idEtape = etape.recupererIdEtapeViaNomEtape(nomEtapeSaisi);
                if (etape.modifierEtape(idEtape, nomEtapeSaisi, dateDebutSaisi, dateFinSaisi, etatSaisi) == true)
                {
                    displayDataProjet();
                    LoadBarreProgression();
                    clear();
                }
                else
                {
                    label_erreur.Text = "Erreur lors de la modification";
                    label_erreur.ForeColor = rouge;
                }
            }
        }
        // ------------------------------------ SUPPRIMER ETAPE ------------------------------------
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string nomEtapeSaisi = input_nom.Text;

            if (String.IsNullOrEmpty(nomEtapeSaisi))
            {
                label_erreur.Text = "Vous devez selectioner un projet";
            }
            else
            {
                int idEtape = etape.recupererIdEtapeViaNomEtape(nomEtapeSaisi);
                if (etape.supprimerEtape(idEtape))
                {
                    displayDataProjet();
                    LoadBarreProgression();
                    clear();
                }
                else
                {
                    label_erreur.Text = "Erreur lors de la suppression";
                    label_erreur.ForeColor = rouge;
                }   
            }
        }
        // SearchBar
        private void input_rechercher_KeyUp(object sender, KeyEventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGrid_etapes.DataSource;
            bs.Filter = "nom" + " like '%" + input_rechercher.Text + "%'";
            dataGrid_etapes.DataSource = bs;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            label_erreur.Text = "";
            input_nom.Text = "";
            input_date_debut.Text = "";
            input_heure_debut.Text = "";
            input_date_fin.Text = "";
            input_heure_fin.Text = "";
            input_etat.Text = "";
            input_projet.Text = "";
            input_rechercher.Text = "";
        }
    }
}
