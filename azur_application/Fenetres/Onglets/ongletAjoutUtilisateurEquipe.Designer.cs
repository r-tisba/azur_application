
namespace azur_application.Fenetres.Onglets
{
    partial class ongletAjoutUtilisateurEquipe
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
            this.dataGridView_donnees_equipes = new System.Windows.Forms.DataGridView();
            this.dataGridView_donnees_utilisateur = new System.Windows.Forms.DataGridView();
            this.label_liste_utilisateur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_identifiant = new System.Windows.Forms.Label();
            this.label_equipe = new System.Windows.Forms.Label();
            this.label_ajout_utilisateur = new System.Windows.Forms.Label();
            this.label_identifiant_enregistrer = new System.Windows.Forms.Label();
            this.label_equipe_enregistrer = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label_idEquipe = new System.Windows.Forms.Label();
            this.label_idUtilisateur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_donnees_equipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_donnees_utilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_donnees_equipes
            // 
            this.dataGridView_donnees_equipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_donnees_equipes.Location = new System.Drawing.Point(697, 237);
            this.dataGridView_donnees_equipes.Name = "dataGridView_donnees_equipes";
            this.dataGridView_donnees_equipes.RowHeadersWidth = 51;
            this.dataGridView_donnees_equipes.Size = new System.Drawing.Size(254, 308);
            this.dataGridView_donnees_equipes.TabIndex = 0;
            this.dataGridView_donnees_equipes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_donnees_equipes_CellDoubleClick);
            // 
            // dataGridView_donnees_utilisateur
            // 
            this.dataGridView_donnees_utilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_donnees_utilisateur.Location = new System.Drawing.Point(203, 237);
            this.dataGridView_donnees_utilisateur.Name = "dataGridView_donnees_utilisateur";
            this.dataGridView_donnees_utilisateur.RowHeadersWidth = 51;
            this.dataGridView_donnees_utilisateur.Size = new System.Drawing.Size(254, 308);
            this.dataGridView_donnees_utilisateur.TabIndex = 1;
            this.dataGridView_donnees_utilisateur.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_donnees_utilisateur_CellDoubleClick);
            // 
            // label_liste_utilisateur
            // 
            this.label_liste_utilisateur.AutoSize = true;
            this.label_liste_utilisateur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_liste_utilisateur.Location = new System.Drawing.Point(197, 193);
            this.label_liste_utilisateur.Name = "label_liste_utilisateur";
            this.label_liste_utilisateur.Size = new System.Drawing.Size(263, 32);
            this.label_liste_utilisateur.TabIndex = 2;
            this.label_liste_utilisateur.Text = "Liste Utilisateurs :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste Équipes :";
            // 
            // label_identifiant
            // 
            this.label_identifiant.AutoSize = true;
            this.label_identifiant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_identifiant.Location = new System.Drawing.Point(256, 142);
            this.label_identifiant.Name = "label_identifiant";
            this.label_identifiant.Size = new System.Drawing.Size(119, 23);
            this.label_identifiant.TabIndex = 4;
            this.label_identifiant.Text = "Identifiant :";
            // 
            // label_equipe
            // 
            this.label_equipe.AutoSize = true;
            this.label_equipe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equipe.Location = new System.Drawing.Point(256, 107);
            this.label_equipe.Name = "label_equipe";
            this.label_equipe.Size = new System.Drawing.Size(89, 23);
            this.label_equipe.TabIndex = 5;
            this.label_equipe.Text = "Équipe :";
            // 
            // label_ajout_utilisateur
            // 
            this.label_ajout_utilisateur.AutoSize = true;
            this.label_ajout_utilisateur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ajout_utilisateur.Location = new System.Drawing.Point(254, 62);
            this.label_ajout_utilisateur.Name = "label_ajout_utilisateur";
            this.label_ajout_utilisateur.Size = new System.Drawing.Size(595, 32);
            this.label_ajout_utilisateur.TabIndex = 6;
            this.label_ajout_utilisateur.Text = "Assignation d\'un Utilisateur à une Équipe :";
            // 
            // label_identifiant_enregistrer
            // 
            this.label_identifiant_enregistrer.AutoSize = true;
            this.label_identifiant_enregistrer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_identifiant_enregistrer.Location = new System.Drawing.Point(381, 142);
            this.label_identifiant_enregistrer.Name = "label_identifiant_enregistrer";
            this.label_identifiant_enregistrer.Size = new System.Drawing.Size(0, 23);
            this.label_identifiant_enregistrer.TabIndex = 7;
            // 
            // label_equipe_enregistrer
            // 
            this.label_equipe_enregistrer.AutoSize = true;
            this.label_equipe_enregistrer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equipe_enregistrer.Location = new System.Drawing.Point(375, 107);
            this.label_equipe_enregistrer.Name = "label_equipe_enregistrer";
            this.label_equipe_enregistrer.Size = new System.Drawing.Size(0, 23);
            this.label_equipe_enregistrer.TabIndex = 8;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(697, 113);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(152, 52);
            this.btn_ajouter.TabIndex = 9;
            this.btn_ajouter.Text = "Associer";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label_idEquipe
            // 
            this.label_idEquipe.AutoSize = true;
            this.label_idEquipe.Location = new System.Drawing.Point(13, 13);
            this.label_idEquipe.Name = "label_idEquipe";
            this.label_idEquipe.Size = new System.Drawing.Size(0, 15);
            this.label_idEquipe.TabIndex = 10;
            // 
            // label_idUtilisateur
            // 
            this.label_idUtilisateur.AutoSize = true;
            this.label_idUtilisateur.Location = new System.Drawing.Point(13, 48);
            this.label_idUtilisateur.Name = "label_idUtilisateur";
            this.label_idUtilisateur.Size = new System.Drawing.Size(0, 15);
            this.label_idUtilisateur.TabIndex = 11;
            // 
            // ongletAjoutUtilisateurEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 557);
            this.Controls.Add(this.label_idUtilisateur);
            this.Controls.Add(this.label_idEquipe);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label_equipe_enregistrer);
            this.Controls.Add(this.label_identifiant_enregistrer);
            this.Controls.Add(this.label_ajout_utilisateur);
            this.Controls.Add(this.label_equipe);
            this.Controls.Add(this.label_identifiant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_liste_utilisateur);
            this.Controls.Add(this.dataGridView_donnees_utilisateur);
            this.Controls.Add(this.dataGridView_donnees_equipes);
            this.Name = "ongletAjoutUtilisateurEquipe";
            this.Text = "Assignation Équipe";
            this.Load += new System.EventHandler(this.ongletAjoutUtilisateurEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_donnees_equipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_donnees_utilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_donnees_equipes;
        private System.Windows.Forms.DataGridView dataGridView_donnees_utilisateur;
        private System.Windows.Forms.Label label_liste_utilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_identifiant;
        private System.Windows.Forms.Label label_equipe;
        private System.Windows.Forms.Label label_ajout_utilisateur;
        private System.Windows.Forms.Label label_identifiant_enregistrer;
        private System.Windows.Forms.Label label_equipe_enregistrer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label_idEquipe;
        private System.Windows.Forms.Label label_idUtilisateur;
    }
}