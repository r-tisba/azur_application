
namespace azur_application.Fenetres.Onglets
{
    partial class ongletAffectations
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
            this.label_identifiant = new System.Windows.Forms.Label();
            this.label_equipe = new System.Windows.Forms.Label();
            this.btn_associer = new System.Windows.Forms.Button();
            this.input_equipe = new System.Windows.Forms.ComboBox();
            this.panel_inputs = new System.Windows.Forms.Panel();
            this.input_identifiant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label_erreur = new System.Windows.Forms.Label();
            this.dataGrid_compositionEquipes = new System.Windows.Forms.DataGridView();
            this.dataGrid_utilisateurs = new System.Windows.Forms.DataGridView();
            this.label_tableUtilisateurs = new System.Windows.Forms.Label();
            this.label_tableCompositions = new System.Windows.Forms.Label();
            this.panel_dataGrid = new System.Windows.Forms.Panel();
            this.panel_inputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_compositionEquipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_utilisateurs)).BeginInit();
            this.panel_dataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_identifiant
            // 
            this.label_identifiant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_identifiant.AutoSize = true;
            this.label_identifiant.Font = new System.Drawing.Font("Lato", 10F);
            this.label_identifiant.Location = new System.Drawing.Point(20, 26);
            this.label_identifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_identifiant.Name = "label_identifiant";
            this.label_identifiant.Size = new System.Drawing.Size(80, 17);
            this.label_identifiant.TabIndex = 4;
            this.label_identifiant.Text = "Identifiant :";
            // 
            // label_equipe
            // 
            this.label_equipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_equipe.AutoSize = true;
            this.label_equipe.Font = new System.Drawing.Font("Lato", 10F);
            this.label_equipe.Location = new System.Drawing.Point(42, 72);
            this.label_equipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_equipe.Name = "label_equipe";
            this.label_equipe.Size = new System.Drawing.Size(58, 17);
            this.label_equipe.TabIndex = 5;
            this.label_equipe.Text = "Équipe :";
            // 
            // btn_associer
            // 
            this.btn_associer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_associer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_associer.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_associer.ForeColor = System.Drawing.Color.White;
            this.btn_associer.Location = new System.Drawing.Point(17, 188);
            this.btn_associer.Margin = new System.Windows.Forms.Padding(5);
            this.btn_associer.Name = "btn_associer";
            this.btn_associer.Size = new System.Drawing.Size(142, 52);
            this.btn_associer.TabIndex = 2;
            this.btn_associer.Text = "Associer";
            this.btn_associer.UseVisualStyleBackColor = false;
            this.btn_associer.Click += new System.EventHandler(this.btn_associer_Click);
            // 
            // input_equipe
            // 
            this.input_equipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_equipe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input_equipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_equipe.Font = new System.Drawing.Font("Lato", 10F);
            this.input_equipe.Location = new System.Drawing.Point(107, 69);
            this.input_equipe.Margin = new System.Windows.Forms.Padding(4);
            this.input_equipe.Name = "input_equipe";
            this.input_equipe.Size = new System.Drawing.Size(146, 24);
            this.input_equipe.TabIndex = 1;
            // 
            // panel_inputs
            // 
            this.panel_inputs.Controls.Add(this.input_identifiant);
            this.panel_inputs.Controls.Add(this.input_equipe);
            this.panel_inputs.Controls.Add(this.label_equipe);
            this.panel_inputs.Controls.Add(this.label_identifiant);
            this.panel_inputs.Location = new System.Drawing.Point(17, 49);
            this.panel_inputs.Margin = new System.Windows.Forms.Padding(4);
            this.panel_inputs.Name = "panel_inputs";
            this.panel_inputs.Size = new System.Drawing.Size(293, 131);
            this.panel_inputs.TabIndex = 13;
            // 
            // input_identifiant
            // 
            this.input_identifiant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_identifiant.Depth = 0;
            this.input_identifiant.Hint = "";
            this.input_identifiant.Location = new System.Drawing.Point(107, 20);
            this.input_identifiant.MaxLength = 32767;
            this.input_identifiant.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_identifiant.Name = "input_identifiant";
            this.input_identifiant.PasswordChar = '\0';
            this.input_identifiant.SelectedText = "";
            this.input_identifiant.SelectionLength = 0;
            this.input_identifiant.SelectionStart = 0;
            this.input_identifiant.Size = new System.Drawing.Size(146, 23);
            this.input_identifiant.TabIndex = 0;
            this.input_identifiant.TabStop = false;
            this.input_identifiant.UseSystemPasswordChar = false;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(168, 188);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(142, 52);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // label_erreur
            // 
            this.label_erreur.AutoSize = true;
            this.label_erreur.Font = new System.Drawing.Font("Lato", 12F);
            this.label_erreur.ForeColor = System.Drawing.Color.Red;
            this.label_erreur.Location = new System.Drawing.Point(13, 9);
            this.label_erreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_erreur.Name = "label_erreur";
            this.label_erreur.Size = new System.Drawing.Size(0, 19);
            this.label_erreur.TabIndex = 14;
            // 
            // dataGrid_compositionEquipes
            // 
            this.dataGrid_compositionEquipes.AllowUserToAddRows = false;
            this.dataGrid_compositionEquipes.AllowUserToDeleteRows = false;
            this.dataGrid_compositionEquipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_compositionEquipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_compositionEquipes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_compositionEquipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_compositionEquipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_compositionEquipes.Location = new System.Drawing.Point(435, 40);
            this.dataGrid_compositionEquipes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_compositionEquipes.Name = "dataGrid_compositionEquipes";
            this.dataGrid_compositionEquipes.RowHeadersWidth = 51;
            this.dataGrid_compositionEquipes.Size = new System.Drawing.Size(340, 482);
            this.dataGrid_compositionEquipes.TabIndex = 5;
            this.dataGrid_compositionEquipes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_composition_CellDoubleClick);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_utilisateurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_utilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_utilisateurs.Location = new System.Drawing.Point(87, 40);
            this.dataGrid_utilisateurs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_utilisateurs.Name = "dataGrid_utilisateurs";
            this.dataGrid_utilisateurs.RowHeadersWidth = 51;
            this.dataGrid_utilisateurs.Size = new System.Drawing.Size(340, 482);
            this.dataGrid_utilisateurs.TabIndex = 4;
            this.dataGrid_utilisateurs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_utilisateur_CellDoubleClick);
            // 
            // label_tableUtilisateurs
            // 
            this.label_tableUtilisateurs.AutoSize = true;
            this.label_tableUtilisateurs.Font = new System.Drawing.Font("Lato", 14F);
            this.label_tableUtilisateurs.Location = new System.Drawing.Point(178, 13);
            this.label_tableUtilisateurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tableUtilisateurs.Name = "label_tableUtilisateurs";
            this.label_tableUtilisateurs.Size = new System.Drawing.Size(160, 23);
            this.label_tableUtilisateurs.TabIndex = 2;
            this.label_tableUtilisateurs.Text = "Liste Utilisateurs :";
            // 
            // label_tableCompositions
            // 
            this.label_tableCompositions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tableCompositions.AutoSize = true;
            this.label_tableCompositions.Font = new System.Drawing.Font("Lato", 14F);
            this.label_tableCompositions.Location = new System.Drawing.Point(523, 13);
            this.label_tableCompositions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tableCompositions.Name = "label_tableCompositions";
            this.label_tableCompositions.Size = new System.Drawing.Size(167, 23);
            this.label_tableCompositions.TabIndex = 3;
            this.label_tableCompositions.Text = "Liste Affectations :";
            // 
            // panel_dataGrid
            // 
            this.panel_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dataGrid.AutoScroll = true;
            this.panel_dataGrid.Controls.Add(this.label_tableCompositions);
            this.panel_dataGrid.Controls.Add(this.label_tableUtilisateurs);
            this.panel_dataGrid.Controls.Add(this.dataGrid_utilisateurs);
            this.panel_dataGrid.Controls.Add(this.dataGrid_compositionEquipes);
            this.panel_dataGrid.Location = new System.Drawing.Point(409, 9);
            this.panel_dataGrid.Name = "panel_dataGrid";
            this.panel_dataGrid.Size = new System.Drawing.Size(779, 532);
            this.panel_dataGrid.TabIndex = 15;
            // 
            // ongletAffectations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 540);
            this.Controls.Add(this.panel_dataGrid);
            this.Controls.Add(this.btn_associer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label_erreur);
            this.Controls.Add(this.panel_inputs);
            this.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ongletAffectations";
            this.Text = "Assignation Équipe";
            this.Load += new System.EventHandler(this.ongletAffectations_Load);
            this.panel_inputs.ResumeLayout(false);
            this.panel_inputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_compositionEquipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_utilisateurs)).EndInit();
            this.panel_dataGrid.ResumeLayout(false);
            this.panel_dataGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_identifiant;
        private System.Windows.Forms.Label label_equipe;
        private System.Windows.Forms.Button btn_associer;
        private System.Windows.Forms.ComboBox input_equipe;
        private System.Windows.Forms.Panel panel_inputs;
        private System.Windows.Forms.Label label_erreur;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.DataGridView dataGrid_compositionEquipes;
        private System.Windows.Forms.DataGridView dataGrid_utilisateurs;
        private System.Windows.Forms.Label label_tableUtilisateurs;
        private System.Windows.Forms.Label label_tableCompositions;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_identifiant;
        private System.Windows.Forms.Panel panel_dataGrid;
    }
}