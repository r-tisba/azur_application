
namespace azur_application.Onglets
{
    partial class ongletStatistiques
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ligne_tl = new System.Windows.Forms.Label();
            this.ligne_l = new System.Windows.Forms.Label();
            this.ligne_r = new System.Windows.Forms.Label();
            this.ligne_b = new System.Windows.Forms.Label();
            this.ligne_tr = new System.Windows.Forms.Label();
            this.lbl_statistiques = new System.Windows.Forms.Label();
            this.lbl_nb_utilisateurs = new System.Windows.Forms.Label();
            this.lbl_nb_admins = new System.Windows.Forms.Label();
            this.lbl_nb_connexions = new System.Windows.Forms.Label();
            this.lbl_nb_messages = new System.Windows.Forms.Label();
            this.lbl_nb_discussions = new System.Windows.Forms.Label();
            this.lbl_nb_evenementT = new System.Windows.Forms.Label();
            this.lbl_moyenne_etapes = new System.Windows.Forms.Label();
            this.br_prg_projets = new CircularProgressBar.CircularProgressBar();
            this.br_prg_etapes = new CircularProgressBar.CircularProgressBar();
            this.br_prg_evenements = new CircularProgressBar.CircularProgressBar();
            this.nb_utilisateurs = new System.Windows.Forms.Label();
            this.nb_admins = new System.Windows.Forms.Label();
            this.nb_connexions = new System.Windows.Forms.Label();
            this.nb_messages = new System.Windows.Forms.Label();
            this.nb_discussions = new System.Windows.Forms.Label();
            this.nb_evenementT = new System.Windows.Forms.Label();
            this.moyenne_etapes = new System.Windows.Forms.Label();
            this.nb_projets_termines = new System.Windows.Forms.Label();
            this.nb_etapes_terminees = new System.Windows.Forms.Label();
            this.nb_evenements_termines = new System.Windows.Forms.Label();
            this.lbl_sur1 = new System.Windows.Forms.Label();
            this.nb_projetsT = new System.Windows.Forms.Label();
            this.nb_etapesT = new System.Windows.Forms.Label();
            this.lbl_sur2 = new System.Windows.Forms.Label();
            this.nb_evenements_semaine = new System.Windows.Forms.Label();
            this.lbl_sur3 = new System.Windows.Forms.Label();
            this.graphBarre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphDonut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graphBarre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphDonut)).BeginInit();
            this.SuspendLayout();
            // 
            // ligne_tl
            // 
            this.ligne_tl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ligne_tl.Location = new System.Drawing.Point(25, 38);
            this.ligne_tl.Name = "ligne_tl";
            this.ligne_tl.Size = new System.Drawing.Size(25, 2);
            this.ligne_tl.TabIndex = 52;
            // 
            // ligne_l
            // 
            this.ligne_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ligne_l.Location = new System.Drawing.Point(25, 38);
            this.ligne_l.Name = "ligne_l";
            this.ligne_l.Size = new System.Drawing.Size(2, 190);
            this.ligne_l.TabIndex = 51;
            // 
            // ligne_r
            // 
            this.ligne_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ligne_r.Location = new System.Drawing.Point(465, 38);
            this.ligne_r.Name = "ligne_r";
            this.ligne_r.Size = new System.Drawing.Size(2, 190);
            this.ligne_r.TabIndex = 50;
            // 
            // ligne_b
            // 
            this.ligne_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ligne_b.Location = new System.Drawing.Point(25, 226);
            this.ligne_b.Name = "ligne_b";
            this.ligne_b.Size = new System.Drawing.Size(440, 2);
            this.ligne_b.TabIndex = 49;
            // 
            // ligne_tr
            // 
            this.ligne_tr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ligne_tr.Location = new System.Drawing.Point(237, 38);
            this.ligne_tr.Name = "ligne_tr";
            this.ligne_tr.Size = new System.Drawing.Size(228, 2);
            this.ligne_tr.TabIndex = 48;
            // 
            // lbl_statistiques
            // 
            this.lbl_statistiques.AutoSize = true;
            this.lbl_statistiques.Font = new System.Drawing.Font("Lato", 13F);
            this.lbl_statistiques.Location = new System.Drawing.Point(56, 24);
            this.lbl_statistiques.Name = "lbl_statistiques";
            this.lbl_statistiques.Size = new System.Drawing.Size(182, 22);
            this.lbl_statistiques.TabIndex = 40;
            this.lbl_statistiques.Text = "Statistiques globales :";
            // 
            // lbl_nb_utilisateurs
            // 
            this.lbl_nb_utilisateurs.AutoSize = true;
            this.lbl_nb_utilisateurs.Font = new System.Drawing.Font("Lato", 11F);
            this.lbl_nb_utilisateurs.Location = new System.Drawing.Point(57, 64);
            this.lbl_nb_utilisateurs.Name = "lbl_nb_utilisateurs";
            this.lbl_nb_utilisateurs.Size = new System.Drawing.Size(190, 18);
            this.lbl_nb_utilisateurs.TabIndex = 53;
            this.lbl_nb_utilisateurs.Text = "Nombre d\'utilisateurs total :";
            // 
            // lbl_nb_admins
            // 
            this.lbl_nb_admins.AutoSize = true;
            this.lbl_nb_admins.Font = new System.Drawing.Font("Lato", 11F);
            this.lbl_nb_admins.Location = new System.Drawing.Point(57, 86);
            this.lbl_nb_admins.Name = "lbl_nb_admins";
            this.lbl_nb_admins.Size = new System.Drawing.Size(130, 18);
            this.lbl_nb_admins.TabIndex = 54;
            this.lbl_nb_admins.Text = "Nombre d\'admins :";
            // 
            // lbl_nb_connexions
            // 
            this.lbl_nb_connexions.AutoSize = true;
            this.lbl_nb_connexions.Font = new System.Drawing.Font("Lato", 11F);
            this.lbl_nb_connexions.Location = new System.Drawing.Point(57, 108);
            this.lbl_nb_connexions.Name = "lbl_nb_connexions";
            this.lbl_nb_connexions.Size = new System.Drawing.Size(289, 18);
            this.lbl_nb_connexions.TabIndex = 55;
            this.lbl_nb_connexions.Text = "Nombre de connexions ces dernières 24h :";
            // 
            // lbl_nb_messages
            // 
            this.lbl_nb_messages.AutoSize = true;
            this.lbl_nb_messages.Font = new System.Drawing.Font("Lato", 11F);
            this.lbl_nb_messages.Location = new System.Drawing.Point(57, 130);
            this.lbl_nb_messages.Name = "lbl_nb_messages";
            this.lbl_nb_messages.Size = new System.Drawing.Size(222, 18);
            this.lbl_nb_messages.TabIndex = 56;
            this.lbl_nb_messages.Text = "Nombre de messages échangés :";
            // 
            // lbl_nb_discussions
            // 
            this.lbl_nb_discussions.AutoSize = true;
            this.lbl_nb_discussions.Font = new System.Drawing.Font("Lato", 11F);
            this.lbl_nb_discussions.Location = new System.Drawing.Point(57, 152);
            this.lbl_nb_discussions.Name = "lbl_nb_discussions";
            this.lbl_nb_discussions.Size = new System.Drawing.Size(219, 18);
            this.lbl_nb_discussions.TabIndex = 57;
            this.lbl_nb_discussions.Text = "Nombre de discussions actives :";
            // 
            // lbl_nb_evenementT
            // 
            this.lbl_nb_evenementT.AutoSize = true;
            this.lbl_nb_evenementT.Font = new System.Drawing.Font("Lato", 11F);
            this.lbl_nb_evenementT.Location = new System.Drawing.Point(57, 174);
            this.lbl_nb_evenementT.Name = "lbl_nb_evenementT";
            this.lbl_nb_evenementT.Size = new System.Drawing.Size(209, 18);
            this.lbl_nb_evenementT.TabIndex = 58;
            this.lbl_nb_evenementT.Text = "Nombre d\'événements totaux :";
            // 
            // lbl_moyenne_etapes
            // 
            this.lbl_moyenne_etapes.AutoSize = true;
            this.lbl_moyenne_etapes.Font = new System.Drawing.Font("Lato", 11F);
            this.lbl_moyenne_etapes.Location = new System.Drawing.Point(57, 196);
            this.lbl_moyenne_etapes.Name = "lbl_moyenne_etapes";
            this.lbl_moyenne_etapes.Size = new System.Drawing.Size(279, 18);
            this.lbl_moyenne_etapes.TabIndex = 59;
            this.lbl_moyenne_etapes.Text = "Nombre d\'étapes par projet en moyenne :";
            // 
            // br_prg_projets
            // 
            this.br_prg_projets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.br_prg_projets.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.br_prg_projets.AnimationSpeed = 600;
            this.br_prg_projets.BackColor = System.Drawing.Color.Transparent;
            this.br_prg_projets.Font = new System.Drawing.Font("Lato", 14F);
            this.br_prg_projets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.br_prg_projets.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.br_prg_projets.InnerMargin = 2;
            this.br_prg_projets.InnerWidth = -1;
            this.br_prg_projets.Location = new System.Drawing.Point(516, 24);
            this.br_prg_projets.MarqueeAnimationSpeed = 2000;
            this.br_prg_projets.Name = "br_prg_projets";
            this.br_prg_projets.OuterColor = System.Drawing.Color.Gray;
            this.br_prg_projets.OuterMargin = -15;
            this.br_prg_projets.OuterWidth = 15;
            this.br_prg_projets.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.br_prg_projets.ProgressWidth = 15;
            this.br_prg_projets.SecondaryFont = new System.Drawing.Font("Lato", 13F);
            this.br_prg_projets.Size = new System.Drawing.Size(190, 190);
            this.br_prg_projets.StartAngle = 270;
            this.br_prg_projets.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.br_prg_projets.SubscriptMargin = new System.Windows.Forms.Padding(-38, 15, 0, 0);
            this.br_prg_projets.SubscriptText = "0";
            this.br_prg_projets.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.br_prg_projets.SuperscriptMargin = new System.Windows.Forms.Padding(-25, 49, 0, 0);
            this.br_prg_projets.SuperscriptText = "%";
            this.br_prg_projets.TabIndex = 60;
            this.br_prg_projets.Text = "Projets";
            this.br_prg_projets.TextMargin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.br_prg_projets.Value = 68;
            // 
            // br_prg_etapes
            // 
            this.br_prg_etapes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.br_prg_etapes.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.br_prg_etapes.AnimationSpeed = 600;
            this.br_prg_etapes.BackColor = System.Drawing.Color.Transparent;
            this.br_prg_etapes.Font = new System.Drawing.Font("Lato", 14F);
            this.br_prg_etapes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.br_prg_etapes.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.br_prg_etapes.InnerMargin = 2;
            this.br_prg_etapes.InnerWidth = -1;
            this.br_prg_etapes.Location = new System.Drawing.Point(746, 24);
            this.br_prg_etapes.MarqueeAnimationSpeed = 2000;
            this.br_prg_etapes.Name = "br_prg_etapes";
            this.br_prg_etapes.OuterColor = System.Drawing.Color.Gray;
            this.br_prg_etapes.OuterMargin = -15;
            this.br_prg_etapes.OuterWidth = 15;
            this.br_prg_etapes.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.br_prg_etapes.ProgressWidth = 15;
            this.br_prg_etapes.SecondaryFont = new System.Drawing.Font("Lato", 13F);
            this.br_prg_etapes.Size = new System.Drawing.Size(190, 190);
            this.br_prg_etapes.StartAngle = 270;
            this.br_prg_etapes.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.br_prg_etapes.SubscriptMargin = new System.Windows.Forms.Padding(-38, 15, 0, 0);
            this.br_prg_etapes.SubscriptText = "34";
            this.br_prg_etapes.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.br_prg_etapes.SuperscriptMargin = new System.Windows.Forms.Padding(-20, 49, 0, 0);
            this.br_prg_etapes.SuperscriptText = "%";
            this.br_prg_etapes.TabIndex = 61;
            this.br_prg_etapes.Text = "Étapes";
            this.br_prg_etapes.TextMargin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.br_prg_etapes.Value = 34;
            // 
            // br_prg_evenements
            // 
            this.br_prg_evenements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.br_prg_evenements.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.br_prg_evenements.AnimationSpeed = 600;
            this.br_prg_evenements.BackColor = System.Drawing.Color.Transparent;
            this.br_prg_evenements.Font = new System.Drawing.Font("Lato", 14F);
            this.br_prg_evenements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.br_prg_evenements.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.br_prg_evenements.InnerMargin = 2;
            this.br_prg_evenements.InnerWidth = -1;
            this.br_prg_evenements.Location = new System.Drawing.Point(976, 24);
            this.br_prg_evenements.MarqueeAnimationSpeed = 2000;
            this.br_prg_evenements.Name = "br_prg_evenements";
            this.br_prg_evenements.OuterColor = System.Drawing.Color.Gray;
            this.br_prg_evenements.OuterMargin = -15;
            this.br_prg_evenements.OuterWidth = 15;
            this.br_prg_evenements.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.br_prg_evenements.ProgressWidth = 15;
            this.br_prg_evenements.SecondaryFont = new System.Drawing.Font("Lato", 13F);
            this.br_prg_evenements.Size = new System.Drawing.Size(190, 190);
            this.br_prg_evenements.StartAngle = 270;
            this.br_prg_evenements.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.br_prg_evenements.SubscriptMargin = new System.Windows.Forms.Padding(-58, 15, 0, 0);
            this.br_prg_evenements.SubscriptText = "79";
            this.br_prg_evenements.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.br_prg_evenements.SuperscriptMargin = new System.Windows.Forms.Padding(-40, 49, 0, 0);
            this.br_prg_evenements.SuperscriptText = "%";
            this.br_prg_evenements.TabIndex = 62;
            this.br_prg_evenements.Text = "Évenements";
            this.br_prg_evenements.TextMargin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.br_prg_evenements.Value = 79;
            // 
            // nb_utilisateurs
            // 
            this.nb_utilisateurs.AutoSize = true;
            this.nb_utilisateurs.Font = new System.Drawing.Font("Lato", 11F);
            this.nb_utilisateurs.Location = new System.Drawing.Point(244, 64);
            this.nb_utilisateurs.Name = "nb_utilisateurs";
            this.nb_utilisateurs.Size = new System.Drawing.Size(0, 18);
            this.nb_utilisateurs.TabIndex = 63;
            // 
            // nb_admins
            // 
            this.nb_admins.AutoSize = true;
            this.nb_admins.Font = new System.Drawing.Font("Lato", 11F);
            this.nb_admins.Location = new System.Drawing.Point(184, 86);
            this.nb_admins.Name = "nb_admins";
            this.nb_admins.Size = new System.Drawing.Size(0, 18);
            this.nb_admins.TabIndex = 64;
            // 
            // nb_connexions
            // 
            this.nb_connexions.AutoSize = true;
            this.nb_connexions.Font = new System.Drawing.Font("Lato", 11F);
            this.nb_connexions.Location = new System.Drawing.Point(343, 108);
            this.nb_connexions.Name = "nb_connexions";
            this.nb_connexions.Size = new System.Drawing.Size(0, 18);
            this.nb_connexions.TabIndex = 65;
            // 
            // nb_messages
            // 
            this.nb_messages.AutoSize = true;
            this.nb_messages.Font = new System.Drawing.Font("Lato", 11F);
            this.nb_messages.Location = new System.Drawing.Point(276, 130);
            this.nb_messages.Name = "nb_messages";
            this.nb_messages.Size = new System.Drawing.Size(0, 18);
            this.nb_messages.TabIndex = 66;
            // 
            // nb_discussions
            // 
            this.nb_discussions.AutoSize = true;
            this.nb_discussions.Font = new System.Drawing.Font("Lato", 11F);
            this.nb_discussions.Location = new System.Drawing.Point(273, 152);
            this.nb_discussions.Name = "nb_discussions";
            this.nb_discussions.Size = new System.Drawing.Size(0, 18);
            this.nb_discussions.TabIndex = 67;
            // 
            // nb_evenementT
            // 
            this.nb_evenementT.AutoSize = true;
            this.nb_evenementT.Font = new System.Drawing.Font("Lato", 11F);
            this.nb_evenementT.Location = new System.Drawing.Point(263, 174);
            this.nb_evenementT.Name = "nb_evenementT";
            this.nb_evenementT.Size = new System.Drawing.Size(0, 18);
            this.nb_evenementT.TabIndex = 68;
            // 
            // moyenne_etapes
            // 
            this.moyenne_etapes.AutoSize = true;
            this.moyenne_etapes.Font = new System.Drawing.Font("Lato", 11F);
            this.moyenne_etapes.Location = new System.Drawing.Point(333, 196);
            this.moyenne_etapes.Name = "moyenne_etapes";
            this.moyenne_etapes.Size = new System.Drawing.Size(0, 18);
            this.moyenne_etapes.TabIndex = 69;
            // 
            // nb_projets_termines
            // 
            this.nb_projets_termines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_projets_termines.AutoSize = true;
            this.nb_projets_termines.Font = new System.Drawing.Font("Lato", 12F);
            this.nb_projets_termines.Location = new System.Drawing.Point(516, 217);
            this.nb_projets_termines.Name = "nb_projets_termines";
            this.nb_projets_termines.Size = new System.Drawing.Size(51, 19);
            this.nb_projets_termines.TabIndex = 70;
            this.nb_projets_termines.Text = "label1";
            // 
            // nb_etapes_terminees
            // 
            this.nb_etapes_terminees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_etapes_terminees.AutoSize = true;
            this.nb_etapes_terminees.Font = new System.Drawing.Font("Lato", 12F);
            this.nb_etapes_terminees.Location = new System.Drawing.Point(739, 217);
            this.nb_etapes_terminees.Name = "nb_etapes_terminees";
            this.nb_etapes_terminees.Size = new System.Drawing.Size(51, 19);
            this.nb_etapes_terminees.TabIndex = 71;
            this.nb_etapes_terminees.Text = "label2";
            // 
            // nb_evenements_termines
            // 
            this.nb_evenements_termines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_evenements_termines.AutoSize = true;
            this.nb_evenements_termines.Font = new System.Drawing.Font("Lato", 12F);
            this.nb_evenements_termines.Location = new System.Drawing.Point(1032, 217);
            this.nb_evenements_termines.Name = "nb_evenements_termines";
            this.nb_evenements_termines.Size = new System.Drawing.Size(51, 19);
            this.nb_evenements_termines.TabIndex = 72;
            this.nb_evenements_termines.Text = "label3";
            // 
            // lbl_sur1
            // 
            this.lbl_sur1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sur1.AutoSize = true;
            this.lbl_sur1.Font = new System.Drawing.Font("Lato", 12F);
            this.lbl_sur1.Location = new System.Drawing.Point(603, 217);
            this.lbl_sur1.Name = "lbl_sur1";
            this.lbl_sur1.Size = new System.Drawing.Size(16, 19);
            this.lbl_sur1.TabIndex = 73;
            this.lbl_sur1.Text = "/";
            // 
            // nb_projetsT
            // 
            this.nb_projetsT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_projetsT.AutoSize = true;
            this.nb_projetsT.Font = new System.Drawing.Font("Lato", 12F);
            this.nb_projetsT.Location = new System.Drawing.Point(615, 217);
            this.nb_projetsT.Name = "nb_projetsT";
            this.nb_projetsT.Size = new System.Drawing.Size(51, 19);
            this.nb_projetsT.TabIndex = 74;
            this.nb_projetsT.Text = "label1";
            // 
            // nb_etapesT
            // 
            this.nb_etapesT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_etapesT.AutoSize = true;
            this.nb_etapesT.Font = new System.Drawing.Font("Lato", 12F);
            this.nb_etapesT.Location = new System.Drawing.Point(845, 217);
            this.nb_etapesT.Name = "nb_etapesT";
            this.nb_etapesT.Size = new System.Drawing.Size(51, 19);
            this.nb_etapesT.TabIndex = 76;
            this.nb_etapesT.Text = "label1";
            // 
            // lbl_sur2
            // 
            this.lbl_sur2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sur2.AutoSize = true;
            this.lbl_sur2.Font = new System.Drawing.Font("Lato", 12F);
            this.lbl_sur2.Location = new System.Drawing.Point(834, 217);
            this.lbl_sur2.Name = "lbl_sur2";
            this.lbl_sur2.Size = new System.Drawing.Size(16, 19);
            this.lbl_sur2.TabIndex = 75;
            this.lbl_sur2.Text = "/";
            // 
            // nb_evenements_semaine
            // 
            this.nb_evenements_semaine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_evenements_semaine.AutoSize = true;
            this.nb_evenements_semaine.Font = new System.Drawing.Font("Lato", 12F);
            this.nb_evenements_semaine.Location = new System.Drawing.Point(972, 261);
            this.nb_evenements_semaine.Name = "nb_evenements_semaine";
            this.nb_evenements_semaine.Size = new System.Drawing.Size(51, 19);
            this.nb_evenements_semaine.TabIndex = 78;
            this.nb_evenements_semaine.Text = "label1";
            // 
            // lbl_sur3
            // 
            this.lbl_sur3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sur3.AutoSize = true;
            this.lbl_sur3.Font = new System.Drawing.Font("Lato", 12F);
            this.lbl_sur3.Location = new System.Drawing.Point(1067, 238);
            this.lbl_sur3.Name = "lbl_sur3";
            this.lbl_sur3.Size = new System.Drawing.Size(16, 19);
            this.lbl_sur3.TabIndex = 77;
            this.lbl_sur3.Text = "/";
            // 
            // graphBarre
            // 
            this.graphBarre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.graphBarre.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graphBarre.Legends.Add(legend1);
            this.graphBarre.Location = new System.Drawing.Point(516, 300);
            this.graphBarre.Name = "graphBarre";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Etape";
            this.graphBarre.Series.Add(series1);
            this.graphBarre.Size = new System.Drawing.Size(668, 267);
            this.graphBarre.TabIndex = 79;
            this.graphBarre.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Étapes validées";
            this.graphBarre.Titles.Add(title1);
            // 
            // graphDonut
            // 
            this.graphDonut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.graphDonut.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graphDonut.Legends.Add(legend2);
            this.graphDonut.Location = new System.Drawing.Point(25, 249);
            this.graphDonut.Name = "graphDonut";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Etape";
            this.graphDonut.Series.Add(series2);
            this.graphDonut.Size = new System.Drawing.Size(442, 318);
            this.graphDonut.TabIndex = 80;
            this.graphDonut.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Projets par équipe";
            this.graphDonut.Titles.Add(title2);
            // 
            // ongletStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 579);
            this.Controls.Add(this.graphDonut);
            this.Controls.Add(this.graphBarre);
            this.Controls.Add(this.nb_evenements_semaine);
            this.Controls.Add(this.lbl_sur3);
            this.Controls.Add(this.nb_etapesT);
            this.Controls.Add(this.lbl_sur2);
            this.Controls.Add(this.nb_projetsT);
            this.Controls.Add(this.lbl_sur1);
            this.Controls.Add(this.nb_evenements_termines);
            this.Controls.Add(this.nb_etapes_terminees);
            this.Controls.Add(this.nb_projets_termines);
            this.Controls.Add(this.moyenne_etapes);
            this.Controls.Add(this.nb_evenementT);
            this.Controls.Add(this.nb_discussions);
            this.Controls.Add(this.nb_messages);
            this.Controls.Add(this.nb_connexions);
            this.Controls.Add(this.nb_admins);
            this.Controls.Add(this.nb_utilisateurs);
            this.Controls.Add(this.br_prg_evenements);
            this.Controls.Add(this.br_prg_etapes);
            this.Controls.Add(this.br_prg_projets);
            this.Controls.Add(this.lbl_moyenne_etapes);
            this.Controls.Add(this.lbl_nb_evenementT);
            this.Controls.Add(this.lbl_nb_discussions);
            this.Controls.Add(this.lbl_nb_messages);
            this.Controls.Add(this.lbl_nb_connexions);
            this.Controls.Add(this.lbl_nb_admins);
            this.Controls.Add(this.lbl_nb_utilisateurs);
            this.Controls.Add(this.ligne_tl);
            this.Controls.Add(this.ligne_l);
            this.Controls.Add(this.ligne_r);
            this.Controls.Add(this.ligne_b);
            this.Controls.Add(this.ligne_tr);
            this.Controls.Add(this.lbl_statistiques);
            this.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ongletStatistiques";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.ongletStatistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphBarre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphDonut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ligne_tl;
        private System.Windows.Forms.Label ligne_l;
        private System.Windows.Forms.Label ligne_r;
        private System.Windows.Forms.Label ligne_b;
        private System.Windows.Forms.Label ligne_tr;
        private System.Windows.Forms.Label lbl_statistiques;
        private System.Windows.Forms.Label lbl_nb_utilisateurs;
        private System.Windows.Forms.Label lbl_nb_admins;
        private System.Windows.Forms.Label lbl_nb_connexions;
        private System.Windows.Forms.Label lbl_nb_messages;
        private System.Windows.Forms.Label lbl_nb_discussions;
        private System.Windows.Forms.Label lbl_nb_evenementT;
        private System.Windows.Forms.Label lbl_moyenne_etapes;
        private CircularProgressBar.CircularProgressBar br_prg_projets;
        private CircularProgressBar.CircularProgressBar br_prg_etapes;
        private CircularProgressBar.CircularProgressBar br_prg_evenements;
        private System.Windows.Forms.Label nb_utilisateurs;
        private System.Windows.Forms.Label nb_admins;
        private System.Windows.Forms.Label nb_connexions;
        private System.Windows.Forms.Label nb_messages;
        private System.Windows.Forms.Label nb_discussions;
        private System.Windows.Forms.Label nb_evenementT;
        private System.Windows.Forms.Label moyenne_etapes;
        private System.Windows.Forms.Label nb_projets_termines;
        private System.Windows.Forms.Label nb_etapes_terminees;
        private System.Windows.Forms.Label nb_evenements_termines;
        private System.Windows.Forms.Label lbl_sur1;
        private System.Windows.Forms.Label nb_projetsT;
        private System.Windows.Forms.Label nb_etapesT;
        private System.Windows.Forms.Label lbl_sur2;
        private System.Windows.Forms.Label nb_evenements_semaine;
        private System.Windows.Forms.Label lbl_sur3;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphBarre;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphDonut;
    }
}