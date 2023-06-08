using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Models
{
    public class MatérielClass
    {
        private int id;
        private string marque;
        private string nom;

        /// <summary>
        /// Id du matériel.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Marque du matériel.
        /// </summary>
        public string Marque { get; set; }

        /// <summary>
        /// Nom du matériel.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Constructeur de la classe MatérielClass.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marque"></param>
        /// <param name="nom"></param>
        public MatérielClass(int id, string marque, string nom)
        {
            Id = id;
            Marque = marque;
            Nom = nom;
        }

        public MatérielClass()
        {

        }

        public string GetNom()
        {
            return Nom;
        }
    }
}