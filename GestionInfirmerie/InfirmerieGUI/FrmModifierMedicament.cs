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
    public partial class FrmModifierMedicament : Form
    {


        public FrmModifierMedicament(string value)
        {
            InitializeComponent();

            // Récupération de la chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Affichage du libellé sélectionné dans le formulaire précédent
            txtNomMedicament.Text = value;

            // -------------------------------------------------------------------------------------------
            // Compare ce qui a été passé à partir de la liste déroulante avec ce qu'il y a dans la BDD
            // afin d'éviter une quelconque erreur de la réactualisation de la liste déroulante
            // -------------------------------------------------------------------------------------------
            int requeteComparaison;
            requeteComparaison = GestionMedicaments.VerifMedicament(txtNomMedicament.Text);

            if (requeteComparaison != 1)
            {
                // ---------------------------------------------------------------------------------------------
                // Si la requête ne trouve pas le médicament passé par la liste cela affiche un message d'erreur 
                // et renvoie sur le formulaire précédent afin de resélectionner
                // ---------------------------------------------------------------------------------------------
                MessageBox.Show("Une erreur s'est produite, réessayer de modifier un médicament !");
                FrmGestionMedicaments GestionMedicament = new FrmGestionMedicaments();
                GestionMedicament.Show();
                this.Hide();
            }
            else
            {
                Medicament unMedicament;
                unMedicament = GestionMedicaments.ExtractInfosMedicament(txtNomMedicament.Text);

                txtIdMedicament.Text = unMedicament.Id.ToString();
                ckbArchive.Checked = unMedicament.Archive;
                ckbPossedeVisite.Checked = unMedicament.PossedeVisite;
            }
        }

        private void ModifierEleve_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestionMedicaments GestionMedicaments = new FrmGestionMedicaments();
            GestionMedicaments.Show();
            this.Hide();
        }

        private void ckbArchive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Variable qui récupère la valeur retourner de la méthode de modification d'un médicament au clic du bouton "Valider"
            int requeteUpdateReussi = GestionMedicaments.ModifierMedicament(int.Parse(txtIdMedicament.Text), txtNomMedicament.Text, ckbArchive.Checked, ckbPossedeVisite.Checked);

            // Si la variable retourne 0 (false), alors une erreur s'est produite, sinon la modification s'est bien passé
            if (requeteUpdateReussi != 1)
            {
                MessageBox.Show("Une erreur s'est produite, réessayer de modifier un médicament !");
            }
            else
            {
                MessageBox.Show("La modification du médicament " + txtNomMedicament.Text + "a bien été effectuer !");

                // Redirection vers le formulaire contenant la liste des médicaments
                FrmGestionMedicaments gestionMedicaments = new FrmGestionMedicaments();
                gestionMedicaments.Show();
                this.Hide();
            }
        }

        private void txtNomMedicament_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmModifierMedicament_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuppression_Click(object sender, EventArgs e)
        {
            // Variable qui récupère la valeur retourner de la méthode de suppression d'un médicament au clic du bouton "Supprimer"
            int requeteDeleteReussi = GestionMedicaments.SuppressionMedicament(int.Parse(txtIdMedicament.Text));

            // Si la variable retourne 0 (false), alors une erreur s'est produite, sinon la suppresion s'est bien passé
            if (requeteDeleteReussi != 1)
            {
                MessageBox.Show("Une erreur s'est produite, réessayer de supprimer un médicament !");
            }
            else
            {
                MessageBox.Show("Le médicament " + txtNomMedicament.Text + "a bien été effectuer !");

                // Redirection vers le formulaire contenant la liste des médicaments
                FrmGestionMedicaments gestionMedicaments = new FrmGestionMedicaments();
                gestionMedicaments.Show();
                this.Hide();
            }
        }
    }
}
