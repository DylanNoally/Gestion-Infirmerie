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
    public partial class FrmGestionMedicaments : Form
    {
        public FrmGestionMedicaments()
        {
            InitializeComponent();

            GestionMedicaments medicaments = new GestionMedicaments();
            List<string> lesMedicaments = new List<string>();
            lesMedicaments = medicaments.RecupererInfosMedicaments();
            listeMedicaments.DataSource = lesMedicaments;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmAccueil Accueil = new FrmAccueil();
            Accueil.Show();
            this.Hide();
        }

        private void btnCreerEleve_Click(object sender, EventArgs e)
        {
            FrmAjoutMedicament AjoutMedicament = new FrmAjoutMedicament();
            AjoutMedicament.Show();
            this.Hide();
        }

        private void listeMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string unMedicament = listeMedicaments.Text;
            FrmModifierMedicament ModifMedicament = new FrmModifierMedicament(unMedicament);
            ModifMedicament.Show();
            this.Hide();         
        }

        private void FrmGestionMedicaments_Load(object sender, EventArgs e)
        {

        }

        private void listeMedicaments_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
