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
    
    public partial class ongletEquipe : Form
    {

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        
        DataTable dt;

        Equipe equipe = new Equipe();

        public ongletEquipe()
        {
            InitializeComponent();
            donneeEquipe();
        }
        int idEquipe = 0;
        //Affichage des équipe dans un tableau
        public void donneeEquipe()
        {
            
            dt = new DataTable();
            equipe.recupererInfosEquipe().Fill(dt);
            dataGridView_equipe.DataSource = dt;
            this.dataGridView_equipe.Sort(this.dataGridView_equipe.Columns["idEquipe"], ListSortDirection.Ascending);

        }

         //Ajout équipe

        private void creer_equipe_Click(object sender, EventArgs e)
        {
            string nom_equipe = input_nom_equipe.Text;
            string image = input_image.Text;

            
            if(String.IsNullOrEmpty(nom_equipe))
            {
            
                MessageBox.Show("Vous devez donner un nom à l'équipe", "Erreur nom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                              
               
            }
            else
            {
                if (String.IsNullOrEmpty(image))
                {
                    image = "../icon/equipe.png";
                }
                equipe.ajout_equipe(nom_equipe, image);

                
                donneeEquipe();
                clearEquipe();
            }
            
        }
        public void clearEquipe()
        {
            input_nom_equipe.Text = "";
            input_image.Text = "";
            idEquipe = 0;
        }

        private void button_suppr_Click(object sender, EventArgs e)
        {



            if (idEquipe == 0)
            {

                MessageBox.Show("Vous devez selectioner une équipe", "Erreur équipe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                equipe.supprimer_equipe(idEquipe);
                donneeEquipe();
                clearEquipe();
            }

        }

        private void dataGridView_equipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEquipe = int.Parse(dataGridView_equipe.Rows[e.RowIndex].Cells[0].Value.ToString());
                input_nom_equipe.Text= dataGridView_equipe.Rows[e.RowIndex].Cells[1].Value.ToString();
                input_image.Text = dataGridView_equipe.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            

        }

        private void button_modif_Click(object sender, EventArgs e)
        {
            string nom_equipe = input_nom_equipe.Text;
            string image = input_image.Text;
            


            if (idEquipe==0 || String.IsNullOrEmpty(nom_equipe))
            {

                MessageBox.Show("Vous devez selectioner une équipe et ne pas rendre vide le champ Nom Équipe", "Erreur équipe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                equipe.modifier_equipe(nom_equipe, image, idEquipe);
                donneeEquipe();
                clearEquipe();
            }
        }

        
        

        

        private void ongletEquipe_Load(object sender, EventArgs e)
        {
            


        }
    }
    
       


    
}
        
