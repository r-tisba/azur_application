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
            DataTable dt = new DataTable();
            equipe_utilisateur.liste_composition_equipe().Fill(dt);
            comboBox_equipe.ValueMember = "nomEquipe";
            comboBox_equipe.DataSource = dt;
            DataTable t = new DataTable();
            equipe_utilisateur.liste_composition_equipe().Fill(t);
            comboBox_utilisateur.ValueMember = "identifiant";
            comboBox_utilisateur.DataSource = t;
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

        
        

        private void ajout_utilisateur_Click_1(object sender, EventArgs e)
        {
            string idUtilisateur_saisi = input_idUtilisateur.Text;
            string idEquipe_saisi = input_idEquipe.Text;
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
              
                donneeUtilisateurEquipe();
                clearEquipeUtilisateur();
            }

        }
        public void clearEquipeUtilisateur()
        {
            input_idUtilisateur.Text = "";
            input_idEquipe.Text = "";
        }

        private void dataGridView_utilisateur_equipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           string idEquipe = dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[0].Value.ToString();
           string idUtilisateur = dataGridView_utilisateur_equipe.Rows[e.RowIndex].Cells[1].Value.ToString();
            input_idEquipe.Text = idEquipe;
            input_idUtilisateur.Text = idUtilisateur;
            label_idEmploye.Text = idUtilisateur;
            labelIdEquipe.Text = idEquipe;


        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            string idEmploye_enregistrer = label_idEmploye.Text;
            string idEquipe_eregistrer = labelIdEquipe.Text;

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

        private void button_modifier_Click(object sender, EventArgs e)
        {
            string idUtilisateur_saisi = input_idUtilisateur.Text;
            string idEquipe_saisi = input_idEquipe.Text;
            string idEmploye_enregistrer = label_idEmploye.Text;
            int idUtilisateur = int.Parse(idUtilisateur_saisi);
            int idEquipe = int.Parse(idEquipe_saisi);
            int idEmploye = int.Parse(idEmploye_enregistrer);
            string idEquipe_eregistrer = labelIdEquipe.Text;
            int label_IdEquipe = int.Parse(idEquipe_eregistrer);

            if (String.IsNullOrEmpty(idEquipe_saisi) && String.IsNullOrEmpty(idUtilisateur_saisi) && String.IsNullOrEmpty(idEmploye_enregistrer) && String.IsNullOrEmpty(idEquipe_eregistrer))
            {

                MessageBox.Show("Vous devez selectioner une association équipe employée", "Erreur selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                equipe_utilisateur.modifier_utilisateur_equipe(idEquipe, idUtilisateur, label_IdEquipe);

                
                donneeUtilisateurEquipe();
                clearEquipeUtilisateur();
            }
        }
    }
}
