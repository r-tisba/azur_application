using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CustomWindowsForm;
using MySql.Data.MySqlClient;
using System.Web;
using azur_application.Services;

namespace azur_application
{
    using BCrypt.Net;
    public partial class Connexion : Form
    {
        Thread th;
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        private CustomFormBorderStyle cfbs;
        public Connexion()
        { 
            InitializeComponent();
            conn.Open();

            // Masque la saisie du mdp
            inputMdp.PasswordChar = '*';
            // Avertit si CapsLock est activé dans l'input de mdp
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("Le Verrouill.Maj est ACTIF.");
            }
        }

        bool exit = true;

        // ------------------------------ DEPLACEMENT & RESIZE DE LA FENETRE ------------------------------
        private void Connexion_Load(object sender, EventArgs e)
        {
            cfbs = new CustomFormBorderStyle(this, _MaxButton, _MinButton, _CloseButton);
        }
        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            cfbs.TopBorderPanel_MouseMove(sender, e);
        }
        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            cfbs.TopBorderPanel_MouseUp(sender, e);
        }
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            cfbs.TopBorderPanel_MouseDown(sender, e);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            cfbs.TopPanel_MouseMove(sender, e);
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            cfbs.TopPanel_MouseUp(sender, e);
        }
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            cfbs.TopPanel_MouseDown(sender, e);
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            cfbs.LeftPanel_MouseMove(sender, e);
        }
        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            cfbs.LeftPanel_MouseUp(sender, e);
        }
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            cfbs.LeftPanel_MouseDown(sender, e);
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            cfbs.RightPanel_MouseMove(sender, e);
        }
        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            cfbs.RightPanel_MouseUp(sender, e);
        }
        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            cfbs.RightPanel_MouseDown(sender, e);
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            cfbs.BottomPanel_MouseMove(sender, e);
        }
        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            cfbs.BottomPanel_MouseUp(sender, e);
        }
        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            cfbs.BottomPanel_MouseDown(sender, e);
        }

        // ------------------------------ BOUTONS MIN, MAX, CLOSE ------------------------------
        private void _MinButton_Click(object sender, EventArgs e)
        {
            cfbs._MinButton_Click(sender, e);
        }
        private void _MaxButton_Click(object sender, EventArgs e)
        {
            cfbs._MaxButton_Click(sender, e);
        }
        private void _CloseButton_Click(object sender, EventArgs e)
        {
            cfbs._CloseButton_Click(sender, e);
        }

        // ------------------------------ BOUTON CONNEXION, VERIFICATION CONFORMITE ------------------------------

        private void boutonConnexion_Click(object sender, EventArgs e)
        {
            string identifiantSaisi = inputIdentifiant.Text;
            string mdpSaisi = inputMdp.Text;

            Color rouge = Color.FromArgb(255, 0, 0);
            Color vert = Color.FromArgb(0, 128, 0);


            if (String.IsNullOrEmpty(identifiantSaisi))
            {
                message_erreur.Text = "Veuillez saisir un identifiant";
                message_erreur.ForeColor = rouge;
            }
            else if(String.IsNullOrEmpty(mdpSaisi))
            {
                message_erreur.Text = "Veuillez saisir un mot de passe";
                message_erreur.ForeColor = rouge;
            } 

            else
            {
                MySqlCommand command = conn.CreateCommand();

                command.Parameters.AddWithValue("@identifiantSaisi", identifiantSaisi);
                command.CommandText = "SELECT mdp, role FROM utilisateurs WHERE identifiant = @identifiantSaisi";
                try
                {
                    conn.Open();
                }
                catch
                {
                    message_erreur.Text = "Cet identifiant n'existe pas";
                    message_erreur.ForeColor = rouge;
                }
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string mdp = reader.GetString(0);
                    string role = reader.GetString(1);

                    // Renvoi booléen
                    if (BCrypt.Verify(mdpSaisi, mdp) == false)
                    {
                        message_erreur.Text = "Mot de passe erroné";
                        message_erreur.ForeColor = rouge;
                    }
                    else
                    {
                        if (role != "Admin" && role != "SuperAdmin")
                        {
                            message_erreur.Text = "Vous n'êtes pas admin";
                            message_erreur.ForeColor = rouge;
                        }
                        else
                        {
                            message_erreur.Text = "Vous êtes connecté";
                            message_erreur.ForeColor = vert;

                            this.Close();
                            th = new Thread(ouvrirNouvellePage);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();

                            /*
                            this.Hide();
                            gestion gest = new gestion();
                            gest.ShowDialog();
                            */

                        }
                    }
                }
                conn.Close();
            }
        }

        private void ouvrirNouvellePage()
        {
            Application.Run(new gestion());
        }
    }
}