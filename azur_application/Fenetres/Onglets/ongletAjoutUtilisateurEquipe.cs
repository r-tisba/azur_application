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
    public partial class ongletAjoutUtilisateurEquipe : Form
    {

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=theodore; pwd=azerty");
        DataTable dt;
        public ongletAjoutUtilisateurEquipe()
        {
            InitializeComponent();
            donneeUtilisateur();
            donneeEquipe();
        }
        Utilisateur utilisateur = new Utilisateur();
        Equipe equipe = new Equipe();
        EquipeUtilisateur equipe_utilisateur = new EquipeUtilisateur();

        //--------------------------------------Données des tableaux------------------------------------------------//
        
        //Tableau Utilisateur
        private void donneeUtilisateur()
        {
            dt = new DataTable();
            utilisateur.recuperationReduiteInfosUtilisateur().Fill(dt);
            dataGridView_donnees_utilisateur.DataSource = dt;
            // Par défaut : Tri croissant par idUtilisateur
            this.dataGridView_donnees_utilisateur.Sort(this.dataGridView_donnees_utilisateur.Columns["idUtilisateur"], ListSortDirection.Ascending);
        }

        //Tableau Équipe
        private void donneeEquipe()
        {
            dt = new DataTable();
            equipe.recuperationReduiteInfosEquipe().Fill(dt);
            dataGridView_donnees_equipes.DataSource = dt;
            // Par défaut : Tri croissant par idEquipe
            this.dataGridView_donnees_equipes.Sort(this.dataGridView_donnees_equipes.Columns["idEquipe"], ListSortDirection.Ascending);
        }




        

        private void ongletAjoutUtilisateurEquipe_Load(object sender, EventArgs e)
        {

        }

        //------------------------------Récuperer les Infos avec Double Clique-------------------------------//

        private void dataGridView_donnees_equipes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                label_idEquipe.Text = dataGridView_donnees_equipes.Rows[e.RowIndex].Cells[0].Value.ToString();
                label_equipe_enregistrer.Text = dataGridView_donnees_equipes.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

        }

        private void dataGridView_donnees_utilisateur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                label_idUtilisateur.Text = dataGridView_donnees_utilisateur.Rows[e.RowIndex].Cells[0].Value.ToString();
                label_identifiant_enregistrer.Text = dataGridView_donnees_utilisateur.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

        }

        //--------------------------------------Boutons d'association---------------------------------------------//

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            string idUtilisateur_saisi = label_idUtilisateur.Text;
            string idEquipe_saisi = label_idEquipe.Text;
            int idUtilisateur = int.Parse(idUtilisateur_saisi);
            int idEquipe = int.Parse(idEquipe_saisi);


            if (String.IsNullOrEmpty(idUtilisateur_saisi) || String.IsNullOrEmpty(idEquipe_saisi))
            {
                if (String.IsNullOrEmpty(idUtilisateur_saisi))
                {
                    MessageBox.Show("Vous devez donner un idUtilisateur", "Erreur idUtilisateur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (String.IsNullOrEmpty(idEquipe_saisi))
                {
                    MessageBox.Show("Vous devez donner un idEquipe", "Erreur idEquipe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                equipe_utilisateur.association_utilisateur_equipe(idEquipe, idUtilisateur);

                
                clear();
            }
        }
        //----------------------------------Remis à propre des champs--------------------------------------//

        public void clear()
        {
            label_idEquipe.Text = "";
            label_idUtilisateur.Text = "";
            label_equipe_enregistrer.Text = "";
            label_identifiant_enregistrer.Text = "";
        }



    }
}
