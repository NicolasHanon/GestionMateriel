using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Models
{
    public class CombinaisonMatérielClass : MatérielClass
    {
        /// <summary>
        /// Taille de la combinaison de plongée.
        /// </summary>
        public string Taille { get; set; }

        /// <summary>
        /// Saison de la combinaison de plongée.
        /// </summary>
        public string SaisonCombi { get; set; }

        /// <summary>
        /// Retroune l'ID du matériel.
        /// </summary>
        /// <returns>Id</returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Retourne la marque du matériel.
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

        /// <summary>
        /// Retourne la date d'achat du matériel.
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateAchat()
        {
            return DateAchat;
        }
    }
}
