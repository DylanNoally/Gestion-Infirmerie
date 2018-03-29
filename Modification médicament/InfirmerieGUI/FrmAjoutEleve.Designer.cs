namespace InfirmerieGUI
{
    partial class FrmAjoutEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutEleve));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.textNomEleve = new System.Windows.Forms.TextBox();
            this.labelNomEleve = new System.Windows.Forms.Label();
            this.textPrenomEleve = new System.Windows.Forms.TextBox();
            this.textNaissanceEleve = new System.Windows.Forms.TextBox();
            this.textTelParent = new System.Windows.Forms.TextBox();
            this.textTelEleve = new System.Windows.Forms.TextBox();
            this.richTextCom = new System.Windows.Forms.RichTextBox();
            this.labelClasseEleve = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.labelPrenomEleve = new System.Windows.Forms.Label();
            this.labelNaissanceEleve = new System.Windows.Forms.Label();
            this.labelTelParent = new System.Windows.Forms.Label();
            this.labelTelEleve = new System.Windows.Forms.Label();
            this.checkTT = new System.Windows.Forms.CheckBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.listClasseEleve = new System.Windows.Forms.ListBox();
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(221, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un élève :";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(193, 348);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(186, 42);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer l\'élève";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // textNomEleve
            // 
            this.textNomEleve.Location = new System.Drawing.Point(120, 109);
            this.textNomEleve.Name = "textNomEleve";
            this.textNomEleve.Size = new System.Drawing.Size(155, 20);
            this.textNomEleve.TabIndex = 2;
            // 
            // labelNomEleve
            // 
            this.labelNomEleve.AutoSize = true;
            this.labelNomEleve.Location = new System.Drawing.Point(31, 112);
            this.labelNomEleve.Name = "labelNomEleve";
            this.labelNomEleve.Size = new System.Drawing.Size(83, 13);
            this.labelNomEleve.TabIndex = 3;
            this.labelNomEleve.Text = "Nom de l\'élève :";
            // 
            // textPrenomEleve
            // 
            this.textPrenomEleve.Location = new System.Drawing.Point(454, 109);
            this.textPrenomEleve.Name = "textPrenomEleve";
            this.textPrenomEleve.Size = new System.Drawing.Size(100, 20);
            this.textPrenomEleve.TabIndex = 6;
            // 
            // textNaissanceEleve
            // 
            this.textNaissanceEleve.Location = new System.Drawing.Point(454, 150);
            this.textNaissanceEleve.Name = "textNaissanceEleve";
            this.textNaissanceEleve.Size = new System.Drawing.Size(100, 20);
            this.textNaissanceEleve.TabIndex = 7;
            // 
            // textTelParent
            // 
            this.textTelParent.Location = new System.Drawing.Point(454, 195);
            this.textTelParent.Name = "textTelParent";
            this.textTelParent.Size = new System.Drawing.Size(100, 20);
            this.textTelParent.TabIndex = 8;
            // 
            // textTelEleve
            // 
            this.textTelEleve.Location = new System.Drawing.Point(454, 236);
            this.textTelEleve.Name = "textTelEleve";
            this.textTelEleve.Size = new System.Drawing.Size(100, 20);
            this.textTelEleve.TabIndex = 9;
            // 
            // richTextCom
            // 
            this.richTextCom.Location = new System.Drawing.Point(34, 262);
            this.richTextCom.Name = "richTextCom";
            this.richTextCom.Size = new System.Drawing.Size(241, 63);
            this.richTextCom.TabIndex = 10;
            this.richTextCom.Text = "";
            // 
            // labelClasseEleve
            // 
            this.labelClasseEleve.AutoSize = true;
            this.labelClasseEleve.Location = new System.Drawing.Point(22, 154);
            this.labelClasseEleve.Name = "labelClasseEleve";
            this.labelClasseEleve.Size = new System.Drawing.Size(92, 13);
            this.labelClasseEleve.TabIndex = 11;
            this.labelClasseEleve.Text = "Classe de l\'élève :";
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(31, 243);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(103, 13);
            this.labelCom.TabIndex = 13;
            this.labelCom.Text = "Commentaire santé :";
            // 
            // labelPrenomEleve
            // 
            this.labelPrenomEleve.AutoSize = true;
            this.labelPrenomEleve.Location = new System.Drawing.Point(343, 112);
            this.labelPrenomEleve.Name = "labelPrenomEleve";
            this.labelPrenomEleve.Size = new System.Drawing.Size(97, 13);
            this.labelPrenomEleve.TabIndex = 14;
            this.labelPrenomEleve.Text = "Prénom de l\'élève :";
            // 
            // labelNaissanceEleve
            // 
            this.labelNaissanceEleve.AutoSize = true;
            this.labelNaissanceEleve.Location = new System.Drawing.Point(346, 150);
            this.labelNaissanceEleve.Name = "labelNaissanceEleve";
            this.labelNaissanceEleve.Size = new System.Drawing.Size(102, 13);
            this.labelNaissanceEleve.TabIndex = 15;
            this.labelNaissanceEleve.Text = "Date de naissance :";
            // 
            // labelTelParent
            // 
            this.labelTelParent.AutoSize = true;
            this.labelTelParent.Location = new System.Drawing.Point(351, 195);
            this.labelTelParent.Name = "labelTelParent";
            this.labelTelParent.Size = new System.Drawing.Size(97, 13);
            this.labelTelParent.TabIndex = 16;
            this.labelTelParent.Text = "Téléphone parent :";
            // 
            // labelTelEleve
            // 
            this.labelTelEleve.AutoSize = true;
            this.labelTelEleve.Location = new System.Drawing.Point(355, 239);
            this.labelTelEleve.Name = "labelTelEleve";
            this.labelTelEleve.Size = new System.Drawing.Size(93, 13);
            this.labelTelEleve.TabIndex = 17;
            this.labelTelEleve.Text = "Téléphone élève :";
            // 
            // checkTT
            // 
            this.checkTT.AutoSize = true;
            this.checkTT.Location = new System.Drawing.Point(358, 286);
            this.checkTT.Name = "checkTT";
            this.checkTT.Size = new System.Drawing.Size(80, 17);
            this.checkTT.TabIndex = 19;
            this.checkTT.Text = "Tiers temps";
            this.checkTT.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(559, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 20;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // listClasseEleve
            // 
            this.listClasseEleve.FormattingEnabled = true;
            this.listClasseEleve.Items.AddRange(new object[] {
            "Test1",
            "Test2"});
            this.listClasseEleve.Location = new System.Drawing.Point(120, 154);
            this.listClasseEleve.Name = "listClasseEleve";
            this.listClasseEleve.Size = new System.Drawing.Size(155, 17);
            this.listClasseEleve.TabIndex = 21;
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(276, 4);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 22;
            this.logoStVincent.TabStop = false;
            // 
            // FrmAjoutEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 429);
            this.Controls.Add(this.logoStVincent);
            this.Controls.Add(this.listClasseEleve);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.checkTT);
            this.Controls.Add(this.labelTelEleve);
            this.Controls.Add(this.labelTelParent);
            this.Controls.Add(this.labelNaissanceEleve);
            this.Controls.Add(this.labelPrenomEleve);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.labelClasseEleve);
            this.Controls.Add(this.richTextCom);
            this.Controls.Add(this.textTelEleve);
            this.Controls.Add(this.textTelParent);
            this.Controls.Add(this.textNaissanceEleve);
            this.Controls.Add(this.textPrenomEleve);
            this.Controls.Add(this.labelNomEleve);
            this.Controls.Add(this.textNomEleve);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAjoutEleve";
            this.Text = "Ajout d\'un élève";
            this.Load += new System.EventHandler(this.FrmAjoutEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox textNomEleve;
        private System.Windows.Forms.Label labelNomEleve;
        private System.Windows.Forms.TextBox textPrenomEleve;
        private System.Windows.Forms.TextBox textNaissanceEleve;
        private System.Windows.Forms.TextBox textTelParent;
        private System.Windows.Forms.TextBox textTelEleve;
        private System.Windows.Forms.RichTextBox richTextCom;
        private System.Windows.Forms.Label labelClasseEleve;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label labelPrenomEleve;
        private System.Windows.Forms.Label labelNaissanceEleve;
        private System.Windows.Forms.Label labelTelParent;
        private System.Windows.Forms.Label labelTelEleve;
        private System.Windows.Forms.CheckBox checkTT;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListBox listClasseEleve;
        private System.Windows.Forms.PictureBox logoStVincent;
    }
}

