
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
            this.panel_input1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_utilisateurs)).BeginInit();
            this.panel_input1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(920, 39);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(152, 52);
            this.btn_ajouter.TabIndex = 0;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // dataGrid_utilisateurs
            // 
            this.dataGrid_utilisateurs.AllowUserToAddRows = false;
            this.dataGrid_utilisateurs.AllowUserToDeleteRows = false;
            this.dataGrid_utilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_utilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_utilisateurs.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_utilisateurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_utilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_utilisateurs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_utilisateurs.Location = new System.Drawing.Point(13, 271);
            this.dataGrid_utilisateurs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_utilisateurs.Name = "dataGrid_utilisateurs";
            this.dataGrid_utilisateurs.RowHeadersWidth = 51;
            this.dataGrid_utilisateurs.Size = new System.Drawing.Size(1082, 211);
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
            this.btn_modifier.Location = new System.Drawing.Point(920, 99);
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
            this.btn_supprimer.Location = new System.Drawing.Point(920, 159);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(152, 52);
            this.btn_supprimer.TabIndex = 17;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table.Location = new System.Drawing.Point(12, 229);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(254, 36);
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
            this.label_erreur.Size = new System.Drawing.Size(0, 24);
            this.label_erreur.TabIndex = 31;
            // 
            // label_asterisque
            // 
            this.label_asterisque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_asterisque.AutoSize = true;
            this.label_asterisque.Font = new System.Drawing.Font("Lato Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asterisque.Location = new System.Drawing.Point(916, 12);
            this.label_asterisque.Name = "label_asterisque";
            this.label_asterisque.Size = new System.Drawing.Size(183, 21);
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
            this.label_idRole.Size = new System.Drawing.Size(51, 21);
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
            this.input_prenom.Size = new System.Drawing.Size(165, 28);
            this.input_prenom.TabIndex = 22;
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
            this.input_poste.Size = new System.Drawing.Size(165, 28);
            this.input_poste.TabIndex = 24;
            this.input_poste.TabStop = false;
            this.input_poste.UseSystemPasswordChar = false;
            // 
            // input_role
            // 
            this.input_role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_role.Location = new System.Drawing.Point(443, 70);
            this.input_role.Name = "input_role";
            this.input_role.Size = new System.Drawing.Size(165, 27);
            this.input_role.TabIndex = 33;
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.Location = new System.Drawing.Point(15, 72);
            this.label_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(76, 21);
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
            this.label_nom.Size = new System.Drawing.Size(55, 21);
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
            this.input_nom.Size = new System.Drawing.Size(165, 28);
            this.input_nom.TabIndex = 21;
            this.input_nom.TabStop = false;
            this.input_nom.UseSystemPasswordChar = false;
            // 
            // label_mdp
            // 
            this.label_mdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdp.Location = new System.Drawing.Point(311, 22);
            this.label_mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(125, 21);
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
            this.label_poste.Size = new System.Drawing.Size(60, 21);
            this.label_poste.TabIndex = 9;
            this.label_poste.Text = "Poste :";
            // 
            // input_mdp
            // 
            this.input_mdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_mdp.Depth = 0;
            this.input_mdp.Hint = "";
            this.input_mdp.Location = new System.Drawing.Point(443, 22);
            this.input_mdp.MaxLength = 32767;
            this.input_mdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_mdp.Name = "input_mdp";
            this.input_mdp.PasswordChar = '\0';
            this.input_mdp.SelectedText = "";
            this.input_mdp.SelectionLength = 0;
            this.input_mdp.SelectionStart = 0;
            this.input_mdp.Size = new System.Drawing.Size(165, 28);
            this.input_mdp.TabIndex = 23;
            this.input_mdp.TabStop = false;
            this.input_mdp.UseSystemPasswordChar = false;
            // 
            // panel_input1
            // 
            this.panel_input1.Controls.Add(this.input_mdp);
            this.panel_input1.Controls.Add(this.label_poste);
            this.panel_input1.Controls.Add(this.label_mdp);
            this.panel_input1.Controls.Add(this.input_nom);
            this.panel_input1.Controls.Add(this.label_nom);
            this.panel_input1.Controls.Add(this.label_prenom);
            this.panel_input1.Controls.Add(this.input_role);
            this.panel_input1.Controls.Add(this.input_poste);
            this.panel_input1.Controls.Add(this.input_prenom);
            this.panel_input1.Controls.Add(this.label_idRole);
            this.panel_input1.Location = new System.Drawing.Point(18, 41);
            this.panel_input1.Name = "panel_input1";
            this.panel_input1.Size = new System.Drawing.Size(671, 172);
            this.panel_input1.TabIndex = 35;
            // 
            // ongletUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 495);
            this.Controls.Add(this.panel_input1);
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
            this.panel_input1.ResumeLayout(false);
            this.panel_input1.PerformLayout();
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
        private System.Windows.Forms.Panel panel_input1;
    }
}