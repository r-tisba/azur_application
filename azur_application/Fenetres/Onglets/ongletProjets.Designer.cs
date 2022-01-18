
namespace azur_application.Onglets
{
    partial class ongletProjets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_projet = new System.Windows.Forms.DataGridView();
            this.label_tableProjet = new System.Windows.Forms.Label();
            this.label_titre = new System.Windows.Forms.Label();
            this.label_titreProjet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_intitule = new System.Windows.Forms.Label();
            this.input_nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_nom = new System.Windows.Forms.Label();
            this.input_intitule = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_equipe = new System.Windows.Forms.Label();
            this.input_equipe = new System.Windows.Forms.ComboBox();
            this.label_debut = new System.Windows.Forms.Label();
            this.label_fin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_contexte = new System.Windows.Forms.TextBox();
            this.label_contexte = new System.Windows.Forms.Label();
            this.input_etat = new System.Windows.Forms.ComboBox();
            this.label_etat = new System.Windows.Forms.Label();
            this.input_fin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_debut = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_projet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_projet
            // 
            this.dataGrid_projet.AllowUserToAddRows = false;
            this.dataGrid_projet.AllowUserToDeleteRows = false;
            this.dataGrid_projet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_projet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_projet.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_projet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_projet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_projet.Location = new System.Drawing.Point(12, 272);
            this.dataGrid_projet.Name = "dataGrid_projet";
            this.dataGrid_projet.RowHeadersWidth = 51;
            this.dataGrid_projet.Size = new System.Drawing.Size(1176, 256);
            this.dataGrid_projet.TabIndex = 0;
            this.dataGrid_projet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_projet_CellDoubleClick);
            // 
            // label_tableProjet
            // 
            this.label_tableProjet.AutoSize = true;
            this.label_tableProjet.Font = new System.Drawing.Font("Lato", 14F);
            this.label_tableProjet.Location = new System.Drawing.Point(13, 246);
            this.label_tableProjet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tableProjet.Name = "label_tableProjet";
            this.label_tableProjet.Size = new System.Drawing.Size(124, 23);
            this.label_tableProjet.TabIndex = 3;
            this.label_tableProjet.Text = "Liste Projets :";
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Font = new System.Drawing.Font("Lato", 14F);
            this.label_titre.Location = new System.Drawing.Point(12, 9);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(71, 23);
            this.label_titre.TabIndex = 4;
            this.label_titre.Text = "Projet :";
            // 
            // label_titreProjet
            // 
            this.label_titreProjet.AutoSize = true;
            this.label_titreProjet.Font = new System.Drawing.Font("Lato", 14F);
            this.label_titreProjet.Location = new System.Drawing.Point(83, 9);
            this.label_titreProjet.Name = "label_titreProjet";
            this.label_titreProjet.Size = new System.Drawing.Size(0, 23);
            this.label_titreProjet.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(985, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 203);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_intitule
            // 
            this.label_intitule.AutoSize = true;
            this.label_intitule.Font = new System.Drawing.Font("Lato", 10F);
            this.label_intitule.Location = new System.Drawing.Point(15, 55);
            this.label_intitule.Name = "label_intitule";
            this.label_intitule.Size = new System.Drawing.Size(60, 17);
            this.label_intitule.TabIndex = 7;
            this.label_intitule.Text = "Intitulé :";
            // 
            // input_nom
            // 
            this.input_nom.Depth = 0;
            this.input_nom.Hint = "";
            this.input_nom.Location = new System.Drawing.Point(81, 20);
            this.input_nom.MaxLength = 32767;
            this.input_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_nom.Name = "input_nom";
            this.input_nom.PasswordChar = '\0';
            this.input_nom.SelectedText = "";
            this.input_nom.SelectionLength = 0;
            this.input_nom.SelectionStart = 0;
            this.input_nom.Size = new System.Drawing.Size(146, 23);
            this.input_nom.TabIndex = 8;
            this.input_nom.TabStop = false;
            this.input_nom.UseSystemPasswordChar = false;
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Lato", 10F);
            this.label_nom.Location = new System.Drawing.Point(28, 20);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(47, 17);
            this.label_nom.TabIndex = 9;
            this.label_nom.Text = "Nom :";
            // 
            // input_intitule
            // 
            this.input_intitule.Depth = 0;
            this.input_intitule.Hint = "";
            this.input_intitule.Location = new System.Drawing.Point(81, 55);
            this.input_intitule.MaxLength = 32767;
            this.input_intitule.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_intitule.Name = "input_intitule";
            this.input_intitule.PasswordChar = '\0';
            this.input_intitule.SelectedText = "";
            this.input_intitule.SelectionLength = 0;
            this.input_intitule.SelectionStart = 0;
            this.input_intitule.Size = new System.Drawing.Size(146, 23);
            this.input_intitule.TabIndex = 10;
            this.input_intitule.TabStop = false;
            this.input_intitule.UseSystemPasswordChar = false;
            // 
            // label_equipe
            // 
            this.label_equipe.AutoSize = true;
            this.label_equipe.Font = new System.Drawing.Font("Lato", 10F);
            this.label_equipe.Location = new System.Drawing.Point(631, 55);
            this.label_equipe.Name = "label_equipe";
            this.label_equipe.Size = new System.Drawing.Size(58, 17);
            this.label_equipe.TabIndex = 11;
            this.label_equipe.Text = "Équipe :";
            // 
            // input_equipe
            // 
            this.input_equipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.input_equipe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input_equipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_equipe.Font = new System.Drawing.Font("Lato", 10F);
            this.input_equipe.Location = new System.Drawing.Point(696, 54);
            this.input_equipe.Margin = new System.Windows.Forms.Padding(4);
            this.input_equipe.Name = "input_equipe";
            this.input_equipe.Size = new System.Drawing.Size(146, 24);
            this.input_equipe.TabIndex = 12;
            // 
            // label_debut
            // 
            this.label_debut.AutoSize = true;
            this.label_debut.Font = new System.Drawing.Font("Lato", 10F);
            this.label_debut.Location = new System.Drawing.Point(327, 20);
            this.label_debut.Name = "label_debut";
            this.label_debut.Size = new System.Drawing.Size(55, 17);
            this.label_debut.TabIndex = 13;
            this.label_debut.Text = "Début :";
            // 
            // label_fin
            // 
            this.label_fin.AutoSize = true;
            this.label_fin.Font = new System.Drawing.Font("Lato", 10F);
            this.label_fin.Location = new System.Drawing.Point(347, 55);
            this.label_fin.Name = "label_fin";
            this.label_fin.Size = new System.Drawing.Size(35, 17);
            this.label_fin.TabIndex = 14;
            this.label_fin.Text = "Fin :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input_contexte);
            this.panel1.Controls.Add(this.label_contexte);
            this.panel1.Controls.Add(this.input_etat);
            this.panel1.Controls.Add(this.label_etat);
            this.panel1.Controls.Add(this.input_fin);
            this.panel1.Controls.Add(this.input_debut);
            this.panel1.Controls.Add(this.input_intitule);
            this.panel1.Controls.Add(this.label_fin);
            this.panel1.Controls.Add(this.label_intitule);
            this.panel1.Controls.Add(this.label_debut);
            this.panel1.Controls.Add(this.input_nom);
            this.panel1.Controls.Add(this.input_equipe);
            this.panel1.Controls.Add(this.label_equipe);
            this.panel1.Controls.Add(this.label_nom);
            this.panel1.Location = new System.Drawing.Point(17, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 203);
            this.panel1.TabIndex = 15;
            // 
            // input_contexte
            // 
            this.input_contexte.AcceptsReturn = true;
            this.input_contexte.AcceptsTab = true;
            this.input_contexte.Location = new System.Drawing.Point(82, 88);
            this.input_contexte.Multiline = true;
            this.input_contexte.Name = "input_contexte";
            this.input_contexte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input_contexte.Size = new System.Drawing.Size(760, 100);
            this.input_contexte.TabIndex = 20;
            // 
            // label_contexte
            // 
            this.label_contexte.AutoSize = true;
            this.label_contexte.Font = new System.Drawing.Font("Lato", 10F);
            this.label_contexte.Location = new System.Drawing.Point(3, 91);
            this.label_contexte.Name = "label_contexte";
            this.label_contexte.Size = new System.Drawing.Size(72, 17);
            this.label_contexte.TabIndex = 19;
            this.label_contexte.Text = "Contexte :";
            // 
            // input_etat
            // 
            this.input_etat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.input_etat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input_etat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_etat.Font = new System.Drawing.Font("Lato", 10F);
            this.input_etat.Location = new System.Drawing.Point(696, 19);
            this.input_etat.Margin = new System.Windows.Forms.Padding(4);
            this.input_etat.Name = "input_etat";
            this.input_etat.Size = new System.Drawing.Size(146, 24);
            this.input_etat.TabIndex = 18;
            // 
            // label_etat
            // 
            this.label_etat.AutoSize = true;
            this.label_etat.Font = new System.Drawing.Font("Lato", 10F);
            this.label_etat.Location = new System.Drawing.Point(648, 20);
            this.label_etat.Name = "label_etat";
            this.label_etat.Size = new System.Drawing.Size(41, 17);
            this.label_etat.TabIndex = 17;
            this.label_etat.Text = "État :";
            // 
            // input_fin
            // 
            this.input_fin.Depth = 0;
            this.input_fin.Hint = "";
            this.input_fin.Location = new System.Drawing.Point(388, 55);
            this.input_fin.MaxLength = 32767;
            this.input_fin.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_fin.Name = "input_fin";
            this.input_fin.PasswordChar = '\0';
            this.input_fin.SelectedText = "";
            this.input_fin.SelectionLength = 0;
            this.input_fin.SelectionStart = 0;
            this.input_fin.Size = new System.Drawing.Size(146, 23);
            this.input_fin.TabIndex = 16;
            this.input_fin.TabStop = false;
            this.input_fin.UseSystemPasswordChar = false;
            // 
            // input_debut
            // 
            this.input_debut.Depth = 0;
            this.input_debut.Hint = "";
            this.input_debut.Location = new System.Drawing.Point(388, 20);
            this.input_debut.MaxLength = 32767;
            this.input_debut.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_debut.Name = "input_debut";
            this.input_debut.PasswordChar = '\0';
            this.input_debut.SelectedText = "";
            this.input_debut.SelectionLength = 0;
            this.input_debut.SelectionStart = 0;
            this.input_debut.Size = new System.Drawing.Size(146, 23);
            this.input_debut.TabIndex = 15;
            this.input_debut.TabStop = false;
            this.input_debut.UseSystemPasswordChar = false;
            // 
            // ongletProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_titreProjet);
            this.Controls.Add(this.label_titre);
            this.Controls.Add(this.label_tableProjet);
            this.Controls.Add(this.dataGrid_projet);
            this.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ongletProjets";
            this.Text = "Projets";
            this.Load += new System.EventHandler(this.ongletProjets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_projet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_projet;
        private System.Windows.Forms.Label label_tableProjet;
        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.Label label_titreProjet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_intitule;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_nom;
        private System.Windows.Forms.Label label_nom;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_intitule;
        private System.Windows.Forms.Label label_equipe;
        private System.Windows.Forms.ComboBox input_equipe;
        private System.Windows.Forms.Label label_debut;
        private System.Windows.Forms.Label label_fin;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_fin;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_debut;
        private System.Windows.Forms.ComboBox input_etat;
        private System.Windows.Forms.Label label_etat;
        private System.Windows.Forms.Label label_contexte;
        private System.Windows.Forms.TextBox input_contexte;
    }
}