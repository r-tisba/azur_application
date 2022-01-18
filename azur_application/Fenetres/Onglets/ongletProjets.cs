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

namespace azur_application.Onglets
{
    public partial class ongletProjets : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        DataTable dt;
        Projet projet = new Projet();
        Color rouge = Color.FromArgb(255, 0, 0);

        int idProjet;
        public ongletProjets()
        {
            InitializeComponent();
            displayDataProjet();
        }
        private void ongletProjets_Load(object sender, EventArgs e)
        {
            LoadTheme();

            Equipe equipe = new Equipe();
            DataTable dt = new DataTable();
            // Select nomEquipes
            equipe.recupererNomsEquipes().Fill(dt);

            input_equipe.ValueMember = "nomEquipe";
            input_equipe.DataSource = dt;

            List<Etat> liste_etats = new List<Etat>();
            liste_etats.Add(new Etat() { id = 1, name = "En cours" });
            liste_etats.Add(new Etat() { id = 2, name = "Terminé" });
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
            dataGrid_projet.DataSource = dt;
            // Par défaut : Tri croissant par idEquipe
            this.dataGrid_projet.Sort(this.dataGrid_projet.Columns["Nom"], ListSortDirection.Ascending);
        }


        // ------------------------------------ DOUBLECLICK sur DataGrid pour préremplir inputs ------------------------------------
        private void dataGrid_projet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idProjet = projet.recupererIdProjetViaNomProjet(dataGrid_projet.Rows[e.RowIndex].Cells[0].Value.ToString());

                input_nom.Text = dataGrid_projet.Rows[e.RowIndex].Cells[0].Value.ToString();
                label_titreProjet.Text = dataGrid_projet.Rows[e.RowIndex].Cells[0].Value.ToString();
                input_intitule.Text = dataGrid_projet.Rows[e.RowIndex].Cells[1].Value.ToString();
                input_debut.Text = dataGrid_projet.Rows[e.RowIndex].Cells[2].Value.ToString();
                input_fin.Text = dataGrid_projet.Rows[e.RowIndex].Cells[3].Value.ToString();

                int bool_etat = Int16.Parse(dataGrid_projet.Rows[e.RowIndex].Cells[4].Value.ToString());
                if (bool_etat == 0)
                {
                    input_etat.Text = "En cours";
                }
                else
                {
                    input_etat.Text = "Terminé";
                }
                input_etat.Text = dataGrid_projet.Rows[e.RowIndex].Cells[4].Value.ToString();

                input_equipe.Text = dataGrid_projet.Rows[e.RowIndex].Cells[5].Value.ToString();
                input_contexte.Text = dataGrid_projet.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}
