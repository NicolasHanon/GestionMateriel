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
        public class NageurModel
        {
            private int Id;
            public string Nom { get; set; }
            private string Prénom;
            private string Mail;
            private string Téléphone;

            public int Id1 { get => Id; set => Id = value; }
            public string Nom1 { get => Nom; set => Nom = value; }

            /// <summary>
            /// Id du nageur.
            /// </summary>
            /// <returns></returns>
            public int GetId()
            {
                return Id1;
            }
            /// <summary>
            /// Modifier l'id du nageur.
            /// </summary>
            /// <param name="id"></param>
            public void SetId(int id)
            {
                Id1 = id;
            }

            /// <summary>
            /// Nom du nageur.
            /// </summary>
            /// <returns></returns>
            public string GetNom()
            {
                return Nom1;
            }

            /// <summary>
            /// Modifier le nom du nageur.
            /// </summary>
            /// <param name="nom"></param>
            public void SetNom(string nom)
            {
                Nom1 = nom;
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
                Id1 = id;
                Nom1 = nom;
                Prénom = prénom;
                Mail = mail;
                Téléphone = téléphone;
            }
            public NageurModel()
            {
            }
    }
}