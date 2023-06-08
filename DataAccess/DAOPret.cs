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
    public class DAOPret
    {
        /// <summary>
        /// Obtenir le stock complet
        /// </summary>
        /// <returns>Le stock</returns>
        public static List<PretModel> GetAllPrets()
        {
            List<PretModel> prets = new List<PretModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("ProcedureVoirPret", connection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {


                            while (sqlDataReader.Read())
                            {
                                PretModel pret = new PretModel();
                                pret.Id = (int)sqlDataReader["Id"];
                                pret.DateEmprunt = (DateTime)sqlDataReader["DateEmprunt"];
                                pret.DateRetour = (DateTime)sqlDataReader["DateRetourPret"];
                                NageurModel nageur = new NageurModel();
                                nageur.Nom = (string)sqlDataReader["Nom"];
                                pret.Nageur = nageur;
                                MatérielClass matériel = new MatérielClass();
                                matériel.Nom = (string)sqlDataReader["Materiel_Prêté"];
                                pret.Matériel = matériel;
                                prets.Add(pret);
                            }
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Log.WriteLog(String.Concat("DAOPret : Affichage des prets"), w);
                            }
                        }
                        else
                        {
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Log.WriteLog(String.Concat(String.Concat("DAOPret : Erreur")), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DAOPret : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return prets;
        }
    }
}
