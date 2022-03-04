using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomWindowsForm;
using System.Threading;
using MySql.Data.MySqlClient;
using azur_application.Modeles;
using azur_application.Services;

namespace azur_application.Fenetres.Onglets
{
    public partial class ongletAffectations : Form
    {

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        DataTable dt;
        Utilisateur utilisateur = new Utilisateur();
        Equipe equipe = new Equipe();
        Affectation affectation = new Affectation();
        public ongletAffectations()
        {
            InitializeComponent();
            displayDataUtilisateur();
            displayDataComposition();
        }
        private void ongletAffectations_Load(object sender, EventArgs e)
        {
            LoadTheme();

            Equipe equipe = new Equipe();
            DataTable dt = new DataTable();
            dataGrid_utilisateurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_compositionEquipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Select nomEquipes
            equipe.recupererNomsEquipes().Fill(dt);

            input_equipe.ValueMember = "nomEquipe";
            input_equipe.DataSource = dt;
        }
        private void LoadTheme()
        {
            label_tableUtilisateurs.ForeColor = ThemeColor.ActiveColor;
            label_tableCompositions.ForeColor = ThemeColor.ActiveColor;
        }

        // ------------------------------------ AFFICHAGE DATAGRID ------------------------------------

        // Tableau Utilisateurs
        private void displayDataUtilisateur()
        {
            DataTable dt = new DataTable();
            utilisateur.recuperationReduiteInfosUtilisateur().Fill(dt);
            dataGrid_utilisateurs.DataSource = dt;
            // Par défaut : Tri croissant par idUtilisateur
            this.dataGrid_utilisateurs.Sort(this.dataGrid_utilisateurs.Columns["ID"], ListSortDirection.Ascending);
        }

        // Tableau Compositions
        private void displayDataComposition()
        {
            DataTable dt = new DataTable();
            affectation.donneeCompoClaires().Fill(dt);
            dataGrid_compositionEquipes.DataSource = dt;
            // Par défaut : Tri croissant par identifiant
            this.dataGrid_compositionEquipes.Sort(this.dataGrid_compositionEquipes.Columns["IDENTIFIANT"], ListSortDirection.Ascending);
        }

        // ------------------------------------ DOUBLECLICK sur DataGrid pour préremplir inputs ------------------------------------
        private void dataGrid_utilisateur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                input_identifiant.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void dataGrid_composition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                input_identifiant.Text = dataGrid_compositionEquipes.Rows[e.RowIndex].Cells[0].Value.ToString();
                input_equipe.Text = dataGrid_compositionEquipes.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        // ------------------------------------ CREER ASSOCIATION ------------------------------------

        private void btn_associer_Click(object sender, EventArgs e)
        {
            string identifiantSaisi = input_identifiant.Text;
            string nomEquipeSaisi = input_equipe.Text;

            int idUtilisateur = utilisateur.recupererIdUtilisateurViaIdentifiant(identifiantSaisi);
            int idEquipe = equipe.recupererIdEquipeViaNomEquipe(nomEquipeSaisi);

            if(affectation.verifierAssociation(idUtilisateur, idEquipe) == false)
            {
                if (String.IsNullOrEmpty(identifiantSaisi) || String.IsNullOrEmpty(nomEquipeSaisi))
                {
                    if (String.IsNullOrEmpty(identifiantSaisi)) { label_erreur.Text = "Le champ 'Identifiant' est obligatoire"; }
                    if (String.IsNullOrEmpty(nomEquipeSaisi)) { label_erreur.Text = "Le champ 'Équipe' est obligatoire"; }
                    conn.Close();
                }
                else
                {
                    Affectation equipeUtilisateur = new Affectation();
                    if (equipeUtilisateur.associationUtilisateurEquipe(idEquipe, idUtilisateur) == true)
                    {
                        displayDataComposition();
                        clear();
                    }
                    else
                    {
                        label_erreur.Text = "Erreur lors de l'association";
                        Color rouge = Color.FromArgb(255, 0, 0);
                        label_erreur.ForeColor = rouge;
                        displayDataComposition();
                    }   
                }
            } else
            {
                label_erreur.Text = "Cet utilisateur est déjà présent dans l'équipe";
            }
        }

        // ------------------------------------ SUPPRIMER ASSOCIATION ------------------------------------

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string identifiantSaisi = input_identifiant.Text;
            string nomEquipeSaisi = input_equipe.Text;

            if (String.IsNullOrEmpty(identifiantSaisi) || String.IsNullOrEmpty(nomEquipeSaisi))
            {
                label_erreur.Text = "Veuillez sélectionner une association";
            }
            else
            {
                Affectation equipeUtilisateur = new Affectation();

                int idUtilisateur = utilisateur.recupererIdUtilisateurViaIdentifiant(identifiantSaisi);
                int idEquipe = equipe.recupererIdEquipeViaNomEquipe(nomEquipeSaisi);

                if (equipeUtilisateur.supprimerAssociation(idUtilisateur, idEquipe) == true)
                {
                    displayDataComposition();
                    clear();
                }
                else
                {
                    label_erreur.Text = "Erreur lors de la suppression";
                    Color rouge = Color.FromArgb(255, 0, 0);
                    label_erreur.ForeColor = rouge;
                    displayDataComposition();
                }
            }
        }

        // SearchBar
        private void input_rechercher_KeyUp(object sender, KeyEventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGrid_utilisateurs.DataSource;
            bs.Filter = "identifiant" + " like '%" + input_rechercher.Text + "%'";
            dataGrid_utilisateurs.DataSource = bs;

            BindingSource bs2 = new BindingSource();
            bs2.DataSource = dataGrid_compositionEquipes.DataSource;
            bs2.Filter = "identifiant" + " like '%" + input_rechercher.Text + "%'";
            dataGrid_compositionEquipes.DataSource = bs2;
        }

        // ------------------------------------ RESET VALEUR INPUT ------------------------------------
        public void clear()
        {
            label_erreur.Text = "";
            input_equipe.Text = "";
            input_identifiant.Text = "";
            input_rechercher.Text = "";
        }
    }
}
