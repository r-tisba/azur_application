
namespace azur_application
{
    partial class gestion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion));
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._MinButton = new CustomWindowsForm.ButtonZ();
            this._MaxButton = new CustomWindowsForm.MinMaxButton();
            this._CloseButton = new CustomWindowsForm.ButtonZ();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button_gestion_membre_equipe = new System.Windows.Forms.Button();
            this.btnParametres = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnProjets = new System.Windows.Forms.Button();
            this.btnUtilisateurs = new System.Windows.Forms.Button();
            this.btnGestEquipe = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label_azur = new System.Windows.Forms.Label();
            this.logo_azur = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseChild = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_azur)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(1300, 2);
            this.TopBorderPanel.TabIndex = 0;
            this.TopBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseDown);
            this.TopBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseMove);
            this.TopBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseUp);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(2, 678);
            this.LeftPanel.TabIndex = 2;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            this.LeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(1298, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(2, 678);
            this.RightPanel.TabIndex = 3;
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.BottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(2, 678);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1296, 2);
            this.BottomPanel.TabIndex = 4;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // _MinButton
            // 
            this._MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this._MinButton.DisplayText = "_";
            this._MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._MinButton.ForeColor = System.Drawing.Color.White;
            this._MinButton.Location = new System.Drawing.Point(1223, -3);
            this._MinButton.Margin = new System.Windows.Forms.Padding(2);
            this._MinButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this._MinButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this._MinButton.Name = "_MinButton";
            this._MinButton.Size = new System.Drawing.Size(22, 30);
            this._MinButton.TabIndex = 4;
            this._MinButton.Text = "_";
            this._MinButton.TextLocation_X = 5;
            this._MinButton.TextLocation_Y = -14;
            this.toolTip1.SetToolTip(this._MinButton, "Minimize");
            this._MinButton.UseVisualStyleBackColor = true;
            this._MinButton.Click += new System.EventHandler(this._MinButton_Click);
            // 
            // _MaxButton
            // 
            this._MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this._MaxButton.CFormState = CustomWindowsForm.MinMaxButton.CustomFormState.Normal;
            this._MaxButton.DisplayText = "_";
            this._MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._MaxButton.ForeColor = System.Drawing.Color.White;
            this._MaxButton.Location = new System.Drawing.Point(1249, 5);
            this._MaxButton.Margin = new System.Windows.Forms.Padding(2);
            this._MaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this._MaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this._MaxButton.Name = "_MaxButton";
            this._MaxButton.Size = new System.Drawing.Size(22, 30);
            this._MaxButton.TabIndex = 3;
            this._MaxButton.Text = "_";
            this._MaxButton.TextLocation_X = 7;
            this._MaxButton.TextLocation_Y = 10;
            this.toolTip1.SetToolTip(this._MaxButton, "Maximise");
            this._MaxButton.UseVisualStyleBackColor = true;
            this._MaxButton.Click += new System.EventHandler(this._MaxButton_Click);
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(1268, 3);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(22, 30);
            this._CloseButton.TabIndex = 0;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 7;
            this._CloseButton.TextLocation_Y = 6;
            this.toolTip1.SetToolTip(this._CloseButton, "Close");
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this._MinButton);
            this.TopPanel.Controls.Add(this._MaxButton);
            this.TopPanel.Controls.Add(this._CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Location = new System.Drawing.Point(2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1296, 37);
            this.TopPanel.TabIndex = 7;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.button_gestion_membre_equipe);
            this.panelMenu.Controls.Add(this.btnParametres);
            this.panelMenu.Controls.Add(this.btnStatistiques);
            this.panelMenu.Controls.Add(this.btnProjets);
            this.panelMenu.Controls.Add(this.btnUtilisateurs);
            this.panelMenu.Controls.Add(this.btnGestEquipe);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(2, 39);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 639);
            this.panelMenu.TabIndex = 8;
            // 
            // button_gestion_membre_equipe
            // 
            this.button_gestion_membre_equipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_gestion_membre_equipe.FlatAppearance.BorderSize = 0;
            this.button_gestion_membre_equipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gestion_membre_equipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_gestion_membre_equipe.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_gestion_membre_equipe.Image = ((System.Drawing.Image)(resources.GetObject("button_gestion_membre_equipe.Image")));
            this.button_gestion_membre_equipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gestion_membre_equipe.Location = new System.Drawing.Point(0, 320);
            this.button_gestion_membre_equipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_gestion_membre_equipe.Name = "button_gestion_membre_equipe";
            this.button_gestion_membre_equipe.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.button_gestion_membre_equipe.Size = new System.Drawing.Size(200, 57);
            this.button_gestion_membre_equipe.TabIndex = 6;
            this.button_gestion_membre_equipe.Text = "  Gestion Membre Équipe";
            this.button_gestion_membre_equipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gestion_membre_equipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_gestion_membre_equipe.UseVisualStyleBackColor = true;
            this.button_gestion_membre_equipe.Click += new System.EventHandler(this.button_gestion_membre_equipe_Click);
            // 
            // btnParametres
            // 
            this.btnParametres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametres.FlatAppearance.BorderSize = 0;
            this.btnParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnParametres.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnParametres.Image = ((System.Drawing.Image)(resources.GetObject("btnParametres.Image")));
            this.btnParametres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametres.Location = new System.Drawing.Point(0, 260);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnParametres.Size = new System.Drawing.Size(200, 60);
            this.btnParametres.TabIndex = 5;
            this.btnParametres.Text = "   Paramètres";
            this.btnParametres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParametres.UseVisualStyleBackColor = true;
            this.btnParametres.Click += new System.EventHandler(this.btnParametres_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistiques.FlatAppearance.BorderSize = 0;
            this.btnStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStatistiques.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistiques.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistiques.Image")));
            this.btnStatistiques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistiques.Location = new System.Drawing.Point(0, 200);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStatistiques.Size = new System.Drawing.Size(200, 60);
            this.btnStatistiques.TabIndex = 4;
            this.btnStatistiques.Text = "   Statistiques";
            this.btnStatistiques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistiques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistiques.UseVisualStyleBackColor = true;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnProjets
            // 
            this.btnProjets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjets.FlatAppearance.BorderSize = 0;
            this.btnProjets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProjets.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProjets.Image = ((System.Drawing.Image)(resources.GetObject("btnProjets.Image")));
            this.btnProjets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjets.Location = new System.Drawing.Point(0, 140);
            this.btnProjets.Name = "btnProjets";
            this.btnProjets.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProjets.Size = new System.Drawing.Size(200, 60);
            this.btnProjets.TabIndex = 3;
            this.btnProjets.Text = "   Projets en cours";
            this.btnProjets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjets.UseVisualStyleBackColor = true;
            this.btnProjets.Click += new System.EventHandler(this.btnProjets_Click);
            // 
            // btnUtilisateurs
            // 
            this.btnUtilisateurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUtilisateurs.FlatAppearance.BorderSize = 0;
            this.btnUtilisateurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilisateurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUtilisateurs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUtilisateurs.Image = ((System.Drawing.Image)(resources.GetObject("btnUtilisateurs.Image")));
            this.btnUtilisateurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilisateurs.Location = new System.Drawing.Point(0, 80);
            this.btnUtilisateurs.Name = "btnUtilisateurs";
            this.btnUtilisateurs.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUtilisateurs.Size = new System.Drawing.Size(200, 60);
            this.btnUtilisateurs.TabIndex = 2;
            this.btnUtilisateurs.Text = "   Gérer utilisateurs";
            this.btnUtilisateurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilisateurs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUtilisateurs.UseVisualStyleBackColor = true;
            this.btnUtilisateurs.Click += new System.EventHandler(this.btnUtilisateurs_Click);
            // 
            // btnGestEquipe
            // 
            this.btnGestEquipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestEquipe.Location = new System.Drawing.Point(9, 381);
            this.btnGestEquipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestEquipe.Name = "btnGestEquipe";
            this.btnGestEquipe.Size = new System.Drawing.Size(166, 43);
            this.btnGestEquipe.TabIndex = 7;
            this.btnGestEquipe.Text = "Gestion Équipe";
            this.btnGestEquipe.Click += new System.EventHandler(this.btnGestEquipe_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(234)))));
            this.panelLogo.Controls.Add(this.label_azur);
            this.panelLogo.Controls.Add(this.logo_azur);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label_azur
            // 
            this.label_azur.AutoSize = true;
            this.label_azur.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label_azur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(102)))), ((int)(((byte)(1)))));
            this.label_azur.Location = new System.Drawing.Point(86, 21);
            this.label_azur.Name = "label_azur";
            this.label_azur.Size = new System.Drawing.Size(120, 42);
            this.label_azur.TabIndex = 10;
            this.label_azur.Text = "AZUR";
            // 
            // logo_azur
            // 
            this.logo_azur.Image = ((System.Drawing.Image)(resources.GetObject("logo_azur.Image")));
            this.logo_azur.Location = new System.Drawing.Point(10, 10);
            this.logo_azur.Name = "logo_azur";
            this.logo_azur.Size = new System.Drawing.Size(60, 60);
            this.logo_azur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_azur.TabIndex = 9;
            this.logo_azur.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.panelTitle.Controls.Add(this.btnCloseChild);
            this.panelTitle.Controls.Add(this.labelTitre);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(202, 39);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1096, 80);
            this.panelTitle.TabIndex = 9;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // btnCloseChild
            // 
            this.btnCloseChild.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChild.FlatAppearance.BorderSize = 0;
            this.btnCloseChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChild.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChild.Image")));
            this.btnCloseChild.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChild.Name = "btnCloseChild";
            this.btnCloseChild.Size = new System.Drawing.Size(93, 80);
            this.btnCloseChild.TabIndex = 1;
            this.btnCloseChild.UseVisualStyleBackColor = true;
            this.btnCloseChild.Click += new System.EventHandler(this.btnCloseChild_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.White;
            this.labelTitre.Location = new System.Drawing.Point(496, 26);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(145, 36);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "ACCUEIL";
            this.labelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(202, 119);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1096, 559);
            this.panelBody.TabIndex = 10;
            // 
            // gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 680);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestion";
            this.Load += new System.EventHandler(this.gestion_Load);
            this.TopPanel.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_azur)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel TopPanel;
        private CustomWindowsForm.ButtonZ _MinButton;
        private CustomWindowsForm.MinMaxButton _MaxButton;
        private CustomWindowsForm.ButtonZ _CloseButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox logo_azur;
        private System.Windows.Forms.Label label_azur;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnProjets;
        private System.Windows.Forms.Button btnUtilisateurs;
        private System.Windows.Forms.Button btnGestEquipe;
        private System.Windows.Forms.Button btnParametres;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button btnCloseChild;
        private System.Windows.Forms.Button button_gestion_membre_equipe;
    }
}