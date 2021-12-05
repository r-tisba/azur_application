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


namespace azur_application.Onglets
{
    public partial class ongletMembreGroupe : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        DataTable dt;

        Utilisateur utilisateur = new Utilisateur();
        Equipe equipe = new Equipe();
        EquipeUtilisateur equipe_utilisateur = new EquipeUtilisateur();
        int idUtilisateur = 0;
        int idEquipe = 0;
        public ongletMembreGroupe()
        {
            InitializeComponent();
            donneeUtilisateurEquipe();
            donneeUtilisateur();
            donneeEquipe();
        }
        

        private void ongletMembreGroupe_Load(object sender, EventArgs e)
        {
            
        }
        //Affichage des des utilisateur et de leur groupe
        public void donneeUtilisateurEquipe()
        {
            dt = new DataTable();
            equipe_utilisateur.donneeCompo().Fill(dt);
            dataGridView_utilisateur_equipe.DataSource = dt;
            this.dataGridView_utilisateur_equipe.Sort(this.dataGridView_utilisateur_equipe.Columns["idEquipe"], ListSortDirection.Ascending);

        }
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


        //Ajout d'un utilisateur dans un groupe





        public void clearEquipeUtilisateur()
        {
            label_identifiant_enregistrer.Text = "";
            label_equipe_enregistrer.Text = "";
            idEquipe = 0;
            idUtilisateur = 0;

        }
        public void clear()
        {
            label_equipe_enregistrer.Text = "";
            label_identifiant_enregistrer.Text = "";
            idUtilisateur = 0;
            idEquipe = 0;
        }
        private void dataGridView_utilisateur_equipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEquipe = int.Parse(dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[0].Value.ToString());
                idUtilisateur = int.Parse(dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[1].Value.ToString());
                string identifiant = dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[2].Value.ToString();
                string equipe = dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[3].Value.ToString();


                label_identifiant_enregistrer.Text = identifiant;
                label_equipe_enregistrer.Text = equipe;
                
            }


        }


        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            

            if (idUtilisateur==0 || idEquipe==0)
            {

                MessageBox.Show("Vous devez selectioner une association équipe employée", "Erreur selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                equipe_utilisateur.supprimer_utilisateur_equipe(idUtilisateur, idEquipe);


                donneeUtilisateurEquipe();
                clearEquipeUtilisateur();
            }
        }

        

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            bool verification = equipe_utilisateur.verif_compos(idEquipe, idUtilisateur);

            if (idUtilisateur == 0 || idEquipe == 0)
            {

                MessageBox.Show("Vous devez selectionner une equipe et un utilisateur", "Erreur compo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                if (verification == true)
                {
                    equipe_utilisateur.association_utilisateur_equipe(idEquipe, idUtilisateur);
                }
                else
                {
                    MessageBox.Show("L'utilisateur est déjà dans l'équipe", "Erreur composition existante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                donneeUtilisateurEquipe();
                clear();
            }
        }

        private void dataGridView_donnees_utilisateur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idUtilisateur = int.Parse(dataGridView_donnees_utilisateur.Rows[e.RowIndex].Cells[0].Value.ToString());
                label_identifiant_enregistrer.Text = dataGridView_donnees_utilisateur.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

        }

        private void dataGridView_donnees_equipes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEquipe = int.Parse(dataGridView_donnees_equipes.Rows[e.RowIndex].Cells[0].Value.ToString());
                label_equipe_enregistrer.Text = dataGridView_donnees_equipes.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
