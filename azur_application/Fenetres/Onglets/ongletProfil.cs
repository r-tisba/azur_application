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
using System.Globalization;
using azur_application.Fenetres.Onglets;
using System.IO;
using azur_application.Services;

namespace azur_application.Onglets
{
    public partial class ongletProfil : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        Utilisateur utilisateur = new Utilisateur();
        int statutBtnAvatar = 0;
        public ongletProfil()
        {
            InitializeComponent();
        }

        private void ongletProfil_Load(object sender, EventArgs e)
        {
            LoadTheme();
            afficherInformationsProfil();
            afficherEvenement();
        }
        private void LoadTheme()
        {
            label_identifiant.ForeColor = ThemeColor.ActiveColor;
        }


        // ------------------------------------ AFFICHAGE INFOS GENERALES ------------------------------------
        public void afficherInformationsProfil()
        {
            Utilisateur utilisateur = new Utilisateur();
            int idUtilisateur = utilisateur.IdUtilisateurSession;
            // new Utilisateur(à changer)
            Utilisateur utilisateurSession = new Utilisateur(1);

            string avatar = utilisateur.recupererAvatarViaIdentifiant(utilisateurSession.Identifiant);
            string pathImage = avatar.Replace("..", @"C:\wamp64\www\ap\azur_web");

            pictureBox_avatar.Image = new Bitmap(pathImage);
            label_identifiant.Text = utilisateurSession.Identifiant;
            label_poste_u.Text = utilisateurSession.Poste;
            label_role_u.Text = utilisateurSession.Role;
            string[] equipes = utilisateurSession.Equipes;

            int count = 1;
            foreach (string element in equipes) {
                if (count == equipes.Length) { label_equipes_u.Text += element; }
                else { label_equipes_u.Text += element + " - "; count++; }
            }
        }

        // ------------------------------------ SELECTIONNER IMAGE ------------------------------------
        private void btn_modifier_avatar_Click(object sender, EventArgs e)
        {
            int idUtilisateur = 1;
            if (statutBtnAvatar == 0)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Formats d'image(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    label_image.Visible = true;
                    label_image_selectionnee.Text = open.FileName;
                    pictureBox_avatar.Image = new Bitmap(open.FileName);
                    statutBtnAvatar = 1;
                    btn_modifier_avatar.Text = "Confirmer la modification";
                    btn_modifier_avatar.BackColor = Color.FromArgb(40, 167, 69);
                }
            }
            else
            {
                string imageSaisi = label_image_selectionnee.Text;
                string nomImageSaisi = Path.GetFileName(label_image_selectionnee.Text);
                if (utilisateur.modifierAvatar(idUtilisateur, nomImageSaisi) == true)
                {
                    try
                    {
                        File.Copy(label_image_selectionnee.Text, Path.Combine(@"C:\wamp64\www\ap\azur_web\images\avatar\", Path.GetFileName(label_image_selectionnee.Text)), true);
                        clear();
                    } 
                    catch
                    {
                        clear();
                    }
                }
            }

        }

        // ------------------------------------ AFFICHAGE PROCHAIN EVEN ------------------------------------
        public void afficherEvenement()
        {
            /* int idUtilisateur = utilisateur.IdUtilisateurSession; */
            int idUtilisateur = 1;
            Evenement evenement = new Evenement();
            int idEvenement = evenement.recupererIdEvenement(idUtilisateur);
            evenement = new Evenement(idEvenement);
            Color _couleur = System.Drawing.ColorTranslator.FromHtml(evenement.BackgroundColor);

            panel_evenement.BackColor = _couleur;
            heure_deb.Text = evenement.Start;
            heure_fin.Text = evenement.End;
            label_nomEvenement.Text = evenement.Title;
            label_nomCreateur.Text = evenement.NomCreateur;
        }

        public void clear()
        {
            label_image.Visible = false;
            label_image_selectionnee.Text = "";
            btn_modifier_avatar.Text = "Modifier avatar";
            btn_modifier_avatar.BackColor = System.Drawing.Color.CornflowerBlue;
        }
    }   
}
