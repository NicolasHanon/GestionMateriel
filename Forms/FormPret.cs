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
    public partial class FormPret : Form
    {
        public FormPret()
        {
            InitializeComponent();
        }
        private void FormPret_Load(object sender, EventArgs e)
        {
            List<PretModel> prets = DAOPret.GetAllPrets();

            //On teste que la liste ne soit pas vide. Si elle est vide, c'est qu'il y a eu une erreur...
            if (prets != null)
            {
                //On parcourt la liste de PretModel
                foreach (PretModel pret in prets)
                {
                    //On crée un tableau de chaines de caractères : une ligne contient les données d'un pret
                    string[] row = { pret.Id.ToString(), pret.DateEmprunt.ToString(), pret.DateRetour.ToString(), pret.Nageur.Nom1, pret.Matériel.Nom };
                    ListViewItem listViewItem = new ListViewItem(row);
                    //On ajoute la ligne dans la listeview
                    lvPret.Items.Add(listViewItem);
                }
            }
        }
        private void BTNVoirNageur_Click(object sender, EventArgs e)
        {
            FormNageur formNageur = new FormNageur();
            formNageur.Show();
        }
    }
}
