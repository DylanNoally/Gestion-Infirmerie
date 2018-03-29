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
            DataTable lesMedicaments = new DataTable();
            lesMedicaments = medicaments.RecupererInfosMedicaments();
            listeMedicaments.DataSource = lesMedicaments;
            listeMedicaments.DisplayMember = "Libelle_medicament";
            listeMedicaments.ValueMember = "Id_medicament";
            
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
            int idMedicament = Convert.ToInt32(listeMedicaments.SelectedValue.ToString());
            FrmModifierMedicament ModifMedicament = new FrmModifierMedicament(idMedicament);
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
