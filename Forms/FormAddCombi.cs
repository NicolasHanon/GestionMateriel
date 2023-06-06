using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMatériel.DataAccess;
using GestionMatériel.Models;

namespace GestionMatériel.Forms
{
    public partial class FormAddCombi : Form
    {
        public FormAddCombi()
        {
            InitializeComponent();
        }

        private void BTNAddCombi_Click(object sender, EventArgs e)
        {
            int id = 0;
            string nom = TboxNom.Text;
            string marque = TboxMarque.Text;
            string taille = TboxTaille.Text;
            string saison = TboxSaison.Text;
            
            try
            {
                DAOAddCombi.AjouterCombinaison(id, nom, marque, taille, saison);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }
    }
}
