namespace InfirmerieGUI
{
    partial class FrmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.titreGestionInfirmerie = new System.Windows.Forms.Label();
            this.titreAccueil = new System.Windows.Forms.Label();
            this.btnGestionEleves = new System.Windows.Forms.Button();
            this.btnGestionVisites = new System.Windows.Forms.Button();
            this.btnGestionClasses = new System.Windows.Forms.Button();
            this.btnGestionMedicaments = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnSauvegarde = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.sousTitre = new System.Windows.Forms.Label();
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // titreGestionInfirmerie
            // 
            this.titreGestionInfirmerie.AutoSize = true;
            this.titreGestionInfirmerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreGestionInfirmerie.Location = new System.Drawing.Point(153, 81);
            this.titreGestionInfirmerie.Name = "titreGestionInfirmerie";
            this.titreGestionInfirmerie.Size = new System.Drawing.Size(163, 18);
            this.titreGestionInfirmerie.TabIndex = 5;
            this.titreGestionInfirmerie.Text = "Gestion d\'une infirmerie";
            // 
            // titreAccueil
            // 
            this.titreAccueil.AutoSize = true;
            this.titreAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreAccueil.Location = new System.Drawing.Point(145, 59);
            this.titreAccueil.Name = "titreAccueil";
            this.titreAccueil.Size = new System.Drawing.Size(196, 20);
            this.titreAccueil.TabIndex = 4;
            this.titreAccueil.Text = "Bienvenue sur l\'application";
            this.titreAccueil.Click += new System.EventHandler(this.titreGestionInfirmerie_Click);
            // 
            // btnGestionEleves
            // 
            this.btnGestionEleves.Location = new System.Drawing.Point(68, 159);
            this.btnGestionEleves.Name = "btnGestionEleves";
            this.btnGestionEleves.Size = new System.Drawing.Size(99, 34);
            this.btnGestionEleves.TabIndex = 6;
            this.btnGestionEleves.Text = "Elèves";
            this.btnGestionEleves.UseVisualStyleBackColor = true;
            this.btnGestionEleves.Click += new System.EventHandler(this.btnGestionEleves_Click);
            // 
            // btnGestionVisites
            // 
            this.btnGestionVisites.BackColor = System.Drawing.SystemColors.Control;
            this.btnGestionVisites.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGestionVisites.Location = new System.Drawing.Point(182, 159);
            this.btnGestionVisites.Name = "btnGestionVisites";
            this.btnGestionVisites.Size = new System.Drawing.Size(99, 34);
            this.btnGestionVisites.TabIndex = 7;
            this.btnGestionVisites.Text = "Visites";
            this.btnGestionVisites.UseVisualStyleBackColor = true;
            this.btnGestionVisites.Click += new System.EventHandler(this.btnGestionVisites_Click);
            // 
            // btnGestionClasses
            // 
            this.btnGestionClasses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGestionClasses.Location = new System.Drawing.Point(297, 159);
            this.btnGestionClasses.Name = "btnGestionClasses";
            this.btnGestionClasses.Size = new System.Drawing.Size(99, 34);
            this.btnGestionClasses.TabIndex = 8;
            this.btnGestionClasses.Text = "Classes";
            this.btnGestionClasses.UseVisualStyleBackColor = false;
            this.btnGestionClasses.Click += new System.EventHandler(this.btnGestionClasses_Click);
            // 
            // btnGestionMedicaments
            // 
            this.btnGestionMedicaments.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionMedicaments.Location = new System.Drawing.Point(122, 215);
            this.btnGestionMedicaments.Name = "btnGestionMedicaments";
            this.btnGestionMedicaments.Size = new System.Drawing.Size(99, 34);
            this.btnGestionMedicaments.TabIndex = 9;
            this.btnGestionMedicaments.Text = "Médicaments";
            this.btnGestionMedicaments.UseVisualStyleBackColor = false;
            this.btnGestionMedicaments.Click += new System.EventHandler(this.btnGestionMedicaments_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMaintenance.Location = new System.Drawing.Point(242, 215);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(99, 34);
            this.btnMaintenance.TabIndex = 10;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnSauvegarde
            // 
            this.btnSauvegarde.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSauvegarde.Location = new System.Drawing.Point(12, 287);
            this.btnSauvegarde.Name = "btnSauvegarde";
            this.btnSauvegarde.Size = new System.Drawing.Size(91, 41);
            this.btnSauvegarde.TabIndex = 11;
            this.btnSauvegarde.Text = "Sauvegarde";
            this.btnSauvegarde.UseVisualStyleBackColor = false;
            this.btnSauvegarde.Click += new System.EventHandler(this.btnSauvegarde_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStats.Location = new System.Drawing.Point(121, 287);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(91, 41);
            this.btnStats.TabIndex = 12;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(369, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // sousTitre
            // 
            this.sousTitre.AutoSize = true;
            this.sousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sousTitre.Location = new System.Drawing.Point(65, 138);
            this.sousTitre.Name = "sousTitre";
            this.sousTitre.Size = new System.Drawing.Size(68, 18);
            this.sousTitre.TabIndex = 14;
            this.sousTitre.Text = "Gestion :";
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(210, 12);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 3;
            this.logoStVincent.TabStop = false;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 338);
            this.Controls.Add(this.sousTitre);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnSauvegarde);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnGestionMedicaments);
            this.Controls.Add(this.btnGestionClasses);
            this.Controls.Add(this.btnGestionVisites);
            this.Controls.Add(this.btnGestionEleves);
            this.Controls.Add(this.titreGestionInfirmerie);
            this.Controls.Add(this.titreAccueil);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreGestionInfirmerie;
        private System.Windows.Forms.Label titreAccueil;
        private System.Windows.Forms.PictureBox logoStVincent;
        private System.Windows.Forms.Button btnGestionEleves;
        private System.Windows.Forms.Button btnGestionVisites;
        private System.Windows.Forms.Button btnGestionClasses;
        private System.Windows.Forms.Button btnGestionMedicaments;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnSauvegarde;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label sousTitre;
    }
}