using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMatériel.Models;
using GestionMatériel.Tools;
using System.IO;

namespace GestionMatériel.DataAccess
{
    public class DAOAddCombi
    {
        public void AjouterCombinaison(string Id, string Marque, string Nom, string Taille, string SaisonCombi)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_AjouterCombinaison", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Ajoutez les paramètres nécessaires à la procédure stockée
                    sqlCommand.Parameters.Add("@pId", SqlDbType.VarChar).Value = Id;
                    sqlCommand.Parameters.Add("@pMarque", SqlDbType.VarChar).Value = Marque;
                    sqlCommand.Parameters.Add("@pNom", SqlDbType.VarChar).Value = Nom;
                    sqlCommand.Parameters.Add("@pTaille", SqlDbType.VarChar).Value = Taille;
                    sqlCommand.Parameters.Add("@pSaisonCombi", SqlDbType.VarChar).Value = SaisonCombi;

                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                    {
                        Log.WriteLog(String.Concat("DAOAddCombi : Ajout d'une combinaison (ID : "+ Id + ") "), w);
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
        }
    }
}
