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
    public partial class FrmAjoutEleve : Form
    {
        public FrmAjoutEleve()
        {
            InitializeComponent();
            // Récupération de la chaine de connexion à la BD à l'ouverture du formulaire
            GestionInfirmerie.SetChaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void FrmAjoutEleve_Load(object sender, EventArgs e)
        {

        }

        private void textNomEleve_TextChanged(object sender, EventArgs e)
        {
            if (textNomEleve.Text == string.Empty)
            {
                btnEnregistrer.Enabled = false;
            }
            else
            {
                btnEnregistrer.Enabled = true;
            }
        }

        private void textPrenomEleve_TextChanged(object sender, EventArgs e)
        {
            if (textPrenomEleve.Text == string.Empty)
            {
                btnEnregistrer.Enabled = false;
            }
            else
            {
                btnEnregistrer.Enabled = true;
            }
        }

        private void textTelParent_TextChanged(object sender, EventArgs e)
        {
            if (textTelParent.Text == string.Empty)
            {
                btnEnregistrer.Enabled = false;
            }
            else
            {
                btnEnregistrer.Enabled = true;
            }
        }

        private void textTelEleve_TextChanged(object sender, EventArgs e)
        {
            if (textTelEleve.Text == string.Empty)
            {
                btnEnregistrer.Enabled = false;
            }
            else
            {
                btnEnregistrer.Enabled = true;
            }
        }

        private void richTextCom_TextChanged(object sender, EventArgs e)
        {
            if (richTextCom.Text == string.Empty)
            {
                btnEnregistrer.Enabled = false;
            }
            else
            {
                btnEnregistrer.Enabled = true;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Appel de la méthode CreerEleve de la couche BLL
            // GestionInfirmerie.CreerEleve(textNomEleve.Text, textPrenomEleve.Text, textNaissance.Text, textTelEleve.Text, textTelParent.Text, richTextCom.Text, checkArchive.Checked, checkTT.Checked, checkVisite.Checked, listClasseEleve.DataSource);

            // Message de dialogue qui confirme l'enregistrement en BD
            MessageBox.Show("Enregistrement de l'élève effectué !", "Saisie");

            // Effacement de la valeur saisie après enregistrement
            textNomEleve.Clear();
            textPrenomEleve.Clear();
            textNaissanceEleve.Clear();
            textTelEleve.Clear();
            textTelParent.Clear();
            richTextCom.Clear();
            checkTT.Checked = false;

            FrmAccueil Accueil = new FrmAccueil();
            Accueil.Show();
            this.Hide();

        }



        private void checkTT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTT.Checked == true)
            {
                btnEnregistrer.Enabled = true;
            }
            else
            {
                btnEnregistrer.Enabled = false;
            }
        }

        private void listClasseEleve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNaissance_TextChanged(object sender, EventArgs e)
        {
            if (textNaissanceEleve.Text == string.Empty)
            {
                btnEnregistrer.Enabled = false;
            }
            else
            {
                btnEnregistrer.Enabled = true;
            }
        }

        //private void checkArchive_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkArchive.Checked == false)
        //    {
        //        btnEnregistrer.Enabled = true;
        //    }
        //    else
        //    {
        //        btnEnregistrer.Enabled = false;
        //    }
        //}

        //private void checkVisite_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkVisite.Checked == false)
        //    {
        //        btnEnregistrer.Enabled = true;
        //    }
        //    else
        //    {
        //        btnEnregistrer.Enabled = false;
        //    }
        //}

        //private void listClasseEleve_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (listClasseEleve.DataSource == string.Empty)
        //    {
        //        btnEnregistrer.Enabled = false;
        //    }
        //    else
        //    {
        //        btnEnregistrer.Enabled = true;
        //    }
        //}

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmAccueil Accueil = new FrmAccueil();
            Accueil.Show();
            this.Hide();
        }
    }
}
