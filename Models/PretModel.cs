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
    /// Modélise un Prêt de matériel pour un Nageur de LyonPalme.
    /// </summary>
    public class PretModel
    {
        private int Id;
        private DateTime DateEmprunt;
        private DateTime DateRetour;
        private NageurModel Nageur;
        private MatérielClass Matériel;

        /// <summary>
        /// Id du prêt.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date d'emprunt du matériel.
        /// </summary>
        public DateTime DateEmprunt { get; set; }

        /// <summary>
        /// Date de retour prévue du matériel.
        /// </summary>
        public DateTime DateRetour { get; set; }

        /// <summary>
        /// Nageur associé au prêt.
        /// </summary>
        public NageurModel Nageur { get; set; }

        /// <summary>
        /// Matériel prêté.
        /// </summary>
        public MatérielClass Matériel { get; set; }

        /// <summary>
        /// Constructeur de la classe PretModel.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dateEmprunt"></param>
        /// <param name="dateRetour"></param>
        /// <param name="nageur"></param>
        /// <param name="matériel"></param>
        public PretModel(int id, DateTime dateEmprunt, DateTime dateRetour, NageurModel nageur, MatérielClass matériel)
        {
            Id = id;
            DateEmprunt = dateEmprunt;
            DateRetour = dateRetour;
            Nageur = nageur;
            Matériel = matériel;
        }
    }
}