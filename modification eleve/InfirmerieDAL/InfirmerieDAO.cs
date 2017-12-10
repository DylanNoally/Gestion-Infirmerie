using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfirmerieBO;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    public class InfirmerieDAO
    {
        private static InfirmerieDAO uneInfirmerieDAO;

        // Accesseur en lecture, renvoi une instance
        public static InfirmerieDAO GetuneInfirmerieDAO()
        {
            if (uneInfirmerieDAO == null)
            {
                uneInfirmerieDAO = new InfirmerieDAO();
            }
            return uneInfirmerieDAO;
        }

        // Méthode INSERT un nouvel élève passé en paramètre dans la BD
        public static int AjoutEleve(Eleve unEleve)
        {
            int nbEnr;

            // Connexion BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Eleve values('" ??? "')";

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture connexion
            maConnexion.Close();
            return nbEnr;
        }
        public static int UpdateEleve(Eleve unEleve)
        {
            int nbEnr;

            // Connexion à la BD SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion(); 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Eleve SET nom, prenom, naissance, sante, telEleve, telParent, archive, tierstemps, visite = '" + unEleve.Nom + unEleve.Prenom + unEleve.Naissance + unEleve.Sante + unEleve.TelEleve + unEleve.TelParent + unEleve.Archive + unEleve.Tierstemps + unEleve.Visite + "' WHERE Id = " + unEleve.Id;
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion maConnexion.Close(); 

            return nbEnr;
        }

    }
}
