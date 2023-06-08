using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMatériel.Models;
using GestionMatériel.Tools;
using GestionMatériel.Forms;
using System.IO;

namespace GestionMatériel.DataAccess
{
    public class DAOAddCombi
    {
        public static void AjouterCombinaison(string Marque, string Nom, string Taille, string SaisonCombi)
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


                        CombinaisonMatérielClass combinaison = new CombinaisonMatérielClass();
                        combinaison.Id = returnValue;
                        combinaison.Marque = Marque;
                        combinaison.Nom = Nom;
                        combinaison.Taille = Taille;
                        combinaison.SaisonCombi = SaisonCombi;
                        using (SqlCommand sqlCommand = new SqlCommand("LP_AjouterCombinaison", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Ajoutez les paramètres nécessaires à la procédure stockée
                            sqlCommand.Parameters.Add("@pId", SqlDbType.VarChar).Value = combinaison.Id;
                            sqlCommand.Parameters.Add("@pMarque", SqlDbType.VarChar).Value = Marque;
                            sqlCommand.Parameters.Add("@pNom", SqlDbType.VarChar).Value = Nom;
                            sqlCommand.Parameters.Add("@pTaille", SqlDbType.VarChar).Value = Taille;
                            sqlCommand.Parameters.Add("@pSaisonCombi", SqlDbType.VarChar).Value = SaisonCombi;

                            sqlCommand.ExecuteNonQuery();
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Log.WriteLog(String.Concat("DAOAddCombi : Ajout d'une combinaison (Nom : " + Nom + ") "), w);
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
                    Log.WriteLog("DAOAddCombi : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
