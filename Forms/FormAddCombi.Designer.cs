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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNAddCombi
            // 
            this.BTNAddCombi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAddCombi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.BTNAddCombi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MARQUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(43, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TAILLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(46, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SAISON";
            // 
            // FormAddCombi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(442, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TboxSaison);
            this.Controls.Add(this.TboxTaille);
            this.Controls.Add(this.TboxNom);
            this.Controls.Add(this.TboxMarque);
            this.Controls.Add(this.BTNAddCombi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}