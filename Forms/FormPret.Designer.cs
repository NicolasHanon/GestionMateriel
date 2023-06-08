namespace GestionMatériel.Forms
{
    partial class FormPret
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
            this.components = new System.ComponentModel.Container();
            this.BTNVoirNageur = new System.Windows.Forms.Button();
            this.lvPret = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATE_EMPRUNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATE_RETOUR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MATERIEL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNRecup = new System.Windows.Forms.Button();
            this.BTNRefreshPret = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NUMRecup = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRecup)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNVoirNageur
            // 
            this.BTNVoirNageur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BTNVoirNageur.FlatAppearance.BorderSize = 0;
            this.BTNVoirNageur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNVoirNageur.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVoirNageur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTNVoirNageur.Location = new System.Drawing.Point(619, 223);
            this.BTNVoirNageur.Name = "BTNVoirNageur";
            this.BTNVoirNageur.Size = new System.Drawing.Size(167, 43);
            this.BTNVoirNageur.TabIndex = 0;
            this.BTNVoirNageur.Text = "Voir les nageurs";
            this.BTNVoirNageur.UseVisualStyleBackColor = false;
            this.BTNVoirNageur.Click += new System.EventHandler(this.BTNVoirNageur_Click);
            // 
            // lvPret
            // 
            this.lvPret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lvPret.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.DATE_EMPRUNT,
            this.DATE_RETOUR,
            this.NOM,
            this.MATERIEL});
            this.lvPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPret.ForeColor = System.Drawing.SystemColors.Window;
            this.lvPret.HideSelection = false;
            this.lvPret.Location = new System.Drawing.Point(27, 74);
            this.lvPret.Name = "lvPret";
            this.lvPret.Size = new System.Drawing.Size(563, 277);
            this.lvPret.TabIndex = 1;
            this.lvPret.UseCompatibleStateImageBehavior = false;
            this.lvPret.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 71;
            // 
            // DATE_EMPRUNT
            // 
            this.DATE_EMPRUNT.Text = "DATE_EMPRUNT";
            this.DATE_EMPRUNT.Width = 121;
            // 
            // DATE_RETOUR
            // 
            this.DATE_RETOUR.Text = "DATE_RETOUR";
            this.DATE_RETOUR.Width = 120;
            // 
            // NOM
            // 
            this.NOM.Text = "NOM";
            // 
            // MATERIEL
            // 
            this.MATERIEL.Text = "MATERIEL";
            this.MATERIEL.Width = 114;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(619, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter un pret";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(165, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste de tout les prets";
            // 
            // BTNRecup
            // 
            this.BTNRecup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BTNRecup.FlatAppearance.BorderSize = 0;
            this.BTNRecup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRecup.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNRecup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTNRecup.Location = new System.Drawing.Point(619, 85);
            this.BTNRecup.Name = "BTNRecup";
            this.BTNRecup.Size = new System.Drawing.Size(167, 43);
            this.BTNRecup.TabIndex = 4;
            this.BTNRecup.Text = "Récupérer";
            this.BTNRecup.UseVisualStyleBackColor = false;
            this.BTNRecup.Click += new System.EventHandler(this.BTNRecup_Click);
            // 
            // BTNRefreshPret
            // 
            this.BTNRefreshPret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BTNRefreshPret.FlatAppearance.BorderSize = 0;
            this.BTNRefreshPret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRefreshPret.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNRefreshPret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTNRefreshPret.Location = new System.Drawing.Point(619, 298);
            this.BTNRefreshPret.Name = "BTNRefreshPret";
            this.BTNRefreshPret.Size = new System.Drawing.Size(167, 43);
            this.BTNRefreshPret.TabIndex = 5;
            this.BTNRefreshPret.Text = "Refresh";
            this.BTNRefreshPret.UseVisualStyleBackColor = false;
            this.BTNRefreshPret.Click += new System.EventHandler(this.BTNRefreshPret_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NUMRecup
            // 
            this.NUMRecup.Location = new System.Drawing.Point(619, 46);
            this.NUMRecup.Name = "NUMRecup";
            this.NUMRecup.Size = new System.Drawing.Size(167, 20);
            this.NUMRecup.TabIndex = 7;
            // 
            // FormPret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(823, 378);
            this.Controls.Add(this.NUMRecup);
            this.Controls.Add(this.BTNRefreshPret);
            this.Controls.Add(this.BTNRecup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvPret);
            this.Controls.Add(this.BTNVoirNageur);
            this.Name = "FormPret";
            this.Text = "FormPret";
            this.Load += new System.EventHandler(this.FormPret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUMRecup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNVoirNageur;
        private System.Windows.Forms.ListView lvPret;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader DATE_EMPRUNT;
        private System.Windows.Forms.ColumnHeader DATE_RETOUR;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader MATERIEL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNRecup;
        private System.Windows.Forms.Button BTNRefreshPret;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown NUMRecup;
    }
}