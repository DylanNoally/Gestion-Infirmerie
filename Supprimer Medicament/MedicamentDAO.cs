using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfirmerieBO; // Référence à la couche BO
using System.Data.SqlClient;
using System.Data;

namespace InfirmerieDAL
{
    public class MedicamentDAO
    {
        private static MedicamentDAO unMedicamentDAO;

        // Accesseur en lecture, renvoi une instance
        public static MedicamentDAO GetUnMedicamentDAO()
        {
            if (unMedicamentDAO == null)
            {
                unMedicamentDAO = new MedicamentDAO();
            }
            return unMedicamentDAO;
        }

        public static int GetMedicament(Medicament unMedicament)
        {
            int resultRequete;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Medicament> lesMedicaments = new List<Medicament>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM MEDICAMENT WHERE Libelle_medicament = @leLibelle";

            cmd.Parameters.Add(new SqlParameter("@leLibelle", SqlDbType.NVarChar, 30));

            cmd.Parameters["@leLibelle"].Value = unMedicament.Libelle;

            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.HasRows)
            {
                resultRequete = 1;
            }
            else
            {
                resultRequete = 0;
            }
            maConnexion.Close();
            return resultRequete;
        }

        public static int GetMedicamentInfos(Medicament unMedicament)
        {
            int resultRequete;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Medicament> lesMedicaments = new List<Medicament>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Libelle_medicament, Archive_medicament, PossedeVisite_medicament FROM MEDICAMENT WHERE Libelle_medicament = @leLibelle";

            cmd.Parameters.Add(new SqlParameter("@leLibelle", SqlDbType.NVarChar, 30));

            cmd.Parameters["@leLibelle"].Value = unMedicament.Libelle;

            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.HasRows)
            {
                resultRequete = 1;
            }
            else
            {
                resultRequete = 0;
            }
            maConnexion.Close();
            return resultRequete;
        }

        public List<string> recupererMedicaments() // Requête qui permet de récupérer les médicaments de la BDD
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Medicaments
            List<string> lesMedicaments = new List<string>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Id_medicament, Libelle_medicament FROM MEDICAMENT";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                // Ajout de chaque libellé dans la liste Box
                lesMedicaments.Add(monReader["Libelle_medicament"].ToString());
            }
            maConnexion.Close();
            return lesMedicaments;
        }

        public static void SupprimerMedicament(int idMedicament)
        {

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE from MEDICAMENT where Id_medicament = " + idMedicament;
            int monReader = cmd.ExecuteNonQuery();
            maConnexion.Close();

        }
    }
}
