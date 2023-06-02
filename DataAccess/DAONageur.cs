﻿using System;
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
        /// Obtenir le conseiller qui s'est connecté
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>L'objet Conseiller qui s'est connecté</returns>
        public static NageurModel GetAllNageur(int idNageur)
        {
            NageurModel nageur = new NageurModel();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("sp_authentification", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pLogin", SqlDbType.NVarChar).Value = login;
                    sqlCommand.Parameters.Add("@pPassword", SqlDbType.VarBinary).Value = password;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            sqlDataReader.Read();
                            nageur.ID = sqlDataReader.GetInt32(0);
                            nageur.Nom = sqlDataReader.GetString(1);
                            nageur.Prénom = sqlDataReader.GetString(2);
                            nageur.mail = sqlDataReader.GetString(3);
                            nageur.telephone = sqlDataReader.GetString(4);
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
            return nageur;
        }

        /// <summary>
        /// Obtenir tous les clients d'un conseiller financier.
        /// </summary>
        /// <param name="idConseiller"></param>
        /// <returns>Liste de tous les clients</returns>
        public static List<ClientModel> GetAllClients(int idConseiller)
        {
            List<ClientModel> clients = new List<ClientModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("spClient_GetByConseiller", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pIdConseiller", SqlDbType.Int).Value = idConseiller;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ClientModel clientModel = new ClientModel();
                            clientModel.Id = sqlDataReader.GetInt32(0);
                            clientModel.Nom = sqlDataReader.GetString(1);
                            clientModel.Prenom = sqlDataReader.GetString(2);
                            clientModel.Mobile = sqlDataReader.GetString(3);
                            clientModel.Mail = sqlDataReader.GetString(4);
                            clients.Add(clientModel);
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
            return clients;
        }


        public static List<CompteModel> GetAllComptes(int idClient)
        {
            //La liste créée est une liste de Compte (et non de CompteCourant ou de CompteEpargne)
            List<CompteModel> comptes = new List<CompteModel>();
            SqlConnection connection = null;
            //SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("spCompte_GetByClient", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pIdClient", SqlDbType.Int).Value = idClient;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            //Si le type de compte est null (colonne 4 de la requête), alors il s'agit d'un compte courant
                            if (sqlDataReader.IsDBNull(3))
                            {
                                CompteCourantModel compteCourantModel = new CompteCourantModel();
                                compteCourantModel.SetId(sqlDataReader.GetInt32(0));
                                //Le solde du compte est stocké en decimal dans la DB. Il faut le convertir en double.
                                compteCourantModel.SetSolde(decimal.ToDouble(sqlDataReader.GetDecimal(1)));
                                //Le découvert du compte est stocké en decimal dans la DB. Il faut le convertir en double.
                                compteCourantModel.Decouvert = decimal.ToDouble(sqlDataReader.GetDecimal(2));
                                //Bien que l'objet soit un CompteCourant, on peut l'ajouter dans la liste de Compte,
                                //Car un CompteCourant "est un" Compte.
                                comptes.Add(compteCourantModel);
                            }
                            else
                            {
                                CompteEpargneModel compteEpargneModel = new CompteEpargneModel();
                                compteEpargneModel.SetId(sqlDataReader.GetInt32(0));
                                //Le solde du compte est stocké en decimal dans la DB. Il faut le convertir en double.
                                compteEpargneModel.SetSolde(decimal.ToDouble(sqlDataReader.GetDecimal(1)));
                                compteEpargneModel.Type = sqlDataReader.GetString(3);
                                //Le taux d'interets est stocké en décimal dans la DB. Il faut le convertir en double.
                                compteEpargneModel.Taux = decimal.ToDouble(sqlDataReader.GetDecimal(4));
                                //Bien que l'objet soit un CompteEpargne, on peut l'ajouter dans la liste de Compte,
                                //Car un CompteEpargne "est un" Compte.
                                comptes.Add(compteEpargneModel);
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
            return comptes;
        }
    }
}

