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
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Log.WriteLog(String.Concat("DAOPret : Affichage des prets"), w);
                            }
                        }
                        else
                        {
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Log.WriteLog(String.Concat(String.Concat("DAOPret : Erreur")), w);
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
                    Log.WriteLog("DAOPret : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return prets;
        }

        public static void AddPret(DateTime DateEmprunt, DateTime DateRetour, string ID_1, string ID_2)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_AjouterUnPret", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    PretModel pret = new PretModel();
                    pret.DateEmprunt = DateEmprunt;
                    pret.DateRetour = DateRetour;
                    NageurModel nageur = new NageurModel();
                    nageur.Id1 = Convert.ToInt32(ID_1);
                    pret.Nageur = nageur;
                    MatérielClass matériel = new MatérielClass();
                    matériel.Id = Convert.ToInt32(ID_2);
                    pret.Matériel = matériel;
                    sqlCommand.Parameters.Add(new SqlParameter("@pDateEmprunt", pret.DateEmprunt));
                    sqlCommand.Parameters.Add(new SqlParameter("@pDateRetourPret", pret.DateRetour));
                    sqlCommand.Parameters.Add(new SqlParameter("@pID1", pret.Nageur.Id1));
                    sqlCommand.Parameters.Add(new SqlParameter("@pID2", pret.Matériel.Id));
                    sqlCommand.ExecuteNonQuery();
                    string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                    using (StreamWriter w = File.AppendText(logErrorFilePath))
                    {
                        Log.WriteLog(String.Concat("DAOPret : Ajout d'un pret"), w);
                    }
                }
            }
            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Log.WriteLog("DAOPret : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
        }  
        
        public static void RecupPret(int Id)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_RecupMaterielPret", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    PretModel pret = new PretModel();
                    pret.Id = Id;
                    sqlCommand.Parameters.Add("@pId", SqlDbType.VarChar).Value = Id;
                    sqlCommand.ExecuteNonQuery();
                    string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                    using (StreamWriter w = File.AppendText(logErrorFilePath))
                    {
                        Log.WriteLog(String.Concat("DAOPret : Suppression d'un pret"), w);
                    }
                }
            }
            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Log.WriteLog("DAOPret : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
