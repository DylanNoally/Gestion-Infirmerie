using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfirmerieBO
{
    public class Medicament
    {
        private int id;
        private string libelle;
        private bool archive;
        private bool possedeVisite;

        // Constructeur qui instancie un objet
        public Medicament(int id, string libelle, bool archive, bool possedeVisite)
        {
            this.id = id;
            this.libelle = libelle;
            this.archive = archive;
            this.possedeVisite = possedeVisite;
        }

        public Medicament(int id, bool archive, bool possedeVisite)
        {
            this.id = id;
            this.archive = archive;
            this.possedeVisite = possedeVisite;
        }
        public Medicament(int id)
        {
            this.id = id;
        }

        public Medicament(string libelle)
        {
            this.libelle = libelle;
        }
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        
        public bool Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        
        public bool PossedeVisite
        {
            get { return possedeVisite; }
            set { possedeVisite = value; }
        }
    }
}
