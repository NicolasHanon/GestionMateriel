using GestionMatériel.DataAccess;
using GestionMatériel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatériel.Forms
{
    public partial class FormNageur : Form
    {
        public FormNageur()
        {
            InitializeComponent();
        }

        private void FormNageur_Load(object sender, EventArgs e)
        {
            List<NageurModel> nageurs = DAONageur.GetAllNageurs();

            //On teste que la liste ne soit pas vide. Si elle est vide, c'est qu'il y a eu une erreur...
            if (nageurs != null)
            {
                //On parcourt la liste de CombinaisonMatérielClass
                foreach (NageurModel nageur in nageurs)
                {
                     //On crée un tableau de chaines de caractères : une ligne contient les données d'un matériel
                     string[] row = { nageur.Id1.ToString(), nageur.Nom1, nageur.Prénom1, nageur.Mail1, nageur.Téléphone1 };
                     ListViewItem listViewItem = new ListViewItem(row);
                     //On ajoute la ligne dans la listeview
                     listView1.Items.Add(listViewItem);
                }
            }
        }
    }
}
