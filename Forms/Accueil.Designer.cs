﻿namespace GestionMatériel.Forms
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvMatériel = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MARQUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAILLE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SAISON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TYPEMONO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.POINTURE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvMatériel
            // 
            this.lvMatériel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.MARQUE,
            this.NOM,
            this.TAILLE,
            this.SAISON,
            this.TYPEMONO,
            this.POINTURE});
            this.lvMatériel.HideSelection = false;
            this.lvMatériel.Location = new System.Drawing.Point(142, 28);
            this.lvMatériel.Name = "lvMatériel";
            this.lvMatériel.Size = new System.Drawing.Size(688, 434);
            this.lvMatériel.TabIndex = 0;
            this.lvMatériel.UseCompatibleStateImageBehavior = false;
            this.lvMatériel.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // MARQUE
            // 
            this.MARQUE.DisplayIndex = 2;
            this.MARQUE.Text = "MARQUE";
            this.MARQUE.Width = 161;
            // 
            // NOM
            // 
            this.NOM.DisplayIndex = 1;
            this.NOM.Text = "NOM";
            this.NOM.Width = 88;
            // 
            // TAILLE
            // 
            this.TAILLE.Text = "TAILLE";
            this.TAILLE.Width = 83;
            // 
            // SAISON
            // 
            this.SAISON.Text = "SAISON";
            // 
            // TYPEMONO
            // 
            this.TYPEMONO.Text = "TYPEMONO";
            this.TYPEMONO.Width = 88;
            // 
            // POINTURE
            // 
            this.POINTURE.Text = "POINTURE";
            this.POINTURE.Width = 86;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 572);
            this.Controls.Add(this.lvMatériel);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMatériel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader MARQUE;
        private System.Windows.Forms.ColumnHeader TAILLE;
        private System.Windows.Forms.ColumnHeader SAISON;
        private System.Windows.Forms.ColumnHeader TYPEMONO;
        private System.Windows.Forms.ColumnHeader POINTURE;
    }
}