﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using InfirmerieBO; // Référence la couche BO
using InfirmerieDAL; // Référence la couche DAL

namespace InfirmerieBLL
{
    public class GestionMedicaments
    {
        private static GestionMedicaments uneGestionMedicaments; // objet BLL

        // Accesseur en lecture
        public static GestionMedicaments GetGestionUtilisateurs()
        {
            if (uneGestionMedicaments == null)
            {
                uneGestionMedicaments = new GestionMedicaments();
            }
            return uneGestionMedicaments;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetChaineConnexion(chaine);
        }

        // Méthode qui renvoie un objet Medicament en faisant appel à la méthode GetMedicaments() de la DAL
        public static int VerifMedicament(string libelle)
        {
            Medicament unMedicament = new Medicament(libelle);

            return MedicamentDAO.GetMedicament(unMedicament);
        }

        
        public List<string> RecupererInfosMedicaments()
        {
            List<string> lesMedicaments = new List<string>();
            MedicamentDAO infosMedicament = new MedicamentDAO();
            lesMedicaments = infosMedicament.RecupererMedicaments();
            return lesMedicaments;
        }

        // Méthode qui renvoit un objet Medicament en faisant appel à la méthode GetMedicaments() de la DAL
        public static Medicament ExtractInfosMedicament(string libelle)
        {
            Medicament unMedicament = new Medicament(libelle);
            
            return MedicamentDAO.GetMedicamentInfos(unMedicament);
        }

        // Méthode qui renvoit un objet Medicament en faisant appel à la méthode ModifierMedicament() de la DAL
        public static int ModifierMedicament(int id, string nom, bool archive, bool possedeVisite)
        {
            Medicament leMedicament = new Medicament(id, nom, archive, possedeVisite);

            return MedicamentDAO.UpdateMedicament(leMedicament);
        }

        // Méthode qui renvoit un objet Medicament en faisant appel à la méthode SuppressionMedicament() de la DAL
        public static int SuppressionMedicament(int idMedicament)
        {

            Medicament leMedicament = new Medicament(idMedicament);

            return MedicamentDAO.SupprimerMedicament(leMedicament);
        }
    }
}
