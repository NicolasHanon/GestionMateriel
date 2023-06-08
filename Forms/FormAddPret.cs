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
    public partial class FormAddPret : Form
    {
        public FormAddPret()
        {
            InitializeComponent();
        }

        private void AddPret_Click(object sender, EventArgs e)
        {
            DateTime DateEmp = DTdateEmp.Value;
            DateTime DateRet = DTdateRet.Value;
            string IDNag = TboxIdNag.Text;
            string IDMat = TboxIdMat.Text;

            try
            {
                DAOPret.AddPret(DateEmp, DateRet, IDNag, IDMat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }
    }
}
