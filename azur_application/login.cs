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
using Microsoft.AspNetCore.Http;
using System.Web;



namespace azur_application
{
    using BCrypt.Net;
    public partial class Connexion : Form
    {
        Thread th;
        MySqlConnection conn = new MySqlConnection("database=gestion; server=localhost; user id=root; pwd=");
        public Connexion()
        {
            InitializeComponent();
            conn.Open();

            // Masque la saisie du mdp
            inputMdp.PasswordChar = '*';
            // Avertit si CapsLock est activé dans l'input de mdp
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;
        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;

        bool exit = true;

        // ------------------------------ DEPLACEMENT & RESIZE DE LA FENETRE ------------------------------
        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }
        }
        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                        toolTip1.SetToolTip(_MaxButton, "Maximize");
                        _MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    toolTip1.SetToolTip(_MaxButton, "Restore Down");
                    _MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                _MaxButton_Click(sender, e);
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                    }
                }
            }
        }
        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                this.Location = new Point(10, this.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                }
            }
        }
        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }
        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (this.Height < 50)
                {
                    this.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    this.Height = this.Height + e.Y;
                }
            }
        }
        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }
        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        // ------------------------------ BOUTONS MIN, MAX, CLOSE ------------------------------
        private void _MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void _MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                this.Location = _normalWindowLocation;
                this.Size = _normalWindowSize;
                toolTip1.SetToolTip(_MaxButton, "Maximize");
                _MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip1.SetToolTip(_MaxButton, "Restore Down");
                _MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }
        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------------ BOUTON CONNEXION, VERIFICATION CONFORMITE ------------------------------
        


        private void boutonConnexion_Click(object sender, EventArgs e)
        {
            string identifiantSaisi = inputIdentifiant.Text;
            string mdpSaisi = inputMdp.Text;


            if(String.IsNullOrEmpty(identifiantSaisi))
            {
                message_erreur.Text = "Veuillez saisir un identifiant";
                Color rouge = Color.FromArgb(255, 0, 0);
                message_erreur.ForeColor = rouge;
            }
            else if(String.IsNullOrEmpty(mdpSaisi))
            {
                message_erreur.Text = "Veuillez saisir un mot de passe";
                Color rouge = Color.FromArgb(255, 0, 0);
                message_erreur.ForeColor = rouge;
            } 

            else
            {
                MySqlCommand command = conn.CreateCommand();

                command.Parameters.AddWithValue("@identifiantSaisi", identifiantSaisi);
                command.CommandText = "SELECT mdp, idRole FROM utilisateurs WHERE identifiant = @identifiantSaisi";
                try
                {
                    conn.Open();
                }
                catch
                {
                    message_erreur.Text = "Cet identifiant n'existe pas";
                    Color rouge = Color.FromArgb(255, 0, 0);
                    message_erreur.ForeColor = rouge;
                }
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string mdp = reader.GetString(0);
                    int idRole = reader.GetInt32(1);

                    // Renvoi booléen
                    if (BCrypt.Verify(mdpSaisi, mdp) == false)
                    {
                        message_erreur.Text = "Mot de passe erroné";
                        Color rouge = Color.FromArgb(255, 0, 0);
                        message_erreur.ForeColor = rouge;
                    }
                    else
                    {
                        if (idRole != 1 && idRole != 2)
                        {
                            message_erreur.Text = "Vous n'êtes pas admin";
                            Color rouge = Color.FromArgb(255, 0, 0);
                            message_erreur.ForeColor = rouge;
                        }
                        else
                        {

                            message_erreur.Text = "Vous êtes connecté";
                            Color vert = Color.FromArgb(0, 128, 0);
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

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}