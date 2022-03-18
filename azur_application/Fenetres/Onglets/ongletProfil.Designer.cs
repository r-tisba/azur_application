namespace azur_application.Onglets
{
    partial class ongletProfil
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
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.label_identifiant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_avatar.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(240, 240);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_avatar.TabIndex = 21;
            this.pictureBox_avatar.TabStop = false;
            // 
            // label_identifiant
            // 
            this.label_identifiant.AutoSize = true;
            this.label_identifiant.Location = new System.Drawing.Point(95, 267);
            this.label_identifiant.Name = "label_identifiant";
            this.label_identifiant.Size = new System.Drawing.Size(0, 16);
            this.label_identifiant.TabIndex = 22;
            // 
            // ongletProfil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1200, 540);
            this.Controls.Add(this.label_identifiant);
            this.Controls.Add(this.pictureBox_avatar);
            this.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ongletProfil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.ongletProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_avatar;
        private System.Windows.Forms.Label label_identifiant;
    }
}