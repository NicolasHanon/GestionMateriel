namespace GestionMatériel.Forms
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
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MARQUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAILLE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SAISON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TYPEMONO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.POINTURE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddMono = new System.Windows.Forms.Button();
            this.btnAddCombi = new System.Windows.Forms.Button();
            this.btnVoirPret = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMatériel
            // 
            this.lvMatériel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lvMatériel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NOM,
            this.MARQUE,
            this.TAILLE,
            this.SAISON,
            this.TYPEMONO,
            this.POINTURE});
            this.lvMatériel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMatériel.ForeColor = System.Drawing.SystemColors.Window;
            this.lvMatériel.HideSelection = false;
            this.lvMatériel.Location = new System.Drawing.Point(220, 110);
            this.lvMatériel.Name = "lvMatériel";
            this.lvMatériel.Size = new System.Drawing.Size(688, 434);
            this.lvMatériel.TabIndex = 0;
            this.lvMatériel.UseCompatibleStateImageBehavior = false;
            this.lvMatériel.View = System.Windows.Forms.View.Details;
            // 
            // NOM
            // 
            this.NOM.Text = "NOM";
            this.NOM.Width = 71;
            // 
            // MARQUE
            // 
            this.MARQUE.Text = "MARQUE";
            this.MARQUE.Width = 96;
            // 
            // TAILLE
            // 
            this.TAILLE.Text = "TAILLE";
            // 
            // SAISON
            // 
            this.SAISON.Text = "SAISON";
            // 
            // TYPEMONO
            // 
            this.TYPEMONO.Text = "TYPEMONO";
            this.TYPEMONO.Width = 107;
            // 
            // POINTURE
            // 
            this.POINTURE.Text = "POINTURE";
            this.POINTURE.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAddMono);
            this.panel1.Controls.Add(this.btnAddCombi);
            this.panel1.Controls.Add(this.btnVoirPret);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(0, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddMono
            // 
            this.btnAddMono.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMono.FlatAppearance.BorderSize = 0;
            this.btnAddMono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMono.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddMono.Location = new System.Drawing.Point(0, 228);
            this.btnAddMono.Name = "btnAddMono";
            this.btnAddMono.Size = new System.Drawing.Size(186, 42);
            this.btnAddMono.TabIndex = 2;
            this.btnAddMono.Text = "Ajouter une monopalme";
            this.btnAddMono.UseVisualStyleBackColor = true;
            this.btnAddMono.Click += new System.EventHandler(this.btnAddMono_Click);
            // 
            // btnAddCombi
            // 
            this.btnAddCombi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCombi.FlatAppearance.BorderSize = 0;
            this.btnAddCombi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCombi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCombi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddCombi.Location = new System.Drawing.Point(0, 186);
            this.btnAddCombi.Name = "btnAddCombi";
            this.btnAddCombi.Size = new System.Drawing.Size(186, 42);
            this.btnAddCombi.TabIndex = 2;
            this.btnAddCombi.Text = "Ajouter une combinaison";
            this.btnAddCombi.UseVisualStyleBackColor = true;
            this.btnAddCombi.Click += new System.EventHandler(this.btnAddCombi_Click);
            // 
            // btnVoirPret
            // 
            this.btnVoirPret.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVoirPret.FlatAppearance.BorderSize = 0;
            this.btnVoirPret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoirPret.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirPret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVoirPret.Location = new System.Drawing.Point(0, 144);
            this.btnVoirPret.Name = "btnVoirPret";
            this.btnVoirPret.Size = new System.Drawing.Size(186, 42);
            this.btnVoirPret.TabIndex = 2;
            this.btnVoirPret.Text = "Voir Pret";
            this.btnVoirPret.UseVisualStyleBackColor = true;
            this.btnVoirPret.Click += new System.EventHandler(this.btnVoirPret_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 2;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelStock.Location = new System.Drawing.Point(421, 29);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(263, 42);
            this.labelStock.TabIndex = 2;
            this.labelStock.Text = "Voir Les Stocks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionMatériel.Properties.Resources.logo_violet_petit;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvMatériel);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMatériel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoirPret;
        private System.Windows.Forms.Button btnAddMono;
        private System.Windows.Forms.Button btnAddCombi;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.ColumnHeader MARQUE;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader TAILLE;
        private System.Windows.Forms.ColumnHeader SAISON;
        private System.Windows.Forms.ColumnHeader TYPEMONO;
        private System.Windows.Forms.ColumnHeader POINTURE;
        private System.Windows.Forms.Button button1;
    }
}