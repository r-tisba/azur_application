
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_utilisateur_equipe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_utilisateur_equipe
            // 
            this.dataGridView_utilisateur_equipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_utilisateur_equipe.Location = new System.Drawing.Point(358, 254);
            this.dataGridView_utilisateur_equipe.Name = "dataGridView_utilisateur_equipe";
            this.dataGridView_utilisateur_equipe.RowHeadersWidth = 51;
            this.dataGridView_utilisateur_equipe.Size = new System.Drawing.Size(453, 309);
            this.dataGridView_utilisateur_equipe.TabIndex = 22;
            this.dataGridView_utilisateur_equipe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_utilisateur_equipe_CellDoubleClick);
            // 
            // ajout_utilisateur
            // 
            this.ajout_utilisateur.BackColor = System.Drawing.Color.Lime;
            this.ajout_utilisateur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajout_utilisateur.ForeColor = System.Drawing.Color.FloralWhite;
            this.ajout_utilisateur.Location = new System.Drawing.Point(856, 103);
            this.ajout_utilisateur.Name = "ajout_utilisateur";
            this.ajout_utilisateur.Size = new System.Drawing.Size(177, 49);
            this.ajout_utilisateur.TabIndex = 21;
            this.ajout_utilisateur.Text = "Ajouter Utilisateur";
            this.ajout_utilisateur.UseVisualStyleBackColor = false;
            this.ajout_utilisateur.Click += new System.EventHandler(this.ajout_utilisateur_Click_1);
            // 
            // input_idEquipe
            // 
            this.input_idEquipe.Location = new System.Drawing.Point(687, 111);
            this.input_idEquipe.Name = "input_idEquipe";
            this.input_idEquipe.Size = new System.Drawing.Size(100, 20);
            this.input_idEquipe.TabIndex = 20;
            // 
            // input_idUtilisateur
            // 
            this.input_idUtilisateur.Location = new System.Drawing.Point(383, 111);
            this.input_idUtilisateur.Name = "input_idUtilisateur";
            this.input_idUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.input_idUtilisateur.TabIndex = 19;
            // 
            // label_idEquipe
            // 
            this.label_idEquipe.AutoSize = true;
            this.label_idEquipe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idEquipe.Location = new System.Drawing.Point(512, 103);
            this.label_idEquipe.Name = "label_idEquipe";
            this.label_idEquipe.Size = new System.Drawing.Size(129, 28);
            this.label_idEquipe.TabIndex = 18;
            this.label_idEquipe.Text = "idEquipe :";
            // 
            // idUtilisateur
            // 
            this.idUtilisateur.AutoSize = true;
            this.idUtilisateur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUtilisateur.Location = new System.Drawing.Point(208, 103);
            this.idUtilisateur.Name = "idUtilisateur";
            this.idUtilisateur.Size = new System.Drawing.Size(169, 28);
            this.idUtilisateur.TabIndex = 17;
            this.idUtilisateur.Text = "idUtilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 44);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ajouter un Utilisateur dans l\'Équipe :";
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_modifier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifier.Location = new System.Drawing.Point(817, 291);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(152, 47);
            this.button_modifier.TabIndex = 23;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(817, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 50);
            this.button1.TabIndex = 24;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tableau Membre Équipe :";
            // 
            // ongletMembreGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.dataGridView_utilisateur_equipe);
            this.Controls.Add(this.ajout_utilisateur);
            this.Controls.Add(this.input_idEquipe);
            this.Controls.Add(this.input_idUtilisateur);
            this.Controls.Add(this.label_idEquipe);
            this.Controls.Add(this.idUtilisateur);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}