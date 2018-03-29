namespace InfirmerieGUI
{
    partial class FrmModifierMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifierMedicament));
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            this.ModifierMedicament = new System.Windows.Forms.Label();
            this.txtNomMedicament = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnSuppression = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.ckbArchive = new System.Windows.Forms.CheckBox();
            this.txtIdMedicament = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(121, 12);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 24;
            this.logoStVincent.TabStop = false;
            // 
            // ModifierMedicament
            // 
            this.ModifierMedicament.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModifierMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierMedicament.Location = new System.Drawing.Point(27, 59);
            this.ModifierMedicament.Name = "ModifierMedicament";
            this.ModifierMedicament.Size = new System.Drawing.Size(247, 29);
            this.ModifierMedicament.TabIndex = 25;
            this.ModifierMedicament.Text = "Modification du médicament :";
            this.ModifierMedicament.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModifierMedicament.Click += new System.EventHandler(this.ModifierEleve_Click);
            // 
            // txtNomMedicament
            // 
            this.txtNomMedicament.Location = new System.Drawing.Point(58, 99);
            this.txtNomMedicament.Name = "txtNomMedicament";
            this.txtNomMedicament.Size = new System.Drawing.Size(195, 20);
            this.txtNomMedicament.TabIndex = 26;
            this.txtNomMedicament.TextChanged += new System.EventHandler(this.txtNomMedicament_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(58, 166);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 27;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnSuppression
            // 
            this.btnSuppression.Location = new System.Drawing.Point(178, 166);
            this.btnSuppression.Name = "btnSuppression";
            this.btnSuppression.Size = new System.Drawing.Size(75, 23);
            this.btnSuppression.TabIndex = 28;
            this.btnSuppression.Text = "Supprimer";
            this.btnSuppression.UseVisualStyleBackColor = true;
            this.btnSuppression.Click += new System.EventHandler(this.btnSuppression_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(232, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(51, 24);
            this.btnRetour.TabIndex = 29;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // ckbArchive
            // 
            this.ckbArchive.AutoSize = true;
            this.ckbArchive.Location = new System.Drawing.Point(121, 134);
            this.ckbArchive.Name = "ckbArchive";
            this.ckbArchive.Size = new System.Drawing.Size(65, 17);
            this.ckbArchive.TabIndex = 31;
            this.ckbArchive.Text = "Archiver";
            this.ckbArchive.UseVisualStyleBackColor = true;
            this.ckbArchive.CheckedChanged += new System.EventHandler(this.ckbArchive_CheckedChanged);
            // 
            // txtIdMedicament
            // 
            this.txtIdMedicament.Location = new System.Drawing.Point(12, 99);
            this.txtIdMedicament.Name = "txtIdMedicament";
            this.txtIdMedicament.ReadOnly = true;
            this.txtIdMedicament.Size = new System.Drawing.Size(27, 20);
            this.txtIdMedicament.TabIndex = 33;
            this.txtIdMedicament.Visible = false;
            this.txtIdMedicament.TextChanged += new System.EventHandler(this.txtIdMedicament_TextChanged);
            // 
            // FrmModifierMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 201);
            this.Controls.Add(this.txtIdMedicament);
            this.Controls.Add(this.ckbArchive);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSuppression);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtNomMedicament);
            this.Controls.Add(this.ModifierMedicament);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmModifierMedicament";
            this.Text = "FrmModifierMedicament";
            this.Load += new System.EventHandler(this.FrmModifierMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoStVincent;
        private System.Windows.Forms.Label ModifierMedicament;
        private System.Windows.Forms.TextBox txtNomMedicament;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnSuppression;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.CheckBox ckbArchive;
        private System.Windows.Forms.TextBox txtIdMedicament;
    }
}