namespace GestionMatériel.Forms
{
    partial class FormAddCombi
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
            this.BTNAddCombi = new System.Windows.Forms.Button();
            this.TboxMarque = new System.Windows.Forms.TextBox();
            this.TboxNom = new System.Windows.Forms.TextBox();
            this.TboxTaille = new System.Windows.Forms.TextBox();
            this.TboxSaison = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNAddCombi
            // 
            this.BTNAddCombi.Location = new System.Drawing.Point(270, 57);
            this.BTNAddCombi.Name = "BTNAddCombi";
            this.BTNAddCombi.Size = new System.Drawing.Size(129, 68);
            this.BTNAddCombi.TabIndex = 0;
            this.BTNAddCombi.Text = "Ajouter une combinaison";
            this.BTNAddCombi.UseVisualStyleBackColor = true;
            this.BTNAddCombi.Click += new System.EventHandler(this.BTNAddCombi_Click);
            // 
            // TboxMarque
            // 
            this.TboxMarque.Location = new System.Drawing.Point(46, 31);
            this.TboxMarque.Name = "TboxMarque";
            this.TboxMarque.Size = new System.Drawing.Size(175, 20);
            this.TboxMarque.TabIndex = 1;
            // 
            // TboxNom
            // 
            this.TboxNom.Location = new System.Drawing.Point(46, 67);
            this.TboxNom.Name = "TboxNom";
            this.TboxNom.Size = new System.Drawing.Size(175, 20);
            this.TboxNom.TabIndex = 2;
            // 
            // TboxTaille
            // 
            this.TboxTaille.Location = new System.Drawing.Point(46, 105);
            this.TboxTaille.Name = "TboxTaille";
            this.TboxTaille.Size = new System.Drawing.Size(175, 20);
            this.TboxTaille.TabIndex = 3;
            // 
            // TboxSaison
            // 
            this.TboxSaison.Location = new System.Drawing.Point(46, 146);
            this.TboxSaison.Name = "TboxSaison";
            this.TboxSaison.Size = new System.Drawing.Size(175, 20);
            this.TboxSaison.TabIndex = 4;
            // 
            // FormAddCombi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 193);
            this.Controls.Add(this.TboxSaison);
            this.Controls.Add(this.TboxTaille);
            this.Controls.Add(this.TboxNom);
            this.Controls.Add(this.TboxMarque);
            this.Controls.Add(this.BTNAddCombi);
            this.Name = "FormAddCombi";
            this.Text = "FormAddCombi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAddCombi;
        private System.Windows.Forms.TextBox TboxMarque;
        private System.Windows.Forms.TextBox TboxNom;
        private System.Windows.Forms.TextBox TboxTaille;
        private System.Windows.Forms.TextBox TboxSaison;
    }
}