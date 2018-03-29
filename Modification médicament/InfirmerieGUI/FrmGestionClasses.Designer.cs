namespace InfirmerieGUI
{
    partial class FrmGestionClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionClasses));
            this.btnRetour = new System.Windows.Forms.Button();
            this.titreGestionInfirmerie = new System.Windows.Forms.Label();
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            this.listeClasses = new System.Windows.Forms.ComboBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnCreerClasse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(331, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 18;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // titreGestionInfirmerie
            // 
            this.titreGestionInfirmerie.AutoSize = true;
            this.titreGestionInfirmerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titreGestionInfirmerie.Location = new System.Drawing.Point(134, 59);
            this.titreGestionInfirmerie.Name = "titreGestionInfirmerie";
            this.titreGestionInfirmerie.Size = new System.Drawing.Size(152, 20);
            this.titreGestionInfirmerie.TabIndex = 17;
            this.titreGestionInfirmerie.Text = "Gestion des classes";
            this.titreGestionInfirmerie.Click += new System.EventHandler(this.titreGestionInfirmerie_Click);
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(187, 12);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 16;
            this.logoStVincent.TabStop = false;
            // 
            // listeClasses
            // 
            this.listeClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeClasses.FormattingEnabled = true;
            this.listeClasses.Location = new System.Drawing.Point(87, 120);
            this.listeClasses.Name = "listeClasses";
            this.listeClasses.Size = new System.Drawing.Size(121, 21);
            this.listeClasses.TabIndex = 22;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClasse.Location = new System.Drawing.Point(37, 123);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(44, 13);
            this.lblClasse.TabIndex = 21;
            this.lblClasse.Text = "Classe :";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(87, 163);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 37);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnCreerClasse
            // 
            this.btnCreerClasse.Location = new System.Drawing.Point(274, 144);
            this.btnCreerClasse.Name = "btnCreerClasse";
            this.btnCreerClasse.Size = new System.Drawing.Size(119, 38);
            this.btnCreerClasse.TabIndex = 24;
            this.btnCreerClasse.Text = "Créer une classe";
            this.btnCreerClasse.UseVisualStyleBackColor = true;
            this.btnCreerClasse.Click += new System.EventHandler(this.btnCreerClasse_Click);
            // 
            // FrmGestionClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 240);
            this.Controls.Add(this.btnCreerClasse);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.listeClasses);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.titreGestionInfirmerie);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmGestionClasses";
            this.Text = "FrmGestionClasses";
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label titreGestionInfirmerie;
        private System.Windows.Forms.PictureBox logoStVincent;
        private System.Windows.Forms.ComboBox listeClasses;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnCreerClasse;
    }
}