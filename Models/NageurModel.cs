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
        /// <summary>
        /// Id du nageur.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom du nageur.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du nageur.
        /// </summary>
        public string Prénom { get; set; }

        /// <summary>
        /// Mail du nageur.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Téléphone du nageur.
        /// </summary>
        public string Téléphone { get; set; }

    }
}
