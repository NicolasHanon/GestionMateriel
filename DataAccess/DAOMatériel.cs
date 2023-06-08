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
        public static List<CombinaisonMatérielClass> GetAllStock()
        {
            List<CombinaisonMatérielClass> materiels = new List<CombinaisonMatérielClass>();
            List<MonopalmeMatérielClass> materielsmono = new List<MonopalmeMatérielClass>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("ProcedureVoirStock", connection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                CombinaisonMatérielClass materiel = new CombinaisonMatérielClass();
                                MonopalmeMatérielClass materielmono = new MonopalmeMatérielClass();
                                materiel.Marque = (string)sqlDataReader["Marque"];
                                materiel.Nom = (string)sqlDataReader["Nom"];
                                materiel.Taille = sqlDataReader["Taille"] == DBNull.Value ? "" : (string)sqlDataReader["Taille"];
                                materiel.SaisonCombi = sqlDataReader["SaisonCombi"] == DBNull.Value ? "" : (string)sqlDataReader["SaisonCombi"];
                                materiels.Add(materiel);
                            }
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Log.WriteLog(String.Concat("DAOMatériel : Affichage du matériel"), w);
                            }
                        }
                        else
                        {
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Log.WriteLog(String.Concat(String.Concat("DAOMatériel : Erreur")), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
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
        public static List<MonopalmeMatérielClass> GetAllStockmono()
        {
            List<MonopalmeMatérielClass> materielsmono = new List<MonopalmeMatérielClass>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("ProcedureVoirStock", connection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                MonopalmeMatérielClass materielmono = new MonopalmeMatérielClass(); 
                                materielmono.Marque = (string)sqlDataReader["Marque"];
                                materielmono.Nom = (string)sqlDataReader["Nom"];
                                materielmono.Type = sqlDataReader["TypeMono"] == DBNull.Value ? "" : (string)sqlDataReader["TypeMono"];
                                materielmono.Pointure = sqlDataReader["Pointure"] == DBNull.Value ? "" : (string)sqlDataReader["Pointure"];
                                materielsmono.Add(materielmono);
                            }
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Log.WriteLog(String.Concat("DAOMatériel : Affichage du matériel"), w);
                            }
                        }
                        else
                        {
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Log.WriteLog(String.Concat(String.Concat("DAOMatériel : Erreur")), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Log.WriteLog("DAOMatériel : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return materielsmono;
        }

    }
}

