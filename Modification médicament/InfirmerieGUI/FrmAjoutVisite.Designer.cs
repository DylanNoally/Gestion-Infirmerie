namespace InfirmerieGUI
{
    partial class FrmAjoutVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutVisite));
            this.titreGestionInfirmerie = new System.Windows.Forms.Label();
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHeureArrive = new System.Windows.Forms.Label();
            this.lblHeureDepart = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.lblPouls = new System.Windows.Forms.Label();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ckcParent = new System.Windows.Forms.CheckBox();
            this.lblParents = new System.Windows.Forms.Label();
            this.radioRetour = new System.Windows.Forms.RadioButton();
            this.radioHopital = new System.Windows.Forms.RadioButton();
            this.radioLycee = new System.Windows.Forms.RadioButton();
            this.txtNomEleve = new System.Windows.Forms.TextBox();
            this.txtPrenomEleve = new System.Windows.Forms.TextBox();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtHeureArriv = new System.Windows.Forms.TextBox();
            this.txtHeureDepart = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtPouls = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtCommentaire = new System.Windows.Forms.RichTextBox();
            this.txtPrescription = new System.Windows.Forms.RichTextBox();
            this.txtIdEleve = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // titreGestionInfirmerie
            // 
            this.titreGestionInfirmerie.AutoSize = true;
            this.titreGestionInfirmerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreGestionInfirmerie.Location = new System.Drawing.Point(203, 59);
            this.titreGestionInfirmerie.Name = "titreGestionInfirmerie";
            this.titreGestionInfirmerie.Size = new System.Drawing.Size(120, 18);
            this.titreGestionInfirmerie.TabIndex = 48;
            this.titreGestionInfirmerie.Text = "Listes de visites :";
            this.titreGestionInfirmerie.Click += new System.EventHandler(this.titreGestionInfirmerie_Click);
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(239, 12);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 47;
            this.logoStVincent.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNom.Location = new System.Drawing.Point(37, 105);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(83, 13);
            this.lblNom.TabIndex = 49;
            this.lblNom.Text = "Nom de l\'élève :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrenom.Location = new System.Drawing.Point(37, 131);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(97, 13);
            this.lblPrenom.TabIndex = 50;
            this.lblPrenom.Text = "Prénom de l\'élève :";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClasse.Location = new System.Drawing.Point(37, 159);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(92, 13);
            this.lblClasse.TabIndex = 51;
            this.lblClasse.Text = "Classe de l\'élève :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAge.Location = new System.Drawing.Point(37, 185);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 13);
            this.lblAge.TabIndex = 52;
            this.lblAge.Text = "Âge :";
            // 
            // lblHeureArrive
            // 
            this.lblHeureArrive.AutoSize = true;
            this.lblHeureArrive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeureArrive.Location = new System.Drawing.Point(37, 236);
            this.lblHeureArrive.Name = "lblHeureArrive";
            this.lblHeureArrive.Size = new System.Drawing.Size(85, 13);
            this.lblHeureArrive.TabIndex = 53;
            this.lblHeureArrive.Text = "Heure d\'arrivée :";
            // 
            // lblHeureDepart
            // 
            this.lblHeureDepart.AutoSize = true;
            this.lblHeureDepart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeureDepart.Location = new System.Drawing.Point(37, 268);
            this.lblHeureDepart.Name = "lblHeureDepart";
            this.lblHeureDepart.Size = new System.Drawing.Size(90, 13);
            this.lblHeureDepart.TabIndex = 54;
            this.lblHeureDepart.Text = "Heure de départ :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMotif.Location = new System.Drawing.Point(37, 298);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(89, 13);
            this.lblMotif.TabIndex = 55;
            this.lblMotif.Text = "Motif de la visite :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(37, 210);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 56;
            this.lblDate.Text = "Date :";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCommentaire.Location = new System.Drawing.Point(298, 105);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(74, 13);
            this.lblCommentaire.TabIndex = 57;
            this.lblCommentaire.Text = "Commentaire :";
            // 
            // lblPouls
            // 
            this.lblPouls.AutoSize = true;
            this.lblPouls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPouls.Location = new System.Drawing.Point(298, 159);
            this.lblPouls.Name = "lblPouls";
            this.lblPouls.Size = new System.Drawing.Size(39, 13);
            this.lblPouls.TabIndex = 58;
            this.lblPouls.Text = "Pouls :";
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrescription.Location = new System.Drawing.Point(298, 185);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(68, 13);
            this.lblPrescription.TabIndex = 59;
            this.lblPrescription.Text = "Prescription :";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQte.Location = new System.Drawing.Point(298, 248);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(53, 13);
            this.lblQte.TabIndex = 60;
            this.lblQte.Text = "Quantité :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(380, 278);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 61;
            this.lblStatus.Text = "Status :";
            // 
            // ckcParent
            // 
            this.ckcParent.AutoSize = true;
            this.ckcParent.Location = new System.Drawing.Point(400, 345);
            this.ckcParent.Name = "ckcParent";
            this.ckcParent.Size = new System.Drawing.Size(15, 14);
            this.ckcParent.TabIndex = 62;
            this.ckcParent.UseVisualStyleBackColor = true;
            // 
            // lblParents
            // 
            this.lblParents.AutoSize = true;
            this.lblParents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParents.Location = new System.Drawing.Point(298, 345);
            this.lblParents.Name = "lblParents";
            this.lblParents.Size = new System.Drawing.Size(96, 13);
            this.lblParents.TabIndex = 63;
            this.lblParents.Text = "Parents prévenus :";
            // 
            // radioRetour
            // 
            this.radioRetour.AutoSize = true;
            this.radioRetour.Location = new System.Drawing.Point(301, 298);
            this.radioRetour.Name = "radioRetour";
            this.radioRetour.Size = new System.Drawing.Size(98, 17);
            this.radioRetour.TabIndex = 64;
            this.radioRetour.TabStop = true;
            this.radioRetour.Text = "Retour domicile";
            this.radioRetour.UseVisualStyleBackColor = true;
            // 
            // radioHopital
            // 
            this.radioHopital.AutoSize = true;
            this.radioHopital.Location = new System.Drawing.Point(405, 298);
            this.radioHopital.Name = "radioHopital";
            this.radioHopital.Size = new System.Drawing.Size(58, 17);
            this.radioHopital.TabIndex = 65;
            this.radioHopital.TabStop = true;
            this.radioHopital.Text = "Hôpital";
            this.radioHopital.UseVisualStyleBackColor = true;
            // 
            // radioLycee
            // 
            this.radioLycee.AutoSize = true;
            this.radioLycee.Location = new System.Drawing.Point(469, 298);
            this.radioLycee.Name = "radioLycee";
            this.radioLycee.Size = new System.Drawing.Size(102, 17);
            this.radioLycee.TabIndex = 66;
            this.radioLycee.TabStop = true;
            this.radioLycee.Text = "Rest(é) au lycée";
            this.radioLycee.UseVisualStyleBackColor = true;
            // 
            // txtNomEleve
            // 
            this.txtNomEleve.Location = new System.Drawing.Point(152, 102);
            this.txtNomEleve.Name = "txtNomEleve";
            this.txtNomEleve.ReadOnly = true;
            this.txtNomEleve.Size = new System.Drawing.Size(129, 20);
            this.txtNomEleve.TabIndex = 67;
            this.txtNomEleve.TextChanged += new System.EventHandler(this.txtNomEleve_TextChanged);
            // 
            // txtPrenomEleve
            // 
            this.txtPrenomEleve.Location = new System.Drawing.Point(152, 128);
            this.txtPrenomEleve.Name = "txtPrenomEleve";
            this.txtPrenomEleve.ReadOnly = true;
            this.txtPrenomEleve.Size = new System.Drawing.Size(129, 20);
            this.txtPrenomEleve.TabIndex = 68;
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(152, 154);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(128, 20);
            this.txtClasse.TabIndex = 69;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(152, 182);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(42, 20);
            this.txtAge.TabIndex = 70;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(152, 207);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(129, 20);
            this.txtDate.TabIndex = 71;
            // 
            // txtHeureArriv
            // 
            this.txtHeureArriv.Location = new System.Drawing.Point(152, 233);
            this.txtHeureArriv.Name = "txtHeureArriv";
            this.txtHeureArriv.Size = new System.Drawing.Size(129, 20);
            this.txtHeureArriv.TabIndex = 72;
            // 
            // txtHeureDepart
            // 
            this.txtHeureDepart.Location = new System.Drawing.Point(152, 265);
            this.txtHeureDepart.Name = "txtHeureDepart";
            this.txtHeureDepart.Size = new System.Drawing.Size(129, 20);
            this.txtHeureDepart.TabIndex = 73;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(151, 295);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(129, 20);
            this.txtMotif.TabIndex = 74;
            // 
            // txtPouls
            // 
            this.txtPouls.Location = new System.Drawing.Point(374, 159);
            this.txtPouls.Name = "txtPouls";
            this.txtPouls.Size = new System.Drawing.Size(164, 20);
            this.txtPouls.TabIndex = 75;
            this.txtPouls.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(374, 245);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(164, 20);
            this.txtQuantite.TabIndex = 76;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(488, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 77;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(248, 380);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 78;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(374, 102);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(164, 51);
            this.txtCommentaire.TabIndex = 79;
            this.txtCommentaire.Text = "";
            // 
            // txtPrescription
            // 
            this.txtPrescription.Location = new System.Drawing.Point(374, 190);
            this.txtPrescription.Name = "txtPrescription";
            this.txtPrescription.Size = new System.Drawing.Size(164, 49);
            this.txtPrescription.TabIndex = 80;
            this.txtPrescription.Text = "";
            // 
            // txtIdEleve
            // 
            this.txtIdEleve.Location = new System.Drawing.Point(40, 57);
            this.txtIdEleve.Name = "txtIdEleve";
            this.txtIdEleve.ReadOnly = true;
            this.txtIdEleve.Size = new System.Drawing.Size(63, 20);
            this.txtIdEleve.TabIndex = 81;
            // 
            // FrmAjoutVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 422);
            this.Controls.Add(this.txtIdEleve);
            this.Controls.Add(this.txtPrescription);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtPouls);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.txtHeureDepart);
            this.Controls.Add(this.txtHeureArriv);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.txtPrenomEleve);
            this.Controls.Add(this.txtNomEleve);
            this.Controls.Add(this.radioLycee);
            this.Controls.Add(this.radioHopital);
            this.Controls.Add(this.radioRetour);
            this.Controls.Add(this.lblParents);
            this.Controls.Add(this.ckcParent);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.lblPouls);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblHeureDepart);
            this.Controls.Add(this.lblHeureArrive);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.titreGestionInfirmerie);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmAjoutVisite";
            this.Text = "FrmAjoutVisite";
            this.Load += new System.EventHandler(this.FrmAjoutVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreGestionInfirmerie;
        private System.Windows.Forms.PictureBox logoStVincent;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeureArrive;
        private System.Windows.Forms.Label lblHeureDepart;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.Label lblPouls;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox ckcParent;
        private System.Windows.Forms.Label lblParents;
        private System.Windows.Forms.RadioButton radioRetour;
        private System.Windows.Forms.RadioButton radioHopital;
        private System.Windows.Forms.RadioButton radioLycee;
        private System.Windows.Forms.TextBox txtNomEleve;
        private System.Windows.Forms.TextBox txtPrenomEleve;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtHeureArriv;
        private System.Windows.Forms.TextBox txtHeureDepart;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtPouls;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.RichTextBox txtCommentaire;
        private System.Windows.Forms.RichTextBox txtPrescription;
        private System.Windows.Forms.TextBox txtIdEleve;
    }
}