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

            // Select roles
            Utilisateur user = new Utilisateur();
            DataTable dt = new DataTable();
            user.recupererNomsRoles().Fill(dt);

            input_role.ValueMember = "nomRole";
            input_role.DataSource = dt;
        }
        private void LoadTheme()
        {
            label_table.ForeColor = ThemeColor.ActiveColor;
        }

        // ------------------------------------ AFFICHAGE DATAGRID ------------------------------------
        public void displayData()
        {
<<<<<<< HEAD
            Utilisateur user = new Utilisateur();
=======
            conn.Open();
            adpt = new MySqlDataAdapter("SELECT idUtilisateur, nom, prenom, identifiant, poste, idRole FROM utilisateurs", conn);
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd
            dt = new DataTable();
            user.recupererInfosUtilisateur().Fill(dt);
            dataGrid_utilisateurs.DataSource = dt;
            // Par défaut : Tri croissant par idUtilisateur
            this.dataGrid_utilisateurs.Sort(this.dataGrid_utilisateurs.Columns["idUtilisateur"], ListSortDirection.Ascending);
<<<<<<< HEAD
=======
            conn.Close();
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd
        }

        // ------------------------------------ DOUBLECLICK sur DataGrid pour préremplir inputs ------------------------------------
        private void dataGrid_utilisateurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUtilisateur = Convert.ToInt32(dataGrid_utilisateurs.Rows[e.RowIndex].Cells[0].Value.ToString());
            input_nom.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[1].Value.ToString();
            input_prenom.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[2].Value.ToString();
            input_poste.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[4].Value.ToString();
            input_role.Text = dataGrid_utilisateurs.Rows[e.RowIndex].Cells[5].Value.ToString();
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
<<<<<<< HEAD
            string roleSaisi = input_role.Text;
=======
            string idRoleSaisi = input_idRole.Text;
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd

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
<<<<<<< HEAD
                if (String.IsNullOrEmpty(roleSaisi))
=======
                if (String.IsNullOrEmpty(idRoleSaisi))
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd
                {
                    roleSaisi = "Utilisateur";
                }

                Utilisateur user = new Utilisateur();

<<<<<<< HEAD
                if (user.ajouterUtilisateur(nomSaisi, prenomSaisi, identifiant, mdpSaisiHash, posteSaisi, roleSaisi) == true)
                {
                    displayData();
                    clear();
                } 
                else
=======
                if (user.ajouterUtilisateur(nomSaisi, prenomSaisi, identifiant, mdpSaisiHash, posteSaisi, idRoleSaisi) == false)
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd
                {
                    label_erreur.Text = "Erreur lors de l'ajout";
                    Color rouge = Color.FromArgb(255, 0, 0);
                    label_erreur.ForeColor = rouge;
                    displayData();
                }
            }
        }

        // ------------------------------------ MODIFIER ------------------------------------
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            MySqlCommand command = conn.CreateCommand();

            string nomSaisi = input_nom.Text;
            string prenomSaisi = input_prenom.Text;
            string posteSaisi = input_poste.Text;
<<<<<<< HEAD
            string roleSaisi = input_role.Text;
=======
            string idRoleSaisi = input_idRole.Text;
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd

            if (String.IsNullOrEmpty(nomSaisi) || String.IsNullOrEmpty(prenomSaisi) || String.IsNullOrEmpty(posteSaisi))
            {
                if (String.IsNullOrEmpty(posteSaisi))
                {
                    label_erreur.Text = "Le champ 'Poste' est obligatoire";
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
<<<<<<< HEAD
                if (String.IsNullOrEmpty(roleSaisi))
                {
                    roleSaisi = "Utilisateur";
=======
                if (String.IsNullOrEmpty(idRoleSaisi))
                {
                    idRoleSaisi = "0";
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd
                }

                Utilisateur user = new Utilisateur();

<<<<<<< HEAD
                if (user.modifierUtilisateur(idUtilisateur, nomSaisi, prenomSaisi, posteSaisi, roleSaisi) == true)
                {
                    displayData();
                    clear();
                }
                else
=======
                if (user.modifierUtilisateur(idUtilisateur, nomSaisi, prenomSaisi, posteSaisi, idRoleSaisi) == false)
>>>>>>> 9d482ba664c636bc1a1834c44d16044b99b4f7bd
                {
                    label_erreur.Text = "Erreur lors de la modification";
                    Color rouge = Color.FromArgb(255, 0, 0);
                    label_erreur.ForeColor = rouge;
                }
            }
        }

        // ------------------------------------ SUPPRIMER ------------------------------------
        private void btn_supprimer_Click(object sender, EventArgs e)
        {

            Utilisateur user = new Utilisateur();

            if (user.supprimerUtilisateur(idUtilisateur) == true)
            {
                displayData();
                clear();
            } 
            else
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
        }

        // ------------------------------------ RESET VALEUR INPUT ------------------------------------
        public void clear()
        {
            label_erreur.Text = "";
            input_nom.Text = "";
            input_prenom.Text = "";
            input_mdp.Text = "";
            input_poste.Text = "";
            input_role.Text = "";
        }
    }
}