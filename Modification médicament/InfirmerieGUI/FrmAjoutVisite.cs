using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using InfirmerieBLL; // Référence à la couche BLL
using InfirmerieBO;  // Référence à la coucher BO

namespace InfirmerieGUI
{
    public partial class FrmAjoutVisite : Form
    {
        public FrmAjoutVisite(string prenom, string nom, string classe)
        {
            InitializeComponent();

            // Récupération de la chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            txtNomEleve.Text = nom;
            txtPrenomEleve.Text = prenom;
            txtClasse.Text = classe;

            // -------------------------------------------------------------------------------------------
            // Compare ce qui a été passé à partir de la liste déroulante avec ce qu'il y a dans la BDD
            // afin d'éviter une quelconque erreur de la réactualisation de la liste déroulante
            // -------------------------------------------------------------------------------------------
            // int requeteComparaison;
            // requeteComparaison = GestionVisites.VerifEleve(txtNomEleve.Text, txtPrenomEleve.Text, txtClasse.Text);

            // if (requeteComparaison != 1)
            // {
                // ---------------------------------------------------------------------------------------------
                // Si la requête ne trouve pas le médicament passé par la liste cela affiche un message d'erreur 
                // et renvoie sur le formulaire précédent afin de resélectionner
                // ---------------------------------------------------------------------------------------------
                // MessageBox.Show("Une erreur s'est produite, réessayer de créer une visite !");
                // FrmGestionVisites GestionVisite = new FrmGestionVisites();
                // GestionVisite.Show();
                // this.Hide();
            // }
            // else
            // {
                // Visite uneVisite;
                //uneVisite = GestionVisites.ExtractInfosEleve(txtNomEleve.Text, txtPrenomEleve.Text, txtClasse.Text);

               
            // }

        }

        private void titreGestionInfirmerie_Click(object sender, EventArgs e)
        {

        }

        private void FrmAjoutVisite_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmListeVisites Visite = new FrmListeVisites();
            Visite.Show();
            this.Hide();
        }

        private void txtNomEleve_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            FrmListeVisites listeVisite = new FrmListeVisites();
            listeVisite.Show();
            this.Hide();
        }
    }
}
