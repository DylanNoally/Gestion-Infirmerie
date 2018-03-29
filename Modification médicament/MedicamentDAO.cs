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

            // Création d'une liste vide d'objets Medicaments
            List<Medicament> lesMedicaments = new List<Medicament>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM MEDICAMENT WHERE Id_medicament = @id_medic";

            cmd.Parameters.Add(new SqlParameter("@id_medic", SqlDbType.Int, 11));

            cmd.Parameters["@id_medic"].Value = unMedicament.Id;

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
            string libelle="";
            bool archive = false;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Id_medicament, Libelle_medicament, Archive_medicament FROM MEDICAMENT WHERE Id_medicament = @id";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 11));

            cmd.Parameters["@id"].Value = unMedicament.Id;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = int.Parse(monReader["Id_medicament"].ToString());
                libelle = monReader["Libelle_medicament"].ToString();
                archive = bool.Parse(monReader["Archive_medicament"].ToString());
                // Création d'un objet Medicament
                
            }
            Medicament leMedicament = new Medicament(id, libelle, archive);

            maConnexion.Close();
            return leMedicament;
        }

        public DataTable RecupererMedicaments() // Requête qui permet de récupérer les médicaments de la BDD
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            DataTable data = new DataTable();

            // Création d'une liste vide d'objets Medicaments
            List<string> lesMedicaments = new List<string>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Id_medicament, Libelle_medicament FROM MEDICAMENT ORDER BY Libelle_medicament";

            //SqlDataReader monReader = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(data);

            //while (monReader.Read())
            //{
                // Ajout de chaque libellé dans la liste Box
                //lesMedicaments.Add(monReader["Id_medicament"].ToString());
                //lesMedicaments.Add(monReader["Libelle_medicament"].ToString());
            //}
            maConnexion.Close();
            return data;
        }

        public static int AjoutMedic(Medicament unMedic)
        {
            int nbEnr;
            int archive = 0;

            if (unMedic.Archive == true)
            {
                archive = 1;
            }
            else
            {
                archive = 0;
            }
            // Connexion BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO MEDICAMENT values(@leLibelle, @archive);";

            // Déclaration des paramètres nécessaire pour protéger la requête des injections SQL
            cmd.Parameters.Add(new SqlParameter("@leLibelle", SqlDbType.NVarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@archive", SqlDbType.Bit));

            cmd.Parameters["@leLibelle"].Value = unMedic.Libelle;
            cmd.Parameters["@archive"].Value = archive;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int UpdateMedicament(Medicament unMedicament)
        {
            int nbEnr;

            // Connexion à la BD SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion(); 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            // Requête qui met à jour le médicament avec l'id passé en paramètre
            cmd.CommandText = "UPDATE MEDICAMENT SET [Libelle_medicament] = @leLibelle, [Archive_medicament] = @archive WHERE [Id_medicament] = @id";

            // Déclaration des paramètres nécessaire pour protéger la requête des injections SQL
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 30));
            cmd.Parameters.Add(new SqlParameter("@leLibelle", SqlDbType.NVarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@archive", SqlDbType.Bit));

            cmd.Parameters["@id"].Value = unMedicament.Id;
            cmd.Parameters["@leLibelle"].Value = unMedicament.Libelle;
            cmd.Parameters["@archive"].Value = unMedicament.Archive;

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
