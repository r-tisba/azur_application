
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_equipe = new System.Windows.Forms.DataGridView();
            this.nom_equipe = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.btn_creer = new System.Windows.Forms.Button();
            this.label_tableEquipe = new System.Windows.Forms.Label();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.input_nomEquipe = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_erreur = new System.Windows.Forms.Label();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.input_image = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.input_rechercher = new System.Windows.Forms.TextBox();
            this.label_rechercher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_equipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_image)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_equipe
            // 
            this.dataGrid_equipe.AllowUserToAddRows = false;
            this.dataGrid_equipe.AllowUserToDeleteRows = false;
            this.dataGrid_equipe.AllowUserToResizeColumns = false;
            this.dataGrid_equipe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGrid_equipe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_equipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_equipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_equipe.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGrid_equipe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGrid_equipe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_equipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_equipe.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_equipe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_equipe.EnableHeadersVisualStyles = false;
            this.dataGrid_equipe.Location = new System.Drawing.Point(744, 35);
            this.dataGrid_equipe.Name = "dataGrid_equipe";
            this.dataGrid_equipe.ReadOnly = true;
            this.dataGrid_equipe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 9.749999F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_equipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_equipe.RowHeadersVisible = false;
            this.dataGrid_equipe.RowHeadersWidth = 51;
            this.dataGrid_equipe.Size = new System.Drawing.Size(444, 495);
            this.dataGrid_equipe.TabIndex = 0;
            this.dataGrid_equipe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_equipe_CellDoubleClick);
            // 
            // nom_equipe
            // 
            this.nom_equipe.AutoSize = true;
            this.nom_equipe.BackColor = System.Drawing.SystemColors.Control;
            this.nom_equipe.Font = new System.Drawing.Font("Lato", 10F);
            this.nom_equipe.Location = new System.Drawing.Point(14, 63);
            this.nom_equipe.Name = "nom_equipe";
            this.nom_equipe.Size = new System.Drawing.Size(92, 17);
            this.nom_equipe.TabIndex = 3;
            this.nom_equipe.Text = "Nom équipe :";
            // 
            // image
            // 
            this.image.AutoSize = true;
            this.image.Font = new System.Drawing.Font("Lato", 10F);
            this.image.Location = new System.Drawing.Point(14, 106);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(53, 17);
            this.image.TabIndex = 5;
            this.image.Text = "Image :";
            // 
            // btn_creer
            // 
            this.btn_creer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_creer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creer.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_creer.ForeColor = System.Drawing.Color.White;
            this.btn_creer.Location = new System.Drawing.Point(570, 81);
            this.btn_creer.Name = "btn_creer";
            this.btn_creer.Size = new System.Drawing.Size(147, 45);
            this.btn_creer.TabIndex = 13;
            this.btn_creer.Text = "Créer";
            this.btn_creer.UseVisualStyleBackColor = false;
            this.btn_creer.Click += new System.EventHandler(this.btn_creer_Click);
            // 
            // label_tableEquipe
            // 
            this.label_tableEquipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tableEquipe.AutoSize = true;
            this.label_tableEquipe.Font = new System.Drawing.Font("Lato", 14F);
            this.label_tableEquipe.Location = new System.Drawing.Point(901, 9);
            this.label_tableEquipe.Name = "label_tableEquipe";
            this.label_tableEquipe.Size = new System.Drawing.Size(147, 23);
            this.label_tableEquipe.TabIndex = 14;
            this.label_tableEquipe.Text = "Tableau Équipe :";
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_supprimer.ForeColor = System.Drawing.Color.Transparent;
            this.btn_supprimer.Location = new System.Drawing.Point(570, 186);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(147, 52);
            this.btn_supprimer.TabIndex = 15;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modifier.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(570, 132);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(147, 48);
            this.btn_modifier.TabIndex = 16;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // input_nomEquipe
            // 
            this.input_nomEquipe.Depth = 0;
            this.input_nomEquipe.Hint = "";
            this.input_nomEquipe.Location = new System.Drawing.Point(113, 63);
            this.input_nomEquipe.MaxLength = 32767;
            this.input_nomEquipe.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_nomEquipe.Name = "input_nomEquipe";
            this.input_nomEquipe.PasswordChar = '\0';
            this.input_nomEquipe.SelectedText = "";
            this.input_nomEquipe.SelectionLength = 0;
            this.input_nomEquipe.SelectionStart = 0;
            this.input_nomEquipe.Size = new System.Drawing.Size(160, 23);
            this.input_nomEquipe.TabIndex = 17;
            this.input_nomEquipe.TabStop = false;
            this.input_nomEquipe.UseSystemPasswordChar = false;
            // 
            // label_erreur
            // 
            this.label_erreur.AutoSize = true;
            this.label_erreur.Font = new System.Drawing.Font("Lato", 12F);
            this.label_erreur.ForeColor = System.Drawing.Color.Red;
            this.label_erreur.Location = new System.Drawing.Point(13, 13);
            this.label_erreur.Name = "label_erreur";
            this.label_erreur.Size = new System.Drawing.Size(0, 19);
            this.label_erreur.TabIndex = 19;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image.Location = new System.Drawing.Point(12, 144);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(387, 386);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 20;
            this.pictureBox_image.TabStop = false;
            // 
            // btn_image
            // 
            this.btn_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_image.Font = new System.Drawing.Font("Lato", 8.2F);
            this.btn_image.Location = new System.Drawing.Point(279, 103);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(120, 23);
            this.btn_image.TabIndex = 21;
            this.btn_image.Text = "Choisir une image";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // input_image
            // 
            this.input_image.BeforeTouchSize = new System.Drawing.Size(200, 23);
            this.input_image.Location = new System.Drawing.Point(73, 103);
            this.input_image.Name = "input_image";
            this.input_image.Size = new System.Drawing.Size(200, 23);
            this.input_image.TabIndex = 22;
            // 
            // input_rechercher
            // 
            this.input_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_rechercher.Location = new System.Drawing.Point(570, 35);
            this.input_rechercher.Name = "input_rechercher";
            this.input_rechercher.Size = new System.Drawing.Size(147, 23);
            this.input_rechercher.TabIndex = 39;
            this.input_rechercher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_rechercher_KeyUp);
            // 
            // label_rechercher
            // 
            this.label_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rechercher.AutoSize = true;
            this.label_rechercher.Font = new System.Drawing.Font("Lato", 10F);
            this.label_rechercher.Location = new System.Drawing.Point(478, 38);
            this.label_rechercher.Name = "label_rechercher";
            this.label_rechercher.Size = new System.Drawing.Size(86, 17);
            this.label_rechercher.TabIndex = 38;
            this.label_rechercher.Text = "Rechercher :";
            // 
            // ongletEquipe
            // 
            this.ClientSize = new System.Drawing.Size(1200, 540);
            this.Controls.Add(this.input_rechercher);
            this.Controls.Add(this.label_rechercher);
            this.Controls.Add(this.input_image);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.label_erreur);
            this.Controls.Add(this.input_nomEquipe);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label_tableEquipe);
            this.Controls.Add(this.btn_creer);
            this.Controls.Add(this.image);
            this.Controls.Add(this.nom_equipe);
            this.Controls.Add(this.dataGrid_equipe);
            this.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ongletEquipe";
            this.Text = "Équipe";
            this.Load += new System.EventHandler(this.ongletEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_equipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.DataGridView dataGrid_equipe;
        private System.Windows.Forms.Label nom_equipe;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.Button btn_creer;
        private System.Windows.Forms.Label label_tableEquipe;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_nomEquipe;
        private System.Windows.Forms.Label label_erreur;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Button btn_image;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt input_image;
        private System.Windows.Forms.TextBox input_rechercher;
        private System.Windows.Forms.Label label_rechercher;
    }
}