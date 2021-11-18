
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
            this.ajout_utilisateur = new System.Windows.Forms.Button();
            this.input_idEquipe = new System.Windows.Forms.TextBox();
            this.input_idUtilisateur = new System.Windows.Forms.TextBox();
            this.label_idEquipe = new System.Windows.Forms.Label();
            this.idUtilisateur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_idEmploye = new System.Windows.Forms.Label();
            this.labelIdEquipe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_utilisateur_equipe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_utilisateur_equipe
            // 
            this.dataGridView_utilisateur_equipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_utilisateur_equipe.Location = new System.Drawing.Point(477, 313);
            this.dataGridView_utilisateur_equipe.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_utilisateur_equipe.Name = "dataGridView_utilisateur_equipe";
            this.dataGridView_utilisateur_equipe.RowHeadersWidth = 51;
            this.dataGridView_utilisateur_equipe.Size = new System.Drawing.Size(604, 380);
            this.dataGridView_utilisateur_equipe.TabIndex = 22;
            this.dataGridView_utilisateur_equipe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_utilisateur_equipe_CellDoubleClick);
            // 
            // ajout_utilisateur
            // 
            this.ajout_utilisateur.BackColor = System.Drawing.Color.Lime;
            this.ajout_utilisateur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajout_utilisateur.ForeColor = System.Drawing.Color.FloralWhite;
            this.ajout_utilisateur.Location = new System.Drawing.Point(1141, 127);
            this.ajout_utilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_utilisateur.Name = "ajout_utilisateur";
            this.ajout_utilisateur.Size = new System.Drawing.Size(236, 60);
            this.ajout_utilisateur.TabIndex = 21;
            this.ajout_utilisateur.Text = "Ajouter Utilisateur";
            this.ajout_utilisateur.UseVisualStyleBackColor = false;
            this.ajout_utilisateur.Click += new System.EventHandler(this.ajout_utilisateur_Click_1);
            // 
            // input_idEquipe
            // 
            this.input_idEquipe.Location = new System.Drawing.Point(916, 137);
            this.input_idEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.input_idEquipe.Name = "input_idEquipe";
            this.input_idEquipe.Size = new System.Drawing.Size(132, 22);
            this.input_idEquipe.TabIndex = 20;
            // 
            // input_idUtilisateur
            // 
            this.input_idUtilisateur.Location = new System.Drawing.Point(511, 137);
            this.input_idUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.input_idUtilisateur.Name = "input_idUtilisateur";
            this.input_idUtilisateur.Size = new System.Drawing.Size(132, 22);
            this.input_idUtilisateur.TabIndex = 19;
            // 
            // label_idEquipe
            // 
            this.label_idEquipe.AutoSize = true;
            this.label_idEquipe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idEquipe.Location = new System.Drawing.Point(683, 127);
            this.label_idEquipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idEquipe.Name = "label_idEquipe";
            this.label_idEquipe.Size = new System.Drawing.Size(129, 28);
            this.label_idEquipe.TabIndex = 18;
            this.label_idEquipe.Text = "idEquipe :";
            // 
            // idUtilisateur
            // 
            this.idUtilisateur.AutoSize = true;
            this.idUtilisateur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUtilisateur.Location = new System.Drawing.Point(277, 127);
            this.idUtilisateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idUtilisateur.Name = "idUtilisateur";
            this.idUtilisateur.Size = new System.Drawing.Size(169, 28);
            this.idUtilisateur.TabIndex = 17;
            this.idUtilisateur.Text = "idUtilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 44);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ajouter un Utilisateur dans l\'Équipe :";
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_modifier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifier.Location = new System.Drawing.Point(1089, 358);
            this.button_modifier.Margin = new System.Windows.Forms.Padding(4);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(203, 58);
            this.button_modifier.TabIndex = 23;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.Color.Crimson;
            this.button_supprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.ForeColor = System.Drawing.Color.Transparent;
            this.button_supprimer.Location = new System.Drawing.Point(1089, 508);
            this.button_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(201, 62);
            this.button_supprimer.TabIndex = 24;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tableau Membre Équipe :";
            // 
            // label_idEmploye
            // 
            this.label_idEmploye.AutoSize = true;
            this.label_idEmploye.Location = new System.Drawing.Point(303, 201);
            this.label_idEmploye.Name = "label_idEmploye";
            this.label_idEmploye.Size = new System.Drawing.Size(0, 17);
            this.label_idEmploye.TabIndex = 26;
            // 
            // labelIdEquipe
            // 
            this.labelIdEquipe.AutoSize = true;
            this.labelIdEquipe.Location = new System.Drawing.Point(303, 233);
            this.labelIdEquipe.Name = "labelIdEquipe";
            this.labelIdEquipe.Size = new System.Drawing.Size(0, 17);
            this.labelIdEquipe.TabIndex = 27;
            // 
            // ongletMembreGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 719);
            this.Controls.Add(this.labelIdEquipe);
            this.Controls.Add(this.label_idEmploye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.dataGridView_utilisateur_equipe);
            this.Controls.Add(this.ajout_utilisateur);
            this.Controls.Add(this.input_idEquipe);
            this.Controls.Add(this.input_idUtilisateur);
            this.Controls.Add(this.label_idEquipe);
            this.Controls.Add(this.idUtilisateur);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ongletMembreGroupe";
            this.Text = "Utilisateur et Équipe";
            this.Load += new System.EventHandler(this.ongletMembreGroupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_utilisateur_equipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_utilisateur_equipe;
        private System.Windows.Forms.Button ajout_utilisateur;
        private System.Windows.Forms.TextBox input_idEquipe;
        private System.Windows.Forms.TextBox input_idUtilisateur;
        private System.Windows.Forms.Label label_idEquipe;
        private System.Windows.Forms.Label idUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_idEmploye;
        private System.Windows.Forms.Label labelIdEquipe;
    }
}