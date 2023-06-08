using GestionMatériel.Models;
using GestionMatériel.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.DataAccess
{
    internal class DAONageur
    {
        public static List<NageurModel> GetAllNageurs()
        {
            List<NageurModel> nageurs = new List<NageurModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("ProcedureVoirNageur", connection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                NageurModel nageur = new NageurModel();
                                nageur.Id1 = (int)sqlDataReader["Id"];
                                nageur.Nom = (string)sqlDataReader["Nom"];
                                nageur.Prénom1 = (string)sqlDataReader["Prénom"];
                                nageur.Mail1 = (string)sqlDataReader["mail"];
                                nageur.Téléphone1 = (string)sqlDataReader["telephone"];
                                nageurs.Add(nageur);
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
            return nageurs;
        }
    }
}
