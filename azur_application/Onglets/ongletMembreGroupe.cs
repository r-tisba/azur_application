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


namespace azur_application.Onglets
{
    public partial class ongletMembreGroupe : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        MySqlDataReader reader;
        MySqlDataAdapter adpt;
        DataTable dt;

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
            conn.Open();
            adpt = new MySqlDataAdapter("SELECT idEquipe, idEmploye, utilisateurs.identifiant, equipe.nomEquipe FROM equipe_employe LEFT JOIN utilisateurs USING(idEmploye) LEFT JOIN equipe USING(idEquipe) ", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView_utilisateur_equipe.DataSource = dt;
            this.dataGridView_utilisateur_equipe.Sort(this.dataGridView_utilisateur_equipe.Columns["idEquipe"], ListSortDirection.Ascending);

            conn.Close();
        }

        //Ajout d'un utilisateur dans un groupe

        
        

        private void ajout_utilisateur_Click_1(object sender, EventArgs e)
        {
            string idUtilisateur = input_idUtilisateur.Text;
            string idEquipe = input_idEquipe.Text;

            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            if (String.IsNullOrEmpty(idUtilisateur) || String.IsNullOrEmpty(idEquipe))
            {
                if (String.IsNullOrEmpty(idUtilisateur))
                {
                    MessageBox.Show("Vous devez donner un idUtilisateur", "Erreur idUtilisateur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();

                }
                if (String.IsNullOrEmpty(idEquipe))
                {
                    MessageBox.Show("Vous devez donner un idEquipe", "Erreur idEquipe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                }

            }
            else
            {
                command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                command.Parameters.AddWithValue("@idEquipe", idEquipe);

                command.CommandText = "INSERT INTO equipe_employe (idEmploye, idEquipe) VALUES(@idUtilisateur, @idEquipe)";
                try
                {
                    command.ExecuteNonQuery();
                }
                catch { }

                conn.Close();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string idEquipe=input_idEquipe.Text;
             string idUtilisateur=input_idUtilisateur.Text;

        }
    }
}
