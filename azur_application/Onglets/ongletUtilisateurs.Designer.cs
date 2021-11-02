
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_poste = new System.Windows.Forms.Label();
            this.dataGrid_utilisateurs = new System.Windows.Forms.DataGridView();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label_mdp = new System.Windows.Forms.Label();
            this.input_nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_prenom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_mdp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_poste = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_idRole = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_idEquipe = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_idEquipe = new System.Windows.Forms.Label();
            this.label_idRole = new System.Windows.Forms.Label();
            this.label_table = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_erreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_utilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(547, 158);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(152, 52);
            this.btn_ajouter.TabIndex = 0;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label_nom
            // 
            this.label_nom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(38, 58);
            this.label_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(47, 17);
            this.label_nom.TabIndex = 3;
            this.label_nom.Text = "Nom :";
            // 
            // label_prenom
            // 
            this.label_prenom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.Location = new System.Drawing.Point(21, 105);
            this.label_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(64, 17);
            this.label_prenom.TabIndex = 7;
            this.label_prenom.Text = "Prénom :";
            // 
            // label_poste
            // 
            this.label_poste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_poste.AutoSize = true;
            this.label_poste.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_poste.Location = new System.Drawing.Point(395, 105);
            this.label_poste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_poste.Name = "label_poste";
            this.label_poste.Size = new System.Drawing.Size(50, 17);
            this.label_poste.TabIndex = 9;
            this.label_poste.Text = "Poste :";
            // 
            // dataGrid_utilisateurs
            // 
            this.dataGrid_utilisateurs.AllowUserToAddRows = false;
            this.dataGrid_utilisateurs.AllowUserToDeleteRows = false;
            this.dataGrid_utilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_utilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_utilisateurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_utilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_utilisateurs.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_utilisateurs.Location = new System.Drawing.Point(13, 231);
            this.dataGrid_utilisateurs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_utilisateurs.Name = "dataGrid_utilisateurs";
            this.dataGrid_utilisateurs.Size = new System.Drawing.Size(1082, 251);
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
            this.btn_modifier.Location = new System.Drawing.Point(748, 158);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(152, 52);
            this.btn_modifier.TabIndex = 16;
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
            this.btn_supprimer.Location = new System.Drawing.Point(942, 158);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(152, 52);
            this.btn_supprimer.TabIndex = 17;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // label_mdp
            // 
            this.label_mdp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdp.Location = new System.Drawing.Point(352, 58);
            this.label_mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(99, 17);
            this.label_mdp.TabIndex = 19;
            this.label_mdp.Text = "Mot de passe :";
            // 
            // input_nom
            // 
            this.input_nom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_nom.Depth = 0;
            this.input_nom.Hint = "";
            this.input_nom.Location = new System.Drawing.Point(92, 58);
            this.input_nom.MaxLength = 32767;
            this.input_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_nom.Name = "input_nom";
            this.input_nom.PasswordChar = '\0';
            this.input_nom.SelectedText = "";
            this.input_nom.SelectionLength = 0;
            this.input_nom.SelectionStart = 0;
            this.input_nom.Size = new System.Drawing.Size(187, 23);
            this.input_nom.TabIndex = 21;
            this.input_nom.TabStop = false;
            this.input_nom.UseSystemPasswordChar = false;
            // 
            // input_prenom
            // 
            this.input_prenom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_prenom.Depth = 0;
            this.input_prenom.Hint = "";
            this.input_prenom.Location = new System.Drawing.Point(92, 105);
            this.input_prenom.MaxLength = 32767;
            this.input_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.PasswordChar = '\0';
            this.input_prenom.SelectedText = "";
            this.input_prenom.SelectionLength = 0;
            this.input_prenom.SelectionStart = 0;
            this.input_prenom.Size = new System.Drawing.Size(187, 23);
            this.input_prenom.TabIndex = 22;
            this.input_prenom.TabStop = false;
            this.input_prenom.UseSystemPasswordChar = false;
            // 
            // input_mdp
            // 
            this.input_mdp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_mdp.Depth = 0;
            this.input_mdp.Hint = "";
            this.input_mdp.Location = new System.Drawing.Point(458, 58);
            this.input_mdp.MaxLength = 32767;
            this.input_mdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_mdp.Name = "input_mdp";
            this.input_mdp.PasswordChar = '\0';
            this.input_mdp.SelectedText = "";
            this.input_mdp.SelectionLength = 0;
            this.input_mdp.SelectionStart = 0;
            this.input_mdp.Size = new System.Drawing.Size(187, 23);
            this.input_mdp.TabIndex = 23;
            this.input_mdp.TabStop = false;
            this.input_mdp.UseSystemPasswordChar = false;
            // 
            // input_poste
            // 
            this.input_poste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_poste.Depth = 0;
            this.input_poste.Hint = "";
            this.input_poste.Location = new System.Drawing.Point(458, 105);
            this.input_poste.MaxLength = 32767;
            this.input_poste.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_poste.Name = "input_poste";
            this.input_poste.PasswordChar = '\0';
            this.input_poste.SelectedText = "";
            this.input_poste.SelectionLength = 0;
            this.input_poste.SelectionStart = 0;
            this.input_poste.Size = new System.Drawing.Size(187, 23);
            this.input_poste.TabIndex = 24;
            this.input_poste.TabStop = false;
            this.input_poste.UseSystemPasswordChar = false;
            // 
            // input_idRole
            // 
            this.input_idRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_idRole.Depth = 0;
            this.input_idRole.Hint = "";
            this.input_idRole.Location = new System.Drawing.Point(824, 105);
            this.input_idRole.MaxLength = 32767;
            this.input_idRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_idRole.Name = "input_idRole";
            this.input_idRole.PasswordChar = '\0';
            this.input_idRole.SelectedText = "";
            this.input_idRole.SelectionLength = 0;
            this.input_idRole.SelectionStart = 0;
            this.input_idRole.Size = new System.Drawing.Size(187, 23);
            this.input_idRole.TabIndex = 28;
            this.input_idRole.TabStop = false;
            this.input_idRole.UseSystemPasswordChar = false;
            // 
            // input_idEquipe
            // 
            this.input_idEquipe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_idEquipe.Depth = 0;
            this.input_idEquipe.Hint = "";
            this.input_idEquipe.Location = new System.Drawing.Point(824, 58);
            this.input_idEquipe.MaxLength = 32767;
            this.input_idEquipe.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_idEquipe.Name = "input_idEquipe";
            this.input_idEquipe.PasswordChar = '\0';
            this.input_idEquipe.SelectedText = "";
            this.input_idEquipe.SelectionLength = 0;
            this.input_idEquipe.SelectionStart = 0;
            this.input_idEquipe.Size = new System.Drawing.Size(187, 23);
            this.input_idEquipe.TabIndex = 27;
            this.input_idEquipe.TabStop = false;
            this.input_idEquipe.UseSystemPasswordChar = false;
            // 
            // label_idEquipe
            // 
            this.label_idEquipe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_idEquipe.AutoSize = true;
            this.label_idEquipe.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idEquipe.Location = new System.Drawing.Point(740, 58);
            this.label_idEquipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idEquipe.Name = "label_idEquipe";
            this.label_idEquipe.Size = new System.Drawing.Size(83, 17);
            this.label_idEquipe.TabIndex = 26;
            this.label_idEquipe.Text = "ID Équipe* :";
            // 
            // label_idRole
            // 
            this.label_idRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_idRole.AutoSize = true;
            this.label_idRole.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idRole.Location = new System.Drawing.Point(755, 105);
            this.label_idRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idRole.Name = "label_idRole";
            this.label_idRole.Size = new System.Drawing.Size(68, 17);
            this.label_idRole.TabIndex = 25;
            this.label_idRole.Text = "ID Rôle* :";
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table.Location = new System.Drawing.Point(19, 181);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(202, 29);
            this.label_table.TabIndex = 29;
            this.label_table.Text = "Table utilisateurs :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1002, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "* : Pas obligatoire";
            // 
            // label_erreur
            // 
            this.label_erreur.AutoSize = true;
            this.label_erreur.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_erreur.ForeColor = System.Drawing.Color.Red;
            this.label_erreur.Location = new System.Drawing.Point(20, 20);
            this.label_erreur.Name = "label_erreur";
            this.label_erreur.Size = new System.Drawing.Size(0, 19);
            this.label_erreur.TabIndex = 31;
            // 
            // ongletUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 495);
            this.Controls.Add(this.label_erreur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_table);
            this.Controls.Add(this.input_idRole);
            this.Controls.Add(this.input_idEquipe);
            this.Controls.Add(this.label_idEquipe);
            this.Controls.Add(this.label_idRole);
            this.Controls.Add(this.input_poste);
            this.Controls.Add(this.input_mdp);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.dataGrid_utilisateurs);
            this.Controls.Add(this.label_poste);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.btn_ajouter);
            this.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ongletUtilisateurs";
            this.Text = "Gérer les utilisateurs";
            this.Load += new System.EventHandler(this.ongletUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_utilisateurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_poste;
        private System.Windows.Forms.DataGridView dataGrid_utilisateurs;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label_mdp;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_nom;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_prenom;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_mdp;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_poste;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_idRole;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_idEquipe;
        private System.Windows.Forms.Label label_idEquipe;
        private System.Windows.Forms.Label label_idRole;
        private System.Windows.Forms.Label label_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_erreur;
    }
}