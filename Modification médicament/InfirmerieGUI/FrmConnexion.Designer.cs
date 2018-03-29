namespace InfirmerieGUI
{
    partial class FrmConnexion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            this.titreGestionInfirmerie = new System.Windows.Forms.Label();
            this.titreConnexion = new System.Windows.Forms.Label();
            this.idConnexion = new System.Windows.Forms.Label();
            this.mdpConnexion = new System.Windows.Forms.Label();
            this.txtLoginConnexion = new System.Windows.Forms.TextBox();
            this.txtMdpConnexion = new System.Windows.Forms.TextBox();
            this.btnValiderConnexion = new System.Windows.Forms.Button();
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // titreGestionInfirmerie
            // 
            this.titreGestionInfirmerie.AutoSize = true;
            this.titreGestionInfirmerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreGestionInfirmerie.Location = new System.Drawing.Point(126, 59);
            this.titreGestionInfirmerie.Name = "titreGestionInfirmerie";
            this.titreGestionInfirmerie.Size = new System.Drawing.Size(184, 20);
            this.titreGestionInfirmerie.TabIndex = 1;
            this.titreGestionInfirmerie.Text = "Gestion d\'une infirmerie :";
            // 
            // titreConnexion
            // 
            this.titreConnexion.AutoSize = true;
            this.titreConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreConnexion.Location = new System.Drawing.Point(173, 90);
            this.titreConnexion.Name = "titreConnexion";
            this.titreConnexion.Size = new System.Drawing.Size(79, 18);
            this.titreConnexion.TabIndex = 2;
            this.titreConnexion.Text = "Connexion";
            // 
            // idConnexion
            // 
            this.idConnexion.AutoSize = true;
            this.idConnexion.Location = new System.Drawing.Point(53, 144);
            this.idConnexion.Name = "idConnexion";
            this.idConnexion.Size = new System.Drawing.Size(101, 13);
            this.idConnexion.TabIndex = 3;
            this.idConnexion.Text = "Nom de l\'utilisateur :";
            // 
            // mdpConnexion
            // 
            this.mdpConnexion.AutoSize = true;
            this.mdpConnexion.Location = new System.Drawing.Point(77, 190);
            this.mdpConnexion.Name = "mdpConnexion";
            this.mdpConnexion.Size = new System.Drawing.Size(77, 13);
            this.mdpConnexion.TabIndex = 4;
            this.mdpConnexion.Text = "Mot de passe :";
            // 
            // txtLoginConnexion
            // 
            this.txtLoginConnexion.Location = new System.Drawing.Point(176, 141);
            this.txtLoginConnexion.Name = "txtLoginConnexion";
            this.txtLoginConnexion.Size = new System.Drawing.Size(158, 20);
            this.txtLoginConnexion.TabIndex = 5;
            // 
            // txtMdpConnexion
            // 
            this.txtMdpConnexion.Location = new System.Drawing.Point(176, 187);
            this.txtMdpConnexion.Name = "txtMdpConnexion";
            this.txtMdpConnexion.PasswordChar = '*';
            this.txtMdpConnexion.Size = new System.Drawing.Size(158, 20);
            this.txtMdpConnexion.TabIndex = 6;
            // 
            // btnValiderConnexion
            // 
            this.btnValiderConnexion.Location = new System.Drawing.Point(162, 248);
            this.btnValiderConnexion.Name = "btnValiderConnexion";
            this.btnValiderConnexion.Size = new System.Drawing.Size(104, 36);
            this.btnValiderConnexion.TabIndex = 7;
            this.btnValiderConnexion.Text = "Valider";
            this.btnValiderConnexion.UseVisualStyleBackColor = true;
            this.btnValiderConnexion.Click += new System.EventHandler(this.btnValiderConnexion_Click);
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(191, 12);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 0;
            this.logoStVincent.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 313);
            this.Controls.Add(this.btnValiderConnexion);
            this.Controls.Add(this.txtMdpConnexion);
            this.Controls.Add(this.txtLoginConnexion);
            this.Controls.Add(this.mdpConnexion);
            this.Controls.Add(this.idConnexion);
            this.Controls.Add(this.titreConnexion);
            this.Controls.Add(this.titreGestionInfirmerie);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmConnexion";
            this.Text = "FrmConnexion";
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoStVincent;
        private System.Windows.Forms.Label titreGestionInfirmerie;
        private System.Windows.Forms.Label titreConnexion;
        private System.Windows.Forms.Label idConnexion;
        private System.Windows.Forms.Label mdpConnexion;
        private System.Windows.Forms.TextBox txtLoginConnexion;
        private System.Windows.Forms.TextBox txtMdpConnexion;
        private System.Windows.Forms.Button btnValiderConnexion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}