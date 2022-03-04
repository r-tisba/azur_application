
namespace azur_application.Onglets
{
    partial class ongletUtilisateurs
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
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.dataGrid_utilisateurs = new System.Windows.Forms.DataGridView();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label_table = new System.Windows.Forms.Label();
            this.label_erreur = new System.Windows.Forms.Label();
            this.label_asterisque = new System.Windows.Forms.Label();
            this.label_idRole = new System.Windows.Forms.Label();
            this.input_prenom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_poste = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_role = new System.Windows.Forms.ComboBox();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.input_nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_mdp = new System.Windows.Forms.Label();
            this.label_poste = new System.Windows.Forms.Label();
            this.input_mdp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel_inputs = new System.Windows.Forms.Panel();
            this.label_rechercher = new System.Windows.Forms.Label();
            this.input_rechercher = new System.Windows.Forms.TextBox();
            this.btn_reinitialisation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_utilisateurs)).BeginInit();
            this.panel_inputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(925, 41);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(152, 52);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // dataGrid_utilisateurs
            // 
            this.dataGrid_utilisateurs.AllowUserToAddRows = false;
            this.dataGrid_utilisateurs.AllowUserToDeleteRows = false;
            this.dataGrid_utilisateurs.AllowUserToResizeColumns = false;
            this.dataGrid_utilisateurs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGrid_utilisateurs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_utilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_utilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_utilisateurs.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGrid_utilisateurs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGrid_utilisateurs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_utilisateurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_utilisateurs.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_utilisateurs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_utilisateurs.EnableHeadersVisualStyles = false;
            this.dataGrid_utilisateurs.Location = new System.Drawing.Point(13, 271);
            this.dataGrid_utilisateurs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_utilisateurs.Name = "dataGrid_utilisateurs";
            this.dataGrid_utilisateurs.ReadOnly = true;
            this.dataGrid_utilisateurs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_utilisateurs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_utilisateurs.RowHeadersVisible = false;
            this.dataGrid_utilisateurs.RowHeadersWidth = 51;
            this.dataGrid_utilisateurs.Size = new System.Drawing.Size(1174, 256);
            this.dataGrid_utilisateurs.TabIndex = 15;
            this.dataGrid_utilisateurs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_utilisateurs_CellDoubleClick);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(925, 101);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(152, 52);
            this.btn_modifier.TabIndex = 6;
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
            this.btn_supprimer.Location = new System.Drawing.Point(925, 161);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(152, 52);
            this.btn_supprimer.TabIndex = 7;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Font = new System.Drawing.Font("Lato", 14F);
            this.label_table.Location = new System.Drawing.Point(14, 244);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(160, 23);
            this.label_table.TabIndex = 29;
            this.label_table.Text = "Table utilisateurs :";
            // 
            // label_erreur
            // 
            this.label_erreur.AutoSize = true;
            this.label_erreur.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_erreur.ForeColor = System.Drawing.Color.Red;
            this.label_erreur.Location = new System.Drawing.Point(14, 9);
            this.label_erreur.Name = "label_erreur";
            this.label_erreur.Size = new System.Drawing.Size(0, 19);
            this.label_erreur.TabIndex = 31;
            // 
            // label_asterisque
            // 
            this.label_asterisque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_asterisque.AutoSize = true;
            this.label_asterisque.Font = new System.Drawing.Font("Lato Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asterisque.Location = new System.Drawing.Point(1036, 20);
            this.label_asterisque.Name = "label_asterisque";
            this.label_asterisque.Size = new System.Drawing.Size(151, 17);
            this.label_asterisque.TabIndex = 34;
            this.label_asterisque.Text = "* Uniquement pour ajout";
            // 
            // label_idRole
            // 
            this.label_idRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_idRole.AutoSize = true;
            this.label_idRole.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idRole.Location = new System.Drawing.Point(363, 72);
            this.label_idRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idRole.Name = "label_idRole";
            this.label_idRole.Size = new System.Drawing.Size(43, 17);
            this.label_idRole.TabIndex = 25;
            this.label_idRole.Text = "Rôle :";
            // 
            // input_prenom
            // 
            this.input_prenom.Depth = 0;
            this.input_prenom.Hint = "";
            this.input_prenom.Location = new System.Drawing.Point(98, 72);
            this.input_prenom.MaxLength = 32767;
            this.input_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.PasswordChar = '\0';
            this.input_prenom.SelectedText = "";
            this.input_prenom.SelectionLength = 0;
            this.input_prenom.SelectionStart = 0;
            this.input_prenom.Size = new System.Drawing.Size(165, 23);
            this.input_prenom.TabIndex = 1;
            this.input_prenom.TabStop = false;
            this.input_prenom.UseSystemPasswordChar = false;
            // 
            // input_poste
            // 
            this.input_poste.Depth = 0;
            this.input_poste.Hint = "";
            this.input_poste.Location = new System.Drawing.Point(98, 120);
            this.input_poste.MaxLength = 32767;
            this.input_poste.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_poste.Name = "input_poste";
            this.input_poste.PasswordChar = '\0';
            this.input_poste.SelectedText = "";
            this.input_poste.SelectionLength = 0;
            this.input_poste.SelectionStart = 0;
            this.input_poste.Size = new System.Drawing.Size(165, 23);
            this.input_poste.TabIndex = 2;
            this.input_poste.TabStop = false;
            this.input_poste.UseSystemPasswordChar = false;
            // 
            // input_role
            // 
            this.input_role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_role.BackColor = System.Drawing.SystemColors.Window;
            this.input_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_role.Font = new System.Drawing.Font("Lato", 10F);
            this.input_role.Location = new System.Drawing.Point(423, 69);
            this.input_role.Name = "input_role";
            this.input_role.Size = new System.Drawing.Size(165, 24);
            this.input_role.TabIndex = 4;
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.Location = new System.Drawing.Point(15, 72);
            this.label_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(64, 17);
            this.label_prenom.TabIndex = 7;
            this.label_prenom.Text = "Prénom :";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(36, 22);
            this.label_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(47, 17);
            this.label_nom.TabIndex = 3;
            this.label_nom.Text = "Nom :";
            // 
            // input_nom
            // 
            this.input_nom.Depth = 0;
            this.input_nom.Hint = "";
            this.input_nom.Location = new System.Drawing.Point(98, 22);
            this.input_nom.MaxLength = 32767;
            this.input_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_nom.Name = "input_nom";
            this.input_nom.PasswordChar = '\0';
            this.input_nom.SelectedText = "";
            this.input_nom.SelectionLength = 0;
            this.input_nom.SelectionStart = 0;
            this.input_nom.Size = new System.Drawing.Size(165, 23);
            this.input_nom.TabIndex = 0;
            this.input_nom.TabStop = false;
            this.input_nom.UseSystemPasswordChar = false;
            // 
            // label_mdp
            // 
            this.label_mdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdp.Location = new System.Drawing.Point(301, 22);
            this.label_mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(105, 17);
            this.label_mdp.TabIndex = 19;
            this.label_mdp.Text = "Mot de passe* :";
            // 
            // label_poste
            // 
            this.label_poste.AutoSize = true;
            this.label_poste.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_poste.Location = new System.Drawing.Point(31, 120);
            this.label_poste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_poste.Name = "label_poste";
            this.label_poste.Size = new System.Drawing.Size(50, 17);
            this.label_poste.TabIndex = 9;
            this.label_poste.Text = "Poste :";
            // 
            // input_mdp
            // 
            this.input_mdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_mdp.Depth = 0;
            this.input_mdp.Hint = "";
            this.input_mdp.Location = new System.Drawing.Point(423, 22);
            this.input_mdp.MaxLength = 32767;
            this.input_mdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_mdp.Name = "input_mdp";
            this.input_mdp.PasswordChar = '\0';
            this.input_mdp.SelectedText = "";
            this.input_mdp.SelectionLength = 0;
            this.input_mdp.SelectionStart = 0;
            this.input_mdp.Size = new System.Drawing.Size(165, 23);
            this.input_mdp.TabIndex = 3;
            this.input_mdp.TabStop = false;
            this.input_mdp.UseSystemPasswordChar = false;
            // 
            // panel_inputs
            // 
            this.panel_inputs.Controls.Add(this.input_mdp);
            this.panel_inputs.Controls.Add(this.label_poste);
            this.panel_inputs.Controls.Add(this.label_mdp);
            this.panel_inputs.Controls.Add(this.input_nom);
            this.panel_inputs.Controls.Add(this.label_nom);
            this.panel_inputs.Controls.Add(this.label_prenom);
            this.panel_inputs.Controls.Add(this.input_role);
            this.panel_inputs.Controls.Add(this.input_poste);
            this.panel_inputs.Controls.Add(this.input_prenom);
            this.panel_inputs.Controls.Add(this.label_idRole);
            this.panel_inputs.Location = new System.Drawing.Point(18, 41);
            this.panel_inputs.Name = "panel_inputs";
            this.panel_inputs.Size = new System.Drawing.Size(671, 172);
            this.panel_inputs.TabIndex = 35;
            // 
            // label_rechercher
            // 
            this.label_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rechercher.AutoSize = true;
            this.label_rechercher.Font = new System.Drawing.Font("Lato", 10F);
            this.label_rechercher.Location = new System.Drawing.Point(920, 244);
            this.label_rechercher.Name = "label_rechercher";
            this.label_rechercher.Size = new System.Drawing.Size(86, 17);
            this.label_rechercher.TabIndex = 36;
            this.label_rechercher.Text = "Rechercher :";
            // 
            // input_rechercher
            // 
            this.input_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_rechercher.Location = new System.Drawing.Point(1012, 241);
            this.input_rechercher.Name = "input_rechercher";
            this.input_rechercher.Size = new System.Drawing.Size(175, 23);
            this.input_rechercher.TabIndex = 37;
            this.input_rechercher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_rechercher_KeyUp);
            // 
            // btn_reinitialisation
            // 
            this.btn_reinitialisation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reinitialisation.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_reinitialisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reinitialisation.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reinitialisation.ForeColor = System.Drawing.Color.White;
            this.btn_reinitialisation.Location = new System.Drawing.Point(1085, 41);
            this.btn_reinitialisation.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reinitialisation.Name = "btn_reinitialisation";
            this.btn_reinitialisation.Size = new System.Drawing.Size(102, 172);
            this.btn_reinitialisation.TabIndex = 38;
            this.btn_reinitialisation.Text = "Réinitialiser";
            this.btn_reinitialisation.UseVisualStyleBackColor = false;
            this.btn_reinitialisation.Click += new System.EventHandler(this.btn_reinitialisation_Click);
            // 
            // ongletUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 540);
            this.Controls.Add(this.btn_reinitialisation);
            this.Controls.Add(this.input_rechercher);
            this.Controls.Add(this.label_rechercher);
            this.Controls.Add(this.panel_inputs);
            this.Controls.Add(this.label_asterisque);
            this.Controls.Add(this.label_erreur);
            this.Controls.Add(this.label_table);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.dataGrid_utilisateurs);
            this.Controls.Add(this.btn_ajouter);
            this.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ongletUtilisateurs";
            this.Text = "Gérer les utilisateurs";
            this.Load += new System.EventHandler(this.ongletUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_utilisateurs)).EndInit();
            this.panel_inputs.ResumeLayout(false);
            this.panel_inputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.DataGridView dataGrid_utilisateurs;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label_table;
        private System.Windows.Forms.Label label_erreur;
        private System.Windows.Forms.Label label_asterisque;
        private System.Windows.Forms.Label label_idRole;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_prenom;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_poste;
        private System.Windows.Forms.ComboBox input_role;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_nom;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_nom;
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.Label label_poste;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_mdp;
        private System.Windows.Forms.Panel panel_inputs;
        private System.Windows.Forms.Label label_rechercher;
        private System.Windows.Forms.TextBox input_rechercher;
        private System.Windows.Forms.Button btn_reinitialisation;
    }
}