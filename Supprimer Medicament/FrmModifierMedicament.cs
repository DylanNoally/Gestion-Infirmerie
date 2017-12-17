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
            requeteComparaison = GestionMedicaments.verifMedicament(txtNomMedicament.Text);

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
                int reqExtractDonnees;
                reqExtractDonnees = GestionMedicaments.verifMedicament(txtNomMedicament.Text);

                if (reqExtractDonnees != 1)
                {
                    // Si la requête ne trouve pas le médicament passé par la liste cela affiche un message d'erreur 
                    // et renvoie sur le formulaire précédent afin de resélectionner
                    MessageBox.Show("Une erreur s'est produite, réessayer de modifier un médicament !");
                    FrmGestionMedicaments GestionMedicament = new FrmGestionMedicaments();
                    GestionMedicament.Show();
                    this.Hide();
                }
                else
                {

                }
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
            FrmGestionMedicaments GestionMedicaments = new FrmGestionMedicaments();
            GestionMedicaments.Show();
            this.Hide();
        }

        private void txtNomMedicament_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmModifierMedicament_Load(object sender, EventArgs e)
        {

        }

        //suppression d'un médicament
        private void btnSuppression_Click(object sender, EventArgs e)
        {
            int idmedicament = //valeur a faire passer
            GestionMedicaments.SuppressionMedicament(idmedicament);
            MessageBox.Show(GestionMedicaments.SuppressionMedicament(idmedicament));
        }
    }
}
