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

        public static Medicament GetMedicamentInfos(Medicament unMedicament)
        {
            int id = 0;
            bool archive = false;
            bool possedeVisite = false;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Id_medicament, Archive_medicament, PossedeVisite_medicament FROM MEDICAMENT WHERE Libelle_medicament = @leLibelle";

            cmd.Parameters.Add(new SqlParameter("@leLibelle", SqlDbType.NVarChar, 30));

            cmd.Parameters["@leLibelle"].Value = unMedicament.Libelle;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = int.Parse(monReader["Id_medicament"].ToString());
                archive = bool.Parse(monReader["Archive_medicament"].ToString());
                possedeVisite = bool.Parse(monReader["PossedeVisite_medicament"].ToString());
                // Création d'un objet Medicament
                
            }
            Medicament leMedicament = new Medicament(id, archive, possedeVisite);

            maConnexion.Close();
            return leMedicament;
        }

        public List<string> RecupererMedicaments() // Requête qui permet de récupérer les médicaments de la BDD
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Medicaments
            List<string> lesMedicaments = new List<string>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Id_medicament, Libelle_medicament FROM MEDICAMENT ORDER BY Libelle_medicament";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                // Ajout de chaque libellé dans la liste Box
                lesMedicaments.Add(monReader["Libelle_medicament"].ToString());
            }
            maConnexion.Close();
            return lesMedicaments;
        }

        public static int UpdateMedicament(Medicament unMedicament)
        {
            int nbEnr;

            // Connexion à la BD SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion(); 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            // Requête qui met à jour le médicament avec l'id passé en paramètre
            cmd.CommandText = "UPDATE MEDICAMENT SET [Libelle_medicament] = @leLibelle, [Archive_medicament] = @archive, [PossedeVisite_medicament] = @possedeVisite WHERE [Id_medicament] = @id";

            // Déclaration des paramètres nécessaire pour protéger la requête des injections SQL
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 30));
            cmd.Parameters.Add(new SqlParameter("@leLibelle", SqlDbType.NVarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@archive", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@possedeVisite", SqlDbType.Bit));

            cmd.Parameters["@id"].Value = unMedicament.Id;
            cmd.Parameters["@leLibelle"].Value = unMedicament.Libelle;
            cmd.Parameters["@archive"].Value = unMedicament.Archive;
            cmd.Parameters["@possedeVisite"].Value = unMedicament.PossedeVisite;

            nbEnr = cmd.ExecuteNonQuery();

            maConnexion.Close(); 

            return nbEnr;
        }

        public static int SupprimerMedicament(Medicament unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            // Requête qui supprime le médicament avec l'id passé en paramètre
            cmd.CommandText = "DELETE FROM MEDICAMENT WHERE [Id_medicament] = + @id";

            // Déclaration du paramètre @id pour protéger la requête des injections SQL
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 30));
            cmd.Parameters["@id"].Value = unMedicament.Id;

            nbEnr = cmd.ExecuteNonQuery();

            maConnexion.Close();

            return nbEnr;

        }
    }
}
