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
    public partial class FrmGestionClasses : Form
    {
        public FrmGestionClasses()
        {
            InitializeComponent();

            GestionClasses classes = new GestionClasses();
            DataTable lesClasses = new DataTable();
            lesClasses = classes.RecupererInfosClasses();
            listeClasses.DataSource = lesClasses;
            listeClasses.DisplayMember = "Libelle_classe";
            listeClasses.ValueMember = "Id_classe";
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmAccueil Accueil = new FrmAccueil();
            Accueil.Show();
            this.Hide();
        }

        private void titreGestionInfirmerie_Click(object sender, EventArgs e)
        {

        }

        private void btnCreerClasse_Click(object sender, EventArgs e)
        {

        }
    }
}
