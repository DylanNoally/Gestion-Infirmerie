namespace InfirmerieGUI
{
    partial class FrmGestionMedicaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionMedicaments));
            this.titreGestionInfirmerie = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnCreerEleve = new System.Windows.Forms.Button();
            this.lblClasse = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            this.listeMedicaments = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // titreGestionInfirmerie
            // 
            this.titreGestionInfirmerie.AutoSize = true;
            this.titreGestionInfirmerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titreGestionInfirmerie.Location = new System.Drawing.Point(111, 59);
            this.titreGestionInfirmerie.Name = "titreGestionInfirmerie";
            this.titreGestionInfirmerie.Size = new System.Drawing.Size(194, 20);
            this.titreGestionInfirmerie.TabIndex = 10;
            this.titreGestionInfirmerie.Text = "Gestion des médicaments";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(327, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 15;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnCreerEleve
            // 
            this.btnCreerEleve.Location = new System.Drawing.Point(264, 116);
            this.btnCreerEleve.Name = "btnCreerEleve";
            this.btnCreerEleve.Size = new System.Drawing.Size(138, 50);
            this.btnCreerEleve.TabIndex = 17;
            this.btnCreerEleve.Text = "Créer un médicament";
            this.btnCreerEleve.UseVisualStyleBackColor = true;
            this.btnCreerEleve.Click += new System.EventHandler(this.btnCreerEleve_Click);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClasse.Location = new System.Drawing.Point(29, 107);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(71, 13);
            this.lblClasse.TabIndex = 19;
            this.lblClasse.Text = "Médicament :";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(73, 152);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 37);
            this.btnModifier.TabIndex = 21;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(183, 12);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 9;
            this.logoStVincent.TabStop = false;
            // 
            // listeMedicaments
            // 
            this.listeMedicaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeMedicaments.FormattingEnabled = true;
            this.listeMedicaments.Location = new System.Drawing.Point(106, 104);
            this.listeMedicaments.Name = "listeMedicaments";
            this.listeMedicaments.Size = new System.Drawing.Size(133, 21);
            this.listeMedicaments.TabIndex = 22;
            this.listeMedicaments.SelectedIndexChanged += new System.EventHandler(this.listeMedicaments_SelectedIndexChanged_1);
            // 
            // FrmGestionMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 219);
            this.Controls.Add(this.listeMedicaments);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.btnCreerEleve);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.titreGestionInfirmerie);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmGestionMedicaments";
            this.Text = "FrmGestionMedicaments";
            this.Load += new System.EventHandler(this.FrmGestionMedicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreGestionInfirmerie;
        private System.Windows.Forms.PictureBox logoStVincent;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnCreerEleve;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox listeMedicaments;
    }
}