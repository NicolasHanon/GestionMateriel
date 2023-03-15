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
        private DateTime dateAchat;

        /// <summary>
        /// Id du matériel.
        /// </summary>
        protected int Id { get => id; set => id = value; }

        /// <summary>
        /// Marque du matériel.
        /// </summary>
        protected string Marque { get => marque; set => marque = value; }

        /// <summary>
        /// Nom du matériel.
        /// </summary>
        public string Nom { get => nom; set => nom = value; }

        /// <summary>
        /// Date d'achat du matériel.
        /// </summary>
        public DateTime DateAchat { get => dateAchat; set => dateAchat = value; }
    }
}
