using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfirmerieBLL;

namespace InfirmerieGUI
{
    public partial class FrmGestionEleves : Form
    {
        private Label titreGestionInfirmerie;
        private Label lblClasse;
        private Label lblEleve;
        private Button btnValider;
        private Button btnRetour;
        private Button btnImportCSV;
        private Button btnCreerEleve;

        private ComboBox listeClasses;
        private ComboBox listeEleves;
        private ComboBox comboBoxPrenoms;
        private PictureBox logoStVincent;
    
        public FrmGestionEleves()
        {
            InitializeComponent();

            GestionInfirmerie classes = new GestionInfirmerie();
            List<string> lesClasses = new List<string>();

            lesClasses = classes.recupererInfosClasses();
            listeClasses.DataSource = lesClasses;

            GestionInfirmerie eleves = new GestionInfirmerie();
            List<string> lesEleves = new List<string>();

            GestionInfirmerie prenoms = new GestionInfirmerie();
            List<string> lesPrenoms = new List<string>();

            //string libClasse = Convert.ToString(listeClasses.ValueMember);
            string libClasse = Convert.ToString(listeClasses.SelectedItem);
            lesEleves = eleves.recupererInfosEleves(libClasse);
            listeEleves.DataSource = lesEleves;

            string prenomsEleves = Convert.ToString(listeEleves.SelectedItem);
            lesPrenoms = prenoms.recupererPrenomsEleves(prenomsEleves);
            comboBoxPrenoms.DataSource = lesPrenoms;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionEleves));
            this.titreGestionInfirmerie = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblEleve = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.btnCreerEleve = new System.Windows.Forms.Button();

            this.listeClasses = new System.Windows.Forms.ComboBox();
            this.listeEleves = new System.Windows.Forms.ComboBox();
            this.comboBoxPrenoms = new System.Windows.Forms.ComboBox();
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // titreGestionInfirmerie
            // 
            this.titreGestionInfirmerie.AutoSize = true;
            this.titreGestionInfirmerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titreGestionInfirmerie.Location = new System.Drawing.Point(137, 59);
            this.titreGestionInfirmerie.Name = "titreGestionInfirmerie";
            this.titreGestionInfirmerie.Size = new System.Drawing.Size(144, 20);
            this.titreGestionInfirmerie.TabIndex = 8;
            this.titreGestionInfirmerie.Text = "Gestion des élèves";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClasse.Location = new System.Drawing.Point(35, 111);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(44, 13);
            this.lblClasse.TabIndex = 9;
            this.lblClasse.Text = "Classe :";
            this.lblClasse.Click += new System.EventHandler(this.lblClasse_Click);
            // 
            // lblEleve
            // 
            this.lblEleve.AutoSize = true;
            this.lblEleve.Location = new System.Drawing.Point(39, 171);
            this.lblEleve.Name = "lblEleve";
            this.lblEleve.Size = new System.Drawing.Size(40, 13);
            this.lblEleve.TabIndex = 10;
            this.lblEleve.Text = "Elève :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(105, 225);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 41);
            this.btnValider.TabIndex = 13;
            this.btnValider.Text = "Rechercher";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(299, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnImportCSV
            // 
            this.btnImportCSV.Location = new System.Drawing.Point(294, 259);
            this.btnImportCSV.Name = "btnImportCSV";
            this.btnImportCSV.Size = new System.Drawing.Size(84, 26);
            this.btnImportCSV.TabIndex = 15;
            this.btnImportCSV.Text = "Import .CSV";
            this.btnImportCSV.UseVisualStyleBackColor = true;
            // 
            // btnCreerEleve
            // 
            this.btnCreerEleve.Location = new System.Drawing.Point(250, 140);
            this.btnCreerEleve.Name = "btnCreerEleve";
            this.btnCreerEleve.Size = new System.Drawing.Size(119, 38);
            this.btnCreerEleve.TabIndex = 16;
            this.btnCreerEleve.Text = "Créer un élève";
            this.btnCreerEleve.UseVisualStyleBackColor = true;
            this.btnCreerEleve.Click += new System.EventHandler(this.btnCreerEleve_Click);
            // 
            // shapeContainer1

            // listeClasses
            // 
            this.listeClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeClasses.FormattingEnabled = true;
            this.listeClasses.Location = new System.Drawing.Point(90, 109);
            this.listeClasses.Name = "listeClasses";
            this.listeClasses.Size = new System.Drawing.Size(121, 21);
            this.listeClasses.TabIndex = 20;
            this.listeClasses.SelectedIndexChanged += new System.EventHandler(this.listeClasses_SelectedIndexChanged);
            // 
            // listeEleves
            // 
            this.listeEleves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeEleves.FormattingEnabled = true;
            this.listeEleves.Location = new System.Drawing.Point(90, 169);
            this.listeEleves.Name = "listeEleves";
            this.listeEleves.Size = new System.Drawing.Size(121, 21);
            this.listeEleves.TabIndex = 21;
            this.listeEleves.SelectedIndexChanged += new System.EventHandler(this.listeEleves_SelectedIndexChanged);
            // 
            // comboBoxPrenoms
            // 
            this.comboBoxPrenoms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrenoms.FormattingEnabled = true;
            this.comboBoxPrenoms.Location = new System.Drawing.Point(90, 197);
            this.comboBoxPrenoms.Name = "comboBoxPrenoms";
            this.comboBoxPrenoms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrenoms.TabIndex = 22;
            this.comboBoxPrenoms.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrenoms_SelectedIndexChanged);
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(175, 12);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 6;
            this.logoStVincent.TabStop = false;
            // 
            // FrmGestionEleves
            // 
            this.ClientSize = new System.Drawing.Size(383, 291);
            this.Controls.Add(this.comboBoxPrenoms);
            this.Controls.Add(this.listeEleves);
            this.Controls.Add(this.listeClasses);
            this.Controls.Add(this.btnCreerEleve);
            this.Controls.Add(this.btnImportCSV);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblEleve);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.titreGestionInfirmerie);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmGestionEleves";
            this.Load += new System.EventHandler(this.FrmGestionEleves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblClasse_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmGestionEleves_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmAccueil Accueil = new FrmAccueil();
            Accueil.Show();
            this.Hide();
        }

        private void btnCreerEleve_Click(object sender, EventArgs e)
        {
            FrmAjoutEleve AjoutEleve = new FrmAjoutEleve();
            AjoutEleve.Show();
            this.Hide();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string prenomEleve = comboBoxPrenoms.Text;
            string nomEleve = listeEleves.Text;
            int classeEleve = listeClasses.SelectedIndex;
            FrmModifierEleve ModifEleve = new FrmModifierEleve(nomEleve, prenomEleve, classeEleve);
            ModifEleve.Show();
            
            this.Hide();
        }

        private void listeClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            GestionInfirmerie eleves = new GestionInfirmerie();
            List<string> lesEleves = new List<string>();

            string libClasse = Convert.ToString(listeClasses.SelectedItem);
            lesEleves = eleves.recupererInfosEleves(libClasse);
            listeEleves.DataSource = lesEleves;

            GestionInfirmerie prenoms = new GestionInfirmerie();
            List<string> lesPrenoms = new List<string>();

            string prenomsEleves = Convert.ToString(listeEleves.SelectedItem);
            lesPrenoms = prenoms.recupererPrenomsEleves(prenomsEleves);
            comboBoxPrenoms.DataSource = lesPrenoms;
        }

        private void listeEleves_SelectedIndexChanged(object sender, EventArgs e)
        {
            GestionInfirmerie prenoms = new GestionInfirmerie();
            List<string> lesPrenoms = new List<string>();

            string prenomsEleves = Convert.ToString(listeEleves.SelectedItem);
            lesPrenoms = prenoms.recupererPrenomsEleves(prenomsEleves);
            comboBoxPrenoms.DataSource = lesPrenoms;
        }

        private void comboBoxPrenoms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
