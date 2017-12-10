using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfirmerieBO
{
    public class Eleve
    {
        // Attributs d'un élève
        private int Id_eleve;
        private string Nom_eleve;
        private string Prenom_eleve;
        private DateTime DateNaissance_eleve;
        private string Sante_eleve;
        private string Tel_eleve;
        private string TelParents_eleve;
        private bool Archive_eleve;
        private bool PossedeTiersTempsExam;
        private bool PossedeVisite;

        // Constructeur
        public Eleve(int id, string nom, string prenom, DateTime naissance, string sante, string telEleve, string telParent, bool archive, bool tierstemps, bool visite)
        {
            this.Id_eleve = id;
            this.Nom_eleve = nom;
            this.Prenom_eleve = prenom;
            this.DateNaissance_eleve = naissance;
            this.Sante_eleve = sante;
            this.Tel_eleve = telEleve;
            this.TelParents_eleve = telParent;
            this.Archive_eleve = archive;
            this.PossedeTiersTempsExam = tierstemps;
            this.PossedeVisite = visite;
        }

        // Propriété Id
        public int Id
        {
            get { return Id_eleve; }
            set { Id_eleve = value; }
        }

        // Propriété Nom
        public string Nom
        {
            get { return Nom_eleve; }
            set { Nom_eleve = value; }
        }

        // Propriété Prénom
        public string Prenom
        {
            get { return Prenom_eleve; }
            set { Prenom_eleve = value; }
        }

        // Propriété Date de naissance
        public DateTime Naissance
        {
            get { return DateNaissance_eleve; }
            set { DateNaissance_eleve = value; }
        }

        // Propriété Santé
        public string Sante
        {
            get { return Sante_eleve; }
            set { Sante_eleve = value; }
        }

        // Propriété Téléphone Eleve
        public string TelEleve
        {
            get { return TelParents_eleve; }
            set { TelParents_eleve = value; }
        }

        // Propriété Téléphone Parent
        public string TelParent
        {
            get { return Tel_eleve; }
            set { Tel_eleve = value; }
        }

        // Propriété Archive Eleve
        public bool Archive
        {
            get { return Archive_eleve; }
            set { Archive_eleve = value; }
        }

        // Propriété Tiers temps
        public bool Tierstemps
        {
            get { return PossedeTiersTempsExam; }
            set { PossedeTiersTempsExam = value; }
        }

        // Propriété Visite
        public bool Visite
        {
            get { return PossedeVisite; }
            set { PossedeVisite = value; }
        }

        // Modifier éléve
        

    }
}
