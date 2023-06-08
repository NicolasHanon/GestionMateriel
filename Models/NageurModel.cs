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
        public string Prénom1 { get => Prénom; set => Prénom = value; }
        public string Mail1 { get => Mail; set => Mail = value; }
        public string Téléphone1 { get => Téléphone; set => Téléphone = value; }

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
                Prénom1 = prénom;
                Mail1 = mail;
                Téléphone1 = téléphone;
            }
            public NageurModel()
            {
            }
    }
}