using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionmateriel.Models;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using gestionmateriel.Tools;

namespace CreditSio.DataAccess
{
    /// <summary>
    /// Gère l'interface entre la base de données et la couche présentation.
    /// </summary>
    public class DAONageur
    {
        /// <summary>
        /// Obtenir le stock complet
        /// </summary>
        /// <returns>Le stock</returns>
        public static List<MaterielClass> GetAllStock()
        {
            List<MaterielClass> materiels = new List<MaterielClass>();
            SqlConnection connection = null;
            try
            {
                string connection = Connection.getInstance().GetConnection();
                string query = "SELECT * FROM vLP_VoirStock";
                sqlCommand commande = new sqlCommand(query, connection);
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                MaterielClass materiel = new MaterielClass();
                                // Effectuez le mapping des colonnes du résultat de la requête dans les propriétés de l'objet materiel
                                materiel.ID = (int)reader["ID"];
                                materiel.marque = (string)reader["marque"];
                                materiel.Nom = (string)reader["Nom"];
                                materiel.Taille = (string)reader["Taille"];
                                materiel.saisonCombi = (string)reader["saisonCombi"];
                                materiel.TypeMono = (string)reader["TypeMono"];
                                materiel.poiture = (string)reader["poiture"];
                                materiels.Add(materiel);
                            }
                            reader.Close();
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Log.WriteLog(String.Concat("DBInterface : l'utilisateur ", login, " vient de se connecter"), w);
                            }
                        }
                        else
                        {
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Log.WriteLog(String.Concat(String.Concat("DBInterface : identifiants de connexion invalide. Login :", login)), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
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

