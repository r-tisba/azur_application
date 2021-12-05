
namespace azur_application.Onglets
{
    partial class ongletMembreGroupe
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
            this.dataGridView_utilisateur_equipe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label_idUtilisateur = new System.Windows.Forms.Label();
            this.label_idEquipe = new System.Windows.Forms.Label();
            this.label_identifiant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_identifiant_enregistrer = new System.Windows.Forms.Label();
            this.label_equipe_enregistrer = new System.Windows.Forms.Label();
            this.btn_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_utilisateur_equipe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_utilisateur_equipe
            // 
            this.dataGridView_utilisateur_equipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_utilisateur_equipe.Location = new System.Drawing.Point(189, 268);
            this.dataGridView_utilisateur_equipe.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_utilisateur_equipe.Name = "dataGridView_utilisateur_equipe";
            this.dataGridView_utilisateur_equipe.RowHeadersWidth = 51;
            this.dataGridView_utilisateur_equipe.Size = new System.Drawing.Size(604, 380);
            this.dataGridView_utilisateur_equipe.TabIndex = 22;
            this.dataGridView_utilisateur_equipe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_utilisateur_equipe_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tableau Membre Équipe :";
            // 
            // label_idUtilisateur
            // 
            this.label_idUtilisateur.AutoSize = true;
            this.label_idUtilisateur.Location = new System.Drawing.Point(65, 23);
            this.label_idUtilisateur.Name = "label_idUtilisateur";
            this.label_idUtilisateur.Size = new System.Drawing.Size(0, 17);
            this.label_idUtilisateur.TabIndex = 26;
            // 
            // label_idEquipe
            // 
            this.label_idEquipe.AutoSize = true;
            this.label_idEquipe.Location = new System.Drawing.Point(25, 26);
            this.label_idEquipe.Name = "label_idEquipe";
            this.label_idEquipe.Size = new System.Drawing.Size(0, 17);
            this.label_idEquipe.TabIndex = 27;
            // 
            // label_identifiant
            // 
            this.label_identifiant.AutoSize = true;
            this.label_identifiant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_identifiant.Location = new System.Drawing.Point(238, 122);
            this.label_identifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_identifiant.Name = "label_identifiant";
            this.label_identifiant.Size = new System.Drawing.Size(143, 28);
            this.label_identifiant.TabIndex = 28;
            this.label_identifiant.Text = "Identifiant :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Equipe :";
            // 
            // label_identifiant_enregistrer
            // 
            this.label_identifiant_enregistrer.AutoSize = true;
            this.label_identifiant_enregistrer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_identifiant_enregistrer.Location = new System.Drawing.Point(389, 127);
            this.label_identifiant_enregistrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_identifiant_enregistrer.Name = "label_identifiant_enregistrer";
            this.label_identifiant_enregistrer.Size = new System.Drawing.Size(0, 23);
            this.label_identifiant_enregistrer.TabIndex = 31;
            // 
            // label_equipe_enregistrer
            // 
            this.label_equipe_enregistrer.AutoSize = true;
            this.label_equipe_enregistrer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equipe_enregistrer.Location = new System.Drawing.Point(706, 125);
            this.label_equipe_enregistrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_equipe_enregistrer.Name = "label_equipe_enregistrer";
            this.label_equipe_enregistrer.Size = new System.Drawing.Size(0, 23);
            this.label_equipe_enregistrer.TabIndex = 32;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(776, 94);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(223, 83);
            this.btn_supprimer.TabIndex = 33;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // ongletMembreGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 692);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label_equipe_enregistrer);
            this.Controls.Add(this.label_identifiant_enregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_identifiant);
            this.Controls.Add(this.label_idEquipe);
            this.Controls.Add(this.label_idUtilisateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_utilisateur_equipe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ongletMembreGroupe";
            this.Text = "Équipes/Utilisateurs";
            this.Load += new System.EventHandler(this.ongletMembreGroupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_utilisateur_equipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_utilisateur_equipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_idUtilisateur;
        private System.Windows.Forms.Label label_idEquipe;
        private System.Windows.Forms.Label label_identifiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_identifiant_enregistrer;
        private System.Windows.Forms.Label label_equipe_enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
    }
}