using GestionMatériel.Models;
using GestionMatériel.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.DataAccess
{
    internal class DAOMonopalme
    {
        public static void AjouterMonopalme(string Marque, string Nom, string TypeMono, string Pointure)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                {
                    using (SqlCommand fonction = new SqlCommand("getMaxID", connection))
                    {
                        fonction.CommandType = System.Data.CommandType.StoredProcedure;

                        // Exécutez la procédure stockée
                        SqlParameter returnValueParam = fonction.Parameters.Add("@ReturnValue", SqlDbType.Int);
                        returnValueParam.Direction = ParameterDirection.ReturnValue;

                        fonction.ExecuteNonQuery();

                        // Récupérer la valeur de retour
                        int returnValue = (int)returnValueParam.Value;


                        MonopalmeMatérielClass monopalme = new MonopalmeMatérielClass();
                        monopalme.Id = returnValue;
                        monopalme.Marque = Marque;
                        monopalme.Nom = Nom;
                        monopalme.Type = TypeMono;
                        monopalme.Pointure = Pointure;
                        using (SqlCommand sqlCommand = new SqlCommand("LP_AjouterMonopalme", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Ajoutez les paramètres nécessaires à la procédure stockée
                            sqlCommand.Parameters.Add("@pId", SqlDbType.VarChar).Value = monopalme.Id;
                            sqlCommand.Parameters.Add("@pMarque", SqlDbType.VarChar).Value = Marque;
                            sqlCommand.Parameters.Add("@pNom", SqlDbType.VarChar).Value = Nom;
                            sqlCommand.Parameters.Add("@pTypeMono", SqlDbType.VarChar).Value = TypeMono;
                            sqlCommand.Parameters.Add("@pPointure", SqlDbType.VarChar).Value = Pointure;

                            sqlCommand.ExecuteNonQuery();
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Log.WriteLog(String.Concat("DAOAddCombi : Ajout d'une Monopalme (Nom : " + Nom + ") "), w);
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
        }
    }
}
