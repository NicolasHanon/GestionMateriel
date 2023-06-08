using GestionMatériel.DataAccess;
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
    public partial class FormAddMono : Form
    {
        public FormAddMono()
        {
            InitializeComponent();
        }

        private void BTNAddMono_Click(object sender, EventArgs e)
        {
            string Nom = TboxNomMono.Text;
            string Marque = TboxMarqueMono.Text;
            string TypeMono = CboxTypeMono.Text;
            string Pointure = TboxPointureMono.Text;

            try
            {
                DAOMonopalme.AjouterMonopalme(Nom, Marque, TypeMono, Pointure);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }
    }

}
