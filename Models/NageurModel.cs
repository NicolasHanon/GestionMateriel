using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Models
{
    /// <summary>
    /// Auteur : N. Hanon.
    /// Date de création : 15/03/2022
    /// Modélise un Nageur de LyonPalme.
    /// </summary>
    namespace GestionMatériel.Models
    {
        public class NageurModel
        {
            private int Id;
            private string Nom;
            private string Prénom;
            private string Mail;
            private string Téléphone;
            
            /// <summary>
            /// Id du nageur.
            /// </summary>
            /// <returns></returns>
            public int GetId()
            {
                return Id;
            }
            /// <summary>
            /// Modifier l'id du nageur.
            /// </summary>
            /// <param name="id"></param>
            public void SetId(int id)
            {
                Id = id;
            }

            /// <summary>
            /// Nom du nageur.
            /// </summary>
            /// <returns></returns>
            public string GetNom()
            {
                return Nom;
            }

            /// <summary>
            /// Modifier le nom du nageur.
            /// </summary>
            /// <param name="nom"></param>
            public void SetNom(string nom)
            {
                Nom = nom;
            }
            
            /// <summary>
            /// Prénom du nageur.
            /// </summary>
            /// <returns></returns>
            public string GetPrénom()
            {
                return Prénom;
            }

            /// <summary>
            /// Modifier le prénom du nageur.
            /// </summary>
            /// <param name="prénom"></param>
            public void SetPrénom(string prénom)
            {
                Prénom = prénom;
            }

            /// <summary>
            /// Mail du nageur.
            /// </summary>
            /// <returns></returns>
            public string GetMail()
            {
                return Mail;
            }

            /// <summary>
            /// Modifier le mail du nageur.
            /// </summary>
            /// <param name="mail"></param>
            public void SetMail(string mail)
            {
                Mail = mail;
            }

            /// <summary>
            /// Téléphone du nageur.
            /// </summary>
            /// <returns></returns>
            public string GetTéléphone()
            {
                return Téléphone;
            }

            /// <summary>
            /// Modifier le téléphone du nageur.
            /// </summary>
            /// <param name="téléphone"></param>
            public void SetTéléphone(string téléphone)
            {
                Téléphone = téléphone;
            }
            
            /// <summary>
            /// Constructeur de la classe NageurModel.
            /// </summary>
            /// <param name="id"></param>
            /// <param name="nom"></param>
            /// <param name="prénom"></param>
            /// <param name="mail"></param>
            /// <param name="téléphone"></param>
            public NageurModel(int id, string nom, string prénom, string mail, string téléphone)
            {
                Id = id;
                Nom = nom;
                Prénom = prénom;
                Mail = mail;
                Téléphone = téléphone;
            }
        }
    }
}