
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_projets = new System.Windows.Forms.DataGridView();
            this.label_titreProjet = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_etapes = new System.Windows.Forms.Button();
            this.label_erreur = new System.Windows.Forms.Label();
            this.panel_inputs = new System.Windows.Forms.Panel();
            this.input_heure_fin = new System.Windows.Forms.DateTimePicker();
            this.input_heure_debut = new System.Windows.Forms.DateTimePicker();
            this.input_date_fin = new System.Windows.Forms.DateTimePicker();
            this.input_date_debut = new System.Windows.Forms.DateTimePicker();
            this.input_contexte = new System.Windows.Forms.TextBox();
            this.label_contexte = new System.Windows.Forms.Label();
            this.input_etat = new System.Windows.Forms.ComboBox();
            this.label_etat = new System.Windows.Forms.Label();
            this.input_intitule = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_fin = new System.Windows.Forms.Label();
            this.label_intitule = new System.Windows.Forms.Label();
            this.label_debut = new System.Windows.Forms.Label();
            this.input_nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_equipe = new System.Windows.Forms.ComboBox();
            this.label_equipe = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_tableProjet = new System.Windows.Forms.Label();
            this.label_asterisque = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.input_rechercher = new System.Windows.Forms.TextBox();
            this.label_rechercher = new System.Windows.Forms.Label();
            this.label_titre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_projets)).BeginInit();
            this.panel_inputs.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_projets
            // 
            this.dataGrid_projets.AllowUserToAddRows = false;
            this.dataGrid_projets.AllowUserToDeleteRows = false;
            this.dataGrid_projets.AllowUserToResizeColumns = false;
            this.dataGrid_projets.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGrid_projets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_projets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_projets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_projets.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGrid_projets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGrid_projets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_projets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_projets.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lato", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_projets.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_projets.EnableHeadersVisualStyles = false;
            this.dataGrid_projets.Location = new System.Drawing.Point(12, 319);
            this.dataGrid_projets.Name = "dataGrid_projets";
            this.dataGrid_projets.ReadOnly = true;
            this.dataGrid_projets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lato", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_projets.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_projets.RowHeadersVisible = false;
            this.dataGrid_projets.RowHeadersWidth = 51;
            this.dataGrid_projets.Size = new System.Drawing.Size(1172, 248);
            this.dataGrid_projets.TabIndex = 0;
            this.dataGrid_projets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_projets_CellDoubleClick);
            // 
            // label_titreProjet
            // 
            this.label_titreProjet.AutoSize = true;
            this.label_titreProjet.Font = new System.Drawing.Font("Lato", 14F);
            this.label_titreProjet.Location = new System.Drawing.Point(180, 9);
            this.label_titreProjet.Name = "label_titreProjet";
            this.label_titreProjet.Size = new System.Drawing.Size(0, 23);
            this.label_titreProjet.TabIndex = 5;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(894, 90);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(132, 52);
            this.btn_ajouter.TabIndex = 21;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(894, 150);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(132, 52);
            this.btn_modifier.TabIndex = 36;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(894, 210);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(132, 52);
            this.btn_supprimer.TabIndex = 36;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_etapes
            // 
            this.btn_etapes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_etapes.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_etapes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_etapes.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_etapes.ForeColor = System.Drawing.Color.White;
            this.btn_etapes.Location = new System.Drawing.Point(1035, 90);
            this.btn_etapes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_etapes.Name = "btn_etapes";
            this.btn_etapes.Size = new System.Drawing.Size(132, 172);
            this.btn_etapes.TabIndex = 37;
            this.btn_etapes.Text = "Liste étapes";
            this.btn_etapes.UseVisualStyleBackColor = false;
            this.btn_etapes.Click += new System.EventHandler(this.btn_etapes_Click);
            // 
            // label_erreur
            // 
            this.label_erreur.AutoSize = true;
            this.label_erreur.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_erreur.ForeColor = System.Drawing.Color.Red;
            this.label_erreur.Location = new System.Drawing.Point(12, 52);
            this.label_erreur.Name = "label_erreur";
            this.label_erreur.Size = new System.Drawing.Size(0, 19);
            this.label_erreur.TabIndex = 38;
            // 
            // panel_inputs
            // 
            this.panel_inputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_inputs.Controls.Add(this.input_heure_fin);
            this.panel_inputs.Controls.Add(this.input_heure_debut);
            this.panel_inputs.Controls.Add(this.input_date_fin);
            this.panel_inputs.Controls.Add(this.input_date_debut);
            this.panel_inputs.Controls.Add(this.input_contexte);
            this.panel_inputs.Controls.Add(this.label_contexte);
            this.panel_inputs.Controls.Add(this.input_etat);
            this.panel_inputs.Controls.Add(this.label_etat);
            this.panel_inputs.Controls.Add(this.input_intitule);
            this.panel_inputs.Controls.Add(this.label_fin);
            this.panel_inputs.Controls.Add(this.label_intitule);
            this.panel_inputs.Controls.Add(this.label_debut);
            this.panel_inputs.Controls.Add(this.input_nom);
            this.panel_inputs.Controls.Add(this.input_equipe);
            this.panel_inputs.Controls.Add(this.label_equipe);
            this.panel_inputs.Controls.Add(this.label_nom);
            this.panel_inputs.Location = new System.Drawing.Point(12, 75);
            this.panel_inputs.Name = "panel_inputs";
            this.panel_inputs.Size = new System.Drawing.Size(853, 203);
            this.panel_inputs.TabIndex = 15;
            // 
            // input_heure_fin
            // 
            this.input_heure_fin.CustomFormat = "HH:mm";
            this.input_heure_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_heure_fin.Location = new System.Drawing.Point(492, 50);
            this.input_heure_fin.Name = "input_heure_fin";
            this.input_heure_fin.ShowUpDown = true;
            this.input_heure_fin.Size = new System.Drawing.Size(99, 23);
            this.input_heure_fin.TabIndex = 41;
            // 
            // input_heure_debut
            // 
            this.input_heure_debut.CustomFormat = "HH:mm";
            this.input_heure_debut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_heure_debut.Location = new System.Drawing.Point(492, 15);
            this.input_heure_debut.Name = "input_heure_debut";
            this.input_heure_debut.ShowUpDown = true;
            this.input_heure_debut.Size = new System.Drawing.Size(99, 23);
            this.input_heure_debut.TabIndex = 40;
            // 
            // input_date_fin
            // 
            this.input_date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_date_fin.Location = new System.Drawing.Point(388, 50);
            this.input_date_fin.Name = "input_date_fin";
            this.input_date_fin.Size = new System.Drawing.Size(98, 23);
            this.input_date_fin.TabIndex = 39;
            // 
            // input_date_debut
            // 
            this.input_date_debut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_date_debut.Location = new System.Drawing.Point(388, 15);
            this.input_date_debut.Name = "input_date_debut";
            this.input_date_debut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_date_debut.Size = new System.Drawing.Size(98, 23);
            this.input_date_debut.TabIndex = 38;
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
            this.input_etat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_etat.Font = new System.Drawing.Font("Lato", 10F);
            this.input_etat.Location = new System.Drawing.Point(696, 17);
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
            this.input_intitule.Size = new System.Drawing.Size(213, 23);
            this.input_intitule.TabIndex = 10;
            this.input_intitule.TabStop = false;
            this.input_intitule.UseSystemPasswordChar = false;
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
            // input_equipe
            // 
            this.input_equipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.input_equipe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input_equipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_equipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_equipe.Font = new System.Drawing.Font("Lato", 10F);
            this.input_equipe.Location = new System.Drawing.Point(696, 52);
            this.input_equipe.Margin = new System.Windows.Forms.Padding(4);
            this.input_equipe.Name = "input_equipe";
            this.input_equipe.Size = new System.Drawing.Size(146, 24);
            this.input_equipe.TabIndex = 12;
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
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Lato", 10F);
            this.label_nom.Location = new System.Drawing.Point(22, 20);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(53, 17);
            this.label_nom.TabIndex = 9;
            this.label_nom.Text = "Nom* :";
            // 
            // label_tableProjet
            // 
            this.label_tableProjet.AutoSize = true;
            this.label_tableProjet.Font = new System.Drawing.Font("Lato", 14F);
            this.label_tableProjet.Location = new System.Drawing.Point(8, 293);
            this.label_tableProjet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tableProjet.Name = "label_tableProjet";
            this.label_tableProjet.Size = new System.Drawing.Size(124, 23);
            this.label_tableProjet.TabIndex = 3;
            this.label_tableProjet.Text = "Liste Projets :";
            // 
            // label_asterisque
            // 
            this.label_asterisque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_asterisque.AutoSize = true;
            this.label_asterisque.Font = new System.Drawing.Font("Lato Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asterisque.Location = new System.Drawing.Point(891, 69);
            this.label_asterisque.Name = "label_asterisque";
            this.label_asterisque.Size = new System.Drawing.Size(179, 17);
            this.label_asterisque.TabIndex = 35;
            this.label_asterisque.Text = "* Le nom n\'est pas modifiable";
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.input_rechercher);
            this.panel_body.Controls.Add(this.label_rechercher);
            this.panel_body.Controls.Add(this.label_titre);
            this.panel_body.Controls.Add(this.label_titreProjet);
            this.panel_body.Controls.Add(this.label_erreur);
            this.panel_body.Controls.Add(this.label_asterisque);
            this.panel_body.Controls.Add(this.btn_etapes);
            this.panel_body.Controls.Add(this.btn_supprimer);
            this.panel_body.Controls.Add(this.label_tableProjet);
            this.panel_body.Controls.Add(this.btn_modifier);
            this.panel_body.Controls.Add(this.dataGrid_projets);
            this.panel_body.Controls.Add(this.panel_inputs);
            this.panel_body.Controls.Add(this.btn_ajouter);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1196, 579);
            this.panel_body.TabIndex = 39;
            // 
            // input_rechercher
            // 
            this.input_rechercher.Location = new System.Drawing.Point(1000, 290);
            this.input_rechercher.Name = "input_rechercher";
            this.input_rechercher.Size = new System.Drawing.Size(184, 23);
            this.input_rechercher.TabIndex = 41;
            this.input_rechercher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_rechercher_KeyUp);
            // 
            // label_rechercher
            // 
            this.label_rechercher.AutoSize = true;
            this.label_rechercher.Font = new System.Drawing.Font("Lato", 10F);
            this.label_rechercher.Location = new System.Drawing.Point(908, 293);
            this.label_rechercher.Name = "label_rechercher";
            this.label_rechercher.Size = new System.Drawing.Size(86, 17);
            this.label_rechercher.TabIndex = 40;
            this.label_rechercher.Text = "Rechercher :";
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Font = new System.Drawing.Font("Lato", 14F);
            this.label_titre.Location = new System.Drawing.Point(8, 9);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(172, 23);
            this.label_titre.TabIndex = 39;
            this.label_titre.Text = "Projet selectionné :";
            // 
            // ongletProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 579);
            this.Controls.Add(this.panel_body);
            this.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ongletProjets";
            this.Text = "Projets";
            this.Load += new System.EventHandler(this.ongletProjets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_projets)).EndInit();
            this.panel_inputs.ResumeLayout(false);
            this.panel_inputs.PerformLayout();
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_projets;
        private System.Windows.Forms.Label label_titreProjet;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_etapes;
        private System.Windows.Forms.Label label_erreur;
        private System.Windows.Forms.Panel panel_inputs;
        private System.Windows.Forms.DateTimePicker input_heure_fin;
        private System.Windows.Forms.DateTimePicker input_heure_debut;
        private System.Windows.Forms.DateTimePicker input_date_fin;
        private System.Windows.Forms.DateTimePicker input_date_debut;
        private System.Windows.Forms.TextBox input_contexte;
        private System.Windows.Forms.Label label_contexte;
        private System.Windows.Forms.ComboBox input_etat;
        private System.Windows.Forms.Label label_etat;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_intitule;
        private System.Windows.Forms.Label label_fin;
        private System.Windows.Forms.Label label_intitule;
        private System.Windows.Forms.Label label_debut;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_nom;
        private System.Windows.Forms.ComboBox input_equipe;
        private System.Windows.Forms.Label label_equipe;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_tableProjet;
        private System.Windows.Forms.Label label_asterisque;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.TextBox input_rechercher;
        private System.Windows.Forms.Label label_rechercher;
    }
}