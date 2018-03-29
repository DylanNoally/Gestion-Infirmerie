using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InfirmerieGUI
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void titreGestionInfirmerie_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Souhaitez-vous vraiment quitter l'application 'Gestion de l'infirmerie'", "Fermeture de l'application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit(); 
            }  
        }

        private void btnGestionEleves_Click(object sender, EventArgs e)
        {
            FrmGestionEleves GestionEleves = new FrmGestionEleves();
            GestionEleves.Show();
            this.Hide();
        }

        private void btnGestionVisites_Click(object sender, EventArgs e)
        {
            FrmGestionVisites GestionVisites = new FrmGestionVisites();
            GestionVisites.Show();
            this.Hide();
        }

        private void btnGestionClasses_Click(object sender, EventArgs e)
        {
            FrmGestionClasses GestionClasses = new FrmGestionClasses();
            GestionClasses.Show();
            this.Hide();
            // MessageBox.Show("Cette section est indisponible pour le moment");
        }

        private void btnGestionMedicaments_Click(object sender, EventArgs e)
        {
            FrmGestionMedicaments GestionMedicaments = new FrmGestionMedicaments();
            GestionMedicaments.Show();
            this.Hide();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette section est indisponible pour le moment");
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette section est indisponible pour le moment");
        }

        private void btnSauvegarde_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette section est indisponible pour le moment");
        }
    }
}
