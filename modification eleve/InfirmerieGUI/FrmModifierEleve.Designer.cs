namespace InfirmerieGUI
{
    partial class FrmModifierEleve
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ModifierEleve = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.labelClasseEleve = new System.Windows.Forms.Label();
            this.labelNomEleve = new System.Windows.Forms.Label();
            this.labelPrenomEleve = new System.Windows.Forms.Label();
            this.labelNaissanceEleve = new System.Windows.Forms.Label();
            this.labelTelParent = new System.Windows.Forms.Label();
            this.labelTelEleve = new System.Windows.Forms.Label();
            this.checkTT = new System.Windows.Forms.CheckBox();
            this.commentSante = new System.Windows.Forms.RichTextBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.listClasseEleve = new System.Windows.Forms.ListBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.dateNaissance = new System.Windows.Forms.TextBox();
            this.telParent = new System.Windows.Forms.TextBox();
            this.telEleve = new System.Windows.Forms.TextBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(155, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 0;
            // 
            // ModifierEleve
            // 
            this.ModifierEleve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModifierEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierEleve.Location = new System.Drawing.Point(183, 46);
            this.ModifierEleve.Name = "ModifierEleve";
            this.ModifierEleve.Size = new System.Drawing.Size(238, 29);
            this.ModifierEleve.TabIndex = 1;
            this.ModifierEleve.Text = "Modifier Eleve :";
            this.ModifierEleve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModifierEleve.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nom
            // 
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(145, 103);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(155, 20);
            this.Nom.TabIndex = 2;
            this.Nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelClasseEleve
            // 
            this.labelClasseEleve.AutoSize = true;
            this.labelClasseEleve.Location = new System.Drawing.Point(47, 147);
            this.labelClasseEleve.Name = "labelClasseEleve";
            this.labelClasseEleve.Size = new System.Drawing.Size(92, 13);
            this.labelClasseEleve.TabIndex = 12;
            this.labelClasseEleve.Text = "Classe de l\'élève :";
            // 
            // labelNomEleve
            // 
            this.labelNomEleve.AutoSize = true;
            this.labelNomEleve.Location = new System.Drawing.Point(47, 106);
            this.labelNomEleve.Name = "labelNomEleve";
            this.labelNomEleve.Size = new System.Drawing.Size(83, 13);
            this.labelNomEleve.TabIndex = 13;
            this.labelNomEleve.Text = "Nom de l\'élève :";
            // 
            // labelPrenomEleve
            // 
            this.labelPrenomEleve.AutoSize = true;
            this.labelPrenomEleve.Location = new System.Drawing.Point(337, 106);
            this.labelPrenomEleve.Name = "labelPrenomEleve";
            this.labelPrenomEleve.Size = new System.Drawing.Size(97, 13);
            this.labelPrenomEleve.TabIndex = 15;
            this.labelPrenomEleve.Text = "Prénom de l\'élève :";
            // 
            // labelNaissanceEleve
            // 
            this.labelNaissanceEleve.AutoSize = true;
            this.labelNaissanceEleve.Location = new System.Drawing.Point(337, 147);
            this.labelNaissanceEleve.Name = "labelNaissanceEleve";
            this.labelNaissanceEleve.Size = new System.Drawing.Size(102, 13);
            this.labelNaissanceEleve.TabIndex = 16;
            this.labelNaissanceEleve.Text = "Date de naissance :";
            // 
            // labelTelParent
            // 
            this.labelTelParent.AutoSize = true;
            this.labelTelParent.Location = new System.Drawing.Point(337, 196);
            this.labelTelParent.Name = "labelTelParent";
            this.labelTelParent.Size = new System.Drawing.Size(97, 13);
            this.labelTelParent.TabIndex = 17;
            this.labelTelParent.Text = "Téléphone parent :";
            // 
            // labelTelEleve
            // 
            this.labelTelEleve.AutoSize = true;
            this.labelTelEleve.Location = new System.Drawing.Point(341, 245);
            this.labelTelEleve.Name = "labelTelEleve";
            this.labelTelEleve.Size = new System.Drawing.Size(93, 13);
            this.labelTelEleve.TabIndex = 18;
            this.labelTelEleve.Text = "Téléphone élève :";
            // 
            // checkTT
            // 
            this.checkTT.AutoSize = true;
            this.checkTT.Location = new System.Drawing.Point(344, 288);
            this.checkTT.Name = "checkTT";
            this.checkTT.Size = new System.Drawing.Size(80, 17);
            this.checkTT.TabIndex = 20;
            this.checkTT.Text = "Tiers temps";
            this.checkTT.UseVisualStyleBackColor = true;
            // 
            // commentSante
            // 
            this.commentSante.Location = new System.Drawing.Point(44, 264);
            this.commentSante.Name = "commentSante";
            this.commentSante.Size = new System.Drawing.Size(241, 63);
            this.commentSante.TabIndex = 21;
            this.commentSante.Text = "";
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(41, 245);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(103, 13);
            this.labelCom.TabIndex = 22;
            this.labelCom.Text = "Commentaire santé :";
            // 
            // listClasseEleve
            // 
            this.listClasseEleve.FormattingEnabled = true;
            this.listClasseEleve.Items.AddRange(new object[] {
            "Test1",
            "Test2"});
            this.listClasseEleve.Location = new System.Drawing.Point(145, 147);
            this.listClasseEleve.Name = "listClasseEleve";
            this.listClasseEleve.Size = new System.Drawing.Size(155, 17);
            this.listClasseEleve.TabIndex = 23;
            // 
            // Prenom
            // 
            this.Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenom.Location = new System.Drawing.Point(440, 103);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(155, 20);
            this.Prenom.TabIndex = 24;
            // 
            // dateNaissance
            // 
            this.dateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNaissance.Location = new System.Drawing.Point(440, 147);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(155, 20);
            this.dateNaissance.TabIndex = 25;
            // 
            // telParent
            // 
            this.telParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telParent.Location = new System.Drawing.Point(440, 193);
            this.telParent.Name = "telParent";
            this.telParent.Size = new System.Drawing.Size(155, 20);
            this.telParent.TabIndex = 26;
            // 
            // telEleve
            // 
            this.telEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telEleve.Location = new System.Drawing.Point(440, 245);
            this.telEleve.Name = "telEleve";
            this.telEleve.Size = new System.Drawing.Size(155, 20);
            this.telEleve.TabIndex = 27;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(520, 21);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 28;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // FrmModifierEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 339);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.telEleve);
            this.Controls.Add(this.telParent);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.listClasseEleve);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.commentSante);
            this.Controls.Add(this.checkTT);
            this.Controls.Add(this.labelTelEleve);
            this.Controls.Add(this.labelTelParent);
            this.Controls.Add(this.labelNaissanceEleve);
            this.Controls.Add(this.labelPrenomEleve);
            this.Controls.Add(this.labelNomEleve);
            this.Controls.Add(this.labelClasseEleve);
            this.Controls.Add(this.ModifierEleve);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Nom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmModifierEleve";
            this.Text = "FrmModifierEleve";
            this.Load += new System.EventHandler(this.FrmModifierEleve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label ModifierEleve;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label labelClasseEleve;
        private System.Windows.Forms.Label labelNomEleve;
        private System.Windows.Forms.Label labelPrenomEleve;
        private System.Windows.Forms.Label labelNaissanceEleve;
        private System.Windows.Forms.Label labelTelParent;
        private System.Windows.Forms.Label labelTelEleve;
        private System.Windows.Forms.CheckBox checkTT;
        private System.Windows.Forms.RichTextBox commentSante;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.ListBox listClasseEleve;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox dateNaissance;
        private System.Windows.Forms.TextBox telParent;
        private System.Windows.Forms.TextBox telEleve;
        private System.Windows.Forms.Button btnRetour;
    }
}