namespace InfirmerieGUI
{
    partial class FrmListeVisites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListeVisites));
            this.comboBoxPrenoms = new System.Windows.Forms.ComboBox();
            this.listeEleves = new System.Windows.Forms.ComboBox();
            this.listeClasses = new System.Windows.Forms.ComboBox();
            this.lblEleve = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.titreGestionInfirmerie = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPrenoms
            // 
            this.comboBoxPrenoms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrenoms.FormattingEnabled = true;
            this.comboBoxPrenoms.Location = new System.Drawing.Point(269, 150);
            this.comboBoxPrenoms.Name = "comboBoxPrenoms";
            this.comboBoxPrenoms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrenoms.TabIndex = 52;
            // 
            // listeEleves
            // 
            this.listeEleves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeEleves.FormattingEnabled = true;
            this.listeEleves.Location = new System.Drawing.Point(142, 150);
            this.listeEleves.Name = "listeEleves";
            this.listeEleves.Size = new System.Drawing.Size(121, 21);
            this.listeEleves.TabIndex = 51;
            // 
            // listeClasses
            // 
            this.listeClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeClasses.FormattingEnabled = true;
            this.listeClasses.Location = new System.Drawing.Point(203, 118);
            this.listeClasses.Name = "listeClasses";
            this.listeClasses.Size = new System.Drawing.Size(121, 21);
            this.listeClasses.TabIndex = 50;
            // 
            // lblEleve
            // 
            this.lblEleve.AutoSize = true;
            this.lblEleve.Location = new System.Drawing.Point(96, 153);
            this.lblEleve.Name = "lblEleve";
            this.lblEleve.Size = new System.Drawing.Size(40, 13);
            this.lblEleve.TabIndex = 49;
            this.lblEleve.Text = "Elève :";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClasse.Location = new System.Drawing.Point(155, 121);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(35, 13);
            this.lblClasse.TabIndex = 48;
            this.lblClasse.Text = "Mois :";
            // 
            // titreGestionInfirmerie
            // 
            this.titreGestionInfirmerie.AutoSize = true;
            this.titreGestionInfirmerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreGestionInfirmerie.Location = new System.Drawing.Point(200, 68);
            this.titreGestionInfirmerie.Name = "titreGestionInfirmerie";
            this.titreGestionInfirmerie.Size = new System.Drawing.Size(120, 18);
            this.titreGestionInfirmerie.TabIndex = 46;
            this.titreGestionInfirmerie.Text = "Listes de visites :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Rafraîchir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 179);
            this.dataGridView1.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.logoStVincent.TabIndex = 45;
            this.logoStVincent.TabStop = false;
            // 
            // FrmListeVisites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 386);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPrenoms);
            this.Controls.Add(this.listeEleves);
            this.Controls.Add(this.listeClasses);
            this.Controls.Add(this.lblEleve);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.titreGestionInfirmerie);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmListeVisites";
            this.Text = "FrmListeVisites";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPrenoms;
        private System.Windows.Forms.ComboBox listeEleves;
        private System.Windows.Forms.ComboBox listeClasses;
        private System.Windows.Forms.Label lblEleve;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label titreGestionInfirmerie;
        private System.Windows.Forms.PictureBox logoStVincent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;

    }
}