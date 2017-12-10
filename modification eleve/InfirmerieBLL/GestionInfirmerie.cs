using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using InfirmerieDAL;
using InfirmerieBO;

namespace InfirmerieBLL
{
    public class GestionInfirmerie
    {
        private static GestionInfirmerie uneGestionInfirmerie; // Objet BLL

        // Accesseur en lecture
        public static GestionInfirmerie GetGestionInfirmerie()
        {
            if (uneGestionInfirmerie == null)
            {
                uneGestionInfirmerie = new GestionInfirmerie();
            }
            return uneGestionInfirmerie;
        }

        // Définit la chaine de connexion grâce à la méthode SetChaineConnexion de la DAL
        public static void SetChaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui créer un nouvel élève à partir de ses attributs et qui le renvoi en l'ajoutant à la BD avec la méthode AjoutEleve de la DAL
        public static int CreerEleve(????)
        {
            Eleve el;
            el = new Eleve(????);
            return InfirmerieDAO.AjoutEleve(el);
        }

        public static int ModifierEleve(int id, string nom, string prenom, DateTime naissance, string sante, string telEleve, string telParent, bool archive, bool tierstemps, bool visite)
        {
            Eleve el; el = new Eleve(id, nom, prenom, naissance, sante, telEleve, telParent, archive, tierstemps, visite);
            return InfirmerieDAO.UpdateEleve(el);
        }
    }
}
