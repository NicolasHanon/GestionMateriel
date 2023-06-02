using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Models
{
    public class CombinaisonMatérielClass : MatérielClass
    {
        private string taille;
        private string saisonCombi;

        /// <summary>
        /// Taille de la Combinaison.
        /// </summary>
        public string Taille
        {
            get { return taille; }
            private set { taille = value; }
        }
        
        /// <summary>
        /// Saison de la Combinaison.
        /// </summary>
        public string SaisonCombi
        {
            get { return saisonCombi; }
            private set { saisonCombi = value; }
        }

        /// <summary>
        /// Obtenir l'id de la combinaison.
        /// </summary>
        /// <returns>ID</returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Obtenir la marque de la combinaison
        /// </summary>
        /// <returns>Marque</returns>
        public string GetMarque()
        {
            return Marque;
        }

        /// <summary>
        /// Retourne le nom de la combinaison.
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return Nom;
        }

        /// <summary>
        /// Constructeur de la classe CombinaisonMatérielClass.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marque"></param>
        /// <param name="nom"></param>
        /// <param name="taille"></param>
        /// <param name="saisonCombi"></param>
        public CombinaisonMatérielClass(int id, string marque, string nom, string taille, string saisonCombi)
            : base(id, marque, nom)
        {
            Taille = taille;
            SaisonCombi = saisonCombi;
        }
    }
}