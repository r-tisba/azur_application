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
using azur_application.Fenetres.Onglets;

namespace azur_application.Onglets
{
    public partial class ongletProjets : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        DataTable dt;
        Projet projet = new Projet();
        private Form activeForm;
        Color rouge = Color.FromArgb(255, 0, 0);
        public static int idProjet;
        public gestion FenetreGestion;

        public ongletProjets(gestion FenetreParent)
        {
            InitializeComponent();
            displayDataProjet();
            this.FenetreGestion = FenetreParent;
        }
        private void ongletProjets_Load(object sender, EventArgs e)
        {
            LoadTheme();

            idProjet = 0;
            Equipe equipe = new Equipe();
            DataTable dt = new DataTable();
            dataGrid_projets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Select nomEquipes
            equipe.recupererNomsEquipes().Fill(dt);

            input_equipe.ValueMember = "nomEquipe";
            input_equipe.DataSource = dt;

            input_etat.DisplayMember = "Name";
            input_etat.ValueMember = "Id";

            System.Object[] ItemObject = new System.Object[2];

            ItemObject[0] = "En cours";
            ItemObject[1] = "Terminé";

            input_etat.Items.AddRange(ItemObject);
        }
        private void LoadTheme()
        {
            label_tableProjet.ForeColor = ThemeColor.ActiveColor;
            label_titreProjet.ForeColor = ThemeColor.ActiveColor;
        }

        // ------------------------------------ AFFICHAGE DATAGRID ------------------------------------
        public void displayDataProjet()
        {
            DataTable dt = new DataTable();
            projet.recupererInfosProjet().Fill(dt);
            dataGrid_projets.DataSource = dt;
            // Par défaut : Tri croissant par idEquipe
            this.dataGrid_projets.Sort(this.dataGrid_projets.Columns["Nom"], ListSortDirection.Ascending);
        }


        // ------------------------------------ DOUBLECLICK sur DataGrid pour préremplir inputs ------------------------------------
        private void dataGrid_projets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idProjet = projet.recupererIdProjetViaNomProjet(dataGrid_projets.Rows[e.RowIndex].Cells[0].Value.ToString());

                input_nom.Text = dataGrid_projets.Rows[e.RowIndex].Cells[0].Value.ToString();
                label_titreProjet.Text = dataGrid_projets.Rows[e.RowIndex].Cells[0].Value.ToString();
                input_intitule.Text = dataGrid_projets.Rows[e.RowIndex].Cells[1].Value.ToString();
                input_date_debut.Text = dataGrid_projets.Rows[e.RowIndex].Cells[2].Value.ToString();
                input_heure_debut.Text = dataGrid_projets.Rows[e.RowIndex].Cells[2].Value.ToString();
                input_date_fin.Text = dataGrid_projets.Rows[e.RowIndex].Cells[3].Value.ToString();
                input_heure_fin.Text = dataGrid_projets.Rows[e.RowIndex].Cells[3].Value.ToString();

                int bool_etat = Int16.Parse(dataGrid_projets.Rows[e.RowIndex].Cells[4].Value.ToString());
                if (bool_etat == 0)
                {
                    input_etat.Text = "En cours";
                }
                else
                {
                    input_etat.Text = "Terminé";
                }
                input_etat.Text = dataGrid_projets.Rows[e.RowIndex].Cells[4].Value.ToString();

                input_equipe.Text = dataGrid_projets.Rows[e.RowIndex].Cells[5].Value.ToString();
                input_contexte.Text = dataGrid_projets.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        // ------------------------------------ CREER PROJET ------------------------------------
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Projet projet = new Projet();

            string nomProjetSaisi = input_nom.Text;
            string intituleSaisi = input_intitule.Text;
            string dateDebutSaisi = input_date_debut.Text;
            string dateFinSaisi = input_date_fin.Text;
            string etatSaisi = input_etat.Text;
            string equipeSaisi = input_equipe.Text;
            string contexteSaisi = input_contexte.Text;

            if (String.IsNullOrEmpty(nomProjetSaisi) || String.IsNullOrEmpty(intituleSaisi) || String.IsNullOrEmpty(dateDebutSaisi) || String.IsNullOrEmpty(dateFinSaisi) || String.IsNullOrEmpty(etatSaisi) || String.IsNullOrEmpty(equipeSaisi))
            {
                if (String.IsNullOrEmpty(nomProjetSaisi)) { label_erreur.Text = "Le champ 'Nom' est obligatoire"; }
                if (String.IsNullOrEmpty(intituleSaisi)) { label_erreur.Text = "Le champ 'Intitulé' est obligatoire"; }
                if (String.IsNullOrEmpty(dateDebutSaisi)) { label_erreur.Text = "Le champ 'Début' est obligatoire"; }
                if (String.IsNullOrEmpty(dateFinSaisi)) { label_erreur.Text = "Le champ 'Fin' est obligatoire"; }
                if (String.IsNullOrEmpty(etatSaisi)) { label_erreur.Text = "Le champ 'État' est obligatoire"; }
                if (String.IsNullOrEmpty(equipeSaisi)) { label_erreur.Text = "Le champ 'Équipe' est obligatoire"; }
                conn.Close();
            }
            else
            {
                DateTime dateDebutSaisiDt = DateTime.Parse(dateDebutSaisi);
                DateTime dateFinSaisiDt = DateTime.Parse(dateFinSaisi);

                if (projet.ajouterProjet(nomProjetSaisi, intituleSaisi, dateDebutSaisiDt, dateFinSaisiDt, etatSaisi, equipeSaisi, contexteSaisi) == true)
                {
                    displayDataProjet();
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

        // ------------------------------------ MODIFIER PROJET ------------------------------------
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            MySqlCommand command = conn.CreateCommand();
            Projet projet = new Projet();

            string nomProjetSaisi = input_nom.Text;
            string intituleSaisi = input_intitule.Text;
            string jourDebutSaisi = input_date_debut.Value.ToString("yyyy-MM-dd");
            string heureDebutSaisi = input_heure_debut.Value.ToString("HH:mm:ss");
            string dateDebutSaisi = jourDebutSaisi + " " + heureDebutSaisi;
            string jourFinSaisi = input_date_fin.Value.ToString("yyyy-MM-dd");
            string heureFinSaisi = input_heure_fin.Value.ToString("HH:mm:ss");
            string dateFinSaisi = jourFinSaisi + " " + heureFinSaisi;
            string etatSaisi = input_etat.Text;
            string equipeSaisi = input_equipe.Text;
            string contexteSaisi = input_contexte.Text;

            if (String.IsNullOrEmpty(nomProjetSaisi) || String.IsNullOrEmpty(intituleSaisi) || String.IsNullOrEmpty(dateDebutSaisi) || String.IsNullOrEmpty(dateFinSaisi) || String.IsNullOrEmpty(etatSaisi) || String.IsNullOrEmpty(equipeSaisi))
            {
                if (String.IsNullOrEmpty(nomProjetSaisi)) { label_erreur.Text = "Le champ 'Nom' est obligatoire"; }
                if (String.IsNullOrEmpty(intituleSaisi)) { label_erreur.Text = "Le champ 'Intitulé' est obligatoire"; }
                if (String.IsNullOrEmpty(dateDebutSaisi)) { label_erreur.Text = "Le champ 'Début' est obligatoire"; }
                if (String.IsNullOrEmpty(dateFinSaisi)) { label_erreur.Text = "Le champ 'Fin' est obligatoire"; }
                if (String.IsNullOrEmpty(etatSaisi)) { label_erreur.Text = "Le champ 'État' est obligatoire"; }
                if (String.IsNullOrEmpty(equipeSaisi)) { label_erreur.Text = "Le champ 'Équipe' est obligatoire"; }
                conn.Close();
            }
            else
            {
                idProjet = projet.recupererIdProjetViaNomProjet(nomProjetSaisi);
                if (projet.modifierProjet(idProjet, nomProjetSaisi, intituleSaisi, dateDebutSaisi, dateFinSaisi, etatSaisi, equipeSaisi, contexteSaisi) == true)
                {
                    displayDataProjet();
                    clear();
                }
                else
                {
                    label_erreur.Text = "Erreur lors de la modification";
                    label_erreur.ForeColor = rouge;
                }
            }
        }
        // ------------------------------------ SUPPRIMER PROJET ------------------------------------
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string nomProjetSaisi = input_nom.Text;

            if (String.IsNullOrEmpty(nomProjetSaisi))
            {
                label_erreur.Text = "Vous devez selectioner un projet";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Êtes vous sûr de vouloir supprimer le projet " + nomProjetSaisi + " ainsi que toutes les étapes associées ?", "Supression du projet " + nomProjetSaisi, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {              
                    int idProjet = projet.recupererIdProjetViaNomProjet(nomProjetSaisi);
                    if (projet.supprimerProjet(idProjet))
                    {
                        displayDataProjet();
                        clear();
                    }
                    else
                    {
                        label_erreur.Text = "Erreur lors de la suppression";
                        label_erreur.ForeColor = rouge;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
        // ------------------------------------ ACCEDER AUX ETAPES ------------------------------------
        private void btn_etapes_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idProjet.ToString()) || idProjet == 0)
            {
                label_erreur.Text = "Vous devez sélectionner un projet";
            }
            else
            {
                OpenChildForm(new ongletEtapes(this), sender);
            }

            /*
            this.Hide();
            var ongletEtapes = new ongletEtapes();
            ongletEtapes.Closed += (s, args) => this.Close();
            this.panelBody.Controls.Add(ongletEtapes);
            this.panelBody.Tag = ongletEtapes;
            ongletEtapes.BringToFront();
            ongletEtapes.Show();
            */

            //OpenChildForm(new Fenetres.Onglets.ongletEtapes(), sender);
            /*
            this.Hide();
            var ongletEtapes = new ongletEtapes();
            ongletEtapes.Closed += (s, args) => this.Close();
            this.panelBody.Controls.Add(ongletEtapes);
            this.panelBody.Tag = ongletEtapes;
            ongletEtapes.BringToFront();
            ongletEtapes.Show();
            */
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            // Display de l'onglet dans le panel body
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_body.Controls.Add(childForm);
            this.panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // SearchBar
        private void filtrageDatagrid()
        {
            string colonne;
            if (radiobtn_nom.Checked == true) { colonne = "nom"; }
            else if (radiobtn_debut.Checked == true) { colonne = "debut"; }
            else if (radiobtn_fin.Checked == true) { colonne = "fin"; }
            else { colonne = "etat"; }
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGrid_projets.DataSource;
            if (colonne == "debut" || colonne == "fin")
            {
                bs.Filter = string.Format(colonne + " >= '{0} 12:00:00 AM' AND " + colonne + " <= '{0} 11:59:59 PM'", input_rechercher_dtp.Text);
            }
            else
            {
                bs.Filter = string.Format("convert(" + colonne + ", 'System.String') Like '%{0}%' ", input_rechercher.Text);

            }
            dataGrid_projets.DataSource = bs;
        }

        private void input_rechercher_KeyUp(object sender, KeyEventArgs e) { filtrageDatagrid(); }
        private void input_rechercher_dtp_KeyUp(object sender, KeyEventArgs e) { filtrageDatagrid(); }
        private void input_rechercher_dtp_CloseUp(object sender, EventArgs e) { filtrageDatagrid(); }
        private void radiobtn_nom_CheckedChanged(object sender, EventArgs e) { input_rechercher.Visible = true; input_rechercher_dtp.Visible = false; filtrageDatagrid(); }
        private void radiobtn_debut_CheckedChanged(object sender, EventArgs e) { input_rechercher.Visible = false; input_rechercher_dtp.Visible = true; filtrageDatagrid(); }
        private void radiobtn_fin_CheckedChanged(object sender, EventArgs e) { input_rechercher.Visible = false; input_rechercher_dtp.Visible = true; filtrageDatagrid(); }
        private void radiobtn_etat_CheckedChanged(object sender, EventArgs e) { input_rechercher.Visible = true; input_rechercher_dtp.Visible = false; filtrageDatagrid(); }
        private void btn_filtre_Click(object sender, EventArgs e) { filtrageDatagrid(); }
        public void clear()
        {
            label_erreur.Text = "";
            label_titreProjet.Text = "";
            input_nom.Text = "";
            input_intitule.Text = "";
            input_date_debut.Text = "";
            input_heure_debut.Text = "";
            input_date_fin.Text = "";
            input_heure_fin.Text = "";
            input_etat.Text = "";
            input_equipe.Text = "";
            input_contexte.Text = "";
        }
    }
}