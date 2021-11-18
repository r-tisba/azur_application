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
        MySqlDataReader reader;
        MySqlDataAdapter adpt;
        MySqlDataAdapter da;

        DataTable dt;
        DataSet ds;

        Equipe equipe = new Equipe();

        public ongletEquipe()
        {
            InitializeComponent();
            donneeEquipe();
        }
        
        //Affichage des équipe dans un tableau
        public void donneeEquipe()
        {
            
            dt = new DataTable();
            equipe.recupererInfosEquipe();
            dataGridView_equipe.DataSource = dt;
            this.dataGridView_equipe.Sort(this.dataGridView_equipe.Columns["idEquipe"], ListSortDirection.Ascending);

        }

         //Ajout équipe

        private void creer_equipe_Click(object sender, EventArgs e)
        {
            string nom_equipe = input_nom_equipe.Text;
            string idSecteur_saisi = input_idSecteur.Text;
            int idSecteur = int.Parse(idSecteur_saisi);
            string image = input_image.Text;

            
            if(String.IsNullOrEmpty(nom_equipe) || String.IsNullOrEmpty(idSecteur_saisi))
            {
                if (String.IsNullOrEmpty(nom_equipe))
                {
                    MessageBox.Show("Vous devez donner un nom à l'équipe", "Erreur nom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                if (String.IsNullOrEmpty(idSecteur_saisi))
                {
                    MessageBox.Show("Vous devez donner un idSecteur", "Erreur idSecteur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                if (String.IsNullOrEmpty(image))
                {
                    image = "../icon/equipe.png";
                }
                equipe.ajout_equipe(nom_equipe, image, idSecteur);

                
                donneeEquipe();
                clearEquipe();
            }
            
        }
        public void clearEquipe()
        {
            input_nom_equipe.Text = "";
            input_idSecteur.Text = "";
            input_image.Text = "";
        }

        private void button_suppr_Click(object sender, EventArgs e)
        {
            
            string idEquipe_enregistrer = label_idEquipe.Text;
            int idEquipe = int.Parse(idEquipe_enregistrer);



            if (String.IsNullOrEmpty(idEquipe_enregistrer))
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
            label_idEquipe.Text= dataGridView_equipe.Rows[e.RowIndex].Cells[0].Value.ToString();
            input_idSecteur.Text = dataGridView_equipe.Rows[e.RowIndex].Cells[1].Value.ToString();
            input_nom_equipe.Text= dataGridView_equipe.Rows[e.RowIndex].Cells[2].Value.ToString();
            input_image.Text = dataGridView_equipe.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void button_modif_Click(object sender, EventArgs e)
        {
            string nom_equipe = input_nom_equipe.Text;
            string idSecteur_saisi = input_idSecteur.Text;
            string image = input_image.Text;
            string idEquipe_enregistrer=label_idEquipe.Text;
            int idEquipe = int.Parse(idEquipe_enregistrer);
            int idSecteur = int.Parse(idSecteur_saisi);


            if (String.IsNullOrEmpty(idEquipe_enregistrer))
            {

                MessageBox.Show("Vous devez selectioner une équipe", "Erreur équipe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                equipe.modifier_equipe(nom_equipe, idSecteur, image, idEquipe);
                donneeEquipe();
                clearEquipe();
            }
        }

        private void comboBox_secteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void comboBox_secteur_Click(object sender, EventArgs e)
        {
            
        }

        private void ongletEquipe_Load(object sender, EventArgs e)
        {

        }
    }
    
       


    
}
        
