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

namespace azur_application.Onglets
{
    using BCrypt.Net;
    public partial class ongletUtilisateurs : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        MySqlDataReader reader;
        MySqlDataAdapter adpt;
        DataTable dt;

        int idUtilisateur;
        public ongletUtilisateurs()
        {
            InitializeComponent();
            displayData();
        }
        private void ongletUtilisateurs_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            label_table.ForeColor = ThemeColor.ActiveColor;
        }

        // ------------------------------------ AFFICHAGE DATAGRID ------------------------------------
        public void displayData()
        {
            conn.Open();
            adpt = new MySqlDataAdapter("SELECT idEmploye, nom, prenom, identifiant, poste, idEquipe, idRole FROM utilisateurs", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGrid_utilisateurs.DataSource = dt;
            // Par défaut : Tri croissant par idEmploye
            this.dataGrid_utilisateurs.Sort(this.dataGrid_utilisateurs.Columns["idEmploye"], ListSortDirection.Ascending);
            conn.Close();
        }
        // ------------------------------------ DOUBLECLICK sur DataGrid pour préremplir inputs ------------------------------------
        private void dataGrid_utilisateurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUtilisateur = Convert.ToInt32(dataGrid_utilisateurs.Rows[e.RowIndex].Cells[0].Value.ToString());
            input_nom.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[1].Value.ToString();
            input_prenom.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[2].Value.ToString();
            input_poste.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[4].Value.ToString();
            input_idEquipe.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[5].Value.ToString();
            input_idRole.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        // ------------------------------------ AJOUT ------------------------------------
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            string nomSaisi = input_nom.Text;
            string prenomSaisi = input_prenom.Text;
            string identifiant = prenomSaisi.ToLower() + "." + nomSaisi.ToLower();
            string mdpSaisi = input_mdp.Text;
            string mdpSaisiHash = BCrypt.HashPassword(mdpSaisi);
            string posteSaisi = input_poste.Text;
            string idEquipeSaisi = input_idEquipe.Text;
            string idRoleSaisi = input_idRole.Text;

            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            if (String.IsNullOrEmpty(nomSaisi) || String.IsNullOrEmpty(prenomSaisi) || String.IsNullOrEmpty(mdpSaisi) || String.IsNullOrEmpty(posteSaisi))
            {
                if (String.IsNullOrEmpty(posteSaisi))
                {
                    label_erreur.Text = "Le champ 'Poste' est obligatoire";
                }
                if (String.IsNullOrEmpty(mdpSaisi))
                {
                    label_erreur.Text = "Le champ 'Mot de passe' est obligatoire";
                }
                if (String.IsNullOrEmpty(prenomSaisi))
                {
                    label_erreur.Text = "Le champ 'Prénom' est obligatoire";
                }
                if (String.IsNullOrEmpty(nomSaisi))
                {
                    label_erreur.Text = "Le champ 'Nom' est obligatoire";
                }
                conn.Close();
            }

            else
            {
                // Oui cette condition est stupide mais ça marche (vide != null)
                if (String.IsNullOrEmpty(idEquipeSaisi))
                {
                    idEquipeSaisi = null;
                }
                if (String.IsNullOrEmpty(idRoleSaisi))
                {
                    idRoleSaisi = "0";
                }

                command.Parameters.AddWithValue("@nomSaisi", nomSaisi);
                command.Parameters.AddWithValue("@prenomSaisi", prenomSaisi);
                command.Parameters.AddWithValue("@identifiant", identifiant);
                command.Parameters.AddWithValue("@mdpSaisi", mdpSaisiHash);
                command.Parameters.AddWithValue("@posteSaisi", posteSaisi);
                command.Parameters.AddWithValue("@idEquipeSaisi", idEquipeSaisi);
                command.Parameters.AddWithValue("@idRoleSaisi", idRoleSaisi);

                command.CommandText = "INSERT INTO utilisateurs (nom, prenom, identifiant, mdp, poste, idEquipe, idRole) VALUES(@nomSaisi, @prenomSaisi, @identifiant, @mdpSaisi, @posteSaisi, @idEquipeSaisi, @idRoleSaisi)";
                try
                {
                    command.ExecuteNonQuery();
                } catch { }

                conn.Close();
                displayData();
                clear();
            }
        }

        // ------------------------------------ MODIFIER ------------------------------------
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string nomSaisi = input_nom.Text;
            string prenomSaisi = input_prenom.Text;
            string mdpSaisi = input_mdp.Text;
            string posteSaisi = input_poste.Text;
            string idEquipeSaisi = input_idEquipe.Text;
            string idRoleSaisi = input_idRole.Text;

            if (String.IsNullOrEmpty(nomSaisi) || String.IsNullOrEmpty(prenomSaisi) || String.IsNullOrEmpty(mdpSaisi) || String.IsNullOrEmpty(posteSaisi))
            {
                MessageBox.Show("Les inputs : 'Nom', 'Prénom', 'Mot de passe' et 'Poste' sont obligatoires");
                conn.Close();
            }
            else
            {
                // Oui cette condition est stupide mais ça marche (vide != null)
                if (String.IsNullOrEmpty(idEquipeSaisi))
                {
                    idEquipeSaisi = null;
                }
                if (String.IsNullOrEmpty(idRoleSaisi))
                {
                    idRoleSaisi = "0";
                }

                command.Parameters.AddWithValue("@nomSaisi", nomSaisi);
                command.Parameters.AddWithValue("@prenomSaisi", prenomSaisi);
                command.Parameters.AddWithValue("@mdpSaisi", mdpSaisi);
                command.Parameters.AddWithValue("@posteSaisi", posteSaisi);
                command.Parameters.AddWithValue("@idEquipeSaisi", idEquipeSaisi);
                command.Parameters.AddWithValue("@idRoleSaisi", idRoleSaisi);

                command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                command.CommandText = "UPDATE utilisateurs SET nom = @nomSaisi, prenom = @prenomSaisi, mdp = @mdpSaisi, " +
                    "poste = @posteSaisi, idEquipe = @idEquipeSaisi, idRole = @idRoleSaisi WHERE idEmploye = @idUtilisateur";
                command.ExecuteNonQuery();

                conn.Close();
                displayData();
                clear();
            }
        }

        // ------------------------------------ SUPPRIMER ------------------------------------
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.CommandText = "DELETE FROM utilisateurs WHERE idEmploye = @idUtilisateur";
            command.ExecuteNonQuery();

            conn.Close();
            displayData();
            clear();
        }

        // ------------------------------------ RESET VALEUR INPUT ------------------------------------
        public void clear()
        {
            input_nom.Text = "";
            input_prenom.Text = "";
            input_mdp.Text = "";
            input_poste.Text = "";
        }
    }
}