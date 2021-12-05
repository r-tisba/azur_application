
namespace azur_application
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_azur = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Panel();
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this._MaxButton = new CustomWindowsForm.MinMaxButton();
            this._MinButton = new CustomWindowsForm.ButtonZ();
            this._CloseButton = new CustomWindowsForm.ButtonZ();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.inputIdentifiant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.boutonConnexion = new MaterialSkin.Controls.MaterialFlatButton();
            this.inputMdp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkBoxEnregistrer = new MaterialSkin.Controls.MaterialCheckBox();
            this.labelMdp = new MaterialSkin.Controls.MaterialLabel();
            this.labelIdentifiant = new MaterialSkin.Controls.MaterialLabel();
            this.message_erreur = new MaterialSkin.Controls.MaterialLabel();
            this.body = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(234)))));
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.label_azur);
            this.header.Location = new System.Drawing.Point(1, 34);
            this.header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(358, 99);
            this.header.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connexion vers l\'application";
            // 
            // label_azur
            // 
            this.label_azur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_azur.AutoSize = true;
            this.label_azur.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_azur.Font = new System.Drawing.Font("Lato Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_azur.Location = new System.Drawing.Point(143, 18);
            this.label_azur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_azur.Name = "label_azur";
            this.label_azur.Size = new System.Drawing.Size(75, 29);
            this.label_azur.TabIndex = 0;
            this.label_azur.Text = "AZUR";
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.head.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.head.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(460, 2);
            this.head.TabIndex = 3;
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(360, 2);
            this.TopBorderPanel.TabIndex = 2;
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
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(2, 502);
            this.LeftPanel.TabIndex = 4;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            this.LeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(358, 2);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(2, 502);
            this.RightPanel.TabIndex = 5;
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.BottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(2, 502);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(356, 2);
            this.BottomPanel.TabIndex = 6;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this._MaxButton);
            this.TopPanel.Controls.Add(this._MinButton);
            this.TopPanel.Controls.Add(this._CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(2, 2);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(356, 32);
            this.TopPanel.TabIndex = 7;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // _MaxButton
            // 
            this._MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this._MaxButton.CFormState = CustomWindowsForm.MinMaxButton.CustomFormState.Normal;
            this._MaxButton.DisplayText = "_";
            this._MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._MaxButton.ForeColor = System.Drawing.Color.White;
            this._MaxButton.Location = new System.Drawing.Point(300, 0);
            this._MaxButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._MaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this._MaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this._MaxButton.Name = "_MaxButton";
            this._MaxButton.Size = new System.Drawing.Size(28, 32);
            this._MaxButton.TabIndex = 2;
            this._MaxButton.Text = "minMaxButton";
            this._MaxButton.TextLocation_X = 7;
            this._MaxButton.TextLocation_Y = 10;
            this.toolTip1.SetToolTip(this._MaxButton, "Maximise");
            this._MaxButton.UseVisualStyleBackColor = true;
            this._MaxButton.Click += new System.EventHandler(this._MaxButton_Click);
            // 
            // _MinButton
            // 
            this._MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this._MinButton.DisplayText = "_";
            this._MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._MinButton.ForeColor = System.Drawing.Color.White;
            this._MinButton.Location = new System.Drawing.Point(272, 0);
            this._MinButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._MinButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this._MinButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this._MinButton.Name = "_MinButton";
            this._MinButton.Size = new System.Drawing.Size(28, 32);
            this._MinButton.TabIndex = 1;
            this._MinButton.Text = "_";
            this._MinButton.TextLocation_X = 5;
            this._MinButton.TextLocation_Y = -14;
            this.toolTip1.SetToolTip(this._MinButton, "Minimize");
            this._MinButton.UseVisualStyleBackColor = true;
            this._MinButton.Click += new System.EventHandler(this._MinButton_Click);
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(328, 0);
            this._CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(28, 32);
            this._CloseButton.TabIndex = 0;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 7;
            this._CloseButton.TextLocation_Y = 6;
            this.toolTip1.SetToolTip(this._CloseButton, "Close");
            this._CloseButton.UseVisualStyleBackColor = false;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // inputIdentifiant
            // 
            this.inputIdentifiant.Depth = 0;
            this.inputIdentifiant.Hint = " Identifiant";
            this.inputIdentifiant.Location = new System.Drawing.Point(62, 94);
            this.inputIdentifiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputIdentifiant.MaxLength = 32767;
            this.inputIdentifiant.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputIdentifiant.Name = "inputIdentifiant";
            this.inputIdentifiant.PasswordChar = '\0';
            this.inputIdentifiant.SelectedText = "";
            this.inputIdentifiant.SelectionLength = 0;
            this.inputIdentifiant.SelectionStart = 0;
            this.inputIdentifiant.Size = new System.Drawing.Size(238, 23);
            this.inputIdentifiant.TabIndex = 8;
            this.inputIdentifiant.TabStop = false;
            this.inputIdentifiant.UseSystemPasswordChar = false;
            // 
            // boutonConnexion
            // 
            this.boutonConnexion.AutoSize = true;
            this.boutonConnexion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boutonConnexion.Depth = 0;
            this.boutonConnexion.Icon = null;
            this.boutonConnexion.Location = new System.Drawing.Point(108, 290);
            this.boutonConnexion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boutonConnexion.MouseState = MaterialSkin.MouseState.HOVER;
            this.boutonConnexion.Name = "boutonConnexion";
            this.boutonConnexion.Primary = false;
            this.boutonConnexion.Size = new System.Drawing.Size(120, 36);
            this.boutonConnexion.TabIndex = 9;
            this.boutonConnexion.Text = "Se connecter";
            this.boutonConnexion.UseVisualStyleBackColor = true;
            this.boutonConnexion.Click += new System.EventHandler(this.boutonConnexion_Click);
            // 
            // inputMdp
            // 
            this.inputMdp.Depth = 0;
            this.inputMdp.Hint = " Mot de passe";
            this.inputMdp.Location = new System.Drawing.Point(62, 183);
            this.inputMdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputMdp.MaxLength = 32767;
            this.inputMdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputMdp.Name = "inputMdp";
            this.inputMdp.PasswordChar = '\0';
            this.inputMdp.SelectedText = "";
            this.inputMdp.SelectionLength = 0;
            this.inputMdp.SelectionStart = 0;
            this.inputMdp.Size = new System.Drawing.Size(238, 23);
            this.inputMdp.TabIndex = 11;
            this.inputMdp.TabStop = false;
            this.inputMdp.UseSystemPasswordChar = false;
            // 
            // checkBoxEnregistrer
            // 
            this.checkBoxEnregistrer.AutoSize = true;
            this.checkBoxEnregistrer.Depth = 0;
            this.checkBoxEnregistrer.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBoxEnregistrer.Location = new System.Drawing.Point(63, 229);
            this.checkBoxEnregistrer.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxEnregistrer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxEnregistrer.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxEnregistrer.Name = "checkBoxEnregistrer";
            this.checkBoxEnregistrer.Ripple = true;
            this.checkBoxEnregistrer.Size = new System.Drawing.Size(147, 30);
            this.checkBoxEnregistrer.TabIndex = 12;
            this.checkBoxEnregistrer.Text = "Se souvenir de moi";
            this.checkBoxEnregistrer.UseVisualStyleBackColor = true;
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Depth = 0;
            this.labelMdp.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMdp.Location = new System.Drawing.Point(58, 147);
            this.labelMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(108, 19);
            this.labelMdp.TabIndex = 13;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Depth = 0;
            this.labelIdentifiant.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelIdentifiant.Location = new System.Drawing.Point(58, 60);
            this.labelIdentifiant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdentifiant.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(84, 19);
            this.labelIdentifiant.TabIndex = 14;
            this.labelIdentifiant.Text = "Identifiant :";
            // 
            // message_erreur
            // 
            this.message_erreur.AutoSize = true;
            this.message_erreur.Depth = 0;
            this.message_erreur.Font = new System.Drawing.Font("Roboto", 11F);
            this.message_erreur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.message_erreur.Location = new System.Drawing.Point(59, 17);
            this.message_erreur.MouseState = MaterialSkin.MouseState.HOVER;
            this.message_erreur.Name = "message_erreur";
            this.message_erreur.Size = new System.Drawing.Size(0, 19);
            this.message_erreur.TabIndex = 15;
            // 
            // body
            // 
            this.body.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.body.Controls.Add(this.message_erreur);
            this.body.Controls.Add(this.labelIdentifiant);
            this.body.Controls.Add(this.labelMdp);
            this.body.Controls.Add(this.checkBoxEnregistrer);
            this.body.Controls.Add(this.inputMdp);
            this.body.Controls.Add(this.boutonConnexion);
            this.body.Controls.Add(this.inputIdentifiant);
            this.body.Location = new System.Drawing.Point(2, 131);
            this.body.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(356, 371);
            this.body.TabIndex = 13;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 504);
            this.ControlBox = false;
            this.Controls.Add(this.body);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_azur;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private CustomWindowsForm.MinMaxButton _MaxButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private CustomWindowsForm.ButtonZ _MinButton;
        private CustomWindowsForm.ButtonZ _CloseButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputIdentifiant;
        private MaterialSkin.Controls.MaterialFlatButton boutonConnexion;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputMdp;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxEnregistrer;
        private MaterialSkin.Controls.MaterialLabel labelMdp;
        private MaterialSkin.Controls.MaterialLabel labelIdentifiant;
        private MaterialSkin.Controls.MaterialLabel message_erreur;
        private System.Windows.Forms.Panel body;
    }
}

