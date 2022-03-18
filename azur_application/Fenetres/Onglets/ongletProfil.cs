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

namespace azur_application.Onglets
{
    public partial class ongletProfil : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        Utilisateur utilisateur = new Utilisateur();
        public ongletProfil()
        {
            InitializeComponent();
        }

        private void ongletProfil_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            label_identifiant.ForeColor = ThemeColor.ActiveColor;
        }
        public void afficherAvatar()
        {
            string lienAvatar = 
            string pathImage = input_image.Text.Replace("..", @"C:\wamp64\www\ap\azur_web");
            pictureBox_avatar.Image = 
            
        }
    }
}
