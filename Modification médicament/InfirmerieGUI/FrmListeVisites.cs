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
    public partial class FrmListeVisites : Form
    {
        public FrmListeVisites()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGestionVisites Visite = new FrmGestionVisites();
            Visite.Show();
            this.Hide();
        }
    }
}
