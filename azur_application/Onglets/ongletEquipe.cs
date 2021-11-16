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
    
    public partial class ongletEquipe : Form
    {

        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        MySqlDataReader reader;
        MySqlDataAdapter adpt;
        MySqlDataAdapter da;

        DataTable dt;
        DataSet ds;

        public ongletEquipe()
        {
            InitializeComponent();
            donneeEquipe();
            donneeSecteur();
        }
        
        //Affichage des équipe dans un tableau
        public void donneeEquipe()
        {
            conn.Open();
            adpt = new MySqlDataAdapter("SELECT idEquipe, idSecteur, nomEquipe, image FROM equipe", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView_equipe.DataSource = dt;
            this.dataGridView_equipe.Sort(this.dataGridView_equipe.Columns["idEquipe"], ListSortDirection.Ascending);

            conn.Close();
        }

         //Ajout équipe

        private void creer_equipe_Click(object sender, EventArgs e)
        {
            string nom_equipe = input_nom_equipe.Text;
            string idSecteur = input_idSecteur.Text;
            string image = input_image.Text;

            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            if(String.IsNullOrEmpty(nom_equipe) || String.IsNullOrEmpty(idSecteur))
            {
                if (String.IsNullOrEmpty(nom_equipe))
                {
                    MessageBox.Show("Vous devez donner un nom à l'équipe", "Erreur nom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();

                }
                if (String.IsNullOrEmpty(idSecteur))
                {
                    MessageBox.Show("Vous devez donner un idSecteur", "Erreur idSecteur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                }

            }
            else
            {
                if (String.IsNullOrEmpty(image))
                {
                    image = "../icon/equipe.png";
                }

                command.Parameters.AddWithValue("@nom_equipe", nom_equipe);
                command.Parameters.AddWithValue("@idSecteur", idSecteur);
                command.Parameters.AddWithValue("@image", image);
                

                command.CommandText = "INSERT INTO equipe (nomEquipe, idSecteur, image) VALUES(@nom_equipe, @idSecteur, @image)";
                try
                {
                    command.ExecuteNonQuery();
                }
                catch { }

                conn.Close();
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
            string nom_equipe = input_nom_equipe.Text;
            string idSecteur = input_idSecteur.Text;
            string image = input_image.Text;
            string idEquipe = label_idEquipe.Text;

            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            if (String.IsNullOrEmpty(idEquipe))
            {
                
                 MessageBox.Show("Vous devez selectioner une équipe", "Erreur équipe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 conn.Close();

            }
            else
            {
                command.Parameters.AddWithValue("@idEquipe", idEquipe);



                command.CommandText = "DELETE FROM equipe WHERE idEquipe=@idEquipe";
                try
                {
                    command.ExecuteNonQuery();
                }
                catch { }

                conn.Close();
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
            string idSecteur = input_idSecteur.Text;
            string image = input_image.Text;
            string idEquipe=label_idEquipe.Text;

            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            if (String.IsNullOrEmpty(idEquipe))
            {

                MessageBox.Show("Vous devez selectioner une équipe", "Erreur équipe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();

            }
            else
            {
            

                command.Parameters.AddWithValue("@nom_equipe", nom_equipe);
                command.Parameters.AddWithValue("@idSecteur", idSecteur);
                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@idEquipe", idEquipe);



                command.CommandText = "UPDATE equipe SET nomEquipe=@nom_equipe, idSecteur=@idSecteur, image=@image WHERE idEquipe=@idEquipe";
                try
                {
                    command.ExecuteNonQuery();
                }
                catch { }

                conn.Close();
                donneeEquipe();
                clearEquipe();
            }
        }

        private void comboBox_secteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void donneeSecteur()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idSecteur", idSecteur);

            command.CommandText = "SELECT idSecteur, nomSecteur FROM secteurs";


        }

        private void comboBox_secteur_Click(object sender, EventArgs e)
        {
            
        }
    }
    
       


    
}
        
