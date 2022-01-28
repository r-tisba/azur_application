
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
            this.dataGrid_etapes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_etapes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_etapes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_etapes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_etapes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_etapes.Location = new System.Drawing.Point(12, 284);
            this.dataGrid_etapes.Name = "dataGrid_etapes";
            this.dataGrid_etapes.ReadOnly = true;
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
            this.input_heure_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.input_heure_fin.Location = new System.Drawing.Point(185, 97);
            this.input_heure_fin.Name = "input_heure_fin";
            this.input_heure_fin.ShowUpDown = true;
            this.input_heure_fin.Size = new System.Drawing.Size(99, 23);
            this.input_heure_fin.TabIndex = 41;
            // 
            // input_heure_debut
            // 
            this.input_heure_debut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.input_heure_debut.Location = new System.Drawing.Point(185, 68);
            this.input_heure_debut.Name = "input_heure_debut";
            this.input_heure_debut.ShowUpDown = true;
            this.input_heure_debut.Size = new System.Drawing.Size(99, 23);
            this.input_heure_debut.TabIndex = 40;
            // 
            // input_date_fin
            // 
            this.input_date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_date_fin.Location = new System.Drawing.Point(81, 97);
            this.input_date_fin.Name = "input_date_fin";
            this.input_date_fin.Size = new System.Drawing.Size(98, 23);
            this.input_date_fin.TabIndex = 39;
            // 
            // input_date_debut
            // 
            this.input_date_debut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_date_debut.Location = new System.Drawing.Point(81, 68);
            this.input_date_debut.Name = "input_date_debut";
            this.input_date_debut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_date_debut.Size = new System.Drawing.Size(98, 23);
            this.input_date_debut.TabIndex = 38;
            // 
            // input_etat
            // 
            this.input_etat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.input_etat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input_etat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_etat.Font = new System.Drawing.Font("Lato", 10F);
            this.input_etat.Location = new System.Drawing.Point(388, 99);
            this.input_etat.Margin = new System.Windows.Forms.Padding(4);
            this.input_etat.Name = "input_etat";
            this.input_etat.Size = new System.Drawing.Size(146, 24);
            this.input_etat.TabIndex = 18;
            // 
            // label_etat
            // 
            this.label_etat.AutoSize = true;
            this.label_etat.Font = new System.Drawing.Font("Lato", 10F);
            this.label_etat.Location = new System.Drawing.Point(340, 102);
            this.label_etat.Name = "label_etat";
            this.label_etat.Size = new System.Drawing.Size(41, 17);
            this.label_etat.TabIndex = 17;
            this.label_etat.Text = "État :";
            // 
            // label_fin
            // 
            this.label_fin.AutoSize = true;
            this.label_fin.Font = new System.Drawing.Font("Lato", 10F);
            this.label_fin.Location = new System.Drawing.Point(40, 102);
            this.label_fin.Name = "label_fin";
            this.label_fin.Size = new System.Drawing.Size(35, 17);
            this.label_fin.TabIndex = 14;
            this.label_fin.Text = "Fin :";
            // 
            // label_debut
            // 
            this.label_debut.AutoSize = true;
            this.label_debut.Font = new System.Drawing.Font("Lato", 10F);
            this.label_debut.Location = new System.Drawing.Point(20, 73);
            this.label_debut.Name = "label_debut";
            this.label_debut.Size = new System.Drawing.Size(55, 17);
            this.label_debut.TabIndex = 13;
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
            this.input_nom.TabIndex = 8;
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
            this.input_projet.Font = new System.Drawing.Font("Lato", 10F);
            this.input_projet.FormattingEnabled = true;
            this.input_projet.Location = new System.Drawing.Point(388, 70);
            this.input_projet.Margin = new System.Windows.Forms.Padding(4);
            this.input_projet.Name = "input_projet";
            this.input_projet.Size = new System.Drawing.Size(146, 24);
            this.input_projet.TabIndex = 12;
            // 
            // label_projet
            // 
            this.label_projet.AutoSize = true;
            this.label_projet.Font = new System.Drawing.Font("Lato", 10F);
            this.label_projet.Location = new System.Drawing.Point(329, 73);
            this.label_projet.Name = "label_projet";
            this.label_projet.Size = new System.Drawing.Size(52, 17);
            this.label_projet.TabIndex = 11;
            this.label_projet.Text = "Projet :";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Lato", 10F);
            this.label_nom.Location = new System.Drawing.Point(28, 32);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(47, 17);
            this.label_nom.TabIndex = 9;
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
            this.btn_supprimer.TabIndex = 47;
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
            this.btn_modifier.TabIndex = 46;
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
            this.btn_ajouter.TabIndex = 45;
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
            // ongletEtapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 579);
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
    }
}