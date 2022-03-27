
namespace azur_application.Fenetres.Onglets
{
    partial class ongletEtapes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ongletEtapes));
            this.label_titre = new System.Windows.Forms.Label();
            this.label_titreProjet = new System.Windows.Forms.Label();
            this.dataGrid_etapes = new System.Windows.Forms.DataGridView();
            this.label_tableProjet = new System.Windows.Forms.Label();
            this.panel_inputs = new System.Windows.Forms.Panel();
            this.input_heure_fin = new System.Windows.Forms.DateTimePicker();
            this.input_heure_debut = new System.Windows.Forms.DateTimePicker();
            this.input_date_fin = new System.Windows.Forms.DateTimePicker();
            this.input_date_debut = new System.Windows.Forms.DateTimePicker();
            this.input_etat = new System.Windows.Forms.ComboBox();
            this.label_etat = new System.Windows.Forms.Label();
            this.label_fin = new System.Windows.Forms.Label();
            this.label_debut = new System.Windows.Forms.Label();
            this.input_nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_projet = new System.Windows.Forms.ComboBox();
            this.label_projet = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label_erreur = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.barre_progression = new CircularProgressBar.CircularProgressBar();
            this.input_rechercher = new System.Windows.Forms.TextBox();
            this.label_rechercher = new System.Windows.Forms.Label();
            this.btn_filtre = new System.Windows.Forms.Button();
            this.radiobtn_etat = new System.Windows.Forms.RadioButton();
            this.radiobtn_debut = new System.Windows.Forms.RadioButton();
            this.radiobtn_fin = new System.Windows.Forms.RadioButton();
            this.radiobtn_nom = new System.Windows.Forms.RadioButton();
            this.input_rechercher_dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_etapes)).BeginInit();
            this.panel_inputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Font = new System.Drawing.Font("Lato", 14F);
            this.label_titre.Location = new System.Drawing.Point(8, 9);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(172, 23);
            this.label_titre.TabIndex = 40;
            this.label_titre.Text = "Projet selectionné :";
            // 
            // label_titreProjet
            // 
            this.label_titreProjet.AutoSize = true;
            this.label_titreProjet.Font = new System.Drawing.Font("Lato", 14F);
            this.label_titreProjet.Location = new System.Drawing.Point(180, 9);
            this.label_titreProjet.Name = "label_titreProjet";
            this.label_titreProjet.Size = new System.Drawing.Size(0, 23);
            this.label_titreProjet.TabIndex = 41;
            // 
            // dataGrid_etapes
            // 
            this.dataGrid_etapes.AllowUserToAddRows = false;
            this.dataGrid_etapes.AllowUserToDeleteRows = false;
            this.dataGrid_etapes.AllowUserToResizeColumns = false;
            this.dataGrid_etapes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGrid_etapes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_etapes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_etapes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_etapes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGrid_etapes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGrid_etapes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_etapes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_etapes.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_etapes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_etapes.EnableHeadersVisualStyles = false;
            this.dataGrid_etapes.Location = new System.Drawing.Point(12, 284);
            this.dataGrid_etapes.Name = "dataGrid_etapes";
            this.dataGrid_etapes.ReadOnly = true;
            this.dataGrid_etapes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_etapes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_etapes.RowHeadersVisible = false;
            this.dataGrid_etapes.RowHeadersWidth = 51;
            this.dataGrid_etapes.Size = new System.Drawing.Size(1172, 283);
            this.dataGrid_etapes.TabIndex = 42;
            this.dataGrid_etapes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_etapes_CellDoubleClick);
            // 
            // label_tableProjet
            // 
            this.label_tableProjet.AutoSize = true;
            this.label_tableProjet.Font = new System.Drawing.Font("Lato", 14F);
            this.label_tableProjet.Location = new System.Drawing.Point(8, 258);
            this.label_tableProjet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tableProjet.Name = "label_tableProjet";
            this.label_tableProjet.Size = new System.Drawing.Size(121, 23);
            this.label_tableProjet.TabIndex = 43;
            this.label_tableProjet.Text = "Liste Étapes :";
            // 
            // panel_inputs
            // 
            this.panel_inputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_inputs.Controls.Add(this.input_heure_fin);
            this.panel_inputs.Controls.Add(this.input_heure_debut);
            this.panel_inputs.Controls.Add(this.input_date_fin);
            this.panel_inputs.Controls.Add(this.input_date_debut);
            this.panel_inputs.Controls.Add(this.input_etat);
            this.panel_inputs.Controls.Add(this.label_etat);
            this.panel_inputs.Controls.Add(this.label_fin);
            this.panel_inputs.Controls.Add(this.label_debut);
            this.panel_inputs.Controls.Add(this.input_nom);
            this.panel_inputs.Controls.Add(this.input_projet);
            this.panel_inputs.Controls.Add(this.label_projet);
            this.panel_inputs.Controls.Add(this.label_nom);
            this.panel_inputs.Location = new System.Drawing.Point(12, 67);
            this.panel_inputs.Name = "panel_inputs";
            this.panel_inputs.Size = new System.Drawing.Size(548, 145);
            this.panel_inputs.TabIndex = 44;
            // 
            // input_heure_fin
            // 
            this.input_heure_fin.CustomFormat = "HH:mm";
            this.input_heure_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_heure_fin.Location = new System.Drawing.Point(185, 97);
            this.input_heure_fin.Name = "input_heure_fin";
            this.input_heure_fin.ShowUpDown = true;
            this.input_heure_fin.Size = new System.Drawing.Size(99, 23);
            this.input_heure_fin.TabIndex = 7;
            // 
            // input_heure_debut
            // 
            this.input_heure_debut.CustomFormat = "HH:mm";
            this.input_heure_debut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_heure_debut.Location = new System.Drawing.Point(185, 68);
            this.input_heure_debut.Name = "input_heure_debut";
            this.input_heure_debut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_heure_debut.ShowUpDown = true;
            this.input_heure_debut.Size = new System.Drawing.Size(99, 23);
            this.input_heure_debut.TabIndex = 4;
            // 
            // input_date_fin
            // 
            this.input_date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_date_fin.Location = new System.Drawing.Point(81, 97);
            this.input_date_fin.Name = "input_date_fin";
            this.input_date_fin.Size = new System.Drawing.Size(98, 23);
            this.input_date_fin.TabIndex = 6;
            // 
            // input_date_debut
            // 
            this.input_date_debut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_date_debut.Location = new System.Drawing.Point(81, 68);
            this.input_date_debut.Name = "input_date_debut";
            this.input_date_debut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_date_debut.Size = new System.Drawing.Size(98, 23);
            this.input_date_debut.TabIndex = 3;
            // 
            // input_etat
            // 
            this.input_etat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.input_etat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input_etat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_etat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_etat.Font = new System.Drawing.Font("Lato", 10F);
            this.input_etat.Location = new System.Drawing.Point(388, 99);
            this.input_etat.Margin = new System.Windows.Forms.Padding(4);
            this.input_etat.Name = "input_etat";
            this.input_etat.Size = new System.Drawing.Size(146, 24);
            this.input_etat.TabIndex = 11;
            // 
            // label_etat
            // 
            this.label_etat.AutoSize = true;
            this.label_etat.Font = new System.Drawing.Font("Lato", 10F);
            this.label_etat.Location = new System.Drawing.Point(340, 102);
            this.label_etat.Name = "label_etat";
            this.label_etat.Size = new System.Drawing.Size(41, 17);
            this.label_etat.TabIndex = 10;
            this.label_etat.Text = "État :";
            // 
            // label_fin
            // 
            this.label_fin.AutoSize = true;
            this.label_fin.Font = new System.Drawing.Font("Lato", 10F);
            this.label_fin.Location = new System.Drawing.Point(40, 102);
            this.label_fin.Name = "label_fin";
            this.label_fin.Size = new System.Drawing.Size(35, 17);
            this.label_fin.TabIndex = 5;
            this.label_fin.Text = "Fin :";
            // 
            // label_debut
            // 
            this.label_debut.AutoSize = true;
            this.label_debut.Font = new System.Drawing.Font("Lato", 10F);
            this.label_debut.Location = new System.Drawing.Point(20, 73);
            this.label_debut.Name = "label_debut";
            this.label_debut.Size = new System.Drawing.Size(55, 17);
            this.label_debut.TabIndex = 2;
            this.label_debut.Text = "Début :";
            // 
            // input_nom
            // 
            this.input_nom.Depth = 0;
            this.input_nom.Hint = "";
            this.input_nom.Location = new System.Drawing.Point(81, 32);
            this.input_nom.MaxLength = 32767;
            this.input_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_nom.Name = "input_nom";
            this.input_nom.PasswordChar = '\0';
            this.input_nom.SelectedText = "";
            this.input_nom.SelectionLength = 0;
            this.input_nom.SelectionStart = 0;
            this.input_nom.Size = new System.Drawing.Size(453, 23);
            this.input_nom.TabIndex = 1;
            this.input_nom.TabStop = false;
            this.input_nom.UseSystemPasswordChar = false;
            // 
            // input_projet
            // 
            this.input_projet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.input_projet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input_projet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_projet.Enabled = false;
            this.input_projet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_projet.Font = new System.Drawing.Font("Lato", 10F);
            this.input_projet.FormattingEnabled = true;
            this.input_projet.Location = new System.Drawing.Point(388, 70);
            this.input_projet.Margin = new System.Windows.Forms.Padding(4);
            this.input_projet.Name = "input_projet";
            this.input_projet.Size = new System.Drawing.Size(146, 24);
            this.input_projet.TabIndex = 9;
            // 
            // label_projet
            // 
            this.label_projet.AutoSize = true;
            this.label_projet.Font = new System.Drawing.Font("Lato", 10F);
            this.label_projet.Location = new System.Drawing.Point(329, 73);
            this.label_projet.Name = "label_projet";
            this.label_projet.Size = new System.Drawing.Size(52, 17);
            this.label_projet.TabIndex = 8;
            this.label_projet.Text = "Projet :";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Lato", 10F);
            this.label_nom.Location = new System.Drawing.Point(28, 32);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(47, 17);
            this.label_nom.TabIndex = 0;
            this.label_nom.Text = "Nom :";
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(594, 174);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(132, 52);
            this.btn_supprimer.TabIndex = 14;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(594, 114);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(132, 52);
            this.btn_modifier.TabIndex = 13;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(594, 54);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(132, 52);
            this.btn_ajouter.TabIndex = 12;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label_erreur
            // 
            this.label_erreur.AutoSize = true;
            this.label_erreur.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_erreur.ForeColor = System.Drawing.Color.Red;
            this.label_erreur.Location = new System.Drawing.Point(12, 45);
            this.label_erreur.Name = "label_erreur";
            this.label_erreur.Size = new System.Drawing.Size(0, 19);
            this.label_erreur.TabIndex = 48;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(734, 54);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(66, 172);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Vider";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // barre_progression
            // 
            this.barre_progression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barre_progression.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.barre_progression.AnimationSpeed = 600;
            this.barre_progression.BackColor = System.Drawing.Color.Transparent;
            this.barre_progression.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.barre_progression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barre_progression.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barre_progression.InnerMargin = 2;
            this.barre_progression.InnerWidth = -1;
            this.barre_progression.Location = new System.Drawing.Point(984, 26);
            this.barre_progression.MarqueeAnimationSpeed = 2000;
            this.barre_progression.Name = "barre_progression";
            this.barre_progression.OuterColor = System.Drawing.Color.Gray;
            this.barre_progression.OuterMargin = -15;
            this.barre_progression.OuterWidth = 15;
            this.barre_progression.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(169)))));
            this.barre_progression.ProgressWidth = 15;
            this.barre_progression.SecondaryFont = new System.Drawing.Font("Lato", 13F);
            this.barre_progression.Size = new System.Drawing.Size(200, 200);
            this.barre_progression.StartAngle = 270;
            this.barre_progression.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.barre_progression.SubscriptMargin = new System.Windows.Forms.Padding(-78, 15, 0, 0);
            this.barre_progression.SubscriptText = "0";
            this.barre_progression.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.barre_progression.SuperscriptMargin = new System.Windows.Forms.Padding(-65, 52, 0, 0);
            this.barre_progression.SuperscriptText = "%";
            this.barre_progression.TabIndex = 52;
            this.barre_progression.Text = "État du projet";
            this.barre_progression.TextMargin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.barre_progression.Value = 68;
            // 
            // input_rechercher
            // 
            this.input_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_rechercher.Location = new System.Drawing.Point(768, 254);
            this.input_rechercher.Name = "input_rechercher";
            this.input_rechercher.Size = new System.Drawing.Size(147, 23);
            this.input_rechercher.TabIndex = 54;
            this.input_rechercher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_rechercher_KeyUp);
            // 
            // label_rechercher
            // 
            this.label_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rechercher.AutoSize = true;
            this.label_rechercher.Font = new System.Drawing.Font("Lato", 10F);
            this.label_rechercher.Location = new System.Drawing.Point(676, 257);
            this.label_rechercher.Name = "label_rechercher";
            this.label_rechercher.Size = new System.Drawing.Size(86, 17);
            this.label_rechercher.TabIndex = 53;
            this.label_rechercher.Text = "Rechercher :";
            // 
            // btn_filtre
            // 
            this.btn_filtre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filtre.FlatAppearance.BorderSize = 0;
            this.btn_filtre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtre.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_filtre.Image = ((System.Drawing.Image)(resources.GetObject("btn_filtre.Image")));
            this.btn_filtre.Location = new System.Drawing.Point(1154, 251);
            this.btn_filtre.Name = "btn_filtre";
            this.btn_filtre.Size = new System.Drawing.Size(30, 24);
            this.btn_filtre.TabIndex = 59;
            this.btn_filtre.UseVisualStyleBackColor = true;
            this.btn_filtre.Click += new System.EventHandler(this.btn_filtre_Click);
            // 
            // radiobtn_etat
            // 
            this.radiobtn_etat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobtn_etat.AutoSize = true;
            this.radiobtn_etat.Location = new System.Drawing.Point(1098, 255);
            this.radiobtn_etat.Name = "radiobtn_etat";
            this.radiobtn_etat.Size = new System.Drawing.Size(50, 20);
            this.radiobtn_etat.TabIndex = 58;
            this.radiobtn_etat.Text = "État";
            this.radiobtn_etat.UseVisualStyleBackColor = true;
            this.radiobtn_etat.CheckedChanged += new System.EventHandler(this.radiobtn_etat_CheckedChanged);
            // 
            // radiobtn_debut
            // 
            this.radiobtn_debut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobtn_debut.AutoSize = true;
            this.radiobtn_debut.Location = new System.Drawing.Point(981, 255);
            this.radiobtn_debut.Name = "radiobtn_debut";
            this.radiobtn_debut.Size = new System.Drawing.Size(62, 20);
            this.radiobtn_debut.TabIndex = 57;
            this.radiobtn_debut.Text = "Début";
            this.radiobtn_debut.UseVisualStyleBackColor = true;
            this.radiobtn_debut.CheckedChanged += new System.EventHandler(this.radiobtn_debut_CheckedChanged);
            // 
            // radiobtn_fin
            // 
            this.radiobtn_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobtn_fin.AutoSize = true;
            this.radiobtn_fin.Location = new System.Drawing.Point(1049, 255);
            this.radiobtn_fin.Name = "radiobtn_fin";
            this.radiobtn_fin.Size = new System.Drawing.Size(43, 20);
            this.radiobtn_fin.TabIndex = 56;
            this.radiobtn_fin.Text = "Fin";
            this.radiobtn_fin.UseVisualStyleBackColor = true;
            this.radiobtn_fin.CheckedChanged += new System.EventHandler(this.radiobtn_fin_CheckedChanged);
            // 
            // radiobtn_nom
            // 
            this.radiobtn_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobtn_nom.AutoSize = true;
            this.radiobtn_nom.Checked = true;
            this.radiobtn_nom.Location = new System.Drawing.Point(921, 255);
            this.radiobtn_nom.Name = "radiobtn_nom";
            this.radiobtn_nom.Size = new System.Drawing.Size(54, 20);
            this.radiobtn_nom.TabIndex = 55;
            this.radiobtn_nom.TabStop = true;
            this.radiobtn_nom.Text = "Nom";
            this.radiobtn_nom.UseVisualStyleBackColor = true;
            this.radiobtn_nom.CheckedChanged += new System.EventHandler(this.radiobtn_nom_CheckedChanged);
            // 
            // input_rechercher_dtp
            // 
            this.input_rechercher_dtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_rechercher_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_rechercher_dtp.Location = new System.Drawing.Point(768, 254);
            this.input_rechercher_dtp.Name = "input_rechercher_dtp";
            this.input_rechercher_dtp.Size = new System.Drawing.Size(147, 23);
            this.input_rechercher_dtp.TabIndex = 60;
            this.input_rechercher_dtp.Visible = false;
            this.input_rechercher_dtp.CloseUp += new System.EventHandler(this.input_rechercher_dtp_CloseUp);
            this.input_rechercher_dtp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_rechercher_dtp_KeyUp);
            // 
            // ongletEtapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1196, 579);
            this.Controls.Add(this.input_rechercher_dtp);
            this.Controls.Add(this.btn_filtre);
            this.Controls.Add(this.radiobtn_etat);
            this.Controls.Add(this.radiobtn_debut);
            this.Controls.Add(this.radiobtn_fin);
            this.Controls.Add(this.radiobtn_nom);
            this.Controls.Add(this.input_rechercher);
            this.Controls.Add(this.label_rechercher);
            this.Controls.Add(this.barre_progression);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label_erreur);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.panel_inputs);
            this.Controls.Add(this.label_tableProjet);
            this.Controls.Add(this.dataGrid_etapes);
            this.Controls.Add(this.label_titreProjet);
            this.Controls.Add(this.label_titre);
            this.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ongletEtapes";
            this.Text = "Étapes";
            this.Load += new System.EventHandler(this.ongletEtapes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_etapes)).EndInit();
            this.panel_inputs.ResumeLayout(false);
            this.panel_inputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.Label label_titreProjet;
        private System.Windows.Forms.DataGridView dataGrid_etapes;
        private System.Windows.Forms.Label label_tableProjet;
        private System.Windows.Forms.Panel panel_inputs;
        private System.Windows.Forms.DateTimePicker input_heure_fin;
        private System.Windows.Forms.DateTimePicker input_heure_debut;
        private System.Windows.Forms.DateTimePicker input_date_fin;
        private System.Windows.Forms.DateTimePicker input_date_debut;
        private System.Windows.Forms.ComboBox input_etat;
        private System.Windows.Forms.Label label_etat;
        private System.Windows.Forms.Label label_fin;
        private System.Windows.Forms.Label label_debut;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_nom;
        private System.Windows.Forms.ComboBox input_projet;
        private System.Windows.Forms.Label label_projet;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label_erreur;
        private System.Windows.Forms.Button btn_clear;
        private CircularProgressBar.CircularProgressBar barre_progression;
        private System.Windows.Forms.TextBox input_rechercher;
        private System.Windows.Forms.Label label_rechercher;
        private System.Windows.Forms.Button btn_filtre;
        private System.Windows.Forms.RadioButton radiobtn_etat;
        private System.Windows.Forms.RadioButton radiobtn_debut;
        private System.Windows.Forms.RadioButton radiobtn_fin;
        private System.Windows.Forms.RadioButton radiobtn_nom;
        private System.Windows.Forms.DateTimePicker input_rechercher_dtp;
    }
}