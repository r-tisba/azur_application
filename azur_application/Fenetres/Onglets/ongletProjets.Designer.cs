
namespace azur_application.Onglets
{
    partial class ongletProjets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_tableProjets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(848, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_tableProjets
            // 
            this.label_tableProjets.AutoSize = true;
            this.label_tableProjets.Font = new System.Drawing.Font("Lato", 14F);
            this.label_tableProjets.Location = new System.Drawing.Point(966, 20);
            this.label_tableProjets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tableProjets.Name = "label_tableProjets";
            this.label_tableProjets.Size = new System.Drawing.Size(124, 23);
            this.label_tableProjets.TabIndex = 3;
            this.label_tableProjets.Text = "Liste Projets :";
            // 
            // ongletProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 540);
            this.Controls.Add(this.label_tableProjets);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ongletProjets";
            this.Text = "Projets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_tableProjets;
    }
}