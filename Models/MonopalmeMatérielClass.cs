using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Models
{
    public class MonopalmeMatérielClass : MatérielClass
    {
        private string type;
        private string pointure;

        /// <summary>
        /// Type de la monopalme.
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// Pointure de la monopalme.
        /// </summary>
        public string Pointure
        {
            get { return pointure; }
            set { pointure = value; }
        }

        /// <summary>
        /// Obtenir l'id de la monopalme.
        /// </summary>
        /// <returns>ID</returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Obtenir la marque de la monopalme
        /// </summary>
        /// <returns>Marque</returns>
        public string GetMarque()
        {
            return Marque;
        }

        /// <summary>
        /// Retourne le nom de la monopalme.
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return Nom;
        }

        /// <summary>
        /// Constructeur de la classe MonopalmeMatérielClass.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marque"></param>
        /// <param name="nom"></param>
        /// <param name="type"></param>
        /// <param name="pointure"></param>
        public MonopalmeMatérielClass(int id, string marque, string nom, string type, string pointure)
            : base(id, marque, nom)
        {
            Type = type;
            Pointure = pointure;
        }

        public MonopalmeMatérielClass()
        {

        }
    }
}