using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMatériel.DataAccess;
using GestionMatériel.Models;

namespace GestionMatériel
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            List<MaterielClass> materiel = DAOMateriel.GetAllComptes(id);
        }
    }
}
