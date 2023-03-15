using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Models
{
    public class MonopalmeMatérielClass : MatérielClass
    {
        /// <summary>
        /// Type de Monopalme.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Pointure du Monopalme.
        /// </summary>
        public string poiture { get; set; }

        /// <summary>
        /// Obtenir l'id du monopalme.
        /// </summary>
        /// <returns>ID</returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Obtenir la marque du monopalme
        /// </summary>
        /// <returns>Marque</returns>
        public string GetMarque()
        {
            return Marque;
        }

        /// <summary>
        /// Retourne le nom du matériel.
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return Nom;
        }
    }
}
