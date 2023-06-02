using System;
using System.Collections.Generic;
using GestionMatériel.Models;
using System.Data.SqlClient;
using System.IO;
using GestionMatériel.Tools;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GestionMatériel.DataAccess
{
    /// <summary>
    /// Gère l'interface entre la base de données et la couche présentation.
    /// </summary>
    public class DAOMatériel
    {
        /// <summary>
        /// Obtenir le stock complet
        /// </summary>
        /// <returns>Le stock</returns>
        public static List<MatérielClass> GetAllStock()
        {
            List<MatérielClass> materiels = new List<MatérielClass>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                string query = "SELECT * FROM LP_Matériel";
                using (SqlCommand commande = new SqlCommand(query, connection))
                {
                    using (SqlDataReader sqlDataReader = commande.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                MatérielClass materiel = new MatérielClass();
                                // Effectuez le mapping des colonnes du résultat de la requête dans les propriétés de l'objet materiel
                                materiel.Id = (int)sqlDataReader["Id"];
                                materiel.Marque = (string)sqlDataReader["Marque"];
                                materiel.Nom = (string)sqlDataReader["Nom"];
                                materiels.Add(materiel);
                            }
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Log.WriteLog(String.Concat("DAOMatériel : Affichage du matériel"), w);
                            }
                        }
                        else
                        {
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Log.WriteLog(String.Concat(String.Concat("DAOMatériel : Erreur")), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DAOMatériel : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return materiels;
        }
    }
}

