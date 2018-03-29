using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfirmerieBLL;
using System.Configuration;

namespace InfirmerieGUI
{
    public partial class FrmAjoutMedicament : Form
    {
        private Label label1;
        private Label lblNomMedicament;
        private TextBox txtMedicament;
        private Button btnEnregistrer;
        private Button btnRetour;
        private CheckBox ckbArchive;
        private CheckBox ckbPossedeVisite;
        private PictureBox logoStVincent;
    
        public FrmAjoutMedicament()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutMedicament));
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomMedicament = new System.Windows.Forms.Label();
            this.txtMedicament = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.ckbArchive = new System.Windows.Forms.CheckBox();
            this.ckbPossedeVisite = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(152, 12);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 23;
            this.logoStVincent.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(79, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ajouter un médicament :";
            // 
            // lblNomMedicament
            // 
            this.lblNomMedicament.AutoSize = true;
            this.lblNomMedicament.Location = new System.Drawing.Point(21, 124);
            this.lblNomMedicament.Name = "lblNomMedicament";
            this.lblNomMedicament.Size = new System.Drawing.Size(147, 13);
            this.lblNomMedicament.TabIndex = 26;
            this.lblNomMedicament.Text = "Saisir le nom du médicament :";
            // 
            // txtMedicament
            // 
            this.txtMedicament.Location = new System.Drawing.Point(174, 120);
            this.txtMedicament.Name = "txtMedicament";
            this.txtMedicament.Size = new System.Drawing.Size(155, 20);
            this.txtMedicament.TabIndex = 25;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(94, 196);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(159, 47);
            this.btnEnregistrer.TabIndex = 27;
            this.btnEnregistrer.Text = "Enregistrer le médicament";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(288, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(65, 24);
            this.btnRetour.TabIndex = 28;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // ckbArchive
            // 
            this.ckbArchive.AutoSize = true;
            this.ckbArchive.Location = new System.Drawing.Point(74, 161);
            this.ckbArchive.Name = "ckbArchive";
            this.ckbArchive.Size = new System.Drawing.Size(65, 17);
            this.ckbArchive.TabIndex = 29;
            this.ckbArchive.Text = "Archiver";
            this.ckbArchive.UseVisualStyleBackColor = true;
            // 
            // ckbPossedeVisite
            // 
            this.ckbPossedeVisite.AutoSize = true;
            this.ckbPossedeVisite.Location = new System.Drawing.Point(203, 161);
            this.ckbPossedeVisite.Name = "ckbPossedeVisite";
            this.ckbPossedeVisite.Size = new System.Drawing.Size(94, 17);
            this.ckbPossedeVisite.TabIndex = 30;
            this.ckbPossedeVisite.Text = "Possède visite";
            this.ckbPossedeVisite.UseVisualStyleBackColor = true;
            // 
            // FrmAjoutMedicament
            // 
            this.ClientSize = new System.Drawing.Size(365, 253);
            this.Controls.Add(this.ckbPossedeVisite);
            this.Controls.Add(this.ckbArchive);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lblNomMedicament);
            this.Controls.Add(this.txtMedicament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmAjoutMedicament";
            this.Load += new System.EventHandler(this.FrmAjoutMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmAjoutMedicament_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestionMedicaments Medicament = new FrmGestionMedicaments();
            Medicament.Show();
            this.Hide();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            GestionMedicaments unMedicament;
            unMedicament = new GestionMedicaments();
            bool archive;

            if (ckbArchive.Checked == true)
            {
                archive = true;
            }
            else
            {
                archive = false;
            }

            unMedicament.CreerMedicament(txtMedicament.Text, archive);

            MessageBox.Show("Le médicament "+ txtMedicament.Text + " a bien été ajouté.");
            FrmGestionMedicaments Medicament = new FrmGestionMedicaments();
            Medicament.Show();
            this.Hide();
        }
    }
}
