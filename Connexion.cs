﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatériel
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "opif" && passwordBox.Text == "password")
            {
            
                Accueil accueil = new Accueil();
                accueil.Show();
                this.Hide();
            }
            else
            {
                labelAuth.Text = "Mauvais identifiants";
            }
        }
    }
}
