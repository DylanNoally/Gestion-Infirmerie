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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();

            // Récupération de la chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {

            int retourRequete;
            retourRequete = GestionUtilisateurs.verifUtilisateur(txtLoginConnexion.Text, txtMdpConnexion.Text);

            if (retourRequete == 1)
            {
                MessageBox.Show("Connexion réussie");
                FrmAccueil Accueil = new FrmAccueil();
                Accueil.Show();
                this.Hide();
            }
            else
            {
                if (txtLoginConnexion.Text == "" || txtMdpConnexion.Text == "")
                {
                    MessageBox.Show("Veuillez saisir tous les champs demandés");
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite, vérifier votre identifiant et votre mot de passe");
                }
            }
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }

        //private void txtPlain_KeyPress(object sender, KeyPressEventArgs e) 
        //{
        //    if (e.KeyCode == Keys.Enter) 
        //    {
        //        int retourRequete;
        //        retourRequete = GestionUtilisateurs.verifUtilisateur(txtLoginConnexion.Text, txtMdpConnexion.Text);

        //        if (retourRequete == 1)
        //        {
        //            MessageBox.Show("Connexion réussie");
        //            FrmAccueil Accueil = new FrmAccueil();
        //            Accueil.Show();
        //            this.Hide();
        //        }
        //        else
        //        {
        //            if (txtLoginConnexion.Text == "" || txtMdpConnexion.Text == "")
        //            {
        //                MessageBox.Show("Veuillez saisir tous les champs demandés");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Une erreur s'est produite, vérifier votre identifiant et votre mot de passe");
        //            }
        //        }
        //    }
        //}
    }
}
