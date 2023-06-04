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
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MARQUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAILLE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMatériel
            // 
            this.lvMatériel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.MARQUE,
            this.NOM,
            this.TAILLE});
            this.lvMatériel.HideSelection = false;
            this.lvMatériel.Location = new System.Drawing.Point(142, 28);
            this.lvMatériel.Name = "lvMatériel";
            this.lvMatériel.Size = new System.Drawing.Size(559, 107);
            this.lvMatériel.TabIndex = 0;
            this.lvMatériel.UseCompatibleStateImageBehavior = false;
            this.lvMatériel.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // MARQUE
            // 
            this.MARQUE.DisplayIndex = 2;
            this.MARQUE.Text = "MARQUE";
            // 
            // NOM
            // 
            this.NOM.DisplayIndex = 1;
            this.NOM.Text = "NOM";
            // 
            // TAILLE
            // 
            this.TAILLE.Text = "TAILLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1018, 335);
            this.dataGridView1.TabIndex = 1;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lvMatériel);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMatériel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader MARQUE;
        private System.Windows.Forms.ColumnHeader TAILLE;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}