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
using System.IO;
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
        Color rouge = Color.FromArgb(255, 0, 0);

        int idEquipe;
        public ongletEquipe()
        {
            InitializeComponent();
            displayDataEquipe();
        }
        private void ongletEquipe_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGrid_equipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadTheme()
        {
            label_tableEquipe.ForeColor = ThemeColor.ActiveColor;
        }

        // ------------------------------------ AFFICHAGE DATAGRID ------------------------------------
        public void displayDataEquipe()
        {
            DataTable dt = new DataTable();
            equipe.recupererInfosEquipe().Fill(dt);
            dataGrid_equipe.DataSource = dt;
            // Par défaut : Tri croissant par idEquipe
            this.dataGrid_equipe.Sort(this.dataGrid_equipe.Columns["Nom"], ListSortDirection.Ascending);
        }

        // ------------------------------------ DOUBLECLICK sur DataGrid pour préremplir inputs ------------------------------------
        private void dataGrid_equipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEquipe = equipe.recupererIdEquipeViaNomEquipe(dataGrid_equipe.Rows[e.RowIndex].Cells[0].Value.ToString());
                input_nomEquipe.Text = dataGrid_equipe.Rows[e.RowIndex].Cells[0].Value.ToString();

                // ------------------ Afficher image ------------------
                input_image.Text = dataGrid_equipe.Rows[e.RowIndex].Cells[1].Value.ToString();
                if(String.IsNullOrEmpty(dataGrid_equipe.Rows[e.RowIndex].Cells[1].Value.ToString()))
                {
                    clearImage();
                }
                else
                {
                    string pathImage = input_image.Text.Replace("..", @"C:\wamp64\www\ap\azur_web");
                    pictureBox_image.Image = new Bitmap(pathImage);
                }
            }
        }

        // ------------------------------------ SELECTIONNER IMAGE ------------------------------------
        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Formats d'image(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                input_image.Text = open.FileName;
                pictureBox_image.Image = new Bitmap(open.FileName);
            }
        }

        // ------------------------------------ CREER EQUIPE ------------------------------------
        private void btn_creer_Click(object sender, EventArgs e)
        {
            string nomEquipeSaisi = input_nomEquipe.Text;
            string imageSaisi = input_image.Text;
            string nomImageSaisi = Path.GetFileName(input_image.Text);

            if (String.IsNullOrEmpty(nomEquipeSaisi))
            {
                label_erreur.Text = "Le champ 'Nom Équipe' est obligatoire";
                conn.Close();
            }
            else
            {
                Equipe equipe = new Equipe();
                if (equipe.ajouterEquipe(nomEquipeSaisi, nomImageSaisi) == true)
                {
                    if(String.IsNullOrEmpty(imageSaisi))
                    {
                        displayDataEquipe();
                        clear();
                        clearImage();
                    }
                    else
                    {
                        try
                        {
                            using (Stream stream = new FileStream(input_image.Text, FileMode.Open))
                            {
                                File.Copy(input_image.Text, Path.Combine(@"C:\wamp64\www\ap\azur_web\images\design\", Path.GetFileName(input_image.Text)), true);
                                displayDataEquipe();
                                clear();
                                clearImage();
                            }
                        }
                        catch
                        { }
                    }
                }
                else
                {
                    label_erreur.Text = "Erreur lors de la création";
                    label_erreur.ForeColor = rouge;
                    displayDataEquipe();
                }
            }
        }
        // ------------------------------------ MODIFIER EQUIPE ------------------------------------
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            MySqlCommand command = conn.CreateCommand();
            Equipe equipe = new Equipe();

            string nomEquipeSaisi = input_nomEquipe.Text;
            string imageSaisi = input_image.Text;
            string nomImageSaisi = Path.GetFileName(input_image.Text);

            if (String.IsNullOrEmpty(nomEquipeSaisi))
            {
                label_erreur.Text = "Le champ 'Nom Équipe' est obligatoire";
                conn.Close();
            }
            else
            {
                if (equipe.modifierEquipe(idEquipe, nomEquipeSaisi, nomImageSaisi) == true)
                {
                    if (String.IsNullOrEmpty(imageSaisi))
                    {
                        displayDataEquipe();
                        clear();
                        clearImage();
                    }
                    else
                    {
                        try 
                        {
                            File.Copy(input_image.Text, Path.Combine(@"C:\wamp64\www\ap\azur_web\images\design\", Path.GetFileName(input_image.Text)), true);
                        }
                        catch
                        { }

                        displayDataEquipe();
                        clear();
                        clearImage();
                    }
                }
                else
                {
                    label_erreur.Text = "Erreur lors de la modification";
                    label_erreur.ForeColor = rouge;
                }
            }
        }
        // ------------------------------------ SUPPRIMER EQUIPE ------------------------------------
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string nomEquipeSaisi = input_nomEquipe.Text;

            if (String.IsNullOrEmpty(nomEquipeSaisi))
            {
                label_erreur.Text = "Vous devez selectioner une équipe";
            }
            else
            {
                int idEquipe = equipe.recupererIdEquipeViaNomEquipe(nomEquipeSaisi);
                if(equipe.supprimerEquipe(idEquipe))
                {
                    displayDataEquipe();
                    clear();
                    clearImage();
                }
                else
                {
                    label_erreur.Text = "Erreur lors de la suppression";
                    label_erreur.ForeColor = rouge;
                }
            }
        }
        // SearchBar
        private void input_rechercher_KeyUp(object sender, KeyEventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGrid_equipe.DataSource;
            bs.Filter = "nom" + " like '%" + input_rechercher.Text + "%'";
            dataGrid_equipe.DataSource = bs;
        }

        public void clear()
        {
            label_erreur.Text = "";
            input_nomEquipe.Text = "";
            input_image.Text = "";
            input_rechercher.Text = "";
        }
        public void clearImage()
        {
            pictureBox_image.Image = null;
        }
    }
}
        
