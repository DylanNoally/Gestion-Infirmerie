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
    public partial class FrmGestionVisites : Form
    {
        private Label titreGestionInfirmerie;
        private Button button1;
        private Label lblEleve;
        private Label lblClasse;
        private ComboBox comboBoxPrenoms;
        private ComboBox listeEleves;
        private ComboBox listeClasses;
        private Button button2;
        private Button button3;
        private PictureBox logoStVincent;
    
        public FrmGestionVisites()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionVisites));
            this.titreGestionInfirmerie = new System.Windows.Forms.Label();
            this.logoStVincent = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEleve = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.comboBoxPrenoms = new System.Windows.Forms.ComboBox();
            this.listeEleves = new System.Windows.Forms.ComboBox();
            this.listeClasses = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // titreGestionInfirmerie
            // 
            this.titreGestionInfirmerie.AutoSize = true;
            this.titreGestionInfirmerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreGestionInfirmerie.Location = new System.Drawing.Point(145, 70);
            this.titreGestionInfirmerie.Name = "titreGestionInfirmerie";
            this.titreGestionInfirmerie.Size = new System.Drawing.Size(163, 18);
            this.titreGestionInfirmerie.TabIndex = 8;
            this.titreGestionInfirmerie.Text = "Gestion d\'une infirmerie";
            // 
            // logoStVincent
            // 
            this.logoStVincent.ErrorImage = null;
            this.logoStVincent.Image = global::InfirmerieGUI.Properties.Resources.logo;
            this.logoStVincent.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoStVincent.InitialImage")));
            this.logoStVincent.Location = new System.Drawing.Point(204, 12);
            this.logoStVincent.Name = "logoStVincent";
            this.logoStVincent.Size = new System.Drawing.Size(42, 44);
            this.logoStVincent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStVincent.TabIndex = 6;
            this.logoStVincent.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEleve
            // 
            this.lblEleve.AutoSize = true;
            this.lblEleve.Location = new System.Drawing.Point(128, 170);
            this.lblEleve.Name = "lblEleve";
            this.lblEleve.Size = new System.Drawing.Size(40, 13);
            this.lblEleve.TabIndex = 39;
            this.lblEleve.Text = "Elève :";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClasse.Location = new System.Drawing.Point(128, 124);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(44, 13);
            this.lblClasse.TabIndex = 38;
            this.lblClasse.Text = "Classe :";
            // 
            // comboBoxPrenoms
            // 
            this.comboBoxPrenoms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrenoms.FormattingEnabled = true;
            this.comboBoxPrenoms.Location = new System.Drawing.Point(178, 197);
            this.comboBoxPrenoms.Name = "comboBoxPrenoms";
            this.comboBoxPrenoms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrenoms.TabIndex = 42;
            // 
            // listeEleves
            // 
            this.listeEleves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeEleves.FormattingEnabled = true;
            this.listeEleves.Location = new System.Drawing.Point(178, 170);
            this.listeEleves.Name = "listeEleves";
            this.listeEleves.Size = new System.Drawing.Size(121, 21);
            this.listeEleves.TabIndex = 41;
            this.listeEleves.SelectedIndexChanged += new System.EventHandler(this.listeEleves_SelectedIndexChanged_1);
            // 
            // listeClasses
            // 
            this.listeClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeClasses.FormattingEnabled = true;
            this.listeClasses.Location = new System.Drawing.Point(178, 121);
            this.listeClasses.Name = "listeClasses";
            this.listeClasses.Size = new System.Drawing.Size(121, 21);
            this.listeClasses.TabIndex = 40;
            this.listeClasses.SelectedIndexChanged += new System.EventHandler(this.listeClasses_SelectedIndexChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Créer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "Consulter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmGestionVisites
            // 
            this.ClientSize = new System.Drawing.Size(474, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxPrenoms);
            this.Controls.Add(this.listeEleves);
            this.Controls.Add(this.listeClasses);
            this.Controls.Add(this.lblEleve);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titreGestionInfirmerie);
            this.Controls.Add(this.logoStVincent);
            this.Name = "FrmGestionVisites";
            this.Load += new System.EventHandler(this.FrmGestionVisites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoStVincent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAccueil Accueil = new FrmAccueil();
            Accueil.Show();
            this.Hide();
        }


        private void FrmGestionVisites_Load(object sender, EventArgs e)
        {

        }

        private void listeClasses_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void listeEleves_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GestionInfirmerie prenoms = new GestionInfirmerie();
            List<string> lesPrenoms = new List<string>();

            string prenomsEleves = Convert.ToString(listeEleves.SelectedItem);
            lesPrenoms = prenoms.recupererPrenomsEleves(prenomsEleves);
            comboBoxPrenoms.DataSource = lesPrenoms;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string prenomEleve = comboBoxPrenoms.Text;
            string nomEleve = listeEleves.Text;
            string classeEleve = listeClasses.Text;
            FrmAjoutVisite ajoutVisite = new FrmAjoutVisite(nomEleve, prenomEleve, classeEleve);
            ajoutVisite.Show();
            this.Hide();
        }
    }
}
