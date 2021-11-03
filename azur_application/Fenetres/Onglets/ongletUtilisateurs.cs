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
            adpt = new MySqlDataAdapter("SELECT idUtilisateur, nom, prenom, identifiant, poste, idEquipe, idRole FROM utilisateurs", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGrid_utilisateurs.DataSource = dt;
            // Par défaut : Tri croissant par idUtilisateur
            this.dataGrid_utilisateurs.Sort(this.dataGrid_utilisateurs.Columns["idUtilisateur"], ListSortDirection.Ascending);
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

                Utilisateur user = new Utilisateur();

                if (user.ajouterUtilisateur(nomSaisi, prenomSaisi, identifiant, mdpSaisiHash, posteSaisi, idEquipeSaisi, idRoleSaisi) == false)
                {
                    label_erreur.Text = "Erreur lors de l'ajout";
                    Color rouge = Color.FromArgb(255, 0, 0);
                    label_erreur.ForeColor = rouge;
                }

                displayData();
                clear();
            }
        }

        // ------------------------------------ MODIFIER ------------------------------------
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            MySqlCommand command = conn.CreateCommand();

            string nomSaisi = input_nom.Text;
            string prenomSaisi = input_prenom.Text;
            string posteSaisi = input_poste.Text;
            string idEquipeSaisi = input_idEquipe.Text;
            string idRoleSaisi = input_idRole.Text;

            if (String.IsNullOrEmpty(nomSaisi) || String.IsNullOrEmpty(prenomSaisi) || String.IsNullOrEmpty(posteSaisi))
            {
                MessageBox.Show("Les inputs : 'Nom', 'Prénom' et 'Poste' sont obligatoires");
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

                Utilisateur user = new Utilisateur();

<<<<<<< HEAD:azur_application/Onglets/ongletUtilisateurs.cs
                command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                command.CommandText = "UPDATE utilisateurs SET nom = @nomSaisi, prenom = @prenomSaisi, mdp = @mdpSaisi, " +
                    "poste = @posteSaisi, idEquipe = @idEquipeSaisi, idRole = @idRoleSaisi WHERE idUtilisateur = @idUtilisateur";
                command.ExecuteNonQuery();
=======
                if (user.modifierUtilisateur(idUtilisateur, nomSaisi, prenomSaisi, posteSaisi, idEquipeSaisi, idRoleSaisi) == false)
                {
                    label_erreur.Text = "Erreur lors de la modification";
                    Color rouge = Color.FromArgb(255, 0, 0);
                    label_erreur.ForeColor = rouge;
                }
>>>>>>> 2324c197d6353ee1777fdc5cb3833e13f876d99d:azur_application/Fenetres/Onglets/ongletUtilisateurs.cs

                displayData();
                clear();
            }
        }

        // ------------------------------------ SUPPRIMER ------------------------------------
        private void btn_supprimer_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD:azur_application/Onglets/ongletUtilisateurs.cs
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.CommandText = "DELETE FROM utilisateurs WHERE idUtilisateur = @idUtilisateur";
            command.ExecuteNonQuery();
=======
            Utilisateur user = new Utilisateur();

            if (user.supprimerUtilisateur(idUtilisateur) == false)
            {
                label_erreur.Text = "Erreur lors de la supression";
                Color rouge = Color.FromArgb(255, 0, 0);
                label_erreur.ForeColor = rouge;

                if (idUtilisateur == 0)
                {
                    label_erreur.Text = "Veuillez sélectionner un utilisateur";
                    label_erreur.ForeColor = rouge;
                }
            }
>>>>>>> 2324c197d6353ee1777fdc5cb3833e13f876d99d:azur_application/Fenetres/Onglets/ongletUtilisateurs.cs

            displayData();
            clear();
        }

        // ------------------------------------ RESET VALEUR INPUT ------------------------------------
        public void clear()
        {
            label_erreur.Text = "";
            input_nom.Text = "";
            input_prenom.Text = "";
            input_mdp.Text = "";
            input_poste.Text = "";
            input_idEquipe.Text = "";
            input_idRole.Text = "";
        }
    }
}