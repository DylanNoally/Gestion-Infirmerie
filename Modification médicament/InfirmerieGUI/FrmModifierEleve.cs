using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfirmerieBLL; // Référence à la couche BLL
using InfirmerieBO;  // Référence à la coucher BO

namespace InfirmerieGUI
{
    public partial class FrmModifierEleve : Form
    {
        private string nomEleveChoisi;
        private string prenomEleveChoisi;
        private int classeEleveChoisi;
        Eleve eleve;

        public FrmModifierEleve(string nomEleve, string prenomEleve, int classeEleve)
        {
            InitializeComponent();
            this.nomEleveChoisi = nomEleve;
            this.prenomEleveChoisi = prenomEleve;
            this.classeEleveChoisi = classeEleve;
        }

        private void FrmModifierEleve_Load(object sender, EventArgs e)
        {
            GestionInfirmerie eleveGestion = new GestionInfirmerie();

            eleve = eleveGestion.recupererDetailsEleves(nomEleveChoisi, prenomEleveChoisi);

            // Définitions des données de l'élève sélectionné
            txtNom.Text = eleve.Nom;
            dateNaissance.Value = eleve.Naissance;
            Prenom.Text = eleve.Prenom;
            telEleve.Text = eleve.TelEleve.ToString();
            telParent.Text = eleve.TelParent.ToString();
            commentSante.Text = eleve.Sante;

            GestionInfirmerie classes = new GestionInfirmerie();
            List<string> lesClasses = new List<string>();

            lesClasses = classes.recupererInfosClasses();
            listeClasses.DataSource = lesClasses;
            listeClasses.SelectedIndex = classeEleveChoisi;

            if (eleve.Tierstemps == true)
            {
                checkTT.Checked = true;
            }
            else
            {
                checkTT.Checked = false;
            }

            if (eleve.Visite == true)
            {
                checkVisite.Checked = true;
            }
            else
            {
                checkVisite.Checked = false;
            }

            if (eleve.Archive == true)
            {
                checkArchive.Checked = true;
            }
            else
            {
                checkArchive.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listClasseEleve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmAccueil Accueil = new FrmAccueil();
            Accueil.Show();
            this.Hide();
        }

        private void btnValidModif_Click(object sender, EventArgs e)
        {
            GestionInfirmerie.ModifierEleve(eleve.Id, eleve.Nom, eleve.Prenom, eleve.Naissance, eleve.Sante, eleve.TelEleve, eleve.TelParent, eleve.Archive, eleve.Tierstemps, eleve.Visite);
            MessageBox.Show("La modification eleve a bien été effectué.");
            FrmGestionEleves Gestion = new FrmGestionEleves();
            Gestion.Show();
            this.Hide();
        }

        private void btnValidSupress_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
