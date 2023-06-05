using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMatériel.Models;
using GestionMatériel.DataAccess;
using System.Data.SqlClient;
using System.Configuration;

namespace GestionMatériel.Forms
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            List<CombinaisonMatérielClass> materiels = DAOMatériel.GetAllStock();
            List<MonopalmeMatérielClass> materielsmono = DAOMatériel.GetAllStockmono();

            //On teste que la liste ne soit pas vide. Si elle est vide, c'est qu'il y a eu une erreur...
            if (materiels != null)
            {
                //On parcourt la liste de ClientModel
                foreach (CombinaisonMatérielClass materiel in materiels)
                {
                    if (materiel.Taille != "")
                    {
                        //On crée un tableau de chaines de caractères : une ligne contient les données d'un client
                        string[] row = { materiel.Id.ToString(), materiel.Nom, materiel.Marque, materiel.Taille, materiel.SaisonCombi, "", "" };
                        ListViewItem listViewItem = new ListViewItem(row);
                        //On ajoute la ligne dans la listeview
                        lvMatériel.Items.Add(listViewItem);
                    }
                }
            }
            if (materielsmono != null)
            {
                foreach (MonopalmeMatérielClass materielmono in materielsmono)
                {
                    if (materielmono.Type != "")
                    {
                        string[] row = { materielmono.Id.ToString(), materielmono.Nom, materielmono.Marque, "", "", materielmono.Type, materielmono.Pointure };
                        ListViewItem listViewItem = new ListViewItem(row);
                        lvMatériel.Items.Add(listViewItem);
                    }
                }
            }
        }
    }
}
