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

        EquipeUtilisateur equipe_utilisateur = new EquipeUtilisateur();
        public ongletMembreGroupe()
        {
            InitializeComponent();
            donneeUtilisateurEquipe();
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
            //this.dataGridView_utilisateur_equipe.Sort(this.dataGridView_utilisateur_equipe.Columns["idEquipe"], ListSortDirection.Ascending);

        }

        //Ajout d'un utilisateur dans un groupe

        
        

        
        public void clearEquipeUtilisateur()
        {
            label_identifiant_enregistrer.Text = "";
            label_idEquipe.Text = "";
            label_equipe_enregistrer.Text = "";
            label_idUtilisateur.Text = "";

        }

        private void dataGridView_utilisateur_equipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idEquipe = dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[0].Value.ToString();
                string idUtilisateur = dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[1].Value.ToString();
                string identifiant = dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[2].Value.ToString();
                string equipe = dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[3].Value.ToString();


                label_identifiant_enregistrer.Text = identifiant;
                label_equipe_enregistrer.Text = equipe;
                label_idUtilisateur.Text = idUtilisateur;
                label_idEquipe.Text = idEquipe;
            }


        }


        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string idEmploye_enregistrer = label_idUtilisateur.Text;
            string idEquipe_eregistrer = label_idEquipe.Text;

            int idEmploye = int.Parse(idEmploye_enregistrer);
            int idEquipe = int.Parse(idEquipe_eregistrer);

            if (String.IsNullOrEmpty(idEmploye_enregistrer) && String.IsNullOrEmpty(idEquipe_eregistrer))
            {

                MessageBox.Show("Vous devez selectioner une association équipe employée", "Erreur selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                equipe_utilisateur.supprimer_utilisateur_equipe(idEmploye, idEquipe);


                donneeUtilisateurEquipe();
                clearEquipeUtilisateur();
            }
        }
    }
}
