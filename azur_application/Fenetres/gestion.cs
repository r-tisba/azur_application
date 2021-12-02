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
using Syncfusion.Windows.Forms.Tools;
using azur_application.Services;

namespace azur_application
{
    public partial class gestion : Form
    {
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        private CustomFormBorderStyle cfbs;

        public gestion()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChild.Visible = false;
        }

        // ------------------------------------ DEPLACEMENT & RESIZE DE LA FENETRE ------------------------------------
        private void gestion_Load(object sender, EventArgs e)
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

        // ------------------------------------ BOUTONS MIN, MAX, CLOSE ------------------------------------
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

        // ------------------------------------ STYLE BOUTONS MENU ------------------------------------

        // Selectionne une couleur random à partir de la liste
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            // Si la couleur à déjà été selectionné, on en pioche une nouvelle
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                // Modifie l'apparence du bouton cliqué & panel titre
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Lato", 12.5F);
                    // Modifie la couleur du panel titre
                    panelTitle.BackColor = color;

                    ThemeColor.ActiveColor = color;

                    btnCloseChild.Visible = true;
                }
            }
        }
        // Etat par défaut du bouton
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(52, 58, 64);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Lato", 10F);
                }
            }
        }

        // ------------------------------------ OUVERTURE DES ONGLETS ------------------------------------

        // Ouverture de la sous-page dans le panel body
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            // Display de l'onglet dans le panel body
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelBody.Controls.Add(childForm);
            this.panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            // Change le titre par celui de l'onglet
            labelTitre.Text = childForm.Text;
            labelTitre.ForeColor = Color.White;
        }

        // ------------------------------------ BOUTONS NAVBAR ------------------------------------
        private void btnProfil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Onglets.ongletProfil(), sender);
        }

        private void btnUtilisateurs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Onglets.ongletUtilisateurs(), sender);
        }

        private void btnProjets_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Onglets.ongletProjets(), sender);
        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Onglets.ongletStatistiques(), sender);
        }

        private void btnParametres_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Onglets.ongletParametres(), sender);
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        // ------------------------------------ RESET ------------------------------------
        private void Reset()
        {
            DisableButton();
            labelTitre.Text = "ACCUEIL";
            panelTitle.BackColor = Color.FromArgb(36, 42, 48);
            panelLogo.BackColor = Color.FromArgb(0, 132, 234);
            currentButton = null;
            btnCloseChild.Visible = false;
        }
    }
}
