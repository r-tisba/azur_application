﻿
namespace azur_application.Onglets
{
    partial class ongletEquipe
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
            this.dataGridView_equipe = new System.Windows.Forms.DataGridView();
            this.label_creer_equipe = new System.Windows.Forms.Label();
            this.nom_equipe = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.input_nom_equipe = new System.Windows.Forms.TextBox();
            this.input_image = new System.Windows.Forms.TextBox();
            this.creer_equipe = new System.Windows.Forms.Button();
            this.label_tableau_equipe = new System.Windows.Forms.Label();
            this.button_suppr = new System.Windows.Forms.Button();
            this.button_modif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_equipe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_equipe
            // 
            this.dataGridView_equipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_equipe.Location = new System.Drawing.Point(354, 275);
            this.dataGridView_equipe.Name = "dataGridView_equipe";
            this.dataGridView_equipe.RowHeadersWidth = 51;
            this.dataGridView_equipe.Size = new System.Drawing.Size(354, 232);
            this.dataGridView_equipe.TabIndex = 0;
            this.dataGridView_equipe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_equipe_CellDoubleClick);
            // 
            // label_creer_equipe
            // 
            this.label_creer_equipe.AutoSize = true;
            this.label_creer_equipe.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_creer_equipe.Location = new System.Drawing.Point(25, 25);
            this.label_creer_equipe.Name = "label_creer_equipe";
            this.label_creer_equipe.Size = new System.Drawing.Size(216, 42);
            this.label_creer_equipe.TabIndex = 1;
            this.label_creer_equipe.Text = "Créer Équipe :";
            // 
            // nom_equipe
            // 
            this.nom_equipe.AutoSize = true;
            this.nom_equipe.BackColor = System.Drawing.SystemColors.Control;
            this.nom_equipe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_equipe.Location = new System.Drawing.Point(180, 94);
            this.nom_equipe.Name = "nom_equipe";
            this.nom_equipe.Size = new System.Drawing.Size(132, 22);
            this.nom_equipe.TabIndex = 3;
            this.nom_equipe.Text = "Nom Équipe :";
            // 
            // image
            // 
            this.image.AutoSize = true;
            this.image.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.Location = new System.Drawing.Point(180, 152);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(78, 22);
            this.image.TabIndex = 5;
            this.image.Text = "Image :";
            // 
            // input_nom_equipe
            // 
            this.input_nom_equipe.Location = new System.Drawing.Point(352, 102);
            this.input_nom_equipe.Name = "input_nom_equipe";
            this.input_nom_equipe.Size = new System.Drawing.Size(100, 20);
            this.input_nom_equipe.TabIndex = 6;
            // 
            // input_image
            // 
            this.input_image.Location = new System.Drawing.Point(284, 159);
            this.input_image.Name = "input_image";
            this.input_image.Size = new System.Drawing.Size(100, 20);
            this.input_image.TabIndex = 8;
            // 
            // creer_equipe
            // 
            this.creer_equipe.BackColor = System.Drawing.Color.Lime;
            this.creer_equipe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creer_equipe.ForeColor = System.Drawing.Color.White;
            this.creer_equipe.Location = new System.Drawing.Point(488, 134);
            this.creer_equipe.Name = "creer_equipe";
            this.creer_equipe.Size = new System.Drawing.Size(200, 45);
            this.creer_equipe.TabIndex = 13;
            this.creer_equipe.Text = "Créer Équipe";
            this.creer_equipe.UseVisualStyleBackColor = false;
            this.creer_equipe.Click += new System.EventHandler(this.creer_equipe_Click);
            // 
            // label_tableau_equipe
            // 
            this.label_tableau_equipe.AutoSize = true;
            this.label_tableau_equipe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tableau_equipe.Location = new System.Drawing.Point(401, 216);
            this.label_tableau_equipe.Name = "label_tableau_equipe";
            this.label_tableau_equipe.Size = new System.Drawing.Size(233, 32);
            this.label_tableau_equipe.TabIndex = 14;
            this.label_tableau_equipe.Text = "Tableau Équipe :";
            // 
            // button_suppr
            // 
            this.button_suppr.BackColor = System.Drawing.Color.Crimson;
            this.button_suppr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_suppr.ForeColor = System.Drawing.Color.Transparent;
            this.button_suppr.Location = new System.Drawing.Point(737, 305);
            this.button_suppr.Name = "button_suppr";
            this.button_suppr.Size = new System.Drawing.Size(200, 52);
            this.button_suppr.TabIndex = 15;
            this.button_suppr.Text = "Supprimer";
            this.button_suppr.UseVisualStyleBackColor = false;
            this.button_suppr.Click += new System.EventHandler(this.button_suppr_Click);
            // 
            // button_modif
            // 
            this.button_modif.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_modif.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modif.ForeColor = System.Drawing.Color.White;
            this.button_modif.Location = new System.Drawing.Point(737, 426);
            this.button_modif.Name = "button_modif";
            this.button_modif.Size = new System.Drawing.Size(200, 48);
            this.button_modif.TabIndex = 16;
            this.button_modif.Text = "Modifier";
            this.button_modif.UseVisualStyleBackColor = false;
            this.button_modif.Click += new System.EventHandler(this.button_modif_Click);
            // 
            // ongletEquipe
            // 
            this.ClientSize = new System.Drawing.Size(1287, 542);
            this.Controls.Add(this.button_modif);
            this.Controls.Add(this.button_suppr);
            this.Controls.Add(this.label_tableau_equipe);
            this.Controls.Add(this.creer_equipe);
            this.Controls.Add(this.input_image);
            this.Controls.Add(this.input_nom_equipe);
            this.Controls.Add(this.image);
            this.Controls.Add(this.nom_equipe);
            this.Controls.Add(this.label_creer_equipe);
            this.Controls.Add(this.dataGridView_equipe);
            this.Name = "ongletEquipe";
            this.Text = "Équipe";
            this.Load += new System.EventHandler(this.ongletEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_equipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.DataGridView dataGridView_equipe;
        private System.Windows.Forms.Label label_creer_equipe;
        private System.Windows.Forms.Label nom_equipe;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.TextBox input_nom_equipe;
        private System.Windows.Forms.TextBox input_image;
        private System.Windows.Forms.Button creer_equipe;
        private System.Windows.Forms.Label label_tableau_equipe;
        private System.Windows.Forms.Button button_suppr;
        private System.Windows.Forms.Button button_modif;
    }
}